Imports MySql.Data.MySqlClient
Imports System.Threading
Imports System.Threading.Tasks

Public Class PendingWatcher
    Private ReadOnly connStr As String
    Private ReadOnly dept As String
    Private cts As CancellationTokenSource
    Private watcherTask As Task
    Private lastSnapshot As String = ""

    Public Event PendingChanged As EventHandler

    Public Sub New(connectionString As String, department As String)
        connStr = connectionString
        dept = department
    End Sub

    Public Sub StartWatching(Optional intervalMs As Integer = 10000) ' default 10s
        If watcherTask IsNot Nothing AndAlso Not watcherTask.IsCompleted Then Return

        cts = New CancellationTokenSource()
        Dim token = cts.Token

        watcherTask = Task.Run(Async Function()
                                   While Not token.IsCancellationRequested
                                       Try
                                           Dim currentSnapshot = Await GetSnapshotAsync()

                                           If lastSnapshot <> "" AndAlso currentSnapshot <> lastSnapshot Then
                                               RaiseEvent PendingChanged(Me, EventArgs.Empty)
                                           End If

                                           lastSnapshot = currentSnapshot
                                       Catch ex As Exception
                                           ' optional: Debug.WriteLine(ex.Message)
                                       End Try

                                       Await Task.Delay(intervalMs, token)
                                   End While
                               End Function, token)
    End Sub

    Public Sub StopWatching()
        If cts Is Nothing Then Return
        cts.Cancel()
        Try
            watcherTask?.Wait(500)
        Catch
        End Try
        cts.Dispose()
        cts = Nothing
        watcherTask = Nothing
    End Sub

    ' Snapshot = concatenated IDs + modified dates
    Private Async Function GetSnapshotAsync() As Task(Of String)
        Dim result As String = ""
        Using con As New MySqlConnection(connStr)
            Await con.OpenAsync()
            Dim sql As String = "SELECT control_num, COALESCE(date_lastmodified, date_created) " &
                                "FROM Documents WHERE status='Sent' AND current_department=@dept ORDER BY control_num"
            Using cmd As New MySqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@dept", dept)
                Using reader = Await cmd.ExecuteReaderAsync()
                    While Await reader.ReadAsync()
                        result &= reader("control_num").ToString() & "|" &
                                  Convert.ToDateTime(reader(1)).ToString("yyyyMMddHHmmss") & ";"
                    End While
                End Using
            End Using
        End Using
        Return result
    End Function
End Class
