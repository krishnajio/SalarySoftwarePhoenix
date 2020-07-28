<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsalarystructure
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
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.ComboBox1orgid = New System.Windows.Forms.ComboBox
        Me.TextBox1da = New System.Windows.Forms.TextBox
        Me.TextBox2hr = New System.Windows.Forms.TextBox
        Me.TextBox3cc = New System.Windows.Forms.TextBox
        Me.TextBox4pf = New System.Windows.Forms.TextBox
        Me.TextBox5ec = New System.Windows.Forms.TextBox
        Me.TextBox6maxpf = New System.Windows.Forms.TextBox
        Me.TextBox7totpf = New System.Windows.Forms.TextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Button1save = New System.Windows.Forms.Button
        Me.Button2upd = New System.Windows.Forms.Button
        Me.Button3del = New System.Windows.Forms.Button
        Me.Button4close = New System.Windows.Forms.Button
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
        Me.Label1.Size = New System.Drawing.Size(772, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SALARY STRUCTURE MASTER FORM"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Organization Id:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "DA Percentage"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "HR Percentage"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "CC Percentage"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "PF Percentage"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "EC Percentage"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 186)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 16)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Max PF Amount"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 211)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 16)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Total PF Amount"
        '
        'ComboBox1orgid
        '
        Me.ComboBox1orgid.FormattingEnabled = True
        Me.ComboBox1orgid.Location = New System.Drawing.Point(126, 39)
        Me.ComboBox1orgid.Name = "ComboBox1orgid"
        Me.ComboBox1orgid.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1orgid.TabIndex = 10
        '
        'TextBox1da
        '
        Me.TextBox1da.Location = New System.Drawing.Point(126, 64)
        Me.TextBox1da.Name = "TextBox1da"
        Me.TextBox1da.Size = New System.Drawing.Size(120, 22)
        Me.TextBox1da.TabIndex = 11
        '
        'TextBox2hr
        '
        Me.TextBox2hr.Location = New System.Drawing.Point(126, 88)
        Me.TextBox2hr.Name = "TextBox2hr"
        Me.TextBox2hr.Size = New System.Drawing.Size(120, 22)
        Me.TextBox2hr.TabIndex = 12
        '
        'TextBox3cc
        '
        Me.TextBox3cc.Location = New System.Drawing.Point(126, 112)
        Me.TextBox3cc.Name = "TextBox3cc"
        Me.TextBox3cc.Size = New System.Drawing.Size(120, 22)
        Me.TextBox3cc.TabIndex = 13
        '
        'TextBox4pf
        '
        Me.TextBox4pf.Location = New System.Drawing.Point(126, 136)
        Me.TextBox4pf.Name = "TextBox4pf"
        Me.TextBox4pf.Size = New System.Drawing.Size(120, 22)
        Me.TextBox4pf.TabIndex = 14
        '
        'TextBox5ec
        '
        Me.TextBox5ec.Location = New System.Drawing.Point(126, 160)
        Me.TextBox5ec.Name = "TextBox5ec"
        Me.TextBox5ec.Size = New System.Drawing.Size(120, 22)
        Me.TextBox5ec.TabIndex = 15
        '
        'TextBox6maxpf
        '
        Me.TextBox6maxpf.Location = New System.Drawing.Point(126, 184)
        Me.TextBox6maxpf.Name = "TextBox6maxpf"
        Me.TextBox6maxpf.Size = New System.Drawing.Size(120, 22)
        Me.TextBox6maxpf.TabIndex = 16
        '
        'TextBox7totpf
        '
        Me.TextBox7totpf.Location = New System.Drawing.Point(126, 208)
        Me.TextBox7totpf.Name = "TextBox7totpf"
        Me.TextBox7totpf.Size = New System.Drawing.Size(120, 22)
        Me.TextBox7totpf.TabIndex = 17
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.DarkGreen
        Me.DataGridView1.Location = New System.Drawing.Point(254, 39)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(506, 193)
        Me.DataGridView1.TabIndex = 18
        '
        'Button1save
        '
        Me.Button1save.Location = New System.Drawing.Point(25, 257)
        Me.Button1save.Name = "Button1save"
        Me.Button1save.Size = New System.Drawing.Size(75, 23)
        Me.Button1save.TabIndex = 19
        Me.Button1save.Text = "SAVE"
        Me.Button1save.UseVisualStyleBackColor = True
        '
        'Button2upd
        '
        Me.Button2upd.Location = New System.Drawing.Point(138, 257)
        Me.Button2upd.Name = "Button2upd"
        Me.Button2upd.Size = New System.Drawing.Size(75, 23)
        Me.Button2upd.TabIndex = 20
        Me.Button2upd.Text = "UPDATE"
        Me.Button2upd.UseVisualStyleBackColor = True
        '
        'Button3del
        '
        Me.Button3del.Location = New System.Drawing.Point(251, 257)
        Me.Button3del.Name = "Button3del"
        Me.Button3del.Size = New System.Drawing.Size(75, 23)
        Me.Button3del.TabIndex = 21
        Me.Button3del.Text = "DELETE"
        Me.Button3del.UseVisualStyleBackColor = True
        '
        'Button4close
        '
        Me.Button4close.Location = New System.Drawing.Point(364, 256)
        Me.Button4close.Name = "Button4close"
        Me.Button4close.Size = New System.Drawing.Size(75, 23)
        Me.Button4close.TabIndex = 22
        Me.Button4close.Text = "CLOSE"
        Me.Button4close.UseVisualStyleBackColor = True
        '
        'frmsalarystructure
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(772, 297)
        Me.Controls.Add(Me.Button4close)
        Me.Controls.Add(Me.Button3del)
        Me.Controls.Add(Me.Button2upd)
        Me.Controls.Add(Me.Button1save)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox7totpf)
        Me.Controls.Add(Me.TextBox6maxpf)
        Me.Controls.Add(Me.TextBox5ec)
        Me.Controls.Add(Me.TextBox4pf)
        Me.Controls.Add(Me.TextBox3cc)
        Me.Controls.Add(Me.TextBox2hr)
        Me.Controls.Add(Me.TextBox1da)
        Me.Controls.Add(Me.ComboBox1orgid)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmsalarystructure"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmsalarystructure"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1orgid As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1da As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2hr As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3cc As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4pf As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5ec As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6maxpf As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7totpf As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1save As System.Windows.Forms.Button
    Friend WithEvents Button2upd As System.Windows.Forms.Button
    Friend WithEvents Button3del As System.Windows.Forms.Button
    Friend WithEvents Button4close As System.Windows.Forms.Button
End Class
