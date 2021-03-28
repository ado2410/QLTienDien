Public Class CustomerForm
    Public CustomerLink As Customer
    Public Mode As Integer = 0

    Private Sub ConfirmedButton_Click(sender As Object, e As EventArgs) Handles ConfirmedButton.Click
        Dim isValid = True
        'Kiem tra SDT nhap vao co phai la so khong
        If Not IsNumeric(SDT.Text) Or SDT.Text.Length < 10 Then
            SDTError.Visible = True
            isValid = False
        Else
            SDTError.Visible = False
        End If

        'Kiem tra CMND nhap vao co dung khong
        If Not IsNumeric(CMND.Text) Or CMND.Text.Length < 9 Or (CMND.Text.Length < 12 And CMND.Text.Length > 9) Then
            CMNDError.Visible = True
            isValid = False
        Else
            CMNDError.Visible = False
        End If

        If isValid = True Then
            Dim gender As String
            If Nam.Checked Then
                gender = "Nam"
            Else
                gender = "Nữ"
            End If

            If Mode = 0 Then
                CustomerLink.Add({MaKH.Text, TenKH.Text, gender, DiaChi.Text, CMND.Text, SDT.Text})
            Else
                CustomerLink.Edit(CustomerLink.CustomerLV.FocusedItem.Index, {MaKH.Text, TenKH.Text, gender, DiaChi.Text, CMND.Text, SDT.Text})
            End If
            Close()
        End If
    End Sub

    Private Sub CustomerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Owner.Enabled = False
        MaKH.Enabled = False
        If Mode = 0 Then
            Dim number As Integer
            Do
                number = Fix(999999999 * Rnd())
            Loop While App.Exist(number, "../../database/customers.txt", 0)
            MaKH.Text = number
        ElseIf Mode = 1 Then
            For Each i As ListViewItem In CustomerLink.CustomerLV.SelectedItems
                MaKH.Text = i.SubItems(0).Text
                TenKH.Text = i.SubItems(1).Text
                If i.SubItems(2).Text = "Nam" Then
                    Nam.Checked = True
                    Nu.Checked = False
                Else
                    Nam.Checked = False
                    Nu.Checked = True
                End If
                DiaChi.Text = i.SubItems(3).Text
                CMND.Text = i.SubItems(4).Text
                SDT.Text = i.SubItems(5).Text
            Next
        End If
    End Sub

    Private Sub Customer_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Owner.Enabled = True
    End Sub
End Class