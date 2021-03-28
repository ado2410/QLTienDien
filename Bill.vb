Public Class Bill
    Private Sub Save()
        App.Save("../../database/bills.txt", BillLV)
    End Sub

    Private Sub Load()
        Dim list = App.Load("../../database/bills.txt")
        BillLV.Items.Clear()
        For Each item In list
            BillLV.Items.Add(item)
        Next
    End Sub

    Public Sub Add(item As Array)
        App.AddToListView(0, item, BillLV)
        Save()
    End Sub

    Public Sub Edit(index As Integer, item As Array)
        BillLV.Items.RemoveAt(index)
        App.AddToListView(index, item, BillLV)
        Save()
    End Sub

    Public Sub Remove(index As Integer)
        BillLV.Items.RemoveAt(index)
        Save()
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If BillLV.SelectedItems.Count > 0 Then
            Remove(BillLV.FocusedItem.Index)
        Else
            MsgBox("Chưa chọn dữ liệu")
        End If
    End Sub

    Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click
        Dim form As New BillForm
        form.Owner = Me
        form.BillLink = Me
        form.Show()
    End Sub

    Private Sub Bill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Owner.Enabled = False
        BillLV.View = View.Details
        Load()
    End Sub

    Private Sub Bill_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Owner.Enabled = True
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        If BillLV.SelectedItems.Count > 0 Then
            Dim form As New PrintForm
            form.Owner = Me
            form.BillId = BillLV.SelectedItems(0).Text
            form.Show()
        Else
            MsgBox("Chưa chọn dữ liệu")
        End If
    End Sub
End Class