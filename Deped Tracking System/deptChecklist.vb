Imports System.Data.OleDb

Public Class deptChecklist


    Private Async Sub deptChecklist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load Pending and Checklist
        Await LoadDocumentsAsync()
        Await LoadPendingAsync()
    End Sub

    'Checklist
    Private Async Function LoadDocumentsAsync() As Task
        flpChecklist.Controls.Clear()
        Dim dt As New DataTable()

        Await Task.Run(Sub()
                           Using con As New OleDbConnection(conString)
                               con.Open()
                               Dim query As String = "
                               SELECT control_num, 
                                      title, 
                                      client_name, 
                                      sender_name,
                                      date_created, 
                                      date_lastmodified, 
                                      previous_department, 
                                      status
                               FROM Documents 
                               WHERE status <> 'Sent';"

                               Using cmd As New OleDbCommand(query, con)
                                   Using adapter As New OleDbDataAdapter(cmd)
                                       adapter.Fill(dt)
                                   End Using
                               End Using
                           End Using
                       End Sub)

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

    'Pending
    Private Async Function LoadPendingAsync() As Task
        flpPending.Controls.Clear()
        Dim dt As New DataTable()

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

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim searchText As String = txtSearch.Text.Trim().ToLower()

        If searchText = "" Then
            ' ✅ Show all cards again when search is empty
            For Each ctrl As Control In flpChecklist.Controls
                If TypeOf ctrl Is creativeChecklist Then
                    ctrl.Visible = True
                End If
            Next
            Exit Sub
        End If

        ' ✅ Filter cards
        For Each ctrl As Control In flpChecklist.Controls
            If TypeOf ctrl Is creativeChecklist Then
                Dim card As creativeChecklist = DirectCast(ctrl, creativeChecklist)

                If card.ControlNum.ToLower().Contains(searchText) OrElse
                   card.ClientName.ToLower().Contains(searchText) Then
                    card.Visible = True
                Else
                    card.Visible = False
                End If
            End If
        Next
    End Sub
    Private Sub deptChecklist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSearch.Text = ""
        LoadDocumentsAsync()
    End Sub

End Class
