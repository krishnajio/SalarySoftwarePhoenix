Public Class frmesirept

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim sql As String
            Dim headname As String = ""
            If ComboBox2.Text = "GROUP INSURANCE" Then
                headname = "groupinsded"
            Else
                headname = "oa1"
            End If

            sql = "SELECT dbo.EMPMASTER.name   , dbo.ORGANIZATIONMASTER.organization," _
                   & tablename & ".basic basic," & tablename & ".amtpay amtpay, " & tablename & ".hra," & tablename & ".cca," _
                   & tablename & "." & headname & " [oa1] , " & tablename & ".oa2, " & tablename & ".it," _
                   & tablename & ".educease," & tablename & ".proftax," _
                   & tablename & ".collegeloan, " & tablename & ".lwp," _
                   & tablename & ".remark," & tablename & ".amt833, " _
                   & tablename & ".amt367, " & tablename & ".groupinsded," _
                   & tablename & ".secudep," & tablename & ".od1, " & tablename & ".paymode," _
                   & " dbo.EMPMASTER.empid, dbo.DEPARTMENT.department,substring(contactno,9,4) [acc] FROM dbo.EMPMASTER INNER JOIN" _
                   & " dbo.ORGANIZATIONMASTER INNER JOIN " & tablename & " ON dbo.ORGANIZATIONMASTER.orgid = " & tablename & ".orgid ON " _
                   & " dbo.EMPMASTER.empid = " & tablename & ".empid and    EMPMASTER.orgid =" & tablename & ".orgid  INNER JOIN" _
                   & " dbo.EMPDEPARTMENT ON dbo.EMPMASTER.empid = dbo.EMPDEPARTMENT.empid AND " _
                   & " dbo.ORGANIZATIONMASTER.orgid = dbo.EMPDEPARTMENT.orgid INNER JOIN" _
                   & " dbo.DEPARTMENT ON dbo.ORGANIZATIONMASTER.orgid = dbo.DEPARTMENT.orgid AND dbo.EMPDEPARTMENT.orgid = dbo.DEPARTMENT.orgid AND " _
                   & " dbo.EMPDEPARTMENT.depno = dbo.DEPARTMENT.depid where " & tablename & ".salmonth='" & setmonth & "' and dbo.EMPDEPARTMENT.orgid='" & organization & "'" _
                   & " and " & tablename & "." & headname & "  >0" _
                   & " ORDER BY " & tablename & ".basic DESC"
            Dim dt As String
            dt = setmonth
            'dt = dt.Substring(3)
            globalmod.DataSetRet(sql, "saesi")
            Dim crqES As New rptesi
            crqES.SetDataSource(ds.Tables("saesi"))
            crqES.SetParameterValue("orgname", organization)
            crqES.SetParameterValue("SALMONTH", dt)
            CrystalReportViewer1.ReportSource = crqES
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmesirept_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ComboBox2.SelectedIndex = 0

        Catch ex As Exception

        End Try
    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class