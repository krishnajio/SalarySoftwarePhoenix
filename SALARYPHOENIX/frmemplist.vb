Public Class frmemplist

    Private Sub frmemplist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String
        sql = "select * from empinfoview where orgid='" & globalmod.organization & "' "
        globalmod.DataSetRet(sql, "empinfoleave")
        DataGridView1.DataSource = ds.Tables("empinfoleave")

    End Sub

    Private Sub TextBox1name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1name.TextChanged
        Try
            Dim dataview1 As New DataView(ds.Tables("empinfoleave"))
            dataview1.Sort = "name asc"
            dataview1.RowFilter = "name like '" + TextBox1name.Text + "%' "
            DataGridView1.DataSource = dataview1
        Catch
        End Try
    End Sub

    Dim EmpId As String
    Dim empname As String


    Public Property retEmpId() As String
        Get
            Return EmpId
        End Get
        Set(ByVal value As String)
        End Set
    End Property
    Public Property retempname() As String
        Get
            Return empname
        End Get
        Set(ByVal value As String)

        End Set
    End Property

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            EmpId = DataGridView1.SelectedRows(0).Cells(0).Value
            empname = DataGridView1.SelectedRows(0).Cells(1).Value
            Me.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub TextBox1name_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1name.KeyUp
        If e.KeyCode = Keys.Enter Then
            Button1_Click(sender, e)
        End If
    End Sub
End Class