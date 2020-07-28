<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdesignation
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
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.ComboBox1orgid = New System.Windows.Forms.ComboBox
        Me.ComboBox2depid = New System.Windows.Forms.ComboBox
        Me.TextBox1des = New System.Windows.Forms.TextBox
        Me.TextBox2ordno = New System.Windows.Forms.TextBox
        Me.TextBox3cat = New System.Windows.Forms.TextBox
        Me.TextBox4scale = New System.Windows.Forms.TextBox
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
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(704, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "DESIGNATION MASTER"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Org Id:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Designation"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Department Id:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Order No."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 143)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 17)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Category"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 167)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 17)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Scale"
        '
        'ComboBox1orgid
        '
        Me.ComboBox1orgid.FormattingEnabled = True
        Me.ComboBox1orgid.Location = New System.Drawing.Point(114, 38)
        Me.ComboBox1orgid.Name = "ComboBox1orgid"
        Me.ComboBox1orgid.Size = New System.Drawing.Size(121, 25)
        Me.ComboBox1orgid.TabIndex = 10
        '
        'ComboBox2depid
        '
        Me.ComboBox2depid.FormattingEnabled = True
        Me.ComboBox2depid.Location = New System.Drawing.Point(114, 63)
        Me.ComboBox2depid.Name = "ComboBox2depid"
        Me.ComboBox2depid.Size = New System.Drawing.Size(121, 25)
        Me.ComboBox2depid.TabIndex = 11
        '
        'TextBox1des
        '
        Me.TextBox1des.Location = New System.Drawing.Point(114, 88)
        Me.TextBox1des.Name = "TextBox1des"
        Me.TextBox1des.Size = New System.Drawing.Size(120, 24)
        Me.TextBox1des.TabIndex = 13
        '
        'TextBox2ordno
        '
        Me.TextBox2ordno.Location = New System.Drawing.Point(114, 112)
        Me.TextBox2ordno.Name = "TextBox2ordno"
        Me.TextBox2ordno.Size = New System.Drawing.Size(120, 24)
        Me.TextBox2ordno.TabIndex = 14
        '
        'TextBox3cat
        '
        Me.TextBox3cat.Location = New System.Drawing.Point(114, 136)
        Me.TextBox3cat.Name = "TextBox3cat"
        Me.TextBox3cat.Size = New System.Drawing.Size(120, 24)
        Me.TextBox3cat.TabIndex = 15
        '
        'TextBox4scale
        '
        Me.TextBox4scale.Location = New System.Drawing.Point(114, 160)
        Me.TextBox4scale.Name = "TextBox4scale"
        Me.TextBox4scale.Size = New System.Drawing.Size(120, 24)
        Me.TextBox4scale.TabIndex = 16
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.Green
        Me.DataGridView1.Location = New System.Drawing.Point(242, 38)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(450, 171)
        Me.DataGridView1.TabIndex = 17
        '
        'Button1save
        '
        Me.Button1save.Location = New System.Drawing.Point(26, 239)
        Me.Button1save.Name = "Button1save"
        Me.Button1save.Size = New System.Drawing.Size(75, 23)
        Me.Button1save.TabIndex = 18
        Me.Button1save.Text = "SAVE"
        Me.Button1save.UseVisualStyleBackColor = True
        '
        'Button2upd
        '
        Me.Button2upd.Location = New System.Drawing.Point(159, 239)
        Me.Button2upd.Name = "Button2upd"
        Me.Button2upd.Size = New System.Drawing.Size(75, 23)
        Me.Button2upd.TabIndex = 19
        Me.Button2upd.Text = "UPDATE"
        Me.Button2upd.UseVisualStyleBackColor = True
        '
        'Button3del
        '
        Me.Button3del.Location = New System.Drawing.Point(292, 239)
        Me.Button3del.Name = "Button3del"
        Me.Button3del.Size = New System.Drawing.Size(75, 23)
        Me.Button3del.TabIndex = 20
        Me.Button3del.Text = "DELETE"
        Me.Button3del.UseVisualStyleBackColor = True
        '
        'Button4close
        '
        Me.Button4close.Location = New System.Drawing.Point(425, 239)
        Me.Button4close.Name = "Button4close"
        Me.Button4close.Size = New System.Drawing.Size(75, 23)
        Me.Button4close.TabIndex = 21
        Me.Button4close.Text = "CLOSE"
        Me.Button4close.UseVisualStyleBackColor = True
        '
        'frmdesignation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(704, 288)
        Me.Controls.Add(Me.Button4close)
        Me.Controls.Add(Me.Button3del)
        Me.Controls.Add(Me.Button2upd)
        Me.Controls.Add(Me.Button1save)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox4scale)
        Me.Controls.Add(Me.TextBox3cat)
        Me.Controls.Add(Me.TextBox2ordno)
        Me.Controls.Add(Me.TextBox1des)
        Me.Controls.Add(Me.ComboBox2depid)
        Me.Controls.Add(Me.ComboBox1orgid)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmdesignation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmdesignation"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1orgid As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2depid As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1des As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2ordno As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3cat As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4scale As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1save As System.Windows.Forms.Button
    Friend WithEvents Button2upd As System.Windows.Forms.Button
    Friend WithEvents Button3del As System.Windows.Forms.Button
    Friend WithEvents Button4close As System.Windows.Forms.Button
End Class
