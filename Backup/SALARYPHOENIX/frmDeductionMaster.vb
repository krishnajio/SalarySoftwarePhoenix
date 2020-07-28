Public Class frmDeductionMaster
    Dim sql As String
    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
    Private Sub frmDeductionMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillEmp()
    End Sub

    Public Sub fillEmp()
        Try
            sql = "SELECT  EMPMASTER.name ,  EMPSALARYSTRUCTURE.* " _
                   & " FROM EMPSALARYSTRUCTURE INNER JOIN EMPMASTER ON EMPSALARYSTRUCTURE.empid = EMPMASTER.empid and EMPSALARYSTRUCTURE.orgid = EMPMASTER.orgid where EMPMASTER.orgid='" _
                   & organization & "' and status=1 order by EMPMASTER.name "
            globalmod.DataSetRet(sql, "empsalded")
            ' MsgBox(ds.Tables("empsalstu").Rows.Count)

            cmbEmpCode.DataSource = ds.Tables("empsalded")
            cmbEmpCode.DisplayMember = "empid"


            cmdEmpName.DataSource = ds.Tables("empsalded")
            cmdEmpName.DisplayMember = "name"
        Catch ex As Exception
        End Try
    End Sub
End Class