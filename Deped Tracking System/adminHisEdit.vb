Imports MySql.Data.MySqlClient

Public Class adminHisEdit

    ' ✅ Store both original and editable control number
    Public Property OriginalControlNumber As String

    Private Sub adminHisEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtControlNum.Text = OriginalControlNumber
        LoadDocumentTypes()
        LoadRecordDetails()
    End Sub

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
            MessageBox.Show("Error loading document types: " & ex.Message,
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadRecordDetails()
        Dim query As String = "
            SELECT 
                title, 
                transaction_type, 
                client_name, 
                client_email, 
                client_contact, 
                date_created, 
                description
            FROM Documents
            WHERE control_num = @control_num;
        "

        Try
            Using con As New MySqlConnection(conString)
                con.Open()
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@control_num", OriginalControlNumber)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            cmbDocType.Text = reader("title").ToString()
                            cmbArta.Text = reader("transaction_type").ToString()
                            txtName.Text = reader("client_name").ToString()
                            txtEmail.Text = reader("client_email").ToString()
                            txtContact.Text = reader("client_contact").ToString()

                            If Not IsDBNull(reader("date_created")) Then
                                dtpDate.Value = Convert.ToDateTime(reader("date_created"))
                            End If

                            txtDescription.Text = reader("description").ToString()
                        Else
                            MessageBox.Show("No record found for Control Number: " & OriginalControlNumber,
                                            "Record Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading record details: " & ex.Message,
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Async Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' ============================
        ' Validate required fields
        ' ============================
        If String.IsNullOrWhiteSpace(txtControlNum.Text) OrElse
       String.IsNullOrWhiteSpace(txtName.Text) OrElse
       String.IsNullOrWhiteSpace(cmbDocType.Text) OrElse
       String.IsNullOrWhiteSpace(cmbArta.Text) Then
            MessageBox.Show("Please fill in all required fields before saving.",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim newControlNum As String = txtControlNum.Text.Trim()
        Dim oldControlNum As String = OriginalControlNumber?.Trim()

        ' ============================
        ' Compute date_due based on ARTA
        ' ============================
        Dim processingDays As Integer
        Select Case cmbArta.Text.Trim().ToLower()
            Case "simple"
                processingDays = 3
            Case "complex"
                processingDays = 7
            Case "highly technical"
                processingDays = 20
            Case Else
                processingDays = 0
        End Select

        Dim dateDue As DateTime = Date.Now.AddDays(processingDays)

        Try
            Using con As New MySqlConnection(conString)
                con.Open()

                Using transaction As MySqlTransaction = con.BeginTransaction()
                    Dim rowsAffectedDocs As Integer = 0
                    Dim rowsAffectedHistory As Integer = 0

                    ' ==========================
                    ' Update Documents Table
                    ' ==========================
                    Dim updateDocsQuery As String = "
                    UPDATE Documents
                    SET 
                        control_num = @new_control_num,
                        title = @title,
                        transaction_type = @transaction_type,
                        client_name = @client_name,
                        client_email = @client_email,
                        client_contact = @client_contact,
                        date_due = @date_due,
                        description = @description
                    WHERE control_num = @old_control_num;
                "

                    Using cmdDocs As New MySqlCommand(updateDocsQuery, con, transaction)
                        cmdDocs.Parameters.AddWithValue("@new_control_num", newControlNum)
                        cmdDocs.Parameters.AddWithValue("@title", cmbDocType.Text)
                        cmdDocs.Parameters.AddWithValue("@transaction_type", cmbArta.Text)
                        cmdDocs.Parameters.AddWithValue("@client_name", txtName.Text)
                        cmdDocs.Parameters.AddWithValue("@client_email", txtEmail.Text)
                        cmdDocs.Parameters.AddWithValue("@client_contact", txtContact.Text)
                        cmdDocs.Parameters.AddWithValue("@date_due", dateDue)
                        cmdDocs.Parameters.AddWithValue("@description", txtDescription.Text)
                        cmdDocs.Parameters.AddWithValue("@old_control_num", oldControlNum)
                        rowsAffectedDocs = cmdDocs.ExecuteNonQuery()
                    End Using

                    ' ==========================
                    ' Update History Table
                    ' ==========================
                    Dim updateHistoryQuery As String = "
                    UPDATE history
                    SET 
                        Control_Num = @new_control_num,
                        client_name = @client_name,
                        title = @title
                    WHERE Control_Num = @old_control_num;
                "

                    Using cmdHistory As New MySqlCommand(updateHistoryQuery, con, transaction)
                        cmdHistory.Parameters.AddWithValue("@new_control_num", newControlNum)
                        cmdHistory.Parameters.AddWithValue("@client_name", txtName.Text)
                        cmdHistory.Parameters.AddWithValue("@title", cmbDocType.Text)
                        cmdHistory.Parameters.AddWithValue("@old_control_num", oldControlNum)
                        rowsAffectedHistory = cmdHistory.ExecuteNonQuery()
                    End Using

                    ' ==========================
                    ' Commit or Rollback
                    ' ==========================
                    If rowsAffectedDocs > 0 OrElse rowsAffectedHistory > 0 Then
                        transaction.Commit()

                        ' Update the original control number
                        OriginalControlNumber = newControlNum

                        MessageBox.Show("Record successfully updated.",
                                    "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Refresh adminHistory form if open
                        For Each openForm As Form In Application.OpenForms
                            If TypeOf openForm Is adminHistory Then
                                Dim historyForm As adminHistory = DirectCast(openForm, adminHistory)

                                ' Refresh data
                                historyForm.ReloadData()
                                Await Task.Delay(500)

                                ' Highlight and show updated record
                                historyForm.SelectRecord(newControlNum)
                                Exit For
                            End If
                        Next

                        ' Close edit form
                        Me.Close()
                    Else
                        transaction.Rollback()
                        MessageBox.Show("No changes were made or record not found.",
                                    "No Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error updating record: " & ex.Message,
                        "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
