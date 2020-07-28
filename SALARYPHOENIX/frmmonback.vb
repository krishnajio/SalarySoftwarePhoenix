Public Class frmmonback

    Private Sub frmmonback_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String
        sql = "select orgid from organizationmaster"
        globalmod.DataSetRet(sql, "or")
        ComboBox1org.DataSource = ds.Tables("or")
        ComboBox1org.DisplayMember = "orgid"

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim sql As New crMONBACK
            sql.SetParameterValue("orgname", globalmod.organization)
            CrystalReportViewer1.ReportSource = sql

        Catch ex As Exception

        End Try
    End Sub
End Class