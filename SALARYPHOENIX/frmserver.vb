Imports System.IO
Imports System.Net


Public Class frmserver

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Focus()
        Dim DT1 As New DataTable
       
        Dim row1 As DataRow
        DT1 = Sql.SqlDataSourceEnumerator.Instance.GetDataSources()
       

        For Each row1 In DT1.Rows
            ComboBox1.Items.Add(row1("ServerName"))
            'MsgBox("Server " & row1("ServerName"))
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim writestr As String
        'globalmodule.servername = ComboBox1.Text
        'globalmodule.username = TextBox1.Text
        'globalmodule.password = TextBox2.Text
        ' writestr = "data source=" & ComboBox1.Text _
        '    & ";Initial Catalog="& txtDbName.Text & " & "User ID=" & TextBox1.Text   & ";password='" & TextBox2.Text & "'"
        'Dim ch() As Char = TextBox2.Text
        'Dim i, j As Integer
        'i = TextBox2.Text.Length
        'For j = 0 To i - 1
        '    ch(j) = ChrW(Asc(ch(j)))
        'Next
        Dim tmpstr As String
        tmpstr = EncryptionStr(writestr, True)
        ' MsgBox(tmpstr)

        'MsgBox(EncryptionStr(tmpstr, False))

        Dim fs As New FileStream("conf.txt", FileMode.Create)
        Dim sr As New StreamWriter(fs)
        sr.WriteLine(tmpstr)
        sr.Close()
        globalmod.Connstr = writestr
        Me.Close()
    End Sub
   

    Private Sub TextBox3_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.Leave
        If TextBox2.Text = TextBox3.Text Then
            Button1.Focus()
        Else
            MessageBox.Show("password & retype pasword must be same", "check the password", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox2.Focus()
        End If
    End Sub
End Class