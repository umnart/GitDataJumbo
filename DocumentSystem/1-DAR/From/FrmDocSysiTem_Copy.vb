Option Explicit On
Option Strict On
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Windows
Public Class FrmDocSysiTem_Copy

    Dim strConn As String
    Dim Conn As New SqlConnection
    Dim da As SqlDataAdapter
    Dim ds As New DataSet
    Dim da2 As SqlDataAdapter
    Dim ds2 As New DataSet
    Dim da3 As SqlDataAdapter
    Dim ds3 As New DataSet
    Dim strSQL As String
    Dim Check As Boolean
    Dim Action As String
    Dim IsFind As Boolean
    Dim IsParentSite As Boolean
    Dim IsParentLocation As Boolean
    Dim IsParentComp As Boolean
    Dim strShowBrand As Boolean
    Dim strShowMoBrand As Boolean
    Dim strShowWindows As Boolean
    Dim strShowOffice As Boolean
    Dim comSave As New SqlCommand
    Dim comDelete As New SqlCommand
    Dim comUpdate As New SqlCommand
    Dim SQL As String
    Dim strDOCTYPE As String
    Private rowIndex As Integer

    Dim strCopyNo As String
    Dim intNUmber As Integer

    Dim strDocCtrl As String

    Dim strDocCtrl2 As String = ""
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FrmDocSysiTem_Copy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Grid()
        Call CheckDataSendDept()
        TxtDOCNO.Text = FrmDocumentSystem.TxtDOCNO.Text
        TxtDOCNAME.Text = FrmDocumentSystem.TxtDOCNAME.Text
        TxtREFNO.Text = FrmDocumentSystem.TxtREFNO.Text
        TxtREFNODATA.Text = FrmDocumentSystem.TxtREFNODATA.Text
        TxtDocCtrl.Text = FrmDocumentSystem.TxtDocCtrl.Text


        Call clearText()



        If FrmDocumentSystem.TxtACTAMD.Checked = True Or FrmDocumentSystem.TxtUndoDoc.Checked = True Or (FrmDocumentSystem.TxtACTOBS.Checked = True And FrmDocumentSystem.TxtCheckDelete.Text = "ต้นฉบับ") Then

            If TxtREFNO.Text <> "" Then

                Me.dgvCopy.AllowUserToAddRows = True
                Me.dgvCopyNo.AllowUserToAddRows = True
                Call LoadData()
                Me.dgvCopy.AllowUserToAddRows = True
                Me.dgvCopyNo.AllowUserToAddRows = True

                bntAddNew.Enabled = True
                bntDeleteData.Enabled = True
                bntSaveData.Enabled = True

            End If
        Else

            Me.dgvCopy.AllowUserToAddRows = True
            Me.dgvCopyNo.AllowUserToAddRows = True

            If FrmDocumentSystem.TxtORGJD.Checked = True Or FrmDocumentSystem.TxtJobD.Checked = True Then

                Call LoadDataGridGA()
            Else
                Call LoadDataGrid()
            End If



            Me.dgvCopy.AllowUserToAddRows = False
            Me.dgvCopyNo.AllowUserToAddRows = False

            bntAddNew.Enabled = True
            bntDeleteData.Enabled = True
            bntSaveData.Enabled = True
        End If



    End Sub

    Sub CheckDataSendDept()

        Dim command1 As New SqlCommand("Select * FROM  QEa_DocSysItem " &
                                    " WHERE REFNO ='" & FrmDocumentSystem.TxtREFNO.Text & "' AND REFNODATA ='" & FrmDocumentSystem.TxtREFNODATA.Text & "'AND StatusUpSendDoc = 'OK'", DB_CMD.ObjConn)
        Dim table1 As New DataTable
        Dim adapter1 As New SqlDataAdapter(command1)
        Dim ds1 As New DataSet
        adapter1.Fill(table1)
        lblStatus.Text = ""
        If table1.Rows.Count > 0 Then
            lblStatus.Text = "update ตารางแจกจ่ายเล้ว"
        End If

    End Sub




    Sub LoadDataToDept()

        Me.dgvToDept.AllowUserToAddRows = True

        Dim Sql As String = "Select * from QEm_ToDept "
        Sql = Sql + " Order by ToDept asc"
        Dim Dt As New DataTable
        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
        dgvToDept.Rows.Clear()

        Dim intNo As Integer = 1
        For Each Dtr As DataRow In Dt.Rows
            With dgvToDept
                ' intM = 1
                'intW = 1

                Application.DoEvents()
                .Rows.Add()
                ' .Item(0, .Rows.Count - 2).Value = intNo
                .Item(1, .Rows.Count - 2).Value = Dtr.Item("ToDept").ToString
                .Item(2, .Rows.Count - 2).Value = Dtr.Item("ToDeptName").ToString
                .Item(3, .Rows.Count - 2).Value = 1
                '.Item(3, .Rows.Count - 2).Value = Dtr.Item("Branch").ToString


            End With

        Next

        Me.dgvToDept.AllowUserToAddRows = False
    End Sub

    Sub LoadDataToDeptGA()

        Me.dgvToDept.AllowUserToAddRows = True

        Dim Sql As String = "Select * from QEm_ToDeptGA "
        Sql = Sql + " Order by ID,ToDept asc"
        Dim Dt As New DataTable
        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
        dgvToDept.Rows.Clear()

        Dim intNo As Integer = 1
        For Each Dtr As DataRow In Dt.Rows
            With dgvToDept
                ' intM = 1
                'intW = 1

                Application.DoEvents()
                .Rows.Add()
                ' .Item(0, .Rows.Count - 2).Value = intNo
                .Item(1, .Rows.Count - 2).Value = Dtr.Item("ToDept").ToString
                .Item(2, .Rows.Count - 2).Value = Dtr.Item("ToDeptName").ToString
                .Item(3, .Rows.Count - 2).Value = 1
                '.Item(3, .Rows.Count - 2).Value = Dtr.Item("Branch").ToString


            End With

        Next

        Me.dgvToDept.AllowUserToAddRows = False
    End Sub


    Sub Grid()

        With Me.dgvToDept
            .RowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            '.AlternatingRowsDefaultCellStyle.Font.arial, 
            .DefaultCellStyle.Font = New Font("Arial", 8)
            .DefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.Font = New Font("Arial", 8)
            .ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 8, FontStyle.Bold)
        End With


        With Me.dgvCopy
            .RowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            '.AlternatingRowsDefaultCellStyle.Font.arial, 
            .DefaultCellStyle.Font = New Font("Arial", 8)
            .DefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.Font = New Font("Arial", 8)
            .ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 8, FontStyle.Bold)
        End With

        With Me.dgvCopyNo
            .RowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            '.AlternatingRowsDefaultCellStyle.Font.arial, 
            .DefaultCellStyle.Font = New Font("Arial", 8)
            .DefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.Font = New Font("Arial", 8)
            .ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 8, FontStyle.Bold)
        End With
    End Sub

    Sub LoadData()
        Dim strStatusData As String = ""

        Dim cri As String = ""
        Dim intQty As Integer = 0
        Dim strTodept As String = ""
        If FrmDocumentSystem.TxtUndoDoc.Checked = True Then
            If lblStatus.Text = "update ตารางแจกจ่ายเล้ว" Then
                strStatusData = "A"
            Else
                strStatusData = "I"
            End If

        Else
            strStatusData = "A"

        End If
        CmdExcute("DELETE FROM QEa_DocSysItem_Copy WHERE DOCNO = '" & TxtDOCNO.Text & "' AND REFNO ='" & TxtREFNO.Text & "' AND REFNODATA ='" & TxtREFNODATA.Text & "' ", DB_CMD.ObjConn)


        Dim Sql As String = "Select DOCNO, language, CtypeData, DocCtrl, CopyNo, ToDept from QEa_SendDocToDept "

        Sql = Sql + "GROUP BY language, CtypeData, CopyNo, ToDept, DOCNO, DocCtrl, STATUS"
        Sql = Sql + " HAVING DOCNO = '" & TxtDOCNO.Text & "' "
        'Sql = Sql + " AND  DocCtrl= 'Y' "
        Sql = Sql + " AND STATUS = '" & strStatusData & "' "
        Sql = Sql + " ORDER BY language, CtypeData, ToDept asc"
        Dim Dt As New DataTable
        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)

        dgvCopy.Rows.Clear()


        Dim intNo As Integer = 1
        For Each Dtr As DataRow In Dt.Rows


            If strTodept = Dtr.Item("ToDept").ToString Then 'Or Dtr.Item("CtypeData").ToString = "SERVER" Then

                GoTo NEXTSTEPDATA

            End If

            With dgvCopy


                Dim Sql1 As String = "SELECT Count(CopyNo) AS CountOfCopyNo from QEa_SendDocToDept "
                Sql1 = Sql1 + " WHERE DOCNO = '" & TxtDOCNO.Text & "' "
                Sql1 = Sql1 + " AND  language= '" & Dtr.Item("language").ToString & "' "
                Sql1 = Sql1 + " And CtypeData = '" & Dtr.Item("CtypeData").ToString & "' "
                Sql1 = Sql1 + " And ToDept = '" & Dtr.Item("ToDept").ToString & "' "
                'Sql1 = Sql1 + " AND  DocCtrl= 'Y' "
                Sql1 = Sql1 + " AND STATUS = '" & strStatusData & "' "
                Dim Dt1 As New DataTable
                Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)

                'strAppQEReceiveCARDate = ""
                'strQEVerifyDate = ""


                Dim Sql3 As String = "SELECT * from QEm_ToDept "
                Sql3 = Sql3 + " WHERE ToDept = '" & Dtr.Item("ToDept").ToString & "' "
                Dim Dt3 As New DataTable
                Dt3 = DB_CMD.GetData_Table(Sql3, DB_CMD.ObjConn)


                Application.DoEvents()
                .Rows.Add()
                .Item(0, .Rows.Count - 2).Value = intNo
                .Item(1, .Rows.Count - 2).Value = TxtREFNO.Text
                .Item(2, .Rows.Count - 2).Value = Dtr.Item("DOCNO").ToString
                .Item(3, .Rows.Count - 2).Value = Dtr.Item("language").ToString
                .Item(4, .Rows.Count - 2).Value = Dtr.Item("CtypeData").ToString

                For Each Dtr3 As DataRow In Dt3.Rows
                    .Item(5, .Rows.Count - 2).Value = Dtr3.Item("ToDeptName").ToString
                Next


                If Dtr.Item("DocCtrl").ToString = "Y" Then
                    .Item(7, .Rows.Count - 2).Value = "เอกสารควบคุม"
                ElseIf Dtr.Item("DocCtrl").ToString = "N" Then
                    .Item(7, .Rows.Count - 2).Value = "เอกสารไม่ควบคุม"
                End If

                For Each Dtr1 As DataRow In Dt1.Rows
                    .Item(6, .Rows.Count - 2).Value = Dtr1.Item("CountOfCopyNo").ToString
                    intQty = CInt(Dtr1.Item("CountOfCopyNo").ToString)
                Next

                .Item(8, .Rows.Count - 2).Value = TxtREFNODATA.Text

            End With

            intNo = intNo + 1

            Dim sqlinsert As String
            sqlinsert = "INSERT INTO QEa_DocSysItem_Copy(REFNO,REFNODATA,DOCNO,language,CtypeData,DocCtrl,ToDept,Qty) " &
                                  "VALUES(@REFNO,@REFNODATA,@DOCNO,@language,@CtypeData,@DocCtrl,@ToDept,@Qty)"

            With comSave
                .Parameters.Clear()
                .Parameters.Add("@REFNO", SqlDbType.VarChar).Value = TxtREFNO.Text
                .Parameters.Add("@REFNODATA", SqlDbType.VarChar).Value = TxtREFNODATA.Text
                .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = Dtr.Item("DOCNO").ToString()
                .Parameters.Add("@language", SqlDbType.VarChar).Value = Dtr.Item("language").ToString()
                .Parameters.Add("@CtypeData", SqlDbType.VarChar).Value = Dtr.Item("CtypeData").ToString()
                .Parameters.Add("@DocCtrl", SqlDbType.VarChar).Value = Dtr.Item("DocCtrl").ToString()
                .Parameters.Add("@ToDept", SqlDbType.VarChar).Value = Dtr.Item("ToDept").ToString()
                .Parameters.Add("@Qty", SqlDbType.Int).Value = intQty

                .CommandText = sqlinsert
                .Connection = DB_CMD.ObjConn
                .ExecuteNonQuery()
            End With


            strTodept = Dtr.Item("ToDept").ToString
