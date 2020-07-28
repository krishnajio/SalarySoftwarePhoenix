<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmempdep
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
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.TextBox1eid = New System.Windows.Forms.TextBox
        Me.TextBox2name = New System.Windows.Forms.TextBox
        Me.DateTimePicker1date = New System.Windows.Forms.DateTimePicker
        Me.ComboBox1oid = New System.Windows.Forms.ComboBox
        Me.ComboBox2dep = New System.Windows.Forms.ComboBox
        Me.ComboBox3des = New System.Windows.Forms.ComboBox
        Me.TextBox3scale = New System.Windows.Forms.TextBox
        Me.DateTimePicker2doi = New System.Windows.Forms.DateTimePicker
        Me.ComboBox4joint = New System.Windows.Forms.ComboBox
        Me.TextBox4baccno = New System.Windows.Forms.TextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Button1save = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button3upd = New System.Windows.Forms.Button
        Me.Label12 = New System.Windows.Forms.Label
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
        Me.Label1.Size = New System.Drawing.Size(793, 24)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "EMPLOYEE DEPARTMENT- DESIGNATION FORM"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 17)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Employee Id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 17)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 17)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Organization id:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 17)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Department"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 17)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Dep Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 17)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Scale"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 206)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 17)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Date Of Increament"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 230)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 17)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Join Type"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 255)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 17)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Bank Account No"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 59)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 17)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Name"
        '
        'TextBox1eid
        '
        Me.TextBox1eid.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBox1eid.Location = New System.Drawing.Point(135, 35)
        Me.TextBox1eid.Name = "TextBox1eid"
        Me.TextBox1eid.ReadOnly = True
        Me.TextBox1eid.Size = New System.Drawing.Size(121, 24)
        Me.TextBox1eid.TabIndex = 28
        '
        'TextBox2name
        '
        Me.TextBox2name.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBox2name.Location = New System.Drawing.Point(135, 59)
        Me.TextBox2name.Name = "TextBox2name"
        Me.TextBox2name.ReadOnly = True
        Me.TextBox2name.Size = New System.Drawing.Size(121, 24)
        Me.TextBox2name.TabIndex = 29
        '
        'DateTimePicker1date
        '
        Me.DateTimePicker1date.CustomFormat = "dd/MMM/yy"
        Me.DateTimePicker1date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1date.Location = New System.Drawing.Point(135, 83)
        Me.DateTimePicker1date.Name = "DateTimePicker1date"
        Me.DateTimePicker1date.Size = New System.Drawing.Size(180, 24)
        Me.DateTimePicker1date.TabIndex = 30
        '
        'ComboBox1oid
        '
        Me.ComboBox1oid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1oid.FormattingEnabled = True
        Me.ComboBox1oid.Location = New System.Drawing.Point(135, 107)
        Me.ComboBox1oid.Name = "ComboBox1oid"
        Me.ComboBox1oid.Size = New System.Drawing.Size(180, 25)
        Me.ComboBox1oid.TabIndex = 31
        '
        'ComboBox2dep
        '
        Me.ComboBox2dep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2dep.FormattingEnabled = True
        Me.ComboBox2dep.Location = New System.Drawing.Point(135, 132)
        Me.ComboBox2dep.Name = "ComboBox2dep"
        Me.ComboBox2dep.Size = New System.Drawing.Size(180, 25)
        Me.ComboBox2dep.TabIndex = 32
        '
        'ComboBox3des
        '
        Me.ComboBox3des.FormattingEnabled = True
        Me.ComboBox3des.Location = New System.Drawing.Point(317, 174)
        Me.ComboBox3des.Name = "ComboBox3des"
        Me.ComboBox3des.Size = New System.Drawing.Size(121, 25)
        Me.ComboBox3des.TabIndex = 33
        Me.ComboBox3des.Text = "null"
        '
        'TextBox3scale
        '
        Me.TextBox3scale.Location = New System.Drawing.Point(135, 182)
        Me.TextBox3scale.Name = "TextBox3scale"
        Me.TextBox3scale.Size = New System.Drawing.Size(180, 24)
        Me.TextBox3scale.TabIndex = 34
        '
        'DateTimePicker2doi
        '
        Me.DateTimePicker2doi.CustomFormat = "dd/MMM/yy"
        Me.DateTimePicker2doi.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2doi.Location = New System.Drawing.Point(135, 206)
        Me.DateTimePicker2doi.Name = "DateTimePicker2doi"
        Me.DateTimePicker2doi.Size = New System.Drawing.Size(180, 24)
        Me.DateTimePicker2doi.TabIndex = 35
        '
        'ComboBox4joint
        '
        Me.ComboBox4joint.FormattingEnabled = True
        Me.ComboBox4joint.Items.AddRange(New Object() {"TEMPORARY", "PERMANENT"})
        Me.ComboBox4joint.Location = New System.Drawing.Point(135, 230)
        Me.ComboBox4joint.Name = "ComboBox4joint"
        Me.ComboBox4joint.Size = New System.Drawing.Size(180, 25)
        Me.ComboBox4joint.TabIndex = 36
        '
        'TextBox4baccno
        '
        Me.TextBox4baccno.Location = New System.Drawing.Point(135, 255)
        Me.TextBox4baccno.Name = "TextBox4baccno"
        Me.TextBox4baccno.Size = New System.Drawing.Size(180, 24)
        Me.TextBox4baccno.TabIndex = 37
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.DarkGreen
        Me.DataGridView1.Location = New System.Drawing.Point(317, 59)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(464, 375)
        Me.DataGridView1.TabIndex = 38
        '
        'Button1save
        '
        Me.Button1save.Location = New System.Drawing.Point(11, 452)
        Me.Button1save.Name = "Button1save"
        Me.Button1save.Size = New System.Drawing.Size(75, 23)
        Me.Button1save.TabIndex = 39
        Me.Button1save.Text = "SAVE"
        Me.Button1save.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(285, 452)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 40
        Me.Button2.Text = "CLOSE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(262, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "FIND ID"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3upd
        '
        Me.Button3upd.Location = New System.Drawing.Point(148, 452)
        Me.Button3upd.Name = "Button3upd"
        Me.Button3upd.Size = New System.Drawing.Size(75, 23)
        Me.Button3upd.TabIndex = 42
        Me.Button3upd.Text = "UPDATE"
        Me.Button3upd.UseVisualStyleBackColor = True
        Me.Button3upd.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(73, 159)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 15)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "Label12"
        '
        'frmempdep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(793, 487)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button3upd)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1save)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox4baccno)
        Me.Controls.Add(Me.ComboBox4joint)
        Me.Controls.Add(Me.DateTimePicker2doi)
        Me.Controls.Add(Me.TextBox3scale)
        Me.Controls.Add(Me.ComboBox3des)
        Me.Controls.Add(Me.ComboBox2dep)
        Me.Controls.Add(Me.ComboBox1oid)
        Me.Controls.Add(Me.DateTimePicker1date)
        Me.Controls.Add(Me.TextBox2name)
        Me.Controls.Add(Me.TextBox1eid)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmempdep"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmempdep"
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
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox1eid As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2name As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1date As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBox1oid As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2dep As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3des As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox3scale As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker2doi As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBox4joint As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox4baccno As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1save As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3upd As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
