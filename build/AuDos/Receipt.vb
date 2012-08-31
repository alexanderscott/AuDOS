Public Class Receipt

    Private Sub Receipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Time.Text = TimeOfDay.ToString
        CheckoutList.Items.Clear()
        CheckoutList.Items.AddRange(Checkout.CheckoutList.Items)
        SubLbl.Text = Checkout.SubLbl.Text
    End Sub
End Class