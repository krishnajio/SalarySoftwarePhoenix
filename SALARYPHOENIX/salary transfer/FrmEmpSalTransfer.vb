Public Class FrmEmpSalTransfer

    Private Sub FrmEmpSalRep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''  DateTimePicker1.MinDate = "04/01/" & Mid(globalmod.session, 1, 2)
        '' DateTimePicker1.MaxDate = "03/31/" & Mid(globalmod.session, 3, 4)

        'Dim sql1 As String = "select OrganizationName from OrganizationMaster where organization='" & globalmod.organization & "'"
        'globalmod.DataSetRet(sql1, "orgname")
        ''ds.Tables("orgname").Rows(0)(0)
        'Me.Text &= " - " & ds.Tables("orgname").Rows(0)(0)
        ''select e.organization,o.OrganizationName,o.Address,e.EpfNo,e.EmpID,e.Name,s.basic,s.salmonth,s.lwp,s.amtpay,s.da,s.hra,s.cca,
        ''s.oa1,s.oa2,s.edc_cs,(s.amtpay+s.da+s.hra+s.cca+s.oa1+s.oa2+s.edc_cs)
        ''"Before Epf",s.epf,s.grossSalary,s.epfded,s.groupinsuranceded,s.securitydepoded,
        ''s.tax,s.tdsded,s.oded,s.totalded,s.remark,s.netpay,s.paymode from
        ''EmpMaster e join EmpSalary s on (e.EmpID=s.EmpId and e.organization=s.organization) join OrganizationMaster o 
        ''on (e.organization=o.organization) 
        ''where o.organization='Org001'
        'Dim sql As String = "select OrganizationName from OrganizationMaster where organization='" & globalmod.organization & "'"
        'globalmod.DataSetRet(sql, "orgname")
        'LblOrg.Text = ds.Tables("orgname").Rows(0)(0)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim joingpost As String = ""
        Dim sqljoinpost As String = ""
        Dim post(20) As String
        Dim r As New CrTransferToAc
        Dim sql As String = ""
        globalmod.SqlExecuteNonQuery("delete from TransferToAcc")
        If Cmb.Text = "TEACHERS" Then


            ' joingpost = "'DRIVER','CONDUCTOR','MAID/POEN','FIXED','TEACHER','OTHER OFFICE STAFF','BAND MASTER','GARDENER','OTHER LABOUR','S.POOL','SWEEPER','CO-ORDINATOR','OFFICE INCHARGE-1','PART TIME MAID','BUS CONDUCTOR'"



            'sqljoinpost = "select distinct joinpost from vwDateWiseSal  where organization='" & globalmod.organization & "' and salmonth='" _
            '& DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and JoinPost not in(" & joingpost & ") and [Before Epf]>0   "
            'globalmod.DataSetRet(sqljoinpost, "Vw_post")

            '            If (globalmod.ds.Tables("Vw_post").Rows.Count > 0) Then
            'For m As Integer = 0 To globalmod.ds.Tables("Vw_post").Rows.Count - 1
            'post(m) = globalmod.ds.Tables("Vw_post").Rows(m)(0)
            transfertoac("TT")
            'Next m

        End If
        '' transfertoac(joingpost)
        ''----------------------------------------------------------------------------------------------
        'ElseIf Cmb.Text = "DRIVER,CONDUCTOR,SUPPORING STAFF" Then
        '' sql = "select * from vwDateWiseSal where organization='" & globalmod.organization & "' and salmonth='" & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and JoinPost in('DRIVER','CONDUCTOR','MAID/POEN')"
        'joingpost = "'DRIVER','CONDUCTOR','MAID/POEN'"


        'sqljoinpost = "select distinct joinpost from vwDateWiseSal  where organization='" & globalmod.organization & "' and salmonth='" _
        '                & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and JoinPost  in(" & joingpost & ") and [Before Epf]>0   "
        'globalmod.DataSetRet(sqljoinpost, "Vw_post")

        'If (globalmod.ds.Tables("Vw_post").Rows.Count > 0) Then
        '    For m As Integer = 0 To globalmod.ds.Tables("Vw_post").Rows.Count - 1
        '        post(m) = globalmod.ds.Tables("Vw_post").Rows(m)(0)
        '        transfertoacin(post(m))
        '    Next m

        'End If

        ''transfertoacin(joingpost)

        'ElseIf Cmb.Text = "FIXED" Then
        ''sql = "select * from vwDateWiseSal where organization='" & globalmod.organization & "' and salmonth='" & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and JoinPost ='FIXED'"
        'joingpost = "'FIXED'"
        'sqljoinpost = "select distinct joinpost from vwDateWiseSal  where organization='" & globalmod.organization & "' and salmonth='" _
        '                & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and JoinPost  in(" & joingpost & ") and [Before Epf]>0   "
        'globalmod.DataSetRet(sqljoinpost, "Vw_post")

        'If (globalmod.ds.Tables("Vw_post").Rows.Count > 0) Then
        '    For m As Integer = 0 To globalmod.ds.Tables("Vw_post").Rows.Count - 1
        '        post(m) = globalmod.ds.Tables("Vw_post").Rows(m)(0)
        '        transfertoacin(post(m))
        '    Next m

        'End If
        '' transfertoacin(joingpost)

        'ElseIf Cmb.Text = "OTHER TEACHING STAFF" Then

        'If (globalmod.organization = "Org001") Then
        '    'sql = "select * from vwDateWiseSal where organization='" & globalmod.organization & "' and salmonth='" & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null) and is_pen_fund=0 and JoinPost in('TEACHER','OTHER OFFICE STAFF','BAND MASTER','CO-ORDINATOR','OFFICE INCHARGE-1')"
        '    joingpost = "'TEACHER','OTHER OFFICE STAFF','BAND MASTER','CO-ORDINATOR','OFFICE INCHARGE-1'"
        '    sqljoinpost = "select distinct joinpost from vwDateWiseSal  where organization='" & globalmod.organization & "' and salmonth='" _
        '                               & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and JoinPost  in(" & joingpost & ") and [Before Epf]>0   "
        '    globalmod.DataSetRet(sqljoinpost, "Vw_post")

        '    If (globalmod.ds.Tables("Vw_post").Rows.Count > 0) Then
        '        For m As Integer = 0 To globalmod.ds.Tables("Vw_post").Rows.Count - 1
        '            post(m) = globalmod.ds.Tables("Vw_post").Rows(m)(0)
        '            transfertoacnonpf(post(m))
        '        Next m

        '    End If
        'Else
        '    joingpost = "'OTHER OFFICE STAFF','TEACHER'"
        '    sqljoinpost = "select distinct joinpost from vwDateWiseSal  where organization='" & globalmod.organization & "' and salmonth='" _
        '                               & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and JoinPost  in(" & joingpost & ")     "
        '    globalmod.DataSetRet(sqljoinpost, "Vw_post")

        '    If (globalmod.ds.Tables("Vw_post").Rows.Count > 0) Then
        '        For m As Integer = 0 To globalmod.ds.Tables("Vw_post").Rows.Count - 1
        '            post(m) = globalmod.ds.Tables("Vw_post").Rows(m)(0)
        '            transfertoacnonpf(post(m))
        '        Next m

        '    End If
        'End If
        ''   transfertoacnonpf(joingpost)

        'ElseIf Cmb.Text = "LABOUR STAFF" Then
        ''sql = "select * from vwDateWiseSal where organization='" & globalmod.organization & "' and salmonth='" & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null) and JoinPost in('GARDENER','OTHER LABOUR','S.POOL','SWEEPER')"
        'joingpost = "'GARDENER','OTHER LABOUR','S.POOL','SWEEPER'"

        'sqljoinpost = "select distinct joinpost from vwDateWiseSal  where organization='" & globalmod.organization & "' and salmonth='" _
        '                            & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and JoinPost  in(" & joingpost & ") and [Before Epf]>0   "
        'globalmod.DataSetRet(sqljoinpost, "Vw_post")

        'If (globalmod.ds.Tables("Vw_post").Rows.Count > 0) Then
        '    For m As Integer = 0 To globalmod.ds.Tables("Vw_post").Rows.Count - 1
        '        post(m) = globalmod.ds.Tables("Vw_post").Rows(m)(0)
        '        transfertoacin(post(m))
        '    Next m

        'End If

        '' transfertoacin(joingpost)

        'ElseIf Cmb.Text = "PART TIME CASUAL STAFF" Then
        'If (globalmod.organization = "Org001") Then
        '    ' sql = "select * from vwDateWiseSal where organization='" & globalmod.organization & "' and salmonth='" & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null) and JoinPost in('BUS CONDUCTOR','PART TIME MAID')"
        '    joingpost = "'BUS CONDUCTOR','PART TIME MAID'"

        '    sqljoinpost = "select distinct joinpost from vwDateWiseSal  where organization='" & globalmod.organization & "' and salmonth='" _
        '                    & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and JoinPost  in(" & joingpost & ") and [Before Epf]>0   "
        '    globalmod.DataSetRet(sqljoinpost, "Vw_post")

        '    If (globalmod.ds.Tables("Vw_post").Rows.Count > 0) Then
        '        For m As Integer = 0 To globalmod.ds.Tables("Vw_post").Rows.Count - 1
        '            post(m) = globalmod.ds.Tables("Vw_post").Rows(m)(0)
        '            transfertoacin(post(m))
        '        Next m

        '    End If
        'Else
        '    ' sql = "select * from vwDateWiseSal where organization='" & globalmod.organization & "' and salmonth='" & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null) and JoinPost in('BUS CONDUCTOR','PART TIME MAID')"
        '    joingpost = "'BUS CONDUCTOR','PART TIME MAID','TEACHER N'"

        '    sqljoinpost = "select distinct joinpost from vwDateWiseSal  where organization='" & globalmod.organization & "' and salmonth='" _
        '                    & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and JoinPost  in(" & joingpost & ") and [Before Epf]>0   "
        '    globalmod.DataSetRet(sqljoinpost, "Vw_post")

        '    If (globalmod.ds.Tables("Vw_post").Rows.Count > 0) Then

        '        transfertoacin_other_staff_lws(joingpost)


        '    End If
        'End If
        '' transfertoacin(joingpost)


        'ElseIf Cmb.Text = "" Then
        'sql = "select * from vwDateWiseSal where organization='" & globalmod.organization & "' and salmonth='" & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null) and JoinPost in('BUS CONDUCTOR','PART TIME MAID')"
        'joingpost = "'BUS CONDUCTOR','PART TIME MAID'"
        'sqljoinpost = "select distinct joinpost from vwDateWiseSal  where organization='" & globalmod.organization & "' and salmonth='" _
        '                    & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and JoinPost  in(" & joingpost & ") and [Before Epf]>0   "
        'globalmod.DataSetRet(sqljoinpost, "Vw_post")

        'If (globalmod.ds.Tables("Vw_post").Rows.Count > 0) Then
        '    For m As Integer = 0 To globalmod.ds.Tables("Vw_post").Rows.Count - 1
        '        post(m) = globalmod.ds.Tables("Vw_post").Rows(m)(0)
        '        transfertoacin(post(m))
        '    Next m

        'End If

        'End If
        ''  MsgBox(DateTimePicker1.Value)

        ''--- Updating  Join Post  in TransfertoAcc Table   
        ''sql = " Update   TransferToAcc set TransferToAcc.JoinPost = empmaster.JoinPost from  TransferToAcc inner join   empmaster  on  TransferToAcc.code=empmaster.empId  and session1='" & globalmod.session1 & "' "
        'globalmod.SqlExecuteNonQuery(sql)
        ''-------- End 
        'sql = " Update   TransferToAcc set TransferToAcc.Sequence = Seniority.Sequence from  TransferToAcc inner join   Seniority  on  TransferToAcc.JoinPost=Seniority.JoinPost   "
        'globalmod.SqlExecuteNonQuery(sql)
        ''-------- End 

        ''sql &= "select * from dbo.TransferToAcc where dramt <> 0 or cramt <>0 order by  sequence,code, id desc"
        ''globalmod.DataSetRet(sql, "Vw9")



        ''r.SetDataSource(globalmod.ds.Tables("Vw9"))
        ''r.SetParameterValue("p1", Cmb.Text & " " & DateTimePicker1.Text)
        ''CrystalReportViewer1.ReportSource = r
    End Sub

    Public Sub transfertoac(ByVal joingpost As String)

        Dim sql, sqljoinpost As String



        'salary debit to salaty a/c
        On Error Resume Next

        '  sql = "select sum([Before Epf]) from vwDateWiseSal  where organization='" & globalmod.organization & "' and salmonth='" _
        '                   & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and JoinPost  in('" & joingpost & "') and [Before Epf]>0   "
        'sum(amt833+amt367)
        sql = "select sum(amtpay+da+hra+cca+oa2) from salacctransfer where orgid ='" & globalmod.organization & "' and salmonth='" & DateTimePicker1.Value.ToShortDateString & "'"
        globalmod.DataSetRet(sql, "Vw1")

        sql = "insert into  TransferToAcc(Code, Name, Dramt, Cramt,HeadOrder, Narration,AcPost) values("

        '**JE0058	CPF EXPENSES
        If (organization = "PRIMARY HEALTH CARE") Then
            sql &= "'**JE0058',"
        ElseIf (organization = "Org002") Then
            sql &= "'**EX0008',"
        End If
        sql &= "'CPF EXPENSES',"
        sql &= "'" & globalmod.ds.Tables("Vw1").Rows(0)(0) & "',"
        sql &= "'0',"
        sql &= "'A',"  '-------- Head Order
        sql &= "'BEING AMOUNT OF STAFF SALARY FOR THE MONTH  OF  " & DateTimePicker1.Text & "' ,'" & joingpost & "')"
        globalmod.SqlExecuteNonQuery(sql)

        'ESI EMPLOYER CONTRIBUTION Credit a/c
        sql = "select sum([Esic]) from vwDateWiseSal    where organization='" & globalmod.organization & "' and salmonth='" _
                            & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and JoinPost  in('" & joingpost & "')  and [Before Epf]>0   "
        globalmod.DataSetRet(sql, "Vw1")

        sql = "insert into  TransferToAcc(Code, Name, Dramt, Cramt,HeadOrder, Narration,AcPost) values("
        If (organization = "Org001") Then
            sql &= "'**EX0072',"
        ElseIf (organization = "Org002") Then
            sql &= "'**EX0045',"
        End If
        sql &= "'ESI-EMPLOYER CONTRIBUTION',"
        sql &= "'" & globalmod.ds.Tables("Vw1").Rows(0)(0) & "',"
        sql &= "'0',"
        sql &= "'Q',"  '-------- Head Order
        sql &= "'BEING AMOUNT OF ESI-EMPLOYEER CONTRIBUTION FOR THE MONTH OF  " & DateTimePicker1.Text & "' ,'" & joingpost & "')"
        globalmod.SqlExecuteNonQuery(sql)

        'salary debit to ESI Contribution a/c
        sql = "select sum([Esic_Both]) from vwDateWiseSal where organization='" & globalmod.organization & "' and salmonth='" _
                            & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and JoinPost  in('" & joingpost & "') and [Before Epf]>0 "
        globalmod.DataSetRet(sql, "Vw1")

        sql = "insert into  TransferToAcc(Code, Name, Dramt, Cramt,HeadOrder, Narration,AcPost) values("
        If (organization = "Org001") Then
            sql &= "'**EX0073',"
        ElseIf (organization = "Org002") Then
            sql &= "'**EX0046',"
        End If
        sql &= "'ESI-BOTH CONTRIBUTION',"
        sql &= "'0',"
        sql &= "'" & globalmod.ds.Tables("Vw1").Rows(0)(0) & "',"

        sql &= "'K',"  '-------- Head Order
        sql &= "'BEING AMOUNT OF ESI-BOTH CONTRIBUTION FOR THE MONTH OF  " & DateTimePicker1.Text & "' ,'" & joingpost & "')"
        globalmod.SqlExecuteNonQuery(sql)




        'indivisual staff credit to salarry a/c
        sql = "insert into  TransferToAcc(Code, Name, Dramt, Cramt,HeadOrder ,Narration,AcPost) "
        sql &= "select EmpId,Name,0,[Before Epf] ,'B','BEING AMOUNT OF STAFF SALARY FOR THE MONTH  OF  " & DateTimePicker1.Text & "', '" & joingpost & "'  from vwDateWiseSal  vw   inner join Seniority s  on  vw.JoinPost= S.JoinPost where organization='" & globalmod.organization & "' and salmonth='" _
        & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and vw.JoinPost  in('" & joingpost & "') and [Before Epf]>0 order by s.sequence ,Empid "
        globalmod.SqlExecuteNonQuery(sql)

        'EMPLOYER CONTRIBUTION debit to a/c
        sql = "select sum(Epf) from vwDateWiseSal  where organization='" & globalmod.organization & "' and salmonth='" _
                   & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and JoinPost  in('" & joingpost & "') and [Before Epf]>0 "
        globalmod.DataSetRet(sql, "Vw2")

        sql = "insert into  TransferToAcc(Code, Name, Dramt, Cramt,HeadOrder, Narration,AcPost) values("

        If (organization = "Org001") Then
            sql &= "'**EX0013',"
        ElseIf (organization = "Org002") Then
            sql &= "'**EX0009',"
        End If

        sql &= "'EMPLOYER CONTRIBUTION',"
        sql &= "'" & globalmod.ds.Tables("Vw2").Rows(0)(0) & "',"
        sql &= "'0',"
        sql &= "'C',"             '---------Head Order
        sql &= "'BEING AMOUNT OF STAFF EMPLOYER CONTRIBUTION FOR THE MONTH  OF  " & DateTimePicker1.Text & "','" & joingpost & "')"
        globalmod.SqlExecuteNonQuery(sql)


        'individual staff credit to salary ESI BOTH-ESI  differnce Employee Contribution a/c

        sql = "insert into  TransferToAcc(Code, Name, Dramt, Cramt,HeadOrder, Narration,AcPost) "
        sql &= "select EmpId,Name,[Esic_Both]-[Esic] ,0,'R','BEING AMOUNT OF  ESI Employee Contribution FOR THE MONTH  OF  " & DateTimePicker1.Text & "' ,'" & joingpost & "' from vwDateWiseSal  vw   inner join Seniority s  on  vw.JoinPost= S.JoinPost where organization='" & globalmod.organization & "' and salmonth='" _
        & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and vw.JoinPost  in('" & joingpost & "') and [Before Epf]>0 order by s.sequence ,Empid "
        globalmod.SqlExecuteNonQuery(sql)




        'individual staff epf a/c debit
        sql = " insert into  TransferToAcc(Code, Name, Dramt, Cramt,HeadOrder, Narration,AcPost) "
        sql &= " select EmpId,Name,epf,0 ,'D','BEING AMOUNT OF STAFF EMPLOYEE CONTRIBUTION FOR THE MONTH  OF  " & DateTimePicker1.Text & "' ,'" & joingpost & "' from vwDateWiseSal  vw   inner join Seniority s  on  vw.JoinPost= S.JoinPost where organization='" & globalmod.organization & "' and salmonth='" _
        & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and vw.JoinPost  in('" & joingpost & "') and [Before Epf]>0 order by s.sequence ,Empid"
        globalmod.SqlExecuteNonQuery(sql)

        'cpf a/c credit 
        sql = "select sum(Epf) from vwDateWiseSal  where organization='" & globalmod.organization & "' and salmonth='" _
                               & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and JoinPost  in('" & joingpost & "') and [Before Epf]>0 "
        globalmod.DataSetRet(sql, "Vw3")


        sql = "insert into  TransferToAcc(Code, Name, Dramt, Cramt, HeadOrder,Narration,AcPost) values("

        If (organization = "Org001") Then
            sql &= "'**EX0014',"
        ElseIf (organization = "Org002") Then
            sql &= "'**EX0010',"
        End If
        sql &= "'C.P.F.',"
        sql &= "'0',"
        sql &= "'" & 2 * Val(globalmod.ds.Tables("Vw3").Rows(0)(0)) & "',"
        sql &= "'E',"
        sql &= "'BEING AMOUNT OF C.P.F.EXPS. BOTH FOR THE MONTH OF" & DateTimePicker1.Text & "' ,'" & joingpost & "')"
        globalmod.SqlExecuteNonQuery(sql)




        'PF tax debit to indivaual a/c 
        sql = "insert into  TransferToAcc(Code, Name, Dramt, Cramt,HeadOrder, Narration,AcPost) "
        sql &= "select EmpId,Name,tax,0 ,'F','BEING AMOUNT OF STAFF PROFESSIONAL TAX FOR THE MONTH OF  " & DateTimePicker1.Text & "' ,'" & joingpost & "'  from vwDateWiseSal  vw   inner join Seniority s  on  vw.JoinPost= S.JoinPost where organization='" & globalmod.organization & "' and salmonth='" _
        & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and vw.JoinPost  in('" & joingpost & "') and [tax]>0  order by s.sequence ,Empid "
        globalmod.SqlExecuteNonQuery(sql)

        'total pf tax credit to proff tax 
        sql = "select sum(tax) from vwDateWiseSal where organization='" & globalmod.organization & "' and salmonth='" _
                                           & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and JoinPost  in('" & joingpost & "') and [Before Epf]>0 "
        globalmod.DataSetRet(sql, "Vw4")

        sql = "insert into  TransferToAcc(Code, Name, Dramt, Cramt,HeadOrder, Narration,AcPost) values("

        If (organization = "Org001") Then
            sql &= "'**EX0040',"
        ElseIf (organization = "Org002") Then
            sql &= "'**EX0027',"
        End If

        sql &= "'PROFESSIONAL TAX',"
        sql &= "'0',"
        sql &= "'" & Val(globalmod.ds.Tables("Vw4").Rows(0)(0)) & "',"
        sql &= "'G',"
        sql &= "'BEING AMOUNT OF STAFF PROFESSIONAL TAX FOR THE MONTH OF " & DateTimePicker1.Text & "','" & joingpost & "' )"
        globalmod.SqlExecuteNonQuery(sql)

        'TDS tax debit to indivaual a/c 
        sql = "insert into  TransferToAcc(Code, Name, Dramt, Cramt,HeadOrder, Narration,AcPost) "
        sql &= "select EmpId,Name,tdsded,0 ,'H','BEING AMOUNT OF T.D.S.FROM STAFF SALARY FOR THE MONTH OF  " & DateTimePicker1.Text & "' ,'" & joingpost & "'  from vwDateWiseSal  vw   inner join Seniority s  on  vw.JoinPost= S.JoinPost where organization='" & globalmod.organization & "' and salmonth='" _
        & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and vw.JoinPost  in('" & joingpost & "') and [tdsded]>0 order by s.sequence ,Empid"
        globalmod.SqlExecuteNonQuery(sql)

        'total tds tax credit to tds a/c
        sql = "select sum(tdsded) from vwDateWiseSal  where organization='" & globalmod.organization & "' and salmonth='" _
                                           & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and JoinPost  in('" & joingpost & "') and [Before Epf]>0 "
        globalmod.DataSetRet(sql, "Vw5")

        sql = "insert into  TransferToAcc(Code, Name, Dramt, Cramt,HeadOrder, Narration,AcPost) values("
        sql &= "'**TD0007',"
        sql &= "'TDS-(SALARY)',"
        sql &= "'0',"
        sql &= "'" & Val(globalmod.ds.Tables("Vw5").Rows(0)(0)) & "',"
        sql &= "'I',"
        sql &= "'BEING AMOUNT OF T.D.S.FROM STAFF SALARY FOR THE MONTH OF " & DateTimePicker1.Text & "' ,'" & joingpost & "')"
        globalmod.SqlExecuteNonQuery(sql)


    End Sub
    Public Sub transfertoacin(ByVal joingpost As String)
        On Error Resume Next
        Dim sql As String
        'salary debit to salary a/c
        sql = "select sum([Before Epf]) from vwDateWiseSal where organization='" & globalmod.organization & "' and salmonth='" _
                    & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and JoinPost in('" & joingpost & "') and [Before Epf]>0  "
        globalmod.DataSetRet(sql, "Vw1")

        sql = "insert into  TransferToAcc(Code, Name, Dramt, Cramt,HeadOrder, Narration,AcPost) values("
        If (organization = "Org001") Then
            sql &= "'**EX0012',"
        ElseIf (organization = "Org002") Then
            sql &= "'**EX0008',"
        End If

        sql &= "'SALARY EXPS.',"
        sql &= "'" & globalmod.ds.Tables("Vw1").Rows(0)(0) & "',"
        sql &= "'0',"
        sql &= "'A',"  '-------- Head Order
        sql &= "'BEING AMOUNT OF STAFF SALARY FOR THE MONTH  OF  " & DateTimePicker1.Text & "' ,'" & joingpost & "')"
        globalmod.SqlExecuteNonQuery(sql)

        'EMPLOYER CONTRIBUTION debit to a/c
        sql = "select sum(Epf) from vwDateWiseSal   where organization='" & globalmod.organization & "' and salmonth='" _
                   & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and JoinPost in ('" & joingpost & "') and [Before Epf]>0 "
        globalmod.DataSetRet(sql, "Vw2")

        sql = "insert into  TransferToAcc(Code, Name, Dramt, Cramt,HeadOrder, Narration,AcPost) values("

        If (organization = "Org001") Then
            sql &= "'**EX0013',"
        ElseIf (organization = "Org002") Then
            sql &= "'**EX0009',"
        End If

        sql &= "'EMPLOYER CONTRIBUTION',"
        sql &= "'" & globalmod.ds.Tables("Vw2").Rows(0)(0) & "',"
        sql &= "'0',"
        sql &= "'C',"             '---------Head Order
        sql &= "'BEING AMOUNT OF STAFF EMPLOYER CONTRIBUTION FOR THE MONTH  OF  " & DateTimePicker1.Text & "' ,'" & joingpost & "')"
        globalmod.SqlExecuteNonQuery(sql)

        'indivisual staff epf a/c debit
        sql = " insert into  TransferToAcc(Code, Name, Dramt, Cramt,HeadOrder, Narration,AcPost) "
        sql &= " select EmpId,Name,epf,0 ,'D','BEING AMOUNT OF STAFF EMPLOYEE CONTRIBUTION FOR THE MONTH  OF  " & DateTimePicker1.Text & "'  ,'" & joingpost & "' from vwDateWiseSal vw   inner join Seniority s  on  vw.JoinPost= S.JoinPost where organization='" & globalmod.organization & "' and salmonth='" _
        & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and vw.JoinPost  in('" & joingpost & "') and [Before Epf]>0 order by s.sequence ,Empid"
        globalmod.SqlExecuteNonQuery(sql)

        'cpf a/c credit 
        sql = "select sum(Epf) from vwDateWiseSal where organization='" & globalmod.organization & "' and salmonth='" _
                               & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and JoinPost  in('" & joingpost & "') and [Before Epf]>0"
        globalmod.DataSetRet(sql, "Vw3")


        sql = "insert into  TransferToAcc(Code, Name, Dramt, Cramt, HeadOrder,Narration,AcPost) values("

        If (organization = "Org001") Then
            sql &= "'**EX0014',"
        ElseIf (organization = "Org002") Then
            sql &= "'**EX0010',"
        End If
        sql &= "'C.P.F.',"
        sql &= "'0',"
        sql &= "'" & 2 * Val(globalmod.ds.Tables("Vw3").Rows(0)(0)) & "',"
        sql &= "'E',"
        sql &= "'BEING AMOUNT OF C.P.F.EXPS. BOTH FOR THE MONTH OF" & DateTimePicker1.Text & "' ,'" & joingpost & "')"
        globalmod.SqlExecuteNonQuery(sql)


        'individual staff credit to salary ESI BOTH-ESI  differnce Employee Contribution a/c

        sql = "insert into  TransferToAcc(Code, Name, Cramt, Dramt,HeadOrder, Narration,AcPost) "
        sql &= "select EmpId,Name,0,[Esic_Both]-[Esic] ,'R','BEING AMOUNT OF  ESI  Employee Contribution FOR THE MONTH  OF  " & DateTimePicker1.Text & "'  ,'" & joingpost & "' from vwDateWiseSal  vw   inner join Seniority s  on  vw.JoinPost= S.JoinPost where organization='" & globalmod.organization & "' and salmonth='" _
        & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and vw.JoinPost  in('" & joingpost & "') and [Before Epf]>0  order by s.sequence ,Empid"
        globalmod.SqlExecuteNonQuery(sql)


        'individual staff credit to salary a/c

        sql = "insert into  TransferToAcc(Code, Name, Dramt, Cramt,HeadOrder, Narration,AcPost) "
        sql &= "select EmpId,Name,0,[Before Epf] ,'B','BEING AMOUNT OF STAFF SALARY FOR THE MONTH  OF  " & DateTimePicker1.Text & "'  ,'" & joingpost & "' from vwDateWiseSal  vw   inner join Seniority s  on  vw.JoinPost= S.JoinPost where organization='" & globalmod.organization & "' and salmonth='" _
        & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and vw.JoinPost  in('" & joingpost & "') and [Before Epf]>0 order by s.sequence ,Empid"
        globalmod.SqlExecuteNonQuery(sql)

        'salary debit to ESI Contribution a/c
        sql = "select sum([Esic_Both]) from vwDateWiseSal where organization='" & globalmod.organization & "' and salmonth='" _
                            & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and JoinPost in('" & joingpost & "') and [Before Epf]>0"
        globalmod.DataSetRet(sql, "Vw1")

        sql = "insert into  TransferToAcc(Code, Name, Dramt, Cramt,HeadOrder, Narration,AcPost) values("
        If (organization = "Org001") Then
            sql &= "'**EX0073',"
        ElseIf (organization = "Org002") Then
            sql &= "'**EX0046',"
        End If

        sql &= "'ESI-BOTH CONTRIBUTION',"
        sql &= "'0',"
        sql &= "'" & globalmod.ds.Tables("Vw1").Rows(0)(0) & "',"
        sql &= "'K',"  '-------- Head Order
        sql &= "'BEING AMOUNT OF ESI-BOTH CONTRIBUTION FOR THE MONTH OF  " & DateTimePicker1.Text & "' ,'" & joingpost & "')"
        globalmod.SqlExecuteNonQuery(sql)

        'ESI EMPLOYER CONTRIBUTION Debit a/c
        sql = "select sum([Esic]) from vwDateWiseSal  where organization='" & globalmod.organization & "' and salmonth='" _
                            & DateTimePicker1.Value.ToShortDateString & "'  and (leaving_date>salmonth or leaving_date is null)  and JoinPost in('" & joingpost & "') and [Before Epf]>0"
        globalmod.DataSetRet(sql, "Vw1")

        sql = "insert into  TransferToAcc(Code, Name, Dramt, Cramt,HeadOrder, Narration,AcPost) values("
        If (organization = "Org001") Then
            sql &= "'**EX0072',"
        ElseIf (organization = "Org002") Then
            sql &= "'**EX0045',"
        End If
        sql &= "'ESI-EMPLOYER CONTRIBUTION',"
        sql &= "'" & globalmod.ds.Tables("Vw1").Rows(0)(0) & "',"
        sql &= "'0',"
        sql &= "'Q',"  '-------- Head Order
        sql &= "'BEING AMOUNT OF ESI-EMPLOYEER CONTRIBUTION FOR THE MONTH OF  " & DateTimePicker1.Text & "' ,'" & joingpost & "')"
        globalmod.SqlExecuteNonQuery(sql)




        ''indivisual staff epf a/c debit
        'sql = " insert into  TransferToAcc(Code, Name, Dramt, Cramt,HeadOrder, Narration) "
        'sql &= " select EmpId,Name,epf,0,'D'  ,'BEING AMOUNT OF STAFF EMPLOYEE CONTRIBUTION FOR THE MONTH  OF  " & DateTimePicker1.Text & "'  from vwDateWiseSal where organization='" & globalmod.organization & "' and salmonth='" _
        '& DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and JoinPost in(" & joingpost & ") and [Before Epf]>0"
        'globalmod.SqlExecuteNonQuery(sql)




        'PF tax debit to indivaual a/c 
        sql = "insert into  TransferToAcc(Code, Name, Dramt, Cramt,HeadOrder, Narration,AcPost) "
        sql &= "select EmpId,Name,tax,0 ,'D','BEING AMOUNT OF STAFF PROFESSIONAL TAX FOR THE MONTH OF  " & DateTimePicker1.Text & "'  ,'" & joingpost & "' from vwDateWiseSal  vw   inner join Seniority s  on  vw.JoinPost= S.JoinPost  where organization='" & globalmod.organization & "' and salmonth='" _
        & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and vw.JoinPost  in('" & joingpost & "') and [tax]>0  order by s.sequence ,Empid"
        globalmod.SqlExecuteNonQuery(sql)

        'total pf tax credit to proff tax 
        sql = "select sum(tax) from vwDateWiseSal  where organization='" & globalmod.organization & "' and salmonth='" _
                                           & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and JoinPost  in('" & joingpost & "') and [Before Epf]>0"
        globalmod.DataSetRet(sql, "Vw4")

        sql = "insert into  TransferToAcc(Code, Name, Dramt, Cramt,HeadOrder, Narration,AcPost) values("

        If (organization = "Org001") Then
            sql &= "'**EX0040',"
        ElseIf (organization = "Org002") Then
            sql &= "'**EX0027',"
        End If
        sql &= "'PROFESSIONAL TAX',"
        sql &= "'0',"
        sql &= "'" & Val(globalmod.ds.Tables("Vw4").Rows(0)(0)) & "',"
        sql &= "'E',"
        sql &= "'BEING AMOUNT OF STAFF PROFESSIONAL TAX FOR THE MONTH OF " & DateTimePicker1.Text & "' ,'" & joingpost & "')"
        globalmod.SqlExecuteNonQuery(sql)

        'TDS tax debit to indivaual a/c 
        sql = "insert into  TransferToAcc(Code, Name, Dramt, Cramt,HeadOrder, Narration,AcPost) "
        sql &= "select EmpId,Name,tdsded,0 ,'BEING AMOUNT OF T.D.S.FROM STAFF SALARY FOR THE MONTH OF  " & DateTimePicker1.Text & "'  ,'" & joingpost & "' from vwDateWiseSal  vw   inner join Seniority s  on  vw.JoinPost= S.JoinPost  where organization='" & globalmod.organization & "' and salmonth='" _
        & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and vw.JoinPost in('" & joingpost & "') and [tdsded]>0  order by s.sequence ,Empid"
        globalmod.SqlExecuteNonQuery(sql)

        'total tds tax credit to tds a/c
        sql = "select sum(tdsded) from vwDateWiseSal    where organization='" & globalmod.organization & "' and salmonth='" _
                                           & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and JoinPost  in('" & joingpost & "') and [Before Epf]>0"
        globalmod.DataSetRet(sql, "Vw5")

        sql = "insert into  TransferToAcc(Code, Name, Dramt, Cramt,HeadOrder, Narration,AcPost) values("
        sql &= "'**TD0007',"
        sql &= "'TDS-(SALARY)',"
        sql &= "'0',"
        sql &= "'" & Val(globalmod.ds.Tables("Vw5").Rows(0)(0)) & "',"
        sql &= "'I',"
        sql &= "'BEING AMOUNT OF T.D.S.FROM STAFF SALARY FOR THE MONTH OF " & DateTimePicker1.Text & "' ,'" & joingpost & "')"
        globalmod.SqlExecuteNonQuery(sql)


    End Sub
    Public Sub transfertoacnonpf(ByVal joingpost As String)
        Dim sql As String
        'salary debit to salaty a/c
        sql = "select sum([Before Epf]) from vwDateWiseSal  where organization='" & globalmod.organization & "' and salmonth='" _
                    & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null) and is_pen_fund=0  and JoinPost in('" & joingpost & "')  "
        globalmod.DataSetRet(sql, "Vw1")
        '**EX0067	STAFF RUNN. & MAINT. EXPS.

        sql = "insert into  TransferToAcc(Code, Name, Dramt, Cramt,HeadOrder, Narration ,AcPost) values("
        If (organization = "Org001") Then
            sql &= "'**EX0067',"
        ElseIf (organization = "Org002") Then
            sql &= "'**EX0042',"
        End If
        sql &= "'STAFF RUNN. & MAINT. EXPS.',"
        sql &= "'" & globalmod.ds.Tables("Vw1").Rows(0)(0) & "',"
        sql &= "'0',"
        sql &= "'A',"
        sql &= "'BEING AMOUNT OF STAFF SALARY FOR THE MONTH  OF  " & DateTimePicker1.Text & "' ,'" & joingpost & "')"
        globalmod.SqlExecuteNonQuery(sql)

        'indivisual staff credit to salary a/c
        sql = "insert into  TransferToAcc(Code, Name, Dramt, Cramt,HeadOrder, Narration ,AcPost) "
        sql &= "select EmpId,Name,0,[Before Epf] ,'B','BEING AMOUNT OF STAFF SALARY FOR THE MONTH  OF  " & DateTimePicker1.Text & "'  ,'" & joingpost & "'  from vwDateWiseSal  vw   inner join Seniority s  on  vw.JoinPost= S.JoinPost where organization='" & globalmod.organization & "' and salmonth='" _
        & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and is_pen_fund=0  and vw.JoinPost  in('" & joingpost & "')   order by s.sequence ,Empid"
        globalmod.SqlExecuteNonQuery(sql)

        'EMPLOYER CONTRIBUTION debit to a/c
        sql = "select sum(Epf) from vwDateWiseSal   where organization='" & globalmod.organization & "' and salmonth='" _
                   & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and is_pen_fund=0  and JoinPost  in('" & joingpost & "') "
        globalmod.DataSetRet(sql, "Vw2")

        If (globalmod.ds.Tables("Vw2").Rows.Count > 0) Then
            sql = "insert into  TransferToAcc(Code, Name, Dramt, Cramt,HeadOrder, Narration,AcPost) values("
            If (organization = "Org001") Then
                sql &= "'**EX0013',"
            ElseIf (organization = "Org002") Then
                sql &= "'**EX0009',"
            End If
            sql &= "'EMPLOYER CONTRIBUTION',"
            sql &= "'" & globalmod.ds.Tables("Vw2").Rows(0)(0) & "',"
            sql &= "'0',"
            sql &= "'C',"
            sql &= "'BEING AMOUNT OF STAFF EMPLOYER CONTRIBUTION FOR THE MONTH  OF  " & DateTimePicker1.Text & "'  ,'" & joingpost & "')"
            globalmod.SqlExecuteNonQuery(sql)

        End If


        ''indivisual staff epf a/c debit
        sql = " insert into  TransferToAcc(Code, Name, Dramt, Cramt,HeadOrder, Narration,AcPost) "
        sql &= " select EmpId,Name,epf,0 ,'D','BEING AMOUNT OF STAFF EMPLOYEE CONTRIBUTION FOR THE MONTH  OF  " & DateTimePicker1.Text & "'   ,'" & joingpost & "' from vwDateWiseSal  vw   inner join Seniority s  on  vw.JoinPost= S.JoinPost where organization='" & globalmod.organization & "' and salmonth='" _
        & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and is_pen_fund=0  and vw.JoinPost in('" & joingpost & "')  order by s.sequence ,Empid"
        globalmod.SqlExecuteNonQuery(sql)

        'cpf a/c credit 
        sql = "select sum(Epf) from vwDateWiseSal where organization='" & globalmod.organization & "' and salmonth='" _
                               & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and is_pen_fund=0   and JoinPost  in('" & joingpost & "')"
        globalmod.DataSetRet(sql, "Vw3")
        If (globalmod.ds.Tables("Vw3").Rows.Count > 0) Then


            sql = "insert into  TransferToAcc(Code, Name, Dramt, Cramt,HeadOrder, Narration,AcPost) values("
            If (organization = "Org001") Then
                sql &= "'**EX0014',"
            ElseIf (organization = "Org002") Then
                sql &= "'**EX0010',"
            End If

            sql &= "'C.P.F.',"
            sql &= "'0',"
            sql &= "'" & 2 * Val(globalmod.ds.Tables("Vw3").Rows(0)(0)) & "',"
            sql &= "'E',"
            sql &= "'BEING AMOUNT OF C.P.F.EXPS. BOTH FOR THE MONTH OF" & DateTimePicker1.Text & "'  ,'" & joingpost & "')"
            globalmod.SqlExecuteNonQuery(sql)
        End If

        'PF tax debit to indivaual a/c 
        sql = "insert into  TransferToAcc(Code, Name, Dramt, Cramt,HeadOrder, Narration ,AcPost) "
        sql &= "select EmpId,Name,tax,0 ,'F','BEING AMOUNT OF STAFF PROFESSIONAL TAX FOR THE MONTH OF  " & DateTimePicker1.Text & "'  ,'" & joingpost & "'  from vwDateWiseSal   vw   inner join Seniority s  on  vw.JoinPost= S.JoinPost  where organization='" & globalmod.organization & "' and salmonth='" _
        & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and is_pen_fund=0  and vw.JoinPost  in('" & joingpost & "') and [tax]>0  order by s.sequence ,Empid"
        globalmod.SqlExecuteNonQuery(sql)

        'total pf tax credit to proff tax 
        sql = "select sum(tax) from vwDateWiseSal   where organization='" & globalmod.organization & "' and salmonth='" _
                                           & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and is_pen_fund=0  and JoinPost  in('" & joingpost & "') "
        globalmod.DataSetRet(sql, "Vw4")
        If (globalmod.ds.Tables("Vw4").Rows.Count > 0) Then

            sql = "insert into  TransferToAcc(Code, Name, Dramt, Cramt,HeadOrder, Narration ,AcPost) values("
            If (organization = "Org001") Then
                sql &= "'**EX0040',"
            ElseIf (organization = "Org002") Then
                sql &= "'**EX0027',"
            End If
            sql &= "'PROFESSIONAL TAX',"
            sql &= "'0',"
            sql &= "'" & Val(globalmod.ds.Tables("Vw4").Rows(0)(0)) & "',"
            sql &= "'G',"
            sql &= "'BEING AMOUNT OF STAFF PROFESSIONAL TAX FOR THE MONTH OF " & DateTimePicker1.Text & "'  ,'" & joingpost & "')"
            globalmod.SqlExecuteNonQuery(sql)
        End If
        'TDS tax debit to indivaual a/c 
        sql = "insert into  TransferToAcc(Code, Name, Dramt, Cramt,HeadOrder, Narration ,AcPost) "
        sql &= "select EmpId,Name,tdsded,0 ,'H','BEING AMOUNT OF T.D.S.FROM STAFF SALARY FOR THE MONTH OF  " & DateTimePicker1.Text & "'  ,'" & joingpost & "'  from vwDateWiseSal  vw   inner join Seniority s  on  vw.JoinPost= S.JoinPost where organization='" & globalmod.organization & "' and salmonth='" _
        & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and is_pen_fund=0  and vw.JoinPost in('" & joingpost & "') and [tdsded]>0  order by s.sequence ,Empid"
        globalmod.SqlExecuteNonQuery(sql)

        'total tds tax credit to tds a/c
        sql = "select sum(tdsded) from vwDateWiseSal where organization='" & globalmod.organization & "' and salmonth='" _
                                           & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and is_pen_fund=0  and JoinPost  in('" & joingpost & "') "
        globalmod.DataSetRet(sql, "Vw5")

        sql = "insert into  TransferToAcc(Code, Name, Dramt, Cramt,HeadOrder, Narration ,AcPost) values("
        If (organization = "Org001") Then
            sql &= "'**EX0040',"
        ElseIf (organization = "Org002") Then
            sql &= "'**EX0027',"
        End If
        sql &= "'PROFESSIONAL TAX',"
        sql &= "'0',"
        sql &= "'" & Val(globalmod.ds.Tables("Vw5").Rows(0)(0)) & "',"
        sql &= "'I',"
        sql &= "'BEING AMOUNT OF T.D.S.FROM STAFF SALARY FOR THE MONTH OF " & DateTimePicker1.Text & "'  ,'" & joingpost & "')"
        globalmod.SqlExecuteNonQuery(sql)


    End Sub
    Public Sub transfertoacin_other_staff_lws(ByVal joingpost As String)
        On Error Resume Next
        Dim sql As String
        Dim post As String

        post = "BUS CONDUCTOR"
        'salary debit to salary a/c
        sql = "select sum([Before Epf]) from vwDateWiseSal where organization='" & globalmod.organization & "' and salmonth='" _
                    & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and JoinPost in(" & joingpost & ") and [Before Epf]>0  "
        globalmod.DataSetRet(sql, "Vw1")

        sql = "insert into  TransferToAcc(Code, Name, Dramt, Cramt,HeadOrder, Narration,AcPost) values("
        If (organization = "Org001") Then
            sql &= "'**EX0012',"
        ElseIf (organization = "Org002") Then
            sql &= "'**EX0008',"
        End If

        sql &= "'SALARY EXPS.',"
        sql &= "'" & globalmod.ds.Tables("Vw1").Rows(0)(0) & "',"
        sql &= "'0',"
        sql &= "'A',"  '-------- Head Order
        sql &= "'BEING AMOUNT OF STAFF SALARY FOR THE MONTH  OF  " & DateTimePicker1.Text & "' ,'" & post & "')"
        globalmod.SqlExecuteNonQuery(sql)

        'EMPLOYER CONTRIBUTION debit to a/c
        sql = "select sum(Epf) from vwDateWiseSal   where organization='" & globalmod.organization & "' and salmonth='" _
                   & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and JoinPost in (" & joingpost & ") and [Before Epf]>0 "
        globalmod.DataSetRet(sql, "Vw2")

        sql = "insert into  TransferToAcc(Code, Name, Dramt, Cramt,HeadOrder, Narration,AcPost) values("

        If (organization = "Org001") Then
            sql &= "'**EX0013',"
        ElseIf (organization = "Org002") Then
            sql &= "'**EX0009',"
        End If

        sql &= "'EMPLOYER CONTRIBUTION',"
        sql &= "'" & globalmod.ds.Tables("Vw2").Rows(0)(0) & "',"
        sql &= "'0',"
        sql &= "'C',"             '---------Head Order
        sql &= "'BEING AMOUNT OF STAFF EMPLOYER CONTRIBUTION FOR THE MONTH  OF  " & DateTimePicker1.Text & "' ,'" & post & "')"
        globalmod.SqlExecuteNonQuery(sql)

        'indivisual staff epf a/c debit
        sql = " insert into  TransferToAcc(Code, Name, Dramt, Cramt,HeadOrder, Narration,AcPost) "
        sql &= " select EmpId,Name,epf,0 ,'D','BEING AMOUNT OF STAFF EMPLOYEE CONTRIBUTION FOR THE MONTH  OF  " & DateTimePicker1.Text & "'  , '" & post & "' from vwDateWiseSal vw   inner join Seniority s  on  vw.JoinPost= S.JoinPost where organization='" & globalmod.organization & "' and salmonth='" _
        & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and vw.JoinPost  in(" & joingpost & ") and [Before Epf]>0 order by s.sequence ,Empid"
        globalmod.SqlExecuteNonQuery(sql)

        'cpf a/c credit 
        sql = "select sum(Epf) from vwDateWiseSal where organization='" & globalmod.organization & "' and salmonth='" _
                               & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and JoinPost  in(" & joingpost & ") and [Before Epf]>0"
        globalmod.DataSetRet(sql, "Vw3")


        sql = "insert into  TransferToAcc(Code, Name, Dramt, Cramt, HeadOrder,Narration,AcPost) values("

        If (organization = "Org001") Then
            sql &= "'**EX0014',"
        ElseIf (organization = "Org002") Then
            sql &= "'**EX0010',"
        End If
        sql &= "'C.P.F.',"
        sql &= "'0',"
        sql &= "'" & 2 * Val(globalmod.ds.Tables("Vw3").Rows(0)(0)) & "',"
        sql &= "'E',"
        sql &= "'BEING AMOUNT OF C.P.F.EXPS. BOTH FOR THE MONTH OF" & DateTimePicker1.Text & "' ,'" & post & "')"
        globalmod.SqlExecuteNonQuery(sql)


        'individual staff credit to salary ESI BOTH-ESI  differnce Employee Contribution a/c

        sql = "insert into  TransferToAcc(Code, Name, Cramt, Dramt,HeadOrder, Narration,AcPost) "
        sql &= "select EmpId,Name,0,[Esic_Both]-[Esic] ,'R','BEING AMOUNT OF  ESI  Employee Contribution FOR THE MONTH  OF  " & DateTimePicker1.Text & "'  ,'" & post & "' from vwDateWiseSal  vw   inner join Seniority s  on  vw.JoinPost= S.JoinPost where organization='" & globalmod.organization & "' and salmonth='" _
        & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and vw.JoinPost  in(" & joingpost & ") and [Before Epf]>0  order by s.sequence ,Empid"
        globalmod.SqlExecuteNonQuery(sql)


        'individual staff credit to salary a/c

        sql = "insert into  TransferToAcc(Code, Name, Dramt, Cramt,HeadOrder, Narration,AcPost) "
        sql &= "select EmpId,Name,0,[Before Epf] ,'B','BEING AMOUNT OF STAFF SALARY FOR THE MONTH  OF  " & DateTimePicker1.Text & "'  ,'" & post & "' from vwDateWiseSal  vw   inner join Seniority s  on  vw.JoinPost= S.JoinPost where organization='" & globalmod.organization & "' and salmonth='" _
        & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and vw.JoinPost  in(" & joingpost & ") and [Before Epf]>0 order by s.sequence ,Empid"
        globalmod.SqlExecuteNonQuery(sql)

        'salary debit to ESI Contribution a/c
        sql = "select sum([Esic_Both]) from vwDateWiseSal where organization='" & globalmod.organization & "' and salmonth='" _
                            & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and JoinPost in(" & joingpost & ") and [Before Epf]>0"
        globalmod.DataSetRet(sql, "Vw1")

        sql = "insert into  TransferToAcc(Code, Name, Dramt, Cramt,HeadOrder, Narration,AcPost) values("
        If (organization = "Org001") Then
            sql &= "'**EX0073',"
        ElseIf (organization = "Org002") Then
            sql &= "'**EX0046',"
        End If

        sql &= "'ESI-BOTH CONTRIBUTION',"
        sql &= "'0',"
        sql &= "'" & globalmod.ds.Tables("Vw1").Rows(0)(0) & "',"
        sql &= "'K',"  '-------- Head Order
        sql &= "'BEING AMOUNT OF ESI-BOTH CONTRIBUTION FOR THE MONTH OF  " & DateTimePicker1.Text & "' ,'" & post & "')"
        globalmod.SqlExecuteNonQuery(sql)

        'ESI EMPLOYER CONTRIBUTION Debit a/c
        sql = "select sum([Esic]) from vwDateWiseSal  where organization='" & globalmod.organization & "' and salmonth='" _
                            & DateTimePicker1.Value.ToShortDateString & "'  and (leaving_date>salmonth or leaving_date is null)  and JoinPost in(" & joingpost & ") and [Before Epf]>0"
        globalmod.DataSetRet(sql, "Vw1")

        sql = "insert into  TransferToAcc(Code, Name, Dramt, Cramt,HeadOrder, Narration,AcPost) values("
        If (organization = "Org001") Then
            sql &= "'**EX0072',"
        ElseIf (organization = "Org002") Then
            sql &= "'**EX0045',"
        End If
        sql &= "'ESI-EMPLOYER CONTRIBUTION',"
        sql &= "'" & globalmod.ds.Tables("Vw1").Rows(0)(0) & "',"
        sql &= "'0',"
        sql &= "'Q',"  '-------- Head Order
        sql &= "'BEING AMOUNT OF ESI-EMPLOYEER CONTRIBUTION FOR THE MONTH OF  " & DateTimePicker1.Text & "' ,'" & post & "')"
        globalmod.SqlExecuteNonQuery(sql)




        ''indivisual staff epf a/c debit
        'sql = " insert into  TransferToAcc(Code, Name, Dramt, Cramt,HeadOrder, Narration) "
        'sql &= " select EmpId,Name,epf,0,'D'  ,'BEING AMOUNT OF STAFF EMPLOYEE CONTRIBUTION FOR THE MONTH  OF  " & DateTimePicker1.Text & "'  from vwDateWiseSal where organization='" & globalmod.organization & "' and salmonth='" _
        '& DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and JoinPost in(" & joingpost & ") and [Before Epf]>0"
        'globalmod.SqlExecuteNonQuery(sql)




        'PF tax debit to indivaual a/c 
        sql = "insert into  TransferToAcc(Code, Name, Dramt, Cramt,HeadOrder, Narration,AcPost) "
        sql &= "select EmpId,Name,tax,0 ,'D','BEING AMOUNT OF STAFF PROFESSIONAL TAX FOR THE MONTH OF  " & DateTimePicker1.Text & "'  ,'" & post & "' from vwDateWiseSal  vw   inner join Seniority s  on  vw.JoinPost= S.JoinPost  where organization='" & globalmod.organization & "' and salmonth='" _
        & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and vw.JoinPost  in(" & joingpost & ") and [tax]>0  order by s.sequence ,Empid"
        globalmod.SqlExecuteNonQuery(sql)

        'total pf tax credit to proff tax 
        sql = "select sum(tax) from vwDateWiseSal  where organization='" & globalmod.organization & "' and salmonth='" _
                                           & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and JoinPost  in(" & joingpost & ") and [Before Epf]>0"
        globalmod.DataSetRet(sql, "Vw4")

        sql = "insert into  TransferToAcc(Code, Name, Dramt, Cramt,HeadOrder, Narration,AcPost) values("

        If (organization = "Org001") Then
            sql &= "'**EX0040',"
        ElseIf (organization = "Org002") Then
            sql &= "'**EX0027',"
        End If
        sql &= "'PROFESSIONAL TAX',"
        sql &= "'0',"
        sql &= "'" & Val(globalmod.ds.Tables("Vw4").Rows(0)(0)) & "',"
        sql &= "'E',"
        sql &= "'BEING AMOUNT OF STAFF PROFESSIONAL TAX FOR THE MONTH OF " & DateTimePicker1.Text & "' ,'" & post & "')"
        globalmod.SqlExecuteNonQuery(sql)

        'TDS tax debit to indivaual a/c 
        sql = "insert into  TransferToAcc(Code, Name, Dramt, Cramt,HeadOrder, Narration,AcPost) "
        sql &= "select EmpId,Name,tdsded,0 ,'BEING AMOUNT OF T.D.S.FROM STAFF SALARY FOR THE MONTH OF  " & DateTimePicker1.Text & "'  ,'" & post & "' from vwDateWiseSal  vw   inner join Seniority s  on  vw.JoinPost= S.JoinPost  where organization='" & globalmod.organization & "' and salmonth='" _
        & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and vw.JoinPost in(" & joingpost & ") and [tdsded]>0  order by s.sequence ,Empid"
        globalmod.SqlExecuteNonQuery(sql)

        'total tds tax credit to tds a/c
        sql = "select sum(tdsded) from vwDateWiseSal    where organization='" & globalmod.organization & "' and salmonth='" _
                                           & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and JoinPost  in(" & joingpost & ") and [Before Epf]>0"
        globalmod.DataSetRet(sql, "Vw5")

        sql = "insert into  TransferToAcc(Code, Name, Dramt, Cramt,HeadOrder, Narration,AcPost) values("
        sql &= "'**TD0007',"
        sql &= "'TDS-(SALARY)',"
        sql &= "'0',"
        sql &= "'" & Val(globalmod.ds.Tables("Vw5").Rows(0)(0)) & "',"
        sql &= "'I',"
        sql &= "'BEING AMOUNT OF T.D.S.FROM STAFF SALARY FOR THE MONTH OF " & DateTimePicker1.Text & "' ,'" & post & "')"
        globalmod.SqlExecuteNonQuery(sql)


    End Sub
    Private Sub DateTimePicker1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DateTimePicker1.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub DateTimePicker1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTimePicker1.Leave
        DateTimePicker1.Value = Month(DateTimePicker1.Value) & "/1/" & Year(DateTimePicker1.Value)
    End Sub

    Private Sub Cmb_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cmb.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Dim sql As String = ""
        Dim r As New CrTransferToAc
        sql &= "select * from dbo.TransferToAcc where AcPost='" & cmbPost.Text & "'   "
        '''---'--and  dramt <> 0 or cramt <>0 order by  sequence,code, id desc"
        globalmod.DataSetRet(Sql, "Vw9")



        r.SetDataSource(globalmod.ds.Tables("Vw9"))
        r.SetParameterValue("p1", Cmb.Text & " " & DateTimePicker1.Text)
        CrystalReportViewer1.ReportSource = r
    End Sub

    Private Sub Cmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb.SelectedIndexChanged

        Dim joingpost, sqljoinpost As String

        If Cmb.Text = "TEACHERS" Then

            joingpost = "'DRIVER','CONDUCTOR','MAID/POEN','FIXED','TEACHER','OTHER OFFICE STAFF','BAND MASTER','GARDENER','OTHER LABOUR','S.POOL','SWEEPER','CO-ORDINATOR','OFFICE INCHARGE-1','PART TIME MAID','BUS CONDUCTOR'"



            sqljoinpost = "select distinct joinpost from vwDateWiseSal  where organization='" & globalmod.organization & "' and salmonth='" _
                               & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and JoinPost not in(" & joingpost & ") and [Before Epf]>0   "
            globalmod.DataSetRet(sqljoinpost, "Vw_post")



        ElseIf Cmb.Text = "DRIVER,CONDUCTOR,SUPPORING STAFF" Then
            ' sql = "select * from vwDateWiseSal where organization='" & globalmod.organization & "' and salmonth='" & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and JoinPost in('DRIVER','CONDUCTOR','MAID/POEN')"
            joingpost = "'DRIVER','CONDUCTOR','MAID/POEN'"

            sqljoinpost = "select distinct joinpost from vwDateWiseSal  where organization='" & globalmod.organization & "' and salmonth='" _
                              & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and JoinPost  in(" & joingpost & ") and [Before Epf]>0   "
            globalmod.DataSetRet(sqljoinpost, "Vw_post")

        ElseIf Cmb.Text = "FIXED" Then
            'sql = "select * from vwDateWiseSal where organization='" & globalmod.organization & "' and salmonth='" & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and JoinPost ='FIXED'"
            joingpost = "'FIXED'"
            sqljoinpost = "select distinct joinpost from vwDateWiseSal  where organization='" & globalmod.organization & "' and salmonth='" _
                                          & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and JoinPost  in(" & joingpost & ") and [Before Epf]>0   "
            globalmod.DataSetRet(sqljoinpost, "Vw_post")


        ElseIf Cmb.Text = "OTHER TEACHING STAFF" Then
            'sql = "select * from vwDateWiseSal where organization='" & globalmod.organization & "' and salmonth='" & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null) and is_pen_fund=0 and JoinPost in('TEACHER','OTHER OFFICE STAFF','BAND MASTER','CO-ORDINATOR','OFFICE INCHARGE-1')"
            joingpost = "'TEACHER','OTHER OFFICE STAFF','BAND MASTER','CO-ORDINATOR','OFFICE INCHARGE-1'"

            sqljoinpost = "select distinct joinpost from vwDateWiseSal  where organization='" & globalmod.organization & "' and salmonth='" _
                                          & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and JoinPost  in(" & joingpost & ")   "
            globalmod.DataSetRet(sqljoinpost, "Vw_post")

        ElseIf Cmb.Text = "LABOUR STAFF" Then
            'sql = "select * from vwDateWiseSal where organization='" & globalmod.organization & "' and salmonth='" & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null) and JoinPost in('GARDENER','OTHER LABOUR','S.POOL','SWEEPER')"
            joingpost = "'GARDENER','OTHER LABOUR','S.POOL','SWEEPER'"
            sqljoinpost = "select distinct joinpost from vwDateWiseSal  where organization='" & globalmod.organization & "' and salmonth='" _
                                          & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and JoinPost in(" & joingpost & ") and [Before Epf]>0   "
            globalmod.DataSetRet(sqljoinpost, "Vw_post")


        ElseIf Cmb.Text = "PART TIME CASUAL STAFF" Then
            ' sql = "select * from vwDateWiseSal where organization='" & globalmod.organization & "' and salmonth='" & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null) and JoinPost in('BUS CONDUCTOR','PART TIME MAID')"
            joingpost = "'BUS CONDUCTOR','PART TIME MAID'"

            sqljoinpost = "select distinct joinpost from vwDateWiseSal  where organization='" & globalmod.organization & "' and salmonth='" _
                                   & DateTimePicker1.Value.ToShortDateString & "' and (leaving_date>salmonth or leaving_date is null)  and JoinPost in(" & joingpost & ") and [Before Epf]>0   "
            globalmod.DataSetRet(sqljoinpost, "Vw_post")

        End If
        cmbPost.DataSource = globalmod.ds.Tables("Vw_post")
        cmbPost.DisplayMember = "joinpost"
    End Sub


End Class