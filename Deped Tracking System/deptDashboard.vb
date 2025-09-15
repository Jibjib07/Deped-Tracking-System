Imports MySql.Data.MySqlClient
Public Class deptDashboard

    Private Async Sub deptDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        Await LoadDashboardCounters()
    End Sub
    Public Async Function LoadDashboardCounters() As Task
        Dim query As String = "
        SELECT 
            H.control_num,
            H.remarks,
            H.user_action
        FROM History AS H
        INNER JOIN Documents AS D 
            ON H.control_num = D.control_num
        WHERE H.History_ID = (
            SELECT H2.History_ID
            FROM History H2
            WHERE H2.control_num = H.control_num
            ORDER BY H2.date_action DESC, H2.History_ID DESC
            LIMIT 1
        )
        AND (H.from_department = @deptName OR H.to_department = @deptName);"

        Dim activeCount As Integer = 0
        Dim completeCount As Integer = 0
        Dim pendingCount As Integer = 0
        Dim receivedCount As Integer = 0

        Using con As New MySqlConnection(conString)
            Await con.OpenAsync()
            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@deptName", GetDepartmentName(sysModule.userUID.ToString()))

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

        lblActive.Text = activeCount.ToString()
        lblCompleted.Text = completeCount.ToString()
        lblPending.Text = pendingCount.ToString()
        lblReceived.Text = receivedCount.ToString()

        ' Update pie with actual data
        UpdatePie(activeCount, completeCount)

    End Function

    Private Function GetDepartmentName(userId As String) As String
        Dim deptName As String = String.Empty
        Using con As New MySqlConnection(conString)
            con.Open()
            Dim query As String = "SELECT department_name FROM Users WHERE user_id = @user_id"
            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@user_id", userId)
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    deptName = result.ToString()
                End If
            End Using
        End Using
        Return deptName
    End Function


    Private pieSegments As New List(Of Tuple(Of Single, Color))

    Private Sub UpdatePie(activeCount As Integer, completeCount As Integer)
        pieSegments.Clear()

        Dim total As Integer = activeCount + completeCount
        If total = 0 Then
            ' avoid divide by zero → fill with 100% gray
            pieSegments.Add(Tuple.Create(100.0F, Color.FromArgb(200, 200, 200)))
        Else
            pieSegments.Add(Tuple.Create(CSng(activeCount) / CSng(total) * 100.0F, Color.FromArgb(96, 96, 96)))      ' Active
            pieSegments.Add(Tuple.Create(CSng(completeCount) / CSng(total) * 100.0F, Color.FromArgb(202, 202, 202)))    ' Completed

        End If

        pbPie.Invalidate() ' redraw
    End Sub


    Private Sub pbPie_Paint(sender As Object, e As PaintEventArgs) Handles pbPie.Paint
        Dim rect As Rectangle = pbPie.ClientRectangle
        Dim startAngle As Single = -90

        Dim categories() As String = {"Active", "Completed"}
        Dim i As Integer = 0

        For Each seg In pieSegments
            If seg.Item1 > 0 Then ' ✅ Only draw if percentage > 0
                Dim sweep As Single = seg.Item1 / 100.0F * 360.0F

                ' Draw slice
                Using brush As New SolidBrush(seg.Item2)
                    e.Graphics.FillPie(brush, rect, startAngle, sweep)
                End Using

                ' Draw label at slice center
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