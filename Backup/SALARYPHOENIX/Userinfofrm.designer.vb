<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Userinfofrm
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmborg = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.CheckBoxstatus = New System.Windows.Forms.CheckBox
        Me.roleComboBox1 = New System.Windows.Forms.ComboBox
        Me.repassTextBox4 = New System.Windows.Forms.TextBox
        Me.passTextBox3 = New System.Windows.Forms.TextBox
        Me.uidTextBox2 = New System.Windows.Forms.TextBox
        Me.unameTextBox1 = New System.Windows.Forms.TextBox
        Me.saveButton1 = New System.Windows.Forms.Button
        Me.clearButton2 = New System.Windows.Forms.Button
        Me.cancelButton3 = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.delButton1 = New System.Windows.Forms.Button
        Me.cancelButton1 = New System.Windows.Forms.Button
        Me.updateButton2 = New System.Windows.Forms.Button
        Me.clearButton3 = New System.Windows.Forms.Button
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.cmbuporg = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.TextBoxrole = New System.Windows.Forms.TextBox
        Me.TextBoxolstatus = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.newroleLabel14 = New System.Windows.Forms.Label
        Me.edtroleComboBox1 = New System.Windows.Forms.ComboBox
        Me.roleLabel14 = New System.Windows.Forms.Label
        Me.uidComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.edtcpassTextBox2 = New System.Windows.Forms.TextBox
        Me.edtpassTextBox3 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.edunameTextBox4 = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.creatButton4 = New System.Windows.Forms.Button
        Me.editButton5 = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(995, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = " User Creation Form"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter User Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Enter user id "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Confirm Password"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Role Name"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cmborg)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.CheckBoxstatus)
        Me.Panel1.Controls.Add(Me.roleComboBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.repassTextBox4)
        Me.Panel1.Controls.Add(Me.passTextBox3)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.uidTextBox2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.unameTextBox1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(8, 73)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(551, 233)
        Me.Panel1.TabIndex = 7
        '
        'cmborg
        '
        Me.cmborg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmborg.FormattingEnabled = True
        Me.cmborg.Location = New System.Drawing.Point(126, 135)
        Me.cmborg.Name = "cmborg"
        Me.cmborg.Size = New System.Drawing.Size(420, 24)
        Me.cmborg.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 138)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 16)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "For Organization"
        '
        'CheckBoxstatus
        '
        Me.CheckBoxstatus.AutoSize = True
        Me.CheckBoxstatus.Location = New System.Drawing.Point(12, 195)
        Me.CheckBoxstatus.Name = "CheckBoxstatus"
        Me.CheckBoxstatus.Size = New System.Drawing.Size(65, 20)
        Me.CheckBoxstatus.TabIndex = 14
        Me.CheckBoxstatus.Text = "Status"
        Me.CheckBoxstatus.UseVisualStyleBackColor = True
        '
        'roleComboBox1
        '
        Me.roleComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.roleComboBox1.FormattingEnabled = True
        Me.roleComboBox1.Location = New System.Drawing.Point(126, 107)
        Me.roleComboBox1.Name = "roleComboBox1"
        Me.roleComboBox1.Size = New System.Drawing.Size(127, 24)
        Me.roleComboBox1.TabIndex = 13
        '
        'repassTextBox4
        '
        Me.repassTextBox4.Location = New System.Drawing.Point(126, 82)
        Me.repassTextBox4.Name = "repassTextBox4"
        Me.repassTextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.repassTextBox4.Size = New System.Drawing.Size(127, 22)
        Me.repassTextBox4.TabIndex = 11
        '
        'passTextBox3
        '
        Me.passTextBox3.Location = New System.Drawing.Point(126, 56)
        Me.passTextBox3.Name = "passTextBox3"
        Me.passTextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passTextBox3.Size = New System.Drawing.Size(127, 22)
        Me.passTextBox3.TabIndex = 10
        '
        'uidTextBox2
        '
        Me.uidTextBox2.Location = New System.Drawing.Point(126, 32)
        Me.uidTextBox2.Name = "uidTextBox2"
        Me.uidTextBox2.Size = New System.Drawing.Size(127, 22)
        Me.uidTextBox2.TabIndex = 9
        '
        'unameTextBox1
        '
        Me.unameTextBox1.Location = New System.Drawing.Point(126, 6)
        Me.unameTextBox1.Name = "unameTextBox1"
        Me.unameTextBox1.Size = New System.Drawing.Size(127, 22)
        Me.unameTextBox1.TabIndex = 8
        '
        'saveButton1
        '
        Me.saveButton1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveButton1.Location = New System.Drawing.Point(29, 15)
        Me.saveButton1.Name = "saveButton1"
        Me.saveButton1.Size = New System.Drawing.Size(82, 22)
        Me.saveButton1.TabIndex = 8
        Me.saveButton1.Text = "Create User"
        Me.saveButton1.UseVisualStyleBackColor = True
        '
        'clearButton2
        '
        Me.clearButton2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton2.Location = New System.Drawing.Point(198, 15)
        Me.clearButton2.Name = "clearButton2"
        Me.clearButton2.Size = New System.Drawing.Size(66, 22)
        Me.clearButton2.TabIndex = 9
        Me.clearButton2.Text = "Clear"
        Me.clearButton2.UseVisualStyleBackColor = True
        '
        'cancelButton3
        '
        Me.cancelButton3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelButton3.Location = New System.Drawing.Point(351, 15)
        Me.cancelButton3.Name = "cancelButton3"
        Me.cancelButton3.Size = New System.Drawing.Size(66, 22)
        Me.cancelButton3.TabIndex = 10
        Me.cancelButton3.Text = "Cancel"
        Me.cancelButton3.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.cancelButton3)
        Me.Panel2.Controls.Add(Me.saveButton1)
        Me.Panel2.Controls.Add(Me.clearButton2)
        Me.Panel2.Location = New System.Drawing.Point(24, 329)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(548, 59)
        Me.Panel2.TabIndex = 11
        Me.Panel2.Visible = False
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.delButton1)
        Me.Panel4.Controls.Add(Me.cancelButton1)
        Me.Panel4.Controls.Add(Me.updateButton2)
        Me.Panel4.Controls.Add(Me.clearButton3)
        Me.Panel4.Location = New System.Drawing.Point(9, 329)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(565, 58)
        Me.Panel4.TabIndex = 13
        '
        'delButton1
        '
        Me.delButton1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delButton1.Location = New System.Drawing.Point(186, 18)
        Me.delButton1.Name = "delButton1"
        Me.delButton1.Size = New System.Drawing.Size(66, 22)
        Me.delButton1.TabIndex = 11
        Me.delButton1.Text = "Delete"
        Me.delButton1.UseVisualStyleBackColor = True
        '
        'cancelButton1
        '
        Me.cancelButton1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelButton1.Location = New System.Drawing.Point(470, 18)
        Me.cancelButton1.Name = "cancelButton1"
        Me.cancelButton1.Size = New System.Drawing.Size(66, 22)
        Me.cancelButton1.TabIndex = 10
        Me.cancelButton1.Text = "Cancel"
        Me.cancelButton1.UseVisualStyleBackColor = True
        '
        'updateButton2
        '
        Me.updateButton2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateButton2.Location = New System.Drawing.Point(28, 18)
        Me.updateButton2.Name = "updateButton2"
        Me.updateButton2.Size = New System.Drawing.Size(82, 22)
        Me.updateButton2.TabIndex = 8
        Me.updateButton2.Text = "Update"
        Me.updateButton2.UseVisualStyleBackColor = True
        '
        'clearButton3
        '
        Me.clearButton3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton3.Location = New System.Drawing.Point(328, 18)
        Me.clearButton3.Name = "clearButton3"
        Me.clearButton3.Size = New System.Drawing.Size(66, 22)
        Me.clearButton3.TabIndex = 9
        Me.clearButton3.Text = "Clear"
        Me.clearButton3.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.cmbuporg)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.TextBoxrole)
        Me.Panel3.Controls.Add(Me.TextBoxolstatus)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.CheckBox1)
        Me.Panel3.Controls.Add(Me.newroleLabel14)
        Me.Panel3.Controls.Add(Me.edtroleComboBox1)
        Me.Panel3.Controls.Add(Me.roleLabel14)
        Me.Panel3.Controls.Add(Me.uidComboBox1)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.edtcpassTextBox2)
        Me.Panel3.Controls.Add(Me.edtpassTextBox3)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.edunameTextBox4)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Enabled = False
        Me.Panel3.Location = New System.Drawing.Point(565, 73)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(422, 233)
        Me.Panel3.TabIndex = 12
        '
        'cmbuporg
        '
        Me.cmbuporg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbuporg.FormattingEnabled = True
        Me.cmbuporg.Location = New System.Drawing.Point(147, 185)
        Me.cmbuporg.Name = "cmbuporg"
        Me.cmbuporg.Size = New System.Drawing.Size(270, 24)
        Me.cmbuporg.TabIndex = 22
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(3, 188)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(104, 16)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "For Organization"
        '
        'TextBoxrole
        '
        Me.TextBoxrole.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBoxrole.Location = New System.Drawing.Point(147, 109)
        Me.TextBoxrole.Name = "TextBoxrole"
        Me.TextBoxrole.ReadOnly = True
        Me.TextBoxrole.Size = New System.Drawing.Size(124, 22)
        Me.TextBoxrole.TabIndex = 20
        '
        'TextBoxolstatus
        '
        Me.TextBoxolstatus.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBoxolstatus.Location = New System.Drawing.Point(147, 157)
        Me.TextBoxolstatus.Name = "TextBoxolstatus"
        Me.TextBoxolstatus.ReadOnly = True
        Me.TextBoxolstatus.Size = New System.Drawing.Size(124, 22)
        Me.TextBoxolstatus.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 16)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Old Status"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(6, 212)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(118, 20)
        Me.CheckBox1.TabIndex = 17
        Me.CheckBox1.Text = "Set New Status"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'newroleLabel14
        '
        Me.newroleLabel14.AutoSize = True
        Me.newroleLabel14.Location = New System.Drawing.Point(3, 135)
        Me.newroleLabel14.Name = "newroleLabel14"
        Me.newroleLabel14.Size = New System.Drawing.Size(142, 16)
        Me.newroleLabel14.TabIndex = 16
        Me.newroleLabel14.Text = "Select New Role Name"
        '
        'edtroleComboBox1
        '
        Me.edtroleComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.edtroleComboBox1.FormattingEnabled = True
        Me.edtroleComboBox1.Location = New System.Drawing.Point(147, 132)
        Me.edtroleComboBox1.Name = "edtroleComboBox1"
        Me.edtroleComboBox1.Size = New System.Drawing.Size(124, 24)
        Me.edtroleComboBox1.TabIndex = 15
        '
        'roleLabel14
        '
        Me.roleLabel14.AutoSize = True
        Me.roleLabel14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.roleLabel14.Location = New System.Drawing.Point(129, 107)
        Me.roleLabel14.Name = "roleLabel14"
        Me.roleLabel14.Size = New System.Drawing.Size(2, 18)
        Me.roleLabel14.TabIndex = 14
        '
        'uidComboBox1
        '
        Me.uidComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.uidComboBox1.FormattingEnabled = True
        Me.uidComboBox1.Location = New System.Drawing.Point(147, 13)
        Me.uidComboBox1.Name = "uidComboBox1"
        Me.uidComboBox1.Size = New System.Drawing.Size(124, 24)
        Me.uidComboBox1.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 16)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Select User Id"
        '
        'edtcpassTextBox2
        '
        Me.edtcpassTextBox2.Location = New System.Drawing.Point(147, 85)
        Me.edtcpassTextBox2.Name = "edtcpassTextBox2"
        Me.edtcpassTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.edtcpassTextBox2.Size = New System.Drawing.Size(124, 22)
        Me.edtcpassTextBox2.TabIndex = 11
        '
        'edtpassTextBox3
        '
        Me.edtpassTextBox3.Location = New System.Drawing.Point(147, 61)
        Me.edtpassTextBox3.Name = "edtpassTextBox3"
        Me.edtpassTextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.edtpassTextBox3.Size = New System.Drawing.Size(124, 22)
        Me.edtpassTextBox3.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 34)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 16)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "User Name "
        '
        'edunameTextBox4
        '
        Me.edunameTextBox4.Location = New System.Drawing.Point(147, 38)
        Me.edunameTextBox4.Name = "edunameTextBox4"
        Me.edunameTextBox4.Size = New System.Drawing.Size(124, 22)
        Me.edunameTextBox4.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 110)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 16)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "AllotedRole"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 59)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 16)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Password"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 85)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(113, 16)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Confirm Password"
        '
        'creatButton4
        '
        Me.creatButton4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.creatButton4.Location = New System.Drawing.Point(35, 46)
        Me.creatButton4.Name = "creatButton4"
        Me.creatButton4.Size = New System.Drawing.Size(66, 22)
        Me.creatButton4.TabIndex = 13
        Me.creatButton4.Text = "Create"
        Me.creatButton4.UseVisualStyleBackColor = True
        '
        'editButton5
        '
        Me.editButton5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editButton5.Location = New System.Drawing.Point(563, 46)
        Me.editButton5.Name = "editButton5"
        Me.editButton5.Size = New System.Drawing.Size(66, 22)
        Me.editButton5.TabIndex = 14
        Me.editButton5.Text = "Edit"
        Me.editButton5.UseVisualStyleBackColor = True
        '
        'Userinfofrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(995, 400)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.editButton5)
        Me.Controls.Add(Me.creatButton4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Userinfofrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents roleComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents repassTextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents passTextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents uidTextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents unameTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents saveButton1 As System.Windows.Forms.Button
    Friend WithEvents clearButton2 As System.Windows.Forms.Button
    Friend WithEvents cancelButton3 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents uidComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents edtcpassTextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents edtpassTextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents cancelButton1 As System.Windows.Forms.Button
    Friend WithEvents updateButton2 As System.Windows.Forms.Button
    Friend WithEvents clearButton3 As System.Windows.Forms.Button
    Friend WithEvents creatButton4 As System.Windows.Forms.Button
    Friend WithEvents editButton5 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents edunameTextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents delButton1 As System.Windows.Forms.Button
    Friend WithEvents edtroleComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents roleLabel14 As System.Windows.Forms.Label
    Friend WithEvents newroleLabel14 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxstatus As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBoxrole As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxolstatus As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmborg As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbuporg As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
