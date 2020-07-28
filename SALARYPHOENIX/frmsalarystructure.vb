Public Class frmsalarystructure

    Private Sub frmsalarystructure_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String
        sql = "select orgid from organizationmaster"
        globalmod.DataSetRet(sql, "orgid")
        ComboBox1orgid.DataSource = ds.Tables("orgid")
        ComboBox1orgid.DisplayMember = "orgid"
        fillgrid()

    End Sub

    Private Sub Button4close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4close.Click
        Me.Close()

    End Sub

    Private Sub Button1save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1save.Click
        If ComboBox1orgid.Text = "" Then
            MsgBox("please select an organization")
            Exit Sub
        End If
        If Not IsNumeric(TextBox1da.Text) Then
            MsgBox("please Enter Numeric Value For DA PERCENT")
        ElseIf Not IsNumeric(TextBox2hr.Text) Then
            MsgBox("please Enter Numeric Value For HR PERCENT")
        ElseIf Not IsNumeric(TextBox3cc.Text) Then
            MsgBox("please Enter Numeric Value For CCA PERCENT")
        ElseIf Not IsNumeric(TextBox4pf.Text) Then
            MsgBox("please Enter Numeric Value For PF PERCENT")
        ElseIf Not IsNumeric(TextBox5ec.Text) Then
            MsgBox("please Enter Numeric Value For EC PERCENT")
        ElseIf Not IsNumeric(TextBox6maxpf.Text) Then
            MsgBox("please Enter Numeric Value For MAX PF AMOUNT")
        ElseIf Not IsNumeric(TextBox7totpf.Text) Then
            MsgBox("please Enter Numeric Value For TOTAL PF AMOUNT")
            Exit Sub
        End If

        Dim sql As String
        sql = "insert into salarystructuremaster values('" _
        & ComboBox1orgid.Text & "','" & TextBox1da.Text & "','" _
        & TextBox2hr.Text & "','" & TextBox3cc.Text & "','" _
        & TextBox4pf.Text & "','" & TextBox5ec.Text & "','" _
        & TextBox6maxpf.Text & "','" & TextBox7totpf.Text & "','sachin')"
        globalmod.SqlExecuteNonQuery(sql)
        fillgrid()
    End Sub
    Public Sub fillgrid()
        Try
            Dim sql As String
            sql = "select * from salarystructuremaster "
            globalmod.DataSetRet(sql, "salary")
            DataGridView1.DataSource = ds.Tables("salary")
        Catch ex As Exception

        End Try


    End Sub

    Private Sub Button2upd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2upd.Click
        Dim sql As String
        sql = "update salarystructuremaster set daper='" & TextBox1da.Text _
        & "',hrper='" & TextBox2hr.Text & "',ccper='" & TextBox3cc.Text _
        & "',pfper='" & TextBox4pf.Text & "',ecpper='" & TextBox5ec.Text _
        & "',maxpfamt='" & TextBox6maxpf.Text & "',totalpfamt='" & TextBox7totpf.Text _
        & "' where orgid='" & organization & "'"
        MsgBox(globalmod.SqlExecuteNonQuery(sql))
        fillgrid()

    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ComboBox1orgid.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value
        TextBox1da.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(1).Value
        TextBox2hr.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(2).Value
        TextBox3cc.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(3).Value
        TextBox4pf.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(4).Value
        TextBox5ec.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(5).Value
        TextBox6maxpf.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(6).Value
        TextBox7totpf.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(7).Value
    End Sub

    Private Sub Button3del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3del.Click
        Dim sql As String
        sql = "delete from salarystructuremaster  where orgid='" & organization & "'"
        globalmod.SqlExecuteNonQuery(sql)
        fillgrid()
    End Sub
End Class