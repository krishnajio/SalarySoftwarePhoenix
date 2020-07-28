Public Class setorg

    Private Sub Button1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseHover

        Button1.BackColor = Color.Red
        Button1.ForeColor = Color.Black


    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.White

        Button1.ForeColor = Color.Black
    End Sub

    Private Sub setorg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbreport.SelectedIndex = 0

        Dim sql As String
        sql = "select org from user_info where user_id='" & globalmod.soft_username & "'"
        globalmod.DataSetRet(sql, "orin")
        ComboBox1ORGM.DataSource = ds.Tables("orin")
        ComboBox1ORGM.DisplayMember = "org"

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If MsgBox("Set The Organization :" & ComboBox1ORGM.Text & vbCrLf & " And Month" & DateTimePicker1.Text, MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
                globalmod.organization = ComboBox1ORGM.Text
                globalmod.setmonth = DateTimePicker1.Text
                If cmbreport.Text = "Current Month" Then
                    tablename = "EMPSALARYTEMP"
                Else
                    tablename = "EMPSALARY"
                End If
                Me.Close()

            Else
                MsgBox("You Must Have to Select Organization And Month")
            End If

        Catch ex As Exception

        End Try



    End Sub

    Private Sub setorg_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If globalmod.setmonth = "" Or globalmod.organization = "" Then
           
            globalmod.organization = ComboBox1ORGM.Text
            globalmod.setmonth = DateTimePicker1.Text


        End If
    End Sub

    Private Sub ComboBox1ORGM_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox1ORGM.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub ComboBox1ORGM_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1ORGM.SelectedIndexChanged

    End Sub

    Private Sub DateTimePicker1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DateTimePicker1.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub
End Class