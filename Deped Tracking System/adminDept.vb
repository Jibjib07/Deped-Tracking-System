Imports MySql.Data.MySqlClient

Public Class adminDept

    Private selectedDeptID As Integer = -1

    Private Sub adminDept_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDepartments()
    End Sub

    ' ===============================
    '  LOAD DEPARTMENTS
    ' ===============================
    Private Sub LoadDepartments()
        Dim dt As New DataTable()

        Using con As New MySqlConnection(conString)
            con.Open()
            Dim query As String = "SELECT department_ID, department_name, department_abbreviation FROM departments ORDER BY department_name"
            Using adapter As New MySqlDataAdapter(query, con)
                adapter.Fill(dt)
            End Using
        End Using

        dgvDept.DataSource = dt
        dgvDept.Columns("department_ID").HeaderText = "ID"
        dgvDept.Columns("department_name").HeaderText = "Name"
        dgvDept.Columns("department_abbreviation").HeaderText = "Abbreviation"

        dgvDept.Columns("department_ID").Width = 20
        dgvDept.Columns("department_name").Width = 60
        dgvDept.Columns("department_abbreviation").Width = 180
    End Sub

    ' ===============================
    '  SELECT ROW → SHOW DATA IN TEXTBOXES
    ' ===============================
    Private Sub dgvDept_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDept.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvDept.Rows(e.RowIndex)
            selectedDeptID = Convert.ToInt32(row.Cells("department_ID").Value)
            txtName.Text = row.Cells("department_name").Value.ToString()
            txtAbbre.Text = row.Cells("department_abbreviation").Value.ToString()
        End If
    End Sub

    ' ===============================
    '  SAVE BUTTON (UPDATE OR ADD)
    ' ===============================
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Using con As New MySqlConnection(conString)
            con.Open()

            If btnSave.Text = "Save" Then

                ' ✅ Update existing department
                If selectedDeptID = -1 Then
                    MessageBox.Show("Select a department first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                Dim updateQuery As String = "UPDATE departments SET department_name = @name, department_abbreviation = @abbre WHERE department_ID = @id"
                Using cmd As New MySqlCommand(updateQuery, con)
                    cmd.Parameters.AddWithValue("@name", txtName.Text.Trim())
                    cmd.Parameters.AddWithValue("@abbre", txtAbbre.Text.Trim())
                    cmd.Parameters.AddWithValue("@id", selectedDeptID)
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Department updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ElseIf btnSave.Text = "Add" Then

                If txtName.Text.Trim() = "" OrElse txtAbbre.Text.Trim() = "" Then
                    MessageBox.Show("Please fill out both fields.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                ' ✅ Add new department
                Dim insertQuery As String = "INSERT INTO departments (department_name, department_abbreviation) VALUES (@name, @abbre)"
                Using cmd As New MySqlCommand(insertQuery, con)
                    cmd.Parameters.AddWithValue("@name", txtName.Text.Trim())
                    cmd.Parameters.AddWithValue("@abbre", txtAbbre.Text.Trim())
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("New department added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dgvDept.Enabled = True
                ' Reset UI
                Label1.Text = "Edit Department:"
                btnSave.Text = "Save"
            End If
        End Using

        ' ✅ Refresh data and clear fields
        LoadDepartments()
        txtName.Clear()
        txtAbbre.Clear()
        selectedDeptID = -1
    End Sub

    ' ===============================
    '  ADD BUTTON
    ' ===============================
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        dgvDept.Enabled = False
        btnRemove.Enabled = True
        btnAdd.Enabled = True

        Label1.Text = "Add Department:"
        btnSave.Text = "Add"
        txtName.Clear()
        txtAbbre.Clear()
        selectedDeptID = -1
    End Sub

    ' ===============================
    '  REMOVE BUTTON
    ' ===============================
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If selectedDeptID = -1 Then
            MessageBox.Show("Please select a department to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to delete this department?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm = DialogResult.Yes Then
            Using con As New MySqlConnection(conString)
                con.Open()
                Dim deleteQuery As String = "DELETE FROM departments WHERE department_ID = @id"
                Using cmd As New MySqlCommand(deleteQuery, con)
                    cmd.Parameters.AddWithValue("@id", selectedDeptID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Department removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadDepartments()
            txtName.Clear()
            txtAbbre.Clear()
            selectedDeptID = -1
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        dgvDept.Enabled = True
        btnRemove.Enabled = True
        btnAdd.Enabled = True
        txtAbbre.Clear()
        txtName.Clear()
        LoadDepartments()
        btnSave.Text = "Save"
        Label1.Text = "Edit Department:"

    End Sub

End Class
