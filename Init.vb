Public Class Init
    Public Shared Sub Initialize()
        Mem.Version = ClarkTribeGames.Converters.GetVersion(Application.ProductVersion)
        Mem.UpdaterD = ClarkTribeGames.MySQLReader.Query(LCase(Mem.Updater).Replace(".exe", ""), "d")
        If System.IO.File.Exists(Mem.Updater) Then
            If System.IO.File.GetLastWriteTime(Mem.Updater) < Convert.ToDateTime(Mem.UpdaterD) Then
                System.IO.File.Delete(Mem.Updater)
                ClarkTribeGames.Updater.GetUpdater()
            End If
        Else
            ClarkTribeGames.Updater.GetUpdater()
        End If
        Mem.Available = ClarkTribeGames.MySQLReader.Query(LCase(Application.ProductName.ToString()), "v")
        Mem.UpdateU = ClarkTribeGames.MySQLReader.Query(LCase(Application.ProductName.ToString()), "u")
        ClarkTribeGames.Updater.Checker(Mem.Version, Mem.Available)
        If Not System.IO.File.Exists(Mem.CoinFile) Then Engine.BuildCoinFile()
        Engine.BuildDrop(Main.CoinDrop)
        Main.ProductLabel.Text = Mem.AppName & " v" & Mem.Version & " by " & (FileVersionInfo.GetVersionInfo(System.
            Reflection.Assembly.GetEntryAssembly().Location)).CompanyName
        Engine.Load()
    End Sub

End Class
