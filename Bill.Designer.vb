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
        Me.NgayThu = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LoaiDien = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SoDien = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LoadButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.DonGia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Gia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(93, 53)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(75, 23)
        Me.DeleteButton.TabIndex = 7
        Me.DeleteButton.Text = "Xóa"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'CreateButton
        '
        Me.CreateButton.Location = New System.Drawing.Point(12, 53)
        Me.CreateButton.Name = "CreateButton"
        Me.CreateButton.Size = New System.Drawing.Size(75, 23)
        Me.CreateButton.TabIndex = 5
        Me.CreateButton.Text = "Tạo mới"
        Me.CreateButton.UseVisualStyleBackColor = True
        '
        'BillLV
        '
        Me.BillLV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.MaHD, Me.MaKH, Me.NgayThu, Me.LoaiDien, Me.SoDien, Me.DonGia, Me.Gia})
        Me.BillLV.FullRowSelect = True
        Me.BillLV.HideSelection = False
        Me.BillLV.Location = New System.Drawing.Point(12, 82)
        Me.BillLV.Name = "BillLV"
        Me.BillLV.Size = New System.Drawing.Size(862, 448)
        Me.BillLV.TabIndex = 4
        Me.BillLV.UseCompatibleStateImageBehavior = False
        '
        'MaHD
        '
        Me.MaHD.Text = "Mã hóa Đơn"
        Me.MaHD.Width = 100
        '
        'MaKH
        '
        Me.MaKH.Text = "Mã Khách Hàng"
        Me.MaKH.Width = 100
        '
        'NgayThu
        '
        Me.NgayThu.Text = "Ngày thu"
        Me.NgayThu.Width = 150
        '
        'LoaiDien
        '
        Me.LoaiDien.Text = "Loại Điện"
        Me.LoaiDien.Width = 150
        '
        'SoDien
        '
        Me.SoDien.Text = "Số Điện"
        Me.SoDien.Width = 100
        '
        'LoadButton
        '
        Me.LoadButton.Location = New System.Drawing.Point(93, 12)
        Me.LoadButton.Name = "LoadButton"
        Me.LoadButton.Size = New System.Drawing.Size(75, 23)
        Me.LoadButton.TabIndex = 9
        Me.LoadButton.Text = "Tải lại"
        Me.LoadButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(12, 12)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 8
        Me.SaveButton.Text = "Lưu"
        Me.SaveButton.UseVisualStyleBackColor = True
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
        'Bill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.LoadButton)
        Me.Controls.Add(Me.SaveButton)
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
    Friend WithEvents LoadButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents MaHD As ColumnHeader
    Friend WithEvents MaKH As ColumnHeader
    Friend WithEvents NgayThu As ColumnHeader
    Friend WithEvents LoaiDien As ColumnHeader
    Friend WithEvents SoDien As ColumnHeader
    Friend WithEvents DonGia As ColumnHeader
    Friend WithEvents Gia As ColumnHeader
End Class
