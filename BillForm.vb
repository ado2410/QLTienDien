Public Class BillForm
    Public BillLink As Bill
    Public CustomerLVLink As ListView
    Public Mode As Integer = 0

    Private Sub ConfirmedButton_Click(sender As Object, e As EventArgs) Handles ConfirmedButton.Click
        Dim isValid = True

        If MaKH.Text = "" Then
            isValid = False
            MaKHError.Visible = True
        Else
            MaKHError.Visible = False
        End If

        If Not IsNumeric(SoDien.Text) Then
            isValid = False
            SoDienError.Visible = True
        Else
            SoDienError.Visible = False
        End If

        If isValid = True Then
            Dim donGia As Double = App.GetPrice(LoaiDien.SelectedIndex)

            Dim input As String() = {MaHD.Text, MaKH.Text.Split("-")(0), NgayThu.Value.ToString, LoaiDien.Text, SoDien.Text, donGia, donGia * SoDien.Text}
            If Mode = 0 Then
                BillLink.Add(input)
            Else
                BillLink.Edit(BillLink.BillLV.FocusedItem.Index, input)
            End If

            Close()
            End If
    End Sub

    Private Sub BillForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Owner.Enabled = False
        MaHD.Enabled = False
        Dim number As Integer
        Do
            number = Fix(999999999 * Rnd())
        Loop While App.Exist(number, "../../database/bills.txt", 0)
        MaHD.Text = number

        Dim list = App.Load("../../database/customers.txt")
        For Each item In list
            MaKH.Items.Add(item.SubItems(0).Text + "-" + item.SubItems(1).Text)
        Next

        LoaiDien.Items.Add("Thông thường")
        LoaiDien.Items.Add("Cường độ mạnh")
        LoaiDien.Items.Add("Siêu cường độ")
        LoaiDien.SelectedItem = "Thông thường"

    End Sub

    Private Sub BillForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Owner.Enabled = True
    End Sub
End Class