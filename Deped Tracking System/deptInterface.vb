Imports System.Data.OleDb
Imports System.IO
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

    Public Sub PictureGet()

        Using con As New OleDbConnection(conString)
            Try
                con.Open()


                Dim uid As Integer
                If Not Integer.TryParse(sysModule.userUID.ToString, uid) Then
                    MessageBox.Show("Invalid User ID in label.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                Dim query As String = "SELECT photo FROM Users WHERE user_id = @uid"
                Dim command As New OleDbCommand(query, con)
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

            Catch ex As Exception
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

End Class
