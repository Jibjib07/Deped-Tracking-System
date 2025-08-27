Imports System.Data.OleDb
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

        Using con As New OleDbConnection(conString)
            con.Open()
            Dim query As String = "SELECT department_name FROM Departments ORDER BY department_name"
            Using cmd As New OleDbCommand(query, con)
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        cmbDepartment.Items.Add(reader("department_name").ToString())
                    End While
                End Using
            End Using
        End Using
    End Sub


    Private Function GetCurrentDepartment(controlNum As String) As String
        Dim dept As String = ""
        Using con As New OleDbConnection(conString)
            con.Open()
            Dim query As String = "SELECT current_department FROM Documents WHERE control_num = @control_num"
            Using cmd As New OleDbCommand(query, con)
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
            Using con As New OleDbConnection(conString)
                con.Open()

                Dim query As String = "SELECT client_email FROM Documents WHERE control_num = @controlNum"
                Using cmd As New OleDbCommand(query, con)
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

        Using con As New OleDbConnection(conString)
            con.Open()

            For Each row As DataGridViewRow In dgvSelected.Rows
                If Not row.IsNewRow Then
                    Dim controlNum As String = row.Cells("ControlNum").Value.ToString()
                    Dim title As String = row.Cells("Title").Value.ToString()
                    Dim email As String = row.Cells("Email").Value.ToString()

                    Dim query As String = "UPDATE Documents 
                                           SET previous_department = current_department, 
                                               current_department = @newDept
                                           WHERE control_num = @controlNum"

                    Using cmd As New OleDbCommand(query, con)
                        cmd.Parameters.AddWithValue("@newDept", targetDept)
                        cmd.Parameters.AddWithValue("@controlNum", controlNum)
                        cmd.ExecuteNonQuery()
                    End Using

                    Dim msg = $"Your transaction '{title}' with control number {controlNum} " &
                              $"has been sent from {row.Cells("CurrentDept").Value} to {targetDept}."
                    MessageBox.Show($"Email to {email}: " & msg)
                End If
            Next
        End Using

        MessageBox.Show("Transaction(s) sent successfully.")
        RaiseEvent TransactionCompleted()
        Me.Close()
    End Sub


    Private Sub SendEmail(toEmail As String, subject As String, body As String)
        Dim smtp As New SmtpClient("smtp.yourserver.com")
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

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ResetForm()
        Me.Hide()
    End Sub

    Private Sub ResetForm()
        cmbDepartment.SelectedIndex = -1
        dgvSelected.Rows.Clear()
    End Sub

End Class