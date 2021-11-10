Public Class Mem

    Public Shared Version As String
    Public Shared Available As String
    Public Shared Updater As String = "CTGUpdater.exe"
    Public Shared UpdaterD As String = "11/10/2021"
    Public Shared AppName As String = System.Reflection.Assembly.GetExecutingAssembly().GetName.Name
    Public Shared TheMagic As String = ((FileVersionInfo.
        GetVersionInfo(System.Reflection.Assembly.GetEntryAssembly().Location)).
        CompanyName).Substring(0, ((FileVersionInfo.GetVersionInfo(System.
        Reflection.Assembly.GetEntryAssembly().Location)).CompanyName).Length - 4)
    Public Shared CoinInfo As String
    Public Shared SettingsFile As String = AppName & ".settings"
    Public Shared CoinFile As String = AppName & ".coins"
    Public Shared CoinList As New List(Of String)
    Public Shared UserList As New List(Of String)
End Class
