Public Class frmSalMonthly

    Private Sub phxrptshow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtp1.Text = setmonth

        Dim sql As String
        sql = "select orgid from organizationmaster"
        globalmod.DataSetRet(sql, "or")
        ComboBox1.DataSource = ds.Tables("or")
        ComboBox1.DisplayMember = "orgid"

        'sql = "SELECT  dbo.EMPDEPARTMENT.empid, dbo.EMPMASTER.name, dbo.ORGANIZATIONMASTER.organization, dbo.DEPARTMENT.department, " _
        '& "" & tablename & ".basic, " & tablename & ".hra, " & tablename & ".cca, " & tablename & ".oa1, " & tablename & ".oa2, " _
        '& " " & tablename & ".it, " & tablename & ".educease, " & tablename & ".proftax, " & tablename & ".collegeloan, " _
        '& " " & tablename & ".lwp, " & tablename & ".remark, " & tablename & ".amt833, " & tablename & ".amt367, " _
        '& " " & tablename & ".groupinsded, " & tablename & ".secudep, " & tablename & ".od1, " & tablename & ".paymode" _
        '& " FROM  dbo.EMPDEPARTMENT INNER JOIN dbo.EMPMASTER ON dbo.EMPDEPARTMENT.empid = dbo.EMPMASTER.empid INNER JOIN" _
        '& " " & tablename & " ON dbo.EMPDEPARTMENT.orgid = " & tablename & ".orgid AND " _
        '& " dbo.EMPDEPARTMENT.empid = " & tablename & ".empid INNER JOIN" _
        '& " dbo.ORGANIZATIONMASTER ON dbo.EMPDEPARTMENT.orgid = dbo.ORGANIZATIONMASTER.orgid AND " _
        '& " " & tablename & ".orgid = dbo.ORGANIZATIONMASTER.orgid INNER JOIN" _
        '& " dbo.EMPDEPARTMENT AS EMPDEPARTMENT_1 ON dbo.EMPMASTER.empid = EMPDEPARTMENT_1.empid AND " _
        '& " dbo.ORGANIZATIONMASTER.orgid = EMPDEPARTMENT_1.orgid INNER JOIN" _
        '& " dbo.DEPARTMENT ON dbo.ORGANIZATIONMASTER.orgid = dbo.DEPARTMENT.orgid  order by " & tablename & ".basic desc"





    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sql As String
        Dim paymode As String = ""


        sql = "select * from dbo.salmonthly where  orgid ='" & ComboBox1.Text & "' and salmonth  between '" & dtp1.Value.ToShortDateString & "' and '" & dtp2.Value.ToShortDateString & "'"

        'If cmbpaymode.Text.ToUpper = "CASH" Then
        '    paymode = " and  len(accountno)=0 "
        'ElseIf cmbpaymode.Text.ToUpper = "ALL" Then
        '    paymode = ""
        'Else
        '    paymode = " and len(accountno)<>0 "

        'End If
        'sql = "SELECT dbo.EMPMASTER.name + '-' + EMPMASTER.fname [name]  , dbo.ORGANIZATIONMASTER.organization," _
        '       & tablename & ".basic basic," & tablename & ".amtpay amtpay, " & tablename & ".hra," & tablename & ".cca," _
        '       & " " & tablename & ".oa1, " & tablename & ".oa2, " & tablename & ".it," _
        '       & "" & tablename & ".educease," & tablename & ".proftax," _
        '       & " " & tablename & ".collegeloan, " & tablename & ".lwp," _
        '       & " " & tablename & ".remark," & tablename & ".amt833, " _
        '       & " " & tablename & ".amt367, " & tablename & ".groupinsded," _
        '       & " " & tablename & ".secudep," & tablename & ".od1, " & tablename & ".paymode, " & tablename & ".da," _
        '       & " dbo.EMPMASTER.empid, dbo.DEPARTMENT.department,substring(contactno,9,4) [acc] FROM dbo.EMPMASTER INNER JOIN" _
        '       & " dbo.ORGANIZATIONMASTER INNER JOIN " & tablename & " ON dbo.ORGANIZATIONMASTER.orgid = " & tablename & ".orgid ON " _
        '       & " dbo.EMPMASTER.empid = " & tablename & ".empid and    EMPMASTER.orgid = " & tablename & ".orgid  INNER JOIN" _
        '       & " dbo.EMPDEPARTMENT ON dbo.EMPMASTER.empid = dbo.EMPDEPARTMENT.empid AND " _
        '       & " dbo.ORGANIZATIONMASTER.orgid = dbo.EMPDEPARTMENT.orgid INNER JOIN" _
        '       & " dbo.DEPARTMENT ON dbo.ORGANIZATIONMASTER.orgid = dbo.DEPARTMENT.orgid AND dbo.EMPDEPARTMENT.orgid = dbo.DEPARTMENT.orgid AND " _
        '       & " dbo.EMPDEPARTMENT.depno = dbo.DEPARTMENT.depid where " & tablename & ".salmonth='" _
        '       & setmonth & "' and dbo.EMPDEPARTMENT.orgid='" & organization & "'" _
        '      & " " & paymode & "  ORDER BY " & tablename & ".basic DESC"
        ''sql = "SELECT dbo.EMPMASTER.name, dbo.ORGANIZATIONMASTER.organization," _
        ''              & " dbo.EMPSALARY.basic basic1,dbo.EMPSALARY.amtpay amtpay, dbo.EMPSALARY.hra,dbo.EMPSALARY.cca," _
        ''              & " dbo.EMPSALARY.oa1, dbo.EMPSALARY.oa2, dbo.EMPSALARY.it," _
        ''              & "dbo.EMPSALARY.educease,dbo.EMPSALARY.proftax," _
        ''              & " dbo.EMPSALARY.collegeloan, dbo.EMPSALARY.lwp," _
        ''              & " dbo.EMPSALARY.remark,dbo.EMPSALARY.amt833, " _
        ''              & " dbo.EMPSALARY.amt367, dbo.EMPSALARY.groupinsded," _
        ''              & " dbo.EMPSALARY.secudep,dbo.EMPSALARY.od1, dbo.EMPSALARY.paymode," _
        ''              & " dbo.EMPMASTER.empid, dbo.DEPARTMENT.department,dbo.EMPMASTER.accountno acc FROM dbo.EMPMASTER INNER JOIN" _
        ''              & " dbo.ORGANIZATIONMASTER INNER JOIN dbo.EMPSALARY ON dbo.ORGANIZATIONMASTER.orgid = dbo.EMPSALARY.orgid ON " _
        ''              & " dbo.EMPMASTER.empid = dbo.EMPSALARY.empid and    EMPMASTER.orgid = EMPSALARY.orgid  INNER JOIN" _
        ''              & " dbo.EMPDEPARTMENT ON dbo.EMPMASTER.empid = dbo.EMPDEPARTMENT.empid AND " _
        ''              & " dbo.ORGANIZATIONMASTER.orgid = dbo.EMPDEPARTMENT.orgid INNER JOIN" _
        ''              & " dbo.DEPARTMENT ON dbo.ORGANIZATIONMASTER.orgid = dbo.DEPARTMENT.orgid AND dbo.EMPDEPARTMENT.orgid = dbo.DEPARTMENT.orgid AND " _
        ''              & " dbo.EMPDEPARTMENT.depno = dbo.DEPARTMENT.depid where dbo.EMPSALARY.salmonth='" & setmonth & "' and dbo.EMPDEPARTMENT.orgid='" & organization & "'" _
        ''              & " ORDER BY dbo.EMPSALARY.basic DESC"

        'Dim dt As String
        'dt = setmonth
        'dt = dt.Substring(3)


        globalmod.DataSetRet(sql, "samon")
        ''MsgBox(ds.Tables("sa").Rows.Count)
        If organization = "Phoenix Poultry" Then
            Dim crq As New CrSalMonthly1
            crq.SetDataSource(ds.Tables("samon"))
            crq.SetParameterValue("p1", ComboBox1.Text)
            CrystalReportViewer1.ReportSource = crq
        ElseIf organization = "Phoenix Hatcheries" Then

            Dim crq As New CrSalMonthly1
            crq.SetDataSource(ds.Tables("samon"))
            crq.SetParameterValue("p1", ComboBox1.Text)
            CrystalReportViewer1.ReportSource = crq
            '    Dim crq As New phxsalrptother
            '    crq.SetDataSource(ds.Tables("sa"))

            '    crq.SetParameterValue("orgname", organization)
            '    crq.SetParameterValue("SALMONTH", dt)
            '    crq.SetParameterValue("printvar", cmbprint.Text)
            '    CrystalReportViewer1.ReportSource = crq
        Else

            '    Dim crq As New phxsalrptcasual
            '    crq.SetDataSource(ds.Tables("sa"))
            '    crq.SetParameterValue("orgname", organization)
            '    crq.SetParameterValue("SALMONTH", dt)
            '    crq.SetParameterValue("printvar", cmbprint.Text)
            '    CrystalReportViewer1.ReportSource = crq
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter
        cmbprint.SelectedIndex = 0
    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp1.ValueChanged

    End Sub

    Private Sub cmbprint_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbprint.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub cmbpaymode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbpaymode.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim sql As String
        Dim paymode As String = ""
        sql = "select * from dbo.salmonthly where  orgid ='" & ComboBox1.Text & "' and salmonth  between '" & dtp1.Value.ToShortDateString & "' and '" & dtp2.Value.ToShortDateString & "'"
        'If cmbpaymode.Text.ToUpper = "CASH" Then
        '    paymode = " and  len(accountno)=0 "
        'ElseIf cmbpaymode.Text.ToUpper = "ALL" Then
        '    paymode = ""
        'Else
        '    paymode = " and len(accountno)<>0 "

        'End If
        'sql = "SELECT dbo.EMPMASTER.name + '-' + EMPMASTER.fname [name]  , dbo.ORGANIZATIONMASTER.organization," _
        '       & tablename & ".basic basic," & tablename & ".amtpay amtpay, " & tablename & ".hra," & tablename & ".cca," _
        '       & " " & tablename & ".oa1, " & tablename & ".oa2, " & tablename & ".it," _
        '       & "" & tablename & ".educease," & tablename & ".proftax," _
        '       & " " & tablename & ".collegeloan, " & tablename & ".lwp," _
        '       & " " & tablename & ".remark," & tablename & ".amt833, " _
        '       & " " & tablename & ".amt367, " & tablename & ".groupinsded," _
        '       & " " & tablename & ".secudep," & tablename & ".od1, " & tablename & ".paymode, " & tablename & ".da," _
        '       & " dbo.EMPMASTER.empid, dbo.DEPARTMENT.department,substring(contactno,9,4) [acc] FROM dbo.EMPMASTER INNER JOIN" _
        '       & " dbo.ORGANIZATIONMASTER INNER JOIN " & tablename & " ON dbo.ORGANIZATIONMASTER.orgid = " & tablename & ".orgid ON " _
        '       & " dbo.EMPMASTER.empid = " & tablename & ".empid and    EMPMASTER.orgid = " & tablename & ".orgid  INNER JOIN" _
        '       & " dbo.EMPDEPARTMENT ON dbo.EMPMASTER.empid = dbo.EMPDEPARTMENT.empid AND " _
        '       & " dbo.ORGANIZATIONMASTER.orgid = dbo.EMPDEPARTMENT.orgid INNER JOIN" _
        '       & " dbo.DEPARTMENT ON dbo.ORGANIZATIONMASTER.orgid = dbo.DEPARTMENT.orgid AND dbo.EMPDEPARTMENT.orgid = dbo.DEPARTMENT.orgid AND " _
        '       & " dbo.EMPDEPARTMENT.depno = dbo.DEPARTMENT.depid where " & tablename & ".salmonth='" _
        '       & setmonth & "' and dbo.EMPDEPARTMENT.orgid='" & organization & "'" _
        '      & " " & paymode & "  ORDER BY " & tablename & ".basic DESC"
        ''sql = "SELECT dbo.EMPMASTER.name, dbo.ORGANIZATIONMASTER.organization," _
        ''              & " dbo.EMPSALARY.basic basic1,dbo.EMPSALARY.amtpay amtpay, dbo.EMPSALARY.hra,dbo.EMPSALARY.cca," _
        ''              & " dbo.EMPSALARY.oa1, dbo.EMPSALARY.oa2, dbo.EMPSALARY.it," _
        ''              & "dbo.EMPSALARY.educease,dbo.EMPSALARY.proftax," _
        ''              & " dbo.EMPSALARY.collegeloan, dbo.EMPSALARY.lwp," _
        ''              & " dbo.EMPSALARY.remark,dbo.EMPSALARY.amt833, " _
        ''              & " dbo.EMPSALARY.amt367, dbo.EMPSALARY.groupinsded," _
        ''              & " dbo.EMPSALARY.secudep,dbo.EMPSALARY.od1, dbo.EMPSALARY.paymode," _
        ''              & " dbo.EMPMASTER.empid, dbo.DEPARTMENT.department,dbo.EMPMASTER.accountno acc FROM dbo.EMPMASTER INNER JOIN" _
        ''              & " dbo.ORGANIZATIONMASTER INNER JOIN dbo.EMPSALARY ON dbo.ORGANIZATIONMASTER.orgid = dbo.EMPSALARY.orgid ON " _
        ''              & " dbo.EMPMASTER.empid = dbo.EMPSALARY.empid and    EMPMASTER.orgid = EMPSALARY.orgid  INNER JOIN" _
        ''              & " dbo.EMPDEPARTMENT ON dbo.EMPMASTER.empid = dbo.EMPDEPARTMENT.empid AND " _
        ''              & " dbo.ORGANIZATIONMASTER.orgid = dbo.EMPDEPARTMENT.orgid INNER JOIN" _
        ''              & " dbo.DEPARTMENT ON dbo.ORGANIZATIONMASTER.orgid = dbo.DEPARTMENT.orgid AND dbo.EMPDEPARTMENT.orgid = dbo.DEPARTMENT.orgid AND " _
        ''              & " dbo.EMPDEPARTMENT.depno = dbo.DEPARTMENT.depid where dbo.EMPSALARY.salmonth='" & setmonth & "' and dbo.EMPDEPARTMENT.orgid='" & organization & "'" _
        ''              & " ORDER BY dbo.EMPSALARY.basic DESC"

        'Dim dt As String
        'dt = setmonth
        'dt = dt.Substring(3)


        globalmod.DataSetRet(sql, "samon")
        ''MsgBox(ds.Tables("sa").Rows.Count)
        If ComboBox1.Text = "Phoenix Poultry" Then
            Dim crq As New CrSalMonthly2
            crq.SetDataSource(ds.Tables("samon"))
            crq.SetParameterValue("p1", ComboBox1.Text)
            CrystalReportViewer1.ReportSource = crq
        Else

            Dim crq As New CrSalMonthly2
            crq.SetDataSource(ds.Tables("samon"))
            crq.SetParameterValue("p1", ComboBox1.Text)
            CrystalReportViewer1.ReportSource = crq

            '    Dim crq As New phxsalrptcasual
            '    crq.SetDataSource(ds.Tables("sa"))
            '    crq.SetParameterValue("orgname", organization)
            '    crq.SetParameterValue("SALMONTH", dt)
            '    crq.SetParameterValue("printvar", cmbprint.Text)
            '    CrystalReportViewer1.ReportSource = crq
        End If
    End Sub
End Class