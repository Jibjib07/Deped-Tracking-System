Imports System.IO
Imports System.Text.RegularExpressions
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient

Public Class adminEdit

    Public Event DataUpdated()

    Private Sub adminEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtUserID.Text = selectedUser

        Dim query As String = "SELECT user_id, first_name, last_name, department_name, email, password, photo " &
                         "FROM users WHERE user_id = @user_id"

        Try
            Using con As New MySqlConnection(conString)
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@user_id", selectedUser)
                    con.Open()

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtUserID.Text = reader("user_id").ToString()
                            txtUserID.ReadOnly = True
                            txtFirstName.Text = reader("first_name").ToString()
                            txtLastName.Text = reader("last_name").ToString()
                            cmbDepartment.Text = reader("department_name").ToString()
                            txtEmail.Text = reader("email").ToString()
                            txtPassword.Text = reader("password").ToString()

                            ' Load photo if available
                            If Not IsDBNull(reader("photo")) Then
                                Dim photoBytes As Byte() = DirectCast(reader("photo"), Byte())
                                Using ms As New MemoryStream(photoBytes)
                                    PictureBox1.Image = Image.FromStream(ms)
                                    PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                                End Using
                            Else
                                PictureBox1.Image = Nothing
                            End If
                        Else
                            MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Me.Close()
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading user details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Using con As New MySqlConnection(conString)
            con.Open()

            Dim queries As String = "SELECT department_name FROM Departments ORDER BY department_name"
            Using cd As New MySqlCommand(queries, con)
                Using reader As MySqlDataReader = cd.ExecuteReader()
                    While reader.Read()
                        cmbDepartment.Items.Add(reader("department_name").ToString())
                    End While
                End Using
            End Using
        End Using

    End Sub


    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Try
            Dim openFileDialog As New OpenFileDialog
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                ' Load the image into a temporary object
                Using tempImg As Image = Image.FromFile(openFileDialog.FileName)
                    ' Clone the image so it's not locked by the file
                    PictureBox1.Image = New Bitmap(tempImg)
                End Using
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Simple validation
        If String.IsNullOrWhiteSpace(txtUserID.Text) OrElse
       String.IsNullOrWhiteSpace(txtFirstName.Text) OrElse
       String.IsNullOrWhiteSpace(txtLastName.Text) OrElse
       String.IsNullOrWhiteSpace(cmbDepartment.Text) OrElse
       String.IsNullOrWhiteSpace(txtEmail.Text) Then

            MessageBox.Show("Please fill in all fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim query As String = "UPDATE users SET first_name=@first_name, last_name=@last_name, department_name=@department, email=@email, password=@password, photo=@photo WHERE user_id=@user_id"

        Try
            Using con As New MySqlConnection(conString)
                Using cmd As New MySqlCommand(query, con)
                    ' Always use selectedUser (not from textbox, since textbox might change)
                    cmd.Parameters.AddWithValue("@user_id", selectedUser)
                    cmd.Parameters.AddWithValue("@first_name", txtFirstName.Text.Trim())
                    cmd.Parameters.AddWithValue("@last_name", txtLastName.Text.Trim())
                    cmd.Parameters.AddWithValue("@department", cmbDepartment.Text.Trim())
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim())
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim())

                    ' Handle photo
                    Dim photoBytes As Byte() = Nothing
                    If PictureBox1.Image IsNot Nothing Then
                        Using ms As New MemoryStream()
                            ' Save as PNG (safer for database)
                            PictureBox1.Image.Save(ms, Imaging.ImageFormat.Png)
                            photoBytes = ms.ToArray()
                        End Using
                        cmd.Parameters.Add("@photo", MySqlDbType.Blob).Value = photoBytes
                    Else
                        cmd.Parameters.Add("@photo", MySqlDbType.Blob).Value = DBNull.Value
                    End If

                    con.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("User details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        RaiseEvent DataUpdated()
                        Me.Close()
                    Else
                        MessageBox.Show("No record was updated. Please check the User ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub cmbDepartment_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbDepartment.KeyPress
        e.Handled = True
    End Sub


End Class
