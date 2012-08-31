Public Class MixedMake
    Private Sub BackButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackButton.Click
        Order.MdiParent = MixedSelect
        Me.Hide()
        MixedSelect.Show()
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

    Private Sub MixedMake_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        AlcList.Items.Add("Bourbon")
        AlcList.Items.Add("Gin")
        AlcList.Items.Add("Rum")
        AlcList.Items.Add("Tequila")
        AlcList.Items.Add("Vodka")

        NonAlcList.Items.Add("Coke")
        NonAlcList.Items.Add("Diet Coke")
        NonAlcList.Items.Add("Cranberry Juice")
        NonAlcList.Items.Add("Orange Juice")
        NonAlcList.Items.Add("Ginger Ale")


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
        
        Dim DrinkNameStr As String
        DrinkNameStr = AlcList.SelectedItem + " / " + NonAlcList.SelectedItem

        Call Order.addOrder(5.0, DrinkNameStr)
    End Sub
End Class