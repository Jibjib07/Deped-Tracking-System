Imports System.Runtime.InteropServices
Imports System.Web
Imports MySql.Data.MySqlClient

Public Class adminUsers

    Private Sub adminUsers_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadDepartments()
        LoadUsers()
    End Sub

    ' ===============================
    '  LOAD USERS (only Active)
    ' ===============================
    Private Sub LoadUsers(Optional departmentFilter As String = "", Optional searchText As String = "")
        Dim dt As New DataTable()

        Using con As New MySqlConnection(conString)
            con.Open()

            Dim query As String = "
                SELECT 
                    user_id, 
                    first_name, 
                    last_name, 
                    department_name,
                    email,
                    photo
                FROM users
                WHERE status = 'Active'
            "

            ' ✅ Filter by department
            If departmentFilter <> "" AndAlso departmentFilter <> "All" Then
                query &= " AND department_name = @dept"
            End If

            ' ✅ Filter by search text (first or last name)
            If searchText <> "" Then
                query &= " AND (first_name LIKE @search OR last_name LIKE @search)"
            End If

            query &= " ORDER BY last_name, first_name"

            Using adapter As New MySqlDataAdapter(query, con)
                If departmentFilter <> "" AndAlso departmentFilter <> "All" Then
                    adapter.SelectCommand.Parameters.AddWithValue("@dept", departmentFilter)
                End If
                If searchText <> "" Then
                    adapter.SelectCommand.Parameters.AddWithValue("@search", "%" & searchText & "%")
                End If
                adapter.Fill(dt)
            End Using
        End Using

        ' ===============================
        ' Populate DataGridView
        ' ===============================
        dgvUsers.Columns.Clear()
        dgvUsers.Rows.Clear()

        Dim imgCol As New DataGridViewImageColumn()
        imgCol.HeaderText = ""
        imgCol.Name = "Photo"
        imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom
        dgvUsers.Columns.Add(imgCol)

        dgvUsers.Columns.Add("User ID", "User ID")
        dgvUsers.Columns.Add("FullName", "Full Name")
        dgvUsers.Columns.Add("Department", "Department")

        For Each row As DataRow In dt.Rows
            Dim img As Byte() = If(IsDBNull(row("photo")), Nothing, DirectCast(row("photo"), Byte()))
            Dim resizedPhoto As Image = Nothing

            If img IsNot Nothing Then
                Using ms As New IO.MemoryStream(img)
                    Dim originalPhoto As Image = Image.FromStream(ms)
                    resizedPhoto = New Bitmap(originalPhoto, New Size(40, 40))
                End Using
            End If

            Dim fullName As String = row("first_name").ToString() & " " & row("last_name").ToString()
            Dim empId As String = row("user_id").ToString()
            Dim dept As String = row("department_name").ToString()

            dgvUsers.Rows.Add(resizedPhoto, empId, fullName, dept)
        Next

        dgvUsers.RowTemplate.Height = 50
    End Sub

    ' ===============================
    '  LOAD DEPARTMENTS
    ' ===============================
    Private Sub LoadDepartments()
        cmbDepartment.Items.Clear()
        cmbDepartment.Items.Add("All")

        Using con As New MySqlConnection(conString)
            con.Open()
            Dim query As String = "SELECT department_name FROM Departments ORDER BY department_name"
            Using cmd As New MySqlCommand(query, con)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        cmbDepartment.Items.Add(reader("department_name").ToString())
                    End While
                End Using
            End Using
        End Using

        cmbDepartment.SelectedIndex = 0
    End Sub

    ' ===============================
    '  REFRESH BUTTON
    ' ===============================
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtSearch.Clear()
        cmbDepartment.SelectedIndex = 0
        LoadUsers()
    End Sub

    ' ===============================
    '  DATA GRID CLICK
    ' ===============================
    Private Sub dgvUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellClick
        If e.RowIndex >= 0 Then
            Dim userId As String = dgvUsers.Rows(e.RowIndex).Cells("User ID").Value.ToString()
            selectedUser = userId

            Using con As New MySqlConnection(conString)
                con.Open()

                Dim query As String = "
                    SELECT 
                        user_id, 
                        first_name, 
                        last_name, 
                        department_name, 
                        email, 
                        photo
                    FROM users
                    WHERE user_id = @userId
                "

                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@userId", userId)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            lblUserID.Text = reader("user_id").ToString()
                            lblName.Text = reader("first_name").ToString() & " " & reader("last_name").ToString()
                            lblDepartment.Text = reader("department_name").ToString()
                            lblEmail.Text = reader("email").ToString()

                            If Not IsDBNull(reader("photo")) Then
                                Dim imgBytes As Byte() = DirectCast(reader("photo"), Byte())
                                Using ms As New IO.MemoryStream(imgBytes)
                                    pbUser.Image = Image.FromStream(ms)
                                    pbUser.SizeMode = PictureBoxSizeMode.StretchImage
                                End Using
                            Else
                                pbUser.Image = Nothing
                            End If
                        End If
                    End Using
                End Using
            End Using
        End If
    End Sub

    ' ===============================
    '  REGISTER & EDIT HANDLERS
    ' ===============================
    Private registrationForm As adminRegister
    Private editForm As adminEdit

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If registrationForm Is Nothing OrElse registrationForm.IsDisposed Then
            registrationForm = New adminRegister()
            AddHandler registrationForm.DataSaved, AddressOf OnDataSaved
        End If
        registrationForm.Show()
        registrationForm.BringToFront()
    End Sub

    Private Sub OnDataSaved()
        LoadUsers()
    End Sub

    Private Sub OnDataUpdated()
        LoadUsers()
        For Each row As DataGridViewRow In dgvUsers.Rows
            If row.Cells("User ID").Value.ToString() = selectedUser Then
                row.Selected = True
                dgvUsers.CurrentCell = row.Cells(1)
                dgvUsers_CellClick(Nothing, New DataGridViewCellEventArgs(row.Cells("User ID").ColumnIndex, row.Index))
                Exit For
            End If
        Next
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If lblUserID.Text = "USER ID" Then
            MessageBox.Show("No User ID provided. Select a user first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            If editForm Is Nothing OrElse editForm.IsDisposed Then
                editForm = New adminEdit()
                AddHandler editForm.DataUpdated, AddressOf OnDataUpdated
            End If
            editForm.Show()
            editForm.BringToFront()
        End If
    End Sub

    ' ===============================
    '  FILTER HANDLERS
    ' ===============================
    Private Sub cmbDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDepartment.SelectedIndexChanged
        If cmbDepartment.SelectedItem Is Nothing Then Exit Sub
        Dim selectedDept As String = cmbDepartment.SelectedItem.ToString()
        Dim searchText As String = txtSearch.Text.Trim()
        LoadUsers(selectedDept, searchText)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim selectedDept As String = ""
        If cmbDepartment.SelectedItem IsNot Nothing Then
            selectedDept = cmbDepartment.SelectedItem.ToString()
        End If
        Dim searchText As String = txtSearch.Text.Trim()
        LoadUsers(selectedDept, searchText)
    End Sub

    Private Sub btnDeactivate_Click(sender As Object, e As EventArgs) Handles btnDeactivate.Click
        ' Check if a user is selected
        If lblUserID.Text = "USER ID" OrElse String.IsNullOrWhiteSpace(lblUserID.Text) Then
            MessageBox.Show("Please select a user to deactivate.", "No User Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim userId As String = lblUserID.Text

        ' Confirm deactivation
        Dim confirm As DialogResult = MessageBox.Show(
            "Are you sure you want to deactivate this user?",
            "Confirm Deactivation",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If confirm = DialogResult.Yes Then
            Try
                Using con As New MySqlConnection(conString)
                    con.Open()

                    Dim query As String = "UPDATE users SET status = 'Deactivated' WHERE user_id = @userId"
                    Using cmd As New MySqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@userId", userId)
                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            MessageBox.Show("User has been deactivated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            ' Refresh the user list after update
                            LoadUsers()

                            ' Optionally clear user details
                            lblUserID.Text = "USER ID"
                            lblName.Text = "FULL NAME"
                            lblDepartment.Text = "DEPARTMENT"
                            lblEmail.Text = "EMAIL"
                            pbUser.Image = Nothing
                        Else
                            MessageBox.Show("Failed to deactivate user. The user may not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred while deactivating the user: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

End Class
