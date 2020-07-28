Public Class frmbankmaster

    Private Sub frmbankmaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String
        sql = "select distinct state from city"
        globalmod.DataSetRet(sql, "state")
        ComboBox1state.DataSource = ds.Tables("state")
        ComboBox1state.DisplayMember = "state"
        fillgrid()
        
    End Sub

    Private Sub Button1save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1save.Click
        Try
            Dim sql As String
            sql = "insert into bankmaster values('" & TextBox1bname.Text _
            & "','" & TextBox2branch.Text & "','" & ComboBox1state.Text _
            & "','" & ComboBox2city.Text & "','" & TextBox4phone.Text _
            & "','sachin')"
            globalmod.SqlExecuteNonQuery(sql)
            fillgrid()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ComboBox1state_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1state.SelectedIndexChanged
        Dim sql As String
        sql = "select city from city where state='" & ComboBox1state.Text & "'"
        globalmod.DataSetRet(sql, "city")
        ComboBox2city.DataSource = ds.Tables("city")
        ComboBox2city.DisplayMember = "city"
    End Sub

    Private Sub fillgrid()
        Try
            Dim sql As String
            sql = "select * from bankmaster"
            globalmod.DataSetRet(sql, "bank")
            DataGridView1.DataSource = ds.Tables("bank")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button4clode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4clode.Click
        Me.Close()
    End Sub

    Private Sub Button3delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3delete.Click
        Dim sql As String
        sql = "delete from bankmaster where bank='" & TextBox1bname.Text & "' and " _
        & " branch='" & TextBox2branch.Text & "'"
        MsgBox(globalmod.SqlExecuteNonQuery(sql))
        fillgrid()

    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        TextBox1bname.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value
        TextBox2branch.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(1).Value
        ComboBox1state.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(2).Value
        ComboBox2city.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(3).Value
        TextBox4phone.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(4).Value

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class