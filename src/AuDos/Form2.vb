Public Class Form2
    Private Sub Form2_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        MyBase.Dispose()
    End Sub

    Private Sub Form2_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Start.Close()
    End Sub

    Private Sub backBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backBtn.Click
        Me.Hide()
        Start.Show()
    End Sub

    Private Sub bwBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bwBtn.Click
        Me.Hide()
        Form3.Show()
    End Sub
    Private Sub mdBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mdBtn.Click
        Me.Hide()
        Form4.Show()
    End Sub
    Private Sub chkOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOut.Click
        Me.Hide()
        Form5.Show()

    End Sub
End Class