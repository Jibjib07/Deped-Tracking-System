Imports MySql.Data.MySqlClient

Public Class deptDashboard

    Private Async Sub deptDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadDashboardCounters()
    End Sub

    Public Async Function LoadDashboardCounters() As Task
        Dim activeCount As Integer = 0
        Dim completeCount As Integer = 0
        Dim pendingCount As Integer = 0
        Dim receivedCount As Integer = 0

        Dim deptName As String = sysModule.userDept ' ✅ use from login/session, no extra query

        Dim sql As String = "
            SELECT h.control_num, h.user_action, h.remarks
            FROM History h
            INNER JOIN (
                SELECT control_num, MAX(History_ID) AS maxHID
                FROM History
                GROUP BY control_num
            ) x ON h.control_num = x.control_num AND h.History_ID = x.maxHID
            WHERE h.to_department = @deptName;
        "

        Using con As New MySqlConnection(conString)
            Await con.OpenAsync()
            Using cmd As New MySqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@deptName", deptName)

                Using reader As MySqlDataReader = Await cmd.ExecuteReaderAsync()
                    While Await reader.ReadAsync()
                        Dim remarks As String = reader("remarks").ToString().ToLower()
                        Dim action As String = reader("user_action").ToString().ToLower()

                        If remarks = "active" Then
                            activeCount += 1
                        ElseIf remarks = "completed" Then
                            completeCount += 1
                        End If

                        If action = "sent" Then
                            pendingCount += 1
                        ElseIf action = "received" Then
                            receivedCount += 1
                        End If
                    End While
                End Using
            End Using
        End Using

        ' Update labels
        lblActive.Text = activeCount.ToString()
        lblCompleted.Text = completeCount.ToString()
        lblPending.Text = pendingCount.ToString()
        lblReceived.Text = receivedCount.ToString()

        ' Update pie chart
        UpdatePie(activeCount, completeCount)
    End Function

    ' === PIE GRAPH HANDLING ===
    Private pieSegments As New List(Of Tuple(Of Single, Color))

    Private Sub UpdatePie(activeCount As Integer, completeCount As Integer)
        pieSegments.Clear()

        Dim total As Integer = activeCount + completeCount
        If total = 0 Then
            ' avoid divide by zero → fill with gray
            pieSegments.Add(Tuple.Create(100.0F, Color.FromArgb(200, 200, 200)))
        Else
            pieSegments.Add(Tuple.Create(CSng(activeCount) / CSng(total) * 100.0F, Color.FromArgb(96, 96, 96)))      ' Active
            pieSegments.Add(Tuple.Create(CSng(completeCount) / CSng(total) * 100.0F, Color.FromArgb(202, 202, 202))) ' Completed
        End If

        pbPie.Invalidate() ' redraw
    End Sub

    Private Sub pbPie_Paint(sender As Object, e As PaintEventArgs) Handles pbPie.Paint
        Dim rect As Rectangle = pbPie.ClientRectangle
        Dim startAngle As Single = -90

        Dim categories() As String = {"Active", "Completed"}
        Dim i As Integer = 0

        For Each seg In pieSegments
            If seg.Item1 > 0 Then
                Dim sweep As Single = seg.Item1 / 100.0F * 360.0F

                Using brush As New SolidBrush(seg.Item2)
                    e.Graphics.FillPie(brush, rect, startAngle, sweep)
                End Using

                ' Draw labels
                Dim midAngle As Double = (startAngle + sweep / 2) * Math.PI / 180
                Dim radius As Single = rect.Width / 4
                Dim labelX As Single = rect.X + rect.Width / 2 + CSng(Math.Cos(midAngle) * radius)
                Dim labelY As Single = rect.Y + rect.Height / 2 + CSng(Math.Sin(midAngle) * radius)

                Using font As New Font("Century Gothic", 11, FontStyle.Bold)
                    Dim text As String = categories(i)
                    Dim textSize As SizeF = e.Graphics.MeasureString(text, font)
                    e.Graphics.DrawString(text, font, Brushes.Black, labelX - textSize.Width / 2, labelY - textSize.Height / 2)
                End Using

                startAngle += sweep
            End If
            i += 1
        Next
    End Sub

End Class
