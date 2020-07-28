Imports System.Data.Sql
Imports System.Collections.Generic
imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class Userinfofrm
    Private Sub clearButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton2.Click
        unameTextBox1.Text = ""
        uidTextBox2.Text = ""
        passTextBox3.Text = ""
        repassTextBox4.Text = ""
        'statusTextBox5.Text = ""
        roleComboBox1.Text = "select one"

    End Sub

    Private Sub saveButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saveButton1.Click

        Try
            'Dim conn As New SqlConnection
            'conn.ConnectionString = ("Data Source=PHXRPT;Initial Catalog=logindata;Integrated Security=True;Pooling=False")
            Dim sql, s As String
            'conn.Open()
            sql = "insert into user_info values('" & uidTextBox2.Text _
            & "','" & passTextBox3.Text & "','" & unameTextBox1.Text & "','" _
            & CheckBoxstatus.CheckState & "','" & roleComboBox1.Text _
            & "','" & cmborg.Text & "')"
            'Dim cmd As New SqlCommand(sql, conn)
            'cmd.ExecuteNonQuery()
            'conn.Close()
            s = globalmod.SqlExecuteNonQuery(sql)
            MessageBox.Show(s)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
        uidTextBox2.Text = ""
        passTextBox3.Text = ""
        unameTextBox1.Text = ""
        repassTextBox4.Text = ""
        roleComboBox1.Text = "select one"

    End Sub

    Private Sub Userinfofrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim conn As New SqlConnection
        'conn.ConnectionString = ("Data Source=PHXRPT;Initial Catalog=logindata;Integrated Security=True;Pooling=False")
        Dim sql As String
        sql = "select distinct role_name from role"
        'Dim cmd As New SqlCommand(sql, conn)
        'cmd.ExecuteNonQuery()
        'Dim da As New SqlDataAdapter(sql, conn)
        'Dim ds As New DataSet
        'da.Fill(ds, "role")
        globalmod.DataSetRet(sql, "role")
        Dim i As Integer = 0
        Dim j As Integer
        Try
            j = ds.Tables("role").Rows.Count
            Do While (i < j)
                roleComboBox1.Items.Add(ds.Tables("role").Rows(i)(0).ToString())
                edtroleComboBox1.Items.Add(ds.Tables("role").Rows(i)(0).ToString())
                i = i + 1
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
        Panel2.Visible = False
        Panel4.Visible = False


        sql = "select orgid from organizationmaster"
        globalmod.DataSetRet(sql, "orin")
        cmborg.DataSource = ds.Tables("orin")
        cmborg.DisplayMember = "orgid"

        cmbuporg.DataSource = ds.Tables("orin")
        cmbuporg.DisplayMember = "orgid"


    End Sub

    Private Sub roleComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles roleComboBox1.SelectedIndexChanged


    End Sub

    Private Sub repassTextBox4_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles repassTextBox4.LostFocus
        If passTextBox3.Text = repassTextBox4.Text Then
            roleComboBox1.Focus()
        Else
            MessageBox.Show("password & retype pasword must be same", "check the password", MessageBoxButtons.OK, MessageBoxIcon.Error)
            passTextBox3.Focus()
        End If
    End Sub

    Private Sub repassTextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles repassTextBox4.TextChanged

    End Sub



    Private Sub creatButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles creatButton4.Click
        roleComboBox1.Text = "select one"
        uidComboBox1.Text = "select one"
        edtroleComboBox1.Text = "select one"
        Panel1.Enabled = True
        Panel3.Enabled = False
        Panel2.Visible = True
        Panel4.Visible = False
        edunameTextBox4.Text = ""
        edtpassTextBox3.Text = ""
        edtcpassTextBox2.Text = ""

        edtroleComboBox1.Text = "select one"
        roleLabel14.Text = ""
    End Sub


    Private Sub editButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editButton5.Click
        edtroleComboBox1.Text = "select one"
        roleComboBox1.Text = "select one"
        unameTextBox1.Text = ""
        uidTextBox2.Text = ""
        passTextBox3.Text = ""
        repassTextBox4.Text = ""
        'statusTextBox5.Text = ""
        Panel1.Enabled = False
        Panel3.Enabled = True
        Panel2.Visible = False
        Panel4.Visible = True
        Panel4.Enabled = True
        uidComboBox1.Items.Clear()
        'Dim conn As New SqlConnection
        'conn.ConnectionString = ("Data Source=PHXRPT;Initial Catalog=logindata;Integrated Security=True;Pooling=False")
        Dim sql As String
        sql = "select user_id from user_info"
        'Dim cmd As New SqlCommand(sql, conn)
        'cmd.ExecuteNonQuery()
        'Dim da As New SqlDataAdapter(sql, conn)
        'Dim ds As New DataSet
        'da.Fill(ds, "user_info")
        globalmod.DataSetRet(sql, "user_info")
        Dim i As Integer = 0
        Dim j As Integer
        Try
            j = ds.Tables("user_info").Rows.Count
            Do While (i < j)
                uidComboBox1.Items.Add(ds.Tables("user_info").Rows(i)(0).ToString())
                i = i + 1
            Loop
        Catch ex As Exception
        End Try


    End Sub


    Private Sub uidComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uidComboBox1.SelectedIndexChanged
        'Dim conn As New SqlConnection
        'conn.ConnectionString = ("Data Source=PHXRPT;Initial Catalog=logindata;Integrated Security=True;Pooling=False")
        Dim sql As String
        sql = "select * from user_info where user_id ='" & uidComboBox1.Text & "'"
        'Dim cmd As New SqlCommand(sql, conn)
        'Dim da As New SqlDataAdapter(sql, conn)
        'Dim ds As New DataSet
        'da.Fill(ds, "user_info")
        globalmod.DataSetRet(sql, "user_info1")
        edunameTextBox4.Text = ds.Tables("user_info1").Rows(0)(2).ToString()
        edtpassTextBox3.Text = ds.Tables("user_info1").Rows(0)(1).ToString()
        'edtcpassTextBox2.Text = ds.Tables("user_info").Rows(0)(2).ToString()
        TextBoxolstatus.Text = ds.Tables("user_info1").Rows(0)(3).ToString()
        TextBoxrole.Text = ds.Tables("user_info1").Rows(0)(4).ToString()
    End Sub


    Private Sub updateButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updateButton2.Click

        If edtroleComboBox1.Text = "select one" Then
            MessageBox.Show(MessageBox.Show("Plese Select a role name ", "check", MessageBoxButtons.OK, MessageBoxIcon.Error))
            Exit Sub
        End If
        Dim sql, s As String
        sql = "update user_info set u_name='" & edunameTextBox4.Text _
        & "', password ='" & edtpassTextBox3.Text & "', status ='" _
        & CheckBox1.CheckState & "',role = '" & edtroleComboBox1.Text _
        & "',org='" & cmbuporg.Text _
        & "' where user_id ='" & uidComboBox1.Text & "'"
        s = globalmod.SqlExecuteNonQuery(sql)
        MessageBox.Show(s)

    End Sub

    Private Sub clearButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton3.Click
        edunameTextBox4.Text = ""
        edtpassTextBox3.Text = ""
        edtcpassTextBox2.Text = ""
        edtroleComboBox1.Text = "select one"
    End Sub

    Private Sub cancelButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelButton1.Click
        Me.Close()
    End Sub

    Private Sub delButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delButton1.Click

        'Dim conn As New SqlConnection
        'conn.ConnectionString = ("Data Source=PHXRPT;Initial Catalog=logindata;Integrated Security=True;Pooling=False")
        Dim sql As String
        sql = "delete from user_info where user_id ='" & uidComboBox1.Text & "'"
        'Dim cmd As New SqlCommand(sql, conn)
        'Dim da As New SqlDataAdapter(sql, conn)
        'conn.Open()
        'cmd.ExecuteNonQuery()
        'conn.Close()
        globalmod.SqlExecuteNonQuery(sql)
        editButton5_Click(sender, e)
        uidComboBox1.Text = "selct one"
    End Sub

    Private Sub edtcpassTextBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles edtcpassTextBox2.LostFocus
        If edtcpassTextBox2.Text = edtpassTextBox3.Text Then
            edtroleComboBox1.Focus()
        Else
            MessageBox.Show("password & retype pasword must be same", "check the password", MessageBoxButtons.OK, MessageBoxIcon.Error)
            edtcpassTextBox2.Focus()

        End If
    End Sub

    Private Sub cancelButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelButton3.Click
        Me.Close()
    End Sub
End Class