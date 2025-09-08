Imports System.Runtime.InteropServices
Imports System.Web
Imports MySql.Data.MySqlClient

Public Class adminUsers
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
End Class