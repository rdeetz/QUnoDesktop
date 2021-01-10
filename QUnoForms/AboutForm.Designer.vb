<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutForm
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
        Me.pictureIcon = New System.Windows.Forms.PictureBox()
        Me.labelTitle = New System.Windows.Forms.Label()
        Me.labelVersion = New System.Windows.Forms.Label()
        Me.labelCopyright = New System.Windows.Forms.Label()
        CType(Me.pictureIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'buttonOk
        '
        Me.buttonOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonOk.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.buttonOk.Location = New System.Drawing.Point(287, 194)
        Me.buttonOk.Name = "buttonOk"
        Me.buttonOk.Size = New System.Drawing.Size(75, 23)
        Me.buttonOk.TabIndex = 0
        Me.buttonOk.Text = "Close"
        Me.buttonOk.UseVisualStyleBackColor = True
        '
        'pictureIcon
        '
        'Me.pictureIcon.Image = Global.Mooville.QUno.Forms.My.Resources.Resources.QUno
        Me.pictureIcon.Location = New System.Drawing.Point(12, 12)
        Me.pictureIcon.Name = "pictureIcon"
        Me.pictureIcon.Size = New System.Drawing.Size(48, 48)
        Me.pictureIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pictureIcon.TabIndex = 1
        Me.pictureIcon.TabStop = False
        '
        'labelTitle
        '
        Me.labelTitle.AutoSize = True
        Me.labelTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTitle.Location = New System.Drawing.Point(66, 12)
        Me.labelTitle.Name = "labelTitle"
        Me.labelTitle.Size = New System.Drawing.Size(80, 32)
        Me.labelTitle.TabIndex = 1
        Me.labelTitle.Text = "QUno"
        '
        'labelVersion
        '
        Me.labelVersion.AutoSize = True
        Me.labelVersion.Location = New System.Drawing.Point(66, 44)
        Me.labelVersion.Name = "labelVersion"
        Me.labelVersion.Size = New System.Drawing.Size(127, 32)
        Me.labelVersion.TabIndex = 2
        Me.labelVersion.Text = "Version {0}"
        '
        'labelCopyright
        '
        Me.labelCopyright.AutoSize = True
        Me.labelCopyright.Location = New System.Drawing.Point(66, 76)
        Me.labelCopyright.Name = "labelCopyright"
        Me.labelCopyright.Size = New System.Drawing.Size(554, 32)
        Me.labelCopyright.TabIndex = 3
        Me.labelCopyright.Text = "Copyright © 2019 Roger Deetz. All rights reserved."
        '
        'AboutForm
        '
        Me.AcceptButton = Me.buttonOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.buttonOk
        Me.ClientSize = New System.Drawing.Size(374, 229)
        Me.Controls.Add(Me.pictureIcon)
        Me.Controls.Add(Me.labelTitle)
        Me.Controls.Add(Me.labelVersion)
        Me.Controls.Add(Me.labelCopyright)
        Me.Controls.Add(Me.buttonOk)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About QUno"
        CType(Me.pictureIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents buttonOk As Button
    Friend WithEvents pictureIcon As PictureBox
    Friend WithEvents labelTitle As Label
    Friend WithEvents labelVersion As Label
    Friend WithEvents labelCopyright As Label
End Class
