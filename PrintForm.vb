Public Class PrintForm
    Public BillId As String
    Private Sub PrintForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Owner.Enabled = False

        Dim customerData = Main.Load("../../database/customers.txt")
        Dim billData = Main.Load("../../database/bills.txt")

        Dim bill As New ListViewItem

        Dim customer As New ListViewItem

        For Each i As ListViewItem In billData
            If BillId = i.SubItems(0).Text Then
                bill = i
                Exit For
            End If
        Next

        For Each i As ListViewItem In customerData
            If bill.SubItems(1).Text = i.SubItems(0).Text Then
                customer = i
                Exit For
            End If
        Next

        MaKH.Text = customer.SubItems(0).Text
        TenKH.Text = customer.SubItems(1).Text
        DiaChi.Text = customer.SubItems(5).Text
        SDT.Text = customer.SubItems(4).Text
        LoaiDien.Text = bill.SubItems(3).Text
        DonGia.Text = "Chưa xong"
        ThanhTien.Text = "Chưa xong"
    End Sub

    Private Sub PrintForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Owner.Enabled = True
    End Sub
End Class