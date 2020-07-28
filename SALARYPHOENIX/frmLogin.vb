Imports System
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Net
Public Class frmLogin
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        'MsgBox(globalmodule.Connstr)
        Dim con As New SqlConnection
        con.ConnectionString = globalmod.Connstr
        '   MsgBox(Connstr)
        Try
            con.Open()
            Dim sql As String
            sql = "select * from [user_info] where user_id='" _
            & txtUserName.Text & "' and status=1 and password='" & txtPassword.Text & "' "
            globalmod.DataSetRet(sql, "user_info")
            If ds.Tables("user_info").Rows.Count = 0 Then
                MsgBox("You Are Not Valid User", MsgBoxStyle.Information, "Please Check The Id and Password")
                txtUserName.Text = ""
                txtPassword.Text = ""
                txtUserName.Focus()
                Exit Sub
            Else
                globalmod.soft_username = txtUserName.Text
                globalmod.rolename = ds.Tables("user_info").Rows(0)("role").ToString
                globalmod.organization = ds.Tables("user_info").Rows(0)("org").ToString
                globalmod.setmonth = DateTimePicker1.Text

            End If
            Me.Visible = False
            'If System.IO.File.Exists("rfidport.txt") Then
            'Else
            '    MsgBox("Please Select A Com Port No After Login")
            'End If

            MDIParent1.Show()
            'frmsetuni.ShowDialog()
            con.Close()
        Catch ex As Exception
            frmserver.ShowDialog()
        End Try
        con.Dispose()


    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If System.IO.File.Exists("Config.txt") Then
            Dim fs As New FileStream("Config.txt", FileMode.Open, FileAccess.Read)
            Dim sr As New StreamReader(fs)
            While sr.Peek() > -1
                globalmod.Connstr = EncryptionStr(sr.ReadLine.ToString, False)
            End While
            sr.Close()
        Else
            frmDataBaseAdmin.ShowDialog()
        End If

        'Dim DT1 As New DataTable
        'Dim row1 As DataRow
        'DT1 = Sql.SqlDataSourceEnumerator.Instance.GetDataSources()
        'For Each row1 In DT1.Rows
        '    MsgBox("Server " & row1("ServerName"))
        'Next
        'Dim myHost As String = System.Net.Dns.GetHostName
        'Dim myIPs As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(myHost)
        ''Dim myIPs As System.Net.IPHostEntry = System.Net.Dns.GetHostByName(myHost)

        'MessageBox.Show("The name of the host is = " & myIPs.HostName, "Host Name", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'For Each myIP As System.Net.IPAddress In myIPs.AddressList
        '    MessageBox.Show("The IP address of host is = " & myIP.ToString, "Host IP Address", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    'globalmodule.hostname = myIPs.HostName.ToString
        'Next
        'globalmodule.Connstr = "Data Source=" & myIPs.HostName & ";Initial Catalog=logindata;Integrated Security=True;Pooling=False"
        ''Dim sql As String
        ''sql = "select srvname from dbo.sysservers"


    End Sub


    Private Sub txtUserName_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUserName.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtPassword_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class
