Public Class Bill
    Private Sub Save()
        Main.Save("../../database/bills.txt", BillLV)

    End Sub

    Private Sub Load()
        Dim list = Main.Load("../../database/bills.txt")
        BillLV.Items.Clear()
        For Each item In list
            BillLV.Items.Add(item)
        Next
    End Sub
    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If BillLV.FocusedItem.Index <> -1 Then
            Dim i As Integer = BillLV.FocusedItem.Index
            BillLV.Items.RemoveAt(i)
        End If
    End Sub

    Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click
        Dim form As New BillForm
        form.Owner = Me
        form.BillLVLink = BillLV
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

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Save()
    End Sub

    Private Sub LoadButton_Click(sender As Object, e As EventArgs) Handles LoadButton.Click
        Load()
    End Sub
End Class