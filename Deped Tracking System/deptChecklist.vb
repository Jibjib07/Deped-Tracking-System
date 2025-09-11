Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class deptChecklist

    Private WithEvents pendingWatcher As PendingWatcher


    Private Async Sub deptChecklist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadDocumentsAsync()
        Await LoadPendingAsync()
        LoadSortOptions()

        pendingWatcher = New PendingWatcher(conString, GetDepartmentName(sysModule.userUID.ToString()))
        pendingWatcher.StartWatching(10000) ' every 10s

    End Sub

    Private Sub pendingWatcher_PendingChanged(sender As Object, e As EventArgs) Handles pendingWatcher.PendingChanged
        If Me.IsHandleCreated Then
            Me.BeginInvoke(New Action(Async Sub()
                                          Await LoadPendingAsync() ' only reload pending
                                      End Sub))
        End If
    End Sub

    Private Sub deptChecklist_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        pendingWatcher?.StopWatching()

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

    Private Function GetDepartmentName(userId As String) As String
        Dim deptName As String = String.Empty
        Using con As New MySqlConnection(conString)
            con.Open()
            Dim query As String = "SELECT department_name FROM Users WHERE user_id = @user_id"
            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@user_id", userId)
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    deptName = result.ToString()
                End If
            End Using
        End Using
        Return deptName
    End Function

    'Checklist
    Private Async Function LoadDocumentsAsync() As Task
        flpChecklist.Controls.Clear()
        Dim dt As New DataTable()
        Dim deptName As String = GetDepartmentName(sysModule.userUID.ToString)

        Await Task.Run(Sub()
                           Using con As New MySqlConnection(conString)
                               con.Open()
                               Dim query As String = "
                                   SELECT control_num, 
                                          title, 
                                          client_name, 
                                          sender_name,
                                          date_created, 
                                          date_lastmodified, 
                                          previous_department, 
                                          status
                                   FROM Documents 
                                   WHERE status <> 'Sent'
                                   AND current_department = @deptName;"

                               Using cmd As New MySqlCommand(query, con)
                                   cmd.Parameters.AddWithValue("@deptName", deptName)
                                   Using adapter As New MySqlDataAdapter(cmd)
                                       adapter.Fill(dt)
                                   End Using
                               End Using
                           End Using
                       End Sub)

        flpChecklist.SuspendLayout()
        For Each row As DataRow In dt.Rows
            Dim card As New creativeChecklist With {
                .ControlNum = row("control_num").ToString(),
                .Title = row("title").ToString(),
                .ClientName = row("client_name").ToString(),
                .SenderName = row("sender_name").ToString(),
                .Status = row("status").ToString(),
                .PreviousDept = row("previous_department").ToString()
            }

            If Not IsDBNull(row("date_created")) Then
                card.DateCreated = CDate(row("date_created")).ToShortDateString()
            End If
            If Not IsDBNull(row("date_lastmodified")) Then
                card.DateModified = CDate(row("date_lastmodified")).ToShortDateString()
            End If

            flpChecklist.Controls.Add(card)
        Next
        flpChecklist.ResumeLayout()
    End Function

    'Pending
    Private Async Function LoadPendingAsync() As Task
        flpPending.Controls.Clear()
        Dim dt As New DataTable()
        Dim deptName As String = GetDepartmentName(sysModule.userUID.ToString)

        Await Task.Run(Sub()
                           Using con As New MySqlConnection(conString)
                               con.Open()
                               Dim query As String = "
                                   SELECT control_num, 
                                          title, 
                                          client_name, 
                                          sender_name, 
                                          date_created, 
                                          date_lastmodified, 
                                          previous_department, 
                                          status
                                   FROM Documents
                                   WHERE status = 'Sent'
                                   AND current_department = @deptName;"

                               Using cmd As New MySqlCommand(query, con)
                                   cmd.Parameters.AddWithValue("@deptName", deptName)
                                   Using adapter As New MySqlDataAdapter(cmd)
                                       adapter.Fill(dt)
                                   End Using
                               End Using
                           End Using
                       End Sub)

        flpPending.SuspendLayout()
        For Each row As DataRow In dt.Rows
            Dim card As New creativePending With {
                .ControlNum = row("control_num").ToString(),
                .Title = row("title").ToString(),
                .ClientName = row("client_name").ToString(),
                .SenderName = row("sender_name").ToString(),
                .Status = row("status").ToString(),
                .PreviousDept = row("previous_department").ToString()
            }

            If Not IsDBNull(row("date_lastmodified")) Then
                card.DateModified = CDate(row("date_lastmodified")).ToShortDateString()
            End If

            flpPending.Controls.Add(card)
        Next
        flpPending.ResumeLayout()
    End Function

    'Search
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If Me.IsDisposed OrElse Me.Disposing Then Exit Sub
        If flpChecklist Is Nothing Then Exit Sub

        Dim searchText As String = txtSearch.Text.Trim().ToLower()

        If searchText = "" OrElse txtSearch.Text = "Name / Control Number" Then
            For Each ctrl As Control In flpChecklist.Controls
                If TypeOf ctrl Is creativeChecklist Then
                    ctrl.Visible = True
                End If
            Next
            Exit Sub
        End If

        For Each ctrl As Control In flpChecklist.Controls
            If TypeOf ctrl Is creativeChecklist Then
                Dim card As creativeChecklist = TryCast(ctrl, creativeChecklist)

                If card IsNot Nothing AndAlso
                   (card.ControlNum.ToLower().Contains(searchText) OrElse
                    card.ClientName.ToLower().Contains(searchText)) Then
                    card.Visible = True
                Else
                    card.Visible = False
                End If
            End If
        Next
    End Sub

    Public Async Sub ReloadData()
        Await LoadDocumentsAsync()
        Await LoadPendingAsync()
    End Sub

    'Refresh
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        ReloadData()
        LoadSortOptions()
    End Sub

    Private Sub LoadSortOptions()
        cmbSort.Items.Clear()
        cmbSort.Items.Add("Sort by:")
        cmbSort.Items.Add("Title (A-Z)")
        cmbSort.Items.Add("Title (Z-A)")
        cmbSort.Items.Add("Date (Newest)")
        cmbSort.Items.Add("Date (Oldest)")
        cmbSort.Items.Add("Client (A-Z)")
        cmbSort.Items.Add("Client (Z-A)")

        cmbSort.SelectedIndex = 0
    End Sub

    Private Sub cmbSort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSort.SelectedIndexChanged
        If cmbSort.SelectedIndex = 0 Then Exit Sub

        Dim cards = flpChecklist.Controls.OfType(Of creativeChecklist)().ToList()

        Select Case cmbSort.SelectedItem.ToString()
            Case "Title (A-Z)"
                cards = cards.OrderBy(Function(c) c.Title).ToList()
            Case "Title (Z-A)"
                cards = cards.OrderByDescending(Function(c) c.Title).ToList()
            Case "Date (Newest)"
                cards = cards.OrderByDescending(Function(c) DateTime.Parse(c.DateCreated)).ToList()
            Case "Date (Oldest)"
                cards = cards.OrderBy(Function(c) DateTime.Parse(c.DateCreated)).ToList()
            Case "Client (A-Z)"
                cards = cards.OrderBy(Function(c) c.ClientName).ToList()
            Case "Client (Z-A)"
                cards = cards.OrderByDescending(Function(c) c.ClientName).ToList()
            Case "Status"
                cards = cards.OrderBy(Function(c) c.Status).ToList()
        End Select

        flpChecklist.SuspendLayout()
        flpChecklist.Controls.Clear()
        For Each card In cards
            flpChecklist.Controls.Add(card)
        Next
        flpChecklist.ResumeLayout()
    End Sub

    Private Sub chkSelect_CheckedChanged(sender As Object, e As EventArgs) Handles chkSelect.CheckedChanged
        For Each card As creativeChecklist In flpChecklist.Controls.OfType(Of creativeChecklist)()
            card.IsSelected = chkSelect.Checked
        Next

        UpdateSendAllVisibility()
    End Sub

    Private createForm As deptCreate

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If createForm Is Nothing OrElse createForm.IsDisposed Then
            createForm = New deptCreate()
            AddHandler createForm.DataSaved, AddressOf OnDataSaved
        End If

        createForm.Show()
        createForm.BringToFront()
    End Sub

    Private Sub OnDataSaved()
        ReloadData()
    End Sub

    Public Sub UpdateSendAllVisibility()
        Dim anySelected = flpChecklist.Controls.OfType(Of creativeChecklist)().Any(Function(c) c.IsSelected)
        btnSendAll.Visible = anySelected
    End Sub

    Private Sub btnSendAll_Click(sender As Object, e As EventArgs) Handles btnSendAll.Click
        Dim selectedCards = flpChecklist.Controls.OfType(Of creativeChecklist)().Where(Function(c) c.IsSelected).ToList()

        If selectedCards.Count = 0 Then
            MessageBox.Show("Please select at least one.")
            Exit Sub
        End If

        Dim sendForm As New deptSend(selectedCards)
        AddHandler sendForm.TransactionCompleted, AddressOf OnTransactionCompleted
        sendForm.ShowDialog()
    End Sub

    Private Sub OnTransactionCompleted()
        ReloadData()
    End Sub

    Private Sub btnReceiveAll_Click(sender As Object, e As EventArgs) Handles btnReceiveAll.Click
        Try
            Using con As New MySqlConnection(conString)
                con.Open()
                Using tx = con.BeginTransaction()
                    Dim today As Date = Date.Today

                    Dim updSql As String =
                        "UPDATE Documents 
                         SET receiver_name = @receiver_name, 
                             status = 'Received', 
                             date_lastmodified = @date_lastmodified 
                         WHERE status = 'Sent' AND current_department = @dept"

                    Using updCmd As New MySqlCommand(updSql, con, tx)
                        updCmd.Parameters.AddWithValue("@receiver_name", userName)
                        updCmd.Parameters.AddWithValue("@date_lastmodified", today)
                        updCmd.Parameters.AddWithValue("@dept", userDept)
                        updCmd.ExecuteNonQuery()
                    End Using

                    Dim insSql As String =
                        "INSERT INTO History 
                         (control_num, title, client_name, from_department, to_department, user_action, user_id, action_name, remarks, date_action) 
                         SELECT control_num, title, client_name, previous_department, current_department, 
                                'Receive', @user_id, @action_name, 'Active', @date_action 
                         FROM Documents 
                         WHERE status = 'Received' AND current_department = @dept"

                    Using insCmd As New MySqlCommand(insSql, con, tx)
                        insCmd.Parameters.AddWithValue("@user_id", userUID)
                        insCmd.Parameters.AddWithValue("@action_name", userName)
                        insCmd.Parameters.AddWithValue("@date_action", today)
                        insCmd.Parameters.AddWithValue("@dept", userDept)
                        insCmd.ExecuteNonQuery()
                    End Using

                    tx.Commit()
                End Using
            End Using

            MessageBox.Show("All pending documents for this department have been received.", "Receive All",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)

            ReloadData()

        Catch ex As Exception
            MessageBox.Show("Error in Receive All: " & ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
