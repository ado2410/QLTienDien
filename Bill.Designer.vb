<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bill
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.CreateButton = New System.Windows.Forms.Button()
        Me.BillLV = New System.Windows.Forms.ListView()
        Me.MaHD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MaKH = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NgayTao = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LoaiDiens = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SoDiens = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DonGias = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ThanhTien = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NgayThu = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LoaiDien = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SoDien = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DonGia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Gia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DeleteButton.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.ForeColor = System.Drawing.Color.Yellow
        Me.DeleteButton.Location = New System.Drawing.Point(93, 2)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(75, 35)
        Me.DeleteButton.TabIndex = 7
        Me.DeleteButton.Text = "Xóa"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'CreateButton
        '
        Me.CreateButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CreateButton.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateButton.ForeColor = System.Drawing.Color.Yellow
        Me.CreateButton.Location = New System.Drawing.Point(12, 2)
        Me.CreateButton.Name = "CreateButton"
        Me.CreateButton.Size = New System.Drawing.Size(75, 35)
        Me.CreateButton.TabIndex = 5
        Me.CreateButton.Text = "Tạo mới"
        Me.CreateButton.UseVisualStyleBackColor = False
        '
        'BillLV
        '
        Me.BillLV.BackColor = System.Drawing.Color.Gainsboro
        Me.BillLV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.MaHD, Me.MaKH, Me.NgayTao, Me.LoaiDiens, Me.SoDiens, Me.DonGias, Me.ThanhTien})
        Me.BillLV.FullRowSelect = True
        Me.BillLV.HideSelection = False
        Me.BillLV.Location = New System.Drawing.Point(12, 43)
        Me.BillLV.Name = "BillLV"
        Me.BillLV.Size = New System.Drawing.Size(902, 448)
        Me.BillLV.TabIndex = 4
        Me.BillLV.UseCompatibleStateImageBehavior = False
        '
        'MaHD
        '
        Me.MaHD.Text = "Mã Hóa Đơn"
        Me.MaHD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MaHD.Width = 100
        '
        'MaKH
        '
        Me.MaKH.Text = "Mã Khách Hàng"
        Me.MaKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MaKH.Width = 150
        '
        'NgayTao
        '
        Me.NgayTao.Text = "Ngày tạo"
        Me.NgayTao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NgayTao.Width = 150
        '
        'LoaiDiens
        '
        Me.LoaiDiens.Text = "Loại điện"
        Me.LoaiDiens.Width = 120
        '
        'SoDiens
        '
        Me.SoDiens.Text = "Số điện sử dụng"
        Me.SoDiens.Width = 100
        '
        'DonGias
        '
        Me.DonGias.Text = "Đơn giá"
        Me.DonGias.Width = 100
        '
        'ThanhTien
        '
        Me.ThanhTien.Text = "Thành tiền"
        Me.ThanhTien.Width = 100
        '
        'DonGia
        '
        Me.DonGia.Text = "Đơn Giá"
        Me.DonGia.Width = 100
        '
        'Gia
        '
        Me.Gia.Text = "Giá"
        Me.Gia.Width = 100
        '
        'PrintButton
        '
        Me.PrintButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PrintButton.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintButton.ForeColor = System.Drawing.Color.Yellow
        Me.PrintButton.Location = New System.Drawing.Point(174, 2)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(75, 35)
        Me.PrintButton.TabIndex = 10
        Me.PrintButton.Text = "In"
        Me.PrintButton.UseVisualStyleBackColor = False
        '
        'Bill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 512)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.CreateButton)
        Me.Controls.Add(Me.BillLV)
        Me.Name = "Bill"
        Me.Text = "Bill"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DeleteButton As Button
    Friend WithEvents CreateButton As Button
    Friend WithEvents BillLV As ListView
    Friend WithEvents MaHD As ColumnHeader
    Friend WithEvents NgayThu As ColumnHeader
    Friend WithEvents LoaiDien As ColumnHeader
    Friend WithEvents SoDien As ColumnHeader
    Friend WithEvents DonGia As ColumnHeader
    Friend WithEvents Gia As ColumnHeader
    Friend WithEvents PrintButton As Button
    Friend WithEvents MaKH As ColumnHeader
    Friend WithEvents NgayTao As ColumnHeader
    Friend WithEvents LoaiDiens As ColumnHeader
    Friend WithEvents SoDiens As ColumnHeader
    Friend WithEvents DonGias As ColumnHeader
    Friend WithEvents ThanhTien As ColumnHeader
End Class
