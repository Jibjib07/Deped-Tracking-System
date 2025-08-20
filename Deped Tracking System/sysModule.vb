Imports System.Data.OleDb
Imports System.Windows.Controls

Module sysModule

    Dim conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\MSI 10\Desktop\Deped Tracking System\Deped.accdb"
    Public con As New OleDbConnection(conString)

End Module
