Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.IO
Imports System.Windows.Controls
Imports FontAwesome.Sharp
Public Class deptHistory

    Private HistoryTable As DataTable
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadHistory()
    End Sub

    Private Sub LoadHistory()
        Try
            dgHistory.DataSource = Nothing

            Dim query As String = "SELECT History_ID, Client_Name, Control_Num, from_department, to_department, action, date_action, date_completed, user_id, remarks " &
                      "FROM History"

            Using con As New OleDbConnection(conString)

                Dim command As New OleDb.OleDbCommand(query, con)
                Dim adapter As New OleDb.OleDbDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)

                HistoryTable = table
                dgHistory.DataSource = HistoryTable

                With dgHistory
                    .Columns("History_ID").HeaderText = "History ID"
                    .Columns("Client_Name").HeaderText = "Client Name"
                    .Columns("Control_Num").HeaderText = "Control Number"
                    .Columns("from_department").HeaderText = "From Department"
                    .Columns("to_department").HeaderText = "To Department"
                    .Columns("action").HeaderText = "Action"
                    .Columns("date_action").HeaderText = "Date of Action"
                    .Columns("date_completed").HeaderText = "Date Completed"
                    .Columns("user_id").HeaderText = "User ID"
                    .Columns("remarks").HeaderText = "Remarks"
                    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading history: " & ex.Message)
        End Try

    End Sub


    Private Sub FilterHistory(filterText As String)
        If HistoryTable Is Nothing Then Exit Sub

        Dim dv As New DataView(HistoryTable)

        If filterText.Trim() <> "" Then
            dv.RowFilter = $"Client_Name LIKE '%{filterText}%' OR Control_Num LIKE '%{filterText}%'"

        End If

        dgHistory.DataSource = dv
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