Public Class frmempdep

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub frmempdep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillgrid()
        Dim SQL As String
        SQL = "SELECT orgid from organizationmaster where orgid='" & organization & "'"
        globalmod.DataSetRet(SQL, "oid")
        ComboBox1oid.DataSource = ds.Tables("oid")
        ComboBox1oid.DisplayMember = "orgid"
        TextBox1eid.Text = empid
        TextBox2name.Text = empname

    End Sub
    Public Sub fillgrid()
        Dim sql As String
        sql = "select * from empdepartment"
        globalmod.DataSetRet(sql, "empdep")
        DataGridView1.DataSource = ds.Tables("empdep")
    End Sub

    Private Sub Button1save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1save.Click
        Dim sql As String
        sql = "update empdepartment set date='" _
        & DateTimePicker1date.Text & "',orgid='" & ComboBox1oid.Text & "',depno='" _
        & ComboBox2dep.SelectedValue & "',designation='" & ComboBox3des.Text & "',scale='" & TextBox3scale.Text _
        & "',doincreament='" & DateTimePicker2doi.Text & "',jointype='" & ComboBox4joint.Text & "',bankaccno='" _
        & TextBox4baccno.Text & "' where empid='" & TextBox1eid.Text & "' and orgid='" & organization & "'"
        MsgBox(globalmod.SqlExecuteNonQuery(sql))
        fillgrid()
        'Dim frmempsalary1 As New frmempsalary
        'frmempsalary1.setempid = TextBox1eid.Text
        'frmempsalary1.setorgid = ComboBox1oid.Text
        'frmempsalary1.setname = TextBox2name.Text

        'frmempsalary1.ShowDialog()
    End Sub
    Dim empname As String
    Dim empid As String
    Public Property setname() As String
        Get
            setname = empname
        End Get
        Set(ByVal value As String)
            empname = value
        End Set
    End Property
    Public Property setempid() As String
        Get
            setempid = empid
        End Get
        Set(ByVal value As String)
            empid = value
        End Set
    End Property

    Private Sub ComboBox1oid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1oid.SelectedIndexChanged

        Dim sql As String
        sql = "select depid,department from department where orgid='" _
        & ComboBox1oid.Text & "'"
        globalmod.DataSetRet(sql, "depinfo")
        ComboBox2dep.DataSource = ds.Tables("depinfo")
        ComboBox2dep.DisplayMember = "department"
        ComboBox2dep.ValueMember = "depid"

    End Sub

    Private Sub ComboBox2dep_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2dep.SelectedIndexChanged
        Try
            Dim sql As String
            'sql = "select designation from designationmaster where orgid='" _
            '& ComboBox1oid.Text & "' and department='" & ComboBox2dep.Text & "'"
            sql = "select DEPARTMENT from DEPARTMENT where orgid='" _
            & ComboBox1oid.Text & "' and DEPID='" & ComboBox2dep.SelectedValue & "'"
            globalmod.DataSetRet(sql, "des")
            Label12.Text = ds.Tables("des").Rows(0)(0)
        Catch ex As Exception

        End Try


        'ComboBox3des.DataSource = ds.Tables("des")
        'ComboBox3des.DisplayMember = "designation"

    End Sub

    Private Sub TextBox1eid_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1eid.Enter

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim frmempid As New frmemplist
        frmempid.ShowDialog()
        TextBox1eid.Text = frmempid.retEmpId
        TextBox2name.Text = frmempid.retempname
        TextBox1eid.Focus()
    End Sub

    Private Sub TextBox1eid_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1eid.KeyUp
        If e.KeyCode = Keys.Enter Then

        End If
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            retinfo(DataGridView1.SelectedRows(0).Cells(0).Value)
        Catch ex As Exception

        End Try


    End Sub
    Private Function retinfo(ByVal empidget As String)
        Dim sql As String
        sql = "  SELECT EMPDEPARTMENT.*, EMPMASTER.name FROM" _
        & " EMPMASTER INNER JOIN EMPDEPARTMENT ON EMPMASTER.empid = EMPDEPARTMENT.empid " _
        & "  where EMPDEPARTMENT.empid='" & empidget & "'"
        globalmod.DataSetRet(sql, "empdepinfo")
        TextBox1eid.Text = ds.Tables("empdepinfo").Rows(0)(0)
        DateTimePicker1date.Text = ds.Tables("empdepinfo").Rows(0)(1)
        ComboBox1oid.Text = ds.Tables("empdepinfo").Rows(0)(2)
        ComboBox2dep.Text = ds.Tables("empdepinfo").Rows(0)(3)
        ComboBox3des.Text = ds.Tables("empdepinfo").Rows(0)(4)
        TextBox3scale.Text = ds.Tables("empdepinfo").Rows(0)(5)
        DateTimePicker2doi.Text = ds.Tables("empdepinfo").Rows(0)(6)
        ComboBox4joint.Text = ds.Tables("empdepinfo").Rows(0)(7)
        TextBox4baccno.Text = ds.Tables("empdepinfo").Rows(0)(8)
        TextBox2name.Text = ds.Tables("empdepinfo").Rows(0)(10)

    End Function

   
    

    
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button3upd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3upd.Click

    End Sub
End Class