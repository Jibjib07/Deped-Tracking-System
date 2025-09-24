Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class deptCreate

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If Not ValidateInputs() Then Exit Sub

        Dim processingDays As Integer = 0
        Select Case cmbArta.SelectedItem?.ToString()
            Case "Simple"
                processingDays = 3
            Case "Complex"
                processingDays = 7
            Case "Highly Technical"
                processingDays = 20
            Case Else
                lblArta.Text = "Please select an ARTA processing type."
                lblArta.Visible = True
                Exit Sub
        End Select

        Dim dateCreated As Date = dtpDate.Value.Date
        Dim dateDue As Date = dateCreated.AddDays(processingDays)

        ' ✅ Confirmation Message
        Dim confirmMsg As String =
        "Please confirm the details before saving:" & vbCrLf & vbCrLf &
        "Control Number: " & txtControlNum.Text.Trim() & vbCrLf &
        "Title: " & txtTitle.Text & vbCrLf &
        "Client Name: " & txtName.Text & vbCrLf &
        "Client Email: " & txtEmail.Text & vbCrLf &
        "Client Contact: " & txtContact.Text & vbCrLf &
        "Processed By: " & sysModule.userDept.ToString() & vbCrLf &
        "Document Type: " & cmbArta.SelectedItem.ToString() & vbCrLf &
        "Date Created: " & dateCreated.ToShortDateString() & vbCrLf &
        "Due Date: " & dateDue.ToShortDateString() & vbCrLf &
        "Description: " & txtDescription.Text & vbCrLf & vbCrLf &
        "Do you want to proceed?"

        Dim result As DialogResult = MessageBox.Show(confirmMsg, "Confirm Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.No Then
            Exit Sub
        End If

        ' 🔽 Duplicate check
        Dim exists As Boolean = False
        Try
            Using con As New MySqlConnection(conString)
                Using cmdCheck As New MySqlCommand("SELECT COUNT(*) FROM Documents WHERE control_num = @control_num", con)
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


        Dim query As String =
             "INSERT INTO Documents " &
             "(control_num, title, creator_name, client_name, client_email, client_contact, sender_name, receiver_name, " &
             "date_created, date_lastmodified, current_department, previous_department, status, description, date_due) " &
             "VALUES (@control_num, @title, @creator_name, @client_name, @client_email, @client_contact, @sender_name, @receiver_name, " &
             "@date_created, @date_lastmodified, @current_department, @previous_department, @status, @description, @date_due)"

        Try
            Using con As New MySqlConnection(conString)
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@control_num", txtControlNum.Text.Trim())
                    cmd.Parameters.AddWithValue("@title", txtTitle.Text)
                    cmd.Parameters.AddWithValue("@creator_name", sysModule.userName.ToString())
                    cmd.Parameters.AddWithValue("@client_name", txtName.Text)
                    cmd.Parameters.AddWithValue("@client_email", txtEmail.Text)
                    cmd.Parameters.AddWithValue("@client_contact", txtContact.Text)
                    cmd.Parameters.AddWithValue("@sender_name", "--")
                    cmd.Parameters.AddWithValue("@receiver_name", sysModule.userName.ToString())
                    cmd.Parameters.AddWithValue("@date_created", dateCreated)
                    cmd.Parameters.AddWithValue("@date_lastmodified", dateCreated)
                    cmd.Parameters.AddWithValue("@current_department", sysModule.userDept.ToString())
                    cmd.Parameters.AddWithValue("@previous_department", "--")
                    cmd.Parameters.AddWithValue("@status", "Received")
                    cmd.Parameters.AddWithValue("@description", txtDescription.Text)
                    cmd.Parameters.AddWithValue("@date_due", dateDue)

                    con.Open()
                    cmd.ExecuteNonQuery()

                    ClearAllControls(Me)

                    MessageBox.Show("Document created successfully!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error saving: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub chkEmail_CheckedChanged(sender As Object, e As EventArgs) Handles chkEmail.CheckedChanged
        Label6.Enabled = chkEmail.Checked
        txtEmail.Enabled = chkEmail.Checked
    End Sub
    Private Function ValidateInputs() As Boolean
        Dim isValid As Boolean = True

        ' Reset all error labels (hide them first)
        lblControlNum.Visible = False
        lblTitle.Visible = False
        lblArta.Visible = False
        lblName.Visible = False
        lblEmail.Visible = False
        lblContact.Visible = False
        lblDate.Visible = False
        lblDescription.Visible = False

        ' Control Number
        If String.IsNullOrWhiteSpace(txtControlNum.Text) Then
            lblControlNum.Text = "Control Number is required."
            lblControlNum.Visible = True
            isValid = False
        End If

        ' Title
        If String.IsNullOrWhiteSpace(txtTitle.Text) Then
            lblTitle.Text = "Title is required."
            lblTitle.Visible = True
            isValid = False
        End If

        ' ARTA type
        If cmbArta.SelectedIndex = -1 Then
            lblArta.Text = "Please select an ARTA type."
            lblArta.Visible = True
            isValid = False
        End If

        ' Name
        If String.IsNullOrWhiteSpace(txtName.Text) Then
            lblName.Text = "Name is required."
            lblName.Visible = True
            isValid = False
        End If

        ' Contact
        If String.IsNullOrWhiteSpace(txtContact.Text) Then
            lblContact.Text = "Contact Number is required."
            lblContact.Visible = True
            isValid = False
        ElseIf txtContact.Text.Length <> 11 OrElse Not IsNumeric(txtContact.Text) Then
            lblContact.Text = "Contact Number must be 11 digits."
            lblContact.Visible = True
            isValid = False
        End If

        ' Email (only if required)
        If chkEmail.Checked Then
            If String.IsNullOrWhiteSpace(txtEmail.Text) Then
                lblEmail.Text = "Email is required."
                lblEmail.Visible = True
                isValid = False
            Else
                ' ✅ Only allow emails ending with @deped.gov.ph (case-insensitive)
                Dim emailPattern As String = "^[A-Za-z0-9._%+-]+@deped\.gov\.ph$"
                If Not Regex.IsMatch(txtEmail.Text.Trim(), emailPattern, RegexOptions.IgnoreCase) Then
                    lblEmail.Text = "Email must be a valid DepEd address."
                    lblEmail.Visible = True
                    isValid = False
                End If
            End If
        End If


        ' Date
        If dtpDate.Value > DateTime.Now Then
            lblDate.Text = "Date cannot be in the future."
            lblDate.Visible = True
            isValid = False
        End If

        ' Description
        If String.IsNullOrWhiteSpace(txtDescription.Text) Then
            lblDescription.Text = "Description is required."
            lblDescription.Visible = True
            isValid = False
        End If

        Return isValid
    End Function


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

    Private processingDays As Integer = 0
    Private dateDue As Date

End Class