NEXTSTEPDATA:
        Next




        '  QEa_DocSysItem_CopyNo
        CmdExcute("DELETE FROM QEa_DocSysItem_CopyNo WHERE DOCNO = '" & TxtDOCNO.Text & "' AND REFNO ='" & TxtREFNO.Text & "' AND REFNODATA ='" & TxtREFNODATA.Text & "' ", DB_CMD.ObjConn)


        Dim Sql2 As String = "SELECT * from QEa_SendDocToDept "
        Sql2 = Sql2 + " WHERE DOCNO = '" & TxtDOCNO.Text & "' "
        'Sql2 = Sql2 + " AND  language= '" & Dtr.Item("language").ToString & "' "
        'Sql2 = Sql2 + " And CtypeData = '" & Dtr.Item("CtypeData").ToString & "' "
        'Sql2 = Sql2 + " And ToDept = '" & Dtr.Item("ToDept").ToString & "' "
        'Sql2 = Sql2 + " AND  DocCtrl= 'Y' "
        Sql2 = Sql2 + " AND STATUS ='" & strStatusData & "' "
        Dim Dt2 As New DataTable
        Dt2 = DB_CMD.GetData_Table(Sql2, DB_CMD.ObjConn)
        dgvCopyNo.Rows.Clear()
        'Dim intNo As Integer = 1
        intNo = 1
        For Each Dtr2 As DataRow In Dt2.Rows
            Dim sqlinsert As String
            sqlinsert = "INSERT INTO QEa_DocSysItem_CopyNo(REFNO,REFNODATA,DOCNO,language,CtypeData,DocCtrl,ToDept,CopyNo) " &
                                  "VALUES(@REFNO,@REFNODATA,@DOCNO,@language,@CtypeData,@DocCtrl,@ToDept,@CopyNo)"

            With comSave
                .Parameters.Clear()
                .Parameters.Add("@REFNO", SqlDbType.VarChar).Value = TxtREFNO.Text
                .Parameters.Add("@REFNODATA", SqlDbType.VarChar).Value = TxtREFNODATA.Text
                .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = Dtr2.Item("DOCNO").ToString()
                .Parameters.Add("@language", SqlDbType.VarChar).Value = Dtr2.Item("language").ToString()
                .Parameters.Add("@CtypeData", SqlDbType.VarChar).Value = Dtr2.Item("CtypeData").ToString()
                .Parameters.Add("@DocCtrl", SqlDbType.VarChar).Value = Dtr2.Item("DocCtrl").ToString()
                .Parameters.Add("@ToDept", SqlDbType.VarChar).Value = Dtr2.Item("ToDept").ToString()
                .Parameters.Add("@CopyNo", SqlDbType.VarChar).Value = Dtr2.Item("CopyNo").ToString()

                .CommandText = sqlinsert
                .Connection = DB_CMD.ObjConn
                .ExecuteNonQuery()

            End With



            Dim Sql3 As String = "SELECT * from QEm_ToDept "
            Sql3 = Sql3 + " WHERE ToDept = '" & Dtr2.Item("ToDept").ToString & "' "
            Dim Dt3 As New DataTable
            Dt3 = DB_CMD.GetData_Table(Sql3, DB_CMD.ObjConn)

            With dgvCopyNo
                Application.DoEvents()
                .Rows.Add()
                .Item(0, .Rows.Count - 2).Value = intNo
                .Item(1, .Rows.Count - 2).Value = TxtREFNO.Text
                .Item(2, .Rows.Count - 2).Value = Dtr2.Item("DOCNO").ToString
                .Item(3, .Rows.Count - 2).Value = Dtr2.Item("language").ToString
                .Item(4, .Rows.Count - 2).Value = Dtr2.Item("CtypeData").ToString
                For Each Dtr3 As DataRow In Dt3.Rows
                    .Item(5, .Rows.Count - 2).Value = Dtr3.Item("ToDeptName").ToString
                Next


                .Item(6, .Rows.Count - 2).Value = Dtr2.Item("CopyNo").ToString

                If Dtr2.Item("DocCtrl").ToString = "Y" Then
                    .Item(7, .Rows.Count - 2).Value = "เอกสารควบคุม"
                ElseIf Dtr2.Item("DocCtrl").ToString = "N" Then
                    .Item(7, .Rows.Count - 2).Value = "เอกสารไม่ควบคุม"
                End If

                .Item(8, .Rows.Count - 2).Value = TxtREFNODATA.Text
                .Item(9, .Rows.Count - 2).Value = Dtr2.Item("Todept").ToString

            End With
            intNo = intNo + 1
        Next




    End Sub

    Private Sub bntAddNew_Click(sender As Object, e As EventArgs) Handles bntAddNew.Click
        Call clearText()
        If FrmDocumentSystem.TxtORGJD.Checked = True Or FrmDocumentSystem.TxtJobD.Checked = True Then

            Call LoadDataToDeptGA()

        Else

            Call LoadDataToDept()

        End If


        Call EnabledText()
        bntDeleteData.Enabled = True
        bntSaveData.Enabled = True
        bntAddNew.Enabled = False

        'dgvCopy.Rows.Clear()
        'dgvCopyNo.Rows.Clear()



    End Sub

    Sub LoadDataGrid()


        Dim Sql As String = "Select *  from QEa_DocSysItem_Copy "
        Sql = Sql + " WHERE DOCNO = '" & TxtDOCNO.Text & "' AND REFNO ='" & TxtREFNO.Text & "' AND REFNODATA ='" & TxtREFNODATA.Text & "'  "
        Sql = Sql + " ORDER BY language, CtypeData, ToDept asc"
        Dim Dt As New DataTable
        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)

        dgvCopy.Rows.Clear()


        Dim intNo As Integer = 1

        For Each Dtr As DataRow In Dt.Rows
            With dgvCopy


                Dim Sql3 As String = "SELECT * from QEm_ToDept "
                Sql3 = Sql3 + " WHERE ToDept = '" & Dtr.Item("ToDept").ToString & "' "
                Dim Dt3 As New DataTable
                Dt3 = DB_CMD.GetData_Table(Sql3, DB_CMD.ObjConn)


                Application.DoEvents()
                .Rows.Add()
                .Item(0, .Rows.Count - 2).Value = intNo
                .Item(1, .Rows.Count - 2).Value = TxtREFNO.Text
                .Item(2, .Rows.Count - 2).Value = Dtr.Item("DOCNO").ToString
                .Item(3, .Rows.Count - 2).Value = Dtr.Item("language").ToString
                .Item(4, .Rows.Count - 2).Value = Dtr.Item("CtypeData").ToString

                For Each Dtr3 As DataRow In Dt3.Rows
                    .Item(5, .Rows.Count - 2).Value = Dtr3.Item("ToDeptName").ToString
                Next


                If Dtr.Item("DocCtrl").ToString = "Y" Then
                    .Item(7, .Rows.Count - 2).Value = "เอกสารควบคุม"
                ElseIf Dtr.Item("DocCtrl").ToString = "N" Then
                    .Item(7, .Rows.Count - 2).Value = "เอกสารไม่ควบคุม"
                End If

                .Item(6, .Rows.Count - 2).Value = Dtr.Item("Qty").ToString


                .Item(8, .Rows.Count - 2).Value = TxtREFNODATA.Text
                .Item(9, .Rows.Count - 2).Value = Dtr.Item("ToDept").ToString
            End With

        Next









        Dim Sql2 As String = "SELECT * from QEa_DocSysItem_CopyNo "
        Sql2 = Sql2 + " WHERE DOCNO = '" & TxtDOCNO.Text & "' AND REFNO ='" & TxtREFNO.Text & "' AND REFNODATA ='" & TxtREFNODATA.Text & "'  "
        Dim Dt2 As New DataTable
        Dt2 = DB_CMD.GetData_Table(Sql2, DB_CMD.ObjConn)
        dgvCopyNo.Rows.Clear()
        intNo = 1
        For Each Dtr2 As DataRow In Dt2.Rows
            Dim sqlinsert As String = ""

            Dim Sql3 As String = "SELECT * from QEm_ToDept "
            Sql3 = Sql3 + " WHERE ToDept = '" & Dtr2.Item("ToDept").ToString & "' "
            Dim Dt3 As New DataTable
            Dt3 = DB_CMD.GetData_Table(Sql3, DB_CMD.ObjConn)

            With dgvCopyNo
                Application.DoEvents()
                .Rows.Add()
                .Item(0, .Rows.Count - 2).Value = intNo
                .Item(1, .Rows.Count - 2).Value = TxtREFNO.Text
                .Item(2, .Rows.Count - 2).Value = Dtr2.Item("DOCNO").ToString
                .Item(3, .Rows.Count - 2).Value = Dtr2.Item("language").ToString
                .Item(4, .Rows.Count - 2).Value = Dtr2.Item("CtypeData").ToString
                For Each Dtr3 As DataRow In Dt3.Rows
                    .Item(5, .Rows.Count - 2).Value = Dtr3.Item("ToDeptName").ToString
                Next


                .Item(6, .Rows.Count - 2).Value = Dtr2.Item("CopyNo").ToString

                If Dtr2.Item("DocCtrl").ToString = "Y" Then
                    .Item(7, .Rows.Count - 2).Value = "เอกสารควบคุม"
                ElseIf Dtr2.Item("DocCtrl").ToString = "N" Then
                    .Item(7, .Rows.Count - 2).Value = "เอกสารไม่ควบคุม"
                End If

                .Item(8, .Rows.Count - 2).Value = TxtREFNODATA.Text
                .Item(9, .Rows.Count - 2).Value = Dtr2.Item("ToDept").ToString

            End With
            intNo = intNo + 1
        Next




        '  MsgBox("OK")



    End Sub
    Sub LoadDataGridGA()


        Dim Sql As String = "Select *  from QEa_DocSysItem_Copy "
        Sql = Sql + " WHERE DOCNO = '" & TxtDOCNO.Text & "' AND REFNO ='" & TxtREFNO.Text & "' AND REFNODATA ='" & TxtREFNODATA.Text & "'  "
        Sql = Sql + " ORDER BY language, CtypeData, ID asc"
        Dim Dt As New DataTable
        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)

        dgvCopy.Rows.Clear()


        Dim intNo As Integer = 1

        For Each Dtr As DataRow In Dt.Rows
            With dgvCopy


                Dim Sql3 As String = "SELECT * from QEm_ToDeptGA "
                Sql3 = Sql3 + " WHERE ToDept = '" & Dtr.Item("ToDept").ToString & "' "
                Dim Dt3 As New DataTable
                Dt3 = DB_CMD.GetData_Table(Sql3, DB_CMD.ObjConn)


                Application.DoEvents()
                .Rows.Add()
                .Item(0, .Rows.Count - 2).Value = intNo
                .Item(1, .Rows.Count - 2).Value = TxtREFNO.Text
                .Item(2, .Rows.Count - 2).Value = Dtr.Item("DOCNO").ToString
                .Item(3, .Rows.Count - 2).Value = Dtr.Item("language").ToString
                .Item(4, .Rows.Count - 2).Value = Dtr.Item("CtypeData").ToString

                For Each Dtr3 As DataRow In Dt3.Rows
                    .Item(5, .Rows.Count - 2).Value = Dtr3.Item("ToDeptName").ToString
                Next


                If Dtr.Item("DocCtrl").ToString = "Y" Then
                    .Item(7, .Rows.Count - 2).Value = "เอกสารควบคุม"
                ElseIf Dtr.Item("DocCtrl").ToString = "N" Then
                    .Item(7, .Rows.Count - 2).Value = "เอกสารไม่ควบคุม"
                End If

                .Item(6, .Rows.Count - 2).Value = Dtr.Item("Qty").ToString


                .Item(8, .Rows.Count - 2).Value = TxtREFNODATA.Text
                .Item(9, .Rows.Count - 2).Value = Dtr.Item("ToDept").ToString
            End With

        Next









        Dim Sql2 As String = "SELECT * from QEa_DocSysItem_CopyNo "
        Sql2 = Sql2 + " WHERE DOCNO = '" & TxtDOCNO.Text & "' AND REFNO ='" & TxtREFNO.Text & "' AND REFNODATA ='" & TxtREFNODATA.Text & "' "
        Sql2 = Sql2 + "ORDER BY ID "
        Dim Dt2 As New DataTable
        Dt2 = DB_CMD.GetData_Table(Sql2, DB_CMD.ObjConn)
        dgvCopyNo.Rows.Clear()
        intNo = 1
        For Each Dtr2 As DataRow In Dt2.Rows
            Dim sqlinsert As String = ""

            Dim Sql3 As String = "SELECT * from QEm_ToDeptGA "
            Sql3 = Sql3 + " WHERE ToDept = '" & Dtr2.Item("ToDept").ToString & "' "
            Dim Dt3 As New DataTable
            Dt3 = DB_CMD.GetData_Table(Sql3, DB_CMD.ObjConn)

            With dgvCopyNo
                Application.DoEvents()
                .Rows.Add()
                .Item(0, .Rows.Count - 2).Value = intNo
                .Item(1, .Rows.Count - 2).Value = TxtREFNO.Text
                .Item(2, .Rows.Count - 2).Value = Dtr2.Item("DOCNO").ToString
                .Item(3, .Rows.Count - 2).Value = Dtr2.Item("language").ToString
                .Item(4, .Rows.Count - 2).Value = Dtr2.Item("CtypeData").ToString
                For Each Dtr3 As DataRow In Dt3.Rows
                    .Item(5, .Rows.Count - 2).Value = Dtr3.Item("ToDeptName").ToString
                Next


                .Item(6, .Rows.Count - 2).Value = Dtr2.Item("CopyNo").ToString

                If Dtr2.Item("DocCtrl").ToString = "Y" Then
                    .Item(7, .Rows.Count - 2).Value = "เอกสารควบคุม"
                ElseIf Dtr2.Item("DocCtrl").ToString = "N" Then
                    .Item(7, .Rows.Count - 2).Value = "เอกสารไม่ควบคุม"
                End If

                .Item(8, .Rows.Count - 2).Value = TxtREFNODATA.Text
                .Item(9, .Rows.Count - 2).Value = Dtr2.Item("ToDept").ToString

            End With
            intNo = intNo + 1
        Next




        '  MsgBox("OK")



    End Sub

    Sub EnabledText()



        'Txtlanguage.Text = ""
        'TxtToDept.Text = ""
        'TxtCtypeData.Text = ""
        'TxtCopyNo.Text = ""
        'TxtDocCtrl.Text = ""

        Txtlanguage.Enabled = True
        TxtToDept.Enabled = True
        TxtCtypeData.Enabled = True
        TxtCopyNo.Enabled = True
        TxtDocCtrl.Enabled = True
        bntDeleteData.Enabled = True
        bntSaveData.Enabled = True
        ' bntAddNew.Enabled = False
        ' dgvCopy.Rows.Clear()
        ' dgvCopyNo.Rows.Clear()



    End Sub


    Sub clearText()

        Txtlanguage.Text = ""
        TxtToDept.Text = ""
        TxtCtypeData.Text = ""
        TxtCopyNo.Text = ""
        ' TxtDocCtrl.Text = ""

        Txtlanguage.Enabled = False
        TxtToDept.Enabled = False
        TxtCtypeData.Enabled = False
        TxtCopyNo.Enabled = False
        ' TxtDocCtrl.Enabled = False
        bntDeleteData.Enabled = False
        bntSaveData.Enabled = False

        dgvToDept.Rows.Clear()
        chkSelectALL.Checked = False
        ' bntAddNew.Enabled = False
        'dgvCopy.Rows.Clear()
        'dgvCopyNo.Rows.Clear()


    End Sub

    Private Sub chkSelectALL_CheckedChanged(sender As Object, e As EventArgs) Handles chkSelectALL.CheckedChanged
        With Me.dgvToDept

            If FrmDocumentSystem.TxtORGJD.Checked = True Or FrmDocumentSystem.TxtJobD.Checked = True Then

                For i As Integer = 0 To .Rows.Count - 1 'Loop data for check lot
                    If .Item(1, i).Value.ToString <> "-" Then
                        If chkSelectALL.Checked = True Then
                            .Item(0, i).Value = True
                            .Item(3, i).Value = 1
                        End If
                    End If



                    If chkSelectALL.Checked = False Then
                        .Item(0, i).Value = False
                        .Item(3, i).Value = 1
                    End If

                Next
            Else


                For i As Integer = 0 To .Rows.Count - 1 'Loop data for check lot
                    If .Item(1, i).Value.ToString <= "026" Then
                        If chkSelectALL.Checked = True Then
                            .Item(0, i).Value = True
                            .Item(3, i).Value = 1
                        End If
                    End If



                    If chkSelectALL.Checked = False Then
                        .Item(0, i).Value = False
                        .Item(3, i).Value = 1
                    End If

                Next
            End If
        End With
    End Sub

    Private Sub bntSaveData_Click(sender As Object, e As EventArgs) Handles bntSaveData.Click
        ' CmdExcute("DELETE FROM QEa_DocSysItem_Copy WHERE REFNO='" & TxtREFNO.Text & "' AND REFNODATA='" & TxtREFNODATA.Text & "' AND DOCNO='" & TxtDOCNO.Text & "' ", DB_CMD.ObjConn)

        ' CmdExcute("DELETE FROM QEa_DocSysItem_CopyNo WHERE REFNO='" & TxtREFNO.Text & "' AND REFNODATA='" & TxtREFNODATA.Text & "' AND DOCNO='" & TxtDOCNO.Text & "' ", DB_CMD.ObjConn)

        If TxtDOCNO.Text = "" Or Txtlanguage.Text = "" Or TxtCtypeData.Text = "" Or TxtDocCtrl.Text = "" Then
            MsgBox("กรุณาใส่ข้อมูลให้ครบด้วย")
            TxtDocCtrl.Focus()
            Exit Sub
        End If


        If TxtDocCtrl.Text = "เอกสารควบคุม" Then
            strDocCtrl = "Y"
        ElseIf TxtDocCtrl.Text = "เอกสารไม่ควบคุม" Then
            strDocCtrl = "N"
        End If




        Select Case strCaseManage
            Case "New"
                If FrmDocumentSystem.TxtORGJD.Checked = True Or FrmDocumentSystem.TxtJobD.Checked = True Then
                    Call ACTNEWGA
                Else

                    Call ACTNEW()
                End If
            Case "Edit"

            Case "Cancel"

                Call ACTOBS()

            Case "Copy"
                Call ActCpy()
            Case "Replace"

                Call Replace()

            Case "Undo"
        End Select






        bntAddNew.Enabled = True

    End Sub


    Sub Replace()

        'End Select
        Dim sqlinsert As String
        Dim strCopyNo As String = ""
        Dim strCopyNo_1 As String = ""
        Dim cMaxCopy As Integer = 0
        Dim CNumber As Integer = 0
        For Each row As DataGridViewRow In dgvToDept.Rows



            If CBool(row.Cells("Sel").Value) = True Then
                intNUmber = 1


                Dim command1 As New SqlCommand("Select *  " &
                                                "FROM QEa_DocSysItem_CopyNo " &
                                                " WHERE DOCNO = '" & TxtDOCNO.Text & "' " &
                                                " AND REFNO ='" & TxtREFNO.Text & "' " &
                                                " AND REFNODATA ='" & TxtREFNODATA.Text & "' " &
                                                " AND language ='" & Txtlanguage.Text & "'  " &
                                                " AND CtypeData ='" & TxtCtypeData.Text & "' " &
                                                " AND ToDept ='" & CStr(row.Cells("ToDept").Value) & "' " &
                                                " AND CopyNo ='" & TxtCopyNo.Text & "' " &
                                                " AND DocCtrl ='" & strDocCtrl & "' ", DB_CMD.ObjConn)
                Dim table1 As New DataTable
                Dim adapter1 As New SqlDataAdapter(command1)
                Dim ds1 As New DataSet
                adapter1.Fill(table1)

                If table1.Rows.Count > 0 Then

                    Exit Sub

                Else


                    Dim command As New SqlCommand("Select *  " &
                                               "FROM QEa_SendDocToDept " &
                                               " WHERE DOCNO = '" & TxtDOCNO.Text & "' " &
                                               " AND STATUS ='A' " &
                                               " AND language ='" & Txtlanguage.Text & "'  " &
                                               " AND CtypeData ='" & TxtCtypeData.Text & "' " &
                                               " AND ToDept ='" & CStr(row.Cells("ToDept").Value) & "' " &
                                               " AND CopyNo ='" & TxtCopyNo.Text & "' " &
                                               " AND DocCtrl ='" & strDocCtrl & "' ", DB_CMD.ObjConn)
                    Dim table As New DataTable
                    Dim adapter As New SqlDataAdapter(command)
                    Dim ds As New DataSet
                    adapter.Fill(table)

                    If table.Rows.Count > 0 Then

                        GoTo NEXTSTEP_ADDDATA
                    Else


                        MsgBox("ไม่พบเลขที่สำเนาที่ต้องการ ", CType(MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, MsgBoxStyle))
                        Exit Sub

                    End If


                End If


