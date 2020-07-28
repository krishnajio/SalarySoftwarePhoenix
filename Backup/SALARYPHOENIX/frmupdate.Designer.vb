<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmupdate
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.org = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.empid = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.basic = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.da = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.hra = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cca = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.oa1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.oa2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ComboBox1oid = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.org, Me.name, Me.empid, Me.basic, Me.da, Me.hra, Me.cca, Me.oa1, Me.oa2})
        Me.DataGridView1.Location = New System.Drawing.Point(15, 35)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(853, 406)
        Me.DataGridView1.TabIndex = 0
        '
        'org
        '
        Me.org.DataPropertyName = "orgid"
        Me.org.HeaderText = "org"
        Me.org.Name = "org"
        Me.org.ReadOnly = True
        '
        'name
        '
        Me.name.DataPropertyName = "name"
        Me.name.HeaderText = "name"
        Me.name.Name = "name"
        Me.name.ReadOnly = True
        '
        'empid
        '
        Me.empid.DataPropertyName = "empid"
        Me.empid.HeaderText = "empid"
        Me.empid.Name = "empid"
        Me.empid.ReadOnly = True
        '
        'basic
        '
        Me.basic.DataPropertyName = "basic"
        Me.basic.HeaderText = "basic"
        Me.basic.Name = "basic"
        '
        'da
        '
        Me.da.DataPropertyName = "da"
        Me.da.HeaderText = "da"
        Me.da.Name = "da"
        '
        'hra
        '
        Me.hra.DataPropertyName = "hra"
        Me.hra.HeaderText = "hra"
        Me.hra.Name = "hra"
        '
        'cca
        '
        Me.cca.DataPropertyName = "cca"
        Me.cca.HeaderText = "field"
        Me.cca.Name = "cca"
        '
        'oa1
        '
        Me.oa1.DataPropertyName = "oa1"
        Me.oa1.HeaderText = "oa1"
        Me.oa1.Name = "oa1"
        '
        'oa2
        '
        Me.oa2.DataPropertyName = "oa2"
        Me.oa2.HeaderText = "oa2"
        Me.oa2.Name = "oa2"
        '
        'ComboBox1oid
        '
        Me.ComboBox1oid.FormattingEnabled = True
        Me.ComboBox1oid.Location = New System.Drawing.Point(126, 8)
        Me.ComboBox1oid.Name = "ComboBox1oid"
        Me.ComboBox1oid.Size = New System.Drawing.Size(96, 21)
        Me.ComboBox1oid.TabIndex = 82
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "Organization Id:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(30, 456)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 83
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(306, 6)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(221, 20)
        Me.TextBox1.TabIndex = 84
        '
        'frmupdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 502)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1oid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        ' Me.name = "frmupdate"
        Me.Text = "frmupdate3212"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ComboBox1oid As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents org As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents empid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents basic As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents da As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents oa1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents oa2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
