Public Class frmesisummary

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim sql As String
            Dim headname As String = ""
            headname = "oa1"
            sql = "SELECT dbo.EMPMASTER.name   , dbo.ORGANIZATIONMASTER.organization," _
                   & " dbo." & tablename & ".basic basic,dbo." & tablename & ".amtpay amtpay, dbo." & tablename & ".hra,dbo." & tablename & ".cca," _
                   & " dbo." & tablename & "." & headname & " [oa1] , dbo." & tablename & ".oa2, dbo." & tablename & ".it," _
                   & "dbo." & tablename & ".educease,dbo." & tablename & ".proftax," _
                   & " dbo." & tablename & ".collegeloan, dbo." & tablename & ".lwp," _
                   & " dbo." & tablename & ".remark,dbo." & tablename & ".amt833, " _
                   & " dbo." & tablename & ".amt367, dbo." & tablename & ".groupinsded," _
                   & " dbo." & tablename & ".secudep,dbo." & tablename & ".od1, dbo." & tablename & ".paymode," _
                   & " dbo.EMPMASTER.empid, dbo.DEPARTMENT.department,substring(contactno,9,4) [acc] FROM dbo.EMPMASTER INNER JOIN" _
                   & " dbo.ORGANIZATIONMASTER INNER JOIN dbo." & tablename & " ON dbo.ORGANIZATIONMASTER.orgid = dbo." & tablename & ".orgid ON " _
                   & " dbo.EMPMASTER.empid = dbo." & tablename & ".empid and    EMPMASTER.orgid = " & tablename & ".orgid  INNER JOIN" _
                   & " dbo.EMPDEPARTMENT ON dbo.EMPMASTER.empid = dbo.EMPDEPARTMENT.empid AND " _
                   & " dbo.ORGANIZATIONMASTER.orgid = dbo.EMPDEPARTMENT.orgid INNER JOIN" _
                   & " dbo.DEPARTMENT ON dbo.ORGANIZATIONMASTER.orgid = dbo.DEPARTMENT.orgid AND dbo.EMPDEPARTMENT.orgid = dbo.DEPARTMENT.orgid AND " _
                   & " dbo.EMPDEPARTMENT.depno = dbo.DEPARTMENT.depid where dbo." & tablename & ".salmonth='" & setmonth & "' and dbo.EMPDEPARTMENT.orgid='" & organization & "'" _
                   & " and " & tablename & "." & headname & "  >0" _
                   & " ORDER BY dbo." & tablename & ".basic DESC"
            Dim dt As String
            dt = setmonth
            'dt = dt.Substring(3)
            globalmod.DataSetRet(sql, "esisum")
            Dim crqES As New CRESIC
            crqES.SetDataSource(ds.Tables("esisum"))
            crqES.SetParameterValue("orgname", organization)
            crqES.SetParameterValue("SALMONTH", dt)
            CrystalReportViewer1.ReportSource = crqES
        Catch ex As Exception

        End Try
    End Sub
End Class