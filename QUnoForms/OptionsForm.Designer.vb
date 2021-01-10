<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionsForm
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
        Me.buttonOk = New System.Windows.Forms.Button()
        Me.buttonCancel = New System.Windows.Forms.Button()
        Me.labelDefaultPlayerName = New System.Windows.Forms.Label()
        Me.textDefaultPlayerName = New System.Windows.Forms.TextBox()
        Me.labelDefaultComputerPlayers = New System.Windows.Forms.Label()
        Me.spinDefaultComputerPlayers = New System.Windows.Forms.NumericUpDown()
        CType(Me.spinDefaultComputerPlayers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'buttonOk
        '
        Me.buttonOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonOk.Location = New System.Drawing.Point(206, 194)
        Me.buttonOk.Name = "buttonOk"
        Me.buttonOk.Size = New System.Drawing.Size(75, 23)
        Me.buttonOk.TabIndex = 4
        Me.buttonOk.Text = "OK"
        Me.buttonOk.UseVisualStyleBackColor = True
        '
        'buttonCancel
        '
        Me.buttonCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.buttonCancel.Location = New System.Drawing.Point(287, 194)
        Me.buttonCancel.Name = "buttonCancel"
        Me.buttonCancel.Size = New System.Drawing.Size(75, 23)
        Me.buttonCancel.TabIndex = 5
        Me.buttonCancel.Text = "Cancel"
        Me.buttonCancel.UseVisualStyleBackColor = True
        '
        'labelDefaultPlayerName
        '
        Me.labelDefaultPlayerName.AutoSize = True
        Me.labelDefaultPlayerName.Location = New System.Drawing.Point(12, 9)
        Me.labelDefaultPlayerName.Name = "labelDefaultPlayerName"
        Me.labelDefaultPlayerName.Size = New System.Drawing.Size(151, 32)
        Me.labelDefaultPlayerName.TabIndex = 0
        Me.labelDefaultPlayerName.Text = "&Player name:"
        '
        'textDefaultPlayerName
        '
        Me.textDefaultPlayerName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textDefaultPlayerName.Location = New System.Drawing.Point(18, 44)
        Me.textDefaultPlayerName.Name = "textDefaultPlayerName"
        Me.textDefaultPlayerName.Size = New System.Drawing.Size(344, 39)
        Me.textDefaultPlayerName.TabIndex = 1
        '
        'labelDefaultComputerPlayers
        '
        Me.labelDefaultComputerPlayers.AutoSize = True
        Me.labelDefaultComputerPlayers.Location = New System.Drawing.Point(12, 86)
        Me.labelDefaultComputerPlayers.Name = "labelDefaultComputerPlayers"
        Me.labelDefaultComputerPlayers.Size = New System.Drawing.Size(329, 32)
        Me.labelDefaultComputerPlayers.TabIndex = 2
        Me.labelDefaultComputerPlayers.Text = "&Number of computer players:"
        '
        'spinDefaultComputerPlayers
        '
        Me.spinDefaultComputerPlayers.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.spinDefaultComputerPlayers.Location = New System.Drawing.Point(18, 121)
        Me.spinDefaultComputerPlayers.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.spinDefaultComputerPlayers.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.spinDefaultComputerPlayers.Name = "spinDefaultComputerPlayers"
        Me.spinDefaultComputerPlayers.Size = New System.Drawing.Size(344, 39)
        Me.spinDefaultComputerPlayers.TabIndex = 3
        Me.spinDefaultComputerPlayers.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'OptionsForm
        '
        Me.AcceptButton = Me.buttonOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.buttonCancel
        Me.ClientSize = New System.Drawing.Size(374, 229)
        Me.Controls.Add(Me.labelDefaultPlayerName)
        Me.Controls.Add(Me.textDefaultPlayerName)
        Me.Controls.Add(Me.labelDefaultComputerPlayers)
        Me.Controls.Add(Me.spinDefaultComputerPlayers)
        Me.Controls.Add(Me.buttonOk)
        Me.Controls.Add(Me.buttonCancel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OptionsForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Options"
        CType(Me.spinDefaultComputerPlayers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents buttonOk As Button
    Friend WithEvents buttonCancel As Button
    Friend WithEvents labelDefaultPlayerName As Label
    Friend WithEvents textDefaultPlayerName As TextBox
    Friend WithEvents labelDefaultComputerPlayers As Label
    Friend WithEvents spinDefaultComputerPlayers As NumericUpDown
End Class
