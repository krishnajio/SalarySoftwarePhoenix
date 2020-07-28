Imports System.Data.SqlClient
Imports System.Net
Imports System.Net.Dns
Imports System.IO.Ports
Imports System.IO
Module globalmod
    Public tablename As String = "empsalarytemp"

    Public univesity As String
    Public organization As String
    Public setmonth As String
    ' Public Connstr As String
    Public servername As String
    Public username As String
    Public password As String
    Public soft_username As String
    Public portno As String
    Public max_pf833_amt As Int32 = 0
    Public tot_pf As Int32 = 0
    Public pf_percent As Int32 = 0
    Public Connstr As String '= "Data Source=phxmain;Initial Catalog=PhoenixSalary;User ID=sa; Password='@jay@dev'"

    'Public Connstr As String = "Data Source=" & hostname.ToString & ";Initial Catalog=logindata;Integrated Security=True;Pooling=False"
    Public SqlConn As New SqlConnection(Connstr)
    Public ds As New DataSet
    Public serialport1 As New SerialPort
    Public rolename As String
    Public pmode As String = "BANK"


    Public Sub rfidcon()
        If System.IO.File.Exists("rfidport.txt") Then
            Dim fs As New FileStream("rfidport.txt", FileMode.Open, FileAccess.Read)
            Dim sr As New StreamReader(fs)
            While sr.Peek() > -1
                globalmod.portno = sr.ReadLine.ToString
            End While
        End If

        Try
            serialport1 = New SerialPort(globalmod.portno, 9600, Parity.None, 8, StopBits.One)
            Try
                serialport1.Open()
            Catch ex As Exception
            End Try
        Catch ex As System.IO.IOException
            MsgBox("RFID READER NOT CONNECTED")
        End Try
    End Sub
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
            ds.Tables(tablename).Dispose()
            ds.Tables(tablename).Clear()
        Catch ex As Exception

        End Try

        Try
            SqlConn.ConnectionString = Connstr
            Dim adp As New SqlDataAdapter(sql, Connstr)
            adp.Fill(ds, tablename)
            adp.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            'frmserver.Show()
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
            retval = "Success"
        Catch ex As Exception
            retval = ex.Message
        End Try
        sqlcmd.Dispose()
        If SqlConn.State = ConnectionState.Open Then SqlConn.Close()
        Return retval
    End Function
    Public Function EncryptionStr(ByVal strval As String, ByVal isencrypt As Boolean) As String
        Dim lenstr, i, t, addval As Integer
        Dim chr1, tmpstr As String
        tmpstr = ""
        lenstr = Len(strval)
        If isencrypt = True Then
            addval = 10
        Else
            addval = -10
        End If
        For i = 0 To lenstr - 1
            chr1 = strval.Substring(i, 1)
            t = Asc(chr1) + addval
            tmpstr = tmpstr + Chr(t).ToString
        Next
        EncryptionStr = tmpstr
    End Function

    Public Function EncryptionStr1(ByVal strval As String, ByVal isencrypt As Boolean) As String
        Dim lenstr, i, t, addval As Integer
        Dim chr1, tmpstr As String
        tmpstr = ""
        lenstr = Len(strval)
        If isencrypt = True Then
            addval = 11
        Else
            addval = -11
        End If
        For i = 0 To lenstr - 1
            chr1 = strval.Substring(i, 1)
            t = Asc(chr1) + addval
            tmpstr = tmpstr + Chr(t).ToString
        Next
        EncryptionStr1 = tmpstr
    End Function
End Module
