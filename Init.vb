Public Class Init
    Public Shared Sub Initialize()
        Dim VersionParts() As String = Strings.Split((System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString()), ".", 4)
        Mem.Version = VersionParts(0) & "." & VersionParts(1) & "." & Toolbox.VersionConverter(VersionParts(2), 3) & "." &
            Toolbox.VersionConverter(VersionParts(3), 4)
        Mem.Available = CTGMySQL.CTGMySQL.Query(LCase(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name.ToString()))
        If Not System.IO.File.Exists(Mem.Updater) Then System.IO.File.WriteAllBytes(Mem.Updater, My.Resources.CTGUpdater)
        Updater.Checker(Mem.Version, Mem.Available)
        If Not System.IO.File.Exists(Mem.CoinFile) Then Engine.BuildCoinFile()
        Engine.BuildDrop(Main.CoinDrop)
        Main.ProductLabel.Text = Mem.AppName & " v" & Mem.Version & " by " & (FileVersionInfo.GetVersionInfo(System.
            Reflection.Assembly.GetEntryAssembly().Location)).CompanyName
        Engine.Load()
    End Sub

End Class
