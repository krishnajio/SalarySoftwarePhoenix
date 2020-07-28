Public Class frmrptemplist

    Private Sub frmrptemplist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String
        sql = "SELECT     dbo.EMPMASTER.empid, dbo.EMPMASTER.name, dbo.EMPMASTER.doj, dbo.EMPSALARYSTRUCTURE.basic," _
        & " dbo.EMPMASTER.orgid[department]" _
        & " FROM         dbo.EMPMASTER INNER JOIN" _
        & " dbo.EMPDEPARTMENT ON dbo.EMPMASTER.empid = dbo.EMPDEPARTMENT.empid AND " _
        & " dbo.EMPMASTER.orgid = dbo.EMPDEPARTMENT.orgid INNER JOIN" _
        & " dbo.EMPSALARYSTRUCTURE ON dbo.EMPMASTER.empid = dbo.EMPSALARYSTRUCTURE.empid AND " _
        & " dbo.EMPDEPARTMENT.empid = dbo.EMPSALARYSTRUCTURE.empid AND " _
        & " dbo.EMPDEPARTMENT.orgid = dbo.EMPSALARYSTRUCTURE.orgid INNER JOIN" _
        & " dbo.DEPARTMENT ON dbo.EMPDEPARTMENT.orgid = dbo.DEPARTMENT.orgid AND " _
        & " dbo.EMPDEPARTMENT.depno = dbo.DEPARTMENT.depid"
        globalmod.DataSetRet(sql, "list")
        Dim cry1 As New rptemplist
        cry1.SetDataSource(ds.Tables("list"))
        CrystalReportViewer1.ReportSource = cry1

    End Sub
End Class