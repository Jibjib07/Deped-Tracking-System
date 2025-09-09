Imports System.Runtime.InteropServices
Imports System.Web
Imports MySql.Data.MySqlClient

Public Class adminUsers

    Private Sub adminUsers_Load(sender As Object, e As EventArgs) Handles Me.Load

        LoadUsers()

    End Sub

    Private Sub LoadUsers()
        Dim dt As New DataTable()

        Using con As New MySqlConnection(conString)
            con.Open()

            Dim query As String = "
                SELECT 
                    user_id, 
                    first_name, 
                    last_name, 
                    department_name,
                    email,
                    photo
                FROM users;
            "

            Using adapter As New MySqlDataAdapter(query, con)
                adapter.Fill(dt)
            End Using
        End Using

        dgvUsers.Columns.Clear()
        dgvUsers.Rows.Clear()

        Dim imgCol As New DataGridViewImageColumn()
        imgCol.HeaderText = ""
        imgCol.Name = "Photo"
        imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom
        dgvUsers.Columns.Add(imgCol)

        dgvUsers.Columns.Add("User ID", "User ID")
        dgvUsers.Columns.Add("FullName", "Full Name")
        dgvUsers.Columns.Add("Department", "Department")

        For Each row As DataRow In dt.Rows
            Dim img As Byte() = If(IsDBNull(row("photo")), Nothing, DirectCast(row("photo"), Byte()))
            Dim resizedPhoto As Image = Nothing

            If img IsNot Nothing Then
                Using ms As New IO.MemoryStream(img)
                    Dim originalPhoto As Image = Image.FromStream(ms)
                    resizedPhoto = New Bitmap(originalPhoto, New Size(40, 40))
                End Using
            End If

            Dim fullName As String = row("first_name").ToString() & " " & row("last_name").ToString()
            Dim empId As String = row("user_id").ToString()
            Dim dept As String = row("department_name").ToString()

            dgvUsers.Rows.Add(resizedPhoto, empId, fullName, dept)
        Next

        dgvUsers.RowTemplate.Height = 50
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadUsers()
    End Sub

    Private Sub dgvUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellClick
        If e.RowIndex >= 0 Then
            Dim userId As String = dgvUsers.Rows(e.RowIndex).Cells("User ID").Value.ToString()
            selectedUser = userId


            Using con As New MySqlConnection(conString)
                con.Open()

                Dim query As String = "
                    SELECT 
                        user_id, 
                        first_name, 
                        last_name, 
                        department_name, 
                        email, 
                        photo
                    FROM users
                    WHERE user_id = @userId
                "

                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@userId", userId)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            lblUserID.Text = reader("user_id").ToString()
                            lblName.Text = reader("first_name").ToString() & " " & reader("last_name").ToString()
                            lblDepartment.Text = reader("department_name").ToString()
                            lblEmail.Text = reader("email").ToString()

                            If Not IsDBNull(reader("photo")) Then
                                Dim imgBytes As Byte() = DirectCast(reader("photo"), Byte())
                                Using ms As New IO.MemoryStream(imgBytes)
                                    pbUser.Image = Image.FromStream(ms)
                                    pbUser.SizeMode = PictureBoxSizeMode.StretchImage
                                End Using
                            Else
                                pbUser.Image = Nothing
                            End If
                        End If
                    End Using
                End Using
            End Using
        End If
    End Sub


    Private registrationForm As adminRegister
    Private editForm As adminEdit

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If registrationForm Is Nothing OrElse registrationForm.IsDisposed Then
            registrationForm = New adminRegister()
            AddHandler registrationForm.DataSaved, AddressOf OnDataSaved
        End If

        registrationForm.Show()
        registrationForm.BringToFront()
    End Sub

    Private Sub OnDataSaved()
        LoadUsers()
    End Sub

    Private Sub OnDataUpdated()
        ' Refresh grid
        LoadUsers()

        ' Reselect the updated user in grid and refresh labels/picture
        For Each row As DataGridViewRow In dgvUsers.Rows
            If row.Cells("User ID").Value.ToString() = selectedUser Then
                row.Selected = True
                dgvUsers.CurrentCell = row.Cells(1) ' move selection to avoid nulls
                dgvUsers_CellClick(Nothing, New DataGridViewCellEventArgs(row.Cells("User ID").ColumnIndex, row.Index))
                Exit For
            End If
        Next
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        If lblUserID.Text = "USER ID" Then
            MessageBox.Show("No User ID provided. Select a user first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            If editForm Is Nothing OrElse editForm.IsDisposed Then
                editForm = New adminEdit()
                AddHandler editForm.DataUpdated, AddressOf OnDataUpdated
            End If

            editForm.Show()
            editForm.BringToFront()
        End If
    End Sub

End Class
