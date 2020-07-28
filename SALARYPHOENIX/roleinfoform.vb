Imports System.Data.Sql
Imports System.Collections.Generic
imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Data.SqlClient
Public Class roleinfoform
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Public Sub roleinfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListBox2.Items.Clear()
        roleTextBox1.Enabled = False
        ComboBox1.Enabled = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelButton4.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addselButton5.Click
        Try
            ListBox1.Items.Add(ListBox2.SelectedItem)
            ListBox2.Items.RemoveAt(ListBox2.SelectedIndex)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles removeButton9.Click
        Try
            ListBox2.Items.Add(ListBox1.SelectedItem)
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addallButton7.Click
        Try

            Dim i As Integer = 0
            For i = 0 To ListBox2.Items.Count - 1
                ListBox1.Items.Add(ListBox2.Items(i))
            Next
            ListBox2.Items.Clear()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles remallButton8.Click
        Try
            Dim i As Integer = 0
            For i = 0 To ListBox1.Items.Count - 1
                ListBox2.Items.Add(ListBox1.Items(i))
            Next
            ListBox1.Items.Clear()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles remselButton6.Click
        Try
            ListBox2.Items.Add(ListBox1.SelectedItem)
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub saveButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saveButton1.Click
        Dim sql, s As String
        Dim i As Integer = 0
        Dim j As Integer = 0
        j = ListBox1.Items.Count
        Do While (i < j)
            sql = "insert into ROLE select '" & roleTextBox1.Text & "',module_name from module where menu_name='" _
            & ListBox1.Items(i) & "'"
            'messagebox.show(sql)
            s = globalmod.SqlExecuteNonQuery(sql)
            messagebox.show(s)
            i = i + 1
        Loop
        MessageBox.Show("1 row updated")
        'conn.Close()
        roleTextBox1.Clear()
        addroleButton1_Click(sender, e)
    End Sub

    Private Sub AddButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton1.Click

        Try
            ListBox1.Items.Add(ListBox2.SelectedItem)
            ListBox2.Items.RemoveAt(ListBox2.SelectedIndex)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub deleteButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteButton2.Click
        Dim sql, s As String
        sql = "delete from role where role_name='" & ComboBox1.Text & "'"
        s = globalmod.SqlExecuteNonQuery(sql)
        MessageBox.Show(s)
        ComboBox1.Text = ""
        editroleButton2_Click(sender, e)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        Dim sql As String
        sql = "select distinct modulename from role where role_name='" & ComboBox1.Text & "'"
        Dim i As Integer = 0
        Dim j As Integer
        globalmod.DataSetRet(sql, "role1")
        j = ds.Tables("role1").Rows.Count
        Do While (i < j)
            ListBox1.Items.Add(ds.Tables("role1").Rows(i)(0).ToString())
            i = i + 1
        Loop
        ListBox2.Items.Clear()
        sql = "select m1.module_name from dbo.MODULE m1  where not exists " & _
            "(select modulename from role r where m1.module_name=r.modulename " & _
         " and role_name='" & ComboBox1.Text & "')"
        globalmod.DataSetRet(sql, "remrole1")
        For i = 0 To ds.Tables("remRole1").Rows.Count - 1
            ListBox2.Items.Add(ds.Tables("remRole1").Rows(i)(0).ToString())
        Next

    End Sub

    Private Sub addroleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addroleButton1.Click
        roleTextBox1.Enabled = True
        roleTextBox1.Focus()
        ComboBox1.Enabled = False
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        Dim sql As String
        sql = "select menu_name from module"
        globalmod.DataSetRet(sql, "module1")
        Dim i As Integer = 0
        Dim j As Integer
        Try
            'ListBox2.DataSource = ds.Tables("module")
            'ListBox2.DisplayMember = "module_name"
            j = ds.Tables("module1").Rows.Count
            Do While (i < j)
                ListBox2.Items.Add(ds.Tables("module1").Rows(i)(0).ToString())
                'messagebox.show(ds.Tables("module1").Rows(i)(0).ToString())
                i = i + 1
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub editroleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editroleButton2.Click
        ComboBox1.Items.Clear()
        roleTextBox1.Text = ""
        roleTextBox1.Enabled = False
        ComboBox1.Enabled = True
        Dim sql As String
        sql = "select distinct role_name from role"

        globalmod.DataSetRet(sql, "role")
        Dim i As Integer = 0
        Dim j As Integer
        Try
            j = ds.Tables("role").Rows.Count
            Do While (i < j)
                ComboBox1.Items.Add(ds.Tables("role").Rows(i)(0).ToString())
                i = i + 1
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub updateButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updateButton1.Click
        Dim sql As String
        Dim i As Integer = 0
        Dim j As Integer = 0

        sql = "delete from ROLE where role_name ='" & ComboBox1.Text & "'"
        j = ListBox1.Items.Count
        globalmod.SqlExecuteNonQuery(sql)
        Do While (i < j)
            sql = "insert into ROLE values('" & ComboBox1.Text & "','" & ListBox1.Items(i) & "')"

            globalmod.SqlExecuteNonQuery(sql)
            i = i + 1
        Loop
        MessageBox.Show(" row updated")
        'conn.Close()
        roleTextBox1.Clear()
        editroleButton2_Click(sender, e)
    End Sub


End Class
