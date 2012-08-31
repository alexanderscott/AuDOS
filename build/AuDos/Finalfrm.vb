Public Class Finalfrm

    Private Sub ClickAnywhere_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClickAnywhere.Click
        Me.Hide()
        Order.Hide()
        Order.clearOrder()
        Start.Show()
    End Sub
End Class