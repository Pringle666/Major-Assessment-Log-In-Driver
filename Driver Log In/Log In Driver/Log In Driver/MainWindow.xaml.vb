Imports System.Data.OleDb

Class MainWindow
    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        connecttodatabase()
    End Sub

    Private Sub Window_Closing(sender As Object, e As ComponentModel.CancelEventArgs)
        disconnectfromdatabase()
    End Sub

    Private Sub BtnLogIn_Click(sender As Object, e As RoutedEventArgs) Handles BtnLogIn.Click
        'Try
        'build the query
        Dim q As String = "SELECT * FROM User"

            'execute the query
            Dim cmd As New OleDbCommand(q, connection)
            Dim reader As OleDbDataReader = cmd.ExecuteReader
            Dim username As String
            Dim password As String

            While reader.Read
                username = reader("Username")
                password = reader("Password")
                If TxtbxUsername.Text = username & TXTbxPassword.Password = password Then
                    MsgBox("working")
                End If
            End While

            reader.Close()
            'Catch x As OleDbException
        '   TxtDisplay.Text = x.ToString
        'End Try
    End Sub
End Class
