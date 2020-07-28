Public Class frmAllBankList

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sql As String
        'MsgBox(setmonth)
        If ComboBox2.Text.ToUpper = "CASH" Then
            sql = "SELECT dbo.EMPMASTER.name + '/' + empmaster.fname [name], dbo.ORGANIZATIONMASTER.orgid organization," _
                         & tablename & ".basic," & tablename & ".amtpay, " & tablename & ".hra," & tablename & ".cca," _
                         & tablename & ".oa1, " & tablename & ".oa2, " & tablename & ".it," _
                         & tablename & ".educease," & tablename & ".proftax," _
                         & tablename & ".collegeloan, " & tablename & ".lwp," _
                         & tablename & ".remark," & tablename & ".amt833, " _
                         & tablename & ".amt367, " & tablename & ".groupinsded," _
                         & tablename & ".secudep," & tablename & ".od1, " & tablename & ".paymode," & tablename & ".da," _
                         & " dbo.EMPMASTER.empid, dbo.DEPARTMENT.department,dbo.EMPMASTER.accountno acc FROM dbo.EMPMASTER INNER JOIN" _
                         & " dbo.ORGANIZATIONMASTER INNER JOIN " & tablename & " ON dbo.ORGANIZATIONMASTER.orgid = " & tablename & ".orgid ON " _
                         & " dbo.EMPMASTER.empid = " & tablename & ".empid and    EMPMASTER.orgid = " & tablename & ".orgid  INNER JOIN" _
                         & " dbo.EMPDEPARTMENT ON dbo.EMPMASTER.empid = dbo.EMPDEPARTMENT.empid AND " _
                         & " dbo.ORGANIZATIONMASTER.orgid = dbo.EMPDEPARTMENT.orgid INNER JOIN" _
                         & " dbo.DEPARTMENT ON dbo.ORGANIZATIONMASTER.orgid = dbo.DEPARTMENT.orgid AND dbo.EMPDEPARTMENT.orgid = dbo.DEPARTMENT.orgid AND " _
                         & " dbo.EMPDEPARTMENT.depno = dbo.DEPARTMENT.depid where " & tablename & ".salmonth='" & setmonth & "'" _
                         & " AND len(EMPMASTER.ACCOUNTNO)=0 and " & tablename & ".orgid<>'Phoenix Hatcheries'" _
                         & " ORDER BY " & tablename & ".basic DESC "
        Else

            sql = "SELECT dbo.EMPMASTER.name + '/' + empmaster.fname [name], dbo.ORGANIZATIONMASTER.orgid organization," _
                   & tablename & ".basic," & tablename & ".amtpay, " & tablename & ".hra," & tablename & ".cca," _
                   & tablename & ".oa1, " & tablename & ".oa2, " & tablename & ".it," _
                   & tablename & ".educease," & tablename & ".proftax," _
                   & tablename & ".collegeloan, " & tablename & ".lwp," _
                   & tablename & ".remark," & tablename & ".amt833, " _
                   & tablename & ".amt367, " & tablename & ".groupinsded," _
                   & tablename & ".secudep," & tablename & ".od1, " & tablename & ".paymode," & tablename & ".da , " _
                   & " dbo.EMPMASTER.empid, dbo.DEPARTMENT.department,dbo.EMPMASTER.accountno acc FROM dbo.EMPMASTER INNER JOIN" _
                   & " dbo.ORGANIZATIONMASTER INNER JOIN " & tablename & " ON dbo.ORGANIZATIONMASTER.orgid = " & tablename & ".orgid ON " _
                   & " dbo.EMPMASTER.empid = " & tablename & ".empid and    EMPMASTER.orgid = " & tablename & ".orgid  INNER JOIN" _
                   & " dbo.EMPDEPARTMENT ON dbo.EMPMASTER.empid = dbo.EMPDEPARTMENT.empid AND " _
                   & " dbo.ORGANIZATIONMASTER.orgid = dbo.EMPDEPARTMENT.orgid INNER JOIN" _
                   & " dbo.DEPARTMENT ON dbo.ORGANIZATIONMASTER.orgid = dbo.DEPARTMENT.orgid AND dbo.EMPDEPARTMENT.orgid = dbo.DEPARTMENT.orgid AND " _
                   & " dbo.EMPDEPARTMENT.depno = dbo.DEPARTMENT.depid where " & tablename & ".salmonth='" & setmonth & "' " _
                   & " AND EMPMASTER.ACCOUNTNO LIKE ('%" & ComboBox2.Text & "%') and " & tablename & ".orgid<>'Phoenix Hatcheries'" _
                   & " ORDER BY " & tablename & ".basic DESC "

        End If
        Dim dt As String
        dt = setmonth

        dt = dt.Substring(3)
        globalmod.DataSetRet(sql, "sa1")
        'MsgBox(ds.Tables("sa").Rows.Count)

        Dim crq As New CrBankstateAll
        crq.SetDataSource(ds.Tables("sa1"))


        crq.SetParameterValue("orgname", "")
        crq.SetParameterValue("SALMONTH", dt)




        CrystalReportViewer1.ReportSource = crq
    End Sub
End Class