NEXTSTEP_ADDDATA:


                sqlinsert = "INSERT INTO QEa_DocSysItem_CopyNo(REFNO,REFNODATA,DOCNO,language,CtypeData,DocCtrl,ToDept,CopyNo) " &
                                        "VALUES(@REFNO,@REFNODATA,@DOCNO,@language,@CtypeData,@DocCtrl,@ToDept,@CopyNo)"


                With comSave
                    .Parameters.Clear()
                    .Parameters.Add("@REFNO", SqlDbType.VarChar).Value = TxtREFNO.Text
                    .Parameters.Add("@REFNODATA", SqlDbType.VarChar).Value = TxtREFNODATA.Text
                    .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = TxtDOCNO.Text
                    .Parameters.Add("@language", SqlDbType.VarChar).Value = Txtlanguage.Text

                    'If CStr(Row.Cells("ToDept").Value) = "014" Or CStr(Row.Cells("ToDept").Value) = "025" Then
                    '    .Parameters.Add("@CtypeData", SqlDbType.VarChar).Value = "ORIGINAL"

                    'Else
                    .Parameters.Add("@CtypeData", SqlDbType.VarChar).Value = TxtCtypeData.Text

                    'End If
                    '.Parameters.Add("@CtypeData", SqlDbType.VarChar).Value = TxtCtypeData.Text
                    .Parameters.Add("@DocCtrl", SqlDbType.VarChar).Value = strDocCtrl
                    .Parameters.Add("@ToDept", SqlDbType.VarChar).Value = CStr(row.Cells("ToDept").Value)

                    If TxtCtypeData.Text = "SERVER" Then
                        .Parameters.Add("@CopyNo", SqlDbType.VarChar).Value = "*"
                    Else
                        .Parameters.Add("@CopyNo", SqlDbType.VarChar).Value = TxtCopyNo.Text
                    End If

                    .CommandText = sqlinsert
                    .Connection = DB_CMD.ObjConn
                    .ExecuteNonQuery()

                End With



                sqlinsert = "INSERT INTO QEa_DocSysItem_Copy(REFNO,REFNODATA,DOCNO,language,CtypeData,DocCtrl,ToDept,Qty) " &
                                          "VALUES(@REFNO,@REFNODATA,@DOCNO,@language,@CtypeData,@DocCtrl,@ToDept,@Qty)"


                With comSave
                    .Parameters.Clear()
                    .Parameters.Add("@REFNO", SqlDbType.VarChar).Value = TxtREFNO.Text
                    .Parameters.Add("@REFNODATA", SqlDbType.VarChar).Value = TxtREFNODATA.Text
                    .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = TxtDOCNO.Text
                    .Parameters.Add("@language", SqlDbType.VarChar).Value = Txtlanguage.Text





                    'If CStr(row.Cells("ToDept").Value) = "014" Or CStr(row.Cells("ToDept").Value) = "025" Then

                    '    .Parameters.Add("@CtypeData", SqlDbType.VarChar).Value = "ORIGINAL"

                    'Else

                    .Parameters.Add("@CtypeData", SqlDbType.VarChar).Value = TxtCtypeData.Text

                    'End If


                    .Parameters.Add("@DocCtrl", SqlDbType.VarChar).Value = strDocCtrl
                    .Parameters.Add("@ToDept", SqlDbType.VarChar).Value = CStr(row.Cells("ToDept").Value)
                    If TxtCtypeData.Text = "SERVER" Then
                        .Parameters.Add("@Qty", SqlDbType.Int).Value = 1
                    Else
                        .Parameters.Add("@Qty", SqlDbType.Int).Value = row.Cells("Quantity").Value.ToString
                    End If


                    .CommandText = sqlinsert
                    .Connection = DB_CMD.ObjConn
                    .ExecuteNonQuery()


                End With


            End If

        Next



        Me.dgvCopy.AllowUserToAddRows = True
        Me.dgvCopyNo.AllowUserToAddRows = True


        Call LoadDataGrid()

        Me.dgvCopy.AllowUserToAddRows = False
        Me.dgvCopyNo.AllowUserToAddRows = False

        Call clearText()






    End Sub
    Sub ACTOBS()

        Dim sqlinsert As String
        Dim strCopyNo As String = ""
        Dim strCopyNo_1 As String = ""

        For Each row As DataGridViewRow In dgvToDept.Rows

            If CBool(row.Cells("Sel").Value) = True Then

                'NEXTCOPYNO:

                sqlinsert = "INSERT INTO QEa_DocSysItem_CopyNo(REFNO,REFNODATA,DOCNO,language,CtypeData,DocCtrl,ToDept,CopyNo) " &
                                                "VALUES(@REFNO,@REFNODATA,@DOCNO,@language,@CtypeData,@DocCtrl,@ToDept,@CopyNo)"


                With comSave
                    .Parameters.Clear()
                    .Parameters.Add("@REFNO", SqlDbType.VarChar).Value = TxtREFNO.Text
                    .Parameters.Add("@REFNODATA", SqlDbType.VarChar).Value = TxtREFNODATA.Text
                    .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = TxtDOCNO.Text
                    .Parameters.Add("@language", SqlDbType.VarChar).Value = Txtlanguage.Text

                    'If CStr(Row.Cells("ToDept").Value) = "014" Or CStr(Row.Cells("ToDept").Value) = "025" Then
                    '    .Parameters.Add("@CtypeData", SqlDbType.VarChar).Value = "ORIGINAL"

                    'Else




                    .Parameters.Add("@CtypeData", SqlDbType.VarChar).Value = TxtCtypeData.Text

                    'End If
                    '.Parameters.Add("@CtypeData", SqlDbType.VarChar).Value = TxtCtypeData.Text
                    '.Parameters.Add("@DocCtrl", SqlDbType.VarChar).Value = TxtDocCtrl.Text

                    If TxtDocCtrl.Text = "เอกสารควบคุม" Then
                        .Parameters.Add("@DocCtrl", SqlDbType.VarChar).Value = "Y"
                    ElseIf TxtDocCtrl.Text = "เอกสารไม่ควบคุม" Then
                        .Parameters.Add("@DocCtrl", SqlDbType.VarChar).Value = "N"
                    End If



                    .Parameters.Add("@ToDept", SqlDbType.VarChar).Value = CStr(row.Cells("ToDept").Value)
                    .Parameters.Add("@CopyNo", SqlDbType.VarChar).Value = TxtCopyNo.Text

                    .CommandText = sqlinsert
                    .Connection = DB_CMD.ObjConn
                    .ExecuteNonQuery()


                End With



                Dim Sql2 As String = "SELECT * from QEa_DocSysItem_Copy "
                Sql2 = Sql2 + " WHERE DOCNO = '" & TxtDOCNO.Text & "' "
                Sql2 = Sql2 + " AND REFNO ='" & TxtREFNO.Text & "' "
                Sql2 = Sql2 + " AND REFNODATA ='" & TxtREFNODATA.Text & "' "
                Sql2 = Sql2 + " And language ='" & Txtlanguage.Text & "'  "
                Sql2 = Sql2 + " And CtypeData ='" & TxtCtypeData.Text & "' "
                Sql2 = Sql2 + " And DocCtrl ='" & strDocCtrl & "' "
                Sql2 = Sql2 + " And ToDept ='" & CStr(row.Cells("ToDept").Value) & "' "
                Dim Dt2 As New DataTable
                Dt2 = DB_CMD.GetData_Table(Sql2, DB_CMD.ObjConn)
                'dgvCopyNo.Rows.Clear()
                Dim intNo As Integer = 1
                Dim intQty As Integer = 1
                For Each Dtr2 As DataRow In Dt2.Rows

                    intQty = CInt(Dtr2.Item("QTY").ToString) + 1

                Next




                CmdExcute("DELETE FROM QEa_DocSysItem_Copy WHERE DOCNO = '" & TxtDOCNO.Text & "' " &
               " AND REFNO ='" & TxtREFNO.Text & "' " &
               " AND REFNODATA ='" & TxtREFNODATA.Text & "' " &
              " And language ='" & Txtlanguage.Text & "'  " &
              " And CtypeData ='" & TxtCtypeData.Text & "' " &
              " And DocCtrl ='" & strDocCtrl & "' " &
              " And ToDept ='" & CStr(row.Cells("ToDept").Value) & "' ", DB_CMD.ObjConn)



                sqlinsert = "INSERT INTO QEa_DocSysItem_Copy(REFNO,REFNODATA,DOCNO,language,CtypeData,DocCtrl,ToDept,Qty) " &
                                                  "VALUES(@REFNO,@REFNODATA,@DOCNO,@language,@CtypeData,@DocCtrl,@ToDept,@Qty)"


                With comSave
                    .Parameters.Clear()
                    .Parameters.Add("@REFNO", SqlDbType.VarChar).Value = TxtREFNO.Text
                    .Parameters.Add("@REFNODATA", SqlDbType.VarChar).Value = TxtREFNODATA.Text
                    .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = TxtDOCNO.Text
                    .Parameters.Add("@language", SqlDbType.VarChar).Value = Txtlanguage.Text
                    .Parameters.Add("@CtypeData", SqlDbType.VarChar).Value = TxtCtypeData.Text
                    'End If


                    '' .Parameters.Add("@DocCtrl", SqlDbType.VarChar).Value = TxtDocCtrl.Text
                    'If TxtCtypeData.Text = "เอกสารควบคุม" Then
                    '    .Parameters.Add("@DocCtrl", SqlDbType.VarChar).Value = "Y"
                    'ElseIf TxtCtypeData.Text = "เอกสารไม่ควบคุม" Then
                    '    .Parameters.Add("@DocCtrl", SqlDbType.VarChar).Value = "N"
                    'End If




                    If TxtDocCtrl.Text = "เอกสารควบคุม" Then
                        .Parameters.Add("@DocCtrl", SqlDbType.VarChar).Value = "Y"
                    ElseIf TxtDocCtrl.Text = "เอกสารไม่ควบคุม" Then
                        .Parameters.Add("@DocCtrl", SqlDbType.VarChar).Value = "N"
                    End If



                    .Parameters.Add("@ToDept", SqlDbType.VarChar).Value = CStr(row.Cells("ToDept").Value)

                    .Parameters.Add("@Qty", SqlDbType.Int).Value = intQty

                    .CommandText = sqlinsert
                    .Connection = DB_CMD.ObjConn
                    .ExecuteNonQuery()


                End With


            End If

        Next



        Me.dgvCopy.AllowUserToAddRows = True
        Me.dgvCopyNo.AllowUserToAddRows = True


        Call LoadDataGrid()

        Me.dgvCopy.AllowUserToAddRows = False
        Me.dgvCopyNo.AllowUserToAddRows = False

        Call clearText()





    End Sub

    Sub ACTNEW()

        'If TxtCtypeData.Text = "SERVER" Then


        '    strCopyNo = "*"


        'End If






        'Select Case TxtCtypeData.Text
        '    Case "SERVER"

        '        If FrmDocumentSystem.TxtACTNEW.Checked = True Then

        '            Call ACTNEW()



        '            For Each row As DataGridViewRow In dgvToDept.Rows
        '                ' Dim IntNO As Integer = 0
        '                Dim IntTO As Integer = 0
        '                Dim sqlinsert As String
        '                Dim Result As Boolean
        '                ' Dim 



        '                If CBool(row.Cells("Sel").Value) = True Then

        '                    'IntNO = CStr(row.Cells("NoFM").Value)



        '                    'CmdExcute("DELETE FROM QEa_DocSysItem_Copy WHERE REFNO='" & TxtREFNO.Text & "' AND REFNODATA='" & TxtREFNODATA.Text & "' AND DOCNO='" & TxtDOCNO.Text & "' ", DB_CMD.ObjConn)


        '                    'DoCmd.SetWarnings False
        '                    'DoCmd.RunSQL "DELETE FROM QEa_DocSysItem_CopyNo  WHERE  RefNo = '" & Me![T_RefNo] & "' AND DocNo = '" & Me![T_DocNo] & "'"
        '                    'DoCmd.SetWarnings True

        '                    sqlinsert = "INSERT INTO QEa_DocSysItem_Copy(REFNO,REFNODATA,DOCNO,language,CtypeData,DocCtrl,ToDept,Qty) " &
        '                                  "VALUES(@REFNO,@REFNODATA,@DOCNO,@language,@CtypeData,@DocCtrl,@ToDept,@Qty)"


        '                    With comSave
        '                        .Parameters.Clear()
        '                        .Parameters.Add("@REFNO", SqlDbType.VarChar).Value = TxtREFNO.Text
        '                        .Parameters.Add("@REFNODATA", SqlDbType.VarChar).Value = TxtREFNODATA.Text
        '                        .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = TxtDOCNO.Text
        '                        .Parameters.Add("@language", SqlDbType.VarChar).Value = Txtlanguage.Text





        '                        If CStr(row.Cells("ToDept").Value) = "014" Or CStr(row.Cells("ToDept").Value) = "025" Then

        '                            .Parameters.Add("@CtypeData", SqlDbType.VarChar).Value = "ORIGINAL"

        '                        Else

        '                            .Parameters.Add("@CtypeData", SqlDbType.VarChar).Value = TxtCtypeData.Text

        '                        End If



        '                        .Parameters.Add("@DocCtrl", SqlDbType.VarChar).Value = TxtDocCtrl.Text
        '                        .Parameters.Add("@ToDept", SqlDbType.VarChar).Value = CStr(row.Cells("ToDept").Value)
        '                        .Parameters.Add("@Qty", SqlDbType.Int).Value = 1

        '                        .CommandText = sqlinsert
        '                        .Connection = DB_CMD.ObjConn
        '                        .ExecuteNonQuery()


        '                    End With





        '                    sqlinsert = "INSERT INTO QEa_DocSysItem_CopyNo(REFNO,REFNODATA,DOCNO,language,CtypeData,DocCtrl,ToDept,CopyNo) " &
        '                                "VALUES(@REFNO,@REFNODATA,@DOCNO,@language,@CtypeData,@DocCtrl,@ToDept,@CopyNo)"


        '                    With comSave
        '                        .Parameters.Clear()
        '                        .Parameters.Add("@REFNO", SqlDbType.VarChar).Value = TxtREFNO.Text
        '                        .Parameters.Add("@REFNODATA", SqlDbType.VarChar).Value = TxtREFNODATA.Text
        '                        .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = TxtDOCNO.Text
        '                        .Parameters.Add("@language", SqlDbType.VarChar).Value = Txtlanguage.Text

        '                        If CStr(row.Cells("ToDept").Value) = "014" Or CStr(row.Cells("ToDept").Value) = "025" Then
        '                            .Parameters.Add("@CtypeData", SqlDbType.VarChar).Value = "ORIGINAL"

        '                        Else
        '                            .Parameters.Add("@CtypeData", SqlDbType.VarChar).Value = TxtCtypeData.Text

        '                        End If
        '                        '.Parameters.Add("@CtypeData", SqlDbType.VarChar).Value = TxtCtypeData.Text
        '                        .Parameters.Add("@DocCtrl", SqlDbType.VarChar).Value = TxtDocCtrl.Text
        '                        .Parameters.Add("@ToDept", SqlDbType.VarChar).Value = CStr(row.Cells("ToDept").Value)

        '                        If CStr(row.Cells("ToDept").Value) = "014" Or CStr(row.Cells("ToDept").Value) = "023" Then
        '                            .Parameters.Add("@CopyNo", SqlDbType.VarChar).Value = "1"
        '                        Else
        '                            .Parameters.Add("@CopyNo", SqlDbType.VarChar).Value = "*"
        '                        End If

        '                        .CommandText = sqlinsert
        '                        .Connection = DB_CMD.ObjConn
        '                        .ExecuteNonQuery()

        '                    End With

        '                End If
        '            Next
        '        End If



        '    Case "Paper"









        'End Select
        Dim sqlinsert As String
        Dim strCopyNo As String = ""
        Dim strCopyNo_1 As String = ""

        For Each row As DataGridViewRow In dgvToDept.Rows
            intNUmber = 1
            If CBool(row.Cells("Sel").Value) = True Then


