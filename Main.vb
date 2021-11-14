Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Init.Initialize()
    End Sub
    Private Sub TextBox_ResetColor(sender As Object, e As EventArgs) Handles SpentBox.Enter, FeesBox.Enter
        sender.ForeColor = Color.WhiteSmoke
    End Sub
    Private Sub KeyPressCheck_NegNumbers(sender As Object, e As KeyPressEventArgs) Handles _
        SpentBox.KeyPress, FeesBox.KeyPress, AddQuantityBox.KeyPress, RemoveQuantityBox.KeyPress
        e.Handled = Toolbox.TestKeyPress(e.KeyChar, "negnumbers")
    End Sub
    Private Sub KeyPressCheck_Numbers(sender As Object, e As KeyPressEventArgs) Handles _
        AddQuantityBox.KeyPress, RemoveQuantityBox.KeyPress
        e.Handled = Toolbox.TestKeyPress(e.KeyChar, "numbers")
    End Sub
    Private Sub TextBox_CheckFormat(sender As Object, e As EventArgs) Handles _
        SpentBox.Leave, FeesBox.Leave
        Engine.DotCheck(sender, ResetButton, "box")
        Engine.ProcessValue(sender)
        Engine.CalculateTotals()
    End Sub
    Private Sub CoinDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CoinDrop.SelectedIndexChanged
        Engine.CoinDropChange(sender)
    End Sub
    Private Sub AddQuantityBox_TextChanged(sender As Object, e As EventArgs) Handles AddQuantityBox.TextChanged
        Engine.TextFillCheck(sender, AddButton)
    End Sub
    Private Sub RemoveQuantityBox_TextChanged(sender As Object, e As EventArgs) Handles RemoveQuantityBox.TextChanged
        Engine.TextFillCheck(sender, RemoveButton)
    End Sub
    Private Sub AddQuantityBoxCheck(sender As Object, e As EventArgs) Handles AddQuantityBox.Leave
        Engine.DotCheck(sender, AddButton, "button")
    End Sub
    Private Sub RemoveQuantityBoxCheck(sender As Object, e As EventArgs) Handles RemoveQuantityBox.Leave
        Engine.DotCheck(sender, RemoveButton, "button")
    End Sub
    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Engine.UpdateCoin("+")
        Engine.Save()
    End Sub
    Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        Engine.UpdateCoin("-")
        Engine.Save()
    End Sub
    Private Sub AddAllLink_Click(sender As Object, e As EventArgs) Handles AddAllLink.Click
        If sender.Visible = True Then Engine.AddAllLink()
        Engine.Save()
    End Sub
    Private Sub ValueBoxesChange(sender As Object, e As EventArgs) Handles CurrentBox.TextChanged, NetBox.TextChanged
        Engine.CalculateTotals()
    End Sub
    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        Engine.Reset()
        Engine.Save()
    End Sub
    Private Sub SaveSettings(sender As Object, e As EventArgs) Handles SaveButton.Click, SaveToolStripMenuItem.Click
        Engine.Save()
    End Sub
    Private Sub CloseApp(sender As Object, e As EventArgs) Handles Me.FormClosing, Me.Closing, ExitToolStripMenuItem.Click
        Engine.Save()
        Environment.Exit(1)
    End Sub
    Private Sub ProductLabel_Click(sender As Object, e As EventArgs) Handles ProductLabel.Click
        Try
            ClarkTribeGames.Web.CTG()
        Catch ex As Exception
            MsgBox("Problem opening the web... " & vbCrLf & ex.ToString)
        End Try
    End Sub
    Private Sub ProductLabel_Hover(sender As Object, e As EventArgs) Handles ProductLabel.MouseHover
        sender.ForeColor = Color.Green
    End Sub
    Private Sub ProductLabel_Leave(sender As Object, e As EventArgs) Handles ProductLabel.MouseLeave
        sender.ForeColor = Color.WhiteSmoke
    End Sub
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Engine.About()
    End Sub
    Private Sub DonateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DonateToolStripMenuItem.Click
        Try
            ClarkTribeGames.Web.PP()
        Catch ex As Exception
            MsgBox("Problem opening the web... " & vbCrLf & ex.ToString)
        End Try
    End Sub
    Private Sub PatreonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PatreonToolStripMenuItem.Click
        Try
            ClarkTribeGames.Web.PT()
        Catch ex As Exception
            MsgBox("Problem opening the web... " & vbCrLf & ex.ToString)
        End Try
    End Sub
    Private Sub CheckForUpdatesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckForUpdatesToolStripMenuItem.Click
        If ClarkTribeGames.Updater.Checker(Mem.Version, Mem.Available) = True Then
            Dim Answer As Integer = MsgBox("Update " & Mem.Available & " Available!" & vbCrLf & vbCrLf & "Would you like to update now?", vbYesNo + vbExclamation)
            If Answer = vbYes Then ClarkTribeGames.Updater.InstallUpdate(Application.ProductName, Mem.UpdateU) Else MsgBox("Please update as soon as possible!")
        Else
            MsgBox("No Update Available!")
        End If
    End Sub
End Class
