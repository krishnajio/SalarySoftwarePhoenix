Public Class frmoverage

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim sql As String
            sql = "select orgid, empid,name,fname, convert( varchar,dob,105)[DOB] from empmaster where dob <='" _
            & CDate(DateTimePicker1.Text).AddYears(-58) & "' order by orgid,name"
            globalmod.DataSetRet(sql, "getretm")
            DataGridView1.DataSource = ds.Tables("getretm")

        Catch ex As Exception

        End Try
    End Sub
End Class