Public Class frmreligion

    Private Sub frmreligion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillgrid()
    End Sub
    Private Sub fillgrid()
        Try
            Dim sql As String
            sql = "select * from religion"
            globalmod.DataSetRet(sql, "rel")
            DataGridView1.DataSource = ds.Tables("rel")
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        TextBox1.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value
    End Sub
    Private Sub Button1save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1save.Click
        Dim sql As String
        sql = "insert into religion values('" & TextBox1.Text & "')"
        globalmod.SqlExecuteNonQuery(sql)
        fillgrid()
    End Sub

    Private Sub Button2upd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2upd.Click
        Dim sql As String
        sql = "delete from religion where religionname = '" & TextBox1.Text & "'"
        MsgBox(globalmod.SqlExecuteNonQuery(sql))
        fillgrid()
    End Sub

    Private Sub Button3close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3close.Click
        Me.Close()
    End Sub
End Class