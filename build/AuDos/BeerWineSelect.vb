Public Class BeerWineSelect
    Private Sub BackButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackButton.Click
        Order.MdiParent = InitialSelect
        Me.Hide()
        InitialSelect.Show()
        Order.Show()
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
    Private Sub Help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Help.Click
        MsgBox("Please see bartender for assistance or questions.", MsgBoxStyle.MsgBoxHelp, Title:="Help!")
    End Sub

    Private Sub DraftButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DraftButton.Click
        Order.MdiParent = DraftSelect
        Me.Hide()
        DraftSelect.Show()
        Order.Show()
    End Sub

    Private Sub BottleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BottleButton.Click
        Order.MdiParent = BottleSelect
        Me.Hide()
        BottleSelect.Show()
        Order.Show()
    End Sub

    Private Sub PitcherButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PitcherButton.Click
        Order.MdiParent = PitcherSelect
        Me.Hide()
        PitcherSelect.Show()
        Order.Show()
    End Sub

    Private Sub RedWineButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedWineButton.Click
        Order.MdiParent = RedWineSelect
        Me.Hide()
        RedWineSelect.Show()
        Order.Show()
    End Sub

    Private Sub WhiteWineButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WhiteWineButton.Click
        Order.MdiParent = WhiteWineSelect
        Me.Hide()
        WhiteWineSelect.Show()
        Order.Show()
    End Sub

    Private Sub BeerWineSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
End Class