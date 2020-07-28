Public Class frmempsal_acc_to_mothdays

    Private Sub frmempsalaryentry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePickersalmonth1.Text = setmonth

        Dim sql As String
        sql = "select  maxpfamt,totalpfamt from salarystructuremaster"
        globalmod.DataSetRet(sql, "salarypf")
        globalmod.max_pf833_amt = ds.Tables("salarypf").Rows(0)(0)
        globalmod.tot_pf = ds.Tables("salarypf").Rows(0)(1)
        sql = "select orgid from organizationmaster"
        globalmod.DataSetRet(sql, "oid")
        ComboBox1oid.DataSource = ds.Tables("oid")
        ComboBox1oid.DisplayMember = "orgid"

        remvalue()


        'sql = "select orgid as Org,eal.empid as EmpID,employee as Name" _
        '& ",deptno as Depart,designation as  Desg from emp_active_list " _
        '& " eal where not exists ( SELECT * from empsalary as es where" _
        '& "  month(salmonth)=month(?) and year(salmonth)=year(?) and eal.orgid=es.orgid and eal.empid=es.empid )and not exists ( SELECT * from emp_salary_t as es  where month(salmonth)=month(?) and"
        '                year(salmonth)=year(?) and 
        '                eal.orgid=es.orgid and eal.empid=es.empid ) "

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button1salfrommaster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1salfrommaster.Click
        Dim sql As String
        sql = "SELECT EMPINFOVIEW.orgid,  EMPINFOVIEW.empid,  EMPINFOVIEW.[name], " _
        & " EMPINFOVIEW.designation,EMPINFOVIEW.UID,EMPINFOVIEW.UIdCode FROM  EMPINFOVIEW where not exists " _
        & " ( select * from  empsalarytemp empsalary where " _
        & " salmonth='" & setmonth & "'" _
        & " and EMPINFOVIEW.orgid=empsalary.orgid and " _
        & " EMPINFOVIEW.empid = empsalary.empid )" _
        & " and not exists (select * from empsalarytemp where " _
        & " salmonth='" & setmonth & "'" _
        & " and EMPINFOVIEW.orgid=empsalarytemp.orgid and" _
        & " EMPINFOVIEW.empid=empsalarytemp.empid) and empinfoview.orgid='" _
        & organization & "'"

        globalmod.DataSetRet(sql, "empactive")
        DataGridView1.DataSource = ds.Tables("empactive")
        'MsgBox(ds.Tables("empactive").Rows.Count)
        Dim i As Integer
        For i = 0 To ds.Tables("empactive").Rows.Count - 1
            Me.Text = "SALARY GENERATING OF EMPLOYEE ID ::" & ds.Tables("empactive").Rows(i)(1).ToString()
            cal_sal_master(ds.Tables("empactive").Rows(i)(0), ds.Tables("empactive").Rows(i)(1))
        Next
        remvalue()
        loanded()
        globalmod.SqlExecuteNonQuery("exec leaveded '" & globalmod.organization & "','" & globalmod.setmonth & "'")
    End Sub
    'insert ing loan values 
    Dim noofins As Integer
    Dim remins As Integer
    Public Sub loanded()
        Dim sql As String
        Dim i As Integer
        If delfalg = False Then
            'sql = "select * from loanmaster where orgid='" & organization & "' and rem>0 and empid  not in (select empid from empsalarytemp  where salmonth='" & setmonth & "' and orgid='" & organization & "') order by empid"
            sql = " select * from loanmaster l " _
            & " inner join ( select * from empsalarytemp  where salmonth='" & globalmod.setmonth & "' and orgid='" & globalmod.organization & "' ) t " _
            & " on l.orgid = t.orgid and l.empid = t.empid"

            globalmod.DataSetRet(sql, "empins")


            For i = 0 To globalmod.ds.Tables("empins").Rows.Count - 1

                noofins = globalmod.ds.Tables("empins").Rows(i)("noofins")
                remins = globalmod.ds.Tables("empins").Rows(i)("remins")
                If remins <> 1 Then
                    sql = "update empsalarytemp set collegeloan='" & globalmod.ds.Tables("empins").Rows(i)("installmentamt") & "' where empid='" & globalmod.ds.Tables("empins").Rows(i)("empid") & "' and salmonth='" & setmonth & "' and orgid='" & organization & "'"
                    globalmod.SqlExecuteNonQuery(sql)

                    sql = "update loanmaster set rem = rem - '" & globalmod.ds.Tables("empins").Rows(i)("installmentamt") & "', remins = remins -1  where empid='" & globalmod.ds.Tables("empins").Rows(i)("empid") & "' and orgid='" & organization & "'"
                    globalmod.SqlExecuteNonQuery(sql)
                ElseIf remins = 1 Then
                    sql = "update empsalarytemp set collegeloan='" & globalmod.ds.Tables("empins").Rows(i)("rem") & "' where empid='" & globalmod.ds.Tables("empins").Rows(i)("empid") & "' and salmonth='" & setmonth & "' and orgid='" & organization & "'"
                    globalmod.SqlExecuteNonQuery(sql)

                    sql = "update loanmaster set rem = rem - '" & globalmod.ds.Tables("empins").Rows(i)("rem") & "', remins = remins -1  where empid='" & globalmod.ds.Tables("empins").Rows(i)("empid") & "' and orgid='" & organization & "'"
                    globalmod.SqlExecuteNonQuery(sql)


                End If
            Next
        ElseIf delfalg = True Then
            If flag = True Then
                'sql = "select * from loanmaster where orgid='" & organization & "' and rem>0 and empid  not in (select empid from empsalarytemp  where salmonth='" & setmonth & "' and orgid='" & organization & "') order by empid"
                sql = " select * from loanmaster l " _
                & " inner join ( select * from empsalarytemp  where salmonth='01/May/15' and orgid='Phoenix Poultry' ) t " _
                & " on l.orgid = t.orgid and l.empid = t.empid"

                globalmod.DataSetRet(sql, "empins")
                For i = 0 To globalmod.ds.Tables("empins").Rows.Count - 1
                    noofins = globalmod.ds.Tables("empins").Rows(i)("noofins")
                    remins = globalmod.ds.Tables("empins").Rows(i)("remins")
                    If remins <> 1 Then
                        sql = "update empsalarytemp set collegeloan='" & globalmod.ds.Tables("empins").Rows(i)("installmentamt") & "' where empid='" & globalmod.ds.Tables("empins").Rows(i)("empid") & "' and salmonth='" & setmonth & "' and orgid='" & organization & "'"
                        globalmod.SqlExecuteNonQuery(sql)

                        sql = "update loanmaster set rem = rem - '" & globalmod.ds.Tables("empins").Rows(i)("installmentamt") & "', remins = remins -1  where empid='" & globalmod.ds.Tables("empins").Rows(i)("empid") & "' and orgid='" & organization & "'"
                        globalmod.SqlExecuteNonQuery(sql)
                    ElseIf remins = 1 Then
                        sql = "update empsalarytemp set collegeloan='" & globalmod.ds.Tables("empins").Rows(i)("rem") & "' where empid='" & globalmod.ds.Tables("empins").Rows(i)("empid") & "' and salmonth='" & setmonth & "' and orgid='" & organization & "'"
                        globalmod.SqlExecuteNonQuery(sql)

                        sql = "update loanmaster set rem = rem - '" & globalmod.ds.Tables("empins").Rows(i)("rem") & "', remins = remins -1  where empid='" & globalmod.ds.Tables("empins").Rows(i)("empid") & "' and orgid='" & organization & "'"
                        globalmod.SqlExecuteNonQuery(sql)
                    End If
                Next
            End If
        End If
    End Sub

    'sachin code
    Private Function cal_sal_master(ByVal orgid As String, ByVal empid As String) As Int32
        Dim sql As String
        sql = "select * from empsalarystructure where orgid='" & organization & "' and empid='" & empid & "'"
        globalmod.DataSetRet(sql, "empinfo")


        If empid = "**FS1535" Then
            Dim l As Int16
            l = 45

        End If
        Dim dt As String = DateTimePicker1.Text
        Dim ispenfund As String = "True"
        Dim basic As String = "0"
        Try
            ispenfund = ds.Tables("empinfo").Rows(0)(11)
        Catch
        End Try

        'calculate the group insurance amount sachinghanghoria
        Dim grpin As Int32
        Try
            grpin = Convert.ToInt32(ds.Tables("empinfo").Rows(0)(12))
        Catch ex As Exception

        End Try
        'calculate professional tax sachin
        Dim proftax As Int32
        Try
            proftax = Convert.ToInt32(ds.Tables("empinfo").Rows(0)("ptax"))
        Catch ex As Exception

        End Try
        'calculat secdeposit sachin
        Dim secdep As Int32
        Try
            secdep = Convert.ToInt32(ds.Tables("empinfo").Rows(0)(14))

        Catch ex As Exception

        End Try

        Dim otded As Int32
        Try
            otded = Convert.ToInt32(ds.Tables("empinfo").Rows(0)(15))

        Catch ex As Exception

        End Try

        Dim pf As Int32 = 0

        Try
            pf = Convert.ToInt32(ds.Tables("empinfo").Rows(0)(6))

        Catch
            'MessageBox.Show("def")
        End Try
        Dim tot_amt As Int32 = 0
        Try
            basic = ds.Tables("empinfo").Rows(0)("pfbasic")
        Catch
        End Try


        Try
            tot_amt = Val(basic) '+ Convert.ToInt32(ds.Tables("empinfo").Rows(0)(3))
        Catch
            tot_amt = 0
        End Try


        Dim pf833 As Int32 = 0
        Dim pf367 As Int32 = 0
        If pf > 0 Then
            pf833 = pf_calculation(tot_amt, pf, ispenfund).pf833
            pf367 = pf_calculation(tot_amt, pf, ispenfund).pf367
        End If

        'code to fetch info about loan
        Dim sql1 As String
        sql1 = "select * from loanstatusview where orgid='" & organization & "' and empid='" & empid & "'"
        globalmod.DataSetRet(sql1, "loaninfo")

        Dim loan_amt As Int32 = 0
        Dim loan_bal As Int32 = 0
        Dim loan_inst As Int32 = 0
        Dim basic_amt As Int32 = 0

        Try
            loan_bal = 0
        Catch
            loan_bal = 0
        End Try
        Try
            loan_inst = 0
        Catch
            loan_inst = 0
        End Try


        Try
            basic_amt = Convert.ToInt32(ds.Tables("empinfo").Rows(0)(2))
        Catch
            basic_amt = 0
        End Try

        If loan_bal < loan_inst Then
            loan_amt = loan_bal
        Else
            loan_amt = loan_inst
        End If

        If loan_amt > basic_amt - pf833 - pf367 Then
            loan_amt = basic_amt - pf833 - pf367
        End If

        Try
            Dim getacc As String
            Dim sqlinsert As String
            getacc = "select isnull(accountno,'') accountno from empmaster where empid='" _
            & empid & "' and orgid='" & orgid & "'"
            globalmod.DataSetRet(getacc, "tbgetacc")

            If globalmod.ds.Tables("tbgetacc").Rows(0)(0) = "" Then
                sqlinsert = "insert into empsalarytemp(orgid, empid, salmonth," _
                        & " saldate, basic, amtpay, da, hra, cca, oa1, oa2, it, educease," _
                        & " proftax, collegeloan, lwp, remark, amt833, amt367, sheetno," _
                        & " userid, groupinsded, secudep, od1,paymode,UID,UIdCode,isfund) values('" & organization & "','" _
                        & empid & "','" & setmonth & "','" _
                        & DateTimePicker1.Text & "','" & basic & "','" & basic_amt & "','" _
                        & ds.Tables("empinfo").Rows(0)(3) & "','" _
                        & ds.Tables("empinfo").Rows(0)(4) & "','" _
                        & ds.Tables("empinfo").Rows(0)(5) & "','" _
                        & ds.Tables("empinfo").Rows(0)(7) & "','" _
                        & ds.Tables("empinfo").Rows(0)(8) & "','" _
                        & ds.Tables("empinfo").Rows(0)(9) & "','" _
                        & ds.Tables("empinfo").Rows(0)(10) & "','" _
                        & proftax & "','" & loan_amt & "','0','','" & pf833 & "','" _
                        & pf367 & "',1, '" & globalmod.soft_username & "','" & grpin & "','" _
                        & secdep & "','" & otded & "','CASH','" & ds.Tables("empinfo").Rows(0)("UID") & "','" & ds.Tables("empinfo").Rows(0)("UIdCode") & "','" & ds.Tables("empinfo").Rows(0)("is_pen_fund") & "')"
                globalmod.SqlExecuteNonQuery(sqlinsert)
            Else
                ' MsgBox(ds.Tables("empinfo").Rows.Count)
                ' MsgBox(ds.Tables("empinfo").Rows(0)(3).ToString)
                sqlinsert = "insert into empsalarytemp(orgid, empid, salmonth," _
                         & " saldate, basic, amtpay, da, hra, cca, oa1, oa2, it, educease," _
                         & " proftax, collegeloan, lwp, remark, amt833, amt367, sheetno," _
                         & " userid, groupinsded, secudep, od1,PAYMODE,UID,UIdCode,isfund) values('" & organization & "','" _
                         & empid & "','" & setmonth & "','" _
                         & DateTimePicker1.Text & "','" & basic & "','" & basic_amt & "','" _
                         & ds.Tables("empinfo").Rows(0)(3) & "','" _
                         & ds.Tables("empinfo").Rows(0)(4) & "','" _
                         & ds.Tables("empinfo").Rows(0)(5) & "','" _
                         & ds.Tables("empinfo").Rows(0)(7) & "','" _
                         & ds.Tables("empinfo").Rows(0)(8) & "','" _
                         & ds.Tables("empinfo").Rows(0)(9) & "','" _
                         & ds.Tables("empinfo").Rows(0)(10) & "','" _
                         & proftax & "','" & loan_amt & "','0','','" & pf833 & "','" _
                         & pf367 & "',1, '" & globalmod.soft_username & "','" & grpin & "','" _
                         & secdep & "','" & otded & "','BANK','" & ds.Tables("empinfo").Rows(0)("UID") & "','" & ds.Tables("empinfo").Rows(0)("UIdCode") & "','" & ds.Tables("empinfo").Rows(0)("is_pen_fund") & "')"
                globalmod.SqlExecuteNonQuery(sqlinsert)
            End If

            'emp_salary_tTableAdapter.Insert(orgid, empid, Convert.ToDateTime(dateTimePicker1.Text),
            ' sdateDateTimePicker.Value, Convert.ToInt32
            '(dataSet1.emp_salary_struct.Rows(0)("basic").ToString()),
            'Convert.ToInt32(dataSet1.emp_salary_struct.Rows(0)("basic").ToString()), _
            'Convert.ToInt32(dataSet1.emp_salary_struct.Rows(0)("da").ToString()),
            ' Convert.ToInt32(dataSet1.emp_salary_struct.Rows(0)("hra").ToString()), 
            'Convert.ToInt32(dataSet1.emp_salary_struct.Rows(0)("cca").ToString()),
            ' Convert.ToInt32(dataSet1.emp_salary_struct.Rows(0)("oa1").ToString()),
            ' Convert.ToInt32(dataSet1.emp_salary_struct.Rows(0)("oa2").ToString()),
            ' Convert.ToInt32(dataSet1.emp_salary_struct.Rows(0)("i_tax").ToString()), _
            'Convert.ToInt32(dataSet1.emp_salary_struct.Rows(0)("edc_cs").ToString()), 0, loan_amt, 0, "", pf833, _
            'pf367, 1, "Admin")
        Catch ex As Exception
            'MessageBox.Show(ex.ToString())
            MessageBox.Show("Please define salary structure for empid=" + empid.ToString())
        End Try

        Return 0
    End Function

    'code to calculate pf amount
    Private Function pf_calculation(ByVal tot_amt As Int32, ByVal pf As Int32, ByVal ispenfund As String) As PFDataType
        Dim pf833 As Int32 = 0
        Dim pf367 As Int32 = 0
        Dim pfd As PFDataType

        'calculation of P.F. // 
        If pf > globalmod.tot_pf Then
            pf = globalmod.tot_pf
        End If
        pf833 = Math.Round(tot_amt * 0.0833, 0, MidpointRounding.AwayFromZero)
        'pf833 = Convert.ToInt32(tot_amt * 0.0833)
        'pf367 = Convert.ToInt32(tot_amt * 0.0367); 
        pf367 = pf - pf833

        If ispenfund = "False" Then
            pf833 = 0
            pf367 = pf
        Else
            If pf833 > globalmod.max_pf833_amt Then
                pf833 = globalmod.max_pf833_amt
                pf367 = pf - globalmod.max_pf833_amt
            End If
        End If

        pfd.pf833 = pf833
        pfd.pf367 = pf367

        Return pfd
    End Function
    'structure for return8.33,3.67
    Public Structure PFDataType
        Public pf833 As Int32
        Public pf367 As Int32
    End Structure
    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            Dim sql As String
            sql = "SELECT orgid, empid, salmonth, saldate, basic, amtpay," _
                   & " da, hra, cca, oa1, oa2, it, educease, proftax, collegeloan," _
                   & " lwp, remark, amt833, amt367, sheetno, userid,groupinsded," _
                   & " secudep,od1,paymode FROM empsalarytemp" _
                   & " where  orgid='" & organization & "' and  empid='" _
                   & DataGridView1.SelectedRows(0).Cells(2).Value & "' and salmonth='" & setmonth & "'"
            'MsgBox(sql)
            globalmod.DataSetRet(sql, "empsal")
            'SACHIN
            Label18name.Text = DataGridView1.SelectedRows(0).Cells(3).Value
            TextBox1empid.Text = ds.Tables("empsal").Rows(0)(1)
            TextBox1amttopay.Text = ds.Tables("empsal").Rows(0)(5)
            TextBox1basic.Text = ds.Tables("empsal").Rows(0)(4)
            TextBox1da.Text = ds.Tables("empsal").Rows(0)(6)
            TextBox1itax.Text = ds.Tables("empsal").Rows(0)(11)
            TextBox1lwp.Text = ds.Tables("empsal").Rows(0)(15)
            TextBox2educease.Text = ds.Tables("empsal").Rows(0)(23)
            TextBox2hra.Text = ds.Tables("empsal").Rows(0)(7)
            TextBox3cca.Text = ds.Tables("empsal").Rows(0)(8)
            TextBox3proftax.Text = ds.Tables("empsal").Rows(0)(13)
            TextBox4loan.Text = ds.Tables("empsal").Rows(0)(14)
            TextBox4pf833.Text = ds.Tables("empsal").Rows(0)(17)
            TextBox5pf367.Text = ds.Tables("empsal").Rows(0)(18)
            TextBox5rem.Text = ds.Tables("empsal").Rows(0)(16)
            TextBox6oa1.Text = ds.Tables("empsal").Rows(0)(9)
            TextBox7oa2.Text = ds.Tables("empsal").Rows(0)(10)
            'show the value in labels
            Label23grpins.Text = ds.Tables("empsal").Rows(0)(21)
            TextBox1secdepo.Text = ds.Tables("empsal").Rows(0)(22)
            'code to calculate heads
            ComboBox1.Text = ds.Tables("empsal").Rows(0)("paymode").ToString
            calheads()


            sql = "select accountno from empmaster where orgid='" & organization & "' and  empid='" & DataGridView1.SelectedRows(0).Cells(2).Value & "' and status =1"
            globalmod.DataSetRet(sql, "empaccno")
            If globalmod.ds.Tables("empaccno").Rows(0)(0) = "" Then
                pmode = "CASH"
            Else
                pmode = "BANK"
            End If

        Catch ex As Exception

        End Try
    End Sub

    'function to calculate heads
    Private Sub calheads()
        cal_per()
        cal_gross()
        cal_pf()
        cal_to_ded()
        cal_net()
    End Sub

    'code to calculate different salary 


    'function to calculate daper,hrper,ccaper

    Private Sub cal_per()
        TextBox1daper.Text = calculate_percent(Convert.ToInt32(TextBox1da.Text)).ToString()
        TextBox2hraper.Text = calculate_percent(Convert.ToInt32(TextBox2hra.Text)).ToString()
        TextBox3ccaper.Text = calculate_percent(Convert.ToInt32(TextBox3cca.Text)).ToString()
        'pf_per833TextBox.Text = calculate_percent_float(Convert.ToInt32(amt833TextBox.Text)).ToString(); 
        'pf_per367TextBox.Text = calculate_percent_float(Convert.ToInt32(amt367TextBox.Text)).ToString(); 
    End Sub

    'function to calculate percentage

    Private Function calculate_percent(ByVal amt As Int32) As Int32
        Dim ret_val As Double = 0
        ' ret_val =; 
        ret_val = amt * 100 / Convert.ToInt32(TextBox1basic.Text)
        ret_val = Math.Round(ret_val, MidpointRounding.AwayFromZero)

        Return (Convert.ToInt32(ret_val))
    End Function
    'function to calculate gross salary

    Private Sub cal_gross()
        Label22gross.Text = Convert.ToString(Convert.ToInt32(TextBox1amttopay.Text) + Convert.ToString(Convert.ToInt32(TextBox1da.Text) + Convert.ToInt32(TextBox2hra.Text) + Convert.ToInt32(TextBox3cca.Text) + Convert.ToInt32(TextBox6oa1.Text) + Convert.ToInt32(TextBox7oa2.Text) + Convert.ToInt32(TextBox4pf833.Text) + Convert.ToInt32(TextBox5pf367.Text)))
    End Sub

    'function to calculate pf

    Private Sub cal_pf()
        pflabel.Text = Convert.ToString((Convert.ToInt32(TextBox4pf833.Text) + Convert.ToInt32(TextBox5pf367.Text)) * 2)
    End Sub

    'function for deduction

    Private Sub cal_to_ded()
        TotDedLabel.Text = Convert.ToString(Convert.ToInt32(pflabel.Text) + Convert.ToInt32(TextBox1itax.Text) + Convert.ToInt32(TextBox2educease.Text) + Convert.ToInt32(TextBox3proftax.Text) + Convert.ToInt32(TextBox4loan.Text) + Convert.ToInt32(Label23grpins.Text) + Convert.ToInt32(TextBox1secdepo.Text))
    End Sub

    'function to calculate net salary

    Private Sub cal_net()
        netlabel.Text = Convert.ToString(Convert.ToInt32(Label22gross.Text) - Convert.ToInt32(TotDedLabel.Text))
    End Sub

    Private Sub Button3savechanges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3savechanges.Click

        Dim sql As String
        sql = "update empsalarytemp set amtpay='" & TextBox1amttopay.Text & "'," _
        & "oa1='" & TextBox6oa1.Text & "',oa2='" & TextBox7oa2.Text & "'," _
        & "it='" & TextBox1itax.Text & "',proftax='" & TextBox3proftax.Text & "'," _
        & "lwp='" & TextBox1lwp.Text & "',remark='" & TextBox5rem.Text & "',da='" _
        & TextBox1da.Text & "',hra='" & TextBox2hra.Text & "',cca='" & TextBox3cca.Text _
        & "',amt833='" & TextBox4pf833.Text & "',amt367='" & TextBox5pf367.Text & "'" _
        & ",secudep='" & TextBox1secdepo.Text & "',od1='" _
        & TextBox2educease.Text & "',collegeloan='" _
        & TextBox4loan.Text & "',paymode='" & ComboBox1.Text & "' , basic='" & TextBox1basic.Text & "' where empid='" & TextBox1empid.Text _
        & "' and salmonth='" & setmonth & "' and orgid='" & organization & "'"

        globalmod.SqlExecuteNonQuery(sql)

        TextBox1empid.Focus()

    End Sub

    Private Sub TextBox1lwp_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1lwp.KeyUp
        'code to calculate lwp
        Try
            If CInt(TextBox1lwp.Text) < 0 Then
                TextBox1lwp.Text = 0
                TextBox1lwp.SelectAll()
            End If
        Catch ex As Exception

        End Try
        Try
            If IsNumeric(TextBox1lwp.Text) = False Then

                TextBox1lwp.Text = 0

                TextBox1lwp.SelectAll()

            End If
        Catch ex As Exception

        End Try

        Dim s1 As New sal_struct()
        Dim empid As String

        Try
            empid = Convert.ToString(TextBox1empid.Text)
        Catch
            empid = -12345
        End Try

        s1 = cal_lwp(TextBox1lwp.Text, empid, ComboBox1oid.Text)
        TextBox1amttopay.Text = s1.amt_pay.ToString()
        TextBox1da.Text = s1.da_pay.ToString()
        TextBox2hra.Text = s1.hra_pay.ToString()
        TextBox3cca.Text = s1.cca_pay.ToString()
        TextBox4pf833.Text = s1.pf833_pay.ToString()
        TextBox5pf367.Text = s1.pf367_pay.ToString()
        TextBox7oa2.Text = s1.oa1.ToString
        TextBox6oa1.Text = s1.esi.ToString
        TextBox1basic.Text = s1.pfbasic.ToString
    End Sub

    'structure to define lwp salary
    Public Structure sal_struct
        Public amt_pay As Int32
        Public da_pay As Int32
        Public hra_pay As Int32
        Public cca_pay As Int32
        Public pf833_pay As Int32
        Public pf367_pay As Int32
        Public hra As Int32
        Public oa1 As Int32
        Public esi As Int32
        Public pfbasic As Int32
    End Structure

    'structure function to calculate lwp
    Private Function cal_lwp(ByVal lwp_txt As String, ByVal empid As String, ByVal org_id As String) As sal_struct
        Dim sal1 As New sal_struct()

        ' emp_salary_structTableAdapter.Fill(dataSet1.emp_salary_struct, empid, org_id)
        Dim sql As String
        sql = "select * from empsalarystructure where orgid='" & organization & "' and empid='" & empid & "'"
        globalmod.DataSetRet(sql, "empinfo1")
        Dim dt As String = DateTimePicker1.Text
        Dim ispenfund As String = "0"
        Dim pf As Int32 = 0
        Try
            ispenfund = ds.Tables("empinfo1").Rows(0)(11)
            pf = Convert.ToInt32(ds.Tables("empinfo1").Rows(0)("epf").ToString())
        Catch
        End Try
        'DateTime.DaysInMonth(DateTimePickersalmonth1.SelectedDate.Value.Year, DateTimePickersalmonth1.SelectedDate.Value.Month)
        ' Dim noofdays As Int32 = DateTimePickersalmonth1.Value.Day
        Dim noofdays As Int32 = DateTime.DaysInMonth(DateTimePickersalmonth1.Value.Year, DateTimePickersalmonth1.Value.Month)
        'If globalmod.organization = "LITTLE WORLD NURSERY" Then
        '    noofdays = Date.DaysInMonth(CDate(DateTimePickersalmonth1.Text).Year, CDate(DateTimePickersalmonth1.Text).Month)
        'End If

        Dim lwp As Single = 0
        Try
            lwp = Single.Parse(lwp_txt)
        Catch
        End Try
        Dim work_day As Single = noofdays - lwp
        Try
            ' sal1.amt_pay = Convert.ToInt32( Math.Round(( work_day * Convert.ToInt32(dataSet1.emp_salary_struct.Rows[0]["basic"].ToString()) 
            ' / noofdays), MidpointRounding.AwayFromZero)); 
            sal1.amt_pay = calculate_amt(work_day, Convert.ToInt32(ds.Tables("empinfo1").Rows(0)("basic").ToString()))
            sal1.da_pay = calculate_amt(work_day, Convert.ToInt32(ds.Tables("empinfo1").Rows(0)("da").ToString()))
            sal1.hra_pay = calculate_amt(work_day, Convert.ToInt32(ds.Tables("empinfo1").Rows(0)("hra")))
            sal1.cca_pay = calculate_amt(work_day, Val(ds.Tables("empinfo1").Rows(0)("cca")))
            sal1.pfbasic = calculate_amt(work_day, Convert.ToInt32(ds.Tables("empinfo1").Rows(0)("pfbasic")))
            ' sal1.hra = calculate_amt(work_day, Convert.ToInt32(ds.Tables("empinfo1").Rows(0)("cca")))
            sal1.oa1 = calculate_amt(work_day, Convert.ToInt32(ds.Tables("empinfo1").Rows(0)("oa2")))

            If organization = "Phoenix Poultry" Then
                If pmode = "BANK" Then
                    sal1.esi = calculate_amt(30, Convert.ToInt32(ds.Tables("empinfo1").Rows(0)("oa1")))
                Else
                    sal1.esi = calculate_amt(work_day, Convert.ToInt32(ds.Tables("empinfo1").Rows(0)("oa1")))
                End If
            Else
                sal1.esi = calculate_amt(work_day, Convert.ToInt32(ds.Tables("empinfo1").Rows(0)("oa1")))
            End If

            ' Int32 tot_pay = Convert.ToInt32(amtpayTextBox.Text) + Convert.ToInt32(daTextBox.Text); 
            Dim tot_pay As Int32 = sal1.pfbasic
            'pf =Convert.ToInt32( Math.Round(((noofdays - Convert.ToInt32(lwpTextBox.Text)*1.00) 
            ' * pf / noofdays), MidpointRounding.AwayFromZero)); 
            If pf > 0 Then
                pf = Convert.ToInt32(Math.Round(tot_pay * 0.12, MidpointRounding.AwayFromZero))
                sal1.pf833_pay = pf_calculation(tot_pay, pf, "").pf833
                sal1.pf367_pay = pf_calculation(tot_pay, pf, "").pf367
            Else
                sal1.pf833_pay = 0
                sal1.pf367_pay = 0
            End If
        Catch
            sal1.amt_pay = 0
            sal1.da_pay = 0
            sal1.cca_pay = 0
            sal1.hra_pay = 0
            sal1.pf833_pay = 0
            sal1.pf367_pay = 0
        End Try
        Return sal1
    End Function

    'code to calculate amount
    Private Function calculate_amt(ByVal work_day As Single, ByVal amt_t As Int32) As Int32
        'return Convert.ToInt32((double.Parse(percent.ToString()) * Convert.ToDouble(amtpayTextBox.Text) / 100)); 
        Dim noofdays As Int32 = DateTime.DaysInMonth(DateTimePickersalmonth1.Value.Year, DateTimePickersalmonth1.Value.Month)
        Return (Convert.ToInt32(Math.Round((work_day * amt_t * 1 / noofdays), MidpointRounding.AwayFromZero)))
    End Function

    Private Sub Button2confirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2confirm.Click
        Dim sql As String
        If MessageBox.Show("Are U Really Want To Confirm", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            sql = "insert into empsalary select * from empsalarytemp where salmonth='" & setmonth & "' and orgid='" & organization & "'"
            globalmod.SqlExecuteNonQuery(sql)
            ' sql = "delete from empsalarytemp where salmonth='" & setmonth & "' and orgid='" & organization & "' "
            'globalmod.SqlExecuteNonQuery(sql)
            remvalue()
        End If
    End Sub
    Private Sub Button1select_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1select.Click
        Dim i As Integer
        For i = 0 To DataGridView1.Rows.Count - 1
            DataGridView1(0, i).Value = 1
        Next
    End Sub
    Dim count As Integer = 0
    Dim flag As Boolean = False
    Dim delfalg As Boolean = False
    Private Sub Button1delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1delete.Click
        delfalg = True
        Try
            Dim i As Integer
            For i = 0 To DataGridView1.Rows.Count - 1
                ' MsgBox(DataGridView1(0, i).Value.ToString)
                If DataGridView1.Rows(i).Cells(0).Value = "1" Then
                    Dim sql As String
                    Try
                        sql = "select collegeloan  from empsalarytemp where orgid='" _
                        & organization & "' and empid='" _
                        & DataGridView1.Rows(i).Cells(2).Value & "' and salmonth='" & setmonth & "'"
                        globalmod.DataSetRet(sql, "cloan")
                        If Val(globalmod.ds.Tables("cloan").Rows(0)(0).ToString()) > 0 Then
                            sql = "select *  from loanmaster  where orgid='" _
                             & organization & "' and empid='" _
                            & DataGridView1.Rows(i).Cells(2).Value & "'"
                            globalmod.DataSetRet(sql, "loan_m")
                            noofins = globalmod.ds.Tables("loan_m").Rows(0)("noofins")
                            remins = globalmod.ds.Tables("loan_m").Rows(0)("remins")
                            flag = True
                        End If
                    Catch ex As Exception

                    End Try
                    sql = "delete from empsalarytemp where orgid='" _
                    & organization & "' and empid='" _
                    & DataGridView1.Rows(i).Cells(2).Value & "' and salmonth='" & setmonth & "'"
                    globalmod.SqlExecuteNonQuery(sql)

                    If remins <> 1 Then
                        sql = "update loanmaster set rem = rem + installmentamt, remins= remins+1  where empid='" & DataGridView1.Rows(i).Cells(2).Value & "' and orgid='" & organization & "'"
                        globalmod.SqlExecuteNonQuery(sql)
                    ElseIf remins = 1 Then
                        sql = "update loanmaster set rem = rem + rem , remins= remins+1  where empid='" & DataGridView1.Rows(i).Cells(2).Value & "' and orgid='" & organization & "'"
                        globalmod.SqlExecuteNonQuery(sql)
                    End If
                End If
            Next
        Catch ex As Exception
        End Try
        MsgBox("Record Deleted")
        remvalue()
        Me.Dispose()
    End Sub
    Public Sub remvalue()
        Dim sql As String
        sql = "SELECT   EMPSALARYTEMP.orgid, EMPSALARYTEMP.empid, EMPINFOVIEW.name, DEPARTMENT,EMPSALARYTEMP.UID,EMPSALARYTEMP.UIdCode" _
                & " FROM EMPSALARYTEMP INNER JOIN  EMPINFOVIEW ON EMPSALARYTEMP.empid = EMPINFOVIEW.empid" _
                & " AND EMPSALARYTEMP.orgid = EMPINFOVIEW.orgid " _
                & " WHERE  EMPSALARYTEMP.salmonth='" & setmonth & "' and " _
                & " EMPSALARYTEMP.orgid='" & organization & "'"
        globalmod.DataSetRet(sql, "fillgrid")
        DataGridView1.DataSource = ds.Tables("fillgrid")
    End Sub

    Private Sub Button1show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1show.Click
        remvalue()
        'Dim sql As String
        'sql = "SELECT EMPSALARYTEMP.orgid, EMPSALARYTEMP.empid, EMPMASTER.name," _
        '& " EMPDEPARTMENT.designation FROM EMPSALARYTEMP INNER JOIN" _
        '& " EMPMASTER ON EMPSALARYTEMP.empid = EMPMASTER.empid INNER JOIN" _
        '& " EMPDEPARTMENT ON EMPMASTER.empid = EMPDEPARTMENT.empid where EMPSALARYTEMP.salmonth='" _
        '& DateTimePickersalmonth1.Text & "'"
        'globalmod.DataSetRet(sql, "fillgrid")
        'DataGridView1.DataSource = ds.Tables("fillgrid")
    End Sub

    Private Sub TextBox1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyUp
        Try
            Dim dataview1 As New DataView(ds.Tables("fillgrid"))
            dataview1.Sort = "name asc"
            dataview1.RowFilter = "name like '" + TextBox1.Text + "%' "
            DataGridView1.DataSource = dataview1
        Catch
        End Try
    End Sub
    Private Sub ComboBox1oid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1oid.SelectedIndexChanged

    End Sub
    Private Sub fetchsal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fetchsal.Click
        Try
            Dim sql As String


            sql = "select count(*) from empsalarytemp"
            globalmod.DataSetRet(sql, "getcntsal")
            If ds.Tables("getcntsal").Rows.Count > 0 Then
                MsgBox("First Confirm Salary Of Last Month")
                Exit Sub
            End If
            sql = "insert into empsalarytemp select orgid, empid,'" & setmonth & "','" _
            & DateTimePicker1.Text & "', basic, amtpay, da, hra, cca, oa1, oa2, it, " _
            & " educease, proftax, collegeloan, lwp, remark, amt833, amt367, " _
            & " sheetno, userid, groupinsded, secudep, od1, paymode from empsalary " _
            & " where salmonth= (select max(salmonth) from empsalary)"
            MsgBox(globalmod.SqlExecuteNonQuery(sql))

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Dim netsded As Double
    Public Sub netdeds()
        Try
            netsded = CInt(pflabel.Text) + CInt(Label23grpins.Text) + CInt(TextBox1itax.Text) + CInt(TextBox3proftax.Text) + CInt(TextBox2educease.Text) + CInt(TextBox4loan.Text) + CInt(TextBox1secdepo.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox1secdepo_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox4loan.KeyUp, TextBox3proftax.KeyUp, TextBox2educease.KeyUp, TextBox1secdepo.KeyUp, TextBox1itax.KeyUp
        netdeds()
        Try
            If netsded > Label22gross.Text Then
                Try
                    Dim sql As String
                    sql = "SELECT orgid, empid, salmonth, saldate, basic, amtpay," _
                           & " da, hra, cca, oa1, oa2, it, educease, proftax, collegeloan," _
                           & " lwp, remark, amt833, amt367, sheetno, userid,groupinsded," _
                           & " secudep,od1,paymode FROM empsalarytemp" _
                           & " where  orgid='" & organization & "' and  empid='" _
                           & TextBox1empid.Text & "' and salmonth='" & setmonth & "'"
                    'MsgBox(sql)
                    globalmod.DataSetRet(sql, "empsal")
                    'SACHIN
                    Label18name.Text = DataGridView1.SelectedRows(0).Cells(3).Value
                    TextBox1empid.Text = ds.Tables("empsal").Rows(0)(1)
                    TextBox1amttopay.Text = ds.Tables("empsal").Rows(0)(5)
                    TextBox1basic.Text = ds.Tables("empsal").Rows(0)(4)
                    TextBox1da.Text = ds.Tables("empsal").Rows(0)(6)
                    TextBox1itax.Text = ds.Tables("empsal").Rows(0)(11)
                    TextBox1lwp.Text = ds.Tables("empsal").Rows(0)(15)
                    TextBox2educease.Text = ds.Tables("empsal").Rows(0)(23)
                    TextBox2hra.Text = ds.Tables("empsal").Rows(0)(7)
                    TextBox3cca.Text = ds.Tables("empsal").Rows(0)(8)
                    TextBox3proftax.Text = ds.Tables("empsal").Rows(0)(13)
                    TextBox4loan.Text = ds.Tables("empsal").Rows(0)(14)
                    TextBox4pf833.Text = ds.Tables("empsal").Rows(0)(17)
                    TextBox5pf367.Text = ds.Tables("empsal").Rows(0)(18)
                    TextBox5rem.Text = ds.Tables("empsal").Rows(0)(16)
                    TextBox6oa1.Text = ds.Tables("empsal").Rows(0)(9)
                    TextBox7oa2.Text = ds.Tables("empsal").Rows(0)(10)
                    'show the value in labels
                    Label23grpins.Text = ds.Tables("empsal").Rows(0)(21)
                    TextBox1secdepo.Text = ds.Tables("empsal").Rows(0)(22)
                    'code to calculate heads
                    ComboBox1.Text = ds.Tables("empsal").Rows(0)("paymode").ToString



                    calheads()
                Catch ex As Exception

                End Try
                MsgBox("Gross Salary Is less from deduction")

                Exit Sub
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox1empid_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1empid.KeyUp
        Dim sqlempid As String
        sqlempid = "SELECT   EMPSALARYTEMP.orgid, EMPSALARYTEMP.empid, EMPINFOVIEW.name, DEPARTMENT" _
                & " FROM EMPSALARYTEMP INNER JOIN  EMPINFOVIEW ON EMPSALARYTEMP.empid = EMPINFOVIEW.empid" _
                & " AND EMPSALARYTEMP.orgid = EMPINFOVIEW.orgid " _
                & " WHERE  EMPSALARYTEMP.salmonth='" & setmonth & "' and " _
                & " EMPSALARYTEMP.orgid='" & organization & "' and EMPSALARYTEMP.empid like '%" & TextBox1empid.Text & "%'"
        globalmod.DataSetRet(sqlempid, "fillgridempid")
        DataGridView1.DataSource = ds.Tables("fillgridempid")
    End Sub

    Private Sub TextBox1lwp_TextChanged(sender As Object, e As EventArgs) Handles TextBox1lwp.TextChanged

    End Sub
End Class