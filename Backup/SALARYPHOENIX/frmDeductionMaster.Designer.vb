<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeductionMaster
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmdEmpName = New System.Windows.Forms.ComboBox
        Me.cmbEmpCode = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtTotalDed = New System.Windows.Forms.TextBox
        Me.txtMonthlyDed = New System.Windows.Forms.TextBox
        Me.Button1upd = New System.Windows.Forms.Button
        Me.Button2close = New System.Windows.Forms.Button
        Me.Button1save = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(843, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "EMPLOYEE DEDUCTION"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(100, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 20)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(587, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 20)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Employee Id:"
        '
        'cmdEmpName
        '
        Me.cmdEmpName.FormattingEnabled = True
        Me.cmdEmpName.Location = New System.Drawing.Point(161, 41)
        Me.cmdEmpName.Name = "cmdEmpName"
        Me.cmdEmpName.Size = New System.Drawing.Size(420, 21)
        Me.cmdEmpName.TabIndex = 47
        '
        'cmbEmpCode
        '
        Me.cmbEmpCode.FormattingEnabled = True
        Me.cmbEmpCode.Location = New System.Drawing.Point(706, 41)
        Me.cmbEmpCode.Name = "cmbEmpCode"
        Me.cmbEmpCode.Size = New System.Drawing.Size(115, 21)
        Me.cmbEmpCode.TabIndex = 48
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 20)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Total Deduction"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(-3, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 20)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Monthly Deduction"
        '
        'txtTotalDed
        '
        Me.txtTotalDed.Location = New System.Drawing.Point(162, 74)
        Me.txtTotalDed.Name = "txtTotalDed"
        Me.txtTotalDed.Size = New System.Drawing.Size(161, 20)
        Me.txtTotalDed.TabIndex = 51
        '
        'txtMonthlyDed
        '
        Me.txtMonthlyDed.Location = New System.Drawing.Point(162, 109)
        Me.txtMonthlyDed.Name = "txtMonthlyDed"
        Me.txtMonthlyDed.Size = New System.Drawing.Size(161, 20)
        Me.txtMonthlyDed.TabIndex = 52
        '
        'Button1upd
        '
        Me.Button1upd.BackColor = System.Drawing.Color.Gray
        Me.Button1upd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1upd.Location = New System.Drawing.Point(290, 151)
        Me.Button1upd.Name = "Button1upd"
        Me.Button1upd.Size = New System.Drawing.Size(91, 23)
        Me.Button1upd.TabIndex = 75
        Me.Button1upd.Text = "DELETE"
        Me.Button1upd.UseVisualStyleBackColor = False
        '
        'Button2close
        '
        Me.Button2close.BackColor = System.Drawing.Color.Gray
        Me.Button2close.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2close.Location = New System.Drawing.Point(391, 151)
        Me.Button2close.Name = "Button2close"
        Me.Button2close.Size = New System.Drawing.Size(91, 23)
        Me.Button2close.TabIndex = 74
        Me.Button2close.Text = "CLOSE"
        Me.Button2close.UseVisualStyleBackColor = False
        '
        'Button1save
        '
        Me.Button1save.BackColor = System.Drawing.Color.Gray
        Me.Button1save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1save.Location = New System.Drawing.Point(190, 151)
        Me.Button1save.Name = "Button1save"
        Me.Button1save.Size = New System.Drawing.Size(91, 23)
        Me.Button1save.TabIndex = 73
        Me.Button1save.Text = "SAVE"
        Me.Button1save.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 180)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(808, 282)
        Me.DataGridView1.TabIndex = 76
        '
        'frmDeductionMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(843, 496)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1upd)
        Me.Controls.Add(Me.Button2close)
        Me.Controls.Add(Me.Button1save)
        Me.Controls.Add(Me.txtMonthlyDed)
        Me.Controls.Add(Me.txtTotalDed)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbEmpCode)
        Me.Controls.Add(Me.cmdEmpName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmDeductionMaster"
        Me.Text = "frmDeductionMaster"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdEmpName As System.Windows.Forms.ComboBox
    Friend WithEvents cmbEmpCode As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTotalDed As System.Windows.Forms.TextBox
    Friend WithEvents txtMonthlyDed As System.Windows.Forms.TextBox
    Friend WithEvents Button1upd As System.Windows.Forms.Button
    Friend WithEvents Button2close As System.Windows.Forms.Button
    Friend WithEvents Button1save As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
