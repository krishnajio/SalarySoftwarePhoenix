Public Class frmupdate

    Private Sub frmupdate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String
        sql = "select orgid from organizationmaster"
        globalmod.DataSetRet(sql, "oid")
        ComboBox1oid.DataSource = ds.Tables("oid")
        ComboBox1oid.DisplayMember = "orgid"
    End Sub
    Public Sub fillgrid()
        Try
            Dim sql As String
            '
            ' Dim sql As String
            sql = "SELECT  EMPMASTER.name ,   EMPMASTER.orgid, EMPMASTER.empid, basic, da, hra,cca, oa1, oa2" _
            & " FROM EMPSALARYSTRUCTURE INNER JOIN EMPMASTER ON EMPSALARYSTRUCTURE.empid = EMPMASTER.empid and EMPSALARYSTRUCTURE.orgid = EMPMASTER.orgid where EMPMASTER.orgid='" _
                   & ComboBox1oid.Text & "' order by EMPMASTER.name"
            globalmod.DataSetRet(sql, "empsalstu")
            ' MsgBox(ds.Tables("empsalstu").Rows.Count)
            DataGridView1.DataSource = ds.Tables("empsalstu")
            globalmod.DataSetRet(sql, "empsalstu")
            ' MsgBox(ds.Tables("empsalstu").Rows.Count)
            DataGridView1.DataSource = ds.Tables("empsalstu")
        Catch ex As Exception

        End Try


    End Sub
    Private Sub ComboBox1oid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1oid.SelectedIndexChanged
        fillgrid()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim sql As String

        For i = 0 To DataGridView1.Rows.Count - 2
            sql = "update EMPSALARYSTRUCTURE set basic='" _
            & DataGridView1.Rows(i).Cells("basic").Value _
            & "',da='" & DataGridView1.Rows(i).Cells("da").Value & "',hra='" _
            & DataGridView1.Rows(i).Cells("hra").Value _
            & "',oa1='" & DataGridView1.Rows(i).Cells("oa1").Value _
            & "',oa2='" _
            & DataGridView1.Rows(i).Cells("oa2").Value _
            & "',cca='" & DataGridView1.Rows(i).Cells("cca").Value _
            & "' where empid='" & DataGridView1.Rows(i).Cells("empid").Value _
            & "' and orgid='" _
            & DataGridView1.Rows(i).Cells("org").Value & "'"
            ' MsgBox(sql)
            globalmod.SqlExecuteNonQuery(sql)


        Next
    End Sub

    Private Sub TextBox1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyUp
        Try
            Dim db1 As New DataView(ds.Tables("empsalstu"))
            db1.RowFilter = "name like '" & TextBox1.Text & "%'"
            DataGridView1.DataSource = db1

        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class