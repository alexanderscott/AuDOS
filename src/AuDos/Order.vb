Imports System.Collections
Imports System.Windows.Forms

Public Class Order

    Public OrderPrice As New ArrayList
    Public OrderName As New ArrayList
    Public OrderTotal As New Double

    Public Sub addOrder(ByVal dblPrice As Double, ByVal strName As String)

        DollarSign.Text = "$"
        Dim i As Integer
        i = OrderName.Count

        OrderPrice.Add(dblPrice)
        OrderName.Add(strName)

        OrderList.Items.Add("$" + OrderPrice.Item(i).ToString + " " + OrderName.Item(i))
        OrderTotal = OrderTotal + dblPrice
        TotalLbl.Text = OrderTotal.ToString
    End Sub

    Public Sub clearOrder()
        OrderPrice.Clear()
        OrderName.Clear()
        OrderTotal = 0
        TotalLbl.Text = OrderTotal.ToString
        OrderList.Items.Clear()
    End Sub

    Public Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton.Click
        Dim i As Integer
        i = OrderList.SelectedIndex

        OrderTotal = OrderTotal - OrderPrice.Item(i)
        OrderPrice.RemoveAt(i)
        OrderName.RemoveAt(i)
        OrderList.Items.RemoveAt(i)
        TotalLbl.Text = OrderTotal.ToString

    End Sub
End Class
