Public Class PitcherSelect
    Private Sub BackButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackButton.Click
        Order.MdiParent = BeerWineSelect
        Me.Hide()
        BeerWineSelect.Show()
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
    Private Sub PitcherSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PitcherList.Items.Add("$6.00 Miller Light")
        PitcherList.Items.Add("$8.00 Bud Light")
        PitcherList.Items.Add("$8.00 Budweiser")
        PitcherList.Items.Add("$8.00 Michelob Ultra")
        PitcherList.Items.Add("$9.00 Corona")
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
    Private Sub AddDrink_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddDrink.Click
        Dim DrinkPrice As String
        DrinkPrice = Mid$(PitcherList.SelectedItem, 2, 4)
        Convert.ToDouble(DrinkPrice)

        Dim DrinkNameStr As String
        DrinkNameStr = Mid$(PitcherList.SelectedItem, 7, 100)

        Call Order.addOrder(DrinkPrice, DrinkNameStr)
    End Sub
End Class