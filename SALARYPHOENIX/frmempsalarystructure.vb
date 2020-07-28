Public Class frmempsalarystructure
    Private Sub Button2close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2close.Click
        Me.Close()
    End Sub
    Dim esibit As Integer
    Private Sub Button1save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1save.Click
        Try
            'cca stand for field allownce
            Dim sql, s As String
            sql = "update empsalarystructure set basic='" _
            & Val(txtpfBasicOA.Text) & "',da='" _
            & TextBox13daamt.Text & "',hra='" & TextBox14hraamt.Text & "',cca='" _
            & TextBox15ccaamt.Text & "',epf='" & TextBox16pfamt.Text & "',oa1='" _
            & TextBox10oa1.Text & "',oa2='" & TextBox11oa2.Text & "',tax='" _
            & TextBox12itax.Text & "',edc_cs='" & TextBox17educeaseamt.Text & "',is_pen_fund='" _
            & CheckBox1egpen.CheckState & "',groupinsuranceded='" _
            & TextBox1grpins.Text & "',tdsded='" & TextBox1tds.Text _
            & "',securitydepoded='" & TextBox1secdep.Text & "',od1='" _
            & TextBox1od1.Text & "' , PFBASIC='" & Val(txtpfBasicOA.Text) & "',ptax ='" & Val(txtProftax.Text) & "'   where empid='" & TextBox2eid.Text & "' and orgid='" & organization & "'"
            s = globalmod.SqlExecuteNonQuery(sql)
            'esibit='" & CheckBox1egpen.CheckState & "'

            If s = "Success" Then
                MsgBox("Record Saved")
                TextBox3name.Text = ""
                TextBox1orgid.Text = ""
                TextBox2eid.Text = ""
                TextBox4basic.Text = ""
                TextBox13daamt.Text = ""
                TextBox14hraamt.Text = ""
                TextBox15ccaamt.Text = ""
                TextBox16pfamt.Text = ""

                ' Me.Close()
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub TextBox4basic_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox4basic.KeyUp
        Dim basic As Integer, da As Integer
        Dim dap As Single, hrap As Single, ccap As Single, epfp As Single, edu_cs As Single
        Try
            basic = Integer.Parse(TextBox4basic.Text)
        Catch
            basic = 0
        End Try
        Try
            dap = Single.Parse(TextBox5da.Text)
        Catch
            dap = 0
        End Try
        Try
            hrap = Single.Parse(TextBox6hra.Text)
        Catch
            hrap = 0
        End Try
        Try
            ccap = Single.Parse(TextBox7cca.Text)
        Catch
            ccap = 0
        End Try
        Try
            epfp = Single.Parse(TextBox8epf.Text)
        Catch
            epfp = 0
        End Try
        Try
            edu_cs = Single.Parse(TextBox9educease.Text)
        Catch
            edu_cs = 0
        End Try

        TextBox13daamt.Text = Convert.ToString(basic * dap * 0.01)
        Try
            da = Int32.Parse(TextBox13daamt.Text)
        Catch
            da = 0
        End Try

        TextBox14hraamt.Text = Convert.ToString(basic * hrap * 0.01)
        TextBox15ccaamt.Text = Convert.ToString(basic * ccap * 0.01)
        TextBox16pfamt.Text = Convert.ToString(basic + da * epfp * 0.01)
        TextBox17educeaseamt.Text = Convert.ToString(basic * edu_cs * 0.01)
        Try
            Try
                Dim pfamt As Double = Math.Round((Val(txtpfBasicOA.Text)) * 0.01 * Convert.ToDouble(TextBox8epf.Text), 0, MidpointRounding.AwayFromZero)
                If pfamt > globalmod.tot_pf Then
                    TextBox16pfamt.Text = globalmod.tot_pf.ToString()
                Else
                    TextBox16pfamt.Text = pfamt.ToString()
                End If
            Catch
                TextBox16pfamt.Text = "0"
            End Try
        Catch ex As Exception

        End Try
    End Sub
    Private Sub TextBox5da_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox5da.KeyUp
        Try
            TextBox13daamt.Text = Convert.ToString(Math.Round(Convert.ToInt32(TextBox4basic.Text) * 0.01 * Convert.ToDouble(TextBox5da.Text), 0))
            TextBox16pfamt.Text = Convert.ToString(Math.Round((Convert.ToInt32(TextBox4basic.Text) + Convert.ToInt32(TextBox5da.Text)) * 0.01 * Convert.ToDouble(TextBox8epf.Text), 0))
        Catch
            TextBox13daamt.Text = "0"
        End Try
    End Sub
    Private Sub TextBox6hra_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox6hra.KeyUp
        Try
            TextBox14hraamt.Text = Convert.ToString(Math.Round(Convert.ToInt32(TextBox4basic.Text) * 0.01 * Convert.ToDouble(TextBox6hra.Text), 0))
        Catch
            TextBox14hraamt.Text = "0"
        End Try
    End Sub
    Private Sub TextBox7cca_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox7cca.KeyUp
        Try
            TextBox15ccaamt.Text = Convert.ToString(Math.Round(Convert.ToInt32(TextBox4basic.Text) * 0.01 * Convert.ToDouble(TextBox7cca.Text), 0))
        Catch
            TextBox15ccaamt.Text = "0"
        End Try
    End Sub
    Private Sub TextBox8epf_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox8epf.KeyUp
        Try
            Dim pfamt As Double = Math.Round((Convert.ToInt32(TextBox4basic.Text) + Convert.ToInt32(TextBox13daamt.Text)) * 0.01 * Convert.ToDouble(TextBox8epf.Text), 0)
            If pfamt > globalmod.tot_pf Then
                TextBox16pfamt.Text = globalmod.tot_pf.ToString()
            Else
                TextBox16pfamt.Text = pfamt.ToString()
            End If
        Catch
            TextBox16pfamt.Text = "0"
        End Try
    End Sub

    Private Sub TextBox9educease_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox9educease.KeyUp
        Try
            TextBox17educeaseamt.Text = Convert.ToString(Math.Round(Convert.ToInt32(TextBox4basic.Text) * 0.01 * Convert.ToDouble(TextBox9educease.Text), 0))
        Catch
            TextBox17educeaseamt.Text = "0"
        End Try
    End Sub
    Sub total()
        txttotal.Text = Val(TextBox10oa1.Text) + Val(TextBox11oa2.Text) + Val(TextBox13daamt.Text) + Val(TextBox14hraamt.Text) + Val(TextBox15ccaamt.Text) + Val(TextBox16pfamt.Text) + Val(TextBox17educeaseamt.Text) + Val(txtpfBasicOA.Text)
    End Sub
    Private Sub frmempsalary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            If globalmod.organization = "Phoenix Hatcheries" Then
                oa1Label.Text = "Special Allow."
                Label14.Text = "PROD. INCEN."
            Else
                oa1Label.Text = "EMP.SHARE ESI:"
                Label14.Text = "PROD. INCEN."
            End If
        Catch ex As Exception

        End Try

        If organization = "Phoenix Poultry" Then
            oa1Label.Text = "EMP.SHARE ESI:"
            Label14.Text = "ESI 1.75%"
        ElseIf globalmod.organization = "Phoenix Hatcheries" Then
            oa1Label.Text = "Special Allow."
            Label14.Text = "PROD. INCEN."
        Else
            oa1Label.Text = "ESI 1.75%"
            Label14.Text = "da"
        End If

        Try
            Dim sql As String
            sql = "select orgid from organizationmaster"
            globalmod.DataSetRet(sql, "uyui")
            ComboBox1.DataSource = ds.Tables("uyui")
            ComboBox1.DisplayMember = "orgid"
            fillgrid()
            TextBox1orgid.Text = orgid
            TextBox2eid.Text = empid
            TextBox3name.Text = empname

            sql = "select totalpfamt from salarystructuremaster"
            globalmod.DataSetRet(sql, "pf")
            globalmod.tot_pf = Convert.ToInt32(ds.Tables("pf").Rows(0)(0).ToString)
        Catch ex As Exception

        End Try
    End Sub
    Public Sub fillgrid()
        Try
            Dim sql As String
            sql = "SELECT  EMPMASTER.name ,  EMPSALARYSTRUCTURE.* " _
                   & " FROM EMPSALARYSTRUCTURE INNER JOIN EMPMASTER ON EMPSALARYSTRUCTURE.empid = EMPMASTER.empid and EMPSALARYSTRUCTURE.orgid = EMPMASTER.orgid where EMPMASTER.orgid='" _
                   & organization & "' and status=1 order by EMPMASTER.name "
            globalmod.DataSetRet(sql, "empsalstu")
            ' MsgBox(ds.Tables("empsalstu").Rows.Count)
            DataGridView1.DataSource = ds.Tables("empsalstu")
        Catch ex As Exception
        End Try
    End Sub
    Private Function retinfo(ByVal orgid1 As String, ByVal empid1 As String)
        Try
            
            Dim sql As String
            sql = "SELECT EMPSALARYSTRUCTURE.*, EMPMASTER.name + '/' +  EMPMASTER.fname as [name]" _
            & " FROM EMPMASTER INNER JOIN EMPSALARYSTRUCTURE ON " _
            & " EMPMASTER.empid = EMPSALARYSTRUCTURE.empid AND EMPMASTER.orgid = EMPSALARYSTRUCTURE.orgid" _
            & " where EMPSALARYSTRUCTURE.empid='" _
            & empid1 & "' and EMPSALARYSTRUCTURE.orgid='" & organization & "'"
          
            globalmod.DataSetRet(sql, "salinfoofemp")
            TextBox3name.Text = ds.Tables("salinfoofemp").Rows(0)("name")
            TextBox1orgid.Text = ds.Tables("salinfoofemp").Rows(0)("orgid")
            TextBox2eid.Text = ds.Tables("salinfoofemp").Rows(0)("empid")
            TextBox4basic.Text = ds.Tables("salinfoofemp").Rows(0)("basic")
            TextBox13daamt.Text = ds.Tables("salinfoofemp").Rows(0)("da")
            TextBox14hraamt.Text = ds.Tables("salinfoofemp").Rows(0)("hra")
            TextBox15ccaamt.Text = ds.Tables("salinfoofemp").Rows(0)("cca")
            TextBox16pfamt.Text = ds.Tables("salinfoofemp").Rows(0)("epf")
            TextBox10oa1.Text = ds.Tables("salinfoofemp").Rows(0)("oa1")
            TextBox11oa2.Text = ds.Tables("salinfoofemp").Rows(0)("oa2")
            TextBox12itax.Text = ds.Tables("salinfoofemp").Rows(0)("tax")
            TextBox9educease.Text = ds.Tables("salinfoofemp").Rows(0)("edc_cs")
            TextBox1tds.Text = ds.Tables("salinfoofemp").Rows(0)("tdsded")
            TextBox1grpins.Text = ds.Tables("salinfoofemp").Rows(0)("groupinsuranceded")
            TextBox1secdep.Text = ds.Tables("salinfoofemp").Rows(0)("securitydepoded")
            TextBox1od1.Text = ds.Tables("salinfoofemp").Rows(0)("od1")
            txtpfBasicOA.Text = ds.Tables("salinfoofemp").Rows(0)("pfbasic")
            txtProftax.Text = ds.Tables("salinfoofemp").Rows(0)("ptax")
            If ds.Tables("salinfoofemp").Rows(0)("is_pen_fund") = "True" Then
                CheckBox1egpen.CheckState = CheckState.Checked
            Else
                CheckBox1egpen.CheckState = CheckState.Unchecked
            End If
            TextBox3name.Text = ds.Tables("salinfoofemp").Rows(0)("name")
        Catch ex As Exception

        End Try
    End Function

    Dim orgid As String
    Dim empid As String
    Dim empname As String
    Public Property setorgid() As String
        Get
            setorgid = orgid
        End Get
        Set(ByVal value As String)
            orgid = value
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

    Public Property setname() As String
        Get
            setname = empname
        End Get
        Set(ByVal value As String)
            empname = value
        End Set
    End Property


    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtProftax.Text = "0"
        Try
            retinfo(DataGridView1.SelectedRows(0).Cells(1).Value, DataGridView1.SelectedRows(0).Cells(2).Value)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox13daamt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox13daamt.TextChanged
        'Try
        ' TextBox5da.Text = calculate_percent(TextBox13daamt.Text)
        'Catch ex As Exception

        'End Try
        total()
    End Sub
    Private Function calculate_percent(ByVal amt As Int32) As Int32
        Try
            Dim ret_val As Double = 0
            ' ret_val =; 
            ret_val = amt * 100 / Convert.ToInt32(txtpfBasicOA.Text)
            ret_val = Math.Round(ret_val, MidpointRounding.AwayFromZero)
            Return (Convert.ToInt32(ret_val))
        Catch ex As Exception

        End Try

    End Function

    Private Sub TextBox14hraamt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox14hraamt.TextChanged
        Try
            TextBox6hra.Text = calculate_percent(TextBox14hraamt.Text)
        Catch ex As Exception

        End Try
        total()
    End Sub

    Private Sub TextBox15ccaamt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox15ccaamt.TextChanged
        Try
            TextBox7cca.Text = calculate_percent(TextBox15ccaamt.Text)
        Catch ex As Exception

        End Try
        total()
    End Sub

    Private Sub TextBox16pfamt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox16pfamt.TextChanged
        Try
            'TextBox8epf.Text = calculate_percent(TextBox16pfamt.Text)
        Catch ex As Exception

        End Try
        total()
    End Sub

    Private Sub TextBox17educeaseamt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox17educeaseamt.TextChanged
        Try
            TextBox9educease.Text = calculate_percent(TextBox17educeaseamt.Text)
        Catch ex As Exception

        End Try
        total()
    End Sub


    Private Sub Button1upd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1upd.Click
        'Button1save_Click(sender, e)
        Try
            Dim sql As String
            sql = "update empsalarystructure set orgid='" & TextBox1orgid.Text & "',basic='" _
            & Val(txtpfBasicOA.Text) & "',da='" _
            & TextBox13daamt.Text & "',hra='" & TextBox14hraamt.Text & "',cca='" _
            & TextBox15ccaamt.Text & "',epf='" & TextBox16pfamt.Text & "',oa1='" _
            & TextBox10oa1.Text & "',oa2='" & TextBox11oa2.Text & "',tax='" _
            & TextBox12itax.Text & "',edc_cs='" & TextBox17educeaseamt.Text & "',is_pen_fund='" _
            & CheckBox1egpen.CheckState & "',groupinsuranceded='" _
            & TextBox1grpins.Text & "',tdsded='" & TextBox1tds.Text _
            & "',securitydepoded='" & TextBox1secdep.Text & "',od1='" _
            & TextBox1od1.Text & "', pfbasic='" & Val(txtpfBasicOA.Text) & "', ptax='" & txtProftax.Text & "'   where empid='" & TextBox2eid.Text & "' and orgid='" & organization & "'"


            ' esibit='" & CheckBox1egpen.CheckState & "'
            'sql = "update empsalarystructure set basic='" _
            '   & TextBox4basic.Text & "',da='" _
            '   & TextBox13daamt.Text & "',hra='" & TextBox14hraamt.Text & "',cca='" _
            '   & TextBox15ccaamt.Text & "',epf='" & TextBox16pfamt.Text & "',oa1='" _
            '   & TextBox10oa1.Text & "',oa2='" & TextBox11oa2.Text & "',tax='" _
            '   & TextBox12itax.Text & "',edc_cs='" & TextBox17educeaseamt.Text & "',is_pen_fund='" _
            '   & CheckBox1egpen.CheckState & "' where empid='" & TextBox2eid.Text & "' where orgid='" _
            '   & TextBox1orgid.Text & "' and empid='" & TextBox2eid.Text & "'"
            globalmod.SqlExecuteNonQuery(sql)
            fillgrid()
        Catch ex As Exception

        End Try
        txtEmpId.Focus()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyUp
        Dim db1 As New DataView(ds.Tables("empsalstu"))
        db1.RowFilter = "name like '" & TextBox1.Text & "%'"
        DataGridView1.DataSource = db1
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        fillgrid()
    End Sub

    Private Sub TextBox8epf_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8epf.TextChanged

    End Sub

    Private Sub TextBox5da_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5da.TextChanged

    End Sub

    Private Sub TextBox4basic_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4basic.TextChanged
        total()
    End Sub

    Private Sub TextBox11oa2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox11oa2.TextChanged
        'TextBox4basic_KeyUp(sender, e)
        total()
    End Sub

    Private Sub TextBox1orgid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1orgid.TextChanged

    End Sub

    Private Sub txtpfBasicOA_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpfBasicOA.KeyUp
        Dim basic As Integer, da As Integer
        Dim dap As Single, hrap As Single, ccap As Single, epfp As Single, edu_cs As Single
        Try
            basic = Integer.Parse(txtpfBasicOA.Text)
        Catch
            basic = 0
        End Try
        Try
            dap = Single.Parse(TextBox5da.Text)
        Catch
            dap = 0
        End Try
        Try
            hrap = Single.Parse(TextBox6hra.Text)
        Catch
            hrap = 0
        End Try
        Try
            ccap = Single.Parse(TextBox7cca.Text)
        Catch
            ccap = 0
        End Try
        Try
            epfp = Single.Parse(TextBox8epf.Text)
        Catch
            epfp = 0
        End Try
        Try
            edu_cs = Single.Parse(TextBox9educease.Text)
        Catch
            edu_cs = 0
        End Try

        TextBox13daamt.Text = Convert.ToString(basic * dap * 0.01)
        Try
            da = Int32.Parse(TextBox13daamt.Text)
        Catch
            da = 0
        End Try

        TextBox14hraamt.Text = Convert.ToString(basic * hrap * 0.01)
        TextBox15ccaamt.Text = Convert.ToString(basic * ccap * 0.01)
        TextBox16pfamt.Text = Convert.ToString(basic * epfp * 0.01)
        TextBox17educeaseamt.Text = Convert.ToString(basic * edu_cs * 0.01)
        Try
            Try
                Dim pfamt As Double = Math.Round((Val(txtpfBasicOA.Text) * 0.01 * Convert.ToDouble(TextBox8epf.Text)), 0)
                If pfamt > globalmod.tot_pf Then
                    TextBox16pfamt.Text = globalmod.tot_pf.ToString()
                Else
                    TextBox16pfamt.Text = pfamt.ToString()
                End If
            Catch
                TextBox16pfamt.Text = "0"
            End Try
        Catch ex As Exception

        End Try
        total()

    End Sub

    Private Sub txtpfBasicOA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpfBasicOA.TextChanged
        TextBox4basic.Text = txtpfBasicOA.Text
    End Sub


    Private Sub TextBox1grpins_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1grpins.TextChanged
        total()
    End Sub

   

    Private Sub txtEmpId_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEmpId.KeyUp
        Dim db1 As New DataView(ds.Tables("empsalstu"))
        db1.RowFilter = " empid like '%" & txtEmpId.Text & "%'"
        DataGridView1.DataSource = db1
    End Sub

    
    Private Sub txtEmpId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmpId.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub CheckBox1egpen_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1egpen.CheckedChanged

    End Sub

    Private Sub TextBox6hra_TextChanged(sender As Object, e As EventArgs) Handles TextBox6hra.TextChanged
        'Try
        '    TextBox14hraamt.Text = Math.Round(Val(txtpfBasicOA.Text) * (Val(TextBox6hra.Text) / 100))
        'Catch ex As Exception

        'End Try
        'total()
    End Sub

    Private Sub txttotal_TextChanged(sender As Object, e As EventArgs) Handles txttotal.TextChanged

    End Sub
End Class