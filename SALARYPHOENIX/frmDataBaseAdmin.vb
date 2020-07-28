Imports System.IO
Public Class frmDataBaseAdmin

    Private Sub frmServerdetection_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        globalmod.ds.Tables.Clear()
    End Sub
    Private Sub frmServerdetection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbserver.Focus()
        Dim DT1 As New DataTable
        Dim row1 As DataRow
        DT1 = Sql.SqlDataSourceEnumerator.Instance.GetDataSources()

        For Each row1 In DT1.Rows
            cmbserver.Items.Add(row1("ServerName"))
            'MsgBox("Server " & row1("ServerName"))
        Next
    End Sub

    Private Sub cmbserver_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbserver.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbserver_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbserver.SelectedIndexChanged

    End Sub
    Private Sub btncontinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncontinue.Click
        Try
            'If bool = True Then
            If cmbDatabase.Text = "" Then
                MsgBox("Please select a database name", MsgBoxStyle.Exclamation)
                cmbDatabase.Focus()
                Exit Try
                Exit Sub
            End If
            Dim ConnStr As String = "Data Source= " & cmbserver.Text & ";Initial Catalog=" & cmbDatabase.Text & ";User ID=" & txtusername.Text & ";Password=" & txtpwd1.Text & ";Connect Timeout=3000;"
            'MsgBox(ConnStr)
            Dim tmpstr As String
            tmpstr = EncryptionStr(ConnStr, True)
            Dim fs As New FileStream("Config.txt", FileMode.Create)
            Dim sr As New StreamWriter(fs)
            sr.WriteLine(tmpstr)
            sr.Close()
            globalmod.Connstr = ConnStr
            frmLogin.Show()
            Me.Hide()
            File.Copy("Config.txt", "C:\Config.txt")
            'End If
        Catch ex As Exception

        End Try

    End Sub
    Dim bool As Boolean = False

    Private Sub txtpwd1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpwd1.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub txtpwd1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpwd1.Leave
        Try
            Dim i As Integer
            If txtpwd.Text <> txtpwd1.Text Then
                MsgBox("Password does't matches", MsgBoxStyle.Critical)
                txtpwd.Focus()
                Exit Sub
            Else
                btncontinue.Focus()
            End If
            Dim ConnStrMaster As String = "Data Source= " & cmbserver.Text & ";Initial Catalog=master;User ID=" & txtusername.Text & ";Password=" & txtpwd1.Text & ""
            Dim da As New SqlClient.SqlDataAdapter("exec sp_databases", ConnStrMaster)
            da.Fill(globalmod.ds, "DbNames")
            For i = 0 To globalmod.ds.Tables("DbNames").Rows.Count - 1
                'MsgBox(GMod.ds.Tables("DbNames").Rows(i)(0).ToString)
                'If GMod.ds.Tables("DbNames").Rows(i)(0).ToString = "RagaGroup" Then
                'bool = True
                ' Exit For
                'End If
                cmbDatabase.Items.Add(globalmod.ds.Tables("DbNames").Rows(i)(0).ToString)
            Next
        Catch ex As Exception
            MsgBox(ex.Message & "Data bases is not attached")
        End Try

    End Sub
    
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub cmbDatabase_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbDatabase.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtpwd_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpwd.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtusername_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtusername.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
End Class