Imports System.Data.OleDb
Imports System.IO
Imports System.Security.Cryptography
Imports System.Web
Imports FontAwesome.Sharp

Public Class Login

    Private Sub Username_Enter(sender As Object, e As EventArgs) Handles txtUserID.Enter
        If txtUserID.Text = "User ID" Then
            txtUserID.Text = ""
            txtUserID.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Username_Leave(sender As Object, e As EventArgs) Handles txtUserID.Leave
        If String.IsNullOrWhiteSpace(txtUserID.Text) Then
            txtUserID.Text = "User ID"
            txtUserID.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub Password_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        If txtPassword.Text = "Password" Then
            txtPassword.Text = ""
            txtPassword.UseSystemPasswordChar = True
            txtPassword.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Password_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            txtPassword.UseSystemPasswordChar = False
            txtPassword.Text = "Password"
            txtPassword.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Using con As New OleDbConnection(conString)
            con.Open()

            If txtUserID.Text = "User ID" Or txtPassword.Text = "Password" Then
                lblerror.Text = "Invalid Employee ID or Password."
                lblerror.Show()
            Else
                Dim UID = txtUserID.Text
                Dim password = txtPassword.Text

                If CredentialCheck(UID, password) Then
                    If IsAdmin(UID) Then
                        txtUserID.Text = "User ID"
                        txtUserID.ForeColor = Color.Gray
                        txtPassword.Text = "Password"
                        txtPassword.ForeColor = Color.Gray
                        txtPassword.PasswordChar = ""
                        btnShow.IconChar = FontAwesome.Sharp.IconChar.EyeSlash

                        lblerror.Hide()
                        adminInterface.Show()
                        Hide()

                    Else
                        Dim userInfo = GetUserInfo(UID, password)

                        sysModule.userName = userInfo.UserName
                        sysModule.userUID = userInfo.UserID
                        sysModule.userDept = userInfo.Department


                        txtUserID.Text = "User ID"
                        txtUserID.ForeColor = Color.FromArgb(200, 200, 200)
                        txtPassword.Text = "Password"
                        txtPassword.ForeColor = Color.FromArgb(200, 200, 200)
                        txtPassword.PasswordChar = ""
                        btnShow.IconChar = FontAwesome.Sharp.IconChar.EyeSlash

                        lblerror.Hide()
                        deptInterface.Show()
                        deptInterface.PictureGet()
                        Hide()

                    End If

                    Exit Sub
                Else
                    lblerror.Text = "Wrong username or password."
                    lblerror.Show()
                End If
            End If
        End Using

    End Sub

    'Credential Check
    Private Function CredentialCheck(uid As String, password As String) As Boolean
        Using con As New OleDbConnection(conString)
            con.Open()

            Using command As New OleDbCommand("SELECT [password] FROM USERS WHERE [user_id] = @uid", con)
                command.Parameters.AddWithValue("@uid", uid)

                Dim dbPassword As Object = command.ExecuteScalar()

                If dbPassword IsNot Nothing Then
                    Return String.Compare(password, dbPassword.ToString(), StringComparison.Ordinal) = 0
                End If

                Return False
            End Using
        End Using
    End Function

    ' Get user_id, first_name, and department
    Private Function GetUserInfo(uid As String, password As String) As (UserID As String, UserName As String, Department As String)
        Using con As New OleDbConnection(conString)
            con.Open()
            Dim query As String = "SELECT user_id, first_name, department_name FROM users WHERE [user_id] = @uid AND [password] = @password"
            Using cmd As New OleDbCommand(query, con)
                cmd.Parameters.AddWithValue("@uid", uid)
                cmd.Parameters.AddWithValue("@password", password)

                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Dim userID As String = reader("user_id").ToString()
                        Dim userName As String = reader("first_name").ToString()
                        Dim department As String = reader("department_name").ToString()
                        Return (userID, userName, department)
                    Else
                        Return (String.Empty, String.Empty, String.Empty)
                    End If
                End Using
            End Using
        End Using
    End Function



    Private Function IsAdmin(username As String) As Boolean
        Using con As New OleDbConnection(conString)
            con.Open()
            Using command As New OleDbCommand("SELECT role FROM users WHERE [user_id] = @uid", con)
                command.Parameters.AddWithValue("@@uid", username)

                Dim result As String = Convert.ToString(command.ExecuteScalar())

                Return result = "admin"
            End Using
        End Using
    End Function



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim imageBytes As Byte() = Nothing
        If PictureBox1.Image IsNot Nothing Then
            Dim ms As New IO.MemoryStream()
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
            imageBytes = ms.ToArray()
        Else
            MessageBox.Show("Please upload a picture for the employee.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            Using con As New OleDbConnection(conString)
                con.Open()
                Dim query As String = "INSERT INTO Users ([user_id], [first_name], [last_name], [department_name], [password], [email], [role], [photo]) " &
                                  "VALUES (@uid, @fname, @lname, @dept, @pass, @mail, @role, @photo)"

                Dim command As New OleDbCommand(query, con)
                command.Parameters.AddWithValue("@uid", 202214625)
                command.Parameters.AddWithValue("@fname", "Evan")
                command.Parameters.AddWithValue("@lname", "Arenas")
                command.Parameters.AddWithValue("@dept", "Personnel Unit")
                command.Parameters.AddWithValue("@pass", "arenas")
                command.Parameters.AddWithValue("@mail", "jibbyarenas@email.com")
                command.Parameters.AddWithValue("@role", "clerk")
                command.Parameters.AddWithValue("@photo", If(imageBytes IsNot Nothing, imageBytes, DBNull.Value))

                command.ExecuteNonQuery()
            End Using

            MessageBox.Show("Record inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Using con As New OleDbConnection(conString)
            con.Open()
            Try
                Dim openFileDialog As New OpenFileDialog
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

                If openFileDialog.ShowDialog = DialogResult.OK Then
                    PictureBox1.Image = Image.FromFile(openFileDialog.FileName)
                    PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

                    MessageBox.Show("Photo uploaded successfully!")
                End If
            Catch ex As Exception
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
            End Try

        End Using

    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        If txtPassword.UseSystemPasswordChar = True Then
            btnShow.IconChar = FontAwesome.Sharp.IconChar.Eye
            txtPassword.UseSystemPasswordChar = False
        Else
            btnShow.IconChar = FontAwesome.Sharp.IconChar.EyeSlash
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        If txtPassword.Text = "Password" Then
            btnShow.Visible = False
        Else
            btnShow.Visible = True
        End If
    End Sub
End Class