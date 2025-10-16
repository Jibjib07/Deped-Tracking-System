Imports System.IO
Imports MySql.Data.MySqlClient

Public Class deptAccount
    Private Sub deptAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ✅ Use the logged-in user ID
        Dim userId As Integer = sysModule.userUID

        ' ✅ Query to get user info
        Dim query As String = "
            SELECT user_id, first_name, last_name, department_name, email, photo 
            FROM users 
            WHERE user_id = @user_id
        "

        Try
            Using con As New MySqlConnection(conString)
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@user_id", userId)
                    con.Open()

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' ✅ Fill form controls
                            lblID.Text = reader("user_id").ToString()
                            txtFirstName.Text = reader("first_name").ToString()
                            txtLastName.Text = reader("last_name").ToString()
                            lblDept.Text = reader("department_name").ToString()
                            txtEmail.Text = reader("email").ToString()

                            ' ✅ Load photo (if any)
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
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' ============================
        ' 🔹 BASIC VALIDATION
        ' ============================
        If String.IsNullOrWhiteSpace(txtFirstName.Text) OrElse
       String.IsNullOrWhiteSpace(txtLastName.Text) OrElse
       String.IsNullOrWhiteSpace(txtEmail.Text) Then

            MessageBox.Show("Please fill in all required fields before saving.",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' ============================
        ' 🔹 CONFIRMATION PROMPT
        ' ============================
        Dim result As DialogResult = MessageBox.Show(
        "Are you sure you want to save the changes?",
        "Confirm Update",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    )

        If result = DialogResult.No Then Exit Sub

        Try
            Using con As New MySqlConnection(conString)
                con.Open()

                Using tx = con.BeginTransaction()
                    ' =====================================
                    ' 1️⃣ UPDATE users TABLE (with photo)
                    ' =====================================
                    Dim updateUserSql As String =
                    "UPDATE users 
                     SET first_name = @first_name,
                         last_name = @last_name,
                         email = @email,
                         photo = @photo
                     WHERE user_id = @user_id"

                    Using cmd As New MySqlCommand(updateUserSql, con, tx)
                        cmd.Parameters.AddWithValue("@first_name", txtFirstName.Text.Trim())
                        cmd.Parameters.AddWithValue("@last_name", txtLastName.Text.Trim())
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim())
                        cmd.Parameters.AddWithValue("@user_id", lblID.Text)

                        ' Handle photo safely
                        Dim photoBytes As Byte() = Nothing
                        If PictureBox1.Image IsNot Nothing Then
                            Using ms As New MemoryStream()
                                PictureBox1.Image.Save(ms, Imaging.ImageFormat.Png)
                                photoBytes = ms.ToArray()
                            End Using
                            cmd.Parameters.Add("@photo", MySqlDbType.Blob).Value = photoBytes
                        Else
                            cmd.Parameters.Add("@photo", MySqlDbType.Blob).Value = DBNull.Value
                        End If

                        cmd.ExecuteNonQuery()
                    End Using

                    ' =====================================
                    ' 2️⃣ UPDATE history TABLE
                    ' =====================================
                    Dim updateHistorySql As String =
                    "UPDATE history 
                     SET action_name = @action_name
                     WHERE user_id = @user_id"

                    Using cmd As New MySqlCommand(updateHistorySql, con, tx)
                        cmd.Parameters.AddWithValue("@action_name", txtFirstName.Text.Trim())
                        cmd.Parameters.AddWithValue("@user_id", lblID.Text)
                        cmd.ExecuteNonQuery()
                    End Using

                    ' ✅ Commit both updates
                    tx.Commit()
                End Using
            End Using

            ' =====================================
            ' 🔹 REFRESH PROFILE PICTURE ON MAIN FORM
            ' =====================================
            If PictureBox1.Image IsNot Nothing Then
                If Application.OpenForms().OfType(Of deptInterface).Any() Then
                    Dim mainForm As deptInterface = Application.OpenForms().OfType(Of deptInterface).First()
                    mainForm.pbProfile.Image = New Bitmap(PictureBox1.Image)
                End If
            End If

            ' ============================
            ' 🔹 SUCCESS MESSAGE
            ' ============================
            MessageBox.Show("Account information successfully updated!",
                        "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error updating information: " & ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Me.Close()
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
End Class