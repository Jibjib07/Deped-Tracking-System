Imports System.Data.OleDb
Imports System.IO

Module sysModule
    Private dbPath As String = Path.Combine(Application.StartupPath, "Database\Deped.accdb")

    Public conString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Path.GetFullPath(dbPath)};"

    Public userUID As String
    Public userName As String
    Public userDept As String
End Module
