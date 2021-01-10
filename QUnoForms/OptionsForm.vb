Public Class OptionsForm
    Private Sub OptionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'textDefaultPlayerName.Text = My.Settings.DefaultHumanPlayerName
        'spinDefaultComputerPlayers.Value = My.Settings.DefaultComputerPlayers
    End Sub

    Private Sub ButtonOk_Click(sender As Object, e As EventArgs) Handles buttonOk.Click
        'My.Settings.DefaultHumanPlayerName = textDefaultPlayerName.Text.Trim()
        'My.Settings.DefaultComputerPlayers = spinDefaultComputerPlayers.Value
        'My.Settings.Save()
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub TextDefaultPlayerName_TextChanged(sender As Object, e As EventArgs) Handles textDefaultPlayerName.TextChanged
        If Not String.IsNullOrEmpty(textDefaultPlayerName.Text.Trim()) Then
            buttonOk.Enabled = True
        Else
            buttonOk.Enabled = False
        End If
    End Sub
End Class