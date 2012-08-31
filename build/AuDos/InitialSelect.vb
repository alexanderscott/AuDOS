Imports System.Collections
Imports System.Windows.Forms


Public Class InitialSelect

    Private Sub InitialSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ctl As Control
        Dim ctlMDI As MdiClient
        For Each ctl In Me.Controls
            Try
                ctlMDI = CType(ctl, MdiClient)
                ctlMDI.BackColor = Me.BackColor
            Catch exc As InvalidCastException
            End Try
        Next
        Order.MdiParent = Me
        Order.Show()
    End Sub

    Private Sub BackButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackButton.Click
        Me.Hide()
        Start.Show()

    End Sub

    Private Sub CheckoutButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckoutButton.Click
        Me.Hide()
        Checkout.ValueLoad()
        Checkout.Show()
    End Sub

    Private Sub QuitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitButton.Click
        Me.Hide()
        Order.Hide()
        Order.clearOrder()
        Start.Show()
    End Sub

    Private Sub MixedDrinkButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MixedDrinkButton.Click
        Order.MdiParent = MixedSelect
        Me.Hide()
        MixedSelect.Show()
        Order.Show()
    End Sub

    Private Sub NonAlcoholicButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NonAlcoholicButton.Click
        Order.MdiParent = NonAlcoholicSelect
        Me.Hide()
        NonAlcoholicSelect.Show()
        Order.Show()
    End Sub

    Private Sub BeerWineButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BeerWineButton.Click
        Order.MdiParent = BeerWineSelect
        Me.Hide()
        BeerWineSelect.Show()
        Order.Show()
    End Sub

    Private Sub Help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Help.Click
        MsgBox("Please see bartender for assistance or questions.", MsgBoxStyle.MsgBoxHelp, Title:="Help!")
    End Sub
End Class
