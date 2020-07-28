Public Class frm3A

    Private Sub frm3A_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Organization
        Dim sql As String
        sql = "select orgid from organizationmaster"
        globalmod.DataSetRet(sql, "or")
        ComboBox1org.DataSource = ds.Tables("or")
        ComboBox1org.DisplayMember = "orgid"
        'Employeee
        
    End Sub

    Private Sub txtempid_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtempid.KeyUp
        'If e.KeyCode = Keys.F2 Then
        '    Dim frmempid As New frmemplist
        '    frmempid.ShowDialog()
        '    txtempid.Text = frmempid.retEmpId

        'End If
    End Sub
    Private Sub txtempid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtempid.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim sql As String
            If organization = "Phoenix Hatcheries" Then
                sql = "SELECT     dbo.EMPSALARY.lwp [empid], dbo.EMPMASTER.name + '-' + empmaster.fname + '-' + empmaster.empid + '-' + convert(varchar,dob,105) [name], dbo.EMPMASTER.contactno, " _
                & " dbo.EMPMASTER.accountno, dbo.EMPSALARY.salmonth, " _
                & " dbo.EMPSALARY.amtpay, dbo.EMPSALARY.basic, dbo.EMPSALARY.amt833, dbo.EMPSALARY.amt367" _
                & " FROM         dbo.EMPMASTER INNER JOIN" _
                & " dbo.EMPSALARY ON dbo.EMPMASTER.orgid = dbo.EMPSALARY.orgid AND dbo.EMPMASTER.empid = dbo.EMPSALARY.empid where EMPSALARY.orgid='" & organization _
                & "'  and EMPSALARY.salmonth between '03/01/" & txtsesion.Text & "' and '02/01/" _
                & CInt(txtsesion.Text) + 1 & "' and  dbo.EMPSALARY.amt367 > 0" _
                & " and cast(substring(contactno,9,4) as int)  between " & txtempid.Text & " and " _
                & txttofc.Text
            Else
                sql = "SELECT     dbo.EMPSALARY.lwp [empid], dbo.EMPMASTER.name + '-' + empmaster.fname + '-' + empmaster.empid + '-' + convert(varchar,dob,105) [name], dbo.EMPMASTER.contactno, " _
              & " dbo.EMPMASTER.accountno, dbo.EMPSALARY.salmonth, " _
              & " dbo.EMPSALARY.amtpay, dbo.EMPSALARY.basic, dbo.EMPSALARY.amt833, dbo.EMPSALARY.amt367" _
              & " FROM         dbo.EMPMASTER INNER JOIN" _
              & " dbo.EMPSALARY ON dbo.EMPMASTER.orgid = dbo.EMPSALARY.orgid AND dbo.EMPMASTER.empid = dbo.EMPSALARY.empid where EMPSALARY.orgid<>'Phoenix Hatcheries" _
              & "'  and EMPSALARY.salmonth between '03/01/" & txtsesion.Text & "' and '02/01/" _
              & CInt(txtsesion.Text) + 1 & "' and  dbo.EMPSALARY.amt367 > 0" _
              & " and cast(substring(contactno,9,4) as int)  between " & txtempid.Text & " and " _
              & txttofc.Text
            End If
            globalmod.DataSetRet(sql, "getallsal2")
            Dim sry As New CRFORM3A
            sry.SetDataSource(globalmod.ds.Tables("getallsal2"))
            sry.SetParameterValue("session", txtsesion.Text)
            sry.SetParameterValue("orgname", globalmod.organization)
            CrystalReportViewer1.ReportSource = sry


        Catch ex As Exception

        End Try
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class