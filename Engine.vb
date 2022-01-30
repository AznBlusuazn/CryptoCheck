Public Class Engine
    Public Shared Sub BuildCoinFile()
        Dim AllInfo() As String = Coinaprika.RunQuery("all", vbNull).Split("}")
        System.IO.File.WriteAllText(Mem.CoinFile, "")
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(Mem.CoinFile, True)
        For Each Item In AllInfo
            Dim Breakdown() As String = (Item.Replace(Chr(34), "")).Split(",")
            Dim ID As String = Breakdown(0).Replace("id:", "")
            Dim Name As String = Breakdown(1).Replace("name:", "")
            Dim Symbol As String = Breakdown(2).Replace("symbol:", "")
            Dim Rank As String = Breakdown(3).Replace("rank:", "")
            Dim IsNew As String = Breakdown(4).Replace("is_new:", "")
            Dim IsOn As String = Breakdown(5).Replace("is_active:", "")
            Dim Type As String = Breakdown(6).Replace("type:", "")
            file.WriteLine($"{ID},{Name},{Symbol},{Rank},{IsNew},{IsOn},{Type}")
        Next
        file.Close()
    End Sub
    Public Shared Sub BuildDrop(drop As ComboBox)
        If System.IO.File.Exists(Mem.CoinFile) = True Then
            For Each Line As String In System.IO.File.ReadLines(Mem.CoinFile)
                Dim Breakdown() As String = Line.Split(",")
                If LCase(Breakdown(5)) = "true" Then
                    drop.Items.Add($"{Breakdown(2)} {Breakdown(1)} #{Breakdown(3)}")
                    Mem.CoinList.Add(Breakdown(0))
                End If
            Next
            drop.SelectedIndex = 0
        Else
            MsgBox($"Something is wrong with your {Mem.CoinFile} file.  Restart the application.")
            Environment.Exit(1)
        End If
    End Sub

    Public Shared Sub Load()
        If System.IO.File.Exists(Mem.SettingsFile) = True Then
            Dim Wrapper As New ClarkTribeGames.Coder(Mem.TheMagic)
            Dim Data As String = ""
            For Each Line As String In System.IO.File.ReadLines(Mem.SettingsFile)
                Data = Line
            Next
            Dim Dec As String = Toolbox.CTGExtractor(Data)
            Dim RawData As String = Wrapper.DecryptData(Dec)
            Try
                Main.SpentBox.Text = Toolbox.DoubleUp(RawData.Split(";")(0), 2)
                Main.FeesBox.Text = Toolbox.DoubleUp(RawData.Split(";")(1), 2)
            Catch
                'This means there is nothing in the settings yet.
            End Try
            Dim RawList As String = RawData.Split(";")(2)
            If Not RawList = "" Then
                    Dim SplitList() As String = RawList.Split(" ")
                    For Each Item In SplitList
                        Mem.UserList.Add(Item)
                        UpdateInventory()
                        Main.AddQuantityBox.Text = ""
                        Main.RemoveQuantityBox.Text = ""
                        Main.CoinDrop.SelectedIndex = -1
                        Main.CoinDrop.SelectedIndex = 0
                    Next
                End If
        End If
    End Sub
    Public Shared Sub ProcessValue(textbox As TextBox)
        Dim StartText As String = textbox.Text, EndText As String = ""
        If StartText.Length > 0 Then
            If StartText.StartsWith(Chr(45)) Then EndText = Chr(45)
            EndText &= Replace(StartText, Chr(45), "")
            EndText = Toolbox.DoubleUp(EndText, 2)
            If EndText.StartsWith("(") And EndText.EndsWith(")") Then
                textbox.ForeColor = Color.Red
            Else
                textbox.ForeColor = Color.WhiteSmoke
            End If
            textbox.Text = EndText
        End If
    End Sub
    Public Shared Sub CoinDropChange(drop As ComboBox)
        If drop.SelectedIndex > -1 Then
            Main.PriceBox.Enabled = True
            Dim PriceText As String = Coinaprika.RunQuery("coin", Mem.CoinList(drop.SelectedIndex)).Split(",")(5)
            PriceText = PriceText.Split(":")(1)
            Main.PriceBox.Text = Toolbox.DoubleUp(PriceText, 6)
            Main.AddCoinBox.Enabled = True
            Main.AddCoinBox.Text = drop.Text.Split(" ")(0)
            Main.RemoveCoinBox.Text = ""
            Main.AddQuantityBox.Enabled = True
            Main.AddQuantityBox.BackColor = Color.FromArgb(0, 5, 0)
            Dim CoinInfo As String = $"{($"{Main.CoinDrop.SelectedIndex},{Main.CoinDrop.Text}").Split(" ")(0)},"
            Dim Skip As Boolean = False
            For x As Integer = 0 To Mem.UserList.Count - 1
                If Skip = False Then
                    If Mem.UserList(x).StartsWith(CoinInfo) Then
                        Main.RemoveCoinBox.Text = drop.Text.Split(" ")(0)
                        Main.RemoveCoinBox.Enabled = True
                        Main.RemoveQuantityBox.Enabled = True
                        Main.RemoveQuantityBox.BackColor = Color.FromArgb(15, 0, 0)
                        Main.AddAllLink.Visible = True
                        Skip = True
                    Else
                        Main.RemoveCoinBox.Text = ""
                        Main.RemoveCoinBox.Enabled = False
                        Main.RemoveQuantityBox.Enabled = False
                        Main.RemoveQuantityBox.BackColor = Color.Black
                        Main.RemoveQuantityBox.Text = ""
                        Main.AddAllLink.Visible = False
                    End If
                End If
            Next
        End If
    End Sub
    Public Shared Sub TextFillCheck(textbox As TextBox, button As Button)
        If textbox.TextLength > 0 Or Not textbox.Text = "" Then button.Enabled = True Else button.Enabled = False
        If textbox.Text = "." Then button.Enabled = False Else button.Enabled = True
    End Sub

    Public Shared Sub DotCheck(textbox As TextBox, button As Button, type As String)
        If textbox.Text = "." Or textbox.Text = "" Then
            textbox.Text = ""
            If type = "button" Then button.Enabled = False
        Else
            Dim StartText As String = textbox.Text, EndText As String
            If StartText.Length > 0 And InStr(StartText, ".") > 0 Then
                Dim FirstDot As Integer = StartText.IndexOf(".")
                EndText = $"{StartText.Substring(0, FirstDot)}.{Replace(StartText.Substring(FirstDot + 1), ".", "")}"
                textbox.Text = EndText
            End If
        End If
    End Sub
    Public Shared Sub UpdateCoin(type As String)
        Dim CoinNumber As Integer = Main.CoinDrop.SelectedIndex
        Dim Coin As String = $"{CoinNumber},{Main.CoinDrop.Text.Split(" ")(0)},"
        Dim Quantity As String
        If type = "+" Then Quantity = Main.AddQuantityBox.Text Else Quantity = Main.RemoveQuantityBox.Text
        Dim CoinInfo As String = Coin & Quantity
        Dim Skip As Boolean = False
        For x As Integer = 0 To Mem.UserList.Count - 1
            If Mem.UserList(x).StartsWith(Coin) Then
                Dim OldQuantity As Double = CDbl(Mem.UserList(x).Split(",")(2))
                Dim NewQuantity As Double
                If type = "+" Then NewQuantity = OldQuantity + CDbl(Quantity) Else NewQuantity = OldQuantity - CDbl(Quantity)
                CoinInfo = Coin & NewQuantity
                If NewQuantity <= 0 Then Mem.UserList.RemoveAt(x) Else Mem.UserList(x) = CoinInfo
                Skip = True
            End If
        Next
        If Skip = False Then Mem.UserList.Add(CoinInfo)
        UpdateInventory()
        Main.AddQuantityBox.Text = ""
        Main.RemoveQuantityBox.Text = ""
        Main.CoinDrop.SelectedIndex = -1
        Main.CoinDrop.SelectedIndex = CoinNumber
    End Sub
    Public Shared Sub UpdateInventory()
        Dim Gross As Double = 0.00
        Main.InventoryBox.Text = ""
        For Each Item As String In Mem.UserList
            Dim Num As Long = CLng(Item.Split(",")(0))
            Dim Coin As String = Item.Split(",")(1)
            Dim Amount As Double = CDbl(Item.Split(",")(2))
            Dim PriceText As String = Coinaprika.RunQuery("coin", Mem.CoinList(Num)).Split(",")(5)
            Dim Price As Double = CDbl(PriceText.Split(":")(1))
            Dim Total As Double = Amount * Price
            Toolbox.AddToRich(Main.InventoryBox, Coin, Color.Green)
            Toolbox.AddToRich(Main.InventoryBox, " x ", Color.WhiteSmoke)
            Toolbox.AddToRich(Main.InventoryBox, Amount, Color.Yellow)
            Toolbox.AddToRich(Main.InventoryBox, " @ ", Color.WhiteSmoke)
            Toolbox.AddToRich(Main.InventoryBox, Toolbox.DoubleUp(Price, 6), Color.Green)
            Toolbox.AddToRich(Main.InventoryBox, " = ", Color.WhiteSmoke)
            Toolbox.AddToRich(Main.InventoryBox, Toolbox.DoubleUp(Total, 2), Color.Red)
            Toolbox.AddToRich(Main.InventoryBox, vbCrLf, Color.WhiteSmoke)
            Gross += Total
        Next
        Main.CurrentBox.Text = Toolbox.DoubleUp(CStr(Gross), 2)
    End Sub
    Public Shared Sub AddAllLink()
        Dim CoinNumber As Integer = Main.CoinDrop.SelectedIndex
        Dim Coin As String = $"{CoinNumber},{Main.CoinDrop.Text.Split(" ")(0)},"
        Dim Quantity As String = 0
        Dim CoinInfo As String = Coin & Quantity
        For x As Integer = 0 To Mem.UserList.Count - 1
            If Mem.UserList(x).StartsWith(Coin) Then
                Quantity = CDbl(Mem.UserList(x).Split(",")(2))
            End If
        Next
        Main.RemoveQuantityBox.Text = Quantity
    End Sub
    Public Shared Sub CalculateTotals()
        Toolbox.ZeroIfBlank(Main.SpentBox)
        Toolbox.ZeroIfBlank(Main.FeesBox)
        Toolbox.ZeroIfBlank(Main.CurrentBox)
        Dim Spent As Double = CDbl(Main.SpentBox.Text)
        Dim Fees As Double = CDbl(Main.FeesBox.Text)
        Dim Gross As Double = CDbl(Main.CurrentBox.Text)
        Dim Net As Double = Gross - Spent - Fees
        Main.NetBox.Text = Toolbox.DoubleUp(Net, 2)
    End Sub
    Public Shared Sub Reset()
        Dim Answer As Integer = MsgBox($"This will reset all fields and your saved settings.{vbCrLf}" &
            $"{vbCrLf}Are you sure you want to do this?", vbYesNo + vbExclamation)
        If Not Answer = vbYes Then Exit Sub
        Mem.UserList.Clear()
        Main.SpentBox.Text = ""
        Main.FeesBox.Text = ""
        Main.AddQuantityBox.Text = ""
        Main.RemoveQuantityBox.Text = ""
        Main.InventoryBox.Text = ""
        CalculateTotals()
        Main.CoinDrop.SelectedIndex = 0
    End Sub
    Public Shared Sub Save()
        Dim Spent As String = $"{Main.SpentBox.Text};"
        Dim Fees As String = $"{Main.FeesBox.Text};"
        Dim UserInfo As String = ""
        For Each Item In Mem.UserList
            UserInfo &= $" {Item}"
        Next
        If Not UserInfo = "" Then UserInfo = UserInfo.Substring(1)
        Dim WriteText As String = $"{Spent}{Fees}{UserInfo}"
        Dim Wrapper As New ClarkTribeGames.Coder(Mem.TheMagic), WrappedUp As String, FinalText As String
        WrappedUp = Wrapper.EncryptData(WriteText)
        FinalText = Toolbox.CTGRBuilder(WrappedUp).ToString
        System.IO.File.WriteAllText(Mem.SettingsFile, "")
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(Mem.SettingsFile, True)
        file.WriteLine(FinalText)
        file.Close()
    End Sub
    Public Shared Sub About()
        MsgBox("This application was designed as a way to keep track of one's Crypto balance from one location." &
            $"{vbCrLf}{vbCrLf}This application relies on the Coinaprika API provided by api.coinaprika.com{vbCrLf}" &
            $"{vbCrLf}This application was licensed under the GNU General Public License 3.0.{vbCrLf}{vbCrLf}" &
            $"Written by ClarkTribeGames LLC.{vbCrLf}{vbCrLf}" &
            $"If you found this application useful, please consider a Donation or Patreon membership.{vbCrLf}{vbCrLf}" &
            "Thank you! ~ Geoff", vbInformation + vbOKOnly)
    End Sub
End Class
