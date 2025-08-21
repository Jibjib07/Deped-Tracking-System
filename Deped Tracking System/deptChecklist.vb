Imports System.Data.OleDb

Public Class deptChecklist


    Private Async Sub deptChecklist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadDocumentsAsync()
        Await LoadPendingAsync()
    End Sub



    'Documents RECIEVED
    Private Async Function LoadDocumentsAsync() As Task
        flpChecklist.Controls.Clear()
        Dim dt As New DataTable()

        ' Run database query in background
        Await Task.Run(Sub()
                           Using con As New OleDbConnection(conString)
                               con.Open()
                               Dim query As String = "
                               SELECT control_num, title, client_name, sender_name,
                                      date_created, date_lastmodified, previous_department, status
                               FROM Documents 
                               WHERE status <> 'Sent';"

                               Using cmd As New OleDbCommand(query, con)
                                   Using adapter As New OleDbDataAdapter(cmd)
                                       adapter.Fill(dt)
                                   End Using
                               End Using
                           End Using
                       End Sub)

        ' Back to UI thread → add controls safely
        flpChecklist.SuspendLayout()
        For Each row As DataRow In dt.Rows
            Dim card As New creativeChecklist With {
            .ControlNum = row("control_num").ToString(),
            .Title = row("title").ToString(),
            .ClientName = row("client_name").ToString(),
            .SenderName = row("sender_name").ToString(),
            .Status = row("status").ToString(),
            .PreviousDept = row("previous_department").ToString()
        }

            If Not IsDBNull(row("date_created")) Then
                card.DateCreated = CDate(row("date_created")).ToShortDateString()
            End If
            If Not IsDBNull(row("date_lastmodified")) Then
                card.DateModified = CDate(row("date_lastmodified")).ToShortDateString()
            End If

            flpChecklist.Controls.Add(card)
        Next
        flpChecklist.ResumeLayout()
    End Function

    Private Async Function LoadPendingAsync() As Task
        flpPending.Controls.Clear()
        Dim dt As New DataTable()

        ' Run database query in background
        Await Task.Run(Sub()
                           Using con As New OleDbConnection(conString)
                               con.Open()
                           Dim query As String = "
                               SELECT control_num, 
                                      title, 
                                      user_name, 
                                      client_name, 
                                      sender_name, 
                                      date_created, 
                                      date_lastmodified, 
                                      previous_department, 
                                      status
                               FROM Documents
                               WHERE status = 'Sent';"

                               Using cmd As New OleDbCommand(query, con)
                                   Using adapter As New OleDbDataAdapter(cmd)
                                       adapter.Fill(dt)
                                   End Using
                               End Using
                           End Using
                       End Sub)

        ' Back to UI thread → add controls safely
        flpPending.SuspendLayout()
        For Each row As DataRow In dt.Rows
            Dim card As New creativePending With {
                .ControlNum = row("control_num").ToString(),
                .Title = row("title").ToString(),
                .ClientName = row("client_name").ToString(),
                .SenderName = row("sender_name").ToString(),
                .Status = row("status").ToString(),
                .PreviousDept = row("previous_department").ToString()
            }

            If Not IsDBNull(row("date_lastmodified")) Then
                card.DateModified = CDate(row("date_lastmodified")).ToShortDateString()
            End If

            flpPending.Controls.Add(card)
        Next
        flpPending.ResumeLayout()
    End Function

End Class
