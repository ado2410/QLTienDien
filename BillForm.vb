Public Class BillForm
    Public BillLVLink As ListView
    Public CustomerLVLink As ListView
    Public Mode As Integer = 0
    Private Sub AddToListView(item As Array)
        Main.AddToListView(item, BillLVLink)
    End Sub

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
            Dim donGia As Double
            If LoaiDien.Text = "Thông thường" Then
                donGia = 1200
            ElseIf LoaiDien.Text = "Cường độ mạnh" Then
                donGia = 1500
            ElseIf LoaiDien.Text = "Siêu cường độ" Then
                donGia = 2000
            End If

            AddToListView({MaHD.Text, MaKH.Text.Split("-")(0), NgayThu.Value.ToString, LoaiDien.Text, SoDien.Text, donGia, donGia * SoDien.Text})
            Close()
            End If
    End Sub

    Private Sub CustomerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Owner.Enabled = False
        Dim list = Main.Load("../../database/customers.txt")
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