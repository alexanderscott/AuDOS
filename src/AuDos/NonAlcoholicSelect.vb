Public Class NonAlcoholicSelect
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
        MsgBox("A member of the bar staff will see you shortly.", MsgBoxStyle.MsgBoxHelp, Title:="Help!")
    End Sub
    Private Sub NonAlcoholicSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        NonAlcoholicList.Items.Add("$1.00 Coke")
        NonAlcoholicList.Items.Add("$1.00 Diet Coke")
        NonAlcoholicList.Items.Add("$1.00 Tonic Water")
        NonAlcoholicList.Items.Add("$1.50 Orange Juice")
        NonAlcoholicList.Items.Add("$1.50 Cranberry Juice")
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
        DrinkPrice = Mid$(NonAlcoholicList.SelectedItem, 2, 4)
        Convert.ToDouble(DrinkPrice)

        Dim DrinkNameStr As String
        DrinkNameStr = Mid$(NonAlcoholicList.SelectedItem, 7, 100)

        Call Order.addOrder(DrinkPrice, DrinkNameStr)
    End Sub
End Class