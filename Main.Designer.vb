<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.CustomerButton = New System.Windows.Forms.Button()
        Me.BillButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(263, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Wellcome to team 5"
        '
        'CustomerButton
        '
        Me.CustomerButton.Location = New System.Drawing.Point(151, 133)
        Me.CustomerButton.Name = "CustomerButton"
        Me.CustomerButton.Size = New System.Drawing.Size(75, 23)
        Me.CustomerButton.TabIndex = 1
        Me.CustomerButton.Text = "Khách hàng"
        Me.CustomerButton.UseVisualStyleBackColor = True
        '
        'BillButton
        '
        Me.BillButton.Location = New System.Drawing.Point(269, 133)
        Me.BillButton.Name = "BillButton"
        Me.BillButton.Size = New System.Drawing.Size(75, 23)
        Me.BillButton.TabIndex = 2
        Me.BillButton.Text = "Hóa đơn"
        Me.BillButton.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BillButton)
        Me.Controls.Add(Me.CustomerButton)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Main"
        Me.Text = "Trang chủ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CustomerButton As Button
    Friend WithEvents BillButton As Button
End Class
