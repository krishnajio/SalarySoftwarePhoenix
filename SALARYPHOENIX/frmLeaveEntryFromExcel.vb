Imports System.Data
Imports System.Data.SqlClient
Public Class frmLeaveEntryFromExcel
    Private Sub dgvoucher_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvoucher.CellContentClick

    End Sub
    Dim path As String
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        od.ShowDialog()
        path = od.FileName
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Dim i As Integer
        Dim sql As String = ""
        Dim drv, crv As Double
        Try
            Dim MyConnection As System.Data.OleDb.OleDbConnection
            Dim DtSet As System.Data.DataSet
            Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
            MyConnection = New System.Data.OleDb.OleDbConnection _
            ("provider=Microsoft.ACE.OLEDB.12.0;Data Source='" & path & "';Extended Properties=Excel 8.0;")
            MyCommand = New System.Data.OleDb.OleDbDataAdapter _
                ("select * from [leave$]", MyConnection)
            MyCommand.TableMappings.Add("Table", "TestTable")
            DtSet = New System.Data.DataSet
            MyCommand.Fill(DtSet)
            dgvoucher.Rows.Add()
            dgvoucher(1, 0).Value = DtSet.Tables(0).Rows(0)(1).ToString.Trim
            sql = "select empid , name+ '-' + fname as n from empmaster where empid = '" & DtSet.Tables(0).Rows(0)(1).ToString.Trim & "' and orgid ='" & globalmod.organization & "'"
            globalmod.DataSetRet(sql, "bonushead")
            dgvoucher(0, 0).Value = i.ToString
            dgvoucher(2, 0).Value = globalmod.ds.Tables("bonushead").Rows(0)("n")
            dgvoucher(3, 0).Value = DtSet.Tables(0).Rows(0)(2).ToString.Trim


            For i = 0 To DtSet.Tables(0).Rows.Count
                If DtSet.Tables(0).Rows(i)(1).ToString.Length > 0 Then
                    dgvoucher.Rows.Add()
                    dgvoucher(1, i).Value = DtSet.Tables(0).Rows(i)(1).ToString.Trim
                    sql = "select empid , name+ '-' + fname as n from empmaster where empid = '" & DtSet.Tables(0).Rows(i)(1).ToString.Trim & "' and orgid ='" & globalmod.organization & "'"
                    globalmod.DataSetRet(sql, "bonushead")
                    dgvoucher(0, i).Value = i.ToString
                    dgvoucher(2, i).Value = globalmod.ds.Tables("bonushead").Rows(0)("n")
                    dgvoucher(3, i).Value = DtSet.Tables(0).Rows(i)(2).ToString.Trim
                Else
                    Exit For
                End If
            Next
            'dgvoucher.DataSource = DtSet.Tables(0)
            MyConnection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try



    End Sub
    Dim sqlsave As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim I As Integer
        Dim trans As SqlTransaction
        If globalmod.SqlConn.State = ConnectionState.Closed Then
            globalmod.SqlConn.Open()
        End If
        trans = globalmod.SqlConn.BeginTransaction
        Try
            For I = 0 To dgvoucher.Rows.Count - 1
                'If Val(dgvoucher(4, i).Value) <> 0 And Val(dgvoucher(5, i).Value) <> 0 Then
                sqlsave = "insert into dbo.Leaves (Orgid, empid, noofleave, salmonth"
                sqlsave &= ") values( "
                sqlsave &= "'" & globalmod.organization & "',"
                sqlsave &= "'" & dgvoucher(1, I).Value & "',"
                sqlsave &= "'" & Val(dgvoucher(3, I).Value.ToString()) & "',"
                sqlsave &= "'" & globalmod.setmonth & "'"
                sqlsave &= ")"
                ' MsgBox(sqlsave)
                Dim cmd As New SqlCommand(sqlsave, globalmod.SqlConn, trans)
                cmd.ExecuteNonQuery()
                'End If
            Next
            trans.Commit()
            dgvoucher.Rows.Clear()
            MessageBox.Show("Leave Record Save Now You Can Generate salary From Master")

        Catch ex As Exception
            trans.Rollback()
            MsgBox(ex.Message)
        End Try
        If globalmod.SqlConn.State = ConnectionState.Open Then
            globalmod.SqlConn.Close()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MessageBox.Show("Deleting Leave Records Fro Month:" & globalmod.setmonth & " and Orgination" & globalmod.organization).Yes = Windows.Forms.DialogResult.Yes Then
            MessageBox.Show(globalmod.SqlExecuteNonQuery("delete from Leaves where orgid = '" & globalmod.organization & "'  and salmonth ='" & globalmod.setmonth & "'"))
        End If
    End Sub
End Class