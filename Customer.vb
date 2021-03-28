Public Class Customer
    Private Sub Save()
        App.Save("../../database/customers.txt", CustomerLV)
    End Sub

    Private Sub Load()
        Dim list = App.Load("../../database/customers.txt")
        CustomerLV.Items.Clear()
        For Each item In list
            CustomerLV.Items.Add(item)
        Next
    End Sub

    Public Sub Add(item As Array)
        App.AddToListView(0, item, CustomerLV)
        Save()
    End Sub

    Public Sub Edit(index As Integer, item As Array)
        CustomerLV.Items.RemoveAt(index)
        App.AddToListView(index, item, CustomerLV)
        Save()
    End Sub

    Public Sub Remove(index As Integer)
        CustomerLV.Items.RemoveAt(index)
        Save()
    End Sub

    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Owner.Enabled = False
        CustomerLV.View = View.Details
        Load()
    End Sub

    Private Sub Customer_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Owner.Enabled = True
    End Sub

    Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click
        Dim form As New CustomerForm
        form.Owner = Me
        form.CustomerLink = Me
        form.Show()
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If CustomerLV.SelectedItems.Count > 0 Then
            If App.Exist(CustomerLV.FocusedItem.SubItems(0).Text, "../../database/bills.txt", 1) = True Then '
                MsgBox("Khách hàng này không thể xóa!Liên kết với hóa hơn.")
            Else
                Remove(CustomerLV.FocusedItem.Index)
            End If
        Else
            MsgBox("Chưa chọn dữ liệu")
        End If
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        If CustomerLV.SelectedItems.Count > 0 Then
            Dim form As New CustomerForm
            form.Owner = Me
            form.CustomerLink = Me
            form.Mode = 1
            form.Show()
        Else
            MsgBox("Chưa chọn dữ liệu")
        End If
    End Sub
End Class