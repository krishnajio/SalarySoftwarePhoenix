<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmbankmaster
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
        Me.TextBox1bname = New System.Windows.Forms.TextBox
        Me.TextBox2branch = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.ComboBox1state = New System.Windows.Forms.ComboBox
        Me.ComboBox2city = New System.Windows.Forms.ComboBox
        Me.TextBox4phone = New System.Windows.Forms.TextBox
        Me.Button1save = New System.Windows.Forms.Button
        Me.Button3delete = New System.Windows.Forms.Button
        Me.Button4clode = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
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
        Me.Label1.Size = New System.Drawing.Size(790, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BANK MASTER FORM"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 41)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Bank Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 65)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Branch"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 114)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "City"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 139)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Phone"
        '
        'TextBox1bname
        '
        Me.TextBox1bname.Location = New System.Drawing.Point(90, 38)
        Me.TextBox1bname.Name = "TextBox1bname"
        Me.TextBox1bname.Size = New System.Drawing.Size(196, 24)
        Me.TextBox1bname.TabIndex = 6
        '
        'TextBox2branch
        '
        Me.TextBox2branch.Location = New System.Drawing.Point(90, 62)
        Me.TextBox2branch.Name = "TextBox2branch"
        Me.TextBox2branch.Size = New System.Drawing.Size(196, 24)
        Me.TextBox2branch.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 89)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 17)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "State"
        '
        'ComboBox1state
        '
        Me.ComboBox1state.FormattingEnabled = True
        Me.ComboBox1state.Location = New System.Drawing.Point(90, 86)
        Me.ComboBox1state.Name = "ComboBox1state"
        Me.ComboBox1state.Size = New System.Drawing.Size(196, 25)
        Me.ComboBox1state.TabIndex = 10
        '
        'ComboBox2city
        '
        Me.ComboBox2city.FormattingEnabled = True
        Me.ComboBox2city.Location = New System.Drawing.Point(90, 111)
        Me.ComboBox2city.Name = "ComboBox2city"
        Me.ComboBox2city.Size = New System.Drawing.Size(196, 25)
        Me.ComboBox2city.TabIndex = 11
        '
        'TextBox4phone
        '
        Me.TextBox4phone.Location = New System.Drawing.Point(90, 136)
        Me.TextBox4phone.Name = "TextBox4phone"
        Me.TextBox4phone.Size = New System.Drawing.Size(196, 24)
        Me.TextBox4phone.TabIndex = 12
        '
        'Button1save
        '
        Me.Button1save.Location = New System.Drawing.Point(21, 183)
        Me.Button1save.Name = "Button1save"
        Me.Button1save.Size = New System.Drawing.Size(75, 23)
        Me.Button1save.TabIndex = 14
        Me.Button1save.Text = "Save"
        Me.Button1save.UseVisualStyleBackColor = True
        '
        'Button3delete
        '
        Me.Button3delete.Location = New System.Drawing.Point(168, 183)
        Me.Button3delete.Name = "Button3delete"
        Me.Button3delete.Size = New System.Drawing.Size(75, 23)
        Me.Button3delete.TabIndex = 16
        Me.Button3delete.Text = "Delete"
        Me.Button3delete.UseVisualStyleBackColor = True
        '
        'Button4clode
        '
        Me.Button4clode.Location = New System.Drawing.Point(315, 183)
        Me.Button4clode.Name = "Button4clode"
        Me.Button4clode.Size = New System.Drawing.Size(75, 23)
        Me.Button4clode.TabIndex = 17
        Me.Button4clode.Text = "Close"
        Me.Button4clode.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.Green
        Me.DataGridView1.Location = New System.Drawing.Point(292, 38)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(489, 124)
        Me.DataGridView1.TabIndex = 13
        '
        'frmbankmaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(790, 220)
        Me.Controls.Add(Me.Button4clode)
        Me.Controls.Add(Me.Button3delete)
        Me.Controls.Add(Me.Button1save)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox4phone)
        Me.Controls.Add(Me.ComboBox2city)
        Me.Controls.Add(Me.ComboBox1state)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox2branch)
        Me.Controls.Add(Me.TextBox1bname)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmbankmaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmbankmaster"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox1bname As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2branch As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1state As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2city As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox4phone As System.Windows.Forms.TextBox
    Friend WithEvents Button1save As System.Windows.Forms.Button
    Friend WithEvents Button3delete As System.Windows.Forms.Button
    Friend WithEvents Button4clode As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
