Public Class frmLWTSalary2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sql As String
        sql = "SELECT * from salary"
        globalmod.DataSetRet(sql, "sal")
        Dim r As New CRLWS2
        r.SetDataSource(globalmod.ds.Tables("sal"))
        CrystalReportViewer1.ReportSource = r
    End Sub
End Class