CopyNo:


                If TxtCtypeData.Text = "SERVER" Or TxtCtypeData.Text = "ORIGINAL" Then

                    strCopyNo = CType(1, String)
                Else
                    strCopyNo_1 = CType(1, String)
                    ' strCopyNo = (Format(strCopyNo_1, "00"))


                    strCopyNo = Format(CSng(strCopyNo_1), "00")
                End If




                Console.WriteLine("strFunction.RecordID: " & TxtDOCNO.Text & ":" & TxtREFNO.Text & ":" & TxtREFNODATA.Text & ":" & Txtlanguage.Text & ":" & TxtCtypeData.Text & ":" & strDocCtrl)


                Dim Sql2 As String = "SELECT * from QEa_DocSysItem_CopyNo "
                Sql2 = Sql2 + " WHERE DOCNO = '" & TxtDOCNO.Text & "' "
                Sql2 = Sql2 + " AND REFNO ='" & TxtREFNO.Text & "' "
                Sql2 = Sql2 + " AND REFNODATA ='" & TxtREFNODATA.Text & "' "
                Sql2 = Sql2 + " And language ='" & Txtlanguage.Text & "'  "
                Sql2 = Sql2 + " And CtypeData ='" & TxtCtypeData.Text & "' "
                Sql2 = Sql2 + " And DocCtrl ='" & strDocCtrl & "' "
                Dim Dt2 As New DataTable
                Dt2 = DB_CMD.GetData_Table(Sql2, DB_CMD.ObjConn)
                'dgvCopyNo.Rows.Clear()
                Dim intNo As Integer = 1
                For Each Dtr2 As DataRow In Dt2.Rows


                    Dim intMax As Integer = 0

                    Dim Sql1 As String = "SELECT Max(CopyNo) AS MaxOfCopyNo  from QEa_DocSysItem_CopyNo "

                    Sql1 = Sql1 + " WHERE DOCNO = '" & TxtDOCNO.Text & "' "
                    Sql1 = Sql1 + " AND REFNO ='" & TxtREFNO.Text & "' "
                    Sql1 = Sql1 + " AND REFNODATA ='" & TxtREFNODATA.Text & "' "
                    Sql1 = Sql1 + " And language ='" & Txtlanguage.Text & "'  "
                    Sql1 = Sql1 + " And CtypeData ='" & TxtCtypeData.Text & "' "
                    Sql1 = Sql1 + " And DocCtrl ='" & strDocCtrl & "' "

                    Dim Dt1 As New DataTable

                    Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)
                    'dgvCopyNo.Rows.Clear()

                    'Dim intNo As Integer = 1
                    For Each Dtr1 As DataRow In Dt1.Rows

                        If TxtCtypeData.Text = "SERVER" Or TxtCtypeData.Text = "ORIGINAL" Then

                            strCopyNo = CType(1, String)

                        Else

                            intMax = CInt(Dtr1.Item("MaxOfCopyNo").ToString)
                            intMax = intMax + 1
                            'strCopyNo = (Format(intMax, "00"))

                            strCopyNo = Format(CSng(intMax), "00")

                            'GoTo NEXTCOPYNO

                        End If

                    Next


                Next









