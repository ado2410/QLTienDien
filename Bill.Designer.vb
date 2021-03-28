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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CreateButton = New System.Windows.Forms.Button()
        Me.CustomerLV = New System.Windows.Forms.ListView()
        Me.STT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MaKH = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NgayThu = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LoaiDien = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SoDien = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DonGia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Gia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LoadButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.TenKH = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DiaChi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CMND = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SDT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.ForeColor = System.Drawing.Color.Yellow
        Me.Button3.Location = New System.Drawing.Point(174, 53)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Xóa"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.ForeColor = System.Drawing.Color.Yellow
        Me.Button2.Location = New System.Drawing.Point(93, 53)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Sửa"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'CreateButton
        '
        Me.CreateButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CreateButton.ForeColor = System.Drawing.Color.Yellow
        Me.CreateButton.Location = New System.Drawing.Point(12, 53)
        Me.CreateButton.Name = "CreateButton"
        Me.CreateButton.Size = New System.Drawing.Size(75, 23)
        Me.CreateButton.TabIndex = 5
        Me.CreateButton.Text = "Tạo mới"
        Me.CreateButton.UseVisualStyleBackColor = False
        '
        'CustomerLV
        '
        Me.CustomerLV.BackColor = System.Drawing.Color.White
        Me.CustomerLV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.STT, Me.MaKH, Me.TenKH, Me.GT, Me.DiaChi, Me.CMND, Me.SDT})
        Me.CustomerLV.HideSelection = False
        Me.CustomerLV.Location = New System.Drawing.Point(12, 82)
        Me.CustomerLV.Name = "CustomerLV"
        Me.CustomerLV.Size = New System.Drawing.Size(1160, 448)
        Me.CustomerLV.TabIndex = 4
        Me.CustomerLV.UseCompatibleStateImageBehavior = False
        '
        'STT
        '
        Me.STT.Text = "STT"
        '
        'MaKH
        '
        Me.MaKH.Text = "Mã Khách Hàng"
        Me.MaKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MaKH.Width = 100
        '
        'TenKH
        '
        Me.TenKH.Text = "Tên Khách Hàng"
        Me.TenKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TenKH.Width = 200
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
        'LoadButton
        'GT
        '
        Me.GT.Text = "Giới tính"
        Me.GT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DiaChi
        '
        Me.DiaChi.Text = "Địa Chỉ"
        Me.DiaChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DiaChi.Width = 200
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(174, 53)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(75, 23)
        Me.PrintButton.TabIndex = 10
        Me.PrintButton.Text = "In"
        Me.PrintButton.UseVisualStyleBackColor = True
        'CMND
        '
        Me.CMND.Text = "CMND"
        Me.CMND.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CMND.Width = 150
        '
        'SDT
        '
        Me.SDT.Text = "SDT"
        Me.SDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SDT.Width = 100
        '
        'Bill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.LoadButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.ClientSize = New System.Drawing.Size(1184, 561)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CreateButton)
        Me.Controls.Add(Me.CustomerLV)
        Me.Name = "Bill"
        Me.Text = "Bill"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents CreateButton As Button
    Friend WithEvents CustomerLV As ListView
    Friend WithEvents STT As ColumnHeader
    Friend WithEvents MaKH As ColumnHeader
    Friend WithEvents NgayThu As ColumnHeader
    Friend WithEvents LoaiDien As ColumnHeader
    Friend WithEvents SoDien As ColumnHeader
    Friend WithEvents DonGia As ColumnHeader
    Friend WithEvents Gia As ColumnHeader
    Friend WithEvents PrintButton As Button
    Friend WithEvents TenKH As ColumnHeader
    Friend WithEvents GT As ColumnHeader
    Friend WithEvents DiaChi As ColumnHeader
    Friend WithEvents CMND As ColumnHeader
    Friend WithEvents SDT As ColumnHeader
End Class
