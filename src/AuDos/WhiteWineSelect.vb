Public Class WhiteWineSelect
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
        MsgBox("A member of the bar staff will see you shortly.", MsgBoxStyle.MsgBoxHelp, Title:="Help!")
    End Sub
    Private Sub WhiteWineSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WhiteWineList.Items.Add("$6.00 Chardonnay")
        WhiteWineList.Items.Add("$6.00 Pinot Grigio")
        WhiteWineList.Items.Add("$6.00 Sauvignon Blanc")
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
        DrinkPrice = Mid$(WhiteWineList.SelectedItem, 2, 4)
        Convert.ToDouble(DrinkPrice)

        Dim DrinkNameStr As String
        DrinkNameStr = Mid$(WhiteWineList.SelectedItem, 7, 100)

        Call Order.addOrder(DrinkPrice, DrinkNameStr)
    End Sub
End Class