NEXTSTEP_ADDDATA:






                ' If IsNothing(row.Cells("Quantity").Value.ToString) Then
                '   MsgBox("กรุณาใส่จำนวนสำเนาทื่ต้องการด้วย")
                '   Exit Sub
                'End If








                'NEXTCOPYNO:

                sqlinsert = "INSERT INTO QEa_DocSysItem_CopyNo(REFNO,REFNODATA,DOCNO,language,CtypeData,DocCtrl,ToDept,CopyNo) " &
                                        "VALUES(@REFNO,@REFNODATA,@DOCNO,@language,@CtypeData,@DocCtrl,@ToDept,@CopyNo)"


                With comSave
                    .Parameters.Clear()
                    .Parameters.Add("@REFNO", SqlDbType.VarChar).Value = TxtREFNO.Text
                    .Parameters.Add("@REFNODATA", SqlDbType.VarChar).Value = TxtREFNODATA.Text
                    .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = TxtDOCNO.Text
                    .Parameters.Add("@language", SqlDbType.VarChar).Value = Txtlanguage.Text

                    'If CStr(Row.Cells("ToDept").Value) = "014" Or CStr(Row.Cells("ToDept").Value) = "025" Then
                    '    .Parameters.Add("@CtypeData", SqlDbType.VarChar).Value = "ORIGINAL"

                    'Else
                    .Parameters.Add("@CtypeData", SqlDbType.VarChar).Value = TxtCtypeData.Text

                    'End If
                    '.Parameters.Add("@CtypeData", SqlDbType.VarChar).Value = TxtCtypeData.Text
                    ' .Parameters.Add("@DocCtrl", SqlDbType.VarChar).Value = TxtDocCtrl.Text

                    If TxtDocCtrl.Text = "เอกสารควบคุม" Then
                        .Parameters.Add("@DocCtrl", SqlDbType.VarChar).Value = "Y"
                    ElseIf TxtDocCtrl.Text = "เอกสารไม่ควบคุม" Then
                        .Parameters.Add("@DocCtrl", SqlDbType.VarChar).Value = "N"
                    End If

                    .Parameters.Add("@ToDept", SqlDbType.VarChar).Value = CStr(row.Cells("ToDept").Value)

                    If TxtCtypeData.Text = "SERVER" Then
                        .Parameters.Add("@CopyNo", SqlDbType.VarChar).Value = "*"
                    Else
                        .Parameters.Add("@CopyNo", SqlDbType.VarChar).Value = strCopyNo
                    End If

                    .CommandText = sqlinsert
                    .Connection = DB_CMD.ObjConn
                    .ExecuteNonQuery()

                End With




                intNUmber = intNUmber + 1

                If intNUmber <= CInt(row.Cells("Quantity").Value.ToString) Then
                    GoTo CopyNo
                End If







                sqlinsert = "INSERT INTO QEa_DocSysItem_Copy(REFNO,REFNODATA,DOCNO,language,CtypeData,DocCtrl,ToDept,Qty) " &
                                          "VALUES(@REFNO,@REFNODATA,@DOCNO,@language,@CtypeData,@DocCtrl,@ToDept,@Qty)"


                With comSave
                    .Parameters.Clear()
                    .Parameters.Add("@REFNO", SqlDbType.VarChar).Value = TxtREFNO.Text
                    .Parameters.Add("@REFNODATA", SqlDbType.VarChar).Value = TxtREFNODATA.Text
                    .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = TxtDOCNO.Text
                    .Parameters.Add("@language", SqlDbType.VarChar).Value = Txtlanguage.Text





                    'If CStr(row.Cells("ToDept").Value) = "014" Or CStr(row.Cells("ToDept").Value) = "025" Then

                    '    .Parameters.Add("@CtypeData", SqlDbType.VarChar).Value = "ORIGINAL"

                    'Else

                    .Parameters.Add("@CtypeData", SqlDbType.VarChar).Value = TxtCtypeData.Text

                    'End If


                    ' .Parameters.Add("@DocCtrl", SqlDbType.VarChar).Value = TxtDocCtrl.Text


                    If TxtDocCtrl.Text = "เอกสารควบคุม" Then
                        .Parameters.Add("@DocCtrl", SqlDbType.VarChar).Value = "Y"
                    ElseIf TxtDocCtrl.Text = "เอกสารไม่ควบคุม" Then
                        .Parameters.Add("@DocCtrl", SqlDbType.VarChar).Value = "N"
                    End If


                    .Parameters.Add("@ToDept", SqlDbType.VarChar).Value = CStr(row.Cells("ToDept").Value)

                    If TxtCtypeData.Text = "SERVER" Then
                        .Parameters.Add("@Qty", SqlDbType.Int).Value = 1
                    Else
                        .Parameters.Add("@Qty", SqlDbType.Int).Value = row.Cells("Quantity").Value.ToString
                    End If


                    .CommandText = sqlinsert
                    .Connection = DB_CMD.ObjConn
                    .ExecuteNonQuery()


                End With


            End If

        Next



        Me.dgvCopy.AllowUserToAddRows = True
        Me.dgvCopyNo.AllowUserToAddRows = True


        Call LoadDataGrid()

        Me.dgvCopy.AllowUserToAddRows = False
        Me.dgvCopyNo.AllowUserToAddRows = False

        Call clearText()






    End Sub

    Sub ACTNEWGA()


        'End Select
        Dim sqlinsert As String
        Dim strCopyNo As String = ""
        Dim strCopyNo_1 As String = ""
        For Each row As DataGridViewRow In dgvToDept.Rows

            If CBool(row.Cells("Sel").Value) = True Then
                '                intNUmber = 1

                'CopyNo:


                '                If TxtCtypeData.Text = "SERVER" Or TxtCtypeData.Text = "ORIGINAL" Then

                '                    strCopyNo = CType(1, String)
                '                Else
                '                    strCopyNo_1 = CType(1, String)
                '                    ' strCopyNo = (Format(strCopyNo_1, "00"))


                '                    strCopyNo = Format(CSng(strCopyNo_1), "00")
                '                End If


                '                Dim Sql2 As String = "SELECT * from QEa_DocSysItem_CopyNo "
                '                Sql2 = Sql2 + " WHERE DOCNO = '" & TxtDOCNO.Text & "' "
                '                Sql2 = Sql2 + " AND REFNO ='" & TxtREFNO.Text & "' "
                '                Sql2 = Sql2 + " AND REFNODATA ='" & TxtREFNODATA.Text & "' "
                '                Sql2 = Sql2 + " And language ='" & Txtlanguage.Text & "'  "
                '                Sql2 = Sql2 + " And CtypeData ='" & TxtCtypeData.Text & "' "
                '                Sql2 = Sql2 + " And DocCtrl ='" & TxtDocCtrl.Text & "' "
                '                Dim Dt2 As New DataTable
                '                Dt2 = DB_CMD.GetData_Table(Sql2, DB_CMD.ObjConn)
                '                'dgvCopyNo.Rows.Clear()
                '                Dim intNo As Integer = 1
                '                For Each Dtr2 As DataRow In Dt2.Rows


                '                    Dim intMax As Integer = 0

                '                    Dim Sql1 As String = "SELECT Max(CopyNo) AS MaxOfCopyNo  from QEa_DocSysItem_CopyNo "

                '                    Sql1 = Sql1 + " WHERE DOCNO = '" & TxtDOCNO.Text & "' "
                '                    Sql1 = Sql1 + " AND REFNO ='" & TxtREFNO.Text & "' "
                '                    Sql1 = Sql1 + " AND REFNODATA ='" & TxtREFNODATA.Text & "' "
                '                    Sql1 = Sql1 + " And language ='" & Txtlanguage.Text & "'  "
                '                    Sql1 = Sql1 + " And CtypeData ='" & TxtCtypeData.Text & "' "
                '                    Sql1 = Sql1 + " And DocCtrl ='" & TxtDocCtrl.Text & "' "

                '                    Dim Dt1 As New DataTable

                '                    Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)
                '                    'dgvCopyNo.Rows.Clear()

                '                    'Dim intNo As Integer = 1
                '                    For Each Dtr1 As DataRow In Dt1.Rows

                '                        If TxtCtypeData.Text = "SERVER" Or TxtCtypeData.Text = "ORIGINAL" Then

                '                            strCopyNo = CType(1, String)

                '                        Else

                '                            intMax = CInt(Dtr1.Item("MaxOfCopyNo").ToString)
                '                            intMax = intMax + 1
                '                            'strCopyNo = (Format(intMax, "00"))

                '                            strCopyNo = Format(CSng(intMax), "00")

                '                            'GoTo NEXTCOPYNO

                '                        End If

                '                    Next


                '                Next









                'NEXTSTEP_ADDDATA:






                '                ' If IsNothing(row.Cells("Quantity").Value.ToString) Then
                '                '   MsgBox("กรุณาใส่จำนวนสำเนาทื่ต้องการด้วย")
                '                '   Exit Sub
                '                'End If








                '                'NEXTCOPYNO:

                sqlinsert = "INSERT INTO QEa_DocSysItem_CopyNo(REFNO,REFNODATA,DOCNO,language,CtypeData,DocCtrl,ToDept,CopyNo) " &
                                        "VALUES(@REFNO,@REFNODATA,@DOCNO,@language,@CtypeData,@DocCtrl,@ToDept,@CopyNo)"


                With comSave
                    .Parameters.Clear()
                    .Parameters.Add("@REFNO", SqlDbType.VarChar).Value = TxtREFNO.Text
                    .Parameters.Add("@REFNODATA", SqlDbType.VarChar).Value = TxtREFNODATA.Text
                    .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = TxtDOCNO.Text
                    .Parameters.Add("@language", SqlDbType.VarChar).Value = Txtlanguage.Text

                    'If CStr(Row.Cells("ToDept").Value) = "014" Or CStr(Row.Cells("ToDept").Value) = "025" Then
                    '    .Parameters.Add("@CtypeData", SqlDbType.VarChar).Value = "ORIGINAL"

                    'Else
                    .Parameters.Add("@CtypeData", SqlDbType.VarChar).Value = TxtCtypeData.Text

                    'End If
                    '.Parameters.Add("@CtypeData", SqlDbType.VarChar).Value = TxtCtypeData.Text
                    '  .Parameters.Add("@DocCtrl", SqlDbType.VarChar).Value = TxtDocCtrl.Text

                    If TxtDocCtrl.Text = "เอกสารควบคุม" Then
                        .Parameters.Add("@DocCtrl", SqlDbType.VarChar).Value = "Y"
                    ElseIf TxtDocCtrl.Text = "เอกสารไม่ควบคุม" Then
                        .Parameters.Add("@DocCtrl", SqlDbType.VarChar).Value = "N"
                    End If



                    .Parameters.Add("@ToDept", SqlDbType.VarChar).Value = CStr(row.Cells("ToDept").Value)


                    .Parameters.Add("@CopyNo", SqlDbType.VarChar).Value = CStr(row.Cells("ToDept").Value)


                    .CommandText = sqlinsert
                    .Connection = DB_CMD.ObjConn
                    .ExecuteNonQuery()

                End With

                sqlinsert = "INSERT INTO QEa_DocSysItem_Copy(REFNO,REFNODATA,DOCNO,language,CtypeData,DocCtrl,ToDept,Qty) " &
                                          "VALUES(@REFNO,@REFNODATA,@DOCNO,@language,@CtypeData,@DocCtrl,@ToDept,@Qty)"


                With comSave
                    .Parameters.Clear()
                    .Parameters.Add("@REFNO", SqlDbType.VarChar).Value = TxtREFNO.Text
                    .Parameters.Add("@REFNODATA", SqlDbType.VarChar).Value = TxtREFNODATA.Text
                    .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = TxtDOCNO.Text
                    .Parameters.Add("@language", SqlDbType.VarChar).Value = Txtlanguage.Text





                    'If CStr(row.Cells("ToDept").Value) = "014" Or CStr(row.Cells("ToDept").Value) = "025" Then

                    '    .Parameters.Add("@CtypeData", SqlDbType.VarChar).Value = "ORIGINAL"

                    'Else

                    .Parameters.Add("@CtypeData", SqlDbType.VarChar).Value = TxtCtypeData.Text

                    'End If


                    '.Parameters.Add("@DocCtrl", SqlDbType.VarChar).Value = TxtDocCtrl.Text
                    'If TxtCtypeData.Text = "เอกสารควบคุม" Then
                    '    .Parameters.Add("@DocCtrl", SqlDbType.VarChar).Value = "Y"
                    'ElseIf TxtCtypeData.Text = "เอกสารไม่ควบคุม" Then
                    '    .Parameters.Add("@DocCtrl", SqlDbType.VarChar).Value = "N"
                    'End If



                    If TxtDocCtrl.Text = "เอกสารควบคุม" Then
                        .Parameters.Add("@DocCtrl", SqlDbType.VarChar).Value = "Y"
                    ElseIf TxtDocCtrl.Text = "เอกสารไม่ควบคุม" Then
                        .Parameters.Add("@DocCtrl", SqlDbType.VarChar).Value = "N"
                    End If


                    .Parameters.Add("@ToDept", SqlDbType.VarChar).Value = CStr(row.Cells("ToDept").Value)
                    .Parameters.Add("@Qty", SqlDbType.Int).Value = row.Cells("Quantity").Value.ToString

                    .CommandText = sqlinsert
                    .Connection = DB_CMD.ObjConn
                    .ExecuteNonQuery()


                End With


            End If

        Next



        Me.dgvCopy.AllowUserToAddRows = True
        Me.dgvCopyNo.AllowUserToAddRows = True


        Call LoadDataGridGA()

        Me.dgvCopy.AllowUserToAddRows = False
        Me.dgvCopyNo.AllowUserToAddRows = False

        Call clearText()






    End Sub
    Sub ActCpy()

        'End Select
        Dim sqlinsert As String
        Dim strCopyNo As String = ""
        Dim strCopyNo_1 As String = ""
        Dim cMaxCopy As Integer
        Dim CNumber As Integer
        For Each row As DataGridViewRow In dgvToDept.Rows



            If CBool(row.Cells("Sel").Value) = True Then
                intNUmber = 1



                'CopyNo:




                If TxtCtypeData.Text = "SERVER" Or TxtCtypeData.Text = "ORIGINAL" Then

                    strCopyNo = CType(1, String)
                Else
                    strCopyNo_1 = CType(1, String)
                    ' strCopyNo = (Format(strCopyNo_1, "00"))


                    strCopyNo = Format(CSng(strCopyNo_1), "00")
                End If





                'Dim Sql2 As String = "SELECT * from QEa_DocSysItem_CopyNo "
                'Sql2 = Sql2 + " WHERE DOCNO = '" & TxtDOCNO.Text & "' "
                'Sql2 = Sql2 + " AND REFNO ='" & TxtREFNO.Text & "' "
                'Sql2 = Sql2 + " AND REFNODATA ='" & TxtREFNODATA.Text & "' "
                'Sql2 = Sql2 + " And language ='" & Txtlanguage.Text & "'  "
                'Sql2 = Sql2 + " And CtypeData ='" & TxtCtypeData.Text & "' "
                'Sql2 = Sql2 + " And DocCtrl ='" & TxtDocCtrl.Text & "' "
                'Dim Dt2 As New DataTable
                'Dt2 = DB_CMD.GetData_Table(Sql2, DB_CMD.ObjConn)
                ''dgvCopyNo.Rows.Clear()
                'Dim intNo As Integer = 1
                'For Each Dtr2 As DataRow In Dt2.Rows




                Dim command1 As New SqlCommand("Select  Max(CopyNo) As MaxOfCopyNo  " &
                                                "FROM QEa_DocSysItem_CopyNo " &
                                                " WHERE DOCNO = '" & TxtDOCNO.Text & "' " &
                                                " AND REFNO ='" & TxtREFNO.Text & "' " &
                                                " AND REFNODATA ='" & TxtREFNODATA.Text & "' " &
                                                " AND language ='" & Txtlanguage.Text & "'  " &
                                                " AND CtypeData ='" & TxtCtypeData.Text & "' " &
                                                " AND DocCtrl ='" & strDocCtrl & "' " &
                                                " HAVING (Not (MAX(CopyNo) Is NULL)) ", DB_CMD.ObjConn)
                Dim table1 As New DataTable
                Dim adapter1 As New SqlDataAdapter(command1)
                Dim ds1 As New DataSet
                adapter1.Fill(table1)


                If table1.Rows.Count > 0 Then


                    cMaxCopy = CInt(table1.Rows(0).Item("MaxOfCopyNo").ToString)
                    cMaxCopy = cMaxCopy + 1
                    strCopyNo = Format(CSng(cMaxCopy), "00")

                Else

                    Dim Sql2 As String = "Select Max(CopyNo) As MaxOfCopyNo from QEa_SendDocToDept "
                    Sql2 = Sql2 + " WHERE DOCNO = '" & TxtDOCNO.Text & "' "
                    Sql2 = Sql2 + " And language ='" & Txtlanguage.Text & "'  "
                    Sql2 = Sql2 + " And CtypeData ='" & TxtCtypeData.Text & "' "
                    Sql2 = Sql2 + " And DocCtrl ='" & strDocCtrl & "' "
                    Sql2 = Sql2 + " And STATUS ='A' "



                    Dim Dt2 As New DataTable
                    Dt2 = DB_CMD.GetData_Table(Sql2, DB_CMD.ObjConn)
                    'dgvCopyNo.Rows.Clear()
                    Dim intNo As Integer = 1
                    For Each Dtr2 As DataRow In Dt2.Rows
                        If Dtr2.Item("MaxOfCopyNo").ToString = "*" Then
                            GoTo cNum
                        End If

                        If IsDBNull(Dtr2.Item("MaxOfCopyNo").ToString) Or Dtr2.Item("MaxOfCopyNo").ToString = "" Then
                            cMaxCopy = 1
                        Else
                            cMaxCopy = CInt(Dtr2.Item("MaxOfCopyNo").ToString)
                            cMaxCopy = cMaxCopy + 1
                            strCopyNo = Format(CSng(cMaxCopy), "00")

                        End If
                    Next
                End If








cNum:

                CNumber = 1

CopyNo:

                Dim intMax As Integer = 0

                Dim Sql21 As String = "SELECT * from QEa_DocSysItem_CopyNo "
                Sql21 = Sql21 + " WHERE DOCNO = '" & TxtDOCNO.Text & "' "
                Sql21 = Sql21 + " AND REFNO ='" & TxtREFNO.Text & "' "
                Sql21 = Sql21 + " AND REFNODATA ='" & TxtREFNODATA.Text & "' "
                Sql21 = Sql21 + " And language ='" & Txtlanguage.Text & "'  "
                Sql21 = Sql21 + " And CtypeData ='" & TxtCtypeData.Text & "' "
                Sql21 = Sql21 + " And DocCtrl ='" & strDocCtrl & "' "
                Dim Dt21 As New DataTable
                Dt21 = DB_CMD.GetData_Table(Sql21, DB_CMD.ObjConn)
                'dgvCopyNo.Rows.Clear()
                '    Dim intNo As Integer = 1
                For Each Dtr21 As DataRow In Dt21.Rows
                    If TxtCtypeData.Text = "SERVER" Or TxtCtypeData.Text = "ORIGINAL" Then

                        strCopyNo = CType(1, String)

                    Else

                        intMax = cMaxCopy
                        'intMax = intMax + 1
                        'strCopyNo = (Format(intMax, "00"))

                        strCopyNo = Format(CSng(intMax), "00")

                        'GoTo NEXTCOPYNO
                        GoTo NEXTSTEP_ADDDATA
                    End If


                Next


                'Dim Sql1 As String = "SELECT Max(CopyNo) AS MaxOfCopyNo  from QEa_DocSysItem_CopyNo "
                'Sql1 = Sql1 + " WHERE DOCNO = '" & TxtDOCNO.Text & "' "
                'Sql1 = Sql1 + " AND REFNO ='" & TxtREFNO.Text & "' "
                'Sql1 = Sql1 + " AND REFNODATA ='" & TxtREFNODATA.Text & "' "
                'Sql1 = Sql1 + " And language ='" & Txtlanguage.Text & "'  "
                'Sql1 = Sql1 + " And CtypeData ='" & TxtCtypeData.Text & "' "
                'Sql1 = Sql1 + " And DocCtrl ='" & TxtDocCtrl.Text & "' "
                'Sql1 = Sql1 + " GROUP BY CopyNo "


                'Dim Dt1 As New DataTable

                'Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)
                ''dgvCopyNo.Rows.Clear()

                ''Dim intNo As Integer = 1
                'For Each Dtr1 As DataRow In Dt1.Rows

                '    If TxtCtypeData.Text = "SERVER" Or TxtCtypeData.Text = "ORIGINAL" Then

                '        strCopyNo = CType(1, String)

                '    Else

                '        intMax = CInt(CInt(Dtr1.Item("MaxOfCopyNo").ToString))
                '        intMax = intMax + 1
                '        'strCopyNo = (Format(intMax, "00"))

                '        strCopyNo = Format(CSng(intMax), "00")

                '        'GoTo NEXTCOPYNO
                '        GoTo NEXTSTEP_ADDDATA

                '    End If

                'Next

