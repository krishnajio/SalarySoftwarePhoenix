<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm3A
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txttofc = New System.Windows.Forms.TextBox
        Me.txtsesion = New System.Windows.Forms.TextBox
        Me.txtempid = New System.Windows.Forms.TextBox
        Me.ComboBox1org = New System.Windows.Forms.ComboBox
        Me.Label41 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txttofc)
        Me.Panel1.Controls.Add(Me.txtsesion)
        Me.Panel1.Controls.Add(Me.txtempid)
        Me.Panel1.Controls.Add(Me.ComboBox1org)
        Me.Panel1.Controls.Add(Me.Label41)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(900, 53)
        Me.Panel1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(342, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "TO FC"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(185, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "FROM FC"
        '
        'txttofc
        '
        Me.txttofc.Location = New System.Drawing.Point(391, 4)
        Me.txttofc.Name = "txttofc"
        Me.txttofc.Size = New System.Drawing.Size(136, 20)
        Me.txttofc.TabIndex = 57
        '
        'txtsesion
        '
        Me.txtsesion.Location = New System.Drawing.Point(613, 6)
        Me.txtsesion.Name = "txtsesion"
        Me.txtsesion.Size = New System.Drawing.Size(136, 20)
        Me.txtsesion.TabIndex = 56
        '
        'txtempid
        '
        Me.txtempid.Location = New System.Drawing.Point(252, 4)
        Me.txtempid.Name = "txtempid"
        Me.txtempid.Size = New System.Drawing.Size(84, 20)
        Me.txtempid.TabIndex = 55
        '
        'ComboBox1org
        '
        Me.ComboBox1org.FormattingEnabled = True
        Me.ComboBox1org.Location = New System.Drawing.Point(85, 5)
        Me.ComboBox1org.Name = "ComboBox1org"
        Me.ComboBox1org.Size = New System.Drawing.Size(94, 21)
        Me.ComboBox1org.TabIndex = 54
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(7, 9)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(82, 13)
        Me.Label41.TabIndex = 53
        Me.Label41.Text = "Organization "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(755, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "SHOW"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(534, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "For Session"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 53)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(900, 448)
        Me.CrystalReportViewer1.TabIndex = 6
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'frm3A
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 501)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm3A"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm3A"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ComboBox1org As System.Windows.Forms.ComboBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents txtempid As System.Windows.Forms.TextBox
    Friend WithEvents txtsesion As System.Windows.Forms.TextBox
    Friend WithEvents txttofc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
