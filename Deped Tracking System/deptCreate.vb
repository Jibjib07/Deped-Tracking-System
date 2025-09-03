Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class deptCreate

    Private Sub deptCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler txtControlNum.KeyPress, AddressOf txtControlNum_KeyPress
    End Sub

    Private Sub txtControlNum_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtControlNum_TextChanged(sender As Object, e As EventArgs) Handles txtControlNum.TextChanged
        lblControlNum.Text = If(String.IsNullOrWhiteSpace(txtControlNum.Text), "Control Number is required.", "")
    End Sub

    Private Sub txtTitle_TextChanged(sender As Object, e As EventArgs) Handles txtTitle.TextChanged
        lblTitle.Text = If(String.IsNullOrWhiteSpace(txtTitle.Text), "Title is required.", "")
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        lblName.Text = If(String.IsNullOrWhiteSpace(txtName.Text), "Client Name is required.", "")
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        If String.IsNullOrWhiteSpace(txtEmail.Text) Then
            lblEmail.Text = "Email is required."
        Else
            Dim emailPattern As String = "^[^@\s]+@[^@\s]+\.[^@\s]+$"
            lblEmail.Text = If(Not Regex.IsMatch(txtEmail.Text, emailPattern), "Invalid email format.", "")
        End If
    End Sub

    Private Sub txtDescription_TextChanged(sender As Object, e As EventArgs) Handles txtDescription.TextChanged
        lblDescription.Text = If(String.IsNullOrWhiteSpace(txtDescription.Text), "Description is required.", "")
    End Sub

    Private Sub dtpDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged
        If dtpDate.Value.Date > DateTime.Now.Date Then
            lblDate.Text = "Date cannot be in the future."
        Else
            lblDate.Text = ""
        End If
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If Not ValidateInputs() Then Exit Sub

        Dim exists As Boolean = False
        Try
            Using con As New OleDbConnection(conString)
                Using cmdCheck As New OleDbCommand("SELECT COUNT(*) FROM Documents WHERE control_num = @control_num", con)
                    cmdCheck.Parameters.AddWithValue("@control_num", Convert.ToInt32(txtControlNum.Text))
                    con.Open()
                    Dim count As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())
                    exists = (count > 0)
                End Using
            End Using
        Catch ex As Exception
            lblControlNum.Text = "Error checking duplicate: " & ex.Message
            Exit Sub
        End Try

        If exists Then
            lblControlNum.Text = "Control Number already exists."
            Exit Sub
        End If

        Dim query As String = "INSERT INTO Documents " &
            "(control_num, title, creator_name, client_name, sender_name, reciever_name, " &
            "date_created, date_lastmodified, current_department, previous_department, status, description) " &
            "VALUES (@control_num, @Title, @user_name, @client_name, @sender_name, @reciever_name, " &
            "@date_created, @date_lastmodified, @current_department, @previous_department, @status, @description)"

        Try
            Using con As New OleDbConnection(conString)
                Using cmd As New OleDbCommand(query, con)
                    cmd.Parameters.AddWithValue("@control_num", Convert.ToInt32(txtControlNum.Text))
                    cmd.Parameters.AddWithValue("@title", txtTitle.Text)
                    cmd.Parameters.AddWithValue("@creator_name", sysModule.userName.ToString())
                    cmd.Parameters.AddWithValue("@client_name", txtName.Text)
                    cmd.Parameters.AddWithValue("@sender_name", "N/A")
                    cmd.Parameters.AddWithValue("@reciever_name", sysModule.userName.ToString())
                    cmd.Parameters.AddWithValue("@date_created", dtpDate.Value.Date)
                    cmd.Parameters.AddWithValue("@date_lastmodified", dtpDate.Value.Date)
                    cmd.Parameters.AddWithValue("@current_department", sysModule.userDept.ToString())
                    cmd.Parameters.AddWithValue("@previous_department", "N/A")
                    cmd.Parameters.AddWithValue("@status", "Received")
                    cmd.Parameters.AddWithValue("@description", txtDescription.Text)

                    con.Open()
                    cmd.ExecuteNonQuery()

                    ClearAllControls(Me)

                    lblDescription.Text = "Document created successfully!"
                End Using
            End Using
        Catch ex As Exception
            lblDescription.Text = "Error saving: " & ex.Message
        End Try
    End Sub

    Private Function ValidateInputs() As Boolean
        Dim isValid As Boolean = True

        If String.IsNullOrWhiteSpace(txtControlNum.Text) Then lblControlNum.Text = "Control Number is required." : isValid = False
        If String.IsNullOrWhiteSpace(txtTitle.Text) Then lblTitle.Text = "Title is required." : isValid = False
        If String.IsNullOrWhiteSpace(txtName.Text) Then lblName.Text = "Client Name is required." : isValid = False
        If String.IsNullOrWhiteSpace(txtEmail.Text) Then lblEmail.Text = "Email is required." : isValid = False
        If String.IsNullOrWhiteSpace(txtDescription.Text) Then lblDescription.Text = "Description is required." : isValid = False
        If dtpDate.Value > DateTime.Now Then lblDate.Text = "Date cannot be in the future." : isValid = False

        Return isValid
    End Function

    Public Event DataSaved()

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ClearAllControls(Me)

        RaiseEvent DataSaved()

        Me.Close()
    End Sub

    Private Sub btnDraft_Click(sender As Object, e As EventArgs) Handles btnDraft.Click
        Me.Hide()
    End Sub

    Private Sub ClearAllControls(parent As Control)
        For Each ctrl As Control In parent.Controls
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Clear()
            ElseIf TypeOf ctrl Is DateTimePicker Then
                CType(ctrl, DateTimePicker).Value = Date.Now
            ElseIf TypeOf ctrl Is Label Then
                If ctrl.Name.StartsWith("lbl") Then ctrl.Text = ""
            End If

            If ctrl.HasChildren Then
                ClearAllControls(ctrl)
            End If
        Next
    End Sub

End Class
