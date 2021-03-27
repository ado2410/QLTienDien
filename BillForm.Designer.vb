<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BillForm
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MaHD = New System.Windows.Forms.TextBox()
        Me.NgayThuLabel = New System.Windows.Forms.Label()
        Me.MaKHLabel = New System.Windows.Forms.Label()
        Me.MaHDLabel = New System.Windows.Forms.Label()
        Me.SoDienLable = New System.Windows.Forms.Label()
        Me.SoDien = New System.Windows.Forms.TextBox()
        Me.NgayThu = New System.Windows.Forms.DateTimePicker()
        Me.LoaiDienLabel = New System.Windows.Forms.Label()
        Me.MaKH = New System.Windows.Forms.ComboBox()
        Me.LoaiDien = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(188, 189)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 38)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Thêm"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MaHD
        '
        Me.MaHD.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaHD.Location = New System.Drawing.Point(146, 12)
        Me.MaHD.Name = "MaHD"
        Me.MaHD.Size = New System.Drawing.Size(234, 23)
        Me.MaHD.TabIndex = 14
        '
        'NgayThuLabel
        '
        Me.NgayThuLabel.AutoSize = True
        Me.NgayThuLabel.BackColor = System.Drawing.Color.Green
        Me.NgayThuLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NgayThuLabel.ForeColor = System.Drawing.Color.Yellow
        Me.NgayThuLabel.Location = New System.Drawing.Point(31, 88)
        Me.NgayThuLabel.Name = "NgayThuLabel"
        Me.NgayThuLabel.Size = New System.Drawing.Size(67, 17)
        Me.NgayThuLabel.TabIndex = 4
        Me.NgayThuLabel.Text = "Ngày thu"
        '
        'MaKHLabel
        '
        Me.MaKHLabel.AutoSize = True
        Me.MaKHLabel.BackColor = System.Drawing.Color.Green
        Me.MaKHLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaKHLabel.ForeColor = System.Drawing.Color.Yellow
        Me.MaKHLabel.Location = New System.Drawing.Point(30, 51)
        Me.MaKHLabel.Name = "MaKHLabel"
        Me.MaKHLabel.Size = New System.Drawing.Size(110, 17)
        Me.MaKHLabel.TabIndex = 8
        Me.MaKHLabel.Text = "Mã khách hàng"
        '
        'MaHDLabel
        '
        Me.MaHDLabel.AutoSize = True
        Me.MaHDLabel.BackColor = System.Drawing.Color.Green
        Me.MaHDLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaHDLabel.ForeColor = System.Drawing.Color.Yellow
        Me.MaHDLabel.Location = New System.Drawing.Point(31, 15)
        Me.MaHDLabel.Name = "MaHDLabel"
        Me.MaHDLabel.Size = New System.Drawing.Size(87, 17)
        Me.MaHDLabel.TabIndex = 9
        Me.MaHDLabel.Text = "Mã hóa đơn"
        '
        'SoDienLable
        '
        Me.SoDienLable.AutoSize = True
        Me.SoDienLable.BackColor = System.Drawing.Color.Green
        Me.SoDienLable.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SoDienLable.ForeColor = System.Drawing.Color.Yellow
        Me.SoDienLable.Location = New System.Drawing.Point(30, 156)
        Me.SoDienLable.Name = "SoDienLable"
        Me.SoDienLable.Size = New System.Drawing.Size(54, 17)
        Me.SoDienLable.TabIndex = 4
        Me.SoDienLable.Text = "Số điện"
        '
        'SoDien
        '
        Me.SoDien.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SoDien.Location = New System.Drawing.Point(146, 147)
        Me.SoDien.Name = "SoDien"
        Me.SoDien.Size = New System.Drawing.Size(234, 23)
        Me.SoDien.TabIndex = 10
        '
        'NgayThu
        '
        Me.NgayThu.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NgayThu.Location = New System.Drawing.Point(146, 87)
        Me.NgayThu.Name = "NgayThu"
        Me.NgayThu.Size = New System.Drawing.Size(234, 23)
        Me.NgayThu.TabIndex = 16
        '
        'LoaiDienLabel
        '
        Me.LoaiDienLabel.AutoSize = True
        Me.LoaiDienLabel.BackColor = System.Drawing.Color.Green
        Me.LoaiDienLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoaiDienLabel.ForeColor = System.Drawing.Color.Yellow
        Me.LoaiDienLabel.Location = New System.Drawing.Point(30, 122)
        Me.LoaiDienLabel.Name = "LoaiDienLabel"
        Me.LoaiDienLabel.Size = New System.Drawing.Size(66, 17)
        Me.LoaiDienLabel.TabIndex = 4
        Me.LoaiDienLabel.Text = "Loại điện"
        '
        'MaKH
        '
        Me.MaKH.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaKH.FormattingEnabled = True
        Me.MaKH.Location = New System.Drawing.Point(146, 48)
        Me.MaKH.Name = "MaKH"
        Me.MaKH.Size = New System.Drawing.Size(234, 25)
        Me.MaKH.TabIndex = 17
        '
        'LoaiDien
        '
        Me.LoaiDien.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoaiDien.FormattingEnabled = True
        Me.LoaiDien.Location = New System.Drawing.Point(146, 116)
        Me.LoaiDien.Name = "LoaiDien"
        Me.LoaiDien.Size = New System.Drawing.Size(122, 25)
        Me.LoaiDien.TabIndex = 18
        '
        'BillForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(451, 239)
        Me.Controls.Add(Me.LoaiDien)
        Me.Controls.Add(Me.MaKH)
        Me.Controls.Add(Me.NgayThu)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SoDien)
        Me.Controls.Add(Me.MaHD)
        Me.Controls.Add(Me.LoaiDienLabel)
        Me.Controls.Add(Me.SoDienLable)
        Me.Controls.Add(Me.NgayThuLabel)
        Me.Controls.Add(Me.MaKHLabel)
        Me.Controls.Add(Me.MaHDLabel)
        Me.Name = "BillForm"
        Me.Text = "BillForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents MaHD As TextBox
    Friend WithEvents NgayThuLabel As Label
    Friend WithEvents MaKHLabel As Label
    Friend WithEvents MaHDLabel As Label
    Friend WithEvents SoDienLable As Label
    Friend WithEvents SoDien As TextBox
    Friend WithEvents NgayThu As DateTimePicker
    Friend WithEvents LoaiDienLabel As Label
    Friend WithEvents MaKH As ComboBox
    Friend WithEvents LoaiDien As ComboBox
End Class
