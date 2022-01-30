Public Class Mem

    Public Shared Version As String
    Public Shared Available As String
    Public Shared Updater As String = "CTGUpdater.exe"
    Public Shared UpdaterD As String
    Public Shared UpdateU As String
    Public Shared AppName As String = Application.ProductName
    Public Shared TheMagic As String = Application.CompanyName.Substring(0, Application.CompanyName.Length - 4)
    Public Shared CoinInfo As String
    Public Shared SettingsFile As String = $"{AppName}.settings"
    Public Shared CoinFile As String = $"{AppName}.coins"
    Public Shared CoinList As New List(Of String)
    Public Shared UserList As New List(Of String)
End Class
