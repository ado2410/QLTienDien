Public Class Customer
    Private Sub Save()
        Main.Save("../../database/customers.txt", CustomerLV)

    End Sub

    Private Sub Load()
        Dim list = Main.Load("../../database/customers.txt")
        CustomerLV.Items.Clear()
        For Each item In list
            CustomerLV.Items.Add(item)
        Next
    End Sub

    Private Sub AddToCustomerLV(item As Array)
        Main.AddToListView(item, CustomerLV)
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
        form.CustomerLVLink = CustomerLV
        form.Show()
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
            Dim form As New CustomerForm
            form.Owner = Me
            form.CustomerLVLink = CustomerLV
            form.Mode = 1
            form.Show()
        End If
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Save()
    End Sub

    Private Sub LoadButton_Click(sender As Object, e As EventArgs) Handles LoadButton.Click
        Load()
    End Sub
End Class