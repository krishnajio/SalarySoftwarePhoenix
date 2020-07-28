Public Class rptform5

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim sql As String
            If organization = "Phoenix Hatcheries" Then
                sql = "select * from empmaster where empid in (select empid from EMPSALARYTEMP " & "  where " _
                           & " empid not in (select empid from empsalary where  orgid='Phoenix Hatcheries') and orgid='Phoenix Hatcheries'" _
                           & ") and orgid='Phoenix Hatcheries'"
                globalmod.DataSetRet(sql, "getnewpflist")
            Else
                sql = "select * from empmaster where empid in (select empid from EMPSALARYTEMP " & "  where " _
                          & " empid not in (select empid from empsalary where  orgid <> 'Phoenix Hatcheries') and orgid <> 'Phoenix Hatcheries'" _
                          & ") and orgid <> 'Phoenix Hatcheries'"
                globalmod.DataSetRet(sql, "getnewpflist")
            End If



            'Dim tot833, tot367, tot12, tot11, tot001, tot05 As Integer
            'tot833 = ds.Tables("pfcalc").Rows(0)(0)
            'tot367 = ds.Tables("pfcalc").Rows(0)(1)
            'tot12 = tot833 + tot367
            'tot11 = (tot12 * 1.1) * 0.01
            'tot001 = (tot12 * 0.01) * 0.01
            'tot05 = (tot12 * 0.5) * 0.01
            Dim crypfli5 As New CRForm5


            crypfli5.SetDataSource(ds.Tables("getnewpflist"))
            crypfli5.SetParameterValue("salmonth", DateTimePicker1.Text)
            crypfli5.SetParameterValue("orgname", globalmod.organization)
            CrystalReportViewer1.ReportSource = crypfli5

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class