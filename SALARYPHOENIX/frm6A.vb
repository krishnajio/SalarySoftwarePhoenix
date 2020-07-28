Public Class frm6A

    Private Sub frm6A_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String
        sql = "select orgid from organizationmaster"
        globalmod.DataSetRet(sql, "or")
        ComboBox1org.DataSource = ds.Tables("or")
        ComboBox1org.DisplayMember = "orgid"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim sql As String

            If ComboBox1org.Text = "Phoenix Hatcheries" Then
                sql = "SELECT  replace(contactno,'mp/6378/','')[pfno],   dbo.EMPMASTER.empid, dbo.EMPMASTER.name, dbo.EMPMASTER.contactno, " _
                           & " dbo.EMPMASTER.accountno, dbo.EMPSALARY.salmonth, " _
                           & " dbo.EMPSALARY.amtpay, dbo.EMPSALARY.basic, dbo.EMPSALARY.amt833, dbo.EMPSALARY.amt367" _
                           & " FROM         dbo.EMPMASTER INNER JOIN" _
                           & " dbo.EMPSALARY ON dbo.EMPMASTER.orgid = dbo.EMPSALARY.orgid AND dbo.EMPMASTER.empid = dbo.EMPSALARY.empid where EMPSALARY.orgid='" & ComboBox1org.Text _
                           & "' and EMPSALARY.salmonth between '03/01/" & txtsesion.Text & "' and '02/01/" _
                           & CInt(txtsesion.Text) + 1 & "' and dbo.EMPSALARY.amt833>0 and dbo.EMPSALARY.amt367 > 0" _
                            & " order by replace(contactno,'mp/6378/','') "

            Else
                sql = "SELECT replace(contactno,'mp/6378/','')[pfno], dbo.EMPMASTER.empid, dbo.EMPMASTER.name, dbo.EMPMASTER.contactno, " _
           & " dbo.EMPMASTER.accountno, dbo.EMPSALARY.salmonth, " _
           & " dbo.EMPSALARY.amtpay, dbo.EMPSALARY.basic, dbo.EMPSALARY.amt833, dbo.EMPSALARY.amt367" _
           & " FROM         dbo.EMPMASTER INNER JOIN" _
           & " dbo.EMPSALARY ON dbo.EMPMASTER.orgid = dbo.EMPSALARY.orgid AND dbo.EMPMASTER.empid = dbo.EMPSALARY.empid where EMPSALARY.orgid <>'Phoenix Hatcheries" _
           & "' and EMPSALARY.salmonth between '03/01/" & txtsesion.Text & "' and '02/01/" _
           & CInt(txtsesion.Text) + 1 & "'  and dbo.EMPSALARY.amt833>0 and dbo.EMPSALARY.amt367 > 0" _
           & " order by replace(contactno,'mp/6378/','') "
            End If
           
            globalmod.DataSetRet(sql, "getallsal")
            Dim cr6 As New CRFORM6A
            cr6.SetDataSource(globalmod.ds.Tables("getallsal"))
            cr6.SetParameterValue("session", txtsesion.Text)
            cr6.SetParameterValue("orgname", globalmod.organization)
            CrystalReportViewer1.ReportSource = cr6


        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtempid_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtempid.KeyUp
        If e.KeyCode = Keys.F2 Then
            Dim frmempid As New frmemplist
            frmempid.ShowDialog()
            txtempid.Text = frmempid.retEmpId

        End If
    End Sub
End Class