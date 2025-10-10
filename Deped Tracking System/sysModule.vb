Imports System.Data.OleDb
Imports System.IO
Imports MySql.Data.MySqlClient


Module sysModule
    'Public conString As String = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\MSI 10\Desktop\Deped Tracking System\Deped Tracking System\Deped Tracking System\Database\Deped.accdb"
    'Public conString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Path.GetFullPath(dbPath)};"

    '=======Local Host=========
    'Public conString As String = "Server=localhost;Database=deped;Uid=root;Pwd=;SslMode=None;"

    '=======Local Host=========
    Public conString As String = "Server=192.168.254.184;Database=deped;Uid=vbuser;Pwd=vbuser;SslMode=None;"

    '=======DEPED SERVER=========
    'Public conString As String = "Server=172.16.0.55;Database=deped;Uid=vbuser;Pwd=vbuser;SslMode=None;"


    Public userUID As String
    Public userName As String
    Public userDept As String

    Public selectedUser As String

End Module
