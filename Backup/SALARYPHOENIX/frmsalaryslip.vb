Public Class frmsalaryslip

    Private Sub frmsalaryslip_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String
        Try

            'sql = "select orgid,organization from organizationmaster"
            'globalmod.DataSetRet(sql, "getorgsal")
            'ComboBox1.DataSource = ds.Tables("getorgsal")
            'ComboBox1.DisplayMember = "orgid"
            'ComboBox1.ValueMember = "organization"
            ComboBox1.Text = organization
        Catch ex As Exception

        End Try
        sql = "select department from DEPARTMENT WHERE ORGID='" & ComboBox1.Text & "'"
        globalmod.DataSetRet(Sql, "dept")
        ComboBox2.DataSource = ds.Tables("dept")
        ComboBox2.DisplayMember = "department"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sql As String

        Dim q As String
        globalmod.SqlExecuteNonQuery("drop table tt")
        q = " select *  into tt from (" _
        & " select p.*,d.department as d from (" _
        & " SELECT empmaster.fname department, EMPMASTER.name, " _
        & " EMPMASTER.accountno as acc, EMPSALARYtemp.*,EMPSALARYtemp.basic as basic1, " _
        & " ORGANIZATIONMASTER.orgid as organization FROM EMPMASTER INNER JOIN " _
        & " EMPSALARYtemp ON EMPMASTER.orgid = EMPSALARYtemp.orgid AND " _
        & " EMPMASTER.empid = EMPSALARYtemp.empid INNER JOIN ORGANIZATIONMASTER ON " _
        & " EMPMASTER.orgid = ORGANIZATIONMASTER.orgid " _
            & " where EMPSALARYtemp.orgid='" & organization & "'" _
        & " and EMPSALARYtemp.salmonth='" & DateTimePicker1.Value.ToShortDateString & "' ) p " _
        & " inner join empdepartment ed on ed.empid=p.empid and ed.orgid=p.orgid " _
        & " inner join department d on  d.depid=ed.depno and ed.orgid=d.orgid ) q "
        globalmod.SqlExecuteNonQuery(q)

        If TextBox1.Text = "" Then
            sql = "select department, name, acc, orgid, empid, salmonth, saldate, basic, amtpay, da, hra, cca, oa1, oa2, it, educease, proftax, collegeloan, lwp, remark, amt833, amt367, sheetno,  groupinsded, secudep, od1, paymode, basic1, organization, d as remark from tt "
        Else
            sql = "select department, name, acc, orgid, empid, salmonth, saldate, basic, amtpay, da, hra, cca, oa1, oa2, it, educease, proftax, collegeloan, lwp, remark, amt833, amt367, sheetno,  groupinsded, secudep, od1,  basic1, organization, d as paymode from tt  where empid='" & TextBox1.Text & "'"
        End If
      Dim dt As String
        dt = DateTimePicker1.Text
        ' dt = dt.Substring(3)
        globalmod.DataSetRet(sql, "salslip21")
        'MsgBox(ds.Tables("sa").Rows.Count)
        Dim crq As New CR_salary_slipold
        crq.SetDataSource(ds.Tables("salslip21"))
        crq.SetParameterValue("formonth", dt)
        CrystalReportViewer1.ReportSource = crq
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim sql As String
       
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub
End Class