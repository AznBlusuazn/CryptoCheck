Public Class Updater
    Public Shared Function Checker(curver As String, avaver As String) As Boolean
        Dim currentver, availver As Long
        currentver = CLng(Replace(curver, ".", ""))
        availver = CLng(Replace(avaver, ".", ""))
        If availver > currentver Then Return True Else Return False
    End Function
    Public Shared Sub InstallUpdate()
        Dim pHelp As New ProcessStartInfo With {
            .FileName = ".\" & Mem.Updater,
            .Arguments = "-Path " & Application.ProductName & " -Dir " &
            (System.IO.Path.GetDirectoryName(System.Reflection.Assembly.
            GetExecutingAssembly().CodeBase)).Substring(6) & " -URL " &
            Mem.UpdateU,
            .UseShellExecute = True,
            .WindowStyle = ProcessWindowStyle.Normal
        }
        Dim proc As Process = Process.Start(pHelp)
    End Sub

End Class
