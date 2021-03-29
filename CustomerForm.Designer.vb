<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MaKH = New System.Windows.Forms.TextBox()
        Me.ConfirmedButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TenKH = New System.Windows.Forms.TextBox()
        Me.SDT = New System.Windows.Forms.TextBox()
        Me.DiaChi = New System.Windows.Forms.TextBox()
        Me.CMND = New System.Windows.Forms.TextBox()
        Me.Nam = New System.Windows.Forms.RadioButton()
        Me.Nu = New System.Windows.Forms.RadioButton()
        Me.TenKHError = New System.Windows.Forms.Label()
        Me.SDTError = New System.Windows.Forms.Label()
        Me.DiaChiError = New System.Windows.Forms.Label()
        Me.CMNDError = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(63, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã khách hàng"
        '
        'MaKH
        '
        Me.MaKH.Location = New System.Drawing.Point(180, 16)
        Me.MaKH.Margin = New System.Windows.Forms.Padding(4)
        Me.MaKH.MaxLength = 10
        Me.MaKH.Name = "MaKH"
        Me.MaKH.Size = New System.Drawing.Size(295, 23)
        Me.MaKH.TabIndex = 1
        '
        'ConfirmedButton
        '
        Me.ConfirmedButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ConfirmedButton.ForeColor = System.Drawing.Color.White
        Me.ConfirmedButton.Location = New System.Drawing.Point(205, 229)
        Me.ConfirmedButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ConfirmedButton.Name = "ConfirmedButton"
        Me.ConfirmedButton.Size = New System.Drawing.Size(204, 30)
        Me.ConfirmedButton.TabIndex = 2
        Me.ConfirmedButton.Text = "Xác "
        Me.ConfirmedButton.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(61, 54)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tên khách hàng"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(62, 84)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Giới tính"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(61, 112)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Số điện thoại"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(61, 146)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Địa chỉ"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(61, 180)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "CMND"
        '
        'TenKH
        '
        Me.TenKH.Location = New System.Drawing.Point(180, 50)
        Me.TenKH.Margin = New System.Windows.Forms.Padding(4)
        Me.TenKH.MaxLength = 100
        Me.TenKH.Name = "TenKH"
        Me.TenKH.Size = New System.Drawing.Size(295, 23)
        Me.TenKH.TabIndex = 1
        '
        'SDT
        '
        Me.SDT.Location = New System.Drawing.Point(180, 109)
        Me.SDT.Margin = New System.Windows.Forms.Padding(4)
        Me.SDT.MaxLength = 10
        Me.SDT.Name = "SDT"
        Me.SDT.Size = New System.Drawing.Size(295, 23)
        Me.SDT.TabIndex = 1
        '
        'DiaChi
        '
        Me.DiaChi.Location = New System.Drawing.Point(180, 146)
        Me.DiaChi.Margin = New System.Windows.Forms.Padding(4)
        Me.DiaChi.MaxLength = 200
        Me.DiaChi.Name = "DiaChi"
        Me.DiaChi.Size = New System.Drawing.Size(295, 23)
        Me.DiaChi.TabIndex = 1
        '
        'CMND
        '
        Me.CMND.Location = New System.Drawing.Point(180, 180)
        Me.CMND.Margin = New System.Windows.Forms.Padding(4)
        Me.CMND.MaxLength = 12
        Me.CMND.Name = "CMND"
        Me.CMND.Size = New System.Drawing.Size(295, 23)
        Me.CMND.TabIndex = 1
        '
        'Nam
        '
        Me.Nam.AutoSize = True
        Me.Nam.Checked = True
        Me.Nam.Location = New System.Drawing.Point(180, 78)
        Me.Nam.Margin = New System.Windows.Forms.Padding(4)
        Me.Nam.Name = "Nam"
        Me.Nam.Size = New System.Drawing.Size(58, 21)
        Me.Nam.TabIndex = 3
        Me.Nam.TabStop = True
        Me.Nam.Text = "Nam"
        Me.Nam.UseVisualStyleBackColor = True
        '
        'Nu
        '
        Me.Nu.AutoSize = True
        Me.Nu.Location = New System.Drawing.Point(251, 78)
        Me.Nu.Margin = New System.Windows.Forms.Padding(4)
        Me.Nu.Name = "Nu"
        Me.Nu.Size = New System.Drawing.Size(43, 21)
        Me.Nu.TabIndex = 3
        Me.Nu.Text = "Nữ"
        Me.Nu.UseVisualStyleBackColor = True
        '
        'TenKHError
        '
        Me.TenKHError.AutoSize = True
        Me.TenKHError.ForeColor = System.Drawing.Color.Red
        Me.TenKHError.Location = New System.Drawing.Point(484, 59)
        Me.TenKHError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TenKHError.Name = "TenKHError"
        Me.TenKHError.Size = New System.Drawing.Size(64, 17)
        Me.TenKHError.TabIndex = 5
        Me.TenKHError.Text = "Nhập sai"
        Me.TenKHError.Visible = False
        '
        'SDTError
        '
        Me.SDTError.AutoSize = True
        Me.SDTError.ForeColor = System.Drawing.Color.Red
        Me.SDTError.Location = New System.Drawing.Point(484, 112)
        Me.SDTError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SDTError.Name = "SDTError"
        Me.SDTError.Size = New System.Drawing.Size(103, 17)
        Me.SDTError.TabIndex = 6
        Me.SDTError.Text = "Nhập sai, 10 số"
        Me.SDTError.Visible = False
        '
        'DiaChiError
        '
        Me.DiaChiError.AutoSize = True
        Me.DiaChiError.ForeColor = System.Drawing.Color.Red
        Me.DiaChiError.Location = New System.Drawing.Point(484, 150)
        Me.DiaChiError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DiaChiError.Name = "DiaChiError"
        Me.DiaChiError.Size = New System.Drawing.Size(64, 17)
        Me.DiaChiError.TabIndex = 7
        Me.DiaChiError.Text = "Nhập sai"
        Me.DiaChiError.Visible = False
        '
        'CMNDError
        '
        Me.CMNDError.AutoSize = True
        Me.CMNDError.ForeColor = System.Drawing.Color.Red
        Me.CMNDError.Location = New System.Drawing.Point(484, 184)
        Me.CMNDError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CMNDError.Name = "CMNDError"
        Me.CMNDError.Size = New System.Drawing.Size(168, 17)
        Me.CMNDError.TabIndex = 8
        Me.CMNDError.Text = "Nhập sai, 9 số hoặc 12 số"
        Me.CMNDError.Visible = False
        '
        'CustomerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 310)
        Me.Controls.Add(Me.CMNDError)
        Me.Controls.Add(Me.DiaChiError)
        Me.Controls.Add(Me.SDTError)
        Me.Controls.Add(Me.TenKHError)
        Me.Controls.Add(Me.Nu)
        Me.Controls.Add(Me.Nam)
        Me.Controls.Add(Me.ConfirmedButton)
        Me.Controls.Add(Me.CMND)
        Me.Controls.Add(Me.DiaChi)
        Me.Controls.Add(Me.SDT)
        Me.Controls.Add(Me.TenKH)
        Me.Controls.Add(Me.MaKH)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CustomerForm"
        Me.Text = "CustomerForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MaKH As TextBox
    Friend WithEvents ConfirmedButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TenKH As TextBox
    Friend WithEvents SDT As TextBox
    Friend WithEvents DiaChi As TextBox
    Friend WithEvents CMND As TextBox
    Friend WithEvents Nam As RadioButton
    Friend WithEvents Nu As RadioButton
    Friend WithEvents TenKHError As Label
    Friend WithEvents SDTError As Label
    Friend WithEvents DiaChiError As Label
    Friend WithEvents CMNDError As Label
End Class
