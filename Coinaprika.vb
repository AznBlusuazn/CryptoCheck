Public Class Coinaprika
    Public Shared Function RunQuery(type As String, coinid As String) As String
        Dim Response As String = ""
        Try
            Select Case LCase(type)
                Case "all"
                    Response = GetValue("coins")
                Case "coin"
                    Response = GetValue("coins/" & coinid & "/ohlcv/today/")
            End Select
        Catch ex As Exception
            MsgBox("Gateway Timeout:  You might be trying to do queries too fast!" & vbCrLf & vbCrLf & "Please restart the application and try again.")
            Environment.Exit(1)
        End Try
        Return Response
    End Function
    Private Shared Function GetValue(extend As String) As String
        Dim request As System.Net.WebRequest = System.Net.WebRequest.Create(
            "https://api.coinpaprika.com/v1/" & extend)
        request.Credentials = System.Net.CredentialCache.DefaultCredentials
        Dim response As System.Net.WebResponse = request.GetResponse()
        'This string is check if OK
        '(CType(response, System.Net.HttpWebResponse).StatusDescription)
        Dim dataStream As System.IO.Stream = response.GetResponseStream()
        Dim reader As New System.IO.StreamReader(dataStream)
        Dim responseFromServer As String = reader.ReadToEnd()
        reader.Close()
        response.Close()
        Return Replace(responseFromServer.Substring(2, responseFromServer.Length - 5), ",{", "")
    End Function

End Class