Imports System.Text
Imports System.Net.Sockets
Imports System.Net
Public Class SendRece
    Sub New()
    End Sub
    Sub Send(ByVal IP As String, ByVal msg As String)
        Try
            Dim UDPClient As New UdpClient()
            UDPClient.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, True)
            UDPClient.Connect(IP, 25566)
            Try
                Dim bytSent As Byte() = Encoding.ASCII.GetBytes(msg)
                UDPClient.Send(bytSent, bytSent.Length)
                UDPClient.Close()
            Catch e As Exception
                Console.WriteLine(e.ToString)
            End Try
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
        End Try
    End Sub
    Function Receive()
            Dim UDPClient As UdpClient = New UdpClient()
            UDPClient.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, True)
            UDPClient.Client.Bind(New IPEndPoint(IPAddress.Any, 25566))
            Try
                Dim iepRemoteEndPoint As IPEndPoint = New IPEndPoint(IPAddress.Any, 25566)
                Dim strMessage As String = String.Empty
                Dim bytReceived As Byte() = UDPClient.Receive(iepRemoteEndPoint)
                strMessage = Encoding.ASCII.GetString(bytReceived)
                UDPClient.Close()
                Return strMessage
            Catch ex As Exception
                Return ex.ToString
            End Try
    End Function
End Class