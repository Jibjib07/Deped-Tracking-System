Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Runtime.InteropServices

Public Class deptInterface

    Dim Dashboard As New deptDashboard
    Dim Checklist As New deptChecklist
    Dim History As New deptHistory
    Dim Account As New deptAccount

    Private Sub deptInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadChildForm(Dashboard)
        lblDept.Text = userDept

        ' 🔹 Add "Account" menu item dynamically if not added in designer
        If cmsProfile.Items("AccountToolStripMenuItem") Is Nothing Then
            Dim accountItem As New ToolStripMenuItem("Account")
            accountItem.Name = "AccountToolStripMenuItem"
            AddHandler accountItem.Click, AddressOf AccountToolStripMenuItem_Click
            cmsProfile.Items.Insert(0, accountItem) ' Insert at top (optional)
        End If
    End Sub

    '<DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function SetParent(hWndChild As IntPtr, hWndNewParent As IntPtr) As IntPtr
    End Function

    Private Sub LoadChildForm(childForm As Form)
        pnlDisplay.Controls.Clear()

        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill

        pnlDisplay.Controls.Add(childForm)
        pnlDisplay.Tag = childForm
        childForm.BringToFront()
        childForm.Show()

        For Each ctrl As Control In childForm.Controls
            ctrl.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Next
    End Sub

    Private Sub btnChecklist_Click(sender As Object, e As EventArgs) Handles btnChecklist.Click
        LoadChildForm(Checklist)
    End Sub

    Private Async Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        LoadChildForm(History)

        Dim histForm As deptHistory = TryCast(History, deptHistory)
        If histForm IsNot Nothing Then
            Await histForm.LoadRecordsAsync()
        End If
    End Sub

    Private Async Sub btnDashBoard_Click(sender As Object, e As EventArgs) Handles btnDashBoard.Click
        LoadChildForm(Dashboard)

        Dim Dash As deptDashboard = TryCast(Dashboard, deptDashboard)
        If Dash IsNot Nothing Then
            Await Dash.LoadDashboardCounters()
            Await Dash.LoadReceivedData()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?",
                                                 "Logout Confirmation",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim loginForm As New Login()
            Application.ExitThread()
        End If
    End Sub

    Private Sub pbProfile_Click(sender As Object, e As EventArgs) Handles pbProfile.Click
        cmsProfile.Show(pbProfile, New Point(0, pbProfile.Height))
    End Sub

    ' 🔹 New "Account" option click event
    Private Sub AccountToolStripMenuItem_Click(sender As Object, e As EventArgs)
        deptAccount.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show(
        "Are you sure you want to logout?",
        "Logout Confirmation",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    )

        If result = DialogResult.Yes Then
            ' Create and show the login form first
            Dim loginForm As New Login()
            loginForm.Show()

            ' Close all other open forms (including this one)
            For Each f As Form In Application.OpenForms.Cast(Of Form).ToList()
                If Not TypeOf f Is Login Then
                    f.Close()
                End If
            Next
        End If
    End Sub

    Public Sub PictureGet()
        Using con As New MySqlConnection(conString)
            Try
                con.Open()

                Dim uid As Integer
                If Not Integer.TryParse(sysModule.userUID.ToString, uid) Then
                    MessageBox.Show("Invalid User ID in label.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                Dim query As String = "SELECT photo FROM Users WHERE user_id = @uid"
                Using command As New MySqlCommand(query, con)
                    command.Parameters.AddWithValue("@uid", uid)

                    Dim photo As Object = command.ExecuteScalar()

                    If photo IsNot DBNull.Value AndAlso photo IsNot Nothing Then
                        Dim photoBytes As Byte() = CType(photo, Byte())
                        Using ms As New MemoryStream(photoBytes)
                            pbProfile.Image = Image.FromStream(ms)
                            pbProfile.SizeMode = PictureBoxSizeMode.StretchImage
                        End Using
                    Else
                        pbProfile.Image = Nothing
                    End If
                End Using

            Catch ex As Exception
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

End Class
