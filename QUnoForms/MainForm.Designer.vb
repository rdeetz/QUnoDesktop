<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.mainMenu = New System.Windows.Forms.MenuStrip()
        Me.GameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.separatorGameMenu = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mainStatus = New System.Windows.Forms.StatusStrip()
        Me.labelStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.listHumanHand = New System.Windows.Forms.ListBox()
        Me.buttonPlay = New System.Windows.Forms.Button()
        Me.buttonDraw = New System.Windows.Forms.Button()
        Me.listComputerPlayers = New System.Windows.Forms.ListBox()
        Me.labelHumanName = New System.Windows.Forms.Label()
        Me.labelHumanHand = New System.Windows.Forms.Label()
        Me.textCurrentPlayer = New System.Windows.Forms.TextBox()
        Me.labelCurrentPlayer = New System.Windows.Forms.Label()
        Me.groupGameInfo = New System.Windows.Forms.GroupBox()
        Me.labelCurrentCard = New System.Windows.Forms.Label()
        Me.textCurrentCard = New System.Windows.Forms.TextBox()
        Me.labelCurrentDirection = New System.Windows.Forms.Label()
        Me.textCurrentDirection = New System.Windows.Forms.TextBox()
        Me.labelCurrentWildColor = New System.Windows.Forms.Label()
        Me.textCurrentWildColor = New System.Windows.Forms.TextBox()
        Me.labelComputerPlayers = New System.Windows.Forms.Label()
        Me.listGameLog = New System.Windows.Forms.ListBox()
        Me.mainMenu.SuspendLayout()
        Me.mainStatus.SuspendLayout()
        Me.groupGameInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainMenu
        '
        Me.mainMenu.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.mainMenu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.mainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GameToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mainMenu.Location = New System.Drawing.Point(0, 0)
        Me.mainMenu.Name = "mainMenu"
        Me.mainMenu.Size = New System.Drawing.Size(998, 40)
        Me.mainMenu.TabIndex = 0
        '
        'GameToolStripMenuItem
        '
        Me.GameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.separatorGameMenu, Me.ExitToolStripMenuItem})
        Me.GameToolStripMenuItem.Name = "GameToolStripMenuItem"
        Me.GameToolStripMenuItem.Size = New System.Drawing.Size(97, 36)
        Me.GameToolStripMenuItem.Text = "&Game"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(283, 44)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'separatorGameMenu
        '
        Me.separatorGameMenu.Name = "separatorGameMenu"
        Me.separatorGameMenu.Size = New System.Drawing.Size(280, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(283, 44)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(90, 36)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(248, 44)
        Me.OptionsToolStripMenuItem.Text = "&Options..."
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(85, 36)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(283, 44)
        Me.AboutToolStripMenuItem.Text = "&About QUno"
        '
        'mainStatus
        '
        Me.mainStatus.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.mainStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelStatus})
        Me.mainStatus.Location = New System.Drawing.Point(0, 655)
        Me.mainStatus.Name = "mainStatus"
        Me.mainStatus.Size = New System.Drawing.Size(998, 42)
        Me.mainStatus.TabIndex = 1
        '
        'labelStatus
        '
        Me.labelStatus.Name = "labelStatus"
        Me.labelStatus.Size = New System.Drawing.Size(79, 32)
        Me.labelStatus.Text = "Ready"
        '
        'listHumanHand
        '
        Me.listHumanHand.FormattingEnabled = True
        Me.listHumanHand.ItemHeight = 32
        Me.listHumanHand.Location = New System.Drawing.Point(12, 107)
        Me.listHumanHand.Name = "listHumanHand"
        Me.listHumanHand.Size = New System.Drawing.Size(381, 164)
        Me.listHumanHand.TabIndex = 4
        '
        'buttonPlay
        '
        Me.buttonPlay.Location = New System.Drawing.Point(399, 107)
        Me.buttonPlay.Name = "buttonPlay"
        Me.buttonPlay.Size = New System.Drawing.Size(75, 23)
        Me.buttonPlay.TabIndex = 5
        Me.buttonPlay.Text = "&Play"
        Me.buttonPlay.UseVisualStyleBackColor = True
        '
        'buttonDraw
        '
        Me.buttonDraw.Location = New System.Drawing.Point(399, 136)
        Me.buttonDraw.Name = "buttonDraw"
        Me.buttonDraw.Size = New System.Drawing.Size(75, 23)
        Me.buttonDraw.TabIndex = 6
        Me.buttonDraw.Text = "&Draw"
        Me.buttonDraw.UseVisualStyleBackColor = True
        '
        'listComputerPlayers
        '
        Me.listComputerPlayers.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listComputerPlayers.FormattingEnabled = True
        Me.listComputerPlayers.ItemHeight = 32
        Me.listComputerPlayers.Location = New System.Drawing.Point(12, 363)
        Me.listComputerPlayers.Name = "listComputerPlayers"
        Me.listComputerPlayers.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.listComputerPlayers.Size = New System.Drawing.Size(974, 164)
        Me.listComputerPlayers.TabIndex = 17
        Me.listComputerPlayers.TabStop = False
        '
        'labelHumanName
        '
        Me.labelHumanName.AutoSize = True
        Me.labelHumanName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelHumanName.Location = New System.Drawing.Point(12, 40)
        Me.labelHumanName.Name = "labelHumanName"
        Me.labelHumanName.Size = New System.Drawing.Size(145, 32)
        Me.labelHumanName.TabIndex = 2
        Me.labelHumanName.Text = "(No player)"
        '
        'labelHumanHand
        '
        Me.labelHumanHand.AutoSize = True
        Me.labelHumanHand.Location = New System.Drawing.Point(12, 72)
        Me.labelHumanHand.Name = "labelHumanHand"
        Me.labelHumanHand.Size = New System.Drawing.Size(77, 32)
        Me.labelHumanHand.TabIndex = 3
        Me.labelHumanHand.Text = "&Hand:"
        '
        'textCurrentPlayer
        '
        Me.textCurrentPlayer.Location = New System.Drawing.Point(222, 32)
        Me.textCurrentPlayer.Name = "textCurrentPlayer"
        Me.textCurrentPlayer.ReadOnly = True
        Me.textCurrentPlayer.Size = New System.Drawing.Size(278, 39)
        Me.textCurrentPlayer.TabIndex = 9
        Me.textCurrentPlayer.TabStop = False
        '
        'labelCurrentPlayer
        '
        Me.labelCurrentPlayer.AutoSize = True
        Me.labelCurrentPlayer.Location = New System.Drawing.Point(6, 35)
        Me.labelCurrentPlayer.Name = "labelCurrentPlayer"
        Me.labelCurrentPlayer.Size = New System.Drawing.Size(172, 32)
        Me.labelCurrentPlayer.TabIndex = 8
        Me.labelCurrentPlayer.Text = "Current player:"
        '
        'groupGameInfo
        '
        Me.groupGameInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupGameInfo.Controls.Add(Me.labelCurrentPlayer)
        Me.groupGameInfo.Controls.Add(Me.textCurrentPlayer)
        Me.groupGameInfo.Controls.Add(Me.labelCurrentCard)
        Me.groupGameInfo.Controls.Add(Me.textCurrentCard)
        Me.groupGameInfo.Controls.Add(Me.labelCurrentDirection)
        Me.groupGameInfo.Controls.Add(Me.textCurrentDirection)
        Me.groupGameInfo.Controls.Add(Me.labelCurrentWildColor)
        Me.groupGameInfo.Controls.Add(Me.textCurrentWildColor)
        Me.groupGameInfo.Location = New System.Drawing.Point(480, 72)
        Me.groupGameInfo.Name = "groupGameInfo"
        Me.groupGameInfo.Size = New System.Drawing.Size(506, 232)
        Me.groupGameInfo.TabIndex = 7
        Me.groupGameInfo.TabStop = False
        Me.groupGameInfo.Text = "Game Info"
        '
        'labelCurrentCard
        '
        Me.labelCurrentCard.AutoSize = True
        Me.labelCurrentCard.Location = New System.Drawing.Point(6, 80)
        Me.labelCurrentCard.Name = "labelCurrentCard"
        Me.labelCurrentCard.Size = New System.Drawing.Size(152, 32)
        Me.labelCurrentCard.TabIndex = 10
        Me.labelCurrentCard.Text = "Current card:"
        '
        'textCurrentCard
        '
        Me.textCurrentCard.Location = New System.Drawing.Point(222, 77)
        Me.textCurrentCard.Name = "textCurrentCard"
        Me.textCurrentCard.ReadOnly = True
        Me.textCurrentCard.Size = New System.Drawing.Size(278, 39)
        Me.textCurrentCard.TabIndex = 11
        Me.textCurrentCard.TabStop = False
        '
        'labelCurrentDirection
        '
        Me.labelCurrentDirection.AutoSize = True
        Me.labelCurrentDirection.Location = New System.Drawing.Point(6, 125)
        Me.labelCurrentDirection.Name = "labelCurrentDirection"
        Me.labelCurrentDirection.Size = New System.Drawing.Size(201, 32)
        Me.labelCurrentDirection.TabIndex = 12
        Me.labelCurrentDirection.Text = "Current direction:"
        '
        'textCurrentDirection
        '
        Me.textCurrentDirection.Location = New System.Drawing.Point(222, 122)
        Me.textCurrentDirection.Name = "textCurrentDirection"
        Me.textCurrentDirection.ReadOnly = True
        Me.textCurrentDirection.Size = New System.Drawing.Size(278, 39)
        Me.textCurrentDirection.TabIndex = 13
        Me.textCurrentDirection.TabStop = False
        '
        'labelCurrentWildColor
        '
        Me.labelCurrentWildColor.AutoSize = True
        Me.labelCurrentWildColor.Location = New System.Drawing.Point(6, 170)
        Me.labelCurrentWildColor.Name = "labelCurrentWildColor"
        Me.labelCurrentWildColor.Size = New System.Drawing.Size(210, 32)
        Me.labelCurrentWildColor.TabIndex = 14
        Me.labelCurrentWildColor.Text = "Current wild color:"
        '
        'textCurrentWildColor
        '
        Me.textCurrentWildColor.Location = New System.Drawing.Point(222, 167)
        Me.textCurrentWildColor.Name = "textCurrentWildColor"
        Me.textCurrentWildColor.ReadOnly = True
        Me.textCurrentWildColor.Size = New System.Drawing.Size(278, 39)
        Me.textCurrentWildColor.TabIndex = 15
        Me.textCurrentWildColor.TabStop = False
        '
        'labelComputerPlayers
        '
        Me.labelComputerPlayers.AutoSize = True
        Me.labelComputerPlayers.Location = New System.Drawing.Point(13, 328)
        Me.labelComputerPlayers.Name = "labelComputerPlayers"
        Me.labelComputerPlayers.Size = New System.Drawing.Size(209, 32)
        Me.labelComputerPlayers.TabIndex = 16
        Me.labelComputerPlayers.Text = "&Computer players:"
        '
        'listGameLog
        '
        Me.listGameLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listGameLog.BackColor = System.Drawing.SystemColors.Control
        Me.listGameLog.FormattingEnabled = True
        Me.listGameLog.ItemHeight = 32
        Me.listGameLog.Location = New System.Drawing.Point(12, 533)
        Me.listGameLog.Name = "listGameLog"
        Me.listGameLog.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.listGameLog.Size = New System.Drawing.Size(974, 100)
        Me.listGameLog.TabIndex = 18
        Me.listGameLog.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 697)
        Me.Controls.Add(Me.labelHumanName)
        Me.Controls.Add(Me.labelHumanHand)
        Me.Controls.Add(Me.listHumanHand)
        Me.Controls.Add(Me.buttonPlay)
        Me.Controls.Add(Me.buttonDraw)
        Me.Controls.Add(Me.groupGameInfo)
        Me.Controls.Add(Me.labelComputerPlayers)
        Me.Controls.Add(Me.listComputerPlayers)
        Me.Controls.Add(Me.listGameLog)
        Me.Controls.Add(Me.mainMenu)
        Me.Controls.Add(Me.mainStatus)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mainMenu
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QUno"
        Me.mainMenu.ResumeLayout(False)
        Me.mainMenu.PerformLayout()
        Me.mainStatus.ResumeLayout(False)
        Me.mainStatus.PerformLayout()
        Me.groupGameInfo.ResumeLayout(False)
        Me.groupGameInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mainMenu As MenuStrip
    Friend WithEvents GameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents separatorGameMenu As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mainStatus As StatusStrip
    Friend WithEvents labelStatus As ToolStripStatusLabel
    Friend WithEvents listHumanHand As ListBox
    Friend WithEvents buttonPlay As Button
    Friend WithEvents buttonDraw As Button
    Friend WithEvents listComputerPlayers As ListBox
    Friend WithEvents labelHumanName As Label
    Friend WithEvents labelHumanHand As Label
    Friend WithEvents textCurrentPlayer As TextBox
    Friend WithEvents labelCurrentPlayer As Label
    Friend WithEvents groupGameInfo As GroupBox
    Friend WithEvents labelCurrentWildColor As Label
    Friend WithEvents textCurrentWildColor As TextBox
    Friend WithEvents textCurrentDirection As TextBox
    Friend WithEvents labelCurrentDirection As Label
    Friend WithEvents textCurrentCard As TextBox
    Friend WithEvents labelCurrentCard As Label
    Friend WithEvents labelComputerPlayers As Label
    Friend WithEvents listGameLog As ListBox
End Class