NEXTSTEP_ADDDATA:





                ' If IsNothing(row.Cells("Quantity").Value.ToString) Then
                '   MsgBox("กรุณาใส่จำนวนสำเนาทื่ต้องการด้วย")
                '   Exit Sub
                'End If



                'NEXTCOPYNO:.0....


                sqlinsert = "INSERT INTO QEa_DocSysItem_CopyNo(REFNO,REFNODATA,DOCNO,language,CtypeData,DocCtrl,ToDept,CopyNo) " &
                                        "VALUES(@REFNO,@REFNODATA,@DOCNO,@language,@CtypeData,@DocCtrl,@ToDept,@CopyNo)"


                With comSave
                    .Parameters.Clear()
                    .Parameters.Add("@REFNO", SqlDbType.VarChar).Value = TxtREFNO.Text
                    .Parameters.Add("@REFNODATA", SqlDbType.VarChar).Value = TxtREFNODATA.Text
                    .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = TxtDOCNO.Text
                    .Parameters.Add("@language", SqlDbType.VarChar).Value = Txtlanguage.Text

                    'If CStr(Row.Cells("ToDept").Value) = "014" Or CStr(Row.Cells("ToDept").Value) = "025" Then
                    '    .Parameters.Add("@CtypeData", SqlDbType.VarChar).Value = "ORIGINAL"

                    'Else
                    .Parameters.Add("@CtypeData", SqlDbType.VarChar).Value = TxtCtypeData.Text

                    'End If
                    '.Parameters.Add("@CtypeData", SqlDbType.VarChar).Value = TxtCtypeData.Text
                    .Parameters.Add("@DocCtrl", SqlDbType.VarChar).Value = strDocCtrl
                    .Parameters.Add("@ToDept", SqlDbType.VarChar).Value = CStr(row.Cells("ToDept").Value)

                    If TxtCtypeData.Text = "SERVER" Then
                        .Parameters.Add("@CopyNo", SqlDbType.VarChar).Value = "*"
                    Else
                        .Parameters.Add("@CopyNo", SqlDbType.VarChar).Value = strCopyNo
                    End If

                    .CommandText = sqlinsert
                    .Connection = DB_CMD.ObjConn
                    .ExecuteNonQuery()

                End With




                intNUmber = intNUmber + 1
                cMaxCopy = cMaxCopy + 1

                If intNUmber <= CInt(row.Cells("Quantity").Value.ToString) Then
                    GoTo CopyNo
                End If



                sqlinsert = "INSERT INTO QEa_DocSysItem_Copy(REFNO,REFNODATA,DOCNO,language,CtypeData,DocCtrl,ToDept,Qty) " &
                                          "VALUES(@REFNO,@REFNODATA,@DOCNO,@language,@CtypeData,@DocCtrl,@ToDept,@Qty)"


                With comSave
                    .Parameters.Clear()
                    .Parameters.Add("@REFNO", SqlDbType.VarChar).Value = TxtREFNO.Text
                    .Parameters.Add("@REFNODATA", SqlDbType.VarChar).Value = TxtREFNODATA.Text
                    .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = TxtDOCNO.Text
                    .Parameters.Add("@language", SqlDbType.VarChar).Value = Txtlanguage.Text





                    'If CStr(row.Cells("ToDept").Value) = "014" Or CStr(row.Cells("ToDept").Value) = "025" Then

                    '    .Parameters.Add("@CtypeData", SqlDbType.VarChar).Value = "ORIGINAL"

                    'Else

                    .Parameters.Add("@CtypeData", SqlDbType.VarChar).Value = TxtCtypeData.Text

                    'End If


                    .Parameters.Add("@DocCtrl", SqlDbType.VarChar).Value = strDocCtrl
                    .Parameters.Add("@ToDept", SqlDbType.VarChar).Value = CStr(row.Cells("ToDept").Value)
                    If TxtCtypeData.Text = "SERVER" Then
                        .Parameters.Add("@Qty", SqlDbType.Int).Value = 1
                    Else
                        .Parameters.Add("@Qty", SqlDbType.Int).Value = row.Cells("Quantity").Value.ToString
                    End If


                    .CommandText = sqlinsert
                    .Connection = DB_CMD.ObjConn
                    .ExecuteNonQuery()


                End With


            End If

        Next



        Me.dgvCopy.AllowUserToAddRows = True
        Me.dgvCopyNo.AllowUserToAddRows = True


        Call LoadDataGrid()

        Me.dgvCopy.AllowUserToAddRows = False
        Me.dgvCopyNo.AllowUserToAddRows = False

        Call clearText()





    End Sub




    '    Sub ActCpy()

    '        'End Select
    '        Dim sqlinsert As String
    '        Dim strCopyNo As String = ""
    '        Dim strCopyNo_1 As String = ""
    '        Dim cMaxCopy As Integer
    '        Dim CNumber As Integer
    '        For Each row As DataGridViewRow In dgvToDept.Rows

    '            If CBool(row.Cells("Sel").Value) = True Then
    '                intNUmber = 1

    '                'CopyNo:


    '                If TxtCtypeData.Text = "SERVER" Or TxtCtypeData.Text = "ORIGINAL" Then

    '                    strCopyNo = CType(1, String)
    '                Else
    '                    strCopyNo_1 = CType(1, String)
    '                    ' strCopyNo = (Format(strCopyNo_1, "00"))


    '                    strCopyNo = Format(CSng(strCopyNo_1), "00")
    '                End If







    '                'Dim Sql2 As String = "SELECT * from QEa_DocSysItem_CopyNo "
    '                'Sql2 = Sql2 + " WHERE DOCNO = '" & TxtDOCNO.Text & "' "
    '                'Sql2 = Sql2 + " AND REFNO ='" & TxtREFNO.Text & "' "
    '                'Sql2 = Sql2 + " AND REFNODATA ='" & TxtREFNODATA.Text & "' "
    '                'Sql2 = Sql2 + " And language ='" & Txtlanguage.Text & "'  "
    '                'Sql2 = Sql2 + " And CtypeData ='" & TxtCtypeData.Text & "' "
    '                'Sql2 = Sql2 + " And DocCtrl ='" & TxtDocCtrl.Text & "' "
    '                'Dim Dt2 As New DataTable
    '                'Dt2 = DB_CMD.GetData_Table(Sql2, DB_CMD.ObjConn)
    '                ''dgvCopyNo.Rows.Clear()
    '                'Dim intNo As Integer = 1
    '                'For Each Dtr2 As DataRow In Dt2.Rows



    '                Dim Sql2 As String = "SELECT Max(CopyNo) AS MaxOfCopyNo from QEa_SendDocToDept "
    '                Sql2 = Sql2 + " WHERE DOCNO = '" & TxtDOCNO.Text & "' "
    '                Sql2 = Sql2 + " And language ='" & Txtlanguage.Text & "'  "
    '                Sql2 = Sql2 + " And CtypeData ='" & TxtCtypeData.Text & "' "
    '                Sql2 = Sql2 + " And DocCtrl ='" & TxtDocCtrl.Text & "' "


    '                Dim Dt2 As New DataTable
    '                Dt2 = DB_CMD.GetData_Table(Sql2, DB_CMD.ObjConn)
    '                'dgvCopyNo.Rows.Clear()
    '                Dim intNo As Integer = 1
    '                For Each Dtr2 As DataRow In Dt2.Rows
    '                    If Dtr2.Item("MaxOfCopyNo").ToString = "*" Then
    '                        GoTo cNum
    '                    End If

    '                    If IsDBNull(Dtr2.Item("MaxOfCopyNo").ToString) Or Dtr2.Item("MaxOfCopyNo").ToString = "" Then
    '                        cMaxCopy = 0
    '                    Else
    '                        cMaxCopy = CInt(Dtr2.Item("MaxOfCopyNo").ToString)

    '                    End If
    '                Next

    'cNum:

    '                CNumber = 1

    'CopyNo:

    '                Dim intMax As Integer = 0

    '                Dim Sql21 As String = "SELECT * from QEa_DocSysItem_CopyNo "
    '                Sql21 = Sql21 + " WHERE DOCNO = '" & TxtDOCNO.Text & "' "
    '                Sql21 = Sql21 + " AND REFNO ='" & TxtREFNO.Text & "' "
    '                Sql21 = Sql21 + " AND REFNODATA ='" & TxtREFNODATA.Text & "' "
    '                Sql21 = Sql21 + " And language ='" & Txtlanguage.Text & "'  "
    '                Sql21 = Sql21 + " And CtypeData ='" & TxtCtypeData.Text & "' "
    '                Sql21 = Sql21 + " And DocCtrl ='" & TxtDocCtrl.Text & "' "
    '                Dim Dt21 As New DataTable
    '                Dt21 = DB_CMD.GetData_Table(Sql21, DB_CMD.ObjConn)
    '                'dgvCopyNo.Rows.Clear()
    '                '    Dim intNo As Integer = 1
    '                For Each Dtr21 As DataRow In Dt21.Rows
    '                    If TxtCtypeData.Text = "SERVER" Or TxtCtypeData.Text = "ORIGINAL" Then

    '                        strCopyNo = CType(1, String)

    '                    Else

    '                        intMax = cMaxCopy
    '                        intMax = intMax + 1
    '                        'strCopyNo = (Format(intMax, "00"))

    '                        strCopyNo = Format(CSng(intMax), "00")

    '                        'GoTo NEXTCOPYNO
    '                        GoTo NEXTSTEP_ADDDATA
    '                    End If


    '                Next


    '                Dim Sql1 As String = "SELECT Max(CopyNo) AS MaxOfCopyNo  from QEa_DocSysItem_CopyNo "
    '                Sql1 = Sql1 + " WHERE DOCNO = '" & TxtDOCNO.Text & "' "
    '                Sql1 = Sql1 + " AND REFNO ='" & TxtREFNO.Text & "' "
    '                Sql1 = Sql1 + " AND REFNODATA ='" & TxtREFNODATA.Text & "' "
    '                Sql1 = Sql1 + " And language ='" & Txtlanguage.Text & "'  "
    '                Sql1 = Sql1 + " And CtypeData ='" & TxtCtypeData.Text & "' "
    '                Sql1 = Sql1 + " And DocCtrl ='" & TxtDocCtrl.Text & "' "
    '                Sql1 = Sql1 + " GROUP BY CopyNo "


    '                Dim Dt1 As New DataTable

    '                Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)
    '                'dgvCopyNo.Rows.Clear()

    '                'Dim intNo As Integer = 1
    '                For Each Dtr1 As DataRow In Dt1.Rows

    '                    If TxtCtypeData.Text = "SERVER" Or TxtCtypeData.Text = "ORIGINAL" Then

    '                        strCopyNo = CType(1, String)

    '                    Else

    '                        intMax = CInt(CInt(Dtr1.Item("MaxOfCopyNo").ToString))
    '                        intMax = intMax + 1
    '                        'strCopyNo = (Format(intMax, "00"))

    '                        strCopyNo = Format(CSng(intMax), "00")

    '                        'GoTo NEXTCOPYNO
    '                        GoTo NEXTSTEP_ADDDATA

    '                    End If

    '                Next







    'NEXTSTEP_ADDDATA:





    '                ' If IsNothing(row.Cells("Quantity").Value.ToString) Then
    '                '   MsgBox("กรุณาใส่จำนวนสำเนาทื่ต้องการด้วย")
    '                '   Exit Sub
    '                'End If



    '                'NEXTCOPYNO:

    '                sqlinsert = "INSERT INTO QEa_DocSysItem_CopyNo(REFNO,REFNODATA,DOCNO,language,CtypeData,DocCtrl,ToDept,CopyNo) " &
    '                                        "VALUES(@REFNO,@REFNODATA,@DOCNO,@language,@CtypeData,@DocCtrl,@ToDept,@CopyNo)"


    '                With comSave
    '                    .Parameters.Clear()
    '                    .Parameters.Add("@REFNO", SqlDbType.VarChar).Value = TxtREFNO.Text
    '                    .Parameters.Add("@REFNODATA", SqlDbType.VarChar).Value = TxtREFNODATA.Text
    '                    .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = TxtDOCNO.Text
    '                    .Parameters.Add("@language", SqlDbType.VarChar).Value = Txtlanguage.Text

    '                    'If CStr(Row.Cells("ToDept").Value) = "014" Or CStr(Row.Cells("ToDept").Value) = "025" Then
    '                    '    .Parameters.Add("@CtypeData", SqlDbType.VarChar).Value = "ORIGINAL"

    '                    'Else
    '                    .Parameters.Add("@CtypeData", SqlDbType.VarChar).Value = TxtCtypeData.Text

    '                    'End If
    '                    '.Parameters.Add("@CtypeData", SqlDbType.VarChar).Value = TxtCtypeData.Text
    '                    .Parameters.Add("@DocCtrl", SqlDbType.VarChar).Value = TxtDocCtrl.Text
    '                    .Parameters.Add("@ToDept", SqlDbType.VarChar).Value = CStr(row.Cells("ToDept").Value)

    '                    If TxtCtypeData.Text = "SERVER" Then
    '                        .Parameters.Add("@CopyNo", SqlDbType.VarChar).Value = "*"
    '                    Else
    '                        .Parameters.Add("@CopyNo", SqlDbType.VarChar).Value = strCopyNo
    '                    End If

    '                    .CommandText = sqlinsert
    '                    .Connection = DB_CMD.ObjConn
    '                    .ExecuteNonQuery()

    '                End With




    '                intNUmber = intNUmber + 1

    '                If intNUmber <= CInt(row.Cells("Quantity").Value.ToString) Then
    '                    GoTo CopyNo
    '                End If



    '                sqlinsert = "INSERT INTO QEa_DocSysItem_Copy(REFNO,REFNODATA,DOCNO,language,CtypeData,DocCtrl,ToDept,Qty) " &
    '                                          "VALUES(@REFNO,@REFNODATA,@DOCNO,@language,@CtypeData,@DocCtrl,@ToDept,@Qty)"


    '                With comSave
    '                    .Parameters.Clear()
    '                    .Parameters.Add("@REFNO", SqlDbType.VarChar).Value = TxtREFNO.Text
    '                    .Parameters.Add("@REFNODATA", SqlDbType.VarChar).Value = TxtREFNODATA.Text
    '                    .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = TxtDOCNO.Text
    '                    .Parameters.Add("@language", SqlDbType.VarChar).Value = Txtlanguage.Text





    '                    'If CStr(row.Cells("ToDept").Value) = "014" Or CStr(row.Cells("ToDept").Value) = "025" Then

    '                    '    .Parameters.Add("@CtypeData", SqlDbType.VarChar).Value = "ORIGINAL"

    '                    'Else

    '                    .Parameters.Add("@CtypeData", SqlDbType.VarChar).Value = TxtCtypeData.Text

    '                    'End If


    '                    .Parameters.Add("@DocCtrl", SqlDbType.VarChar).Value = TxtDocCtrl.Text
    '                    .Parameters.Add("@ToDept", SqlDbType.VarChar).Value = CStr(row.Cells("ToDept").Value)
    '                    If TxtCtypeData.Text = "SERVER" Then
    '                        .Parameters.Add("@Qty", SqlDbType.Int).Value = 1
    '                    Else
    '                        .Parameters.Add("@Qty", SqlDbType.Int).Value = row.Cells("Quantity").Value.ToString
    '                    End If


    '                    .CommandText = sqlinsert
    '                    .Connection = DB_CMD.ObjConn
    '                    .ExecuteNonQuery()


    '                End With


    '            End If

    '        Next



    '        Me.dgvCopy.AllowUserToAddRows = True
    '        Me.dgvCopyNo.AllowUserToAddRows = True


    '        Call LoadDataGrid()

    '        Me.dgvCopy.AllowUserToAddRows = False
    '        Me.dgvCopyNo.AllowUserToAddRows = False

    '        Call clearText()





    '    End Sub

    '    Sub ACTCPY()


    '        'End Select
    '        Dim sqlinsert As String
    '        Dim strCopyNo As String = ""
    '        Dim strCopyNo_1 As String = ""
    '        For Each row As DataGridViewRow In dgvToDept.Rows

    '            If CBool(row.Cells("Sel").Value) = True Then
    '                intNUmber = 1

    'CopyNo:


    '                If TxtCtypeData.Text = "SERVER" Or TxtCtypeData.Text = "ORIGINAL" Then

    '                    strCopyNo = CType(1, String)
    '                Else
    '                    strCopyNo_1 = CType(1, String)
    '                    ' strCopyNo = (Format(strCopyNo_1, "00"))


    '                    strCopyNo = Format(CSng(strCopyNo_1), "00")
    '                End If







    '                Dim Sql2 As String = "SELECT * from QEa_DocSysItem_CopyNo "
    '                Sql2 = Sql2 + " WHERE DOCNO = '" & TxtDOCNO.Text & "' "
    '                Sql2 = Sql2 + " AND REFNO ='" & TxtREFNO.Text & "' "
    '                Sql2 = Sql2 + " AND REFNODATA ='" & TxtREFNODATA.Text & "' "
    '                Sql2 = Sql2 + " And language ='" & Txtlanguage.Text & "'  "
    '                Sql2 = Sql2 + " And CtypeData ='" & TxtCtypeData.Text & "' "
    '                Sql2 = Sql2 + " And DocCtrl ='" & TxtDocCtrl.Text & "' "
    '                Dim Dt2 As New DataTable
    '                Dt2 = DB_CMD.GetData_Table(Sql2, DB_CMD.ObjConn)
    '                'dgvCopyNo.Rows.Clear()
    '                Dim intNo As Integer = 1
    '                For Each Dtr2 As DataRow In Dt2.Rows


    '                    Dim intMax As Integer = 0

    '                    Dim Sql1 As String = "SELECT Max(CopyNo) AS MaxOfCopyNo  from QEa_DocSysItem_CopyNo "

    '                    Sql1 = Sql1 + " WHERE DOCNO = '" & TxtDOCNO.Text & "' "
    '                    Sql1 = Sql1 + " AND REFNO ='" & TxtREFNO.Text & "' "
    '                    Sql1 = Sql1 + " AND REFNODATA ='" & TxtREFNODATA.Text & "' "
    '                    Sql1 = Sql1 + " And language ='" & Txtlanguage.Text & "'  "
    '                    Sql1 = Sql1 + " And CtypeData ='" & TxtCtypeData.Text & "' "
    '                    Sql1 = Sql1 + " And DocCtrl ='" & TxtDocCtrl.Text & "' "

    '                    Dim Dt1 As New DataTable

    '                    Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)
    '                    'dgvCopyNo.Rows.Clear()

    '                    'Dim intNo As Integer = 1
    '                    For Each Dtr1 As DataRow In Dt1.Rows

    '                        If TxtCtypeData.Text = "SERVER" Or TxtCtypeData.Text = "ORIGINAL" Then

    '                            strCopyNo = CType(1, String)

    '                        Else

    '                            intMax = CInt(Dtr1.Item("MaxOfCopyNo").ToString)
    '                            intMax = intMax + 1
    '                            'strCopyNo = (Format(intMax, "00"))

    '                            strCopyNo = Format(CSng(intMax), "00")

    '                            'GoTo NEXTCOPYNO

    '                        End If

    '                    Next


    '                Next






    'NEXTSTEP_ADDDATA:





    '                ' If IsNothing(row.Cells("Quantity").Value.ToString) Then
    '                '   MsgBox("กรุณาใส่จำนวนสำเนาทื่ต้องการด้วย")
    '                '   Exit Sub
    '                'End If



    '                'NEXTCOPYNO:

    '                sqlinsert = "INSERT INTO QEa_DocSysItem_CopyNo(REFNO,REFNODATA,DOCNO,language,CtypeData,DocCtrl,ToDept,CopyNo) " &
    '                                        "VALUES(@REFNO,@REFNODATA,@DOCNO,@language,@CtypeData,@DocCtrl,@ToDept,@CopyNo)"


    '                With comSave
    '                    .Parameters.Clear()
    '                    .Parameters.Add("@REFNO", SqlDbType.VarChar).Value = TxtREFNO.Text
    '                    .Parameters.Add("@REFNODATA", SqlDbType.VarChar).Value = TxtREFNODATA.Text
    '                    .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = TxtDOCNO.Text
    '                    .Parameters.Add("@language", SqlDbType.VarChar).Value = Txtlanguage.Text

    '                    'If CStr(Row.Cells("ToDept").Value) = "014" Or CStr(Row.Cells("ToDept").Value) = "025" Then
    '                    '    .Parameters.Add("@CtypeData", SqlDbType.VarChar).Value = "ORIGINAL"

    '                    'Else
    '                    .Parameters.Add("@CtypeData", SqlDbType.VarChar).Value = TxtCtypeData.Text

    '                    'End If
    '                    '.Parameters.Add("@CtypeData", SqlDbType.VarChar).Value = TxtCtypeData.Text
    '                    .Parameters.Add("@DocCtrl", SqlDbType.VarChar).Value = TxtDocCtrl.Text
    '                    .Parameters.Add("@ToDept", SqlDbType.VarChar).Value = CStr(row.Cells("ToDept").Value)

    '                    If TxtCtypeData.Text = "SERVER" Then
    '                        .Parameters.Add("@CopyNo", SqlDbType.VarChar).Value = "*"
    '                    Else
    '                        .Parameters.Add("@CopyNo", SqlDbType.VarChar).Value = strCopyNo
    '                    End If

    '                    .CommandText = sqlinsert
    '                    .Connection = DB_CMD.ObjConn
    '                    .ExecuteNonQuery()

    '                End With




    '                intNUmber = intNUmber + 1

    '                If intNUmber <= CInt(row.Cells("Quantity").Value.ToString) Then
    '                    GoTo CopyNo
    '                End If



    '                sqlinsert = "INSERT INTO QEa_DocSysItem_Copy(REFNO,REFNODATA,DOCNO,language,CtypeData,DocCtrl,ToDept,Qty) " &
    '                                          "VALUES(@REFNO,@REFNODATA,@DOCNO,@language,@CtypeData,@DocCtrl,@ToDept,@Qty)"


    '                With comSave
    '                    .Parameters.Clear()
    '                    .Parameters.Add("@REFNO", SqlDbType.VarChar).Value = TxtREFNO.Text
    '                    .Parameters.Add("@REFNODATA", SqlDbType.VarChar).Value = TxtREFNODATA.Text
    '                    .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = TxtDOCNO.Text
    '                    .Parameters.Add("@language", SqlDbType.VarChar).Value = Txtlanguage.Text





    '                    'If CStr(row.Cells("ToDept").Value) = "014" Or CStr(row.Cells("ToDept").Value) = "025" Then

    '                    '    .Parameters.Add("@CtypeData", SqlDbType.VarChar).Value = "ORIGINAL"

    '                    'Else

    '                    .Parameters.Add("@CtypeData", SqlDbType.VarChar).Value = TxtCtypeData.Text

    '                    'End If


    '                    .Parameters.Add("@DocCtrl", SqlDbType.VarChar).Value = TxtDocCtrl.Text
    '                    .Parameters.Add("@ToDept", SqlDbType.VarChar).Value = CStr(row.Cells("ToDept").Value)
    '                    If TxtCtypeData.Text = "SERVER" Then
    '                        .Parameters.Add("@Qty", SqlDbType.Int).Value = 1
    '                    Else
    '                        .Parameters.Add("@Qty", SqlDbType.Int).Value = row.Cells("Quantity").Value.ToString
    '                    End If


    '                    .CommandText = sqlinsert
    '                    .Connection = DB_CMD.ObjConn
    '                    .ExecuteNonQuery()


    '                End With


    '            End If

    '        Next



    '        Me.dgvCopy.AllowUserToAddRows = True
    '        Me.dgvCopyNo.AllowUserToAddRows = True


    '        Call LoadDataGrid()

    '        Me.dgvCopy.AllowUserToAddRows = False
    '        Me.dgvCopyNo.AllowUserToAddRows = False

    '        Call clearText()





    '    End Sub

    '    Sub ACTCPY()


    '        'End Select
    '        Dim sqlinsert As String
    '        Dim strCopyNo As String = ""
    '        Dim strCopyNo_1 As String = ""
    '        For Each row As DataGridViewRow In dgvToDept.Rows

    '            If CBool(row.Cells("Sel").Value) = True Then
    '                intNUmber = 1

    'CopyNo:


    '                If TxtCtypeData.Text = "SERVER" Or TxtCtypeData.Text = "ORIGINAL" Then

    '                    strCopyNo = CType(1, String)
    '                Else
    '                    strCopyNo_1 = CType(1, String)
    '                    ' strCopyNo = (Format(strCopyNo_1, "00"))


    '                    strCopyNo = Format(CSng(strCopyNo_1), "00")
    '                End If







    '                Dim Sql2 As String = "SELECT * from QEa_DocSysItem_CopyNo "
    '                Sql2 = Sql2 + " WHERE DOCNO = '" & TxtDOCNO.Text & "' "
    '                Sql2 = Sql2 + " AND REFNO ='" & TxtREFNO.Text & "' "
    '                Sql2 = Sql2 + " AND REFNODATA ='" & TxtREFNODATA.Text & "' "
    '                Sql2 = Sql2 + " And language ='" & Txtlanguage.Text & "'  "
    '                Sql2 = Sql2 + " And CtypeData ='" & TxtCtypeData.Text & "' "
    '                Sql2 = Sql2 + " And DocCtrl ='" & TxtDocCtrl.Text & "' "
    '                Dim Dt2 As New DataTable
    '                Dt2 = DB_CMD.GetData_Table(Sql2, DB_CMD.ObjConn)
    '                'dgvCopyNo.Rows.Clear()
    '                Dim intNo As Integer = 1
    '                For Each Dtr2 As DataRow In Dt2.Rows


    '                    Dim intMax As Integer = 0

    '                    Dim Sql1 As String = "SELECT Max(CopyNo) AS MaxOfCopyNo  from QEa_DocSysItem_CopyNo "

    '                    Sql1 = Sql1 + " WHERE DOCNO = '" & TxtDOCNO.Text & "' "
    '                    Sql1 = Sql1 + " AND REFNO ='" & TxtREFNO.Text & "' "
    '                    Sql1 = Sql1 + " AND REFNODATA ='" & TxtREFNODATA.Text & "' "
    '                    Sql1 = Sql1 + " And language ='" & Txtlanguage.Text & "'  "
    '                    Sql1 = Sql1 + " And CtypeData ='" & TxtCtypeData.Text & "' "
    '                    Sql1 = Sql1 + " And DocCtrl ='" & TxtDocCtrl.Text & "' "

    '                    Dim Dt1 As New DataTable

    '                    Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)
    '                    'dgvCopyNo.Rows.Clear()

    '                    'Dim intNo As Integer = 1
    '                    For Each Dtr1 As DataRow In Dt1.Rows

    '                        If TxtCtypeData.Text = "SERVER" Or TxtCtypeData.Text = "ORIGINAL" Then

    '                            strCopyNo = CType(1, String)

    '                        Else

    '                            intMax = CInt(Dtr1.Item("MaxOfCopyNo").ToString)
    '                            intMax = intMax + 1
    '                            'strCopyNo = (Format(intMax, "00"))

    '                            strCopyNo = Format(CSng(intMax), "00")

    '                            'GoTo NEXTCOPYNO

    '                        End If

    '                    Next


    '                Next






    'NEXTSTEP_ADDDATA:





    '                ' If IsNothing(row.Cells("Quantity").Value.ToString) Then
    '                '   MsgBox("กรุณาใส่จำนวนสำเนาทื่ต้องการด้วย")
    '                '   Exit Sub
    '                'End If



    '                'NEXTCOPYNO:

    '                sqlinsert = "INSERT INTO QEa_DocSysItem_CopyNo(REFNO,REFNODATA,DOCNO,language,CtypeData,DocCtrl,ToDept,CopyNo) " &
    '                                        "VALUES(@REFNO,@REFNODATA,@DOCNO,@language,@CtypeData,@DocCtrl,@ToDept,@CopyNo)"


    '                With comSave
    '                    .Parameters.Clear()
    '                    .Parameters.Add("@REFNO", SqlDbType.VarChar).Value = TxtREFNO.Text
    '                    .Parameters.Add("@REFNODATA", SqlDbType.VarChar).Value = TxtREFNODATA.Text
    '                    .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = TxtDOCNO.Text
    '                    .Parameters.Add("@language", SqlDbType.VarChar).Value = Txtlanguage.Text

    '                    'If CStr(Row.Cells("ToDept").Value) = "014" Or CStr(Row.Cells("ToDept").Value) = "025" Then
    '                    '    .Parameters.Add("@CtypeData", SqlDbType.VarChar).Value = "ORIGINAL"

    '                    'Else
    '                    .Parameters.Add("@CtypeData", SqlDbType.VarChar).Value = TxtCtypeData.Text

    '                    'End If
    '                    '.Parameters.Add("@CtypeData", SqlDbType.VarChar).Value = TxtCtypeData.Text
    '                    .Parameters.Add("@DocCtrl", SqlDbType.VarChar).Value = TxtDocCtrl.Text
    '                    .Parameters.Add("@ToDept", SqlDbType.VarChar).Value = CStr(row.Cells("ToDept").Value)

    '                    If TxtCtypeData.Text = "SERVER" Then
    '                        .Parameters.Add("@CopyNo", SqlDbType.VarChar).Value = "*"
    '                    Else
    '                        .Parameters.Add("@CopyNo", SqlDbType.VarChar).Value = strCopyNo
    '                    End If

    '                    .CommandText = sqlinsert
    '                    .Connection = DB_CMD.ObjConn
    '                    .ExecuteNonQuery()

    '                End With




    '                intNUmber = intNUmber + 1

    '                If intNUmber <= CInt(row.Cells("Quantity").Value.ToString) Then
    '                    GoTo CopyNo
    '                End If



    '                sqlinsert = "INSERT INTO QEa_DocSysItem_Copy(REFNO,REFNODATA,DOCNO,language,CtypeData,DocCtrl,ToDept,Qty) " &
    '                                          "VALUES(@REFNO,@REFNODATA,@DOCNO,@language,@CtypeData,@DocCtrl,@ToDept,@Qty)"


    '                With comSave
    '                    .Parameters.Clear()
    '                    .Parameters.Add("@REFNO", SqlDbType.VarChar).Value = TxtREFNO.Text
    '                    .Parameters.Add("@REFNODATA", SqlDbType.VarChar).Value = TxtREFNODATA.Text
    '                    .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = TxtDOCNO.Text
    '                    .Parameters.Add("@language", SqlDbType.VarChar).Value = Txtlanguage.Text





    '                    'If CStr(row.Cells("ToDept").Value) = "014" Or CStr(row.Cells("ToDept").Value) = "025" Then

    '                    '    .Parameters.Add("@CtypeData", SqlDbType.VarChar).Value = "ORIGINAL"

    '                    'Else

    '                    .Parameters.Add("@CtypeData", SqlDbType.VarChar).Value = TxtCtypeData.Text

    '                    'End If


    '                    .Parameters.Add("@DocCtrl", SqlDbType.VarChar).Value = TxtDocCtrl.Text
    '                    .Parameters.Add("@ToDept", SqlDbType.VarChar).Value = CStr(row.Cells("ToDept").Value)
    '                    If TxtCtypeData.Text = "SERVER" Then
    '                        .Parameters.Add("@Qty", SqlDbType.Int).Value = 1
    '                    Else
    '                        .Parameters.Add("@Qty", SqlDbType.Int).Value = row.Cells("Quantity").Value.ToString
    '                    End If


    '                    .CommandText = sqlinsert
    '                    .Connection = DB_CMD.ObjConn
    '                    .ExecuteNonQuery()


    '                End With


    '            End If

    '        Next



    '        Me.dgvCopy.AllowUserToAddRows = True
    '        Me.dgvCopyNo.AllowUserToAddRows = True


    '        Call LoadDataGrid()

    '        Me.dgvCopy.AllowUserToAddRows = False
    '        Me.dgvCopyNo.AllowUserToAddRows = False

    '        Call clearText()





    '    End Sub



    Private Sub dgvToDept_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvToDept.CellContentClick
        '    SendKeys.Send("{Tab}")

    End Sub

    Private Sub TxtCopyNo_TextChanged(sender As Object, e As EventArgs) Handles TxtCopyNo.TextChanged

    End Sub

    Private Sub TxtToDept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtToDept.SelectedIndexChanged

    End Sub

    Private Sub TxtCtypeData_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtCtypeData.SelectedIndexChanged

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub dgvToDept_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvToDept.CellMouseUp

        'If CBool(dgvToDept.Item(0, Me.dgvToDept.CurrentRow.Index).Value.ToString) = True Then

        '    dgvToDept.Item(3, Me.dgvToDept.CurrentRow.Index).Value = 1
        'Else
        '    dgvToDept.Item(3, Me.dgvToDept.CurrentRow.Index).Value = ""

        'End If
    End Sub

    Private Sub bntUpdate_Click(sender As Object, e As EventArgs) Handles bntUpdate.Click


        'If TxtACTNEW.Checked = True Then
        '    strCaseManage = "New"
        'ElseIf TxtACTAMD.Checked = True Then
        '    strCaseManage = "Edit"
        'ElseIf TxtACTOBS.Checked = True Then
        '    strCaseManage = "Cancel"
        'ElseIf TxtACTCPY.Checked = True Then
        '    strCaseManage = "Copy"
        'ElseIf TxtCTRPL.Checked = True Then
        '    strCaseManage = "Replace"
        'ElseIf TxtUndoDoc.Checked = True Then
        '    strCaseManage = "Undo"
        'End If

        If FrmDocumentSystem.TxtACTNEW.Checked = True Or FrmDocumentSystem.TxtACTCPY.Checked = True Then


            For Each row As DataGridViewRow In dgvCopyNo.Rows

                If CStr(row.Cells("DocCtrl2").Value) = "เอกสารควบคุม" Then

                    strDocCtrl2 = "Y"

                ElseIf CStr(row.Cells("DocCtrl2").Value) = "เอกสารไม่ควบคุม" Then

                    strDocCtrl2 = "N"

                End If

                'CmdExcute("DELETE FROM QEa_SendDocToDept WHERE DOCNO = '" & CStr(row.Cells("DOCNO2").Value) & "' " &
                '                                "And language ='" & CStr(row.Cells("language2").Value) & "' " &
                '                                "And CtypeData ='" & CStr(row.Cells("CtypeData2").Value) & "' " &
                '                                "And DocCtrl ='" & strDocCtrl2 & "' " &
                '                                "And CopyNo ='" & CStr(row.Cells("CopyNo").Value) & "' " &
                '                                "And Todept ='" & CStr(row.Cells("ToDept3").Value) & "' ", DB_CMD.ObjConn)


                Dim command1 As New SqlCommand("Select *  " &
                                                "FROM QEa_SendDocToDept " &
                                                "WHERE DOCNO = '" & CStr(row.Cells("DOCNO2").Value) & "' " &
                                                "AND language ='" & CStr(row.Cells("language2").Value) & "' " &
                                                "AND CtypeData ='" & CStr(row.Cells("CtypeData2").Value) & "' " &
                                                "AND DocCtrl ='" & strDocCtrl2 & "' " &
                                                "AND CopyNo ='" & CStr(row.Cells("CopyNo").Value) & "' " &
                                                "AND STATUS ='A' " &
                                                "AND Todept ='" & CStr(row.Cells("ToDept3").Value) & "' ", DB_CMD.ObjConn)
                Dim table1 As New DataTable
                Dim adapter1 As New SqlDataAdapter(command1)
                Dim ds1 As New DataSet
                adapter1.Fill(table1)


                If table1.Rows.Count > 0 Then

                    GoTo NEXT_STEP_COYNO

                End If



                Dim sqlinsert As String

                sqlinsert = "INSERT INTO QEa_SendDocToDept(DOCNO,language,CtypeData,DocCtrl,ToDept,CopyNo,STATUS) " &
                                  "VALUES(@DOCNO,@language,@CtypeData,@DocCtrl,@ToDept,@CopyNo,@STATUS)"

                With comSave
                    .Parameters.Clear()
                    .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = CStr(row.Cells("DOCNO2").Value)
                    .Parameters.Add("@language", SqlDbType.VarChar).Value = CStr(row.Cells("language2").Value)
                    .Parameters.Add("@CtypeData", SqlDbType.VarChar).Value = CStr(row.Cells("CtypeData2").Value)

                    If CStr(row.Cells("DocCtrl2").Value) = "เอกสารควบคุม" Then

                        .Parameters.Add("@DocCtrl", SqlDbType.VarChar).Value = "Y"

                    ElseIf CStr(row.Cells("DocCtrl2").Value) = "เอกสารไม่ควบคุม" Then

                        .Parameters.Add("@DocCtrl", SqlDbType.VarChar).Value = "N"

                    End If




                    .Parameters.Add("@ToDept", SqlDbType.VarChar).Value = CStr(row.Cells("ToDept3").Value)
                    .Parameters.Add("@CopyNo", SqlDbType.VarChar).Value = CStr(row.Cells("CopyNo").Value)
                    .Parameters.Add("@STATUS", SqlDbType.VarChar).Value = "A"
                    .CommandText = sqlinsert
                    .Connection = DB_CMD.ObjConn
                    .ExecuteNonQuery()

                End With

