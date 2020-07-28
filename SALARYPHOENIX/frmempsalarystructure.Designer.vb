<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmempsalarystructure
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
        Dim edc_csLabel As System.Windows.Forms.Label
        Dim basicLabel As System.Windows.Forms.Label
        Dim hraLabel As System.Windows.Forms.Label
        Dim ccaLabelfieall As System.Windows.Forms.Label
        Dim epfLabel As System.Windows.Forms.Label
        Dim oa2Label As System.Windows.Forms.Label
        Dim i_taxLabel As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim Label16 As System.Windows.Forms.Label
        Dim Label17 As System.Windows.Forms.Label
        Me.oa1Label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1orgid = New System.Windows.Forms.TextBox()
        Me.TextBox2eid = New System.Windows.Forms.TextBox()
        Me.TextBox3name = New System.Windows.Forms.TextBox()
        Me.TextBox4basic = New System.Windows.Forms.TextBox()
        Me.TextBox5da = New System.Windows.Forms.TextBox()
        Me.TextBox6hra = New System.Windows.Forms.TextBox()
        Me.TextBox7cca = New System.Windows.Forms.TextBox()
        Me.TextBox8epf = New System.Windows.Forms.TextBox()
        Me.TextBox9educease = New System.Windows.Forms.TextBox()
        Me.TextBox10oa1 = New System.Windows.Forms.TextBox()
        Me.TextBox11oa2 = New System.Windows.Forms.TextBox()
        Me.TextBox12itax = New System.Windows.Forms.TextBox()
        Me.CheckBox1egpen = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox13daamt = New System.Windows.Forms.TextBox()
        Me.TextBox14hraamt = New System.Windows.Forms.TextBox()
        Me.TextBox15ccaamt = New System.Windows.Forms.TextBox()
        Me.TextBox16pfamt = New System.Windows.Forms.TextBox()
        Me.TextBox17educeaseamt = New System.Windows.Forms.TextBox()
        Me.Button1save = New System.Windows.Forms.Button()
        Me.Button2close = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1upd = New System.Windows.Forms.Button()
        Me.TextBox1tds = New System.Windows.Forms.TextBox()
        Me.TextBox1grpins = New System.Windows.Forms.TextBox()
        Me.TextBox1secdep = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox1od1 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txtpfBasicOA = New System.Windows.Forms.TextBox()
        Me.txtProftax = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtEmpId = New System.Windows.Forms.TextBox()
        Me.CheckBoxForEsi = New System.Windows.Forms.CheckBox()
        edc_csLabel = New System.Windows.Forms.Label()
        basicLabel = New System.Windows.Forms.Label()
        hraLabel = New System.Windows.Forms.Label()
        ccaLabelfieall = New System.Windows.Forms.Label()
        epfLabel = New System.Windows.Forms.Label()
        oa2Label = New System.Windows.Forms.Label()
        i_taxLabel = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label15 = New System.Windows.Forms.Label()
        Label16 = New System.Windows.Forms.Label()
        Label17 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'edc_csLabel
        '
        edc_csLabel.AutoSize = True
        edc_csLabel.Location = New System.Drawing.Point(54, 264)
        edc_csLabel.Name = "edc_csLabel"
        edc_csLabel.Size = New System.Drawing.Size(81, 16)
        edc_csLabel.TabIndex = 37
        edc_csLabel.Text = "EdU Cease:"
        '
        'basicLabel
        '
        basicLabel.AutoSize = True
        basicLabel.Location = New System.Drawing.Point(86, 113)
        basicLabel.Name = "basicLabel"
        basicLabel.Size = New System.Drawing.Size(45, 16)
        basicLabel.TabIndex = 32
        basicLabel.Text = "Basic:"
        basicLabel.Visible = False
        '
        'hraLabel
        '
        hraLabel.AutoSize = True
        hraLabel.Location = New System.Drawing.Point(87, 192)
        hraLabel.Name = "hraLabel"
        hraLabel.Size = New System.Drawing.Size(40, 16)
        hraLabel.TabIndex = 34
        hraLabel.Text = "HRA:"
        '
        'ccaLabelfieall
        '
        ccaLabelfieall.AutoSize = True
        ccaLabelfieall.Location = New System.Drawing.Point(7, 216)
        ccaLabelfieall.Name = "ccaLabelfieall"
        ccaLabelfieall.Size = New System.Drawing.Size(119, 16)
        ccaLabelfieall.TabIndex = 35
        ccaLabelfieall.Text = "TRAVEL. ALLOW.."
        '
        'epfLabel
        '
        epfLabel.AutoSize = True
        epfLabel.Location = New System.Drawing.Point(24, 240)
        epfLabel.Name = "epfLabel"
        epfLabel.Size = New System.Drawing.Size(111, 16)
        epfLabel.TabIndex = 36
        epfLabel.Text = "EPF: (Basic+O.A)"
        '
        'oa2Label
        '
        oa2Label.AutoSize = True
        oa2Label.Location = New System.Drawing.Point(47, 311)
        oa2Label.Name = "oa2Label"
        oa2Label.Size = New System.Drawing.Size(84, 16)
        oa2Label.TabIndex = 39
        oa2Label.Text = "OA/Incentive"
        '
        'i_taxLabel
        '
        i_taxLabel.AutoSize = True
        i_taxLabel.Location = New System.Drawing.Point(240, 332)
        i_taxLabel.Name = "i_taxLabel"
        i_taxLabel.Size = New System.Drawing.Size(36, 16)
        i_taxLabel.TabIndex = 40
        i_taxLabel.Text = "TDS"
        i_taxLabel.Visible = False
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(177, 467)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(112, 16)
        Label10.TabIndex = 73
        Label10.Text = "Proffessional Tax"
        Label10.Visible = False
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(47, 336)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(78, 16)
        Label11.TabIndex = 75
        Label11.Text = "Group Insu.."
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.BackColor = System.Drawing.Color.Orange
        Label12.Location = New System.Drawing.Point(54, 360)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(76, 16)
        Label12.TabIndex = 77
        Label12.Text = "TOTAL ESI"
        '
        'Label15
        '
        Label15.AutoSize = True
        Label15.ForeColor = System.Drawing.Color.Red
        Label15.Location = New System.Drawing.Point(73, 431)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(55, 16)
        Label15.TabIndex = 85
        Label15.Text = "TOTAL "
        '
        'Label16
        '
        Label16.AutoSize = True
        Label16.Location = New System.Drawing.Point(31, 140)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(103, 16)
        Label16.TabIndex = 87
        Label16.Text = "PF Basic + O.A :"
        '
        'Label17
        '
        Label17.AutoSize = True
        Label17.Location = New System.Drawing.Point(927, 34)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(109, 16)
        Label17.TabIndex = 89
        Label17.Text = "ORGANIZATION"
        '
        'oa1Label
        '
        Me.oa1Label.AutoSize = True
        Me.oa1Label.BackColor = System.Drawing.Color.Orange
        Me.oa1Label.Location = New System.Drawing.Point(18, 286)
        Me.oa1Label.Name = "oa1Label"
        Me.oa1Label.Size = New System.Drawing.Size(114, 16)
        Me.oa1Label.TabIndex = 38
        Me.oa1Label.Text = "EMP.SHARE ESI:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1212, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "EMPLOYEE SALARY STRUCTURE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Organization Id:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 16)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Employee Id:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 16)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Name"
        '
        'TextBox1orgid
        '
        Me.TextBox1orgid.BackColor = System.Drawing.Color.AliceBlue
        Me.TextBox1orgid.Location = New System.Drawing.Point(134, 58)
        Me.TextBox1orgid.Name = "TextBox1orgid"
        Me.TextBox1orgid.ReadOnly = True
        Me.TextBox1orgid.Size = New System.Drawing.Size(181, 22)
        Me.TextBox1orgid.TabIndex = 45
        '
        'TextBox2eid
        '
        Me.TextBox2eid.BackColor = System.Drawing.Color.AliceBlue
        Me.TextBox2eid.Location = New System.Drawing.Point(134, 82)
        Me.TextBox2eid.Name = "TextBox2eid"
        Me.TextBox2eid.ReadOnly = True
        Me.TextBox2eid.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2eid.TabIndex = 46
        '
        'TextBox3name
        '
        Me.TextBox3name.BackColor = System.Drawing.Color.AliceBlue
        Me.TextBox3name.Location = New System.Drawing.Point(54, 2)
        Me.TextBox3name.Name = "TextBox3name"
        Me.TextBox3name.Size = New System.Drawing.Size(248, 22)
        Me.TextBox3name.TabIndex = 47
        '
        'TextBox4basic
        '
        Me.TextBox4basic.Location = New System.Drawing.Point(134, 106)
        Me.TextBox4basic.Name = "TextBox4basic"
        Me.TextBox4basic.Size = New System.Drawing.Size(100, 22)
        Me.TextBox4basic.TabIndex = 48
        Me.TextBox4basic.Visible = False
        '
        'TextBox5da
        '
        Me.TextBox5da.Location = New System.Drawing.Point(134, 161)
        Me.TextBox5da.Name = "TextBox5da"
        Me.TextBox5da.ReadOnly = True
        Me.TextBox5da.Size = New System.Drawing.Size(100, 22)
        Me.TextBox5da.TabIndex = 49
        '
        'TextBox6hra
        '
        Me.TextBox6hra.Location = New System.Drawing.Point(134, 185)
        Me.TextBox6hra.Name = "TextBox6hra"
        Me.TextBox6hra.Size = New System.Drawing.Size(100, 22)
        Me.TextBox6hra.TabIndex = 50
        Me.TextBox6hra.Text = "40"
        '
        'TextBox7cca
        '
        Me.TextBox7cca.Location = New System.Drawing.Point(134, 209)
        Me.TextBox7cca.Name = "TextBox7cca"
        Me.TextBox7cca.Size = New System.Drawing.Size(100, 22)
        Me.TextBox7cca.TabIndex = 51
        '
        'TextBox8epf
        '
        Me.TextBox8epf.Location = New System.Drawing.Point(134, 233)
        Me.TextBox8epf.Name = "TextBox8epf"
        Me.TextBox8epf.ReadOnly = True
        Me.TextBox8epf.Size = New System.Drawing.Size(100, 22)
        Me.TextBox8epf.TabIndex = 52
        Me.TextBox8epf.Text = "12"
        '
        'TextBox9educease
        '
        Me.TextBox9educease.Location = New System.Drawing.Point(134, 257)
        Me.TextBox9educease.Name = "TextBox9educease"
        Me.TextBox9educease.Size = New System.Drawing.Size(100, 22)
        Me.TextBox9educease.TabIndex = 53
        Me.TextBox9educease.Text = "0"
        '
        'TextBox10oa1
        '
        Me.TextBox10oa1.Location = New System.Drawing.Point(134, 281)
        Me.TextBox10oa1.Name = "TextBox10oa1"
        Me.TextBox10oa1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox10oa1.TabIndex = 54
        Me.TextBox10oa1.Text = "0"
        '
        'TextBox11oa2
        '
        Me.TextBox11oa2.Location = New System.Drawing.Point(134, 305)
        Me.TextBox11oa2.Name = "TextBox11oa2"
        Me.TextBox11oa2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox11oa2.TabIndex = 55
        Me.TextBox11oa2.Text = "0"
        '
        'TextBox12itax
        '
        Me.TextBox12itax.Location = New System.Drawing.Point(240, 327)
        Me.TextBox12itax.Name = "TextBox12itax"
        Me.TextBox12itax.Size = New System.Drawing.Size(63, 22)
        Me.TextBox12itax.TabIndex = 56
        Me.TextBox12itax.Text = "0"
        '
        'CheckBox1egpen
        '
        Me.CheckBox1egpen.AutoSize = True
        Me.CheckBox1egpen.Checked = True
        Me.CheckBox1egpen.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1egpen.Location = New System.Drawing.Point(324, 499)
        Me.CheckBox1egpen.Name = "CheckBox1egpen"
        Me.CheckBox1egpen.Size = New System.Drawing.Size(156, 20)
        Me.CheckBox1egpen.TabIndex = 57
        Me.CheckBox1egpen.Text = "Eligible for Pen. Fund:"
        Me.CheckBox1egpen.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(195, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 16)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "%"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(195, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 16)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "%"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(195, 214)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 16)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "%"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(195, 264)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(18, 16)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "%"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(195, 239)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 16)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "%"
        '
        'TextBox13daamt
        '
        Me.TextBox13daamt.BackColor = System.Drawing.Color.AliceBlue
        Me.TextBox13daamt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox13daamt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox13daamt.Location = New System.Drawing.Point(234, 159)
        Me.TextBox13daamt.Name = "TextBox13daamt"
        Me.TextBox13daamt.Size = New System.Drawing.Size(69, 26)
        Me.TextBox13daamt.TabIndex = 63
        '
        'TextBox14hraamt
        '
        Me.TextBox14hraamt.BackColor = System.Drawing.Color.AliceBlue
        Me.TextBox14hraamt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox14hraamt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox14hraamt.Location = New System.Drawing.Point(234, 183)
        Me.TextBox14hraamt.Name = "TextBox14hraamt"
        Me.TextBox14hraamt.Size = New System.Drawing.Size(69, 26)
        Me.TextBox14hraamt.TabIndex = 64
        '
        'TextBox15ccaamt
        '
        Me.TextBox15ccaamt.BackColor = System.Drawing.Color.AliceBlue
        Me.TextBox15ccaamt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox15ccaamt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox15ccaamt.Location = New System.Drawing.Point(234, 209)
        Me.TextBox15ccaamt.Name = "TextBox15ccaamt"
        Me.TextBox15ccaamt.Size = New System.Drawing.Size(69, 26)
        Me.TextBox15ccaamt.TabIndex = 65
        '
        'TextBox16pfamt
        '
        Me.TextBox16pfamt.BackColor = System.Drawing.Color.AliceBlue
        Me.TextBox16pfamt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox16pfamt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox16pfamt.Location = New System.Drawing.Point(234, 233)
        Me.TextBox16pfamt.Name = "TextBox16pfamt"
        Me.TextBox16pfamt.Size = New System.Drawing.Size(69, 26)
        Me.TextBox16pfamt.TabIndex = 66
        '
        'TextBox17educeaseamt
        '
        Me.TextBox17educeaseamt.BackColor = System.Drawing.Color.AliceBlue
        Me.TextBox17educeaseamt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox17educeaseamt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox17educeaseamt.Location = New System.Drawing.Point(234, 257)
        Me.TextBox17educeaseamt.Name = "TextBox17educeaseamt"
        Me.TextBox17educeaseamt.Size = New System.Drawing.Size(69, 26)
        Me.TextBox17educeaseamt.TabIndex = 67
        Me.TextBox17educeaseamt.Text = "0"
        '
        'Button1save
        '
        Me.Button1save.BackColor = System.Drawing.Color.Gray
        Me.Button1save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1save.Location = New System.Drawing.Point(16, 517)
        Me.Button1save.Name = "Button1save"
        Me.Button1save.Size = New System.Drawing.Size(75, 23)
        Me.Button1save.TabIndex = 68
        Me.Button1save.Text = "SAVE"
        Me.Button1save.UseVisualStyleBackColor = False
        '
        'Button2close
        '
        Me.Button2close.BackColor = System.Drawing.Color.Gray
        Me.Button2close.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2close.Location = New System.Drawing.Point(238, 517)
        Me.Button2close.Name = "Button2close"
        Me.Button2close.Size = New System.Drawing.Size(75, 23)
        Me.Button2close.TabIndex = 69
        Me.Button2close.Text = "CLOSE"
        Me.Button2close.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TextBox3name)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(12, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(305, 29)
        Me.Panel1.TabIndex = 70
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.DarkGreen
        Me.DataGridView1.Location = New System.Drawing.Point(324, 63)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(888, 430)
        Me.DataGridView1.TabIndex = 71
        '
        'Button1upd
        '
        Me.Button1upd.BackColor = System.Drawing.Color.Gray
        Me.Button1upd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1upd.Location = New System.Drawing.Point(127, 517)
        Me.Button1upd.Name = "Button1upd"
        Me.Button1upd.Size = New System.Drawing.Size(86, 23)
        Me.Button1upd.TabIndex = 72
        Me.Button1upd.Text = "UPDATE"
        Me.Button1upd.UseVisualStyleBackColor = False
        '
        'TextBox1tds
        '
        Me.TextBox1tds.Location = New System.Drawing.Point(240, 351)
        Me.TextBox1tds.Name = "TextBox1tds"
        Me.TextBox1tds.Size = New System.Drawing.Size(63, 22)
        Me.TextBox1tds.TabIndex = 74
        Me.TextBox1tds.Text = "0"
        Me.TextBox1tds.Visible = False
        '
        'TextBox1grpins
        '
        Me.TextBox1grpins.Location = New System.Drawing.Point(134, 329)
        Me.TextBox1grpins.Name = "TextBox1grpins"
        Me.TextBox1grpins.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1grpins.TabIndex = 76
        Me.TextBox1grpins.Text = "0"
        '
        'TextBox1secdep
        '
        Me.TextBox1secdep.Location = New System.Drawing.Point(134, 353)
        Me.TextBox1secdep.Name = "TextBox1secdep"
        Me.TextBox1secdep.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1secdep.TabIndex = 78
        Me.TextBox1secdep.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(60, 384)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 16)
        Me.Label13.TabIndex = 79
        Me.Label13.Text = "Other Ded"
        '
        'TextBox1od1
        '
        Me.TextBox1od1.Location = New System.Drawing.Point(134, 377)
        Me.TextBox1od1.Name = "TextBox1od1"
        Me.TextBox1od1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1od1.TabIndex = 80
        Me.TextBox1od1.Text = "0"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Azure
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(324, 31)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(322, 22)
        Me.TextBox1.TabIndex = 81
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(27, 167)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 16)
        Me.Label14.TabIndex = 82
        Me.Label14.Text = "PROD. INCEIN."
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(1042, 29)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 83
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gray
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1169, 29)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(43, 23)
        Me.Button1.TabIndex = 84
        Me.Button1.Text = "GO"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(134, 426)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(100, 22)
        Me.txttotal.TabIndex = 86
        Me.txttotal.Text = "0"
        '
        'txtpfBasicOA
        '
        Me.txtpfBasicOA.BackColor = System.Drawing.Color.Azure
        Me.txtpfBasicOA.Location = New System.Drawing.Point(134, 133)
        Me.txtpfBasicOA.Name = "txtpfBasicOA"
        Me.txtpfBasicOA.Size = New System.Drawing.Size(100, 22)
        Me.txtpfBasicOA.TabIndex = 88
        '
        'txtProftax
        '
        Me.txtProftax.Location = New System.Drawing.Point(134, 402)
        Me.txtProftax.Name = "txtProftax"
        Me.txtProftax.Size = New System.Drawing.Size(100, 22)
        Me.txtProftax.TabIndex = 91
        Me.txtProftax.Text = "0"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(60, 409)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(58, 16)
        Me.Label18.TabIndex = 90
        Me.Label18.Text = "Prof Tax"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(652, 34)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(111, 16)
        Me.Label19.TabIndex = 92
        Me.Label19.Text = "Sreach by EmpId"
        '
        'txtEmpId
        '
        Me.txtEmpId.BackColor = System.Drawing.Color.Azure
        Me.txtEmpId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpId.Location = New System.Drawing.Point(769, 31)
        Me.txtEmpId.Name = "txtEmpId"
        Me.txtEmpId.Size = New System.Drawing.Size(152, 22)
        Me.txtEmpId.TabIndex = 93
        '
        'CheckBoxForEsi
        '
        Me.CheckBoxForEsi.AutoSize = True
        Me.CheckBoxForEsi.Location = New System.Drawing.Point(486, 499)
        Me.CheckBoxForEsi.Name = "CheckBoxForEsi"
        Me.CheckBoxForEsi.Size = New System.Drawing.Size(48, 20)
        Me.CheckBoxForEsi.TabIndex = 94
        Me.CheckBoxForEsi.Text = "ESI"
        Me.CheckBoxForEsi.UseVisualStyleBackColor = True
        '
        'frmempsalarystructure
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(1212, 572)
        Me.Controls.Add(Me.CheckBoxForEsi)
        Me.Controls.Add(Me.txtEmpId)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtProftax)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Label17)
        Me.Controls.Add(Me.txtpfBasicOA)
        Me.Controls.Add(Label16)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Label15)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox1od1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TextBox1secdep)
        Me.Controls.Add(Label12)
        Me.Controls.Add(Me.TextBox1grpins)
        Me.Controls.Add(Label11)
        Me.Controls.Add(Me.TextBox1tds)
        Me.Controls.Add(Label10)
        Me.Controls.Add(Me.Button1upd)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2close)
        Me.Controls.Add(Me.Button1save)
        Me.Controls.Add(Me.TextBox17educeaseamt)
        Me.Controls.Add(Me.TextBox16pfamt)
        Me.Controls.Add(Me.TextBox15ccaamt)
        Me.Controls.Add(Me.TextBox14hraamt)
        Me.Controls.Add(Me.TextBox13daamt)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CheckBox1egpen)
        Me.Controls.Add(Me.TextBox12itax)
        Me.Controls.Add(Me.TextBox11oa2)
        Me.Controls.Add(Me.TextBox10oa1)
        Me.Controls.Add(Me.TextBox9educease)
        Me.Controls.Add(Me.TextBox8epf)
        Me.Controls.Add(Me.TextBox7cca)
        Me.Controls.Add(Me.TextBox6hra)
        Me.Controls.Add(Me.TextBox5da)
        Me.Controls.Add(Me.TextBox4basic)
        Me.Controls.Add(Me.TextBox2eid)
        Me.Controls.Add(Me.TextBox1orgid)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(edc_csLabel)
        Me.Controls.Add(basicLabel)
        Me.Controls.Add(hraLabel)
        Me.Controls.Add(ccaLabelfieall)
        Me.Controls.Add(epfLabel)
        Me.Controls.Add(Me.oa1Label)
        Me.Controls.Add(oa2Label)
        Me.Controls.Add(i_taxLabel)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmempsalarystructure"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmempsalary"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox1orgid As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2eid As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3name As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4basic As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5da As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6hra As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7cca As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8epf As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9educease As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10oa1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11oa2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12itax As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1egpen As System.Windows.Forms.CheckBox
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox13daamt As System.Windows.Forms.TextBox
    Friend WithEvents TextBox14hraamt As System.Windows.Forms.TextBox
    Friend WithEvents TextBox15ccaamt As System.Windows.Forms.TextBox
    Friend WithEvents TextBox16pfamt As System.Windows.Forms.TextBox
    Friend WithEvents TextBox17educeaseamt As System.Windows.Forms.TextBox
    Friend WithEvents Button1save As System.Windows.Forms.Button
    Friend WithEvents Button2close As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1upd As System.Windows.Forms.Button
    Friend WithEvents TextBox1tds As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1grpins As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1secdep As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox1od1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents oa1Label As System.Windows.Forms.Label
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents txtpfBasicOA As System.Windows.Forms.TextBox
    Friend WithEvents txtProftax As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtEmpId As System.Windows.Forms.TextBox
    Friend WithEvents CheckBoxForEsi As System.Windows.Forms.CheckBox
End Class
