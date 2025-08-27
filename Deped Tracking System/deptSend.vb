Imports System.Data.OleDb
Imports System.Net.Mail

Public Class deptSend

    Public Sub LoadSelectedCards(cards As List(Of creativeChecklist))
        dgvSelected.Rows.Clear()

        For Each card In cards
            dgvSelected.Rows.Add(card.ControlNum, card.Title)
        Next
    End Sub

    Private Sub deptSend_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvSelected.Rows.Clear()

        For Each card In selectedCards
            dgvSelected.Rows.Add(card.ControlNum, card.Title)
        Next
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        If cmbDepartment.SelectedIndex = -1 Then
            MessageBox.Show("Please select a department.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim newDept As String = cmbDepartment.SelectedItem.ToString()

        Using con As New OleDbConnection(conString)
            con.Open()

            For Each card In selectedCards
                ' 1. Get current info from DB (email, current dept, etc.)
                Dim querySelect As String = "SELECT client_email, current_department 
                                         FROM Documents 
                                         WHERE control_num = @controlNum"

                Dim clientEmail As String = ""
                Dim prevDept As String = ""

                Using cmdSelect As New OleDbCommand(querySelect, con)
                    cmdSelect.Parameters.AddWithValue("@controlNum", card.ControlNum)
                    Using reader As OleDbDataReader = cmdSelect.ExecuteReader()
                        If reader.Read() Then
                            clientEmail = reader("client_email").ToString()
                            prevDept = reader("current_department").ToString()
                        End If
                    End Using
                End Using

                ' 2. Update DB with new department
                Dim queryUpdate As String = "UPDATE Documents 
                                         SET previous_department = @prevDept, 
                                             current_department = @newDept 
                                         WHERE control_num = @controlNum"

                Using cmdUpdate As New OleDbCommand(queryUpdate, con)
                    cmdUpdate.Parameters.AddWithValue("@prevDept", prevDept)
                    cmdUpdate.Parameters.AddWithValue("@newDept", newDept)
                    cmdUpdate.Parameters.AddWithValue("@controlNum", card.ControlNum)
                    cmdUpdate.ExecuteNonQuery()
                End Using

                ' 3. Send Email Notification
                If clientEmail <> "" Then
                    Try
                        Dim subject As String = "Transaction Update Notification"
                        Dim body As String = $"Dear Client," & vbCrLf & vbCrLf &
                                             $"Your transaction [{card.Title}] with control number [{card.ControlNum}] " &
                                             $"has been sent from {prevDept} to {newDept}." & vbCrLf & vbCrLf &
                                             "Thank you."

                        SendEmail(clientEmail, subject, body)
                    Catch ex As Exception
                        MessageBox.Show($"Failed to send email for transaction {card.ControlNum}: {ex.Message}")
                    End Try
                End If
            Next
        End Using

        MessageBox.Show("Documents sent successfully and emails have been dispatched.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub SendEmail(toEmail As String, subject As String, body As String)
        Dim smtp As New SmtpClient("smtp.yourserver.com") ' e.g. smtp.gmail.com
        smtp.Port = 587
        smtp.Credentials = New Net.NetworkCredential("youremail@domain.com", "yourpassword")
        smtp.EnableSsl = True

        Dim mail As New MailMessage()
        mail.From = New MailAddress("youremail@domain.com")
        mail.To.Add(toEmail)
        mail.Subject = subject
        mail.Body = body

        smtp.Send(mail)
    End Sub


    Private selectedCards As List(Of creativeChecklist)

    Public Sub New(cards As List(Of creativeChecklist))
        InitializeComponent()
        selectedCards = cards
    End Sub

End Class