Imports System.IO
Imports System.Data.SqlClient
Imports System.Data
Public Class frmdepartment
    Dim ConstrAcc As String
    Private Sub frmdepartment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String
        sql = "select orgid from organizationmaster where orgid='" & globalmod.organization & "' "
        globalmod.DataSetRet(sql, "oid")
        ComboBox1.DataSource = ds.Tables("oid")
        ComboBox1.DisplayMember = "orgid"
        fillgrid()
        
        ConstrAcc = "Data Source=PHXSERVER;Initial Catalog =PhxGroupERP;user id =sa;password = ph@hoenix#g"
        fillHedas()
    End Sub
    Public Sub fillHedas()
        Dim dsHead As New DataSet
        If globalmod.organization = "Phoenix Hatcheries" Then

            Dim da As New SqlDataAdapter("select * from Acc_head_phha_1617 where group_name not in('Party','Customer','Bank') ", ConstrAcc)
            da.Fill(dsHead, "heads")
            da.Fill(dsHead, "cpfheads")
            cmbSalaryHead.DataSource = dsHead.Tables("heads")
            cmbSalaryHead.DisplayMember = "account_head_name"
            cmbsalCode.DataSource = dsHead.Tables("heads")
            cmbsalCode.DisplayMember = "account_code"


            cmbCPFHead.DataSource = dsHead.Tables("cpfheads")
            cmbCPFHead.DisplayMember = "account_head_name"
            cmbcpfCode.DataSource = dsHead.Tables("cpfheads")
            cmbcpfCode.DisplayMember = "account_code"
        ElseIf globalmod.organization = "PRIMARY HEALTH CARE" Then
            Dim da As New SqlDataAdapter("select * from Acc_head_prhe_1819 where group_name not in('Party','Customer','Bank') ", ConstrAcc)
            da.Fill(dsHead, "heads")
            da.Fill(dsHead, "cpfheads")
            cmbSalaryHead.DataSource = dsHead.Tables("heads")
            cmbSalaryHead.DisplayMember = "account_head_name"
            cmbsalCode.DataSource = dsHead.Tables("heads")
            cmbsalCode.DisplayMember = "account_code"

            cmbCPFHead.DataSource = dsHead.Tables("cpfheads")
            cmbCPFHead.DisplayMember = "account_head_name"
            cmbcpfCode.DataSource = dsHead.Tables("cpfheads")
            cmbcpfCode.DisplayMember = "account_code"
        Else
            Dim da As New SqlDataAdapter("select * from Acc_head_phoe_1819 where group_name not in('Party','Customer','Bank') ", ConstrAcc)
            da.Fill(dsHead, "heads")
            da.Fill(dsHead, "cpfheads")
            cmbSalaryHead.DataSource = dsHead.Tables("heads")
            cmbSalaryHead.DisplayMember = "account_head_name"
            cmbsalCode.DataSource = dsHead.Tables("heads")
            cmbsalCode.DisplayMember = "account_code"

            cmbCPFHead.DataSource = dsHead.Tables("cpfheads")
            cmbCPFHead.DisplayMember = "account_head_name"
            cmbcpfCode.DataSource = dsHead.Tables("cpfheads")
            cmbcpfCode.DisplayMember = "account_code"
        End If
    End Sub
    Public Sub fillgrid()
        Dim sql As String
        sql = "select * from department where orgid='" & globalmod.organization & "' order by depid "
        globalmod.DataSetRet(sql, "dep")
        DataGridView1.DataSource = ds.Tables("dep")
    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick

    End Sub

    Private Sub Button4close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4close.Click
        Me.Close()
    End Sub

    Private Sub Button3del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3del.Click
        Dim sql As String
        sql = "delete from department where orgid='" & organization _
        & "' and depid='" & TextBox1.Text & "'"
        globalmod.SqlExecuteNonQuery(sql)
        fillgrid()
    End Sub

    Private Sub Button2upd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2upd.Click
        Dim sql As String
        sql = " update department set department='" & TextBox2.Text & "',salcode ='" & cmbsalCode.Text & "',cpfcode='" & cmbcpfCode.Text & "',salhead ='" & cmbSalaryHead.Text & "',cpfhead='" & cmbCPFHead.Text & "' " _
        & " where orgid='" & organization _
        & "' and depid='" & TextBox1.Text & "'"
        globalmod.SqlExecuteNonQuery(sql)
        fillgrid()
        MessageBox.Show("Data updated...")
    End Sub

    Private Sub Button1save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1save.Click
        Dim sql As String
        sql = "insert into department(orgid, depid, department, salcode, cpfcode, salhead, cpfhead) values('" & ComboBox1.Text _
        & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & cmbsalCode.Text & "','" & cmbcpfCode.Text & "','" & cmbSalaryHead.Text & "','" & cmbCPFHead.Text & "')"
        globalmod.SqlExecuteNonQuery(sql)
        fillgrid()
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        Try

            ComboBox1.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value
            TextBox1.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(1).Value
            TextBox2.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(2).Value
            cmbsalCode.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(3).Value
            cmbcpfCode.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(4).Value
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class