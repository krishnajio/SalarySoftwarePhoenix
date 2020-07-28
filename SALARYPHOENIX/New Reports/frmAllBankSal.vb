Public Class frmAllBankSal

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sql As String
        sql = "select orgid,left(accountno,3) bank ,salmonth,sum((amtpay+da+hra+cca+oa2+oa1)-(it+educease+collegeloan+amt833+amt367+groupinsded+secudep+od1+proftax)) netsal" _
              & " from vSalAll group by left(accountno,3),salmonth,orgid " _
               & " having salmonth ='" & DateTimePicker1.Value.ToShortDateString() & "'  and orgid<>'Phoenix Hatcheries'"
        globalmod.DataSetRet(sql, "allbank")
        'MsgBox(ds.Tables("sa").Rows.Count)
        Dim crq As New CrAllBank
        crq.SetDataSource(ds.Tables("allbank"))
        ' crq.SetParameterValue("orgname", organization)
        crq.SetParameterValue("p1", "SALARY MONTH:" & DateTimePicker1.Text)
        CrystalReportViewer1.ReportSource = crq
    End Sub
End Class