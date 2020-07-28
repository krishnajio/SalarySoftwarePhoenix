Public Class frmuser

    Private Sub frmuser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillgrid()
    End Sub
    Public Sub fillgrid()
        Dim sql As String
        sql = "select userid,username,role,status from [user]"

        globalmod.DataSetRet(sql, "uinfo")
        DataGridView1.DataSource = ds.Tables("uinfo")
    End Sub

    Private Sub Button4close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4close.Click
        Me.Close()

    End Sub

    Private Sub Button1crt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1crt.Click
        If TextBox3pass.Text <> TextBox1conpass.Text Then
            MsgBox("Password & Confirm Password Must Be Same")
            Exit Sub
        End If
        Dim sql As String
        sql = "insert into [user] values('" & TextBox1uid.Text & "',' " _
        & TextBox2uname.Text & "','" & TextBox3pass.Text & "','" _
        & ComboBox1role.Text & "','" & CheckBox1.CheckState & "')"
        globalmod.SqlExecuteNonQuery(sql)
        fillgrid()

    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            TextBox1uid.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value
            TextBox2uname.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(1).Value
            ComboBox1role.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(3).Value
            CheckBox1.CheckState = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(4).Value


        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2upd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2upd.Click
        Dim sql As String
        sql = "update [user] set username='" & TextBox2uname.Text & "',password='" _
        & TextBox3pass.Text & "',role='" & ComboBox1role.Text & "',status='" _
        & CheckBox1.CheckState & "' where userid='" & TextBox1uid.Text & "'"
        globalmod.SqlExecuteNonQuery(sql)
        fillgrid()

    End Sub

    Private Sub Button3del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3del.Click
        Dim sql As String
        sql = "delete from [user] where userid='" & TextBox1uid.Text & "'"
        globalmod.SqlExecuteNonQuery(sql)
        fillgrid()

    End Sub

    Private Sub TextBox1conpass_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1conpass.Leave
       
    End Sub
End Class