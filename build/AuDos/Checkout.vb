Imports System.Collections
Imports System.Windows.Forms


Public Class Checkout
    Public Sub ValueLoad()
        CheckoutList.Items.Clear()
        CheckoutList.Items.AddRange(Order.OrderList.Items)
        SubLbl.Text = Order.TotalLbl.Text
        TotalLbl.Text = SubLbl.Text
        TipLbl.Text = "- -"
    End Sub
    Private Sub Checkout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ctl As Control
        Dim ctlMDI As MdiClient
        For Each ctl In Me.Controls
            Try
                ctlMDI = CType(ctl, MdiClient)
                ctlMDI.BackColor = Me.BackColor
            Catch exc As InvalidCastException
            End Try
        Next
    End Sub
    Private Sub QuitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitButton.Click
        Me.Hide()
        Order.Hide()
        Order.clearOrder()
        Start.Show()
    End Sub
    Private Sub BackButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackButton.Click
        Order.MdiParent = InitialSelect
        Me.Hide()
        InitialSelect.Show()
        Order.Show()
    End Sub
    Private Sub Help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Help.Click
        MsgBox("Please see bartender for assistance or questions.", MsgBoxStyle.MsgBoxHelp, Title:="Help!")
    End Sub

    Private Sub FivePercent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FivePercent.Click
        TipLbl.Text = FormatCurrency(0.05 * Order.OrderTotal.ToString, 2)
        TotalLbl.Text = FormatCurrency((0.05 * Order.OrderTotal + Order.OrderTotal).ToString, 2)
    End Sub

    Private Sub TenPercent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TenPercent.Click
        TipLbl.Text = FormatCurrency(0.1 * Order.OrderTotal.ToString, 2)
        TotalLbl.Text = FormatCurrency((0.1 * Order.OrderTotal + Order.OrderTotal).ToString, 2)
    End Sub

    Private Sub FifteenPercent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FifteenPercent.Click
        TipLbl.Text = FormatCurrency(0.15 * Order.OrderTotal.ToString, 2)
        TotalLbl.Text = FormatCurrency((0.15 * Order.OrderTotal + Order.OrderTotal).ToString, 2)
    End Sub

    Private Sub TwentyPercent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TwentyPercent.Click
        TipLbl.Text = FormatCurrency(0.2 * Order.OrderTotal.ToString, 2)
        TotalLbl.Text = FormatCurrency((0.2 * Order.OrderTotal + Order.OrderTotal).ToString, 2)
    End Sub

    Private Sub CashButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CashButton.Click
        Cash.TipLbl.Text = Me.TipLbl.Text
        Cash.TotalLbl.Text = Me.TotalLbl.Text
        Cash.CheckoutList.Items.Clear()
        Cash.CheckoutList.Items.AddRange(Order.OrderList.Items)
        Cash.SubLbl.Text = Order.TotalLbl.Text
        Receipt.TipLbl.Text = Me.TipLbl.Text
        Receipt.TotalLbl.Text = Me.TotalLbl.Text
        Me.Hide()
        Cash.Show()
    End Sub

    Private Sub CreditDebitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreditDebitButton.Click
        CreditDebit.TipLbl.Text = Me.TipLbl.Text
        CreditDebit.TotalLbl.Text = Me.TotalLbl.Text
        CreditDebit.CheckoutList.Items.Clear()
        CreditDebit.CheckoutList.Items.AddRange(Order.OrderList.Items)
        CreditDebit.SubLbl.Text = Order.TotalLbl.Text
        Receipt.TipLbl.Text = Me.TipLbl.Text
        Receipt.TotalLbl.Text = Me.TotalLbl.Text
        Me.Hide()
        CreditDebit.Show()
    End Sub
End Class