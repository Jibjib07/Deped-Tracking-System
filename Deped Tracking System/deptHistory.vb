Public Class deptHistory
    Private Sub deptHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox2.TextChanged

    End Sub
    Private Sub FilterByDateRange(fromDate As Date, toDate As Date)
        If HistoryTable Is Nothing Then Exit Sub

        Dim dv As New DataView(HistoryTable)

        ' RowFilter must use #date# format for Access SQL
        dv.RowFilter = $"date_action >= #{fromDate:MM/dd/yyyy}# AND date_completed <= #{toDate:MM/dd/yyyy}#"

        dgHistory.DataSource = dv
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        FilterHistory(txtsearch.Text)
    End Sub

    Private Sub seachbtn_Click(sender As Object, e As EventArgs) Handles searchbtn.Click
        LoadHistory()
    End Sub
    Private Sub dtpFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpFrom.ValueChanged, dtpTo.ValueChanged
        If dtpFrom.Value <= dtpTo.Value Then
            FilterByDateRange(dtpFrom.Value.Date, dtpTo.Value.Date)
        Else
            MessageBox.Show("Start date must be earlier than end date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

End Class