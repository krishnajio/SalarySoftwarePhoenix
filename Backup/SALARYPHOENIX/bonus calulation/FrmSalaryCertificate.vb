Public Class FrmSalaryCertificate

    Private Sub FrmSalaryCertificate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'DtpFrom.MinDate = "04/01/" & Mid(globalmod.session, 1, 2)
        'DtpFrom.MaxDate = "03/31/" & Mid(globalmod.session, 3, 4)
        'DtpTo.MinDate = "04/01/" & Mid(globalmod.session, 1, 2)
        'DtpTo.MaxDate = "03/31/" & Mid(globalmod.session, 3, 4)

        '        select s.EmpID,e.Name,e.Department,e.JoinPost,sum(s.grossSalary),sum(s.totalded),sum(s.netpay)
        ' from EmpSalary s,EmpMaster e
        'where  s.salmonth between '1/01/2012' and '4/30/2012' and  s.EmpID= e.EmpID and s.OrgId='Org001'
        'group by s.EmpID,e.Name,e.Department,e.JoinPost

       
        globalmod.DataSetRet("select EmpID,Name from EMPMASTER where orgId='" & globalmod.organization & "'", "cmbName")
        CmbEmp.DataSource = ds.Tables("cmbName")
        CmbEmp.DisplayMember = "Name"
        CmbEmpCode.DataSource = ds.Tables("cmbName")
        CmbEmpCode.DisplayMember = "EmpID"
    End Sub

    Public Function getyear(ByVal d As Date) As String
        If d.Month > 3 Then
            Return d.Year & " - " & Format((d.Year + 1), "0000")
        Else
            Return Format((d.Year - 1), "0000") & " - " & d.Year
        End If
    End Function

    Private Sub BtnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnShow.Click
        Dim y1 As String = getyear(DtpTo.Value)
        'MsgBox("y1=" & y1)       
        Dim sql1 As String = "select orgid,address,city,state from ORGANIZATIONMASTER where orgid='" & globalmod.organization & "' "
        globalmod.DataSetRet(sql1, "address")
        Dim address As String = globalmod.ds.Tables("address").Rows(0)("address") & ","
        address += " " & globalmod.ds.Tables("address").Rows(0)("city") & ","
        address += " " & globalmod.ds.Tables("address").Rows(0)("state")
        If ChkAll.Checked = True Then
            Dim sql As String = "select e.name,e.doj,e.joinpost, s.EmpID,s.orgid,sum(isnull(amtpay,0)+isnull(da,0)+isnull(hra,0)+isnull(cca,0)+isnull(oa1,0)+isnull(oa2,0)) "
            sql += " as grossSalary,"
            sql += " sum ((isnull(amt833,0)+isnull(amt367,0))) as epfded,sum(proftax) as tax,sum(it) as tdsded,sum(isnull(proftax,0)+isnull(it,0)+isnull(0,0)+isnull(groupinsded,0)+isnull(secudep,0)+isnull(od1,0) +  ((isnull(amt833,0)+isnull(amt367,0)))) "
            sql += " as totalded,SUM(groupinsded) groupinsuranceded from EMPSALARY s,dbo.EMPMASTER e  where "
            sql += " s.OrgId='" & globalmod.organization & "'  and salmonth between '" & DtpFrom.Value.ToShortDateString & "' and '" & DtpTo.Value.ToShortDateString & "' and "
            sql += " s.OrgId = e.OrgId And s.empid = e.empid"
            sql += " group by e.name,e.doj,e.joinpost, s.EmpID,s.orgid"

            globalmod.DataSetRet(sql, "salaryCer1")
            Dim r As New CrSalaryCertificate
            r.SetDataSource(globalmod.ds.Tables("salaryCer1"))
            r.SetParameterValue("fromdate", DtpFrom.Value.ToShortDateString)
            r.SetParameterValue("todate", DtpTo.Value.ToShortDateString)
            r.SetParameterValue("year", y1)
            r.SetParameterValue("address", address)
            CrystalReportViewer1.ReportSource = r
        Else
            'Dim sql As String = "select e.name,e.doj,e.joinpost, s.EmpID,s.orgid,sum(isnull(amtpay,0)+isnull(da,0)+isnull(hra,0)+isnull(cca,0)+isnull(oa1,0)+isnull(oa2,0)) "
            'sql += " as grossSalary,"
            'sql += " sum ((isnull(amt833,0)+isnull(amt367,0))) as epfded,sum(proftax) as tax,sum(it) as tdsded,sum(isnull(proftax,0)+isnull(it,0)+isnull(0,0)+isnull(groupinsded,0)+isnull(secudep,0)+isnull(od1,0) +  ((isnull(amt833,0)+isnull(amt367,0)))) "
            'sql += " as totalded,SUM(groupinsded) groupinsuranceded from EMPSALARYtemp s,dbo.EMPMASTER e  where "
            'sql += " and s.EmpId='" & CmbEmpCode.Text & "'  and salmonth between '" & DtpFrom.Value.ToShortDateString & "' and '" & DtpTo.Value.ToShortDateString & "' and "
            'sql += " s.OrgId = e.OrgId And s.empid = e.empid   "
            'sql += " group by e.name,e.doj,e.joinpost, s.EmpID,s.orgid"
            Dim sql As String
            If RadioButton1.Enabled = True Then
                sql = "select s.EmpID,sum(isnull(amtpay,0)+isnull(da,0)+isnull(hra,0)+isnull(cca,0)+isnull(oa1,0)+isnull(oa2,0))  "
                sql += " as grossSalary,"
                sql += " sum ((isnull(amt833,0)+isnull(amt367,0))) as epfded,sum(proftax) as tax,sum(it) as tdsded,sum(isnull(proftax,0)+isnull(it,0)+isnull(0,0)+isnull(groupinsded,0)+isnull(secudep,0)+isnull(od1,0) +  ((isnull(amt833,0)+isnull(amt367,0)))) "
                sql += " as totalded,SUM(groupinsded) groupinsuranceded from EMPSALARYtemp s where "
                sql += " s.EmpId='" & CmbEmpCode.Text & "'  and salmonth between '" & DtpFrom.Value.ToShortDateString & "' and '" & DtpTo.Value.ToShortDateString & "' and s.orgid ='Phoenix Hatcheries'"
                sql += " group by  s.EmpID"
            End If


            If RadioButton2.Enabled = True Then
                sql = "select s.EmpID,sum(isnull(amtpay,0)+isnull(da,0)+isnull(hra,0)+isnull(cca,0)+isnull(oa1,0)+isnull(oa2,0)) "
                sql += " as grossSalary,"
                sql += " sum ((isnull(amt833,0)+isnull(amt367,0))) as epfded,sum(proftax) as tax,sum(it) as tdsded,sum(isnull(proftax,0)+isnull(it,0)+isnull(0,0)+isnull(groupinsded,0)+isnull(secudep,0)+isnull(od1,0) +  ((isnull(amt833,0)+isnull(amt367,0)))) "
                sql += " as totalded,SUM(groupinsded) groupinsuranceded from EMPSALARYtemp s where "
                sql += " s.EmpId='" & CmbEmpCode.Text & "'  and salmonth between '" & DtpFrom.Value.ToShortDateString & "' and '" & DtpTo.Value.ToShortDateString & "'  and s.orgid <>'Phoenix Hatcheries'"
                sql += " group by  s.EmpID"
            End If


            globalmod.DataSetRet(Sql, "salaryCer")
            Dim r As New CrSalaryCertificate
            r.SetDataSource(globalmod.ds.Tables("salaryCer"))
            r.SetParameterValue("fromdate", DtpFrom.Value.ToShortDateString)
            r.SetParameterValue("todate", DtpTo.Value.ToShortDateString)
            r.SetParameterValue("year", y1)
            r.SetParameterValue("address", address)
            r.SetParameterValue("nn", CmbEmp.Text)
            CrystalReportViewer1.ReportSource = r
            End If
    End Sub
    Private Sub CmbEmp_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbEmp.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub DtpFrom_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DtpFrom.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub DtpTo_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DtpTo.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
End Class