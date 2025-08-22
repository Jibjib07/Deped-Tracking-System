Imports System.Runtime.InteropServices

Public Class deptInterface

    Dim Dashboard As New deptDashboard
    Dim Checklist As New deptChecklist
    Dim History As New deptHistory

    Private Sub deptInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnChecklist.Click
        LoadChildForm(Checklist)
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        LoadChildForm(History)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnDashBoard_Click_1(sender As Object, e As EventArgs) Handles btnDashBoard.Click
        LoadChildForm(Dashboard)
    End Sub
End Class
