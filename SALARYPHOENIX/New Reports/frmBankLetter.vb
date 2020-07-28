Public Class frmBankLetter

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

       
            Dim sql As String
            sql = "select orgid,left(accountno,3) bank ,salmonth,sum((amtpay+da+hra+cca+oa1+oa2)-(it+educease+collegeloan+amt833+amt367+groupinsded+secudep+od1+proftax)) netsal" _
                  & " from vSalAll group by left(accountno,3),salmonth,orgid " _
                   & " having salmonth ='" & DateTimePicker1.Value.ToShortDateString() & "' and left(accountno,3)='" & ComboBox2.Text & "' and orgid<>'Phoenix Hatcheries'"

            globalmod.DataSetRet(sql, "boi")
            'MsgBox(ds.Tables("sa").Rows.Count)


            If ComboBox2.Text = "BOI" Then
                Dim crq As New CrBOILetter
                crq.SetParameterValue("p1", Val(globalmod.ds.Tables("BOI").Rows(0)("netsal")))
                CrystalReportViewer1.ReportSource = crq
            ElseIf ComboBox2.Text = "SBI" Then
                Dim crq As New CrSBILetter
                crq.SetParameterValue("p1", Val(globalmod.ds.Tables("BOI").Rows(0)("netsal")))
                CrystalReportViewer1.ReportSource = crq
            ElseIf ComboBox2.Text = "CBI" Then
                Dim crq As New CrCBILetter
                crq.SetParameterValue("p1", Val(globalmod.ds.Tables("BOI").Rows(0)("netsal")))
                CrystalReportViewer1.ReportSource = crq
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class