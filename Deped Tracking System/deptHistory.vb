Imports System.Data.OleDb

Public Class deptHistory
    Private Sub deptHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRecords()
    End Sub

    Private Sub LoadRecords()
        Using con As New OleDbConnection(conString)
            con.Open()

            Dim query As String = "
        SELECT 
            H.control_num AS [Control Number], 
            H.client_name AS [Client Name], 
            H.remarks AS [Status],
            H.date_action
        FROM History AS H
        INNER JOIN (
            SELECT control_num, MAX(date_action) AS latest_date
            FROM History
            GROUP BY control_num
        ) AS X
        ON H.control_num = X.control_num 
        AND H.date_action = X.latest_date
        ORDER BY 
            IIF(H.remarks='active',1,2),
            H.date_action DESC
        "

            Dim adapter As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            ' Hide date_action if you don’t want to display it
            dgvRecords.DataSource = dt
            If dgvRecords.Columns.Contains("date_action") Then
                dgvRecords.Columns("date_action").Visible = False
            End If
        End Using
    End Sub


    Private Sub dgvRecords_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvRecords.DataBindingComplete
        For Each col As DataGridViewColumn In dgvRecords.Columns
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next

        ' Highlight specific statuses
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


    Private Sub dgvRecords_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRecords.CellClick
        If e.RowIndex < 0 Then Return

        Dim raw = dgvRecords.Rows(e.RowIndex).Cells("Control Number").Value
        If raw Is Nothing OrElse raw Is DBNull.Value Then Return

        Dim controlNum As Integer
        If Integer.TryParse(raw.ToString(), controlNum) Then
            LoadHistory(controlNum)
        End If
    End Sub

    Private Sub LoadHistory(controlNum As Integer)
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

                Dim adapter As New OleDbDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                dgvHistory.DataSource = dt
                dgvHistory.ClearSelection()
            End Using
        End Using
    End Sub


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


End Class