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
        TipDollar.Hide()
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
        MsgBox("A member of the bar staff will see you shortly.", MsgBoxStyle.MsgBoxHelp, Title:="Help!")
    End Sub

    Private Sub FivePercent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FivePercent.Click
        TipLbl.Text = 0.05 * Order.OrderTotal.ToString
        TotalLbl.Text = (0.05 * Order.OrderTotal + Order.OrderTotal).ToString
        TipDollar.Show()
    End Sub

    Private Sub TenPercent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TenPercent.Click
        TipLbl.Text = 0.1 * Order.OrderTotal.ToString
        TotalLbl.Text = (0.1 * Order.OrderTotal + Order.OrderTotal).ToString
        TipDollar.Show()
    End Sub

    Private Sub FifteenPercent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FifteenPercent.Click
        TipLbl.Text = 0.15 * Order.OrderTotal.ToString
        TotalLbl.Text = (0.15 * Order.OrderTotal + Order.OrderTotal).ToString
        TipDollar.Show()
    End Sub

    Private Sub TwentyPercent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TwentyPercent.Click
        TipLbl.Text = 0.2 * Order.OrderTotal.ToString
        TotalLbl.Text = (0.2 * Order.OrderTotal + Order.OrderTotal).ToString
        TipDollar.Show()
    End Sub
End Class