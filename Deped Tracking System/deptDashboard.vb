Imports System.Numerics
Imports System.Windows.Data
Imports MySql.Data.MySqlClient

Public Class deptDashboard

    Private Async Sub deptDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadDashboardCounters()
        Await LoadReceivedData()
    End Sub

    Public Async Function LoadDashboardCounters() As Task
        Dim activeCount As Integer = 0
        Dim completeCount As Integer = 0
        Dim pendingCount As Integer = 0
        Dim receivedCount As Integer = 0

        Dim deptName As String = sysModule.userDept

        Using con As New MySqlConnection(conString)
            Await con.OpenAsync()

            Dim sqlPending As String = "
            SELECT h.user_action
            FROM History h
            INNER JOIN (
                SELECT control_num, MAX(History_ID) AS maxHID
                FROM History
                GROUP BY control_num
            ) x ON h.control_num = x.control_num AND h.History_ID = x.maxHID
            WHERE h.to_department = @deptName;
        "

            Using cmd As New MySqlCommand(sqlPending, con)
                cmd.Parameters.AddWithValue("@deptName", deptName)
                Using reader As MySqlDataReader = Await cmd.ExecuteReaderAsync()
                    While Await reader.ReadAsync()
                        Dim action As String = reader("user_action").ToString().ToLower()
                        If action = "sent" Then
                            pendingCount += 1
                        ElseIf action = "received" Then
                            receivedCount += 1
                        End If
                    End While
                End Using
            End Using

            Dim sqlStatus As String = "
            SELECT h.remarks
            FROM History h
            INNER JOIN (
                SELECT control_num, MAX(History_ID) AS maxHID
                FROM History
                GROUP BY control_num
            ) x ON h.control_num = x.control_num AND h.History_ID = x.maxHID
            WHERE EXISTS (
                SELECT 1 FROM History h2
                WHERE h2.control_num = h.control_num
                  AND (h2.from_department = @deptName OR h2.to_department = @deptName)
            );
        "

            Using cmd As New MySqlCommand(sqlStatus, con)
                cmd.Parameters.AddWithValue("@deptName", deptName)
                Using reader As MySqlDataReader = Await cmd.ExecuteReaderAsync()
                    While Await reader.ReadAsync()
                        Dim remarks As String = reader("remarks").ToString().ToLower()
                        If remarks = "active" Then
                            activeCount += 1
                        ElseIf remarks = "completed" Then
                            completeCount += 1
                        End If
                    End While
                End Using
            End Using
        End Using

        lblActive.Text = activeCount.ToString()
        lblCompleted.Text = completeCount.ToString()
        lblPending.Text = pendingCount.ToString()
        lblReceived.Text = receivedCount.ToString()

        UpdatePie(activeCount, completeCount)
    End Function

    ' percentage, startColor, endColor, count
    Private pieSegments As New List(Of Tuple(Of Single, Color, Color, Integer))()

    Private Sub UpdatePie(activeCount As Integer, completeCount As Integer)
        pieSegments.Clear()

        Dim total As Integer = activeCount + completeCount
        If total = 0 Then
            pieSegments.Add(Tuple.Create(100.0F,
                                     Color.FromArgb(200, 200, 200),
                                     Color.FromArgb(240, 240, 240),
                                     0))
        Else
            Dim activePct As Single = CSng(activeCount) / CSng(total) * 100.0F
            Dim completePct As Single = CSng(completeCount) / CSng(total) * 100.0F

            pieSegments.Add(Tuple.Create(activePct,
                                     Color.FromArgb(37, 99, 235),
                                     Color.FromArgb(147, 197, 253),
                                     activeCount)) ' blue gradient

            pieSegments.Add(Tuple.Create(completePct,
                                     Color.FromArgb(36, 35, 34),
                                     Color.FromArgb(120, 120, 120),
                                     completeCount)) ' gray gradient
        End If

        pbPie.Invalidate()
    End Sub

    Private Sub pbPie_Paint(sender As Object, e As PaintEventArgs) Handles pbPie.Paint
        Dim rect As Rectangle = pbPie.ClientRectangle
        Dim startAngle As Single = -90

        Dim categories() As String = {"Active", "Completed"}
        Dim i As Integer = 0

        For Each seg In pieSegments
            If seg.Item1 > 0 Then
                Dim sweep As Single = seg.Item1 / 100.0F * 360.0F

                Using brush As New Drawing2D.LinearGradientBrush(rect, seg.Item2, seg.Item3, Drawing2D.LinearGradientMode.ForwardDiagonal)
                    e.Graphics.FillPie(brush, rect, startAngle, sweep)
                End Using

                Using pen As New Pen(Color.White, 2)
                    e.Graphics.DrawPie(pen, rect, startAngle, sweep)
                End Using

                Dim midAngle As Double = (startAngle + sweep / 2) * Math.PI / 180
                Dim radius As Single = rect.Width / 4
                Dim labelX As Single = rect.X + rect.Width / 2 + CSng(Math.Cos(midAngle) * radius)
                Dim labelY As Single = rect.Y + rect.Height / 2 + CSng(Math.Sin(midAngle) * radius)

                Using font As New Font("Century Gothic", 11, FontStyle.Bold)
                    Dim text As String = $"{categories(i)} ({seg.Item4})"
                    Dim textSize As SizeF = e.Graphics.MeasureString(text, font)
                    e.Graphics.DrawString(text, font, Brushes.White, labelX - textSize.Width / 2, labelY - textSize.Height / 2)
                End Using

                startAngle += sweep
            End If
            i += 1
        Next
    End Sub


    Private receivedData As New Dictionary(Of Date, Integer)

    Public Async Function LoadReceivedData() As Task
        receivedData.Clear()

        For i As Integer = 0 To 4
            Dim d As Date = Date.Today.AddDays(-i)
            receivedData(d) = 0
        Next

        Using con As New MySqlConnection(conString)
            Await con.OpenAsync()

            Dim sqlReceived As String = "
    SELECT DATE(h.date_action) AS date_action, COUNT(*) AS total
    FROM History h
    WHERE h.to_department = @deptName
      AND h.user_action = 'received'
      AND DATE(h.date_action) >= CURDATE() - INTERVAL 4 DAY
    GROUP BY DATE(h.date_action)
    ORDER BY date_action ASC;
