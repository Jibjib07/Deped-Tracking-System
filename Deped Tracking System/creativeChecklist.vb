Imports MySql.Data.MySqlClient

Public Class creativeChecklist

    ' === Public Properties for binding ===
    Public Property ControlNum As String
        Get
            Return lblControlNum.Text
        End Get
        Set(value As String)
            lblControlNum.Text = value
        End Set
    End Property

    Private _dateDue As Date
    Public Property DateDue As String
        Get
            Return lblDatedue.Text
        End Get
        Set(value As String)
            lblDatedue.Text = value

            ' Parse and evaluate the due date for color display
            Dim dueDate As Date
            If Date.TryParse(value, dueDate) Then
                _dateDue = dueDate
                UpdateDueDateColor(dueDate)
            Else
                pnlColor.BackColor = Color.Gray ' default if invalid date
            End If
        End Set
    End Property

    Private Sub UpdateDueDateColor(dueDate As Date)
        Dim daysLeft As Integer = (dueDate - Date.Today).Days

        If daysLeft < 0 Then
            pnlColor.FillColor = Color.Red
        ElseIf daysLeft <= 2 Then
            pnlColor.FillColor = Color.Orange
        Else
            pnlColor.FillColor = Color.Green
        End If
    End Sub

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

    Public Property DateCreated As String
        Get
            Return lblDateCreated.Text
        End Get
        Set(value As String)
            lblDateCreated.Text = value
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

    Public Property IsSelected As Boolean
        Get
            Return chkItem.Checked
        End Get
        Set(value As Boolean)
            chkItem.Checked = value
        End Set
    End Property

    ' === Event handlers ===
    Private Sub chkItem_CheckedChanged(sender As Object, e As EventArgs) Handles chkItem.CheckedChanged
        IsSelected = chkItem.Checked

        Dim parentChecklist = TryCast(Me.Parent, FlowLayoutPanel)
        If parentChecklist IsNot Nothing AndAlso TypeOf parentChecklist.Parent Is deptChecklist Then
            DirectCast(parentChecklist.Parent, deptChecklist).UpdateSendAllVisibility()
        End If
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Dim sendForm As New deptSend(New List(Of creativeChecklist) From {Me})

        AddHandler sendForm.TransactionCompleted, Sub()
                                                      DirectCast(Me.Parent.Parent, deptChecklist).ReloadData()
                                                  End Sub

        sendForm.ShowDialog()
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        ' Confirm
        Dim result As DialogResult = MessageBox.Show(
            "Are you sure you want to mark this document as Completed?",
            "Confirm Completion",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If result = DialogResult.No Then Exit Sub

        Try
            Using con As New MySqlConnection(conString)
                con.Open()

                ' === Update Document ===
                Dim updateQuery As String = "
                    UPDATE Documents 
                    SET status = 'Completed',
                        sender_name = '--',
                        receiver_name = '--',
                        previous_department = current_department,
                        current_department = '--',
                        date_lastmodified = @date_lastmodified
                    WHERE control_num = @controlNum
                "

                Using updateCmd As New MySqlCommand(updateQuery, con)
                    updateCmd.Parameters.AddWithValue("@date_lastmodified", Now)
                    updateCmd.Parameters.AddWithValue("@controlNum", lblControlNum.Text)
                    updateCmd.ExecuteNonQuery()
                End Using

                ' === Insert into History ===
                Dim insertQuery As String = "
                    INSERT INTO History
                    (control_num, title, client_name, from_department, to_department, user_action, user_id, action_name, remarks, date_action)
                    SELECT control_num, title, client_name, previous_department, current_department, 'Completed', @user_id, @action_name, 'Completed', @date_action
                    FROM Documents WHERE control_num = @controlNum
                "

                Using insertCmd As New MySqlCommand(insertQuery, con)
                    insertCmd.Parameters.AddWithValue("@user_id", userUID)
                    insertCmd.Parameters.AddWithValue("@action_name", userName)
                    insertCmd.Parameters.AddWithValue("@date_action", Now)
                    insertCmd.Parameters.AddWithValue("@controlNum", lblControlNum.Text)
                    insertCmd.ExecuteNonQuery()
                End Using
            End Using

            Dim parentForm As deptChecklist = TryCast(Me.FindForm(), deptChecklist)
            If parentForm IsNot Nothing Then
                parentForm.ReloadData()
            End If

            MessageBox.Show("Document marked as Completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error while completing document: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
