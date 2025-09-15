
Imports MySql.Data.MySqlClient
Imports System.Threading.Tasks
Public Class adminHistory

    Private Async Sub deptHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadRecordsAsync()
    End Sub

    Private recordsBinding As New BindingSource()

    Public Async Function LoadRecordsAsync() As Task
        Dim dt As New DataTable()

        Await Task.Run(Sub()
                           Using con As New MySqlConnection(conString)
                               con.Open()

                               Dim query As String = "
                                SELECT 
                                    H.control_num AS `Control Number`, 
                                    H.title AS `Title`,
                                    H.client_name AS `Client Name`, 
                                    D.description AS `Description`,
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
                                )
                                ORDER BY 
                                    CASE WHEN H.remarks='active' THEN 1 ELSE 2 END,
                                    H.date_action DESC;

                               "

                               Using adapter As New MySqlDataAdapter(query, con)
                                   adapter.Fill(dt)
                               End Using
                           End Using
                       End Sub)

        recordsBinding.DataSource = dt
        dgvRecords.DataSource = recordsBinding

        If dgvRecords.Columns.Contains("date_action") Then
            dgvRecords.Columns("date_action").Visible = False
        End If
    End Function


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

    Private Async Sub dgvRecords_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRecords.CellClick
        If e.RowIndex < 0 Then Return

        Dim raw = dgvRecords.Rows(e.RowIndex).Cells("Control Number").Value
        If raw Is Nothing OrElse raw Is DBNull.Value Then Return

        Dim controlNum As Integer
        If Integer.TryParse(raw.ToString(), controlNum) Then
            Await LoadHistoryAsync(controlNum)

            Await LoadRecordDetailsAsync(controlNum)
        End If
    End Sub


    Private Async Function LoadHistoryAsync(controlNum As Integer) As Task
        Dim dt As New DataTable()

        Await Task.Run(Sub()
                           Using con As New MySqlConnection(conString)
                               con.Open()

                               Dim query As String = "
                                   SELECT 
                                       from_department AS `From Department`, 
                                       to_department AS `To Department`, 
                                       date_action AS `Date of Action`, 
                                       user_action AS `User Action`
                                   FROM History
                                   WHERE control_num = @controlNum
                                   ORDER BY history_id ASC
                               "

                               Using cmd As New MySqlCommand(query, con)
                                   cmd.Parameters.AddWithValue("@controlNum", controlNum)

                                   Using adapter As New MySqlDataAdapter(cmd)
                                       adapter.Fill(dt)
                                   End Using
                               End Using
                           End Using
                       End Sub)

        dgvHistory.DataSource = dt
        dgvHistory.ClearSelection()
    End Function

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
            $" OR [Title] LIKE '%{searchText}%'"
        End If
    End Sub

    Public Async Sub ReloadData()
        Await LoadRecordsAsync()
    End Sub

    Private Async Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Await LoadRecordsAsync()
        dgvRecords.ClearSelection()
        dgvHistory.DataSource = Nothing
    End Sub

    Private Async Function LoadRecordDetailsAsync(controlNum As Integer) As Task
        Dim dt As New DataTable()

        Await Task.Run(Sub()
                           Using con As New MySqlConnection(conString)
                               con.Open()

                               Dim query As String = "
                               SELECT 
                                   D.control_num,
                                   D.title,
                                   D.date_created,
                                   D.client_name,
                                   D.client_email,
                                   D.client_contact,
                                   D.description,
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
                       End Sub)

        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)

            lblControlNum.Text = "Control Number: " & row("control_num").ToString()
            lblTitle.Text = "Title: " & row("title").ToString()
            lblDate.Text = "Date Created: " & Convert.ToDateTime(row("date_created")).ToString("MM/dd/yyyy")
            lblName.Text = "Name: " & row("client_name").ToString()
            lblEmail.Text = "Email: " & row("client_email").ToString()
            lblContactNum.Text = "Contact Number: " & row("client_contact").ToString()
            lblStatus.Text = "Status: " & row("status").ToString()
            txtDescription.Text = row("description").ToString()
        Else
            lblControlNum.Text = "Control Number: -"
            lblTitle.Text = "Title: -"
            lblDate.Text = "Date Created: -"
            lblName.Text = "Name: -"
            lblEmail.Text = "Email: -"
            lblContactNum.Text = "Contact Number: -"
            lblStatus.Text = "Status: -"
            txtDescription.Text = ""
        End If
    End Function


End Class
