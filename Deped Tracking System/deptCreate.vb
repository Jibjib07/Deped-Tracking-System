Imports System.Data.OleDb

Public Class deptCreate

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click

        'Error Trapping for creation
        If String.IsNullOrWhiteSpace(txtControlNum.Text) OrElse
       String.IsNullOrWhiteSpace(txtTitle.Text) OrElse
       String.IsNullOrWhiteSpace(txtName.Text) Then

            MessageBox.Show("Please fill in all required fields (Control Number, Title, Client Name).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        Dim exists As Boolean = False
        Try
            Using con As New OleDbConnection(conString)
                Using cmdCheck As New OleDbCommand("SELECT COUNT(*) FROM Documents WHERE control_num = @control_num", con)
                    cmdCheck.Parameters.AddWithValue("@control_num", Convert.ToInt32(txtControlNum.Text))
                    con.Open()
                    Dim count As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())
                    If count > 0 Then
                        exists = True
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking duplicate Control Number: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        If exists Then
            MessageBox.Show("Control Number already exists.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'Insert new Record

        Dim query As String = "INSERT INTO Documents " &
        "(control_num, title, creator_name, client_name, client_email, sender_name, reciever_name, " &
        "date_created, date_lastmodified, current_department, previous_department, status, description) " &
        "VALUES (@control_num, @title, @user_name, @client_name, @email, @sender_name, @reciever_name, " &
        "@date_created, @date_lastmodified, @current_department, @previous_department, @status, @description)"

        Try
            Using con As New OleDbConnection(conString)
                Using cmd As New OleDbCommand(query, con)
                    cmd.Parameters.AddWithValue("@control_num", Convert.ToInt32(txtControlNum.Text))
                    cmd.Parameters.AddWithValue("@title", txtTitle.Text)
                    cmd.Parameters.AddWithValue("@creator_name", sysModule.userName.ToString())
                    cmd.Parameters.AddWithValue("@client_name", txtName.Text)
                    cmd.Parameters.AddWithValue("@client_email", txtEmail.Text)
                    cmd.Parameters.AddWithValue("@sender_name", "N/A")
                    cmd.Parameters.AddWithValue("@reciever_name", sysModule.userName.ToString())
                    cmd.Parameters.AddWithValue("@date_created", dtpDate.Value.Date)
                    cmd.Parameters.AddWithValue("@date_lastmodified", dtpDate.Value.Date)
                    cmd.Parameters.AddWithValue("@current_department", sysModule.userDept.ToString())
                    cmd.Parameters.AddWithValue("@previous_department", "N/A")
                    cmd.Parameters.AddWithValue("@status", "Received")
                    cmd.Parameters.AddWithValue("@description", txtDescription.Text)

                    con.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Document created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ClearAllControls(Me)
                End Using
            End Using



        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Insert Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Event DataSaved()

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ClearAllControls(Me)

        RaiseEvent DataSaved()

        Me.Close()
    End Sub


    Private Sub ClearAllControls(parent As Control)
        For Each ctrl As Control In parent.Controls
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Clear()
            ElseIf TypeOf ctrl Is DateTimePicker Then
                CType(ctrl, DateTimePicker).Value = Date.Now
            End If

            If ctrl.HasChildren Then
                ClearAllControls(ctrl)
            End If
        Next
    End Sub

    Private Sub btnDraft_Click(sender As Object, e As EventArgs) Handles btnDraft.Click
        Me.Hide()
    End Sub

End Class