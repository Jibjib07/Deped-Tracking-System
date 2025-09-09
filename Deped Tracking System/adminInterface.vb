Imports System.Runtime.InteropServices

Public Class adminInterface
    Dim Dashboard As New adminDashboard
    Dim Users As New adminUsers
    Dim History As New adminHistory

    Private Sub adminInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadChildForm(Dashboard)
    End Sub

    <DllImport("user32.dll", SetLastError:=True)>
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

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        LoadChildForm(Users)
    End Sub

    Private Async Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        LoadChildForm(History)

        Dim histForm As adminHistory = TryCast(History, adminHistory)
        If histForm IsNot Nothing Then
            Await histForm.LoadRecordsAsync()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.ExitThread()
    End Sub

    Private Sub btnDashBoard_Click(sender As Object, e As EventArgs) Handles btnDashBoard.Click
        LoadChildForm(Dashboard)
    End Sub

    Private Sub pbProfile_Click(sender As Object, e As EventArgs) Handles pbProfile.Click
        cmsProfile.Show(pbProfile, New Point(0, pbProfile.Height))
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?",
                                                 "Logout Confirmation",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim loginForm As New Login()
            loginForm.Show()

            Me.Close()
        End If
    End Sub
End Class