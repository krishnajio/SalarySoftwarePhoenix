Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System
'Imports System.Collections.Generic
'Imports System.Text

Module globalmod1
    'Public Connstr As String

    Public ds As New DataSet
    Public connstr As String = "Data Source=PHXRPT;Initial Catalog=PhoenixSalary;Integrated Security=True"
    Public max_pf833_amt As Int32 = 0
    Public SqlConn As New SqlConnection(connstr)
    Public tot_pf As Int32 = 0
    Public pf_percent As Int32 = 0
    Public Userid As String = ""

    Public Function getnoofdays(ByVal dt As DateTime) As Integer
        Dim mnt As Integer, yr As Integer
        mnt = dt.Month
        yr = dt.Year
        Dim days As Integer = 0
        Dim isleap As Boolean
        If yr Mod 100 = 0 AndAlso yr Mod 400 = 0 Then
            isleap = True
        ElseIf yr Mod 4 = 0 AndAlso yr Mod 100 <> 0 Then
            isleap = True
        Else
            isleap = False
        End If

        If mnt = 1 OrElse mnt = 3 OrElse mnt = 5 OrElse mnt = 7 OrElse mnt = 8 OrElse mnt = 10 OrElse mnt = 12 Then
            days = 31
        ElseIf mnt = 2 AndAlso isleap = True Then
            days = 29
        ElseIf mnt = 2 AndAlso isleap = False Then
            days = 28
        ElseIf mnt = 4 OrElse mnt = 6 OrElse mnt = 9 OrElse mnt = 8 OrElse mnt = 11 Then
            days = 30

        End If

        Return days
    End Function
    Public Sub DataSetRet(ByVal sql As String, ByVal tablename As String)
        Try
            ds.Tables(tablename).Clear()
            ds.Tables(tablename).Rows.Clear()
        Catch ex As Exception

        End Try

        Try
            SqlConn.ConnectionString = Connstr
            Dim adp As New SqlDataAdapter(sql, connstr)
            adp.Fill(ds, tablename)
            adp.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Public Function SqlExecuteNonQuery(ByVal sql As String) As String
        Dim retval As String = ""
        If SqlConn.State = ConnectionState.Closed Then
            SqlConn.ConnectionString = Connstr
            SqlConn.Open()
        End If
        Dim sqlcmd As New SqlCommand(sql, SqlConn)
        Try
            sqlcmd.ExecuteNonQuery()
            retval = "Sucess"
        Catch ex As Exception
            retval = ex.Message
        End Try
        sqlcmd.Dispose()
        If SqlConn.State = ConnectionState.Open Then SqlConn.Close()
        Return retval
    End Function
End Module


