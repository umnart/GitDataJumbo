Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Net.Mail
Public Class FrmKMViewData
    Public EditNo As String
    Private intSelectedRow As Integer
    Private rowIndex As Integer
    Dim strChekGrid As String

    Dim strStatus As String = ""
    Dim strTxtAppMgrEmail As String = ""
    Dim strTxtAppMREmail As String = ""
    Dim strDOCTYPE As String = ""
    Dim comSave As New SqlCommand
    Dim Exts As String
    Dim strDOCTYPEDATA As String
    Dim strAttfile As String = ""
    Dim comUpdate As SqlCommand
    Dim ConnKB As New SqlConnection
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        FrmMainMenu.PictureBox2.Enabled = True
        Me.Close()
    End Sub

    Private Sub bntSelectEm_Click(sender As Object, e As EventArgs) Handles bntSelectEm.Click
        Me.dgvData.AllowUserToAddRows = True
        Dim strCri As String = ""
        dgvData.Rows.Clear()

        If TxtGROUPNAME.Text = "" Then

            MsgBox("กรุณาเลือกประเภทการจัดกลุ่มเก็บข้อมูล")

            TxtGROUPNAME.Focus()
            Exit Sub

        End If

        ' strCri = "WHERE B.Branch ='" & TxtBranch.Text & "' AND A.DOCTYPE ='KMM' "


        ' If TxtGROUPNAME.Text <> "" Then

        '     strCri = strCri & "AND B.GROUPNAME = '" & TxtGROUPNAME.Text & "' "

        ' End If

        ' If TxtDOCNO.Text <> "" Then

        '     strCri = strCri & "AND B.GROUPNAME = '" & TxtGROUPNAME.Text & "' "

        ' End If

        ' 'If strLavelLogon = "Medium" Then
        ' strCri = strCri & "And  B.Lavel = 'Low' "
        '' End If

        ' '' Level Low
        ' Dim Sql1 As String = "SELECT MAX(A.REVNO) As MAXREVNO, A.DOCNO, A.DOCNAME, A.DOCDEPT, MAX(A.EFFDATE) As MAXEFFDATE, A.AttachFile, B.Branch, B.GROUPNAME, B.Lavel, B.DeptDATA "
        '     Sql1 = Sql1 + "FROM QEa_CourseMaster AS A LEFT OUTER Join QEm_KM_Dept_SEL AS B ON A.DOCNO = B.DOCNO "
        '     Sql1 = Sql1 + strCri
        '     Sql1 = Sql1 + "GROUP BY A.DOCNO, A.DOCNAME, A.DOCDEPT, A.AttachFile, B.Branch, B.GROUPNAME, B.Lavel, B.DeptDATA "
        '     Sql1 = Sql1 + "Order By A.DOCNO, MAXEFFDATE "

        '     Dim Dt1 As New DataTable
        '     Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)

        ' Dim intNo As Integer = 1
        ' Dim strDOCNO As String = ""

        ' For Each Dtr1 As DataRow In Dt1.Rows
        '     With dgvData

        '         Application.DoEvents()



        '         .Rows.Add()
        '         .Item(0, .Rows.Count - 2).Value = intNo
        '         .Item(1, .Rows.Count - 2).Value = Dtr1.Item("DOCNO").ToString
        '         .Item(2, .Rows.Count - 2).Value = Dtr1.Item("DOCNAME").ToString
        '         .Item(3, .Rows.Count - 2).Value = Dtr1.Item("MAXREVNO").ToString
        '         .Item(4, .Rows.Count - 2).Value = Mid(Dtr1.Item("MAXEFFDATE").ToString, 1, 10)
        '         .Item(5, .Rows.Count - 2).Value = Dtr1.Item("Branch").ToString
        '         .Item(6, .Rows.Count - 2).Value = Dtr1.Item("DOCDEPT").ToString
        '         .Item(7, .Rows.Count - 2).Value = Dtr1.Item("AttachFile").ToString



        '     End With

        '     intNo = intNo + 1

        ' Next


        '' Level Medium, Hight, Admin
        strCri = ""

        strCri = "WHERE B.Branch ='" & TxtBranch.Text & "' AND A.DOCTYPE ='KMM' "


        If TxtGROUPNAME.Text <> "" Then

            strCri = strCri & "AND B.GROUPNAME = '" & TxtGROUPNAME.Text & "' "

        End If

        If TxtDOCNO.Text <> "" Then

            strCri = strCri & "AND B.GROUPNAME = '" & TxtGROUPNAME.Text & "' "

        End If



        If strLavelLogon = "Medium" Then



            strCri = strCri & "And  B.Lavel <> 'Hight' "
            'strCri = strCri & "And  A.DOCDEPT ='" & strDeptData & "' "
        End If

        If strLavelLogon = "Hight" Then
            strCri = strCri & "And  B.Lavel = 'Hight' "
        End If

        If strLavelLogon = "Admin" Then
            ' strcri = strcri & "And Lavel = 'Hight' "
        End If



        Dim Sql2 As String = "SELECT MAX(A.REVNO) As MAXREVNO, A.DOCNO, A.DOCNAME, A.DOCDEPT, MAX(A.EFFDATE) As MAXEFFDATE, A.AttachFile, B.Branch, B.GROUPNAME, B.Lavel "
        Sql2 = Sql2 + "FROM QEa_CourseMaster AS A LEFT OUTER Join QEm_KM_Dept_SEL AS B ON A.DOCNO = B.DOCNO "
        Sql2 = Sql2 + strCri
        Sql2 = Sql2 + "GROUP BY A.DOCNO, A.DOCNAME, A.DOCDEPT, A.AttachFile, B.Branch, B.GROUPNAME, B.Lavel "
        Sql2 = Sql2 + "Order By A.DOCNO, MAXEFFDATE "




        Dim Dt2 As New DataTable
        Dt2 = DB_CMD.GetData_Table(Sql2, DB_CMD.ObjConn)

        Dim intNo As Integer = 1
        Dim strDOCNO As String = ""

        For Each Dtr2 As DataRow In Dt2.Rows
            With dgvData

                Application.DoEvents()


                If strLavelLogon = "Admin" Or strLavelLogon = "Hight" Then
                    GoTo NEXTSTEP_1
                End If

                Dim strDeptDATASel As String = ""
                Dim command99 As New SqlCommand("SELECT  * FROM QEm_KM_Dept_SEL " &
                                     "WHERE DOCNO ='" & Dtr2.Item("DOCNO").ToString & "'" &
                                     "AND DeptDATA ='" & strDeptData & "'", DB_CMD.ObjConn)
                Dim table99 As New DataTable
                Dim adapter99 As New SqlDataAdapter(command99)
                Dim ds99 As New DataSet
                adapter99.Fill(table99)

                If table99.Rows.Count > 0 Then

                    strDeptDATASel = table99.Rows(0).Item("DeptDATA")

                End If




                If strDeptData <> strDeptDATASel Then

                    Dim command As New SqlCommand("Select * FROM QEm_KM_UserView WHERE DOCNO = '" & Dtr2.Item("DOCNO").ToString & "' AND EmployeeNo ='" & StrEmployeeNo & "' ORDER BY DOCNO DESC ", DB_CMD.ObjConn)
                    Dim table As New DataTable
                    Dim adapter As New SqlDataAdapter(command)
                    Dim ds As New DataSet
                    adapter.Fill(table)
                    adapter.Fill(ds, "QEm_KM_UserView")
                    If table.Rows.Count > 0 Then

                        GoTo NEXTSTEP_1

                    End If


                    If Dtr2.Item("Lavel").ToString <> "Low" Then
                        GoTo NEXTSTEP_2
                    End If
                End If

