Public Class frmLWNursery

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sql As String
        sql = "SELECT * from salary"
        globalmod.DataSetRet(sql, "sal")
        Dim r As New CRLW
        r.SetDataSource(globalmod.ds.Tables("sal"))
        CrystalReportViewer2.ReportSource = r
    End Sub
End Class