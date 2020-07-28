Public Class totransfer

    Private Sub totransfer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim sql As String
        sql = "select * from sheet1$ "
        globalmod.DataSetRet(sql, "sa")
        DataGridView1.DataSource = ds.Tables("sa")
        MsgBox(ds.Tables("sa").Rows.Count)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        For i = 0 To DataGridView1.Rows.Count - 2

            Dim sql As String

            'sql = "insert into empmaster (empid,name,orgid) values('" & DataGridView1.Rows(i).Cells(2).Value _
            '& "','" & DataGridView1.Rows(i).Cells(1).Value _
            '& "','Phoenix Hatcheries')"

            sql = "insert into empsalarystructure (orgid,empid) values('Phoenix Hatcheries','" & DataGridView1.Rows(i).Cells(2).Value _
            & "')"
            'MsgBox(sql)
            MsgBox(globalmod.SqlExecuteNonQuery(sql))
            'MsgBox(sql)

            'MsgBox(globalmod.SqlExecuteNonQuery(sql))
            'Dim sql1 As String
            'sql1 = "insert into empdepartment (empid,[date],orgid,depno) values" _
            '& "('" & DataGridView1.Rows(i).Cells(2).Value & "','" & Date.Today _
            '& "','Phoenix Hatcheries','" & DataGridView1.Rows(i).Cells(0).Value & "')"
            '' MsgBox(sql1)

        Next
    End Sub
End Class