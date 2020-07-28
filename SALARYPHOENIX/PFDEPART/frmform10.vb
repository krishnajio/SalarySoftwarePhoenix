Public Class frmform10

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim sql As String
            If globalmod.organization = "Phoenix Hatcheries" Then
                sql = "select empid, name, fname, mname,  doj, gender, empcaste, category, religion, joinpost [dob]," _
                & " qualification1, qualification2, localadd, peradd, bloodgroup, contactno, accountno, photo, status," _
                & " remark, orgid from empmaster where empid   in (select empid from empsalary where " _
                           & " empid not in  (select empid from empsalarytemp where  orgid='" & organization & "' and salmonth='" & DateTimePicker1.Text & "')" _
                           & " and orgid='" & organization & "' and salmonth='" & CDate(DateTimePicker1.Text).AddMonths(-1) & "' ) and orgid='" & organization & "' and status=0 and len(empid)<>0"
            Else

                sql = "select empid, name, fname, mname,  doj, gender, empcaste, category, religion, joinpost [dob]," _
                & " qualification1, qualification2, localadd, peradd, bloodgroup, contactno, accountno, photo, status," _
                & " remark, orgid from empmaster where empid   in (select empid from empsalary where " _
                        & " empid not in  (select empid from empsalarytemp where  orgid<>'" & "Phoenix Hatcheries" & "' and salmonth='" & DateTimePicker1.Text & "')" _
                             & " and orgid<>'" & "Phoenix Hatcheries" & "' and salmonth='" _
                             & CDate(DateTimePicker1.Text).AddMonths(-1) & "' and  amtpay>0) and orgid<>'" & "Phoenix Hatcheries" & " ' and status=0 and len(empid)<>0"
            
            End If

            'sql = "select * from empmaster where empid not  in (select empid from " & tablename & " where " _
            '& " empid in (select empid from empsalary where  orgid='" & globalmod.organization & "' and salmonth='" _
            '& DateTimePicker1.Value.AddMonths(-1) & "' )and orgid='" & globalmod.organization _
            '& "' ) and orgid='" & globalmod.organization & "' "
            'sql = "select * from empmaster where empid not  in (select empid from empsalarytemp where" _
            '& "  empid in (select empid from empsalary where  orgid='" & organization _
            '& "' and salmonth='" & DateTimePicker1.Value.AddMonths(-1) & "' )and orgid='" _
            '& organization & "') and orgid='" & organization & "' and status=0" _
            '& " and len(empid)<>0"


            globalmod.DataSetRet(sql, "getnewpflist")

            'Dim tot833, tot367, tot12, tot11, tot001, tot05 As Integer
            'tot833 = ds.Tables("pfcalc").Rows(0)(0)
            'tot367 = ds.Tables("pfcalc").Rows(0)(1)
            'tot12 = tot833 + tot367
            'tot11 = (tot12 * 1.1) * 0.01
            'tot001 = (tot12 * 0.01) * 0.01
            'tot05 = (tot12 * 0.5) * 0.01
            Dim crypfli5 As New CRForm10


            crypfli5.SetDataSource(ds.Tables("getnewpflist"))
            crypfli5.SetParameterValue("salmonth", DateTimePicker1.Text)
            crypfli5.SetParameterValue("orgname", globalmod.organization)
            CrystalReportViewer1.ReportSource = crypfli5

        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmform10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String
        sql = "select orgid from organizationmaster"
        globalmod.DataSetRet(sql, "or")
        ComboBox1org.DataSource = ds.Tables("or")
        ComboBox1org.DisplayMember = "orgid"

    End Sub
End Class