"

            Using cmd As New MySqlCommand(sqlReceived, con)
                cmd.Parameters.AddWithValue("@deptName", sysModule.userDept)
                Using reader As MySqlDataReader = Await cmd.ExecuteReaderAsync()
                    While Await reader.ReadAsync()
                        Dim d As Date = Convert.ToDateTime(reader("date_action"))
                        Dim count As Integer = Convert.ToInt32(reader("total"))
                        If receivedData.ContainsKey(d) Then
                            receivedData(d) = count
                        End If
                    End While
                End Using
            End Using

        End Using

        pbBar.Invalidate()
    End Function

    Private Sub pbBar_Paint(sender As Object, e As PaintEventArgs) Handles pbBar.Paint
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        If receivedData.Count = 0 Then
            Using font As New Font("Century Gothic", 12, FontStyle.Bold)
                Dim msg As String = "No data available"
                Dim textSize As SizeF = g.MeasureString(msg, font)
                g.DrawString(msg, font, Brushes.Gray, (pbBar.Width - textSize.Width) / 2, (pbBar.Height - textSize.Height) / 2)
            End Using
            Return
        End If

        Dim chartRect As Rectangle = pbBar.ClientRectangle
        Dim margin As Integer = 50
        Dim chartHeight As Integer = chartRect.Height - margin * 2
        Dim chartWidth As Integer = chartRect.Width - margin * 2

        Dim categories() As String = receivedData.Keys.OrderBy(Function(d) d).Select(Function(d) d.ToString("MM/dd")).ToArray()
        Dim values() As Integer = receivedData.OrderBy(Function(kv) kv.Key).Select(Function(kv) kv.Value).ToArray()
        Dim colors() As Color = Enumerable.Repeat(Color.FromArgb(124, 58, 237), values.Length).ToArray()

        Dim maxVal As Integer = values.Max()
        If maxVal = 0 Then maxVal = 1
        Dim stepSize As Integer = 5
        If maxVal > 20 Then stepSize = 10
        maxVal = Math.Ceiling(maxVal / stepSize) * stepSize

        ' Y-axis gridlines
        For yVal As Integer = 0 To maxVal Step stepSize
            Dim y As Integer = chartRect.Height - margin - CInt((yVal / maxVal) * chartHeight)

            Using gridPen As New Pen(Color.LightGray, 1)
                g.DrawLine(gridPen, margin, y, chartRect.Width - margin, y)
            End Using

            Using font As New Font("Century Gothic", 9)
                Dim text As String = yVal.ToString()
                Dim textSize As SizeF = g.MeasureString(text, font)
                g.DrawString(text, font, Brushes.Black, margin - textSize.Width - 5, y - textSize.Height / 2)
            End Using
        Next

        Dim barWidth As Integer = chartWidth \ (values.Length * 2)
        Dim spacing As Integer = barWidth

        For i As Integer = 0 To values.Length - 1
            Dim barHeight As Integer = CInt((values(i) / maxVal) * chartHeight)
            Dim x As Integer = margin + (i * (barWidth + spacing)) + spacing
            Dim y As Integer = chartRect.Height - margin - barHeight

            Using brush As New SolidBrush(colors(i))
                g.FillRectangle(brush, x, y, barWidth, barHeight)
            End Using

            Using pen As New Pen(Color.White, 2)
                g.DrawRectangle(pen, x, y, barWidth, barHeight)
            End Using

            Using font As New Font("Century Gothic", 10, FontStyle.Bold)
                Dim valueText As String = values(i).ToString()
                Dim textSize As SizeF = g.MeasureString(valueText, font)
                g.DrawString(valueText, font, Brushes.Black, x + (barWidth - textSize.Width) / 2, y - textSize.Height - 2)
            End Using

            Using font As New Font("Century Gothic", 10, FontStyle.Regular)
                Dim labelText As String = categories(i)
                Dim textSize As SizeF = g.MeasureString(labelText, font)
                g.DrawString(labelText, font, Brushes.Black, x + (barWidth - textSize.Width) / 2, chartRect.Height - margin + 5)
            End Using
        Next

        Using axisPen As New Pen(Color.Black, 2)
            g.DrawLine(axisPen, margin, chartRect.Height - margin, chartRect.Width - margin, chartRect.Height - margin)
        End Using

        Using font As New Font("Century Gothic", 12, FontStyle.Bold)
            Dim title As String = "Received Documents (Past 5 Days)"
            Dim textSize As SizeF = g.MeasureString(title, font)
            g.DrawString(title, font, Brushes.Black, (pbBar.Width - textSize.Width) / 2, 10)
        End Using
    End Sub

End Class
