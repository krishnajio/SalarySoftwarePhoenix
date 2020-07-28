
Public Class FrmBonusRpt

    Private Sub FrmBonusRpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        globalmod.DataSetRet("select distinct orgid from EMPSALARY", "CmbOrgId")
        CmbOrgId.DataSource = ds.Tables("CmbOrgId")
        CmbOrgId.DisplayMember = "orgid"
    End Sub

    Private Sub TxtSession_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtSession.Leave
        Try
            dtpFrom.Value = "04/01/" & Mid(Val(TxtSession.Text), 1, 2)
        Catch ex As Exception
            MsgBox("Enter session in like '1112' ")
            TxtSession.Focus()
        End Try
    End Sub
    Sub phoephha()
        Dim sqlsave As String
        Try
            Dim sql As String = "delete from TmpBonus"
            Dim str As String = globalmod.SqlExecuteNonQuery(sql)
            If str = "Success" Then

                sql = "select empid,name,orgid from EMPMASTER where status=1  and orgid= '" & CmbOrgId.Text & "'"
                globalmod.DataSetRet(sql, "fillEmp")
                Dim i As Integer = 0
                For i = 0 To globalmod.ds.Tables("fillEmp").Rows.Count - 1
                    sqlsave = "insert into TmpBonus(empid,empname,orgid) values( "
                    sqlsave += "'" & globalmod.ds.Tables("fillEmp").Rows(i)("empid").ToString & "',"
                    sqlsave += "'" & globalmod.ds.Tables("fillEmp").Rows(i)("name").ToString & "',"
                    sqlsave += "'" & globalmod.ds.Tables("fillEmp").Rows(i)("orgid").ToString & "')"
                    globalmod.SqlExecuteNonQuery(sqlsave)
                Next
                Dim j, k, m As Integer
                sql = "select empid,depno,orgid from EMPDEPARTMENT where orgid='" & CmbOrgId.Text & "'"
                globalmod.DataSetRet(sql, "filldeptno")
                For m = 0 To globalmod.ds.Tables("filldeptno").Rows.Count - 1
                    sqlsave = "update TmpBonus set "
                    sqlsave += "depno = " & globalmod.ds.Tables("filldeptno").Rows(m)("depno").ToString
                    sqlsave += " where orgid= '" & globalmod.ds.Tables("filldeptno").Rows(m)("orgid").ToString & "' and "
                    sqlsave += "empid= '" & globalmod.ds.Tables("filldeptno").Rows(m)("empid").ToString & "' "
                    globalmod.SqlExecuteNonQuery(sqlsave)
                Next

                For j = 1 To 12
                    sql = " select orgid, empid, salmonth, isnull(amtpay,0) "
                    'sql += " isnull(cca,0)+isnull(oa1,0)+isnull(oa2,0)-isnull(it,0)-isnull(educease,0)"
                    'sql += " -isnull(proftax,0)-isnull(collegeloan,0)+isnull(amt833,0)+isnull(amt367,0) -"
                    'sql += "(2*(isnull(amt833,0)+isnull(amt367,0)))-"
                    sql += "salary from EMPSALARY "
                    sql += " where salmonth='" & dtpFrom.Value.ToShortDateString & "'and orgid= '" & CmbOrgId.Text & "'"
                    'MsgBox(dtpFrom.Value.ToShortDateString)
                    globalmod.DataSetRet(sql, "filldata")
                    For k = 0 To globalmod.ds.Tables("filldata").Rows.Count - 1
                        sqlsave = "update TmpBonus set "
                        sqlsave += "[" & j.ToString & "] = " & globalmod.ds.Tables("filldata").Rows(k)("salary").ToString
                        sqlsave += " where orgid= '" & globalmod.ds.Tables("filldata").Rows(k)("orgid").ToString & "' and "
                        sqlsave += "empid= '" & globalmod.ds.Tables("filldata").Rows(k)("empid").ToString & "' "
                        globalmod.SqlExecuteNonQuery(sqlsave)
                    Next
                    dtpFrom.Value = dtpFrom.Value.AddMonths(1)
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Sub filltemp()
        Dim sqlsave As String
        Try
            Dim sql As String = "delete from TmpBonus"
            Dim str As String = globalmod.SqlExecuteNonQuery(sql)
            If str = "Success" Then

                sql = "select empid,name,orgid from EMPMASTER where status=1  and orgid= '" & CmbOrgId.Text & "'"
                globalmod.DataSetRet(sql, "fillEmp")
                Dim i As Integer = 0
                For i = 0 To globalmod.ds.Tables("fillEmp").Rows.Count - 1
                    sqlsave = "insert into TmpBonus(empid,empname,orgid) values( "
                    sqlsave += "'" & globalmod.ds.Tables("fillEmp").Rows(i)("empid").ToString & "',"
                    sqlsave += "'" & globalmod.ds.Tables("fillEmp").Rows(i)("name").ToString & "',"
                    sqlsave += "'" & globalmod.ds.Tables("fillEmp").Rows(i)("orgid").ToString & "')"
                    globalmod.SqlExecuteNonQuery(sqlsave)
                Next
                Dim j, k, m As Integer
                sql = "select empid,depno,orgid from EMPDEPARTMENT where orgid='" & CmbOrgId.Text & "'"
                globalmod.DataSetRet(sql, "filldeptno")
                For m = 0 To globalmod.ds.Tables("filldeptno").Rows.Count - 1
                    sqlsave = "update TmpBonus set "
                    sqlsave += "depno = " & globalmod.ds.Tables("filldeptno").Rows(m)("depno").ToString
                    sqlsave += " where orgid= '" & globalmod.ds.Tables("filldeptno").Rows(m)("orgid").ToString & "' and "
                    sqlsave += "empid= '" & globalmod.ds.Tables("filldeptno").Rows(m)("empid").ToString & "' "
                    globalmod.SqlExecuteNonQuery(sqlsave)
                Next

                For j = 1 To 12
                    sql = " select orgid, empid, salmonth, (isnull(amtpay,0)+isnull(da,0)+isnull(hra,0)+"
                    sql += " isnull(cca,0)+isnull(oa1,0)+isnull(oa2,0)-isnull(it,0)-isnull(educease,0)"
                    sql += " -isnull(0,0)-isnull(0,0)+isnull(amt833,0)+isnull(amt367,0) -"
                    sql += "(2*(isnull(amt833,0)+isnull(amt367,0)))-"
                    sql += " isnull(groupinsded,0)-isnull(secudep,0)-isnull(0,0)) salary from EMPSALARY"
                    sql += " where salmonth='" & dtpFrom.Value.ToShortDateString & "'and orgid= '" & CmbOrgId.Text & "'"
                    'MsgBox(dtpFrom.Value.ToShortDateString)
                    globalmod.DataSetRet(sql, "filldata")
                    For k = 0 To globalmod.ds.Tables("filldata").Rows.Count - 1
                        sqlsave = "update TmpBonus set "
                        sqlsave += "[" & j.ToString & "] = " & globalmod.ds.Tables("filldata").Rows(k)("salary").ToString
                        sqlsave += " where orgid= '" & globalmod.ds.Tables("filldata").Rows(k)("orgid").ToString & "' and "
                        sqlsave += "empid= '" & globalmod.ds.Tables("filldata").Rows(k)("empid").ToString & "' "
                        globalmod.SqlExecuteNonQuery(sqlsave)
                    Next
                    dtpFrom.Value = dtpFrom.Value.AddMonths(1)
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnShow.Click
        If CmbOrgId.Text = "Phoenix Poultry" Then
            phoephha()
        ElseIf CmbOrgId.Text = "Phoenix Hatcheries" Then
            phoephha()
        Else
            filltemp()
        End If


        dtpFrom.Value = "04/01/" & Mid(Val(TxtSession.Text), 1, 2)
        Dim sql As String = "select a.*,b.department from TmpBonus a left join DEPARTMENT b "
        sql += " on(a.orgid=b.orgid and a.depno=b.depid)  order by total desc"
        globalmod.DataSetRet(sql, "rptbonus")
        Dim r As New CrBonus
        r.SetDataSource(globalmod.ds.Tables("rptbonus"))
        r.SetParameterValue("forsession", TxtSession.Text)
        CrystalReportViewer1.ReportSource = r
    End Sub
End Class