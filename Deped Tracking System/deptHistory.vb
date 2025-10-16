Imports MySql.Data.MySqlClient
Imports System.Threading.Tasks

Public Class deptHistory

    Private recordsBinding As New BindingSource()

    ' ==============================
    ' FORM LOAD
    ' ==============================
    Private Async Sub deptHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadRecordsAsync()

        ' ARTA Combo
        cmbARTA.Items.Clear()
        cmbARTA.Items.AddRange({"All", "Simple", "Complex", "Highly Technical"})
        cmbARTA.SelectedIndex = 0

        ' SORT Combo
        cmbSort.Items.Clear()
        cmbSort.Items.AddRange({
            "Sort by:",
            "Title (A-Z)",
            "Title (Z-A)",
            "Date (Newest)",
            "Date (Oldest)",
            "Client (A-Z)",
            "Client (Z-A)"
        })
        cmbSort.SelectedIndex = 0
    End Sub

    ' ==============================
    ' LOAD RECORDS (Department-Specific)
    ' ==============================
    Public Async Function LoadRecordsAsync() As Task
        Dim dt As New DataTable()
        Dim deptName As String = sysModule.userDept.ToString()

        Try
            Using con As New MySqlConnection(conString)
                Await con.OpenAsync()

                Dim query As String = "
                    SELECT 
                        H.control_num AS `Control Number`,
                        H.title AS `Document Type`,
                        H.client_name AS `Client Name`,
                        D.description AS `Description`,
                        D.transaction_type AS `Transaction Type`,
                        H.remarks AS `Status`,
                        H.date_action
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
                        AND (H3.from_department = @deptName OR H3.to_department = @deptName)
                    )
                    ORDER BY 
                        CASE WHEN H.remarks = 'active' THEN 1 ELSE 2 END,
                        H.date_action DESC;
                "

                Using adapter As New MySqlDataAdapter(query, con)
                    adapter.SelectCommand.Parameters.AddWithValue("@deptName", deptName)
                    adapter.Fill(dt)
                End Using
            End Using

            recordsBinding.DataSource = dt
            dgvRecords.DataSource = recordsBinding

            ' Hide internal date column
            If dgvRecords.Columns.Contains("date_action") Then
                dgvRecords.Columns("date_action").Visible = False
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading records: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    ' ==============================
    ' RECORD TABLE STYLING
    ' ==============================
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

    ' ==============================
    ' RECORD CLICK HANDLER
    ' ==============================
    Private Async Sub dgvRecords_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRecords.CellClick
        If e.RowIndex < 0 Then Return

        Dim controlNum As String = dgvRecords.Rows(e.RowIndex).Cells("Control Number").Value?.ToString()
        If String.IsNullOrWhiteSpace(controlNum) Then Return

        Await LoadHistoryAsync(controlNum)
        Await LoadRecordDetailsAsync(controlNum)
    End Sub

    ' ==============================
    ' LOAD HISTORY (Per Record)
    ' ==============================
    Private Async Function LoadHistoryAsync(controlNum As String) As Task
        Dim dt As New DataTable()
        Dim deptName As String = sysModule.userDept.ToString()

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
                      AND (from_department = @deptName OR to_department = @deptName)
                    ORDER BY history_id ASC;
                "

                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@controlNum", controlNum)
                    cmd.Parameters.AddWithValue("@deptName", deptName)
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

    ' ==============================
    ' HISTORY TABLE STYLING
    ' ==============================
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

    ' ==============================
    ' SEARCH BAR
    ' ==============================
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
        ApplyFiltersAndSort()
    End Sub

    ' ==============================
    ' REFRESH BUTTON
    ' ==============================
    Private Async Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Await LoadRecordsAsync()
        dgvRecords.ClearSelection()
        dgvHistory.DataSource = Nothing
        cmbARTA.SelectedIndex = 0
        cmbSort.SelectedIndex = 0
        txtSearch.Text = "Search..."
        txtSearch.ForeColor = Color.Gray
    End Sub

    ' ==============================
    ' LOAD RECORD DETAILS
    ' ==============================
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
                lblTitle.Text = "Title: " & row("title").ToString()
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
        lblTitle.Text = "Title: -"
        lblDate.Text = "Date Created: -"
        lblName.Text = "Name: -"
        lblEmail.Text = "Email: -"
        lblContactNum.Text = "Contact Number: -"
        lblStatus.Text = "Status: -"
        lbltype.Text = "Transaction Type: -"
        txtDescription.Text = ""
    End Sub

    ' ==============================
    ' FILTER + SORT COMBINED
    ' ==============================
    Private Sub ApplyFiltersAndSort()
        If recordsBinding.DataSource Is Nothing Then Return

        Dim searchFilter As String = ""
        Dim artaFilter As String = ""
        Dim finalFilter As String = ""
        Dim sortExpression As String = ""

        ' SEARCH FILTER
        If Not String.IsNullOrWhiteSpace(txtSearch.Text) AndAlso txtSearch.Text <> "Search..." Then
            Dim searchText As String = txtSearch.Text.Trim().Replace("'", "''")
            searchFilter =
                $"CONVERT([Control Number], 'System.String') LIKE '%{searchText}%'" &
                $" OR [Client Name] LIKE '%{searchText}%'" &
                $" OR [Description] LIKE '%{searchText}%'" &
                $" OR [Document Type] LIKE '%{searchText}%'"
        End If

        ' ARTA FILTER (transaction_type)
        If cmbARTA.SelectedItem IsNot Nothing AndAlso cmbARTA.SelectedItem.ToString() <> "All" Then
            artaFilter = $"[Transaction Type] = '{cmbARTA.SelectedItem.ToString()}'"
        End If

        ' COMBINE FILTERS
        If artaFilter <> "" AndAlso searchFilter <> "" Then
            finalFilter = $"{artaFilter} AND ({searchFilter})"
        ElseIf artaFilter <> "" Then
            finalFilter = artaFilter
        ElseIf searchFilter <> "" Then
            finalFilter = searchFilter
        End If

        recordsBinding.Filter = finalFilter

        ' SORTING
        If cmbSort.SelectedItem IsNot Nothing Then
            Select Case cmbSort.SelectedItem.ToString()
                Case "Title (A-Z)"
                    sortExpression = "[Title] ASC"
                Case "Title (Z-A)"
                    sortExpression = "[Title] DESC"
                Case "Date (Newest)"
                    sortExpression = "[date_action] DESC"
                Case "Date (Oldest)"
                    sortExpression = "[date_action] ASC"
                Case "Client (A-Z)"
                    sortExpression = "[Client Name] ASC"
                Case "Client (Z-A)"
                    sortExpression = "[Client Name] DESC"
            End Select
        End If

        If sortExpression <> "" Then
            recordsBinding.Sort = sortExpression
        Else
            recordsBinding.RemoveSort()
        End If

        dgvRecords.ClearSelection()
    End Sub

    ' ==============================
    ' COMBO HANDLERS
    ' ==============================
    Private Sub cmbSort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSort.SelectedIndexChanged
        ApplyFiltersAndSort()
    End Sub

    Private Sub cmbARTA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbARTA.SelectedIndexChanged
        ApplyFiltersAndSort()
    End Sub

End Class
