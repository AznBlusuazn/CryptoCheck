Public Class Init
    Public Shared Sub Initialize()
        Dim VersionParts() As String = Strings.Split((System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString()), ".", 4)
        Mem.Version = VersionParts(0) & "." & VersionParts(1) & "." & Toolbox.VersionConverter(VersionParts(2), 3) & "." &
            Toolbox.VersionConverter(VersionParts(3), 4)
        Mem.UpdaterD = ClarkTribeGames.MySQLReader.Query(LCase(Mem.Updater).Replace(".exe", ""), "d")
        If System.IO.File.Exists(Mem.Updater) Then
            If System.IO.File.GetLastWriteTime(Mem.Updater) < Convert.ToDateTime(Mem.UpdaterD) Then
                System.IO.File.Delete(Mem.Updater)
                ClarkTribeGames.Updater.GetUpdater()
            End If
        Else
            ClarkTribeGames.Updater.GetUpdater()
        End If
        Mem.Available = ClarkTribeGames.MySQLReader.Query(LCase(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name.ToString()), "v")
        Mem.UpdateU = ClarkTribeGames.MySQLReader.Query(LCase(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name.ToString()), "u")
        Updater.Checker(Mem.Version, Mem.Available)
        If Not System.IO.File.Exists(Mem.CoinFile) Then Engine.BuildCoinFile()
        Engine.BuildDrop(Main.CoinDrop)
        Main.ProductLabel.Text = Mem.AppName & " v" & Mem.Version & " by " & (FileVersionInfo.GetVersionInfo(System.
            Reflection.Assembly.GetEntryAssembly().Location)).CompanyName
        Engine.Load()
    End Sub

End Class
