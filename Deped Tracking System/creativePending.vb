Imports MySql.Data.MySqlClient

Public Class creativePending
    'bound labes
    Public Property ControlNum As String
        Get
            Return lblControlNum.Text
        End Get
        Set(value As String)
            lblControlNum.Text = value
        End Set
    End Property

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

    'Accept
    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        Try
            Using con As New MySqlConnection(conString)
                con.Open()

                Dim updateQuery As String =
                    "UPDATE Documents 
                     SET receiver_name = @receiver_name, 
                         status = 'Received', 
                         date_lastmodified = @date_lastmodified 
                     WHERE control_num = @controlNum"

                Using updateCmd As New MySqlCommand(updateQuery, con)
                    updateCmd.Parameters.AddWithValue("@receiver_name", userName)
                    updateCmd.Parameters.AddWithValue("@date_lastmodified", Date.Today)
                    updateCmd.Parameters.AddWithValue("@controlNum", lblControlNum.Text)
                    updateCmd.ExecuteNonQuery()
                End Using

                Dim insertQuery As String =
                    "INSERT INTO History 
                     (control_num, title, client_name, from_department, to_department, user_action, user_id, action_name, remarks, date_action) 
                     SELECT control_num, title, client_name, previous_department, current_department, 
                            'Received', @user_id, @action_name, 'Active', @date_action 
                     FROM Documents WHERE control_num = @controlNum"

                Using insertCmd As New MySqlCommand(insertQuery, con)
                    insertCmd.Parameters.AddWithValue("@user_id", userUID)
                    insertCmd.Parameters.AddWithValue("@action_name", userName)
                    insertCmd.Parameters.AddWithValue("@date_action", Date.Today)
                    insertCmd.Parameters.AddWithValue("@controlNum", lblControlNum.Text)
                    insertCmd.ExecuteNonQuery()
                End Using
            End Using

            Dim parentForm As deptChecklist = TryCast(Me.FindForm(), deptChecklist)
            If parentForm IsNot Nothing Then
                parentForm.ReloadData()
            End If

        Catch ex As Exception
            MessageBox.Show("Error while updating document: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
