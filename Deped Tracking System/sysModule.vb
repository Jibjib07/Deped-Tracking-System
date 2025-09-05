Imports System.Data.OleDb
Imports System.IO
Imports MySql.Data.MySqlClient


Module sysModule
    Private dbPath As String = Path.Combine(Application.StartupPath, "Database\Deped.accdb")
    'Public conString As String = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\MSI 10\Desktop\Deped Tracking System\Deped Tracking System\Deped Tracking System\Database\Deped.accdb"
    'Public conString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Path.GetFullPath(dbPath)};"
    Public conString As String = "Server=localhost;Database=deped;Uid=root;Pwd=;SslMode=None;"



    Public userUID As String
    Public userName As String
    Public userDept As String
End Module
