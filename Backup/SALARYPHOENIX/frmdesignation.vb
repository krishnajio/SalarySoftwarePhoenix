Public Class frmdesignation

    Private Sub frmdesignation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillgrid()
        Dim sql As String
        sql = "select orgid from organizationmaster"
        globalmod.DataSetRet(sql, "org")
        ComboBox1orgid.DataSource = ds.Tables("org")
        ComboBox1orgid.DisplayMember = "orgid"



    End Sub
    Private Sub fillgrid()
        Dim sql As String
        sql = "select * from designationmaster"
        globalmod.DataSetRet(sql, "desi")
        DataGridView1.DataSource = ds.Tables("desi")
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub ComboBox1orgid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1orgid.SelectedIndexChanged
        Dim sql As String
        sql = "select depid from department where orgid='" & organization & "'"
        globalmod.DataSetRet(sql, "depid")
        ComboBox2depid.DataSource = ds.Tables("depid")
        ComboBox2depid.DisplayMember = "depid"

    End Sub



    Private Sub Button4close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4close.Click
        Me.Close()

    End Sub

    Private Sub Button1save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1save.Click
        Dim sql As String
        sql = "insert into designationmaster values('" _
        & ComboBox1orgid.Text & "','" _
        & TextBox1des.Text & "','" _
        & ComboBox2depid.Text & "','" _
        & TextBox2ordno.Text & "','" _
        & TextBox3cat.Text & "','" _
        & TextBox4scale.Text & "','sachin')"
        globalmod.SqlExecuteNonQuery(sql)
        fillgrid()
    End Sub

    Private Sub Button2upd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2upd.Click
        Dim sql As String
        sql = "update designationmaster set orderno='" & TextBox2ordno.Text _
        & "',category='" & TextBox3cat.Text & "', scale='" & TextBox4scale.Text _
        & "',userid='sachin' where orgid='" & organization _
        & "' and designation='" & TextBox1des.Text & "' and department='" _
        & ComboBox2depid.Text & "'"
        globalmod.SqlExecuteNonQuery(sql)
        fillgrid()
    End Sub

    Private Sub Button3del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3del.Click
        Dim sql As String
        sql = "delete from designationmaster where orgid='" & organization _
        & "' and designation='" & TextBox1des.Text & "' and department='" _
        & ComboBox2depid.Text & "'"
        globalmod.SqlExecuteNonQuery(sql)
        fillgrid()

    End Sub
End Class