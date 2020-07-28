Public Class frmempmaster

    Private Sub frmempmaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button1upd.Enabled = False
        fillgrid()
        Dim sql As String
        sql = "select * from bloodgroup"
        globalmod.DataSetRet(sql, "bg")
        ComboBox5bg.DataSource = ds.Tables("bg")
        ComboBox5bg.DisplayMember = "bloodgroup"

        sql = "select * from religion"
        globalmod.DataSetRet(sql, "rel")
        ComboBox4rel.DataSource = ds.Tables("rel")
        ComboBox4rel.DisplayMember = "religionname"

        sql = "select * from castemaster"
        globalmod.DataSetRet(sql, "cast")
        ComboBox2caste.DataSource = ds.Tables("cast")
        ComboBox2caste.DisplayMember = "castename"

        Dim SQL1 As String
        SQL1 = "SELECT orgid from organizationmaster where orgid='" & organization & "'"
        globalmod.DataSetRet(SQL1, "org")
        ComboBox1org.DataSource = ds.Tables("org")
        ComboBox1org.DisplayMember = "orgid"
    End Sub
    Public Sub fillgrid()
        Dim sql As String
        sql = "select empid,contactno as EPFNo,accountno, name, fname,dob, mname as Nominee, qualification2 as NomineeDOB, doj, gender, empcaste, category, religion, joinpost, qualification1, " _
        & "localadd, peradd, bloodgroup, photo, status, remark, orgid from empmaster where orgid='" & organization & "'"
        globalmod.DataSetRet(sql, "empinfo3")
        DataGridView1.DataSource = ds.Tables("empinfo3")
    End Sub
    Private Sub Button4close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4close.Click
        Me.Close()
    End Sub

    Private Sub Button1save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1save.Click
        If TextBox1eid.Text = "" Then
            MsgBox("please fill the Emp Id or Staff Code")
        ElseIf TextBox2name.Text = "" Then
            MsgBox("Please fill the employee name")
        ElseIf DateTimePicker1dob.Text = Date.Today Then
            MsgBox("please change the date of birth this person is not deserve to be an employee of phoenix group")
            Exit Sub
        End If

        globalmod.DataSetRet("select Max(uid)+1 from empmaster", "MaxUid")
        Dim UIdCode As String = "P" + Format(globalmod.ds.Tables("MaxUid").Rows(0)(0), "000000")
        ' MessageBox.Show(UIdCode)

        Dim sql As String
        sql = "insert into empmaster (empid, name, fname, mname, dob, doj, gender," _
        & " empcaste, category, religion, joinpost, qualification1, " _
        & " qualification2, localadd, peradd, bloodgroup, contactno, accountno," _
        & " status, remark,orgid,UID,UIdCode) values ('" & TextBox1eid.Text & "','" _
        & TextBox2name.Text & "','" & TextBox3fname.Text & "','" _
        & TextBox4mname.Text & "','" & DateTimePicker1dob.Text & "','" _
        & DateTimePicker2doj.Text & "','" & ComboBox1gender.Text & "','" _
        & ComboBox2caste.Text & "','" & ComboBox3cat.Text & "','" & ComboBox4rel.Text & "','" _
        & TextBox5jpost.Text & "','" & TextBox6qu1.Text & "','" _
        & TextBox7qu2.Text & "','" & TextBox8ladd.Text & "','" _
        & TextBox9padd.Text & "','" & ComboBox5bg.Text & "','" _
        & TextBox10con.Text & "','" & TextBox11accno.Text & "','" _
        & CheckBox1.CheckState & "','" & TextBox12rem.Text & "','" & organization & "','" & Val(globalmod.ds.Tables("MaxUid").Rows(0)(0)) & "','" & UIdCode & "')"
        Dim s As String = globalmod.SqlExecuteNonQuery(sql)
        If s.ToUpper = "SUCCESS" Then
            sql = "insert into empdepartment (empid, date, orgid, depno,UID,UIdCode)" _
                  & " values('" & TextBox1eid.Text & "','" _
                  & DateTimePicker2doj.Text & "','" & organization & "','" _
                  & ComboBox2dep.SelectedValue & "','" & Val(globalmod.ds.Tables("MaxUid").Rows(0)(0)) & "','" & UIdCode & "')"
            globalmod.SqlExecuteNonQuery(sql)
            sql = "insert into empsalarystructure (orgid, empid,UID,UIdCode) values('" & organization & "','" & TextBox1eid.Text & "','" & Val(globalmod.ds.Tables("MaxUid").Rows(0)(0)) & "','" & UIdCode & "')"
            globalmod.SqlExecuteNonQuery(sql)
        End If
        'sql query to insert  data in empdepartment
        'sql query to insert default salary structure in empsalary

        fillgrid()
        'Dim frmempdep1 As New frmempsalaryentry
        'frmempdep1.setempid = TextBox1eid.Text
        'frmempdep1.setname = TextBox2name.Text

        '''''''''code comment by krihna on 18/5/13------------
        'Dim frmempsalary1 As New frmempsalary
        'frmempsalary1.setempid = TextBox1eid.Text
        'frmempsalary1.setorgid = organization
        'frmempsalary1.setname = TextBox2name.Text
        'frmempsalary1.ShowDialog()
        '''''''''''''''''''''''''''''''''''
        'frmempdep1.ShowDialog()
    End Sub

    Private Sub frmempmaster_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        'Try
        '    Dim sql As String
        '    sql = "delete from empmaster where empid not in (select empid from empdepartment)"
        '    globalmod.SqlExecuteNonQuery(sql)
        'Catch ex As Exception

        'End Try


    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            Button1save.Enabled = False
            retinfo(DataGridView1.SelectedRows(0).Cells(0).Value, DataGridView1.SelectedRows(0).Cells(21).Value)
            Button1upd.Enabled = True
            Button1save.Enabled = False
        Catch ex As Exception

        End Try

    End Sub
    Private Function retinfo(ByVal empid As String, ByVal orgid As String)
        Try
            Dim sql As String
            sql = "select * from empmaster where empid='" & empid & "' and orgid='" & orgid & "'"
            globalmod.DataSetRet(sql, "empmas")
            TextBox1eid.Text = ds.Tables("empmas").Rows(0)(0).ToString
            TextBox2name.Text = ds.Tables("empmas").Rows(0)(1).ToString
            TextBox3fname.Text = ds.Tables("empmas").Rows(0)(2).ToString
            TextBox4mname.Text = ds.Tables("empmas").Rows(0)(3).ToString
            DateTimePicker1dob.Text = ds.Tables("empmas").Rows(0)(4).ToString
            DateTimePicker2doj.Text = ds.Tables("empmas").Rows(0)(5).ToString
            ComboBox1gender.Text = ds.Tables("empmas").Rows(0)(6).ToString
            ComboBox2caste.Text = ds.Tables("empmas").Rows(0)(7).ToString
            ComboBox3cat.Text = ds.Tables("empmas").Rows(0)(8).ToString
            ComboBox4rel.Text = ds.Tables("empmas").Rows(0)(9).ToString
            TextBox5jpost.Text = ds.Tables("empmas").Rows(0)(10).ToString
            TextBox6qu1.Text = ds.Tables("empmas").Rows(0)(11).ToString
            Try
                TextBox7qu2.Text = CDate(ds.Tables("empmas").Rows(0)(12).ToString)

            Catch ex As Exception

            End Try

            TextBox8ladd.Text = ds.Tables("empmas").Rows(0)(13).ToString
            TextBox9padd.Text = ds.Tables("empmas").Rows(0)(14).ToString
            ComboBox5bg.Text = ds.Tables("empmas").Rows(0)(15).ToString
            TextBox10con.Text = ds.Tables("empmas").Rows(0)(16).ToString
            TextBox11accno.Text = ds.Tables("empmas").Rows(0)(17).ToString
            If ds.Tables("empmas").Rows(0)(19).ToString = "True" Then
                CheckBox1.CheckState = CheckState.Checked
            Else
                CheckBox1.CheckState = CheckState.Unchecked
            End If
            TextBox12rem.Text = ds.Tables("empmas").Rows(0)(20).ToString

            sql = "select depno from EMPDEPARTMENT where empid='" & empid & "' and orgid='" & orgid & "'"
            globalmod.DataSetRet(sql, "edept")
            ComboBox2dep.SelectedValue = ds.Tables("edept").Rows(0)(0).ToString


        Catch

        End Try
    End Function





    Private Sub Button1upd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1upd.Click
        If TextBox5jpost.Text.Trim = "" Then
        Else
            If Not IsDate(TextBox5jpost.Text) Then
                TextBox5jpost.Text = ""
                MessageBox.Show("Invalid Leave Date")
                Exit Sub
            End If
        End If

        Dim sql As String
        sql = "update empmaster set name='" & TextBox2name.Text & "'," _
        & "fname='" & TextBox3fname.Text & "'," _
        & " mname='" & TextBox4mname.Text & "'," _
        & "dob='" & DateTimePicker1dob.Text & "'," _
        & "doj='" & DateTimePicker2doj.Text & "'," _
        & "gender='" & ComboBox1gender.Text & "'," _
        & " empcaste='" & ComboBox2caste.Text & "'," _
        & "category='" & ComboBox3cat.Text & "'," _
        & "religion='" & ComboBox4rel.Text & "'," _
        & "joinpost='" & TextBox5jpost.Text & "'," _
        & "qualification1='" & TextBox6qu1.Text & "'," _
        & " qualification2='" & TextBox7qu2.Text & "'," _
        & "localadd='" & TextBox8ladd.Text & "'," _
        & "peradd='" & TextBox9padd.Text & "'," _
        & "bloodgroup='" & ComboBox5bg.Text & "'," _
        & "contactno='" & TextBox10con.Text & "'," _
        & "accountno='" & TextBox11accno.Text & "'," _
        & "status='" & CheckBox1.CheckState & "'," _
        & "remark='" & TextBox12rem.Text & "' where empid='" & TextBox1eid.Text & "' and orgid='" & organization & "'"
        globalmod.SqlExecuteNonQuery(sql)

        sql = "update EMPDEPARTMENT set depno= '" & ComboBox2dep.SelectedValue & "'  where empid='" & TextBox1eid.Text & "' and orgid='" & organization & "'"
        'MsgBox(sql)
        MsgBox(globalmod.SqlExecuteNonQuery(sql))
        fillgrid()

    End Sub

    Private Sub Button1addnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1addnew.Click

        Button1save.Enabled = True
        Button1upd.Enabled = False
        TextBox1eid.Text = ""
        TextBox2name.Text = ""
        TextBox3fname.Text = ""
        TextBox4mname.Text = ""
        DateTimePicker1dob.Text = ""
        DateTimePicker2doj.Text = ""
        ComboBox1gender.Text = ""
        ComboBox2caste.Text = ""
        ComboBox3cat.Text = ""
        ComboBox4rel.Text = ""
        TextBox5jpost.Text = ""
        TextBox6qu1.Text = ""
        TextBox7qu2.Text = ""
        TextBox8ladd.Text = ""
        TextBox9padd.Text = ""
        ComboBox5bg.Text = ""
        TextBox10con.Text = ""
        TextBox11accno.Text = ""
        TextBox1eid.Focus()
    End Sub

    Private Sub TextBox1sid_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1sid.KeyUp
        Try
            Dim dataview1 As New DataView(ds.Tables("empinfo3"))
            dataview1.Sort = "name asc"
            dataview1.RowFilter = "name like '" + TextBox1sid.Text + "%' "
            DataGridView1.DataSource = dataview1
        Catch
        End Try
    End Sub


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1sid.TextChanged
       
    End Sub

    Private Sub ComboBox1org_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1org.SelectedIndexChanged
        Try
            Dim sql As String
            sql = "select depid,department from department where orgid='" _
            & organization & "'"
            globalmod.DataSetRet(sql, "depinfo")
            ComboBox2dep.DataSource = ds.Tables("depinfo")
            ComboBox2dep.DisplayMember = "department"
            ComboBox2dep.ValueMember = "depid"


        Catch ex As Exception

        End Try

        Try
            Dim sql As String

            sql = "select organization from organizationmaster where orgid='" _
        & organization & "'"
            globalmod.DataSetRet(Sql, "orgma")
            Label43.Text = ds.Tables("orgma").Rows(0)(0).ToString

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ComboBox2dep_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2dep.SelectedIndexChanged
        Try
            Dim sql As String

            sql = "select department from department where orgid='" _
        & organization & "' and depid='" & ComboBox2dep.Text & "'"
            globalmod.DataSetRet(sql, "orgma1")
            Label44.Text = ds.Tables("orgma1").Rows(0)(0).ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox(CheckBox1.CheckState)
    End Sub

    Private Sub TextBox1eid_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1eid.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TextBox1eid_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1eid.Leave
        Try
            Dim sql As String
            sql = "select count (*) from empmaster where empid='" & TextBox1eid.Text _
            & "' and orgid='" & globalmod.organization & "'"
            globalmod.DataSetRet(sql, "getdupl")
            If ds.Tables("getdupl").Rows(0)(0) > 0 Then
                MsgBox("Staff Code is already Exist")
                Button1save.Enabled = False
            Else
                Button1save.Enabled = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxEmpId.KeyUp
        Try
            Dim dataview1 As New DataView(ds.Tables("empinfo3"))
            dataview1.Sort = "name asc"
            dataview1.RowFilter = "empid like '%" + TextBoxEmpId.Text + "%' "
            DataGridView1.DataSource = dataview1
        Catch
        End Try
    End Sub

    
End Class