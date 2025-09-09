Imports System.IO
Imports FontAwesome.Sharp
Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class adminRegister

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If String.IsNullOrWhiteSpace(txtUserID.Text) OrElse
       String.IsNullOrWhiteSpace(txtFirstName.Text) OrElse
       String.IsNullOrWhiteSpace(txtLastName.Text) OrElse
       String.IsNullOrWhiteSpace(cmbDepartment.Text) OrElse
       String.IsNullOrWhiteSpace(txtEmail.Text) Then

            MessageBox.Show("Please fill in all fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Email validation
        If Not Regex.IsMatch(txtEmail.Text.Trim(), "^[^@\s]+@[^@\s]+\.[^@\s]+$") Then
            MessageBox.Show("Please enter a valid email address.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmail.Focus()
            Exit Sub
        End If


        Dim photoBytes As Byte() = Nothing
        If PictureBox1.Image IsNot Nothing Then
            Using ms As New MemoryStream()
                PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                photoBytes = ms.ToArray()
            End Using
        End If

        Dim query As String = "INSERT INTO users " &
                          "(user_id, first_name, last_name, department_name, email, role, password, photo) " &
                          "VALUES (@user_id, @first_name, @last_name, @department_name, @email, @role, @password, @photo)"

        Try
            Using con As New MySqlConnection(conString)
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@user_id", txtUserID.Text.Trim())
                    cmd.Parameters.AddWithValue("@first_name", txtFirstName.Text.Trim())
                    cmd.Parameters.AddWithValue("@last_name", txtLastName.Text.Trim())
                    cmd.Parameters.AddWithValue("@department_name", cmbDepartment.Text.Trim())
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim())
                    cmd.Parameters.AddWithValue("@role", "Clerk")
                    cmd.Parameters.AddWithValue("@password", txtUserID.Text.Trim()) ' password = user_id

                    If photoBytes IsNot Nothing Then
                        cmd.Parameters.Add("@photo", MySqlDbType.LongBlob).Value = photoBytes
                    Else
                        cmd.Parameters.Add("@photo", MySqlDbType.LongBlob).Value = DBNull.Value
                    End If

                    con.Open()
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    txtUserID.Clear()
                    txtFirstName.Clear()
                    txtLastName.Clear()
                    cmbDepartment.SelectedIndex = -1
                    txtEmail.Clear()
                    PictureBox1.Image = Nothing
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error saving: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtUserID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUserID.KeyPress
        ' Allow only digits and control keys (like Backspace)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        Try
            Using openFileDialog As New OpenFileDialog()
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
                openFileDialog.Title = "Select a Photo"

                If openFileDialog.ShowDialog() = DialogResult.OK Then
                    ' Dispose old image if exists
                    If PictureBox1.Image IsNot Nothing Then
                        PictureBox1.Image.Dispose()
                    End If

                    PictureBox1.Image = Image.FromFile(openFileDialog.FileName)
                    PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub adminRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbDepartment.Items.Clear()

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
    End Sub

    Public Event DataSaved()

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ClearAllControls(Me)
        RaiseEvent DataSaved()
        Me.Close()
    End Sub

    Private Sub btnDraft_Click(sender As Object, e As EventArgs) Handles btnDraft.Click

        Me.Hide()
    End Sub

    Private Sub ClearAllControls(parent As Control)
        For Each ctrl As Control In parent.Controls
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Clear()

            ElseIf TypeOf ctrl Is ComboBox Then
                Dim cb As ComboBox = CType(ctrl, ComboBox)
                cb.SelectedIndex = -1
                cb.Text = ""

            ElseIf TypeOf ctrl Is Label Then
                If ctrl.Name.StartsWith("lbl") Then
                    ctrl.Text = ""
                End If

            ElseIf TypeOf ctrl Is PictureBox Then
                CType(ctrl, PictureBox).Image = Nothing
            End If
            If ctrl.HasChildren Then
                ClearAllControls(ctrl)
            End If
        Next
    End Sub

    Private Sub cmbDepartment_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbDepartment.KeyPress
        e.Handled = True
    End Sub
End Class