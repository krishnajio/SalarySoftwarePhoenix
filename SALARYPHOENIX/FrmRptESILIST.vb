Public Class FrmRptESILIST

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim sql As String
            If globalmod.organization = "Phoenix Hatcheries" Then
                sql = "SELECT   EMPMASTER.name, salmonth, saldate, basic, amtpay, " _
                & " da, hra, cca, oa1, oa2, it, educease, proftax, collegeloan, " _
                & " lwp, amt833, amt367, sheetno, userid, groupinsded, secudep, od1" _
                & "  ,EMPMASTER.contactno [acc], convert(varchar,EMPMASTER.dob,106) [paymode]  FROM " _
                & " EMPMASTER INNER JOIN " _
                & tablename & " ON EMPMASTER.orgid = " & tablename & ".orgid AND " _
                & " EMPMASTER.empid = " & tablename & ".empid where salmonth=' " _
                & DateTimePicker1.Text & " ' and EMPMASTER.orgid='" & globalmod.organization & "'" _
                & " and (" & tablename & ".amt833>0 or " & tablename & ".amt367>0)"
            Else
                sql = "SELECT   EMPMASTER.name, salmonth, saldate, basic, amtpay, " _
                & " da, hra, cca, oa1, oa2, it, educease, proftax, collegeloan, " _
                & " lwp, amt833, amt367, sheetno, userid, groupinsded, secudep, od1" _
                & "  ,EMPMASTER.contactno [acc], convert(varchar,EMPMASTER.dob,106) [paymode] " _
                & " FROM  EMPMASTER INNER JOIN  " _
                & tablename & " ON EMPMASTER.orgid = " & tablename & ".orgid AND " _
                & " EMPMASTER.empid = " & tablename & ".empid where salmonth=' " _
                & DateTimePicker1.Text & " ' and EMPMASTER.orgid<>'Phoenix Hatcheries' and" _
                & "(" & tablename & ".amt833>0 or " & tablename & ".amt367>0)"
            End If

            globalmod.DataSetRet(sql, "pfcalclis")
            'Dim tot833, tot367, tot12, tot11, tot001, tot05 As Integer
            'tot833 = ds.Tables("pfcalc").Rows(0)(0)
            'tot367 = ds.Tables("pfcalc").Rows(0)(1)
            'tot12 = tot833 + tot367
            'tot11 = (tot12 * 1.1) * 0.01
            'tot001 = (tot12 * 0.01) * 0.01
            'tot05 = (tot12 * 0.5) * 0.01
            Dim crypfli As New RptPFLIST
            crypfli.SetDataSource(ds.Tables("pfcalclis"))
            crypfli.SetParameterValue("orgname", organization)
            crypfli.SetParameterValue("salmonth", DateTimePicker1.Text)
            CrystalReportViewer1.ReportSource = crypfli
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub FrmRptPFLIST_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class