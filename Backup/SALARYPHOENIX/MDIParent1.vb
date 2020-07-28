Imports System.Windows.Forms

Public Class MDIParent1

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Global.System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticleToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer = 0

    Private Sub USERCREATIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles USERCREATIONToolStripMenuItem.Click
        Dim user As New frmuser
        user.Show()

    End Sub

    Private Sub ORGANIZATIONMASTERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ORGANIZATIONMASTERToolStripMenuItem.Click
        Dim org As New frmorganization
        org.Show()

    End Sub

    Private Sub DEPARTMENTANDDESIGNATIONMASTERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DEPARTMENTANDDESIGNATIONMASTERToolStripMenuItem.Click
        Dim dep As New frmdepartment
        dep.Show()

    End Sub

    Private Sub SALARYSTRUCTUREMASTERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SALARYSTRUCTUREMASTERToolStripMenuItem.Click
        Dim salstu As New frmsalarystructure
        salstu.Show()

    End Sub

    Private Sub EMPLOYEEINFOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EMPLOYEEINFOToolStripMenuItem.Click
        Dim emp As New frmempmaster
        emp.Show()

    End Sub

    Private Sub EMPLOYEESALARYSTRUCTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EMPLOYEESALARYSTRUCTToolStripMenuItem.Click
        Dim empsalstu As New frmempsalarystructure
        empsalstu.Show()

    End Sub

    Private Sub LOANENTRYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOANENTRYToolStripMenuItem.Click
        Dim loan As New frmloanmaster
        loan.Show()

    End Sub

    Private Sub BANKMASTERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BANKMASTERToolStripMenuItem.Click
        Dim bank As New frmbankmaster
        bank.Show()

    End Sub

    Private Sub BLOODGROUPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BLOODGROUPToolStripMenuItem.Click
        Dim blood As New frmbloodgroup
        blood.Show()

    End Sub

    Private Sub CASTEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CASTEToolStripMenuItem.Click
        Dim caste As New frmcaste
        caste.Show()

    End Sub

    Private Sub CATEGORYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CATEGORYToolStripMenuItem.Click
        Dim category As New frmcategory
        category.Show()

    End Sub

    Private Sub RELIGIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RELIGIONToolStripMenuItem.Click
        Dim religion As New frmreligion
        religion.Show()

    End Sub

    Private Sub DESIGNATIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DESIGNATIONToolStripMenuItem.Click
        Dim designation As New frmdesignation
        designation.Show()

    End Sub

    Private Sub SALARYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SALARYToolStripMenuItem.Click
        Dim SAL As New frmempsalaryentry
        SAL.Show()

    End Sub

    Private Sub EMPLOYEEDESIGNATIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EMPLOYEEDESIGNATIONToolStripMenuItem.Click
        Dim empdes12 As New frmempdep
        empdes12.Show()

    End Sub

    Private Sub EMPLISTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EMPLISTToolStripMenuItem.Click
        Dim emplist As New frmrptemplist
        emplist.Show()

    End Sub

    Private Sub MDIParent1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub SALARYToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SALARYToolStripMenuItem1.Click
        Dim sal As New phxrptshow
        sal.Show()
    End Sub
    Private Sub SaToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BANKSTATEMENTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BANKSTATEMENTToolStripMenuItem.Click
        Dim bank As New bankstateshow
        bank.Show()

    End Sub

    Private Sub SaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim s As New totransfer
        s.Show()
    End Sub

    Private Sub SETORGToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SETORGToolStripMenuItem.Click
        Dim orset As New setorg
        orset.Show()
    End Sub

    Private Sub MDIParent1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim orset1 As New setorg
        'orset1.ShowDialog()s
        'Format(GMod.ds.Tables("nxt").Rows(0)(0), "0000")
       
        For Each ct1 As Control In Me.Controls
            If TypeOf ct1 Is MdiClient Then
                ct1.BackColor = Me.BackColor
            End If
        Next

        'code for module

        Dim sql As String
        sql = "select modulename from role where role_name='" & globalmod.rolename & "'"
        globalmod.DataSetRet(sql, "moduleinfo")

        'messagebox.show(ds.Tables("moduleinfo").Rows.Count)
        ' Label1.Text = "           WELCOME " & " " & soft_username

        Dim i As Integer
        For i = 0 To ds.Tables("moduleinfo").Rows.Count - 1
            Try
                ' messagebox.show(LOANENTRYToolStripMenuItem.Name)

                If USERCREATIONToolStripMenuItem.Name = ds.Tables("moduleinfo").Rows(i)(0) Then
                    USERCREATIONToolStripMenuItem.Enabled = True

                ElseIf ORGANIZATIONMASTERToolStripMenuItem.Name = ds.Tables("moduleinfo").Rows(i)(0) Then
                    ORGANIZATIONMASTERToolStripMenuItem.Enabled = True

                ElseIf DEPARTMENTANDDESIGNATIONMASTERToolStripMenuItem.Name = ds.Tables("moduleinfo").Rows(i)(0) Then
                    DEPARTMENTANDDESIGNATIONMASTERToolStripMenuItem.Enabled = True

                ElseIf DESIGNATIONToolStripMenuItem.Name = ds.Tables("moduleinfo").Rows(i)(0) Then
                    DESIGNATIONToolStripMenuItem.Enabled = True

                ElseIf SALARYSTRUCTUREMASTERToolStripMenuItem.Name = ds.Tables("moduleinfo").Rows(i)(0) Then
                    SALARYSTRUCTUREMASTERToolStripMenuItem.Enabled = True
                    'CURRENT

                ElseIf ROLECREATIONToolStripMenuItem.Name = ds.Tables("moduleinfo").Rows(i)(0) Then
                    ROLECREATIONToolStripMenuItem.Enabled = True

                ElseIf USERCREATIONToolStripMenuItem1.Name = ds.Tables("moduleinfo").Rows(i)(0) Then
                    USERCREATIONToolStripMenuItem1.Enabled = True


                ElseIf EMPLOYEEINFOToolStripMenuItem.Name = ds.Tables("moduleinfo").Rows(i)(0) Then
                    EMPLOYEEINFOToolStripMenuItem.Enabled = True

                ElseIf EMPLOYEESALARYSTRUCTToolStripMenuItem.Name = ds.Tables("moduleinfo").Rows(i)(0) Then
                    EMPLOYEESALARYSTRUCTToolStripMenuItem.Enabled = True

                ElseIf SALARYToolStripMenuItem.Name = ds.Tables("moduleinfo").Rows(i)(0) Then
                    SALARYToolStripMenuItem.Enabled = True

                ElseIf EMPLOYEEDESIGNATIONToolStripMenuItem.Name = ds.Tables("moduleinfo").Rows(i)(0) Then
                    EMPLOYEEDESIGNATIONToolStripMenuItem.Enabled = True

                End If
                'after
            Catch ex As Exception
                MessageBox.Show("error")

            End Try
        Next
        'code for module
        Me.Text = globalmod.organization.ToUpper & "-" & globalmod.setmonth
        ToolStripStatusLabel1.Text = globalmod.organization.ToUpper
        ToolStripStatusLabel2.Text = "SALARY MONTH: " & globalmod.setmonth
        ToolStripStatusLabel3.Text = "USER: " & globalmod.soft_username
    End Sub

    Private Sub SalarySlipToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalarySlipToolStripMenuItem.Click
        Dim frmsalslip As New frmsalaryslip
        frmsalslip.ShowDialog()

    End Sub

    Private Sub UpdateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmup As New frmupdate
        frmup.ShowDialog()

    End Sub

    Private Sub LIttleWorldSalaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim t As New frmLWorld
        t.Show()
    End Sub

    Private Sub LittleWorldNurToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim t As New frmLWNursery
        t.Show()
    End Sub

    Private Sub LWSTilwara2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim t As New frmLWTSalary2
        t.Show()
    End Sub

    Private Sub LWSTilwara1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim t As New frmLWTSalary1
        t.Show()
    End Sub

    Private Sub LittleWorldToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim t As New frmLWTilwara
        t.Show()
    End Sub

    Private Sub PFCALCULATIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PFCALCULATIONToolStripMenuItem.Click
        Dim t As New frmpfcalculation
        t.ShowDialog()

    End Sub

    Private Sub PFLISTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PFLISTToolStripMenuItem.Click
        Dim tp As New FrmRptPFLIST
        tp.ShowDialog()

    End Sub

    Private Sub NEWADDINPFToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NEWADDINPFToolStripMenuItem.Click
        Dim tpf As New rptform5
        tpf.ShowDialog()

    End Sub

    Private Sub ESILISTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ESILISTToolStripMenuItem.Click
        Dim t As New frmesirept
        t.ShowDialog()

    End Sub

    Private Sub GROUPINSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GROUPINSToolStripMenuItem.Click
        Dim tgs As New frmrptgrpins
        tgs.ShowDialog()

    End Sub

    Private Sub CHECKFORTAXToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHECKFORTAXToolStripMenuItem.Click
        Dim tch As New frmapptaxrpt
        tch.ShowDialog()

    End Sub

    Private Sub USERCREATIONToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles USERCREATIONToolStripMenuItem1.Click
        Dim tus As New Userinfofrm
        tus.ShowDialog()

    End Sub

    Private Sub ROLECREATIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ROLECREATIONToolStripMenuItem.Click
        Dim trl As New roleinfoform
        trl.ShowDialog()

    End Sub

    Private Sub MDIParent1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        'If e.KeyCode = Keys.F2 Then
        '    SETORGToolStripMenuItem.Enabled = True
        'End If
    End Sub

    Private Sub MonthlyChallanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonthlyChallanToolStripMenuItem.Click
        Dim t As New frmmonthlychallan
        t.Show()

    End Sub

    Private Sub Form12ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Form12ToolStripMenuItem.Click
        Dim t As New frmform12
        t.Show()
    End Sub

    Private Sub Form5ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Form5ToolStripMenuItem.Click
        Dim t As New rptform5

        t.Show()
    End Sub

    Private Sub Form10ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Form10ToolStripMenuItem.Click
        Dim t As New frmform10
        t.Show()
    End Sub

    Private Sub FORM3AToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FORM3AToolStripMenuItem.Click
        Dim t As New frm3A
        t.Show()
    End Sub

    Private Sub FORM6AToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FORM6AToolStripMenuItem.Click
        Dim t As New frm6A
        t.Show()
    End Sub

    Private Sub ESISUMMARYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ESISUMMARYToolStripMenuItem.Click
        Dim t As New frmesisummary
        t.Show()
    End Sub

    Private Sub MONTLHYBACKToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MONTLHYBACKToolStripMenuItem.Click
        Dim t As New frmmonback
        t.Show()
    End Sub

    Private Sub FORM9ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FORM9ToolStripMenuItem.Click
        Dim t As New frmform9
        t.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub MansarSalaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MansarSalaryToolStripMenuItem.Click
        Dim t As New mansarsal
        t.Show()
    End Sub

    Private Sub OVERAGEEMPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OVERAGEEMPToolStripMenuItem.Click
        Dim t As New frmoverage
        t.Show()
    End Sub

    Private Sub DepartmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartmentToolStripMenuItem.Click
        Dim dep As New frmdepartment
        dep.Show()
    End Sub

    Private Sub SalaryStructureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalaryStructureToolStripMenuItem.Click
        Dim salstu As New frmsalarystructure
        salstu.Show()
    End Sub

    Private Sub SALARYSTRUCTUREToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim salstu As New frmempsalarystructure
        salstu.Show()
    End Sub

    Private Sub BonusCalculationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BonusCalculationToolStripMenuItem.Click
        Dim frmbonus As New FrmBonusRpt
        frmbonus.ShowDialog()
    End Sub

    Private Sub SalaryStatementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalaryStatementToolStripMenuItem.Click
        Dim frmsalsat As New FrmSalaryCertificate
        frmsalsat.ShowDialog()
    End Sub

    Private Sub MonthlySalaryStatementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonthlySalaryStatementToolStripMenuItem.Click
        Dim t As New frmSalMonthly
        t.ShowDialog()
    End Sub

    Private Sub LEAVEENTRYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LEAVEENTRYToolStripMenuItem.Click
        Dim leaveEntry As New frmLeaveEntryFromExcel
        leaveEntry.ShowDialog()
    End Sub

    Private Sub AllBankToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllBankToolStripMenuItem.Click
        Dim t As New frmAllBankSal
        t.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Dim t As New frmAllBankList
        t.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Dim t As New frmBankLetter
        t.ShowDialog()
    End Sub
End Class
