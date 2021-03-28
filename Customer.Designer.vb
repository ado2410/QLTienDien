<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Customer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.CustomerLV = New System.Windows.Forms.ListView()
        Me.MaKH = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TenKH = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DiaChi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CMND = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SDT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CreateButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.LoadButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CustomerLV
        '
        Me.CustomerLV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.MaKH, Me.TenKH, Me.GT, Me.DiaChi, Me.CMND, Me.SDT})
        Me.CustomerLV.FullRowSelect = True
        Me.CustomerLV.HideSelection = False
        Me.CustomerLV.Location = New System.Drawing.Point(12, 112)
        Me.CustomerLV.Name = "CustomerLV"
        Me.CustomerLV.Size = New System.Drawing.Size(860, 437)
        Me.CustomerLV.TabIndex = 0
        Me.CustomerLV.UseCompatibleStateImageBehavior = False
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
        'CreateButton
        '
        Me.CreateButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CreateButton.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateButton.ForeColor = System.Drawing.Color.Yellow
        Me.CreateButton.Location = New System.Drawing.Point(12, 60)
        Me.CreateButton.Name = "CreateButton"
        Me.CreateButton.Size = New System.Drawing.Size(75, 35)
        Me.CreateButton.TabIndex = 1
        Me.CreateButton.Text = "Tạo mới"
        Me.CreateButton.UseVisualStyleBackColor = False
        '
        'EditButton
        '
        Me.EditButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.EditButton.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditButton.ForeColor = System.Drawing.Color.Yellow
        Me.EditButton.Location = New System.Drawing.Point(110, 60)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(87, 35)
        Me.EditButton.TabIndex = 2
        Me.EditButton.Text = "Sửa"
        Me.EditButton.UseVisualStyleBackColor = False
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DeleteButton.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.ForeColor = System.Drawing.Color.Yellow
        Me.DeleteButton.Location = New System.Drawing.Point(216, 60)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(94, 35)
        Me.DeleteButton.TabIndex = 3
        Me.DeleteButton.Text = "Xóa"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SaveButton.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.ForeColor = System.Drawing.Color.Yellow
        Me.SaveButton.Location = New System.Drawing.Point(12, 21)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 33)
        Me.SaveButton.TabIndex = 4
        Me.SaveButton.Text = "Lưu"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'LoadButton
        '
        Me.LoadButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LoadButton.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadButton.ForeColor = System.Drawing.Color.Yellow
        Me.LoadButton.Location = New System.Drawing.Point(110, 21)
        Me.LoadButton.Name = "LoadButton"
        Me.LoadButton.Size = New System.Drawing.Size(87, 33)
        Me.LoadButton.TabIndex = 5
        Me.LoadButton.Text = "Tải lại"
        Me.LoadButton.UseVisualStyleBackColor = False
        '
        'Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.LoadButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.CreateButton)
        Me.Controls.Add(Me.CustomerLV)
        Me.Name = "Customer"
        Me.Text = "Customer"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CustomerLV As ListView
    Friend WithEvents CreateButton As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents MaKH As ColumnHeader
    Friend WithEvents TenKH As ColumnHeader
    Friend WithEvents GT As ColumnHeader
    Friend WithEvents DiaChi As ColumnHeader
    Friend WithEvents CMND As ColumnHeader
    Friend WithEvents SDT As ColumnHeader
    Friend WithEvents SaveButton As Button
    Friend WithEvents LoadButton As Button
End Class
