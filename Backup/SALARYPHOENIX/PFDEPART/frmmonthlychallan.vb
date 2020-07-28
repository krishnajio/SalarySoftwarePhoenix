Public Class frmmonthlychallan

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim sql As String
            If organization = "Phoenix Hatcheries" Then
                sql = "select isnull(sum(amtpay),0)[basic], isnull(sum(amt833),0) as a833,isnull(sum(amt367),0) as a367 from " & tablename & " where salmonth=' " _
                           & DateTimePicker1.Text & "' and orgid='" & globalmod.organization & "' and " _
                           & " (amt833>0 or amt367>0) "
                globalmod.DataSetRet(sql, "pfcalc")
                sql = "select isnull(sum(amtpay),0)[basic], isnull(sum(amt833),0) as a833,isnull(sum(amt367),0) as a367 from " & tablename & " where salmonth=' " _
                                           & DateTimePicker1.Text & "' and orgid='Phoenix Hatcheries' and amt833>0"
                globalmod.DataSetRet(sql, "totpf3")


                Dim tot833, tot367, tot12, tot11, tot001, tot05 As Integer
                tot833 = ds.Tables("pfcalc").Rows(0)("a833")
                tot367 = ds.Tables("pfcalc").Rows(0)("a367")
                tot12 = tot833 + tot367
                tot11 = (CInt(ds.Tables("pfcalc").Rows(0)("basic")) * 1.1) * 0.01
                tot001 = ((CLng(ds.Tables("pfcalc").Rows(0)("basic")) * 0.05) * 0.01)

                tot05 = (CInt(ds.Tables("pfcalc").Rows(0)("basic")) * 0.5) * 0.01

                sql = "select count (* ) from " & tablename & " where salmonth=' " _
                & DateTimePicker1.Text & "' and orgid='Phoenix Hatcheries'" & " and " _
                & " amt367>0 "
                globalmod.DataSetRet(sql, "pfcalc1")

                sql = "select count (* ) from " & tablename & " where salmonth=' " _
               & DateTimePicker1.Text & "' and orgid = 'Phoenix Hatcheries' and " _
               & " amt833>0 "
                globalmod.DataSetRet(sql, "empc1")


                Dim crypf As New CRPFNEW
                crypf.SetParameterValue("am833", tot833)
                crypf.SetParameterValue("basic", ds.Tables("pfcalc").Rows(0)("basic"))
                crypf.SetParameterValue("am367", tot367)
                crypf.SetParameterValue("amt11", tot11)
                crypf.SetParameterValue("tot12", tot12)
                crypf.SetParameterValue("tot05", tot05)
                crypf.SetParameterValue("tot001", tot001)
                crypf.SetParameterValue("orgname", globalmod.organization)
                crypf.SetParameterValue("salmonth", DateTimePicker1.Text)
                crypf.SetParameterValue("empcnt", globalmod.ds.Tables("pfcalc1").Rows(0)(0))
                crypf.SetParameterValue("totpf", globalmod.ds.Tables("totpf3").Rows(0)(0))
                crypf.SetParameterValue("emp", globalmod.ds.Tables("empc1").Rows(0)(0))


                CrystalReportViewer1.ReportSource = crypf
            Else
                sql = "select isnull(sum(amtpay),0)[basic], isnull(sum(amt833),0) as a833,isnull(sum(amt367),0) as a367 from " & tablename & " where salmonth=' " _
                                           & DateTimePicker1.Text & "' and orgid<>'Phoenix Hatcheries' and " _
                                           & " (amt833>0 or amt367>0) "
                globalmod.DataSetRet(sql, "pfcalc")


                'total(fund)
                sql = "select isnull(sum(amtpay),0)[basic], isnull(sum(amt833),0) as a833,isnull(sum(amt367),0) as a367 from " & tablename & " where salmonth=' " _
                           & DateTimePicker1.Text & "' and orgid<>'Phoenix Hatcheries' and amt833>0"
                globalmod.DataSetRet(sql, "totpf4")


                Dim tot833, tot367, tot12, tot11, tot001, tot05 As Integer
                tot833 = ds.Tables("pfcalc").Rows(0)("a833")
                tot367 = ds.Tables("pfcalc").Rows(0)("a367")
                tot12 = tot833 + tot367
                tot11 = (CInt(ds.Tables("pfcalc").Rows(0)("basic")) * 1.1) * 0.01
                tot001 = ((CLng(ds.Tables("pfcalc").Rows(0)("basic")) * 0.05) * 0.01)

                tot05 = (CInt(ds.Tables("pfcalc").Rows(0)("basic")) * 0.5) * 0.01

                sql = "select count (* ) from " & tablename & " where salmonth=' " _
                & DateTimePicker1.Text & "' and orgid<>'Phoenix Hatcheries' and " _
                & " amt367>0 "
                globalmod.DataSetRet(sql, "pfcalc1")

                'empcounting
                sql = "select count (* ) from " & tablename & " where salmonth=' " _
               & DateTimePicker1.Text & "' and orgid<>'Phoenix Hatcheries' and " _
               & " amt833>0 "
                globalmod.DataSetRet(sql, "empc")

                Dim crypf As New CRPFNEW
                crypf.SetParameterValue("am833", tot833)
                crypf.SetParameterValue("basic", ds.Tables("pfcalc").Rows(0)("basic"))
                crypf.SetParameterValue("am367", tot367)
                crypf.SetParameterValue("amt11", tot11)
                crypf.SetParameterValue("tot12", tot12)
                crypf.SetParameterValue("tot05", tot05)
                crypf.SetParameterValue("tot001", tot001)
                crypf.SetParameterValue("orgname", globalmod.organization)
                crypf.SetParameterValue("salmonth", DateTimePicker1.Text)
                crypf.SetParameterValue("empcnt", globalmod.ds.Tables("pfcalc1").Rows(0)(0))
                crypf.SetParameterValue("emp", globalmod.ds.Tables("empc").Rows(0)(0))
                crypf.SetParameterValue("totpf", globalmod.ds.Tables("totpf4").Rows(0)(0))

                CrystalReportViewer1.ReportSource = crypf

            End If

        Catch ex As Exception

        End Try
       
    End Sub

    Private Sub frmmonthlychallan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String
        sql = "select orgid from organizationmaster"
        globalmod.DataSetRet(sql, "or")
        ComboBox1org.DataSource = ds.Tables("or")
        ComboBox1org.DisplayMember = "orgid"

    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class