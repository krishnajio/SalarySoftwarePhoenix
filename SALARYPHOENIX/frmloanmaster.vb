Public Class frmloanmaster

    Private Sub frmloanmaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillgrid()
        Dim sql As String
        sql = "select orgid from organizationmaster where orgid ='" & globalmod.organization & "'"
        globalmod.DataSetRet(sql, "oid")
        ComboBox1oid.DataSource = ds.Tables("oid")
        ComboBox1oid.DisplayMember = "orgid"

    End Sub
    Public Sub fillgrid()
        Dim sql As String
        sql = "select * from loanmaster where orgid ='" & globalmod.organization & "' "
        globalmod.DataSetRet(sql, "loan")
        DataGridView1.DataSource = ds.Tables("loan")
    End Sub

    Private Sub Button2close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2close.Click
        Me.Close()

    End Sub

    Private Sub Button1save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1save.Click
        Try
            Dim sql As String
            sql = "insert into LOANMASTER (orgid, empid, loandate, amount, installmentamt,completedate,rem,noofins,remins)" _
            & " values ('" & organization & "','" & TextBox1eid.Text & "','" _
            & DateTimePicker1loandate.Text & "','" & Val(TextBox2amt.Text) & "','" _
            & Val(TextBox3inst.Text) & "','" & DateTimePicker2comdate.Text & "','" & Val(TextBox2amt.Text) & "','" & noofins & "','" & noofins & "')"
            globalmod.SqlExecuteNonQuery(sql)
            fillgrid()
            TextBox1eid.Focus()
            TextBox2amt.Clear()
            TextBox3inst.Clear()
        Catch

        End Try

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ComboBox1oid.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value
        TextBox1eid.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(1).Value
        DateTimePicker1loandate.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(2).Value
        TextBox2amt.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(3).Value
        TextBox3inst.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(4).Value
        DateTimePicker2comdate.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(6).Value
    End Sub

    Private Sub Button1upd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1eid_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1eid.Enter
        Dim frmempid As New frmemplist
        frmempid.ShowDialog()
        TextBox1eid.Text = frmempid.retEmpId
        TextBox1name.Text = frmempid.retempname



    End Sub
    Dim noofins As Integer
    Private Sub TextBox3inst_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3inst.Leave
        Try
            If Val(TextBox3inst.Text) > 0 Then
                noofins = Math.Ceiling(Val(TextBox2amt.Text) / Val(TextBox3inst.Text))
                DateTimePicker2comdate.Value = DateTimePicker1loandate.Value.AddMonths(noofins)
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub TextBox3inst_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3inst.TextChanged

    End Sub

    Private Sub ComboBox1oid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1oid.SelectedIndexChanged

    End Sub

    Private Sub TextBox1eid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1eid.TextChanged

    End Sub
End Class