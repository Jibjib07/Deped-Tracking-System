Imports System.Runtime.InteropServices

Public Class adminInterface
    ' ===============================
    '  Form Instances
    ' ===============================
    Dim Dashboard As New adminDashboard
    Dim Users As New adminUsers
    Dim History As New adminHistory
    Dim Departments As New adminDept   ' ✅ Added this line

    Private Sub adminInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadChildForm(Dashboard)
    End Sub

    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function SetParent(hWndChild As IntPtr, hWndNewParent As IntPtr) As IntPtr
    End Function

    ' ===============================
    '  LOAD CHILD FORM TO PANEL
    ' ===============================
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

    ' ===============================
    '  BUTTON HANDLERS
    ' ===============================
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

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?",
                                                 "Logout Confirmation",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim loginForm As New Login()
            Application.ExitThread()
        End If

    End Sub

    Private Sub btnDashBoard_Click(sender As Object, e As EventArgs) Handles btnDashBoard.Click
        LoadChildForm(Dashboard)
    End Sub

    Private Sub pbProfile_Click(sender As Object, e As EventArgs) Handles pbProfile.Click
        cmsProfile.Show(pbProfile, New Point(0, pbProfile.Height))
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show(
        "Are you sure you want to logout?",
        "Logout Confirmation",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    )

        If result = DialogResult.Yes Then
            ' ✅ Show the Login form first (so the app stays alive)
            Dim loginForm As New Login()
            loginForm.StartPosition = FormStartPosition.CenterScreen
            loginForm.Show()

            ' ✅ Close all other open forms (including this one)
            For Each f As Form In Application.OpenForms.Cast(Of Form).ToList()
                If Not TypeOf f Is Login Then
                    f.Close()
                End If
            Next
        End If
    End Sub


    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    ' ===============================
    '  DEPARTMENTS BUTTON
    ' ===============================
    Private Sub btnDept_Click(sender As Object, e As EventArgs) Handles btnDept.Click
        LoadChildForm(Departments) ' ✅ Loads the adminDept form
    End Sub
End Class
