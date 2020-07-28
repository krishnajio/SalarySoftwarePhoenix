Public Class bankstateshow

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sql As String
        'MsgBox(setmonth)
        If ComboBox2.Text.ToUpper = "CASH" Then
            sql = "SELECT dbo.EMPMASTER.name + '/' + empmaster.fname [name], dbo.ORGANIZATIONMASTER.organization," _
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
                         & " dbo.EMPDEPARTMENT.depno = dbo.DEPARTMENT.depid where " & tablename & ".salmonth='" & setmonth & "' and dbo.EMPDEPARTMENT.orgid='" & organization & "'" _
                         & " AND len(EMPMASTER.ACCOUNTNO)=0" _
                         & " ORDER BY " & tablename & ".basic DESC "
        Else

            sql = "SELECT dbo.EMPMASTER.name + '/' + empmaster.fname [name], dbo.ORGANIZATIONMASTER.organization," _
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
                   & " dbo.EMPDEPARTMENT.depno = dbo.DEPARTMENT.depid where " & tablename & ".salmonth='" & setmonth & "' and dbo.EMPDEPARTMENT.orgid='" & organization & "'" _
                   & " AND EMPMASTER.ACCOUNTNO LIKE ('%" & ComboBox2.Text & "%')" _
                   & " ORDER BY " & tablename & ".basic DESC "

        End If
        Dim dt As String
        dt = setmonth

        dt = dt.Substring(3)
        globalmod.DataSetRet(sql, "sa1")
        'MsgBox(ds.Tables("sa").Rows.Count)

        Dim crq As New bankstate
        crq.SetDataSource(ds.Tables("sa1"))


        crq.SetParameterValue("orgname", organization)
        crq.SetParameterValue("SALMONTH", dt)




        CrystalReportViewer1.ReportSource = crq
    End Sub

    Private Sub bankstateshow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String
        sql = "select orgid from organizationmaster"
        globalmod.DataSetRet(sql, "or1")
        ComboBox1.DataSource = ds.Tables("or1")
        ComboBox1.DisplayMember = "orgid"
        ComboBox2.SelectedIndex = 0

    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub
End Class