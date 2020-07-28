Public Class frmrptgrpins

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If organization = "Phoenix Hatcheries" Then
            Try
                Dim sql As String
                Dim I As Integer
                If CheckBox1.Checked = True Then
                    sql = "SELECT EMPMASTER.doj,dbo.EMPMASTER.name, dbo.EMPMASTER.fname [fname] ,EMPMASTER.dob,EMPMASTER.MNAME ,dbo.ORGANIZATIONMASTER.organization," _
                                    & " dbo." & tablename & ".empid ,dbo." & tablename & ".amtpay amtpay, dbo." & tablename & ".hra,dbo." & tablename & ".cca," _
                                    & " dbo." & tablename & ".OA1 [oa1] , dbo." & tablename & ".oa2, dbo." & tablename & ".it," _
                                    & "dbo." & tablename & ".educease,dbo." & tablename & ".proftax," _
                                    & " dbo." & tablename & ".collegeloan, dbo." & tablename & ".lwp," _
                                    & " dbo." & tablename & ".remark,dbo." & tablename & ".amt833, " _
                                    & " dbo." & tablename & ".amt367, dbo." & tablename & ".groupinsded [basic]," _
                                    & " dbo." & tablename & ".secudep,dbo." & tablename & ".od1, dbo." & tablename & ".paymode," _
                                    & " dbo.EMPMASTER.empid, dbo.DEPARTMENT.department,substring(contactno,9,4) [acc] FROM dbo.EMPMASTER INNER JOIN" _
                                    & " dbo.ORGANIZATIONMASTER INNER JOIN dbo." & tablename & " ON dbo.ORGANIZATIONMASTER.orgid = dbo." & tablename & ".orgid ON " _
                                    & " dbo.EMPMASTER.empid = dbo." & tablename & ".empid and    EMPMASTER.orgid = " & tablename & ".orgid  INNER JOIN" _
                                    & " dbo.EMPDEPARTMENT ON dbo.EMPMASTER.empid = dbo.EMPDEPARTMENT.empid AND " _
                                    & " dbo.ORGANIZATIONMASTER.orgid = dbo.EMPDEPARTMENT.orgid INNER JOIN" _
                                    & " dbo.DEPARTMENT ON dbo.ORGANIZATIONMASTER.orgid = dbo.DEPARTMENT.orgid AND dbo.EMPDEPARTMENT.orgid = dbo.DEPARTMENT.orgid AND " _
                                    & " dbo.EMPDEPARTMENT.depno = dbo.DEPARTMENT.depid where dbo." & tablename & ".salmonth='" & setmonth & "' and dbo.EMPDEPARTMENT.orgid='Phoenix Hatcheries'" _
                                    & " and " & tablename & ".groupinsded  >0 and (groupinsded=140 or groupinsded=70) " _
                                    & " ORDER BY dbo." & tablename & ".basic DESC "
                    I = 1


                Else
                    sql = "SELECT empmaster.doj,dbo.EMPMASTER.name , dbo.EMPMASTER.fname [fname] ,EMPMASTER.dob,EMPMASTER.MNAME, dbo.ORGANIZATIONMASTER.organization," _
                                 & " dbo." & tablename & ".empid ,dbo." & tablename & ".amtpay amtpay, dbo." & tablename & ".hra,dbo." & tablename & ".cca," _
                                 & " dbo." & tablename & ".OA1 [oa1] , dbo." & tablename & ".oa2, dbo." & tablename & ".it," _
                                 & "dbo." & tablename & ".educease,dbo." & tablename & ".proftax," _
                                 & " dbo." & tablename & ".collegeloan, dbo." & tablename & ".lwp," _
                                 & " dbo." & tablename & ".remark,dbo." & tablename & ".amt833, " _
                                 & " dbo." & tablename & ".amt367, dbo." & tablename & ".groupinsded [basic]," _
                                 & " dbo." & tablename & ".secudep,dbo." & tablename & ".od1, dbo." & tablename & ".paymode," _
                                 & " dbo.EMPMASTER.empid, dbo.DEPARTMENT.department,substring(contactno,9,4) [acc] FROM dbo.EMPMASTER INNER JOIN" _
                                 & " dbo.ORGANIZATIONMASTER INNER JOIN dbo." & tablename & " ON dbo.ORGANIZATIONMASTER.orgid = dbo." & tablename & ".orgid ON " _
                                 & " dbo.EMPMASTER.empid = dbo." & tablename & ".empid and    EMPMASTER.orgid = " & tablename & ".orgid  INNER JOIN" _
                                 & " dbo.EMPDEPARTMENT ON dbo.EMPMASTER.empid = dbo.EMPDEPARTMENT.empid AND " _
                                 & " dbo.ORGANIZATIONMASTER.orgid = dbo.EMPDEPARTMENT.orgid INNER JOIN" _
                                 & " dbo.DEPARTMENT ON dbo.ORGANIZATIONMASTER.orgid = dbo.DEPARTMENT.orgid AND dbo.EMPDEPARTMENT.orgid = dbo.DEPARTMENT.orgid AND " _
                                 & " dbo.EMPDEPARTMENT.depno = dbo.DEPARTMENT.depid where dbo." & tablename & ".salmonth='" & setmonth & "' and dbo.EMPDEPARTMENT.orgid='Phoenix Hatcheries'" _
                                 & " and (groupinsded=90 or groupinsded=45) and  " & tablename & ".groupinsded  >0" _
                                 & " ORDER BY dbo." & tablename & ".basic DESC "
                    I = 0

                End If

                Dim dt As String
                dt = setmonth
                dt = dt.Substring(3)
                globalmod.DataSetRet(sql, "saesi")
                Dim crqESgs As New rptgrsi
                crqESgs.SetDataSource(ds.Tables("saesi"))
                crqESgs.SetParameterValue("orgname", organization)
                crqESgs.SetParameterValue("SALMONTH", dt)
                crqESgs.SetParameterValue("setbit", I)

                CrystalReportViewer1.ReportSource = crqESgs
            Catch ex As Exception

            End Try

        Else

            Try
                Dim sql As String
                Dim I As Integer
                If CheckBox1.Checked = True Then
                    sql = "SELECT EMPMASTER.doj, dbo.EMPMASTER.name , dbo.EMPMASTER.fname [fname] ,EMPMASTER.dob,EMPMASTER.MNAME , dbo.ORGANIZATIONMASTER.organization," _
                                    & " dbo." & tablename & ".empid ,dbo." & tablename & ".amtpay amtpay, dbo." & tablename & ".hra,dbo." & tablename & ".cca," _
                                    & " dbo." & tablename & ".OA1 [oa1] , dbo." & tablename & ".oa2, dbo." & tablename & ".it," _
                                    & " dbo." & tablename & ".educease,dbo." & tablename & ".proftax," _
                                    & " dbo." & tablename & ".collegeloan, dbo." & tablename & ".lwp," _
                                    & " dbo." & tablename & ".remark,dbo." & tablename & ".amt833, " _
                                    & " dbo." & tablename & ".amt367, dbo." & tablename & ".groupinsded [basic]," _
                                    & " dbo." & tablename & ".secudep,dbo." & tablename & ".od1, dbo." & tablename & ".paymode," _
                                    & " dbo.EMPMASTER.empid, dbo.DEPARTMENT.department,substring(contactno,9,4) [acc] FROM dbo.EMPMASTER INNER JOIN" _
                                    & " dbo.ORGANIZATIONMASTER INNER JOIN dbo." & tablename & " ON dbo.ORGANIZATIONMASTER.orgid = dbo." & tablename & ".orgid ON " _
                                    & " dbo.EMPMASTER.empid = dbo." & tablename & ".empid and    EMPMASTER.orgid = " & tablename & ".orgid  INNER JOIN" _
                                    & " dbo.EMPDEPARTMENT ON dbo.EMPMASTER.empid = dbo.EMPDEPARTMENT.empid AND " _
                                    & " dbo.ORGANIZATIONMASTER.orgid = dbo.EMPDEPARTMENT.orgid INNER JOIN" _
                                    & " dbo.DEPARTMENT ON dbo.ORGANIZATIONMASTER.orgid = dbo.DEPARTMENT.orgid AND dbo.EMPDEPARTMENT.orgid = dbo.DEPARTMENT.orgid AND " _
                                    & " dbo.EMPDEPARTMENT.depno = dbo.DEPARTMENT.depid where dbo." & tablename & ".salmonth='" & setmonth & "' and dbo.EMPDEPARTMENT.orgid<>'Phoenix Hatcheries'" _
                                    & " and " & tablename & ".groupinsded  >0 and (groupinsded=140 or groupinsded=70) " _
                                    & " ORDER BY dbo." & tablename & ".basic DESC "
                    I = 1


                Else
                    sql = "SELECT EMPMASTER.doj,dbo.EMPMASTER.name , dbo.EMPMASTER.fname [fname] ,EMPMASTER.dob,EMPMASTER.MNAME , dbo.ORGANIZATIONMASTER.organization," _
                                 & " dbo." & tablename & ".empid ,dbo." & tablename & ".amtpay amtpay, dbo." & tablename & ".hra,dbo." & tablename & ".cca," _
                                 & " dbo." & tablename & ".OA1 [oa1] , dbo." & tablename & ".oa2, dbo." & tablename & ".it," _
                                 & "dbo." & tablename & ".educease,dbo." & tablename & ".proftax," _
                                 & " dbo." & tablename & ".collegeloan, dbo." & tablename & ".lwp," _
                                 & " dbo." & tablename & ".remark,dbo." & tablename & ".amt833, " _
                                 & " dbo." & tablename & ".amt367, dbo." & tablename & ".groupinsded [basic]," _
                                 & " dbo." & tablename & ".secudep,dbo." & tablename & ".od1, dbo." & tablename & ".paymode," _
                                 & " dbo.EMPMASTER.empid, dbo.DEPARTMENT.department,substring(contactno,9,4) [acc] FROM dbo.EMPMASTER INNER JOIN" _
                                 & " dbo.ORGANIZATIONMASTER INNER JOIN dbo." & tablename & " ON dbo.ORGANIZATIONMASTER.orgid = dbo." & tablename & ".orgid ON " _
                                 & " dbo.EMPMASTER.empid = dbo." & tablename & ".empid and    EMPMASTER.orgid = " & tablename & ".orgid  INNER JOIN" _
                                 & " dbo.EMPDEPARTMENT ON dbo.EMPMASTER.empid = dbo.EMPDEPARTMENT.empid AND " _
                                 & " dbo.ORGANIZATIONMASTER.orgid = dbo.EMPDEPARTMENT.orgid INNER JOIN" _
                                 & " dbo.DEPARTMENT ON dbo.ORGANIZATIONMASTER.orgid = dbo.DEPARTMENT.orgid AND dbo.EMPDEPARTMENT.orgid = dbo.DEPARTMENT.orgid AND " _
                                 & " dbo.EMPDEPARTMENT.depno = dbo.DEPARTMENT.depid where dbo." & tablename & ".salmonth='" & setmonth & "' and dbo.EMPDEPARTMENT.orgid<>'Phoenix Hatcheries'" _
                                 & " and (groupinsded=90 or groupinsded=45) and  " & tablename & ".groupinsded  >0" _
                                 & " ORDER BY dbo." & tablename & ".basic DESC "
                    I = 0

                End If

                Dim dt As String
                dt = setmonth
                dt = dt.Substring(3)
                globalmod.DataSetRet(sql, "saesi")
                Dim crqESgs As New rptgrsi
                crqESgs.SetDataSource(ds.Tables("saesi"))
                crqESgs.SetParameterValue("orgname", organization)
                crqESgs.SetParameterValue("SALMONTH", dt)
                crqESgs.SetParameterValue("setbit", I)

                CrystalReportViewer1.ReportSource = crqESgs
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    
    Private Sub frmrptgrpins_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class