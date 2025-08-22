Public Class Login

    Private Sub Username_Enter(sender As Object, e As EventArgs) Handles tboxUsername.Enter
        If tboxUsername.Text = "Username" Then
            tboxUsername.Text = ""
            tboxUsername.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Username_Leave(sender As Object, e As EventArgs) Handles tboxUsername.Leave
        If String.IsNullOrWhiteSpace(tboxUsername.Text) Then
            tboxUsername.Text = "Username"
            tboxUsername.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub Password_Enter(sender As Object, e As EventArgs) Handles tboxPassword.Enter
        If tboxPassword.Text = "Password" Then
            tboxPassword.Text = ""
            tboxPassword.UseSystemPasswordChar = True   ' enable password masking
            tboxPassword.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Password_Leave(sender As Object, e As EventArgs) Handles tboxPassword.Leave
        If String.IsNullOrWhiteSpace(tboxPassword.Text) Then
            tboxPassword.UseSystemPasswordChar = False  ' show placeholder again
            tboxPassword.Text = "Password"
            tboxPassword.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub Guna2ShadowPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2ShadowPanel1.Paint

    End Sub
End Class