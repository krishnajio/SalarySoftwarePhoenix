<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdepartment
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Button1save = New System.Windows.Forms.Button
        Me.Button2upd = New System.Windows.Forms.Button
        Me.Button3del = New System.Windows.Forms.Button
        Me.Button4close = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbSalaryHead = New System.Windows.Forms.ComboBox
        Me.cmbCPFHead = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbsalCode = New System.Windows.Forms.ComboBox
        Me.cmbcpfCode = New System.Windows.Forms.ComboBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Teal
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(863, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DEPARTMENT MASTER"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Organization Id:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Department Id:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Department Name"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(137, 35)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(436, 24)
        Me.ComboBox1.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(137, 60)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(436, 22)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(137, 84)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(436, 22)
        Me.TextBox2.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.DarkGreen
        Me.DataGridView1.Location = New System.Drawing.Point(12, 197)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(839, 298)
        Me.DataGridView1.TabIndex = 9
        '
        'Button1save
        '
        Me.Button1save.Location = New System.Drawing.Point(1, 516)
        Me.Button1save.Name = "Button1save"
        Me.Button1save.Size = New System.Drawing.Size(75, 23)
        Me.Button1save.TabIndex = 5
        Me.Button1save.Text = "SAVE"
        Me.Button1save.UseVisualStyleBackColor = True
        '
        'Button2upd
        '
        Me.Button2upd.Location = New System.Drawing.Point(128, 516)
        Me.Button2upd.Name = "Button2upd"
        Me.Button2upd.Size = New System.Drawing.Size(75, 23)
        Me.Button2upd.TabIndex = 6
        Me.Button2upd.Text = "UPDATE"
        Me.Button2upd.UseVisualStyleBackColor = True
        '
        'Button3del
        '
        Me.Button3del.Location = New System.Drawing.Point(255, 515)
        Me.Button3del.Name = "Button3del"
        Me.Button3del.Size = New System.Drawing.Size(75, 23)
        Me.Button3del.TabIndex = 7
        Me.Button3del.Text = "DELETE"
        Me.Button3del.UseVisualStyleBackColor = True
        '
        'Button4close
        '
        Me.Button4close.Location = New System.Drawing.Point(382, 516)
        Me.Button4close.Name = "Button4close"
        Me.Button4close.Size = New System.Drawing.Size(75, 23)
        Me.Button4close.TabIndex = 8
        Me.Button4close.Text = "CLOSE"
        Me.Button4close.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(49, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Salary Head"
        '
        'cmbSalaryHead
        '
        Me.cmbSalaryHead.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbSalaryHead.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbSalaryHead.FormattingEnabled = True
        Me.cmbSalaryHead.Location = New System.Drawing.Point(137, 116)
        Me.cmbSalaryHead.Name = "cmbSalaryHead"
        Me.cmbSalaryHead.Size = New System.Drawing.Size(436, 24)
        Me.cmbSalaryHead.TabIndex = 3
        '
        'cmbCPFHead
        '
        Me.cmbCPFHead.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCPFHead.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCPFHead.FormattingEnabled = True
        Me.cmbCPFHead.Location = New System.Drawing.Point(137, 146)
        Me.cmbCPFHead.Name = "cmbCPFHead"
        Me.cmbCPFHead.Size = New System.Drawing.Size(436, 24)
        Me.cmbCPFHead.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(49, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "C.P.F Head"
        '
        'cmbsalCode
        '
        Me.cmbsalCode.FormattingEnabled = True
        Me.cmbsalCode.Location = New System.Drawing.Point(577, 117)
        Me.cmbsalCode.Name = "cmbsalCode"
        Me.cmbsalCode.Size = New System.Drawing.Size(120, 24)
        Me.cmbsalCode.TabIndex = 17
        '
        'cmbcpfCode
        '
        Me.cmbcpfCode.FormattingEnabled = True
        Me.cmbcpfCode.Location = New System.Drawing.Point(577, 147)
        Me.cmbcpfCode.Name = "cmbcpfCode"
        Me.cmbcpfCode.Size = New System.Drawing.Size(120, 24)
        Me.cmbcpfCode.TabIndex = 18
        '
        'frmdepartment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(863, 551)
        Me.Controls.Add(Me.cmbcpfCode)
        Me.Controls.Add(Me.cmbsalCode)
        Me.Controls.Add(Me.cmbCPFHead)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbSalaryHead)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button4close)
        Me.Controls.Add(Me.Button3del)
        Me.Controls.Add(Me.Button2upd)
        Me.Controls.Add(Me.Button1save)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmdepartment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmdepartment"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1save As System.Windows.Forms.Button
    Friend WithEvents Button2upd As System.Windows.Forms.Button
    Friend WithEvents Button3del As System.Windows.Forms.Button
    Friend WithEvents Button4close As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbSalaryHead As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCPFHead As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbsalCode As System.Windows.Forms.ComboBox
    Friend WithEvents cmbcpfCode As System.Windows.Forms.ComboBox
End Class
