Public Class frmapptaxrpt

    Private Sub frmapptaxrpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePicker1.Text = setmonth

        Dim sql As String
        sql = "select orgid from organizationmaster"
        globalmod.DataSetRet(sql, "or")
        ComboBox1.DataSource = ds.Tables("or")
        ComboBox1.DisplayMember = "orgid"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sql As String

        sql = "SELECT dbo.EMPMASTER.name + '-' + EMPMASTER.fname [name]  , dbo.ORGANIZATIONMASTER.organization," _
               & " dbo." & tablename & ".basic basic1,dbo." & tablename & ".amtpay amtpay, dbo." & tablename & ".hra,dbo." & tablename & ".cca," _
               & " dbo." & tablename & ".oa1, dbo." & tablename & ".oa2, dbo." & tablename & ".it," _
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
               & " and  dbo." & tablename & ".amtpay + dbo." & tablename & ".hra + dbo." & tablename & ".cca + " _
               & " dbo." & tablename & ".oa1 + dbo." & tablename & ".oa2 >15000 ORDER BY dbo." & tablename & ".basic DESC"
        'sql = "SELECT dbo.EMPMASTER.name, dbo.ORGANIZATIONMASTER.organization," _
        '              & " dbo.EMPSALARY.basic basic1,dbo.EMPSALARY.amtpay amtpay, dbo.EMPSALARY.hra,dbo.EMPSALARY.cca," _
        '              & " dbo.EMPSALARY.oa1, dbo.EMPSALARY.oa2, dbo.EMPSALARY.it," _
        '              & "dbo.EMPSALARY.educease,dbo.EMPSALARY.proftax," _
        '              & " dbo.EMPSALARY.collegeloan, dbo.EMPSALARY.lwp," _
        '              & " dbo.EMPSALARY.remark,dbo.EMPSALARY.amt833, " _
        '              & " dbo.EMPSALARY.amt367, dbo.EMPSALARY.groupinsded," _
        '              & " dbo.EMPSALARY.secudep,dbo.EMPSALARY.od1, dbo.EMPSALARY.paymode," _
        '              & " dbo.EMPMASTER.empid, dbo.DEPARTMENT.department,dbo.EMPMASTER.accountno acc FROM dbo.EMPMASTER INNER JOIN" _
        '              & " dbo.ORGANIZATIONMASTER INNER JOIN dbo.EMPSALARY ON dbo.ORGANIZATIONMASTER.orgid = dbo.EMPSALARY.orgid ON " _
        '              & " dbo.EMPMASTER.empid = dbo.EMPSALARY.empid and    EMPMASTER.orgid = EMPSALARY.orgid  INNER JOIN" _
        '              & " dbo.EMPDEPARTMENT ON dbo.EMPMASTER.empid = dbo.EMPDEPARTMENT.empid AND " _
        '              & " dbo.ORGANIZATIONMASTER.orgid = dbo.EMPDEPARTMENT.orgid INNER JOIN" _
        '              & " dbo.DEPARTMENT ON dbo.ORGANIZATIONMASTER.orgid = dbo.DEPARTMENT.orgid AND dbo.EMPDEPARTMENT.orgid = dbo.DEPARTMENT.orgid AND " _
        '              & " dbo.EMPDEPARTMENT.depno = dbo.DEPARTMENT.depid where dbo.EMPSALARY.salmonth='" & setmonth & "' and dbo.EMPDEPARTMENT.orgid='" & organization & "'" _
        '              & " ORDER BY dbo.EMPSALARY.basic DESC"

        Dim dt As String
        dt = setmonth
        dt = dt.Substring(3)


        globalmod.DataSetRet(sql, "sa")
        'MsgBox(ds.Tables("sa").Rows.Count)

        Dim crq As New phxaptax
        crq.SetDataSource(ds.Tables("sa"))
        crq.SetParameterValue("orgname", organization)
        crq.SetParameterValue("SALMONTH", dt)
        CrystalReportViewer1.ReportSource = crq
        
    End Sub
End Class