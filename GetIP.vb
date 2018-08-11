Private Function GetIPv4Address() As String
    GetIPv4Address = String.Empty
    Dim strHostName As String = System.Net.Dns.GetHostName()
    Dim iphe As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(strHostName)
    For Each ipheal As System.Net.IPAddress In iphe.AddressList
        If ipheal.AddressFamily = System.Net.Sockets.AddressFamily.InterNetwork Then
            GetIPv4Address = ipheal.ToString()
        End If
    Next
End Function