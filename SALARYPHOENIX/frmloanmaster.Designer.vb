<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmloanmaster
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
        Me.ComboBox1oid = New System.Windows.Forms.ComboBox
        Me.TextBox1eid = New System.Windows.Forms.TextBox
        Me.DateTimePicker1loandate = New System.Windows.Forms.DateTimePicker
        Me.TextBox2amt = New System.Windows.Forms.TextBox
        Me.TextBox3inst = New System.Windows.Forms.TextBox
        Me.DateTimePicker2comdate = New System.Windows.Forms.DateTimePicker
        Me.Button1save = New System.Windows.Forms.Button
        Me.Button2close = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.TextBox1name = New System.Windows.Forms.TextBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Teal
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(901, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "LOAN MASTER"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(-4, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Organization Id:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Employee Id:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Loan Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Amount"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Installment"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 183)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 17)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Complete date"
        '
        'ComboBox1oid
        '
        Me.ComboBox1oid.FormattingEnabled = True
        Me.ComboBox1oid.Location = New System.Drawing.Point(106, 33)
        Me.ComboBox1oid.Name = "ComboBox1oid"
        Me.ComboBox1oid.Size = New System.Drawing.Size(527, 25)
        Me.ComboBox1oid.TabIndex = 10
        '
        'TextBox1eid
        '
        Me.TextBox1eid.Location = New System.Drawing.Point(106, 58)
        Me.TextBox1eid.Name = "TextBox1eid"
        Me.TextBox1eid.Size = New System.Drawing.Size(527, 24)
        Me.TextBox1eid.TabIndex = 11
        '
        'DateTimePicker1loandate
        '
        Me.DateTimePicker1loandate.CustomFormat = "dd/MMM/yy"
        Me.DateTimePicker1loandate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1loandate.Location = New System.Drawing.Point(106, 106)
        Me.DateTimePicker1loandate.Name = "DateTimePicker1loandate"
        Me.DateTimePicker1loandate.Size = New System.Drawing.Size(214, 24)
        Me.DateTimePicker1loandate.TabIndex = 12
        '
        'TextBox2amt
        '
        Me.TextBox2amt.Location = New System.Drawing.Point(106, 130)
        Me.TextBox2amt.Name = "TextBox2amt"
        Me.TextBox2amt.Size = New System.Drawing.Size(214, 24)
        Me.TextBox2amt.TabIndex = 13
        '
        'TextBox3inst
        '
        Me.TextBox3inst.Location = New System.Drawing.Point(106, 154)
        Me.TextBox3inst.Name = "TextBox3inst"
        Me.TextBox3inst.Size = New System.Drawing.Size(214, 24)
        Me.TextBox3inst.TabIndex = 14
        '
        'DateTimePicker2comdate
        '
        Me.DateTimePicker2comdate.CustomFormat = "dd/MMM/yy"
        Me.DateTimePicker2comdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2comdate.Location = New System.Drawing.Point(106, 178)
        Me.DateTimePicker2comdate.Name = "DateTimePicker2comdate"
        Me.DateTimePicker2comdate.Size = New System.Drawing.Size(214, 24)
        Me.DateTimePicker2comdate.TabIndex = 15
        '
        'Button1save
        '
        Me.Button1save.Location = New System.Drawing.Point(17, 230)
        Me.Button1save.Name = "Button1save"
        Me.Button1save.Size = New System.Drawing.Size(75, 23)
        Me.Button1save.TabIndex = 16
        Me.Button1save.Text = "SAVE"
        Me.Button1save.UseVisualStyleBackColor = True
        '
        'Button2close
        '
        Me.Button2close.Location = New System.Drawing.Point(106, 230)
        Me.Button2close.Name = "Button2close"
        Me.Button2close.Size = New System.Drawing.Size(75, 23)
        Me.Button2close.TabIndex = 17
        Me.Button2close.Text = "CLOSE"
        Me.Button2close.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.DarkGreen
        Me.DataGridView1.Location = New System.Drawing.Point(10, 259)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(857, 364)
        Me.DataGridView1.TabIndex = 18
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(326, 180)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(86, 21)
        Me.CheckBox1.TabIndex = 20
        Me.CheckBox1.Text = "IS PAYED"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBox1name
        '
        Me.TextBox1name.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TextBox1name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1name.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox1name.Location = New System.Drawing.Point(106, 85)
        Me.TextBox1name.Name = "TextBox1name"
        Me.TextBox1name.ReadOnly = True
        Me.TextBox1name.Size = New System.Drawing.Size(622, 20)
        Me.TextBox1name.TabIndex = 21
        '
        'frmloanmaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(901, 635)
        Me.Controls.Add(Me.TextBox1name)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2close)
        Me.Controls.Add(Me.Button1save)
        Me.Controls.Add(Me.DateTimePicker2comdate)
        Me.Controls.Add(Me.TextBox3inst)
        Me.Controls.Add(Me.TextBox2amt)
        Me.Controls.Add(Me.DateTimePicker1loandate)
        Me.Controls.Add(Me.TextBox1eid)
        Me.Controls.Add(Me.ComboBox1oid)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmloanmaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmloanmaster"
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
    Friend WithEvents ComboBox1oid As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1eid As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1loandate As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox2amt As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3inst As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker2comdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1save As System.Windows.Forms.Button
    Friend WithEvents Button2close As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1name As System.Windows.Forms.TextBox
End Class
