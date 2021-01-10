Imports System.Reflection

Public Class AboutForm
    Private Sub AboutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim version As Version = Assembly.GetExecutingAssembly().GetName().Version
        labelVersion.Text = String.Format(labelVersion.Text, version.ToString())
    End Sub
End Class