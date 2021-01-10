Imports Mooville.QUno.Model

Public Class WildColorForm
    Public Property WildColor As Color

    Private Sub WildColorForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        listColors.SelectedIndex = 0
    End Sub

    Private Sub ButtonOk_Click(sender As Object, e As EventArgs) Handles buttonOk.Click
        Dim colorName As String = listColors.SelectedItem
        Select Case colorName
            Case "Red"
                WildColor = Color.Red
            Case "Blue"
                WildColor = Color.Blue
            Case "Yellow"
                WildColor = Color.Yellow
            Case "Green"
                WildColor = Color.Green
        End Select
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub ListColors_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listColors.SelectedIndexChanged
        If listColors.SelectedIndex >= 0 Then
            buttonOk.Enabled = True
        Else
            buttonOk.Enabled = False
        End If
    End Sub
End Class