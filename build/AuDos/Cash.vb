Public Class Cash
    Dim payment As Boolean = False

    Private Sub Cash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CheckoutList.Items.Clear()
        CheckoutList.Items.AddRange(Order.OrderList.Items)
        SubLbl.Text = Order.TotalLbl.Text
        SwipeLbl.Text = "Please enter bills and any change..."
        payment = False
    End Sub

    Private Sub CashInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CashInsert.Click
        SwipeLbl.Text = TotalLbl.Text
        payment = True
    End Sub

    Private Sub PayBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PayBtn.Click
        If payment = True Then
            SwipeLbl.Text = "Please enter bills and any change..."
            Order.clearOrder()
            Me.Hide()
            Finalfrm.Show()
            Receipt.Show()
        End If
        If payment = False Then
            SwipeLbl.Text = "Not enough $"
        End If

    End Sub

    Private Sub ReturnBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturnBtn.Click
        SwipeLbl.Text = "$0.00"
        payment = False
    End Sub

    Private Sub BackButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackButton.Click
        SwipeLbl.Text = "Please enter bills and any change..."
        Me.Hide()
        Checkout.Show()
    End Sub

    Private Sub QuitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitButton.Click
        SwipeLbl.Text = "Please enter bills and any change..."
        Me.Hide()
        Order.clearOrder()
        Start.Show()
    End Sub

    Private Sub Help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Help.Click
        MsgBox("Please see bartender for assistance or questions.", MsgBoxStyle.MsgBoxHelp, Title:="Help!")
    End Sub
End Class