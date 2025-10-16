Imports MySql.Data.MySqlClient
Imports System.Threading.Tasks

Public Class adminHistory

    Private recordsBinding As New BindingSource()

    Private Async Sub adminHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadRecordsAsync()
    End Sub

    ' ==========================
    ' LOAD RECORDS (Main Table)
    ' ==========================
    Public Async Function LoadRecordsAsync() As Task
        Dim dt As New DataTable()

        Try
            Using con As New MySqlConnection(conString)
                Await con.OpenAsync()

                Dim query As String = "
                    SELECT 
                        CAST(D.control_num AS CHAR) AS `Control Number`, 
                        H.title AS `Document Type`,
                        H.client_name AS `Client Name`, 
                        D.description AS `Description`,
                        H.remarks AS `Status`
                    FROM History AS H
                    INNER JOIN Documents AS D 
                        ON H.control_num = D.control_num
                    WHERE H.History_ID = (
                        SELECT H2.History_ID
                        FROM History H2
                        WHERE H2.control_num = H.control_num
                        ORDER BY H2.date_action DESC, H2.History_ID DESC
                        LIMIT 1
                    )
                    AND EXISTS (
                        SELECT 1
                        FROM History H3
                        WHERE H3.control_num = H.control_num
                    )
                    ORDER BY 
                        CASE WHEN H.remarks = 'active' THEN 1 ELSE 2 END;
                "


                Using adapter As New MySqlDataAdapter(query, con)
                    adapter.Fill(dt)
                End Using
            End Using

            ' ✅ Bind to DataGridView
            recordsBinding.DataSource = dt
            dgvRecords.DataSource = recordsBinding

        Catch ex As Exception
            MessageBox.Show("Error loading records: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    ' ==========================
    ' RECORD TABLE STYLE
    ' ==========================
    Private Sub dgvRecords_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvRecords.DataBindingComplete
        For Each col As DataGridViewColumn In dgvRecords.Columns
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next

        For Each row As DataGridViewRow In dgvRecords.Rows
            If row.IsNewRow Then Continue For

            Dim raw = row.Cells("Status").Value
            If raw Is Nothing OrElse raw Is DBNull.Value Then Continue For

            Select Case raw.ToString().Trim().ToLower()
                Case "active"
                    row.Cells("Status").Style.ForeColor = Color.Lime
                Case "completed"
                    row.Cells("Status").Style.ForeColor = Color.Violet
            End Select
        Next
    End Sub

    ' ==========================
    ' RECORD CLICK HANDLER
    ' ==========================
    Private Async Sub dgvRecords_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRecords.CellClick
        If e.RowIndex < 0 Then Return

        Dim raw = dgvRecords.Rows(e.RowIndex).Cells("Control Number").Value
        If raw Is Nothing OrElse raw Is DBNull.Value Then Return

        Dim controlNum As String = raw.ToString()
        Await LoadHistoryAsync(controlNum)
        Await LoadRecordDetailsAsync(controlNum)
    End Sub

    ' ==========================
    ' LOAD HISTORY (Per Record)
    ' ==========================
    Private Async Function LoadHistoryAsync(controlNum As String) As Task
        Dim dt As New DataTable()

        Try
            Using con As New MySqlConnection(conString)
                Await con.OpenAsync()

                Dim query As String = "
                    SELECT 
                        from_department AS `From Department`, 
                        to_department AS `To Department`, 
                        date_action AS `Date of Action`, 
                        user_action AS `User Action`
                    FROM History
                    WHERE control_num = @controlNum
                    ORDER BY history_id ASC;
                "

                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@controlNum", controlNum)

                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using

            dgvHistory.DataSource = dt
            dgvHistory.ClearSelection()

        Catch ex As Exception
            MessageBox.Show("Error loading history: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    ' ==========================
    ' HISTORY TABLE STYLE
    ' ==========================
    Private Sub dgvHistory_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvHistory.DataBindingComplete
        For Each col As DataGridViewColumn In dgvHistory.Columns
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next

        For Each row As DataGridViewRow In dgvHistory.Rows
            If row.IsNewRow Then Continue For

            Dim raw = row.Cells("User Action").Value
            If raw Is Nothing OrElse raw Is DBNull.Value Then Continue For

            Select Case raw.ToString().Trim().ToLower()
                Case "received"
                    row.Cells("User Action").Style.ForeColor = Color.Lime
                Case "sent"
                    row.Cells("User Action").Style.ForeColor = Color.Blue
            End Select
        Next
    End Sub

    ' ==========================
    ' SEARCH FEATURE
    ' ==========================
    Private Sub txtSearch_GotFocus(sender As Object, e As EventArgs) Handles txtSearch.GotFocus
        If txtSearch.Text = "Search..." Then
            txtSearch.Text = ""
            txtSearch.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtSearch_LostFocus(sender As Object, e As EventArgs) Handles txtSearch.LostFocus
        If txtSearch.Text.Trim() = "" Then
            txtSearch.Text = "Search..."
            txtSearch.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If recordsBinding.DataSource Is Nothing Then Return

        Dim searchText As String = txtSearch.Text.Trim().Replace("'", "''")

        If String.IsNullOrWhiteSpace(searchText) OrElse searchText = "Search..." Then
            recordsBinding.RemoveFilter()
        Else
            recordsBinding.Filter =
                $"CONVERT([Control Number], 'System.String') LIKE '%{searchText}%'" &
                $" OR [Client Name] LIKE '%{searchText}%'" &
                $" OR [Description] LIKE '%{searchText}%'" &
                $" OR [Document Type] LIKE '%{searchText}%'"
        End If
    End Sub

    ' ==========================
    ' REFRESH DATA
    ' ==========================
    Public Async Sub ReloadData()
        Await LoadRecordsAsync()
    End Sub

    Private Async Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Await LoadRecordsAsync()
        dgvRecords.ClearSelection()
        dgvHistory.DataSource = Nothing
    End Sub

    ' ==========================
    ' LOAD RECORD DETAILS
    ' ==========================
    Private Async Function LoadRecordDetailsAsync(controlNum As String) As Task
        Dim dt As New DataTable()

        Try
            Using con As New MySqlConnection(conString)
                Await con.OpenAsync()

                Dim query As String = "
                    SELECT 
                        D.control_num,
                        D.title,
                        D.date_created,
                        D.client_name,
                        D.client_email,
                        D.client_contact,
                        D.description,
                        D.transaction_type,
                        H.remarks AS status
                    FROM Documents D
                    INNER JOIN History H 
                        ON D.control_num = H.control_num
                    WHERE D.control_num = @controlNum
                    ORDER BY H.date_action DESC, H.History_ID DESC
                    LIMIT 1;
                "

                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@controlNum", controlNum)
                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using

            If dt.Rows.Count > 0 Then
                Dim row As DataRow = dt.Rows(0)

                lblControlNum.Text = "Control Number: " & row("control_num").ToString()
                lblCN.Text = row("control_num").ToString()
                lblTitle.Text = "Document Type: " & row("title").ToString()
                lblDate.Text = "Date Created: " & If(IsDBNull(row("date_created")), "-", Convert.ToDateTime(row("date_created")).ToString("MM/dd/yyyy"))
                lblName.Text = "Name: " & row("client_name").ToString()
                lblEmail.Text = "Email: " & row("client_email").ToString()
                lblContactNum.Text = "Contact Number: " & row("client_contact").ToString()
                lbltype.Text = "Transaction Type: " & row("transaction_type").ToString()
                lblStatus.Text = "Status: " & row("status").ToString()
                txtDescription.Text = row("description").ToString()
            Else
                ClearRecordLabels()
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading record details: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Sub ClearRecordLabels()
        lblControlNum.Text = "Control Number: -"
        lblTitle.Text = "Document Type: -"
        lblDate.Text = "Date Created: -"
        lblName.Text = "Name: -"
        lblEmail.Text = "Email: -"
        lblContactNum.Text = "Contact Number: -"
        lblStatus.Text = "Status: -"
        lbltype.Text = "Transaction Type: -"
        txtDescription.Text = ""
    End Sub

    Private Async Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Ensure a record is selected
        If dgvRecords.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a document to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim controlNum As String = dgvRecords.CurrentRow.Cells("Control Number").Value?.ToString()
        If String.IsNullOrWhiteSpace(controlNum) Then
            MessageBox.Show("Invalid document selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim confirm As DialogResult = MessageBox.Show(
            $"Are you sure you want to delete the document with Control Number: {controlNum}?{vbCrLf}This will also delete all related timeline records.",
            "Confirm Deletion",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning)

        If confirm <> DialogResult.Yes Then Return

        Try
            Using con As New MySqlConnection(conString)
                Await con.OpenAsync()

                ' Use synchronous transaction so we can Rollback/Commit without Await inside Catch/Finally
                Using transaction As MySqlTransaction = con.BeginTransaction()
                    Try
                        ' Delete related history records first (async)
                        Dim deleteHistoryQuery As String = "DELETE FROM History WHERE control_num = @controlNum;"
                        Using cmdHistory As New MySqlCommand(deleteHistoryQuery, con, transaction)
                            cmdHistory.Parameters.AddWithValue("@controlNum", controlNum)
                            Await cmdHistory.ExecuteNonQueryAsync()
                        End Using

                        ' Then delete the main document record (async)
                        Dim deleteDocumentQuery As String = "DELETE FROM Documents WHERE control_num = @controlNum;"
                        Using cmdDoc As New MySqlCommand(deleteDocumentQuery, con, transaction)
                            cmdDoc.Parameters.AddWithValue("@controlNum", controlNum)
                            Await cmdDoc.ExecuteNonQueryAsync()
                        End Using

                        ' Commit synchronously
                        transaction.Commit()

                        MessageBox.Show($"Document '{controlNum}' and its history have been successfully deleted.",
                                        "Deleted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Refresh UI (these can be awaited here)
                        Await LoadRecordsAsync()
                        dgvHistory.DataSource = Nothing
                        ClearRecordLabels()

                    Catch exInner As Exception
                        ' Rollback synchronously (no Await here)
                        Try
                            transaction.Rollback()
                        Catch
                            ' ignore rollback errors
                        End Try

                        MessageBox.Show("Error deleting document: " & exInner.Message, "Database Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error connecting to database: " & ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        ' Ensure a control number is selected
        If String.IsNullOrWhiteSpace(lblCN.Text) Then
            MessageBox.Show("Please select a record to edit first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Pass the selected control number to the edit form
        Dim editForm As New adminHisEdit()
        editForm.OriginalControlNumber = lblCN.Text   ' ✅ Updated property name
        editForm.Show()
    End Sub

    ' ==============================
    ' Public method to select a record
    ' ==============================
    Public Sub SelectRecord(controlNumber As String)
        Try
            ' Find and select the updated record in DataGridView
            For Each row As DataGridViewRow In dgvRecords.Rows
                If row.IsNewRow Then Continue For
                Dim cellVal = row.Cells("Control Number").Value
                If cellVal IsNot Nothing AndAlso cellVal.ToString() = controlNumber Then
                    row.Selected = True
                    dgvRecords.CurrentCell = row.Cells(0)

                    ' Trigger the same logic as clicking the row
                    dgvRecords_CellClick(dgvRecords, New DataGridViewCellEventArgs(0, row.Index))
                    Exit For
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Error selecting record: " & ex.Message, "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class

