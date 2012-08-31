Public Class CreditDebit

    Dim asterisk As Integer = 0

    Private Sub CreditDebit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub DebitBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DebitBtn.Click
        SwipeLbl.Text = "Please swipe debit card..."
        DebitSwipe.Enabled() = True
    End Sub

    Private Sub CreditBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreditBtn.Click
        SwipeLbl.Text = "Please swipe credit card..."
        CreditSwipe.Enabled() = True
    End Sub

    Private Sub CreditSwipe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreditSwipe.Click
        SwipeLbl.Text = "Please select Credit or Debit..."
        Button1.Enabled() = False
        Button2.Enabled() = False
        Button3.Enabled() = False
        Button4.Enabled() = False
        Button5.Enabled() = False
        Button6.Enabled() = False
        Button7.Enabled() = False
        Button8.Enabled() = False
        Button9.Enabled() = False
        Button10.Enabled() = False
        Button11.Enabled() = False
        ClearBtn.Enabled() = False
        CreditSwipe.Enabled() = False
        DebitSwipe.Enabled() = False
        Order.clearOrder()
        Me.Hide()
        Finalfrm.Show()
        Receipt.Show()
    End Sub

    Private Sub DebitSwipe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DebitSwipe.Click
        SwipeLbl.Text = "Authorizing..."
        MsgDelay()
        SwipeLbl.Text = "Please enter PIN and press OK..."
        Button1.Enabled() = True
        Button2.Enabled() = True
        Button3.Enabled() = True
        Button4.Enabled() = True
        Button5.Enabled() = True
        Button6.Enabled() = True
        Button7.Enabled() = True
        Button8.Enabled() = True
        Button9.Enabled() = True
        Button10.Enabled() = True
        Button11.Enabled() = True
        ClearBtn.Enabled() = True


    End Sub

    Private Sub BackButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackButton.Click
        Me.Hide()
        Checkout.Show()
    End Sub

    Private Sub QuitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitButton.Click
        Me.Hide()
        Order.clearOrder()
        Start.Show()
    End Sub

    Private Sub MsgDelay()
        For iCount = 1 To 1000
        Next iCount
    End Sub

    Private Sub PIN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button10.Click
        asterisk = asterisk + 1
        If asterisk = 1 Then
            SwipeLbl.Text = "*"
        End If
        If asterisk = 2 Then
            SwipeLbl.Text = "**"
        End If
        If asterisk = 3 Then
            SwipeLbl.Text = "***"
        End If
        If asterisk = 4 Then
            SwipeLbl.Text = "****"
        End If
        If asterisk > 4 Then
            SwipeLbl.Text = "Please try PIN again..."
            asterisk = 0
        End If

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        If asterisk = 4 Then
            Order.clearOrder()
            SwipeLbl.Text = "Please select Credit or Debit..."
            Button1.Enabled() = False
            Button2.Enabled() = False
            Button3.Enabled() = False
            Button4.Enabled() = False
            Button5.Enabled() = False
            Button6.Enabled() = False
            Button7.Enabled() = False
            Button8.Enabled() = False
            Button9.Enabled() = False
            Button10.Enabled() = False
            Button11.Enabled() = False
            ClearBtn.Enabled() = False
            CreditSwipe.Enabled() = False
            DebitSwipe.Enabled() = False
            Me.Hide()
            Finalfrm.Show()
            Receipt.Show()
        End If
        If asterisk < 4 Then
            SwipeLbl.Text = "Please try PIN again..."
            asterisk = 0
        End If

    End Sub

    Private Sub Help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Help.Click
        MsgBox("Please see bartender for assistance or questions.", MsgBoxStyle.MsgBoxHelp, Title:="Help!")
    End Sub

    Private Sub ClearBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearBtn.Click
        If asterisk = 0 Then
            SwipeLbl.Text = "Please try PIN again..."
        End If
        If asterisk = 1 Then
            SwipeLbl.Text = "Please enter PIN and press OK..."
            asterisk = 0
        End If
        If asterisk = 2 Then
            SwipeLbl.Text = "*"
            asterisk = 1
        End If
        If asterisk = 3 Then
            SwipeLbl.Text = "**"
            asterisk = 2
        End If
        If asterisk = 4 Then
            SwipeLbl.Text = "***"
            asterisk = 3
        End If
    End Sub
End Class