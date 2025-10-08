Imports MySql.Data.MySqlClient
Imports System.Net.Mail

Public Class deptSend
    Private SelectedCards As List(Of creativeChecklist)
    Public Event TransactionCompleted()

    Public Sub New(cards As List(Of creativeChecklist))
        InitializeComponent()
        SelectedCards = cards
    End Sub

    Private Sub deptSend_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvSelected.Columns.Clear()
        dgvSelected.Rows.Clear()

        dgvSelected.Columns.Add("ControlNum", "Control Number")
        dgvSelected.Columns.Add("Title", "Title")
        dgvSelected.Columns.Add("Email", "Email")
        dgvSelected.Columns.Add("CurrentDept", "Current Department")

        For Each card In SelectedCards
            Dim email As String = GetEmailByControlNum(card.ControlNum)
            Dim currDept As String = GetCurrentDepartment(card.ControlNum)

            dgvSelected.Rows.Add(card.ControlNum, card.Title, email, currDept)
        Next

        LoadDepartments()
    End Sub

    Private Sub LoadDepartments()
        cmbDepartment.Items.Clear()

        Using con As New MySqlConnection(conString)
            con.Open()
            Dim query As String = "SELECT department_name FROM Departments ORDER BY department_name"
            Using cmd As New MySqlCommand(query, con)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        cmbDepartment.Items.Add(reader("department_name").ToString())
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Function GetCurrentDepartment(controlNum As String) As String
        Dim dept As String = ""
        Using con As New MySqlConnection(conString)
            con.Open()
            Dim query As String = "SELECT current_department FROM Documents WHERE control_num = @control_num"
            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@control_num", controlNum)
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing Then dept = result.ToString()
            End Using
        End Using
        Return dept
    End Function

    Private Function GetEmailByControlNum(controlNum As String) As String
        Dim email As String = ""

        Try
            Using con As New MySqlConnection(conString)
                con.Open()

                Dim query As String = "SELECT client_email FROM Documents WHERE control_num = @controlNum"
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@controlNum", controlNum)

                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        email = result.ToString()
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error fetching email: " & ex.Message)
        End Try

        Return email
    End Function

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        If cmbDepartment.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a department.")
            Exit Sub
        End If

        Dim targetDept As String = cmbDepartment.SelectedItem.ToString()

        ' ✅ Build simple confirmation message
        Dim confirmMsg As String = "The following document/s will be sent to: " & targetDept & vbCrLf & vbCrLf

        For Each row As DataGridViewRow In dgvSelected.Rows
            If Not row.IsNewRow Then
                Dim controlNum As String = row.Cells("ControlNum").Value.ToString()
                Dim title As String = row.Cells("Title").Value.ToString()
                confirmMsg &= "- [" & controlNum & "] " & title & vbCrLf
            End If
        Next

        confirmMsg &= vbCrLf & "Do you want to proceed?"

        ' ✅ Show confirmation box
        Dim result As DialogResult = MessageBox.Show(confirmMsg, "Confirm Send", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.No Then
            Exit Sub
        End If

        ' 🔽 Continue with sending if confirmed
        Dim emailQueue As New List(Of Tuple(Of String, String, String, String, String))

        Using con As New MySqlConnection(conString)
            con.Open()

            For Each row As DataGridViewRow In dgvSelected.Rows
                If Not row.IsNewRow Then
                    Dim controlNum As String = row.Cells("ControlNum").Value.ToString()
                    Dim title As String = row.Cells("Title").Value.ToString()
                    Dim email As String = If(row.Cells("Email").Value IsNot Nothing, row.Cells("Email").Value.ToString(), "").Trim()
                    Dim currentDept As String = row.Cells("CurrentDept").Value.ToString()

                    Dim query As String = "
                    UPDATE Documents 
                    SET sender_name = @user_name, 
                        previous_department = current_department, 
                        current_department = @newDept, 
                        status = @status, 
                        date_lastmodified = @date_lastmodified
                    WHERE control_num = @controlNum
                "

                    Using cmd As New MySqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@user_name", userName)
                        cmd.Parameters.AddWithValue("@newDept", targetDept)
                        cmd.Parameters.AddWithValue("@status", "Sent")
                        cmd.Parameters.AddWithValue("@date_lastmodified", Date.Today)
                        cmd.Parameters.AddWithValue("@controlNum", controlNum)
                        cmd.ExecuteNonQuery()
                    End Using

                    Dim insertQuery As String = "
                    INSERT INTO History 
                    (control_num, title, client_name, from_department, to_department, user_action, user_id, action_name, remarks, date_action)
                    SELECT control_num, title, client_name, previous_department, current_department, 'Sent', @user_id, @action_name, 'Active', @date_action
                    FROM Documents WHERE control_num = @controlNum
                "

                    Using insertCmd As New MySqlCommand(insertQuery, con)
                        insertCmd.Parameters.AddWithValue("@user_id", userUID)
                        insertCmd.Parameters.AddWithValue("@action_name", userName)
                        insertCmd.Parameters.AddWithValue("@date_action", Date.Today)
                        insertCmd.Parameters.AddWithValue("@controlNum", controlNum)
                        insertCmd.ExecuteNonQuery()
                    End Using

                    If Not String.IsNullOrEmpty(email) Then
                        emailQueue.Add(Tuple.Create(email, title, controlNum, currentDept, targetDept))
                    End If
                End If
            Next
        End Using

        For Each item In emailQueue
            SendEmail(item.Item1, item.Item2, item.Item3, item.Item4, item.Item5)
        Next

        MessageBox.Show("Transaction(s) sent successfully.")
        RaiseEvent TransactionCompleted()
        Me.Close()
    End Sub


    ' Reusable email sender
    Private Sub SendEmail(recipient As String, title As String, controlNum As String, currentDept As String, targetDept As String)
        Try
            Dim senderEmail As String = "depedsystem@gmail.com"
            Dim senderPassword As String = "zvej jhck lbxn izwo"

            Dim formattedMessage As String =
$"Good day," & vbCrLf & vbCrLf &
$"This is to formally inform you that your transaction titled '{title}', " &
$"with Control Number {controlNum}, has been successfully forwarded " &
$"from the {currentDept} Department to the {targetDept} Department." & vbCrLf & vbCrLf &
$"Thank you for your continued cooperation." & vbCrLf & vbCrLf &
$"Sincerely," & vbCrLf &
$"Document Management System"

            Dim mail As New MailMessage()
            mail.From = New MailAddress(senderEmail, "SDO, Document Management System")
            mail.To.Add(recipient)
            mail.Subject = "Transaction Notification"
            mail.Body = formattedMessage

            Dim smtp As New SmtpClient("smtp.gmail.com")
            smtp.Port = 587
            smtp.Credentials = New Net.NetworkCredential(senderEmail, senderPassword)
            smtp.EnableSsl = True

            smtp.Send(mail)

        Catch ex As Exception
            MessageBox.Show("Failed to send email. Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ResetForm()
        Me.Hide()
    End Sub

    Private Sub ResetForm()
        cmbDepartment.SelectedIndex = -1
        dgvSelected.Rows.Clear()
    End Sub

    Private Sub cmbDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDepartment.SelectedIndexChanged

    End Sub
End Class
