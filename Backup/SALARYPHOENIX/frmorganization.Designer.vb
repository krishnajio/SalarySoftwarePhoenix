<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmorganization
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
        Me.TextBox1orgid = New System.Windows.Forms.TextBox
        Me.TextBox2name = New System.Windows.Forms.TextBox
        Me.TextBox3add = New System.Windows.Forms.TextBox
        Me.ComboBox1state = New System.Windows.Forms.ComboBox
        Me.ComboBox2city = New System.Windows.Forms.ComboBox
        Me.TextBox4phone = New System.Windows.Forms.TextBox
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
        Me.Label1.Size = New System.Drawing.Size(715, 24)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "ORGANIZATION MASTER"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 17)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Org Id:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 17)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Organization Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 17)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 17)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "State"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 17)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "City"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 159)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 17)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Phone"
        '
        'TextBox1orgid
        '
        Me.TextBox1orgid.Location = New System.Drawing.Point(142, 33)
        Me.TextBox1orgid.Name = "TextBox1orgid"
        Me.TextBox1orgid.Size = New System.Drawing.Size(164, 24)
        Me.TextBox1orgid.TabIndex = 23
        '
        'TextBox2name
        '
        Me.TextBox2name.Location = New System.Drawing.Point(142, 57)
        Me.TextBox2name.Name = "TextBox2name"
        Me.TextBox2name.Size = New System.Drawing.Size(164, 24)
        Me.TextBox2name.TabIndex = 24
        '
        'TextBox3add
        '
        Me.TextBox3add.Location = New System.Drawing.Point(142, 81)
        Me.TextBox3add.Name = "TextBox3add"
        Me.TextBox3add.Size = New System.Drawing.Size(164, 24)
        Me.TextBox3add.TabIndex = 25
        '
        'ComboBox1state
        '
        Me.ComboBox1state.FormattingEnabled = True
        Me.ComboBox1state.Location = New System.Drawing.Point(142, 105)
        Me.ComboBox1state.Name = "ComboBox1state"
        Me.ComboBox1state.Size = New System.Drawing.Size(165, 25)
        Me.ComboBox1state.TabIndex = 26
        '
        'ComboBox2city
        '
        Me.ComboBox2city.FormattingEnabled = True
        Me.ComboBox2city.Location = New System.Drawing.Point(142, 130)
        Me.ComboBox2city.Name = "ComboBox2city"
        Me.ComboBox2city.Size = New System.Drawing.Size(165, 25)
        Me.ComboBox2city.TabIndex = 27
        '
        'TextBox4phone
        '
        Me.TextBox4phone.Location = New System.Drawing.Point(142, 155)
        Me.TextBox4phone.Name = "TextBox4phone"
        Me.TextBox4phone.Size = New System.Drawing.Size(164, 24)
        Me.TextBox4phone.TabIndex = 28
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.DarkGreen
        Me.DataGridView1.Location = New System.Drawing.Point(313, 33)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(390, 146)
        Me.DataGridView1.TabIndex = 29
        '
        'Button1save
        '
        Me.Button1save.Location = New System.Drawing.Point(22, 209)
        Me.Button1save.Name = "Button1save"
        Me.Button1save.Size = New System.Drawing.Size(75, 23)
        Me.Button1save.TabIndex = 30
        Me.Button1save.Text = "SAVE"
        Me.Button1save.UseVisualStyleBackColor = True
        '
        'Button2upd
        '
        Me.Button2upd.Location = New System.Drawing.Point(137, 209)
        Me.Button2upd.Name = "Button2upd"
        Me.Button2upd.Size = New System.Drawing.Size(75, 23)
        Me.Button2upd.TabIndex = 31
        Me.Button2upd.Text = "UPDATE"
        Me.Button2upd.UseVisualStyleBackColor = True
        '
        'Button3del
        '
        Me.Button3del.Location = New System.Drawing.Point(252, 209)
        Me.Button3del.Name = "Button3del"
        Me.Button3del.Size = New System.Drawing.Size(75, 23)
        Me.Button3del.TabIndex = 32
        Me.Button3del.Text = "DELETE"
        Me.Button3del.UseVisualStyleBackColor = True
        '
        'Button4close
        '
        Me.Button4close.Location = New System.Drawing.Point(367, 209)
        Me.Button4close.Name = "Button4close"
        Me.Button4close.Size = New System.Drawing.Size(75, 23)
        Me.Button4close.TabIndex = 33
        Me.Button4close.Text = "CLOSE"
        Me.Button4close.UseVisualStyleBackColor = True
        '
        'frmorganization
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(715, 253)
        Me.Controls.Add(Me.Button4close)
        Me.Controls.Add(Me.Button3del)
        Me.Controls.Add(Me.Button2upd)
        Me.Controls.Add(Me.Button1save)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox4phone)
        Me.Controls.Add(Me.ComboBox2city)
        Me.Controls.Add(Me.ComboBox1state)
        Me.Controls.Add(Me.TextBox3add)
        Me.Controls.Add(Me.TextBox2name)
        Me.Controls.Add(Me.TextBox1orgid)
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
        Me.Name = "frmorganization"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmorganization"
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
    Friend WithEvents TextBox1orgid As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2name As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3add As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1state As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2city As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox4phone As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1save As System.Windows.Forms.Button
    Friend WithEvents Button2upd As System.Windows.Forms.Button
    Friend WithEvents Button3del As System.Windows.Forms.Button
    Friend WithEvents Button4close As System.Windows.Forms.Button
End Class
