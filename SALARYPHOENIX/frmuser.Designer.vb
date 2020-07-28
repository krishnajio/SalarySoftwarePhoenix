<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmuser
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
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.TextBox1uid = New System.Windows.Forms.TextBox
        Me.TextBox2uname = New System.Windows.Forms.TextBox
        Me.TextBox3pass = New System.Windows.Forms.TextBox
        Me.ComboBox1role = New System.Windows.Forms.ComboBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Button1crt = New System.Windows.Forms.Button
        Me.Button2upd = New System.Windows.Forms.Button
        Me.Button3del = New System.Windows.Forms.Button
        Me.Button4close = New System.Windows.Forms.Button
        Me.TextBox1conpass = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
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
        Me.Label1.Size = New System.Drawing.Size(623, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "USER CREATION FORM"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "User Id:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "User Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Role"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(10, 156)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(64, 20)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "Status"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBox1uid
        '
        Me.TextBox1uid.Location = New System.Drawing.Point(126, 34)
        Me.TextBox1uid.Name = "TextBox1uid"
        Me.TextBox1uid.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1uid.TabIndex = 8
        '
        'TextBox2uname
        '
        Me.TextBox2uname.Location = New System.Drawing.Point(126, 58)
        Me.TextBox2uname.Name = "TextBox2uname"
        Me.TextBox2uname.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2uname.TabIndex = 9
        '
        'TextBox3pass
        '
        Me.TextBox3pass.Location = New System.Drawing.Point(126, 82)
        Me.TextBox3pass.Name = "TextBox3pass"
        Me.TextBox3pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox3pass.Size = New System.Drawing.Size(100, 22)
        Me.TextBox3pass.TabIndex = 10
        '
        'ComboBox1role
        '
        Me.ComboBox1role.FormattingEnabled = True
        Me.ComboBox1role.Location = New System.Drawing.Point(126, 130)
        Me.ComboBox1role.Name = "ComboBox1role"
        Me.ComboBox1role.Size = New System.Drawing.Size(100, 24)
        Me.ComboBox1role.TabIndex = 11
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.DarkGreen
        Me.DataGridView1.Location = New System.Drawing.Point(232, 35)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(379, 142)
        Me.DataGridView1.TabIndex = 12
        '
        'Button1crt
        '
        Me.Button1crt.Location = New System.Drawing.Point(32, 201)
        Me.Button1crt.Name = "Button1crt"
        Me.Button1crt.Size = New System.Drawing.Size(75, 23)
        Me.Button1crt.TabIndex = 13
        Me.Button1crt.Text = "CREATE"
        Me.Button1crt.UseVisualStyleBackColor = True
        '
        'Button2upd
        '
        Me.Button2upd.Location = New System.Drawing.Point(142, 201)
        Me.Button2upd.Name = "Button2upd"
        Me.Button2upd.Size = New System.Drawing.Size(75, 23)
        Me.Button2upd.TabIndex = 14
        Me.Button2upd.Text = "UPDATE"
        Me.Button2upd.UseVisualStyleBackColor = True
        '
        'Button3del
        '
        Me.Button3del.Location = New System.Drawing.Point(252, 201)
        Me.Button3del.Name = "Button3del"
        Me.Button3del.Size = New System.Drawing.Size(75, 23)
        Me.Button3del.TabIndex = 15
        Me.Button3del.Text = "DELETE"
        Me.Button3del.UseVisualStyleBackColor = True
        '
        'Button4close
        '
        Me.Button4close.Location = New System.Drawing.Point(362, 201)
        Me.Button4close.Name = "Button4close"
        Me.Button4close.Size = New System.Drawing.Size(75, 23)
        Me.Button4close.TabIndex = 16
        Me.Button4close.Text = "CLOSE"
        Me.Button4close.UseVisualStyleBackColor = True
        '
        'TextBox1conpass
        '
        Me.TextBox1conpass.Location = New System.Drawing.Point(126, 106)
        Me.TextBox1conpass.Name = "TextBox1conpass"
        Me.TextBox1conpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox1conpass.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1conpass.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 16)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Confirm Password"
        '
        'frmuser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(623, 244)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox1conpass)
        Me.Controls.Add(Me.Button4close)
        Me.Controls.Add(Me.Button3del)
        Me.Controls.Add(Me.Button2upd)
        Me.Controls.Add(Me.Button1crt)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBox1role)
        Me.Controls.Add(Me.TextBox3pass)
        Me.Controls.Add(Me.TextBox2uname)
        Me.Controls.Add(Me.TextBox1uid)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmuser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmuser"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1uid As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2uname As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3pass As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1role As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1crt As System.Windows.Forms.Button
    Friend WithEvents Button2upd As System.Windows.Forms.Button
    Friend WithEvents Button3del As System.Windows.Forms.Button
    Friend WithEvents Button4close As System.Windows.Forms.Button
    Friend WithEvents TextBox1conpass As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
