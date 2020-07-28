Public Class frmform12

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            Dim sql As String
            If ComboBox1org.Text = "Phoenix Hatcheries" Then
                Dim sqlmy As String
                sqlmy = "select count(*)" _
                               & " from empmaster where empid   in (select empid from empsalary where " _
                                          & " empid not in  (select empid from empsalarytemp where  orgid='" & organization & "' and salmonth='" & DateTimePicker1.Text & "')" _
                                          & " and orgid='" & organization & "' and salmonth='" & CDate(DateTimePicker1.Text).AddMonths(-1) & "' ) and orgid='" & organization & "' and status=0 and len(empid)<>0"
                globalmod.DataSetRet(sqlmy, "getnewpflist")
                Dim sqlpf As String
                sqlpf = "select count(*) from empmaster where empid in (select empid from EMPSALARYTEMP " & "  where " _
                           & " empid not in (select empid from empsalary where  orgid='Phoenix Hatcheries') and orgid='Phoenix Hatcheries'" _
                           & ") and orgid='Phoenix Hatcheries'"
                globalmod.DataSetRet(sqlpf, "getnew")

                '    sql = "select count (* ) from " & tablename & " where salmonth=' " _
                '& DateTimePicker1.Text & "' and orgid<>'Phoenix Hatcheries' and " _
                '& " amt833>0 "
                '    globalmod.DataSetRet(sql, "empc")

                sql = "select count (* ) from " & tablename & " where salmonth=' " _
               & DateTimePicker1.Text & "' and orgid = 'Phoenix Hatcheries' and " _
               & " amt833>0 "
                globalmod.DataSetRet(sql, "empc1")

                sql = "select isnull(sum(amtpay),0)[basic], isnull(sum(amt833),0) as a833,isnull(sum(amt367),0) as a367 from " & tablename & " where salmonth=' " _
                            & DateTimePicker1.Text & "' and orgid='" & ComboBox1org.Text & "' and " _
                            & " (amt833>0 or amt367>0) "

                globalmod.DataSetRet(sql, "pfcalc")
                sql = "select isnull(sum(amtpay),0)[basic], isnull(sum(amt833),0) as a833,isnull(sum(amt367),0) as a367 from " & tablename & " where salmonth=' " _
                                         & DateTimePicker1.Text & "' and orgid='Phoenix Hatcheries' and " _
                                         & " (amt833>0) "

                globalmod.DataSetRet(sql, "pfcalc7")
                'tiw
                sql = "select count (* ) from " & tablename & " where salmonth=' " _
                & DateTimePicker1.Text & "' and orgid='" & ComboBox1org.Text & "' and " _
                & " (amt833>0 or amt367>0)"
                globalmod.DataSetRet(sql, "pfcalc1")
                Dim tot833, tot367, tot12, tot11, tot001, tot05 As Integer
                tot833 = ds.Tables("pfcalc").Rows(0)("a833")
                tot367 = ds.Tables("pfcalc").Rows(0)("a367")
                tot12 = tot833 + tot367
                tot11 = (CInt(ds.Tables("pfcalc").Rows(0)("basic")) * 1.1) * 0.01
                tot001 = ((CLng(ds.Tables("pfcalc").Rows(0)("basic")) * 0.05) * 0.01)

                tot05 = (CInt(ds.Tables("pfcalc").Rows(0)("basic")) * 0.5) * 0.01
                Dim crypf As New CRForm12
                crypf.SetParameterValue("am833", tot833)
                crypf.SetParameterValue("basic", ds.Tables("pfcalc").Rows(0)("basic"))
                crypf.SetParameterValue("am367", tot367)
                crypf.SetParameterValue("amt11", tot11)
                crypf.SetParameterValue("tot12", tot12)
                crypf.SetParameterValue("tot05", tot05)
                crypf.SetParameterValue("tot001", tot001)
                crypf.SetParameterValue("empcnt", globalmod.ds.Tables("pfcalc1").Rows(0)(0))
                crypf.SetParameterValue("orgname", globalmod.organization)
                crypf.SetParameterValue("salmonth", DateTimePicker1.Text)
                crypf.SetParameterValue("tiwgor", ds.Tables("pfcalc7").Rows(0)("basic"))
                crypf.SetParameterValue("emp", globalmod.ds.Tables("empc1").Rows(0)(0))
                crypf.SetParameterValue("empcount", globalmod.ds.Tables("getnewpflist").Rows(0)(0))
                crypf.SetParameterValue("empgf", globalmod.ds.Tables("getnew").Rows(0)(0))
                CrystalReportViewer1.ReportSource = crypf
            Else
                Dim sqlpf As String
                sqlpf = "select count(*) from empmaster where empid in (select empid from EMPSALARYTEMP " & "  where " _
                         & " empid not in (select empid from empsalary where  orgid <> 'Phoenix Hatcheries') and orgid <> 'Phoenix Hatcheries'" _
                         & ") and orgid <> 'Phoenix Hatcheries'"
                globalmod.DataSetRet(sqlpf, "getnew")

                Dim sqlmy As String
                sqlmy = "select count(*) " _
             & " from empmaster where empid   in (select empid from empsalary where " _
                     & " empid not in  (select empid from empsalarytemp where  orgid<>'" & "Phoenix Hatcheries" & "' and salmonth='" & DateTimePicker1.Text & "')" _
                          & " and orgid<>'" & "Phoenix Hatcheries" & "' and salmonth='" _
                          & CDate(DateTimePicker1.Text).AddMonths(-1) & "' and  amtpay>0) and orgid<>'" & "Phoenix Hatcheries" & " ' and status=0 and len(empid)<>0"

                globalmod.DataSetRet(sqlmy, "getnewpflist")

                sql = "select count (* ) from " & tablename & " where salmonth=' " _
                            & DateTimePicker1.Text & "' and orgid<>'Phoenix Hatcheries' and " _
                            & " amt833>0 "
                globalmod.DataSetRet(sql, "empc")


                sql = "select isnull(sum(amtpay),0)[basic], isnull(sum(amt833),0) as a833,isnull(sum(amt367),0) as a367 from " & tablename & " where salmonth=' " _
                            & DateTimePicker1.Text & "' and orgid<>'Phoenix Hatcheries' and " _
                            & " (amt833>0 or amt367>0) "

                globalmod.DataSetRet(sql, "pfcalc")



                'tiw
                sql = "select isnull(sum(amtpay),0)[basic], isnull(sum(amt833),0) as a833,isnull(sum(amt367),0) as a367 from " & tablename & " where salmonth=' " _
                           & DateTimePicker1.Text & "' and orgid<>'Phoenix Hatcheries' and " _
                           & " (amt833>0) "

                globalmod.DataSetRet(sql, "pfcalc3")
                'tiw

                sql = "select count (* ) from " & tablename & " where salmonth=' " _
                & DateTimePicker1.Text & "' and orgid<>'Phoenix Hatcheries' and " _
                & " (amt833>0 or amt367>0) "
                globalmod.DataSetRet(sql, "pfcalc1")
                Dim tot833, tot367, tot12, tot11, tot001, tot05 As Integer
                tot833 = ds.Tables("pfcalc").Rows(0)("a833")
                tot367 = ds.Tables("pfcalc").Rows(0)("a367")
                tot12 = tot833 + tot367
                tot11 = (CInt(ds.Tables("pfcalc").Rows(0)("basic")) * 1.1) * 0.01
                tot001 = ((CLng(ds.Tables("pfcalc").Rows(0)("basic")) * 0.05) * 0.01)

                tot05 = (CInt(ds.Tables("pfcalc").Rows(0)("basic")) * 0.5) * 0.01
                Dim crypf As New CRForm12
                crypf.SetParameterValue("am833", tot833)
                crypf.SetParameterValue("basic", ds.Tables("pfcalc").Rows(0)("basic"))
                crypf.SetParameterValue("am367", tot367)
                crypf.SetParameterValue("amt11", tot11)
                crypf.SetParameterValue("tot12", tot12)
                crypf.SetParameterValue("tot05", tot05)
                crypf.SetParameterValue("tot001", tot001)
                crypf.SetParameterValue("empcnt", globalmod.ds.Tables("pfcalc1").Rows(0)(0))
                crypf.SetParameterValue("orgname", globalmod.organization)
                crypf.SetParameterValue("salmonth", DateTimePicker1.Text)
                crypf.SetParameterValue("tiwgor", ds.Tables("pfcalc3").Rows(0)("basic"))
                crypf.SetParameterValue("emp", globalmod.ds.Tables("empc").Rows(0)(0))
                crypf.SetParameterValue("empcount", globalmod.ds.Tables("getnewpflist").Rows(0)(0))
                crypf.SetParameterValue("empgf", globalmod.ds.Tables("getnew").Rows(0)(0))
                CrystalReportViewer1.ReportSource = crypf
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmform12_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String
        sql = "select orgid from organizationmaster"
        globalmod.DataSetRet(sql, "or")
        ComboBox1org.DataSource = ds.Tables("or")
        ComboBox1org.DisplayMember = "orgid"

    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class