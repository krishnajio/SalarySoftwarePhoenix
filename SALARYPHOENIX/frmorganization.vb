Public Class frmorganization

    Private Sub frmorganization_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillgrid()
        Dim sql As String
        sql = "select distinct state from city"
        globalmod.DataSetRet(sql, "state")
        ComboBox1state.DataSource = ds.Tables("state")
        ComboBox1state.DisplayMember = "state"
    End Sub
    Public Sub fillgrid()
        Dim sql As String
        sql = "select * from organizationmaster"
        globalmod.DataSetRet(sql, "org")
        DataGridView1.DataSource = ds.Tables("org")
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        TextBox1orgid.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value
        TextBox2name.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(1).Value
        TextBox3add.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(2).Value
        ComboBox1state.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(3).Value
        ComboBox2city.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(4).Value
        TextBox4phone.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(5).Value
    End Sub


    Private Sub Button1save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1save.Click
        Dim sql As String
        sql = "insert into organizationmaster values('" & TextBox1orgid.Text _
        & "','" & TextBox2name.Text & "','" & TextBox3add.Text & "','" _
        & ComboBox1state.Text & "','" & ComboBox2city.Text & "','" _
        & TextBox4phone.Text & "','sachin')"
        globalmod.SqlExecuteNonQuery(sql)
        fillgrid()
    End Sub

    Private Sub Button4close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4close.Click
        Me.Close()

    End Sub

    Private Sub Button2upd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2upd.Click
        Dim sql As String
        sql = "update organizationmaster set organization='" & TextBox2name.Text _
        & "',address='" & TextBox3add.Text & "',state='" & ComboBox1state.Text _
        & "',city='" & ComboBox2city.Text & "',phone='" & TextBox4phone.Text _
        & "',orgid='" & TextBox1orgid.Text & "' where orgid='" & organization & "'"
        MsgBox(globalmod.SqlExecuteNonQuery(sql))
        fillgrid()
    End Sub

    Private Sub Button3del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3del.Click
        Dim sql As String
        sql = "delete from  organizationmaster where orgid='" & organization & "'"
        MsgBox(globalmod.SqlExecuteNonQuery(sql))
        fillgrid()
    End Sub

    Private Sub ComboBox1state_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1state.SelectedIndexChanged
        Dim sql As String
        sql = "select city from city where state='" & ComboBox1state.Text & "'"
        globalmod.DataSetRet(sql, "city")
        ComboBox2city.DataSource = ds.Tables("city")
        ComboBox2city.DisplayMember = "city"
    End Sub
End Class