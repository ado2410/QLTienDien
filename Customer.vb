Public Class Customer
    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomerLV.View = View.Details
    End Sub

    Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click
        Dim CustomerFormShow As New CustomerForm
        CustomerFormShow.CustomerLVLink = CustomerLV
        CustomerFormShow.Show()
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        'Lấy vị trí con trỏ trong CustomerListView
        If CustomerLV.FocusedItem.Index <> -1 Then
            Dim i As Integer = CustomerLV.FocusedItem.Index
            CustomerLV.Items.RemoveAt(i)
        End If
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        If CustomerLV.FocusedItem IsNot Nothing Then
            Dim CustomerFormShow As New CustomerForm
            CustomerFormShow.CustomerLVLink = CustomerLV
            CustomerFormShow.Mode = 1
            CustomerFormShow.Show()
        End If
    End Sub
End Class