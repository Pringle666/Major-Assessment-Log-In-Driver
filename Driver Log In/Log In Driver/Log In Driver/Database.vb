Imports System.Data.OleDb
Module Database
    Public connection As OleDbConnection

    Sub connecttodatabase()
        'connect the connection string
        connection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jarra\Desktop\School Yr12\SDD\Student Database\Driver Log In\Log In Driver\Log In Driver\Student.accdb;")

        'open the connection
        connection.Open()

    End Sub

    Sub disconnectfromdatabase()
        'close the connection
        connection = Nothing
    End Sub

    Sub ViewUsers()
        ''build the query
        'Dim q As String = "SELECT * FROM Username"

        ''execute the query
        'Dim cmd As New OleDbCommand(q, connection)
        'Dim reader As OleDbDataReader = cmd.ExecuteReader



        'reader.Close()
    End Sub
End Module
