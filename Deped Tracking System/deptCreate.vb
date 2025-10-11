Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class deptCreate

    Private Async Sub deptCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDocumentTypes()
        Await GenerateControlNumberAsync() ' Auto-generate control number based on department
    End Sub

    ' Load document types from DB into ComboBox
    Private Sub LoadDocumentTypes()
        Try
            Using con As New MySqlConnection(conString)
                Dim query As String = "SELECT type_name FROM documents_type ORDER BY type_name ASC"
                Using cmd As New MySqlCommand(query, con)
                    con.Open()
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        cmbDocType.Items.Clear()
                        While reader.Read()
                            cmbDocType.Items.Add(reader("type_name").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading document types: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Auto-generate Control Number (based on department abbreviation)
    Private Async Function GenerateControlNumberAsync() As Task
        Dim deptName As String = sysModule.userDept
        Dim deptAbbrev As String = ""
        Dim newControlNum As String = ""
        Dim currentYear As String = DateTime.Now.Year.ToString()

        Try
            Using con As New MySqlConnection(conString)
                Await con.OpenAsync()

                ' 1️⃣ Get department abbreviation
                Dim getAbbrevQuery As String =
                    "SELECT department_abbreviation FROM departments WHERE department_name = @deptName LIMIT 1"

                Using cmdAbbrev As New MySqlCommand(getAbbrevQuery, con)
                    cmdAbbrev.Parameters.AddWithValue("@deptName", deptName)
                    Dim result = Await cmdAbbrev.ExecuteScalarAsync()

                    If result IsNot Nothing AndAlso Not String.IsNullOrEmpty(result.ToString()) Then
                        deptAbbrev = result.ToString().Trim()
                    Else
                        ' No abbreviation → let user manually input
                        txtControlNum.ReadOnly = False
                        txtControlNum.Clear()
                        Return
                    End If
                End Using

                'Create prefix (e.g., OSDS-2025-)
                Dim prefix As String = $"{deptAbbrev}-{currentYear}-"

                ' Get latest control number
                Dim getLastQuery As String =
                    "SELECT control_num FROM Documents " &
                    "WHERE control_num LIKE @prefixPattern " &
                    "ORDER BY control_num DESC LIMIT 1"

                Using cmdLast As New MySqlCommand(getLastQuery, con)
                    cmdLast.Parameters.AddWithValue("@prefixPattern", prefix & "%")

                    Dim lastControl = Await cmdLast.ExecuteScalarAsync()
                    Dim nextNumber As Integer = 1

                    If lastControl IsNot Nothing Then
                        Dim parts = lastControl.ToString().Split("-"c)
                        If parts.Length = 3 AndAlso Integer.TryParse(parts(2), nextNumber) Then
                            nextNumber += 1
                        End If
                    End If

                    ' Format new control number like OSDS-2025-00001
                    newControlNum = $"{prefix}{nextNumber.ToString("D5")}"
                End Using
            End Using

            '  Apply generated control number
            txtControlNum.Text = newControlNum
            txtControlNum.ReadOnly = True

        Catch ex As Exception
            MessageBox.Show("Error generating control number: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtControlNum.ReadOnly = False
        End Try
    End Function

    'Create Button Click
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If Not ValidateInputs() Then Exit Sub

        Dim processingDays As Integer
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

        ' Confirmation Message
        Dim confirmMsg As String =
            "Please confirm the details before saving:" & vbCrLf & vbCrLf &
            "Control Number: " & txtControlNum.Text.Trim() & vbCrLf &
            "Document Type: " & cmbDocType.SelectedItem.ToString() & vbCrLf &
            "Client Name: " & txtName.Text & vbCrLf &
            "Client Email: " & txtEmail.Text & vbCrLf &
            "Client Contact: " & txtContact.Text & vbCrLf &
            "Processed By: " & sysModule.userDept.ToString() & vbCrLf &
            "Transaction Type: " & cmbArta.SelectedItem.ToString() & vbCrLf &
            "Date Created: " & dateCreated.ToShortDateString() & vbCrLf &
            "Due Date: " & dateDue.ToShortDateString() & vbCrLf &
            "Description: " & txtDescription.Text & vbCrLf & vbCrLf &
            "Do you want to proceed?"

        If MessageBox.Show(confirmMsg, "Confirm Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Exit Sub

        ' Duplicate check
        Dim exists As Boolean = False
        Try
            Using con As New MySqlConnection(conString)
                Using cmdCheck As New MySqlCommand("SELECT COUNT(*) FROM Documents WHERE control_num = @control_num", con)
                    cmdCheck.Parameters.AddWithValue("@control_num", txtControlNum.Text.Trim())
                    con.Open()
                    exists = Convert.ToInt32(cmdCheck.ExecuteScalar()) > 0
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

        '  Insert record
        Dim query As String =
            "INSERT INTO Documents " &
            "(control_num, title, creator_name, client_name, client_email, client_contact, sender_name, receiver_name, " &
            "date_created, date_lastmodified, current_department, previous_department, status, description, date_due, transaction_type) " &
            "VALUES (@control_num, @title, @creator_name, @client_name, @client_email, @client_contact, @sender_name, @receiver_name, " &
            "@date_created, @date_lastmodified, @current_department, @previous_department, @status, @description, @date_due, @transaction_type)"

        Try
            Using con As New MySqlConnection(conString)
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@control_num", txtControlNum.Text.Trim())
                    cmd.Parameters.AddWithValue("@title", cmbDocType.SelectedItem.ToString())
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
                    cmd.Parameters.AddWithValue("@transaction_type", cmbArta.SelectedItem)

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

    ' Input validation
    Private Function ValidateInputs() As Boolean
        Dim isValid As Boolean = True

        lblControlNum.Visible = False
        lblArta.Visible = False
        lblName.Visible = False
        lblEmail.Visible = False
        lblContact.Visible = False
        lblDate.Visible = False
        lblDescription.Visible = False

        If String.IsNullOrWhiteSpace(txtControlNum.Text) Then
            lblControlNum.Text = "Control Number is required."
            lblControlNum.Visible = True
            isValid = False
        End If

        If cmbDocType.SelectedIndex = -1 Then
            lblTitle.Text = "Please select a document type."
            lblTitle.Visible = True
            isValid = False
        End If

        If cmbArta.SelectedIndex = -1 Then
            lblArta.Text = "Please select an ARTA type."
            lblArta.Visible = True
            isValid = False
        End If

        If String.IsNullOrWhiteSpace(txtName.Text) Then
            lblName.Text = "Client name is required."
            lblName.Visible = True
            isValid = False
        End If

        If chkContact.Checked AndAlso (txtContact.Text.Length <> 11 OrElse Not IsNumeric(txtContact.Text)) Then
            lblContact.Text = "Contact must be 11 digits."
            lblContact.Visible = True
            isValid = False
        End If

        If chkEmail.Checked AndAlso Not Regex.IsMatch(txtEmail.Text.Trim(), "^[A-Za-z0-9._%+-]+@deped\.gov\.ph$", RegexOptions.IgnoreCase) Then
            lblEmail.Text = "Email must be a valid DepEd address."
            lblEmail.Visible = True
            isValid = False
        End If

        If dtpDate.Value > DateTime.Now Then
            lblDate.Text = "Date cannot be in the future."
            lblDate.Visible = True
            isValid = False
        End If

        If String.IsNullOrWhiteSpace(txtDescription.Text) Then
            lblDescription.Text = "Description is required."
            lblDescription.Visible = True
            isValid = False
        End If

        Return isValid
    End Function

    ' Helpers
    Private Sub chkEmail_CheckedChanged(sender As Object, e As EventArgs) Handles chkEmail.CheckedChanged
        Label6.Enabled = chkEmail.Checked
        txtEmail.Enabled = chkEmail.Checked
    End Sub

    Private Sub chkContact_CheckedChanged(sender As Object, e As EventArgs) Handles chkContact.CheckedChanged
        Label9.Enabled = chkContact.Checked
        txtContact.Enabled = chkContact.Checked
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
            ElseIf TypeOf ctrl Is ComboBox Then
                CType(ctrl, ComboBox).SelectedIndex = -1
            ElseIf TypeOf ctrl Is DateTimePicker Then
                CType(ctrl, DateTimePicker).Value = Date.Now
            End If

            If ctrl.HasChildren Then ClearAllControls(ctrl)
        Next
    End Sub

End Class
