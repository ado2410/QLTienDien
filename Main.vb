Public Class Main
    Public Shared khachHang As ListView
    Private Sub CustomerButton_Click(sender As Object, e As EventArgs) Handles CustomerButton.Click
        Dim form As New Customer
        form.Owner = Me
        form.Show()
    End Sub

    Private Sub BillButton_Click(sender As Object, e As EventArgs) Handles BillButton.Click
        Dim form As New Bill
        form.Owner = Me
        form.Show()
    End Sub

    Private Sub About_Click(sender As Object, e As EventArgs) Handles About.Click
        Dim form As New About
        form.Owner = Me
        form.Show()
    End Sub
End Class
