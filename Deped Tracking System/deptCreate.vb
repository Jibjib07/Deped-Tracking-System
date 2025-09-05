Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class deptCreate

    Private Sub deptCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    '======================
    ' CREATE BUTTON
    '======================
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If Not ValidateInputs() Then Exit Sub

        Dim exists As Boolean = False
        Try
            Using con As New OleDbConnection(conString)
                Using cmdCheck As New OleDbCommand("SELECT COUNT(*) FROM Documents WHERE control_num = @control_num", con)
                    cmdCheck.Parameters.AddWithValue("@control_num", txtControlNum.Text.Trim())
                    con.Open()
                    Dim count As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())
                    exists = (count > 0)
                End Using
            End Using
        Catch ex As Exception
            lblControlNum.Text = "Error checking duplicate: " & ex.Message
            lblControlNum.Visible = True
            Exit Sub
        End Try

        If exists Then
            lblControlNum.Text = "Control Number already exists."
            lblControlNum.Visible = True
            Exit Sub
        End If

        Dim query As String = "INSERT INTO Documents " &
        "(control_num, title, creator_name, client_name, client_email, client_contact, sender_name, receiver_name, " &
        "date_created, date_lastmodified, current_department, previous_department, status, description) " &
        "VALUES (@control_num, @Title, @user_name, @client_name, @client_email, @client_contact, @sender_name, @receiver_name, " &
        "@date_created, @date_lastmodified, @current_department, @previous_department, @status, @description)"

        Try
            Using con As New OleDbConnection(conString)
                Using cmd As New OleDbCommand(query, con)
                    cmd.Parameters.AddWithValue("@control_num", txtControlNum.Text.Trim())
                    cmd.Parameters.AddWithValue("@title", txtTitle.Text)
                    cmd.Parameters.AddWithValue("@creator_name", sysModule.userName.ToString())
                    cmd.Parameters.AddWithValue("@client_name", txtName.Text)
                    cmd.Parameters.AddWithValue("@client_email", txtEmail.Text)
                    cmd.Parameters.AddWithValue("@client_contact", txtContact.Text)
                    cmd.Parameters.AddWithValue("@sender_name", "--")
                    cmd.Parameters.AddWithValue("@receiver_name", sysModule.userName.ToString())
                    cmd.Parameters.AddWithValue("@date_created", dtpDate.Value.Date)
                    cmd.Parameters.AddWithValue("@date_lastmodified", dtpDate.Value.Date)
                    cmd.Parameters.AddWithValue("@current_department", sysModule.userDept.ToString())
                    cmd.Parameters.AddWithValue("@previous_department", "--")
                    cmd.Parameters.AddWithValue("@status", "Received")
                    cmd.Parameters.AddWithValue("@description", txtDescription.Text)

                    con.Open()
                    cmd.ExecuteNonQuery()

                    ClearAllControls(Me)

                    MessageBox.Show("Document created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error saving: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '======================
    ' CHECKBOX EMAIL
    '======================
    Private Sub chkEmail_CheckedChanged(sender As Object, e As EventArgs) Handles chkEmail.CheckedChanged
        Label6.Enabled = chkEmail.Checked
        txtEmail.Enabled = chkEmail.Checked
    End Sub

    '======================
    ' VALIDATION
    '======================
    Private Function ValidateInputs() As Boolean
        Dim isValid As Boolean = True

        lblControlNum.Visible = False
        lblTitle.Visible = False
        lblName.Visible = False
        lblEmail.Visible = False
        lblDescription.Visible = False
        lblDate.Visible = False
        lblContact.Visible = False   ' Make sure you have a label for contact errors

        If String.IsNullOrWhiteSpace(txtControlNum.Text) Then
            lblControlNum.Text = "Control Number is required."
            lblControlNum.Visible = True
            isValid = False
        End If

        If String.IsNullOrWhiteSpace(txtTitle.Text) Then
            lblTitle.Text = "Title is required."
            lblTitle.Visible = True
            isValid = False
        End If

        If String.IsNullOrWhiteSpace(txtName.Text) Then
            lblName.Text = "Client Name is required."
            lblName.Visible = True
            isValid = False
        End If

        If String.IsNullOrWhiteSpace(txtContact.Text) Then
            lblContact.Text = "Contact Number is required."
            lblContact.Visible = True
            isValid = False

        ElseIf txtContact.Text.Length = 11 Then
            lblContact.Text = "Contact Number length is invalid."
            lblContact.Visible = True
            isValid = False
        End If

        If chkEmail.Checked Then
            If String.IsNullOrWhiteSpace(txtEmail.Text) Then
                lblEmail.Text = "Email is required."
                lblEmail.Visible = True
                isValid = False
            Else
                Dim emailPattern As String = "^[^@\s]+@[^@\s]+\.[^@\s]+$"
                If Not Regex.IsMatch(txtEmail.Text, emailPattern) Then
                    lblEmail.Text = "Invalid email format."
                    lblEmail.Visible = True
                    isValid = False
                End If
            End If
        End If

        If String.IsNullOrWhiteSpace(txtDescription.Text) Then
            lblDescription.Text = "Description is required."
            lblDescription.Visible = True
            isValid = False
        End If

        If dtpDate.Value > DateTime.Now Then
            lblDate.Text = "Date cannot be in the future."
            lblDate.Visible = True
            isValid = False
        End If

        Return isValid
    End Function


    '======================
    ' TEXTBOX ONLY NUMBERS
    '======================
    Private Sub txtControlNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtControlNum.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtContact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContact.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    '======================
    ' EVENTS & CONTROLS
    '======================
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