NEXT_STEP_COYNO:

            Next

            MsgBox("Update รายการเเจกจ่ายเรียบร้อย")
            lblStatus.Text = "update ตารางแจกจ่ายเล้ว"
            Call UpdateStatus()
            Call clearText()
            dgvCopy.Rows.Clear()
            dgvCopyNo.Rows.Clear()
            dgvToDept.Rows.Clear()


        End If

        If FrmDocumentSystem.TxtACTOBS.Checked = True Then

            For Each row As DataGridViewRow In dgvCopyNo.Rows


                If CStr(row.Cells("DocCtrl2").Value) = "เอกสารควบคุม" Then

                    strDocCtrl2 = "Y"

                ElseIf CStr(row.Cells("DocCtrl2").Value) = "เอกสารไม่ควบคุม" Then

                    strDocCtrl2 = "N"

                End If

                Dim myCommand As New SqlCommand("Update QEa_SendDocToDept Set Status = @Status " &
                                                "WHERE DOCNO = '" & CStr(row.Cells("DOCNO2").Value) & "' " &
                                                "And language ='" & CStr(row.Cells("language2").Value) & "' " &
                                                "And CtypeData ='" & CStr(row.Cells("CtypeData2").Value) & "' " &
                                                "And DocCtrl ='" & strDocCtrl2 & "' " &
                                                "And CopyNo ='" & CStr(row.Cells("CopyNo").Value) & "' " &
                                                "And Todept ='" & CStr(row.Cells("ToDept3").Value) & "' ", DB_CMD.ObjConn)

                myCommand.Parameters.Add("@Status", SqlDbType.VarChar).Value = "I"
                ' myCommand.Parameters.Add("@DateVerify", SqlDbType.VarChar).Value = TxtDateVerify.Text

                Dim rowsAffected As Integer = myCommand.ExecuteNonQuery
            Next

            MsgBox("Update รายการเเจกจ่ายเรียบร้อย")
            lblStatus.Text = "update ตารางแจกจ่ายเล้ว"
            Call UpdateStatus()

            Call clearText()

            dgvCopy.Rows.Clear()
            dgvCopyNo.Rows.Clear()
            dgvToDept.Rows.Clear()


        End If



        If FrmDocumentSystem.TxtUndoDoc.Checked = True Then

            For Each row As DataGridViewRow In dgvCopyNo.Rows


                If CStr(row.Cells("DocCtrl2").Value) = "เอกสารควบคุม" Then

                    strDocCtrl2 = "Y"

                ElseIf CStr(row.Cells("DocCtrl2").Value) = "เอกสารไม่ควบคุม" Then

                    strDocCtrl2 = "N"

                End If

                Dim myCommand As New SqlCommand("Update QEa_SendDocToDept Set Status = @Status " &
                                                "WHERE DOCNO = '" & CStr(row.Cells("DOCNO2").Value) & "' " &
                                                "And language ='" & CStr(row.Cells("language2").Value) & "' " &
                                                "And CtypeData ='" & CStr(row.Cells("CtypeData2").Value) & "' " &
                                                "And DocCtrl ='" & strDocCtrl2 & "' " &
                                                "And CopyNo ='" & CStr(row.Cells("CopyNo").Value) & "' " &
                                                "And Todept ='" & CStr(row.Cells("ToDept3").Value) & "' ", DB_CMD.ObjConn)

                myCommand.Parameters.Add("@Status", SqlDbType.VarChar).Value = "A"
                ' myCommand.Parameters.Add("@DateVerify", SqlDbType.VarChar).Value = TxtDateVerify.Text

                Dim rowsAffected As Integer = myCommand.ExecuteNonQuery
            Next

            MsgBox("Update รายการเเจกจ่ายเรียบร้อย")
            lblStatus.Text = "update ตารางแจกจ่ายเล้ว"
            Call UpdateStatus()

            Call clearText()

            dgvCopy.Rows.Clear()
            dgvCopyNo.Rows.Clear()
            dgvToDept.Rows.Clear()


        End If







    End Sub

    Sub UpdateStatus()
        Try


            Dim myCommand As New SqlCommand("Update QEa_DocSysItem Set StatusUpSendDoc = @StatusUpSendDoc " &
                                       "WHERE REFNO = '" & TxtREFNO.Text & "' " &
                                       "And REFNODATA ='" & TxtREFNODATA.Text & "' ", DB_CMD.ObjConn)

            myCommand.Parameters.Add("@StatusUpSendDoc", SqlDbType.VarChar).Value = "OK"
            ' myCommand.Parameters.Add("@DateVerify", SqlDbType.VarChar).Value = TxtDateVerify.Text

            Dim rowsAffected As Integer = myCommand.ExecuteNonQuery

        Catch ex As Exception

        End Try

    End Sub


    Private Sub TxtCopyNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCopyNo.KeyPress

        If e.KeyChar = Chr(13) Then




            Dim Sql2 As String = "SELECT * from QEa_SendDocToDept "
            Sql2 = Sql2 + " WHERE DOCNO = '" & TxtDOCNO.Text & "' "
            Sql2 = Sql2 + " AND CopyNo ='" & TxtCopyNo.Text & "' "
            Sql2 = Sql2 + " And language ='" & Txtlanguage.Text & "'  "
            Sql2 = Sql2 + " And CtypeData ='" & TxtCtypeData.Text & "' "
            Sql2 = Sql2 + " And DocCtrl ='" & strDocCtrl & "' "
            Sql2 = Sql2 + " And STATUS ='A' "
            Dim Dt2 As New DataTable
            Dt2 = DB_CMD.GetData_Table(Sql2, DB_CMD.ObjConn)
            'dgvCopyNo.Rows.Clear()
            Dim intNo As Integer = 1
            For Each Dtr2 As DataRow In Dt2.Rows


                With Me.dgvToDept
                    For i As Integer = 0 To .Rows.Count - 1 'Loop data for check lot
                        If .Item(1, i).Value.ToString = Dtr2.Item("ToDept").ToString Then

                            .Item(0, i).Value = True
                        End If
                    Next

                End With

                Exit Sub
            Next



            MsgBox("ไม่พบข้อมูลที่ต้องการ ให้ตรวจสอบความถูกต้องด้วย")
            Exit Sub

        End If

    End Sub

    Private Sub bntDeleteData_Click(sender As Object, e As EventArgs) Handles bntDeleteData.Click
        Dim Sms As String = "คุณต้องการลบข้อมูล    " & TxtDOCNO.Text & "    ออก จากรายการ หรือไม่?"

        If MsgBox(Sms, MsgBoxStyle.YesNo, "Delete") = MsgBoxResult.No Then Exit Sub
        CmdExcute("DELETE FROM QEa_DocSysItem_Copy  WHERE REFNO = '" & TxtREFNO.Text & "' " &
                                           "AND REFNODATA ='" & TxtREFNODATA.Text & "' AND DOCNO ='" & TxtDOCNO.Text & "'", DB_CMD.ObjConn)

        CmdExcute("DELETE FROM QEa_DocSysItem_CopyNo  WHERE REFNO = '" & TxtREFNO.Text & "' " &
                                           "AND REFNODATA ='" & TxtREFNODATA.Text & "' AND DOCNO ='" & TxtDOCNO.Text & "'", DB_CMD.ObjConn)

        Me.Close()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub

    Private Sub dgvCopy_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCopy.CellContentClick

    End Sub

    Private Sub dgvCopy_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvCopy.CellMouseUp
        Try


            If e.Button = MouseButtons.Right Then
                Me.dgvCopy.Rows(e.RowIndex).Selected = True
                Me.rowIndex = e.RowIndex

                strLineData = ""
                strLineRefNoData = ""
                strLineRefNoData = TxtREFNO.Text
                strToDept = dgvCopy.Rows(e.RowIndex).Cells(9).Value().ToString.Trim()



                Me.MetroContextMenu1.Show(Me.dgvCopy, e.Location)
                MetroContextMenu1.Show(Cursor.Position)


            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub menuDelete_Click(sender As Object, e As EventArgs) Handles menuDelete.Click
        Dim Sms As String = "คุณต้องการลบข้อมูล    " & TxtDOCNO.Text & "    ออก จากรายการ หรือไม่?"
        If MsgBox(Sms, MsgBoxStyle.YesNo, "Delete") = MsgBoxResult.No Then Exit Sub
        CmdExcute("DELETE FROM QEa_DocSysItem_Copy  WHERE REFNO = '" & TxtREFNO.Text & "' " &
                                           "AND REFNODATA ='" & TxtREFNODATA.Text & "' AND DOCNO ='" & TxtDOCNO.Text & "' AND ToDept = '" & strToDept & "'", DB_CMD.ObjConn)

        CmdExcute("DELETE FROM QEa_DocSysItem_CopyNo  WHERE REFNO = '" & TxtREFNO.Text & "' " &
                                           "AND REFNODATA ='" & TxtREFNODATA.Text & "' AND DOCNO ='" & TxtDOCNO.Text & "' AND ToDept = '" & strToDept & "'", DB_CMD.ObjConn)

        Me.dgvCopy.AllowUserToAddRows = True
        Me.dgvCopyNo.AllowUserToAddRows = True

        If FrmDocumentSystem.TxtORGJD.Checked = True Or FrmDocumentSystem.TxtJobD.Checked = True Then

            Call LoadDataGridGA()
        Else
            Call LoadDataGrid()
        End If



        Me.dgvCopy.AllowUserToAddRows = False
        Me.dgvCopyNo.AllowUserToAddRows = False


    End Sub
End Class