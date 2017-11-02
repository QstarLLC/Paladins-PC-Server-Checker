Imports System.Net.Sockets

Public Class Form1

    Public Function CheckPaladinsLobby()

        Dim LobbyServer As New TcpClient
        Try

            ' Ip and Port
            LobbyServer.Connect("198.255.78.87", 9000)

            ' Server Online
            status.Text = "Paladins PC is Online."
            status.ForeColor = Color.Green

        Catch Excep As Exception

            ' Server Offline
            status.Text = "Paladins PC is Offline."
            status.ForeColor = Color.Red

            ' Message the user
            'MsgBox("Login Server is currently offline, please check the forums.")

        End Try

    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckPaladinsLobby()
    End Sub
End Class
