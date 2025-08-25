Imports System.Data.OleDb

Public Class creativePending
    Public Property ControlNum As String
        Get
            Return lblControlNum.Text
        End Get
        Set(value As String)
            lblControlNum.Text = value
        End Set
    End Property
    'gggggggggggggggggg'
    Public Property Title As String
        Get
            Return lblTitle.Text
        End Get
        Set(value As String)
            lblTitle.Text = value
        End Set
    End Property

    Public Property ClientName As String
        Get
            Return lblClientName.Text
        End Get
        Set(value As String)
            lblClientName.Text = value
        End Set
    End Property

    Public Property SenderName As String
        Get
            Return lblSenderName.Text
        End Get
        Set(value As String)
            lblSenderName.Text = value
        End Set
    End Property

    Public Property DateModified As String
        Get
            Return lblDateModified.Text
        End Get
        Set(value As String)
            lblDateModified.Text = value
        End Set
    End Property

    Public Property PreviousDept As String
        Get
            Return lblPrevDept.Text
        End Get
        Set(value As String)
            lblPrevDept.Text = value
        End Set
    End Property
    Public Property Status As String
        Get
            Return lblStatus.Text
        End Get
        Set(value As String)
            lblStatus.Text = value
        End Set
    End Property

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        Try
            Using con As New OleDbConnection(conString)
                con.Open()

                Dim query As String = "UPDATE Documents SET status = 'Received' WHERE control_num = @controlNum"
                Using cmd As New OleDbCommand(query, con)
                    cmd.Parameters.AddWithValue("@controlNum", lblControlNum.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            Dim parentForm As deptChecklist = TryCast(Me.FindForm(), deptChecklist)
            If parentForm IsNot Nothing Then
                parentForm.ReloadData()
            End If

        Catch ex As Exception
            MessageBox.Show("Error while updating document: " & ex.Message)
        End Try
    End Sub

End Class
