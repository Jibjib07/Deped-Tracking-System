Imports System.Data.OleDb

Public Class deptChecklist


    Private Sub deptChecklist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDocuments()
        LoadPending()
    End Sub


    'Documents RECIEVED
    Private Sub LoadDocuments()
        flpChecklist.Controls.Clear()
        Try
            con.Open()

            Dim query As String = "SELECT control_num, title, user_name, 
                              client_name, sender_name, date_created, date_lastmodified, 
                              previous_department, status
                       FROM Documents 
                       WHERE status <> 'Sent';"
            Dim cmd As New OleDbCommand(query, con)
            Dim adapter As New OleDbDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            ' 🔹 Loop rows, create cards
            For Each row As DataRow In dt.Rows
                Dim card As New creativeChecklist()

                card.ControlNum = row("control_num").ToString()
                card.Title = row("title").ToString()
                card.ClientName = row("client_name").ToString()
                card.SenderName = row("sender_name").ToString()
                card.Status = row("status").ToString()

                If Not IsDBNull(row("date_created")) Then
                    card.DateCreated = CDate(row("date_created")).ToShortDateString()
                End If

                If Not IsDBNull(row("date_lastmodified")) Then
                    card.DateModified = CDate(row("date_lastmodified")).ToShortDateString()
                End If

                card.PreviousDept = row("previous_department").ToString()



                ' 🔹 Add card to FlowLayoutPanel
                flpChecklist.Controls.Add(card)
            Next

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub LoadPending()
        flpPending.Controls.Clear()
        Try
            con.Open()

            Dim query As String =
            "SELECT control_num, 
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
            Dim cmd As New OleDbCommand(query, con)
            Dim adapter As New OleDbDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            ' 🔹 Loop rows, create cards
            For Each row As DataRow In dt.Rows
                Dim card As New creativePending()

                card.ControlNum = row("control_num").ToString()
                card.Title = row("title").ToString()
                card.ClientName = row("client_name").ToString()
                card.SenderName = row("sender_name").ToString()
                card.Status = row("status").ToString()

                If Not IsDBNull(row("date_lastmodified")) Then
                    card.DateModified = CDate(row("date_lastmodified")).ToShortDateString()
                End If

                card.PreviousDept = row("previous_department").ToString()

                ' 🔹 Add card to FlowLayoutPanel
                flpPending.Controls.Add(card)
            Next

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        deptCreate.Show()
    End Sub
End Class
