<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.CoinDrop = New System.Windows.Forms.ComboBox()
        Me.InventoryBox = New System.Windows.Forms.RichTextBox()
        Me.SelectLabel = New System.Windows.Forms.Label()
        Me.SpentLabel = New System.Windows.Forms.Label()
        Me.FeesLabel = New System.Windows.Forms.Label()
        Me.SpentBox = New System.Windows.Forms.TextBox()
        Me.FeesBox = New System.Windows.Forms.TextBox()
        Me.NetBox = New System.Windows.Forms.TextBox()
        Me.CurrentBox = New System.Windows.Forms.TextBox()
        Me.NetLabel = New System.Windows.Forms.Label()
        Me.CurrentLabel = New System.Windows.Forms.Label()
        Me.PriceBox = New System.Windows.Forms.TextBox()
        Me.PriceLabel = New System.Windows.Forms.Label()
        Me.AddLabel = New System.Windows.Forms.Label()
        Me.AddCoinBox = New System.Windows.Forms.TextBox()
        Me.AddQuantityBox = New System.Windows.Forms.TextBox()
        Me.AddCoinLabel = New System.Windows.Forms.Label()
        Me.AddQuantityLabel = New System.Windows.Forms.Label()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.RemoveLabel = New System.Windows.Forms.Label()
        Me.RemoveQuantityLabel = New System.Windows.Forms.Label()
        Me.RemoveCoinLabel = New System.Windows.Forms.Label()
        Me.RemoveQuantityBox = New System.Windows.Forms.TextBox()
        Me.RemoveCoinBox = New System.Windows.Forms.TextBox()
        Me.AddAllLink = New System.Windows.Forms.Label()
        Me.RemoveButton = New System.Windows.Forms.Button()
        Me.MenuBar = New System.Windows.Forms.MenuStrip()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DonateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PatreonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductLabel = New System.Windows.Forms.Label()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.MenuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'CoinDrop
        '
        Me.CoinDrop.BackColor = System.Drawing.Color.Black
        Me.CoinDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CoinDrop.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.CoinDrop.FormattingEnabled = True
        Me.CoinDrop.Location = New System.Drawing.Point(8, 106)
        Me.CoinDrop.Name = "CoinDrop"
        Me.CoinDrop.Size = New System.Drawing.Size(418, 23)
        Me.CoinDrop.TabIndex = 0
        '
        'InventoryBox
        '
        Me.InventoryBox.BackColor = System.Drawing.Color.Black
        Me.InventoryBox.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.InventoryBox.Location = New System.Drawing.Point(15, 215)
        Me.InventoryBox.Name = "InventoryBox"
        Me.InventoryBox.ReadOnly = True
        Me.InventoryBox.Size = New System.Drawing.Size(600, 210)
        Me.InventoryBox.TabIndex = 1
        Me.InventoryBox.Text = ""
        '
        'SelectLabel
        '
        Me.SelectLabel.AutoSize = True
        Me.SelectLabel.Location = New System.Drawing.Point(5, 91)
        Me.SelectLabel.Name = "SelectLabel"
        Me.SelectLabel.Size = New System.Drawing.Size(203, 15)
        Me.SelectLabel.TabIndex = 2
        Me.SelectLabel.Text = "Select an Active Crypto Coin"
        '
        'SpentLabel
        '
        Me.SpentLabel.AutoSize = True
        Me.SpentLabel.Location = New System.Drawing.Point(349, 33)
        Me.SpentLabel.Name = "SpentLabel"
        Me.SpentLabel.Size = New System.Drawing.Size(77, 15)
        Me.SpentLabel.TabIndex = 5
        Me.SpentLabel.Text = "USD Spent:"
        '
        'FeesLabel
        '
        Me.FeesLabel.AutoSize = True
        Me.FeesLabel.Location = New System.Drawing.Point(349, 63)
        Me.FeesLabel.Name = "FeesLabel"
        Me.FeesLabel.Size = New System.Drawing.Size(70, 15)
        Me.FeesLabel.TabIndex = 6
        Me.FeesLabel.Text = "USD Fees:"
        '
        'SpentBox
        '
        Me.SpentBox.BackColor = System.Drawing.Color.Black
        Me.SpentBox.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.SpentBox.Location = New System.Drawing.Point(432, 30)
        Me.SpentBox.Name = "SpentBox"
        Me.SpentBox.Size = New System.Drawing.Size(183, 21)
        Me.SpentBox.TabIndex = 7
        '
        'FeesBox
        '
        Me.FeesBox.BackColor = System.Drawing.Color.Black
        Me.FeesBox.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FeesBox.Location = New System.Drawing.Point(432, 60)
        Me.FeesBox.Name = "FeesBox"
        Me.FeesBox.Size = New System.Drawing.Size(183, 21)
        Me.FeesBox.TabIndex = 8
        '
        'NetBox
        '
        Me.NetBox.BackColor = System.Drawing.Color.Black
        Me.NetBox.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.NetBox.Location = New System.Drawing.Point(116, 60)
        Me.NetBox.Name = "NetBox"
        Me.NetBox.ReadOnly = True
        Me.NetBox.Size = New System.Drawing.Size(183, 21)
        Me.NetBox.TabIndex = 12
        '
        'CurrentBox
        '
        Me.CurrentBox.BackColor = System.Drawing.Color.Black
        Me.CurrentBox.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.CurrentBox.Location = New System.Drawing.Point(116, 30)
        Me.CurrentBox.Name = "CurrentBox"
        Me.CurrentBox.ReadOnly = True
        Me.CurrentBox.Size = New System.Drawing.Size(183, 21)
        Me.CurrentBox.TabIndex = 11
        '
        'NetLabel
        '
        Me.NetLabel.AutoSize = True
        Me.NetLabel.Location = New System.Drawing.Point(33, 63)
        Me.NetLabel.Name = "NetLabel"
        Me.NetLabel.Size = New System.Drawing.Size(77, 15)
        Me.NetLabel.TabIndex = 10
        Me.NetLabel.Text = "Net Value:"
        '
        'CurrentLabel
        '
        Me.CurrentLabel.AutoSize = True
        Me.CurrentLabel.Location = New System.Drawing.Point(5, 33)
        Me.CurrentLabel.Name = "CurrentLabel"
        Me.CurrentLabel.Size = New System.Drawing.Size(105, 15)
        Me.CurrentLabel.TabIndex = 9
        Me.CurrentLabel.Text = "Current Value:"
        '
        'PriceBox
        '
        Me.PriceBox.BackColor = System.Drawing.Color.Black
        Me.PriceBox.Enabled = False
        Me.PriceBox.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.PriceBox.Location = New System.Drawing.Point(432, 106)
        Me.PriceBox.Name = "PriceBox"
        Me.PriceBox.ReadOnly = True
        Me.PriceBox.Size = New System.Drawing.Size(183, 21)
        Me.PriceBox.TabIndex = 13
        '
        'PriceLabel
        '
        Me.PriceLabel.AutoSize = True
        Me.PriceLabel.Location = New System.Drawing.Point(432, 91)
        Me.PriceLabel.Name = "PriceLabel"
        Me.PriceLabel.Size = New System.Drawing.Size(98, 15)
        Me.PriceLabel.TabIndex = 14
        Me.PriceLabel.Text = "Current Price"
        '
        'AddLabel
        '
        Me.AddLabel.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddLabel.Location = New System.Drawing.Point(40, 143)
        Me.AddLabel.Name = "AddLabel"
        Me.AddLabel.Size = New System.Drawing.Size(127, 20)
        Me.AddLabel.TabIndex = 15
        Me.AddLabel.Text = "Add To Inventory:"
        '
        'AddCoinBox
        '
        Me.AddCoinBox.BackColor = System.Drawing.Color.Black
        Me.AddCoinBox.Enabled = False
        Me.AddCoinBox.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.AddCoinBox.Location = New System.Drawing.Point(221, 140)
        Me.AddCoinBox.Name = "AddCoinBox"
        Me.AddCoinBox.ReadOnly = True
        Me.AddCoinBox.Size = New System.Drawing.Size(122, 21)
        Me.AddCoinBox.TabIndex = 16
        '
        'AddQuantityBox
        '
        Me.AddQuantityBox.BackColor = System.Drawing.Color.Black
        Me.AddQuantityBox.Enabled = False
        Me.AddQuantityBox.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.AddQuantityBox.Location = New System.Drawing.Point(432, 140)
        Me.AddQuantityBox.Name = "AddQuantityBox"
        Me.AddQuantityBox.Size = New System.Drawing.Size(97, 21)
        Me.AddQuantityBox.TabIndex = 17
        '
        'AddCoinLabel
        '
        Me.AddCoinLabel.AutoSize = True
        Me.AddCoinLabel.Location = New System.Drawing.Point(173, 143)
        Me.AddCoinLabel.Name = "AddCoinLabel"
        Me.AddCoinLabel.Size = New System.Drawing.Size(42, 15)
        Me.AddCoinLabel.TabIndex = 18
        Me.AddCoinLabel.Text = "Coin:"
        '
        'AddQuantityLabel
        '
        Me.AddQuantityLabel.AutoSize = True
        Me.AddQuantityLabel.Location = New System.Drawing.Point(349, 143)
        Me.AddQuantityLabel.Name = "AddQuantityLabel"
        Me.AddQuantityLabel.Size = New System.Drawing.Size(70, 15)
        Me.AddQuantityLabel.TabIndex = 19
        Me.AddQuantityLabel.Text = "Quantity:"
        '
        'AddButton
        '
        Me.AddButton.Enabled = False
        Me.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.AddButton.Location = New System.Drawing.Point(540, 140)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 23)
        Me.AddButton.TabIndex = 20
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'RemoveLabel
        '
        Me.RemoveLabel.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveLabel.Location = New System.Drawing.Point(5, 172)
        Me.RemoveLabel.Name = "RemoveLabel"
        Me.RemoveLabel.Size = New System.Drawing.Size(162, 18)
        Me.RemoveLabel.TabIndex = 21
        Me.RemoveLabel.Text = "Remove From Inventory:"
        '
        'RemoveQuantityLabel
        '
        Me.RemoveQuantityLabel.AutoSize = True
        Me.RemoveQuantityLabel.Location = New System.Drawing.Point(349, 172)
        Me.RemoveQuantityLabel.Name = "RemoveQuantityLabel"
        Me.RemoveQuantityLabel.Size = New System.Drawing.Size(70, 15)
        Me.RemoveQuantityLabel.TabIndex = 25
        Me.RemoveQuantityLabel.Text = "Quantity:"
        '
        'RemoveCoinLabel
        '
        Me.RemoveCoinLabel.AutoSize = True
        Me.RemoveCoinLabel.Location = New System.Drawing.Point(173, 172)
        Me.RemoveCoinLabel.Name = "RemoveCoinLabel"
        Me.RemoveCoinLabel.Size = New System.Drawing.Size(42, 15)
        Me.RemoveCoinLabel.TabIndex = 24
        Me.RemoveCoinLabel.Text = "Coin:"
        '
        'RemoveQuantityBox
        '
        Me.RemoveQuantityBox.BackColor = System.Drawing.Color.Black
        Me.RemoveQuantityBox.Enabled = False
        Me.RemoveQuantityBox.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RemoveQuantityBox.Location = New System.Drawing.Point(432, 169)
        Me.RemoveQuantityBox.Name = "RemoveQuantityBox"
        Me.RemoveQuantityBox.Size = New System.Drawing.Size(97, 21)
        Me.RemoveQuantityBox.TabIndex = 23
        '
        'RemoveCoinBox
        '
        Me.RemoveCoinBox.BackColor = System.Drawing.Color.Black
        Me.RemoveCoinBox.Enabled = False
        Me.RemoveCoinBox.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RemoveCoinBox.Location = New System.Drawing.Point(221, 169)
        Me.RemoveCoinBox.Name = "RemoveCoinBox"
        Me.RemoveCoinBox.ReadOnly = True
        Me.RemoveCoinBox.Size = New System.Drawing.Size(122, 21)
        Me.RemoveCoinBox.TabIndex = 22
        '
        'AddAllLink
        '
        Me.AddAllLink.AutoSize = True
        Me.AddAllLink.Font = New System.Drawing.Font("Courier New", 6.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddAllLink.ForeColor = System.Drawing.Color.Gold
        Me.AddAllLink.Location = New System.Drawing.Point(433, 193)
        Me.AddAllLink.Name = "AddAllLink"
        Me.AddAllLink.Size = New System.Drawing.Size(85, 12)
        Me.AddAllLink.TabIndex = 26
        Me.AddAllLink.Text = "Click To Add All"
        Me.AddAllLink.Visible = False
        '
        'RemoveButton
        '
        Me.RemoveButton.Enabled = False
        Me.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RemoveButton.Location = New System.Drawing.Point(540, 168)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(75, 23)
        Me.RemoveButton.TabIndex = 27
        Me.RemoveButton.Text = "Subtract"
        Me.RemoveButton.UseVisualStyleBackColor = True
        '
        'MenuBar
        '
        Me.MenuBar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(630, 24)
        Me.MenuBar.TabIndex = 28
        Me.MenuBar.Text = "MenuStrip1"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.AboutToolStripMenuItem, Me.CheckForUpdatesToolStripMenuItem, Me.DonateToolStripMenuItem, Me.PatreonToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.OptionsToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'CheckForUpdatesToolStripMenuItem
        '
        Me.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem"
        Me.CheckForUpdatesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CheckForUpdatesToolStripMenuItem.Text = "Check For Updates"
        '
        'DonateToolStripMenuItem
        '
        Me.DonateToolStripMenuItem.Name = "DonateToolStripMenuItem"
        Me.DonateToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DonateToolStripMenuItem.Text = "Donate"
        '
        'PatreonToolStripMenuItem
        '
        Me.PatreonToolStripMenuItem.Name = "PatreonToolStripMenuItem"
        Me.PatreonToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PatreonToolStripMenuItem.Text = "Patreon"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ProductLabel
        '
        Me.ProductLabel.AutoSize = True
        Me.ProductLabel.Location = New System.Drawing.Point(12, 433)
        Me.ProductLabel.Name = "ProductLabel"
        Me.ProductLabel.Size = New System.Drawing.Size(343, 15)
        Me.ProductLabel.TabIndex = 29
        Me.ProductLabel.Text = "CryptoCheck v1.0.000.0000 by ClarkTribeGames LLC"
        '
        'ResetButton
        '
        Me.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ResetButton.Location = New System.Drawing.Point(493, 430)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(125, 20)
        Me.ResetButton.TabIndex = 31
        Me.ResetButton.Text = "Reset Everything"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.SaveButton.Location = New System.Drawing.Point(362, 430)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(125, 20)
        Me.SaveButton.TabIndex = 32
        Me.SaveButton.Text = "Save Settings"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(630, 457)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.ProductLabel)
        Me.Controls.Add(Me.RemoveButton)
        Me.Controls.Add(Me.AddAllLink)
        Me.Controls.Add(Me.RemoveQuantityLabel)
        Me.Controls.Add(Me.RemoveCoinLabel)
        Me.Controls.Add(Me.RemoveQuantityBox)
        Me.Controls.Add(Me.RemoveCoinBox)
        Me.Controls.Add(Me.RemoveLabel)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.AddQuantityLabel)
        Me.Controls.Add(Me.AddCoinLabel)
        Me.Controls.Add(Me.AddQuantityBox)
        Me.Controls.Add(Me.AddCoinBox)
        Me.Controls.Add(Me.AddLabel)
        Me.Controls.Add(Me.PriceLabel)
        Me.Controls.Add(Me.PriceBox)
        Me.Controls.Add(Me.NetBox)
        Me.Controls.Add(Me.CurrentBox)
        Me.Controls.Add(Me.NetLabel)
        Me.Controls.Add(Me.CurrentLabel)
        Me.Controls.Add(Me.FeesBox)
        Me.Controls.Add(Me.SpentBox)
        Me.Controls.Add(Me.FeesLabel)
        Me.Controls.Add(Me.SpentLabel)
        Me.Controls.Add(Me.SelectLabel)
        Me.Controls.Add(Me.InventoryBox)
        Me.Controls.Add(Me.CoinDrop)
        Me.Controls.Add(Me.MenuBar)
        Me.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuBar
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CryptoCheck by ClarkTribeGames LLC"
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CoinDrop As ComboBox
    Friend WithEvents InventoryBox As RichTextBox
    Friend WithEvents SelectLabel As Label
    Friend WithEvents SpentLabel As Label
    Friend WithEvents FeesLabel As Label
    Friend WithEvents SpentBox As TextBox
    Friend WithEvents FeesBox As TextBox
    Friend WithEvents NetBox As TextBox
    Friend WithEvents CurrentBox As TextBox
    Friend WithEvents NetLabel As Label
    Friend WithEvents CurrentLabel As Label
    Friend WithEvents PriceBox As TextBox
    Friend WithEvents PriceLabel As Label
    Friend WithEvents AddLabel As Label
    Friend WithEvents AddCoinBox As TextBox
    Friend WithEvents AddQuantityBox As TextBox
    Friend WithEvents AddCoinLabel As Label
    Friend WithEvents AddQuantityLabel As Label
    Friend WithEvents AddButton As Button
    Friend WithEvents RemoveLabel As Label
    Friend WithEvents RemoveQuantityLabel As Label
    Friend WithEvents RemoveCoinLabel As Label
    Friend WithEvents RemoveQuantityBox As TextBox
    Friend WithEvents RemoveCoinBox As TextBox
    Friend WithEvents AddAllLink As Label
    Friend WithEvents RemoveButton As Button
    Friend WithEvents MenuBar As MenuStrip
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckForUpdatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DonateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PatreonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductLabel As Label
    Friend WithEvents ResetButton As Button
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveButton As Button
End Class
