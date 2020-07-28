Public Class frmform9

 
    Private Sub frmform9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String
        sql = "select orgid from organizationmaster"
        globalmod.DataSetRet(sql, "or")
        ComboBox1org.DataSource = ds.Tables("or")
        ComboBox1org.DisplayMember = "orgid"

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim sqlsel As String
            sqlsel = "SELECT     empid, name, fname, mname, dob, doj, gender, isnull(CONVERT(varchar, joinpost,105),'')joinpost, qualification1, contactno, accountno " _
             & "FROM dbo.EMPMASTER where orgid='" & organization & "' and status='True' order by contactno"

            globalmod.DataSetRet(sqlsel, "tbsqlset")
            Dim crypfli5 As New Rptform9
            crypfli5.SetDataSource(ds.Tables("tbsqlset"))
            crypfli5.SetParameterValue("orgname", organization)
            crypfli5.SetParameterValue("orgid", globalmod.organization)
            CrystalReportViewer1.ReportSource = crypfli5
        Catch ex As Exception

        End Try
    End Sub
End Class