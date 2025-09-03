Imports System.Data.OleDb

Public Class deptHistory
    Private Async Sub deptHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadRecordsAsync()
    End Sub


    Private recordsBinding As New BindingSource()

    Public Async Function LoadRecordsAsync() As Task

        Dim dt As New DataTable()

        Await Task.Run(Sub()
                           Using con As New OleDbConnection(conString)
                               con.Open()

                               Dim query As String = "
                           SELECT 
                               H.control_num AS [Control Number], 
                               H.client_name AS [Client Name], 
                               H.remarks AS [Status],
                               H.date_action
                           FROM History AS H
                           WHERE H.History_ID = (
                               SELECT TOP 1 H2.History_ID
                               FROM History H2
                               WHERE H2.control_num = H.control_num
                               ORDER BY H2.date_action DESC, H2.History_ID DESC
                           )
                           ORDER BY 
                               IIF(H.remarks='active',1,2),
                               H.date_action DESC
                           "

                               Using adapter As New OleDbDataAdapter(query, con)
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
        End If
    End Sub


    Private Async Function LoadHistoryAsync(controlNum As Integer) As Task
        Dim dt As New DataTable()

        Await Task.Run(Sub()
                           Using con As New OleDbConnection(conString)
                               con.Open()

                               Dim query As String = "
                           SELECT 
                               from_department AS [From Department], 
                               to_department AS [To Department], 
                               date_action AS [Date of Action], 
                               user_action AS [User Action]
                           FROM History
                           WHERE [control_num] = ?
                           ORDER BY date_action ASC
                           "

                               Using cmd As New OleDbCommand(query, con)
                                   cmd.Parameters.AddWithValue("?", controlNum)

                                   Using adapter As New OleDbDataAdapter(cmd)
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
        If txtSearch.Text = "Name / Control Number" Then
            txtSearch.Text = ""
            txtSearch.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtSearch_LostFocus(sender As Object, e As EventArgs) Handles txtSearch.LostFocus
        If txtSearch.Text.Trim() = "" Then
            txtSearch.Text = "Name / Control Number"
            txtSearch.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If recordsBinding.DataSource Is Nothing Then Return

        Dim searchText As String = txtSearch.Text.Trim().Replace("'", "''")

        If String.IsNullOrWhiteSpace(searchText) OrElse searchText = "Name / Control Number" Then
            recordsBinding.RemoveFilter()
        Else

            recordsBinding.Filter =
            $"CONVERT([Control Number], 'System.String') LIKE '%{searchText}%' " &
            $"OR [Client Name] LIKE '%{searchText}%'"
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

End Class