NEXTSTEP_1:

                .Rows.Add()
                .Item(0, .Rows.Count - 2).Value = intNo
                .Item(1, .Rows.Count - 2).Value = Dtr2.Item("DOCNO").ToString
                .Item(2, .Rows.Count - 2).Value = Dtr2.Item("DOCNAME").ToString
                .Item(3, .Rows.Count - 2).Value = Dtr2.Item("MAXREVNO").ToString
                .Item(4, .Rows.Count - 2).Value = Mid(Dtr2.Item("MAXEFFDATE").ToString, 1, 10)
                .Item(5, .Rows.Count - 2).Value = Dtr2.Item("Branch").ToString
                .Item(6, .Rows.Count - 2).Value = Dtr2.Item("DOCDEPT").ToString
                .Item(7, .Rows.Count - 2).Value = Dtr2.Item("AttachFile").ToString

            End With

            intNo = intNo + 1

NEXTSTEP_2:

        Next


        Me.dgvData.AllowUserToAddRows = False

    End Sub

    Private Sub TxtBranch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtBranch.SelectedIndexChanged
        dgvData.Rows.Clear()
        TxtDOCNO.Text = ""
    End Sub

    Private Sub TxtGROUPNAME_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtGROUPNAME.SelectedIndexChanged
        dgvData.Rows.Clear()
        TxtDOCNO.Text = ""
    End Sub

    Private Sub FrmKMViewData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.dgvData.AllowUserToAddRows = False
        Call GROUPNAME()
    End Sub
    Sub GROUPNAME()

        Dim command As New SqlCommand("SELECT  GROUPNAME, ID FROM  QEm_KM_GROUP  ORDER BY ID  ", DB_CMD.ObjConn)
        Dim table As New DataTable
        Dim adapter As New SqlDataAdapter(command)
        Dim ds As New DataSet
        adapter.Fill(table)



        adapter.Fill(ds, "QEm_KM_GROUP")
        If table.Rows.Count > 0 Then
            TxtGROUPNAME.DisplayMember = "GROUPNAME"
            TxtGROUPNAME.ValueMember = "ID"
            TxtGROUPNAME.DataSource = ds.Tables("QEm_KM_GROUP")
        End If


        Exit Sub
    End Sub

    Private Sub dgvData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellContentClick

    End Sub

    Private Sub dgvData_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvData.CellMouseDoubleClick
        Dim strDOCNO As String = ""
        Dim strAttfile As String = ""
        Try
            strDOCNO = ""
            strDOCNO = ""

            strDOCNO = CType(dgvData.Item(1, dgvData.CurrentRow.Index).Value, String)
            strAttfile = CType(dgvData.Item(7, dgvData.CurrentRow.Index).Value, String)
            If strAttfile <> "" Then
                Process.Start(strAttfile)
            End If
        Catch ex As Exception
            MsgBox("path ที่เก็บไฟล์ไม่ถูกต้อง  : " & strAttfile)
        End Try
    End Sub

    Private Sub TxtDOCNO_TextChanged(sender As Object, e As EventArgs) Handles TxtDOCNO.TextChanged

    End Sub
End Class