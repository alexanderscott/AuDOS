Imports System.Collections
Imports System.Windows.Forms


Public Class Start

    Private Sub StartButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartButton.Click
        Order.MdiParent = InitialSelect
        Me.Hide()
        InitialSelect.Show()
        Order.Show()

    End Sub
End Class

