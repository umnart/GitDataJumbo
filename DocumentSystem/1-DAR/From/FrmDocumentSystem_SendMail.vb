Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data.SqlTypes
Imports System.Net.Mail

Public Class FrmDocumentSystem_SendMail
    Public EditNo As String
    Private intSelectedRow As Integer
    Dim ds As New DataSet
    Dim da As SqlDataAdapter
    Dim Exts As String
    Dim _txt As New TextBox
    Dim IsFindType, IsFindRepair, IsFindName, IsEquName, IsFindJobDesc, IsFindService As Boolean
    Dim strRefNoSendMail, strRefNoSendMailCheck, strPathAttFile, strPathAttFileCheck, strPathAttFileData, strEFFDATEDATA, strEFFDATEDATACheck, strDOCNOSendMail, strDOCNOSendMailCheck, StrPathServer As String
    Sub Grid()
        '  Me.dgvDetail.AllowUserToAddRows = False
        With Me.dgvDetail
            .RowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            '.AlternatingRowsDefaultCellStyle.Font.arial, 
            .DefaultCellStyle.Font = New Font("Arial", 8)
            .DefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.Font = New Font("Arial", 8)
            .ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 8, FontStyle.Bold)
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .GridColor = Color.LightGray
        End With


        With Me.dgvP2
            .RowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            '.AlternatingRowsDefaultCellStyle.Font.arial, 
            .DefaultCellStyle.Font = New Font("Arial", 8)
            .DefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.Font = New Font("Arial", 8)
            .ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 8, FontStyle.Bold)
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .GridColor = Color.LightGray
        End With

        With Me.dgvData2
            .RowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            '.AlternatingRowsDefaultCellStyle.Font.arial, 
            .DefaultCellStyle.Font = New Font("Arial", 8)
            .DefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.Font = New Font("Arial", 8)
            .ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 8, FontStyle.Bold)
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .GridColor = Color.LightGray
        End With




        With Me.grdAttFile
            .RowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            '.AlternatingRowsDefaultCellStyle.Font.arial, 
            .DefaultCellStyle.Font = New Font("Arial", 8)
            .DefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.Font = New Font("Arial", 8)
            .ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 8, FontStyle.Bold)
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .GridColor = Color.LightGray
        End With



    End Sub


    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub bntCC_Click(sender As Object, e As EventArgs) Handles bntCC.Click
        strTTCCEmail = ""
        strTTCCEmail = "CC"
        TxtEmailCC1.Text = ""

        FrmEmailList.ShowDialog()
    End Sub

    Private Sub bntTO_Click(sender As Object, e As EventArgs) Handles bntTO.Click
        strTTCCEmail = ""
        strTTCCEmail = "TO"
        txtToEmail1.Text = ""
        FrmEmailList.ShowDialog()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub bntFind_Click(sender As Object, e As EventArgs) Handles bntFind.Click
        'Dim command As New SqlCommand("Select DOCNO, DOCNAME, REVNO, MANAGE, REASON, EFFDATE, REFNODATA, REFNO, DARNO FROM QEa_DocSysItem WHERE REFNO ='" & TxtRefNoFM.Text & "' ORDER BY DOCNO, REVNO ", DB_CMD.ObjConn)
        'Dim table As New DataTable
        'Dim adapter As New SqlDataAdapter(command)
        'Dim ds As New DataSet
        'adapter.Fill(table)


        'adapter.Fill(ds, "QEa_DocSysItem")
        'If table.Rows.Count > 0 Then
        '    'TxtRefNoFM.DisplayMember = "REFNO"
        '    'TxtRefNoFM.ValueMember = "REFNO"
        '    dgvDetail.DataSource = ds.Tables("QEa_DocSysItem")

        'End If

        'Exit Sub
        Me.dgvDetail.AllowUserToAddRows = True
        Me.dgvP2.AllowUserToAddRows = True
        Me.dgvData2.AllowUserToAddRows = True


        strRefNoSendMail = ""
        strRefNoSendMailCheck = ""
        strPathAttFileCheck = ""
        strPathAttFile = ""
        strPathAttFileData = ""
        dgvDetail.Rows.Clear()
        dgvP2.Rows.Clear()
        dgvData2.Rows.Clear()

        Dim cri As String

        If TxtStatus.Text = "" Then
            MsgBox("กรุณาเลือก Status ด้วย")
            Exit Sub
        End If

        If txtSELECTSYSTEM.Text = "" Then
            MsgBox("กรุณาเลือกระบบ ด้วย")
            Exit Sub
        End If


        cri = "WHERE STATUS ='" & TxtStatus.Text & "'  AND  SELECTSYSTEM ='" & strSELECTSYSTEMEmail & "'"


        If TxtDOCDEPT.Text <> "" Then
            cri = cri & "And (PETITIONDEPT  =   '" & TxtDOCDEPT.Text & "')"
        End If

        If TxtRefNoFM.Text <> "" And TxtRefNoTO.Text <> "" Then
            cri = cri & "And (REFNO  BETWEEN   '" & TxtRefNoFM.Text & "' AND  '" & TxtRefNoTO.Text & "')"
        End If

        'If TxtDOCDEPT.Text <> "" Then
        '    cri = cri & "And (PETITIONDEPT  =   '" & TxtDOCDEPT.Text & "')"
        'End If

        'If strDeptData <> "SD" Then

        '    cri = cri & "And (SELECTSYSTEM  <> 'DS')"

        'End If


        Dim Sql As String = "SELECT * "
        Sql = Sql + " FROM  QEa_DocSysItem "
        Sql = Sql + cri
        Sql = Sql + " Order by REFNO,REFNODATA,DOCNO, REVNO asc "

        Dim Dt As New DataTable
        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)


        Dim intNo As Integer = 1
        For Each Dtr As DataRow In Dt.Rows


            Dim strMANAGEFind As String = ""
            Select Case Dtr.Item("MANAGE").ToString
                Case "N"
                    strMANAGEFind = "จัดทำใหม่"
                Case "E"
                    strMANAGEFind = "แก้ไข"
                Case "O"
                    If Dtr.Item("ACTOBS").ToString = "สำเนา" Then
                        strMANAGEFind = "ยกเลิกสำเนา"
                    ElseIf Dtr.Item("ACTOBS").ToString = "ต้นฉบับ" Then
                        strMANAGEFind = "ยกเลิกต้นฉบับ"
                    End If

                Case "C"
                    strMANAGEFind = "ขอสำเนาเพิ่ม"
                Case "R"
                    strMANAGEFind = "ขอสำเนาทดแทน"
                Case "U"
                    strMANAGEFind = "ขอนำเอกสารยกเลิกกลับมาใช้"
            End Select

            Dim strDOCTYPEFind As String = ""

            Select Case Dtr.Item("DOCTYPE").ToString()

                Case "MNL"
                    strDOCTYPEFind = "MANUAL"
                Case "PRC"
                    strDOCTYPEFind = "PROCEDURE"
                Case "WIN"
                    strDOCTYPEFind = "WORK INSTRUCTION"
                Case "STD"
                    strDOCTYPEFind = "STANDARD DOCUMENT"
                Case "RCF"
                    strDOCTYPEFind = "RECORD"
                Case "KMM"
                    strDOCTYPEFind = "KM"
                Case "OGN"
                    strDOCTYPEFind = "Organization Chart"
                Case "JOB"

                    strDOCTYPEFind = "Job Description"

            End Select


            '********** Select Path Server  *************

            Dim Sql9 As String = "SELECT *  "
            Sql9 = Sql9 + " FROM  QEm_PathServer "
            Sql9 = Sql9 + " WHERE  DOCTYPE = '" & Dtr.Item("DOCTYPE").ToString & "' AND DOCDEPT = '" & Dtr.Item("DOCDEPT").ToString & "' "
            Sql9 = Sql9 + " Order by DOCTYPE,DOCDEPT asc "

            Dim Dt9 As New DataTable

            Dt9 = DB_CMD.GetData_Table(Sql9, DB_CMD.ObjConn)
            For Each Dtr9 As DataRow In Dt9.Rows
                StrPathServer = StrPathServer & " , " & Dtr9.Item("DOCTYPEDESC").ToString
            Next

            '********************************************


            Select Case TxtStatus.Text

                Case "รอ ผู้จัดการฝ่ายอนุมัติ", "ผู้จัดการฝ่ายไม่อนุมัติ", "รอ Document Control จัดการ", "SD ไม่อนุมัติ", "รอ SD Section Head อนุมัติ", "SD Section Head ไม่อนุมัติ", "รอจัดทำเอกสาร", "รอ SD จัดทำเอกสาร"


                    With dgvDetail
                        ' intM = 1
                        'intW = 1

                        Application.DoEvents()
                        .Rows.Add()

                        .Item(0, .Rows.Count - 2).Value = intNo
                        .Item(1, .Rows.Count - 2).Value = Dtr.Item("REFNO").ToString
                        .Item(2, .Rows.Count - 2).Value = Dtr.Item("DOCNO").ToString
                        .Item(3, .Rows.Count - 2).Value = Dtr.Item("DOCNAME").ToString
                        .Item(4, .Rows.Count - 2).Value = Dtr.Item("REVNO").ToString
                        .Item(5, .Rows.Count - 2).Value = strMANAGEFind
                        .Item(6, .Rows.Count - 2).Value = Dtr.Item("REASON").ToString
                        .Item(7, .Rows.Count - 2).Value = Dtr.Item("EFFDATE").ToString
                        .Item(8, .Rows.Count - 2).Value = "-"

                        If IsDBNull(Dtr.Item("MGRREASON").ToString) Or Dtr.Item("MGRREASON").ToString = "" Then
                            .Item(9, .Rows.Count - 2).Value = "-"
                        Else
                            .Item(9, .Rows.Count - 2).Value = Dtr.Item("MGRREASON").ToString
                        End If


                        If strRefNoSendMailCheck <> Dtr.Item("REFNO").ToString Then

                            strRefNoSendMailCheck = Dtr.Item("REFNO").ToString
                            strRefNoSendMail = strRefNoSendMail & "," & Dtr.Item("REFNO").ToString

                        End If




                    End With


                Case "รอ SD รับ DAR"


                    With dgvDetail
                        ' intM = 1
                        'intW = 1

                        Application.DoEvents()
                        .Rows.Add()

                        .Item(0, .Rows.Count - 2).Value = intNo
                        .Item(1, .Rows.Count - 2).Value = Dtr.Item("REFNO").ToString
                        .Item(2, .Rows.Count - 2).Value = Dtr.Item("DOCNO").ToString
                        .Item(3, .Rows.Count - 2).Value = Dtr.Item("DOCNAME").ToString
                        .Item(4, .Rows.Count - 2).Value = Dtr.Item("REVNO").ToString
                        .Item(5, .Rows.Count - 2).Value = strMANAGEFind
                        .Item(6, .Rows.Count - 2).Value = Dtr.Item("REASON").ToString
                        .Item(7, .Rows.Count - 2).Value = Dtr.Item("EFFDATE").ToString
                        .Item(8, .Rows.Count - 2).Value = Dtr.Item("DARNO").ToString

                        If IsDBNull(Dtr.Item("MGRREASON").ToString) Or Dtr.Item("MGRREASON").ToString = "" Then
                            .Item(9, .Rows.Count - 2).Value = "-"
                        Else
                            .Item(9, .Rows.Count - 2).Value = Dtr.Item("MGRREASON").ToString
                        End If

                        If strRefNoSendMailCheck <> Dtr.Item("REFNO").ToString Then

                            strRefNoSendMailCheck = Dtr.Item("REFNO").ToString
                            strRefNoSendMail = strRefNoSendMail & "," & Dtr.Item("REFNO").ToString

                        End If

                    End With



                Case "รอ MR อนุมัติ", "MR ไม่อนุมัติ"

                    With dgvDetail
                        ' intM = 1
                        'intW = 1

                        Application.DoEvents()
                        .Rows.Add()

                        .Item(0, .Rows.Count - 2).Value = intNo
                        .Item(1, .Rows.Count - 2).Value = Dtr.Item("REFNO").ToString
                        .Item(2, .Rows.Count - 2).Value = Dtr.Item("DOCNO").ToString
                        .Item(3, .Rows.Count - 2).Value = Dtr.Item("DOCNAME").ToString
                        .Item(4, .Rows.Count - 2).Value = Dtr.Item("REVNO").ToString
                        .Item(5, .Rows.Count - 2).Value = strMANAGEFind
                        .Item(6, .Rows.Count - 2).Value = Dtr.Item("REASON").ToString
                        .Item(7, .Rows.Count - 2).Value = Dtr.Item("EFFDATE").ToString
                        .Item(8, .Rows.Count - 2).Value = Dtr.Item("DARNO").ToString

                        If IsDBNull(Dtr.Item("MGRREASON").ToString) Or Dtr.Item("MGRREASON").ToString = "" Then
                            .Item(9, .Rows.Count - 2).Value = "-"
                        Else
                            .Item(9, .Rows.Count - 2).Value = Dtr.Item("MGRREASON").ToString
                        End If

                        If strRefNoSendMailCheck <> Dtr.Item("REFNO").ToString Then

                            strRefNoSendMailCheck = Dtr.Item("REFNO").ToString
                            strRefNoSendMail = strRefNoSendMail & "," & Dtr.Item("REFNO").ToString
                        End If

                    End With

                Case "รอเอกสารลงนาม"

                    With dgvP2
                        ' intM = 1
                        'intW = 1

                        strDOCNOSendMail = ""

                        Dim Sql1 As String = "SELECT  REFNO, REFNODATA, LinkFilePDF "
                        Sql1 = Sql1 + " FROM  QEa_AttFile "
                        Sql1 = Sql1 + " WHERE  REFNO = '" & Dtr.Item("REFNO").ToString & "' AND REFNODATA = '" & Dtr.Item("REFNODATA").ToString & "' "
                        Sql1 = Sql1 + " Order by REFNO, REFNODATA, LinkFilePDF asc "

                        Dim Dt1 As New DataTable
                        Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)


                        Dim intNo1 As Integer = 1
                        Dim strLinkFilePDF As String = ""
                        For Each Dtr1 As DataRow In Dt1.Rows
                            If IsDBNull(Dtr1.Item("LinkFilePDF").ToString) Or Dtr1.Item("LinkFilePDF").ToString = "" Then
                                strLinkFilePDF = "-"
                            Else
                                strLinkFilePDF = Dtr1.Item("LinkFilePDF").ToString
                            End If


                        Next


                        Dim Sql2 As String = "SELECT *  "
                        Sql2 = Sql2 + " FROM  QEa_DocSys_ReceiveDoc "
                        Sql2 = Sql2 + " WHERE  REFNO = '" & Dtr.Item("REFNO").ToString & "' AND REFNODATA = '" & Dtr.Item("REFNODATA").ToString & "' "
                        Sql2 = Sql2 + " Order by REFNO, REFNODATA, RRSNO asc "

                        Dim strRRSNODATA As String = "-"
                        Dim Dt2 As New DataTable

                        Dt2 = DB_CMD.GetData_Table(Sql2, DB_CMD.ObjConn)
                        For Each Dtr2 As DataRow In Dt2.Rows
                            strRRSNODATA = Dtr2.Item("RRSNO").ToString
                        Next


                        Application.DoEvents()
                        .Rows.Add()

                        .Item(0, .Rows.Count - 2).Value = intNo
                        .Item(1, .Rows.Count - 2).Value = Dtr.Item("REFNO").ToString
                        .Item(2, .Rows.Count - 2).Value = Dtr.Item("DOCNO").ToString
                        .Item(3, .Rows.Count - 2).Value = Dtr.Item("DOCNAME").ToString
                        .Item(4, .Rows.Count - 2).Value = Dtr.Item("REVNO").ToString
                        .Item(5, .Rows.Count - 2).Value = strMANAGEFind
                        .Item(6, .Rows.Count - 2).Value = Dtr.Item("REASON").ToString
                        .Item(7, .Rows.Count - 2).Value = Dtr.Item("EFFDATE").ToString
                        .Item(8, .Rows.Count - 2).Value = strLinkFilePDF
                        '.Item(9, .Rows.Count - 2).Value = Dtr.Item("REFNODATA").ToString
                        .Item(9, .Rows.Count - 2).Value = strDOCTYPEFind
                        .Item(10, .Rows.Count - 2).Value = strRRSNODATA

                        strDOCNOSendMail = strDOCNOSendMail & "," & Dtr.Item("DOCNO").ToString

                        If strRefNoSendMailCheck <> Dtr.Item("REFNO").ToString Then

                            strRefNoSendMailCheck = Dtr.Item("REFNO").ToString
                            strRefNoSendMail = strRefNoSendMail & "," & Dtr.Item("REFNO").ToString

                        End If
                    End With
                ' <a href = "/uploads/media/Default/0001/01/540cb75550adf33f281f29132dddd14fded85bfc.pdf" >
                Case "รอประกาศใช้", "รอ SD Chief ทวนสอบ"

                    With dgvP2
                        ' intM = 1
                        'intW = 1

                        strDOCNOSendMail = ""


                        Dim Sql1 As String = "SELECT  REFNO, REFNODATA, AttFile3,Filename3 "
                        Sql1 = Sql1 + " FROM  QEa_AttFile "
                        Sql1 = Sql1 + " WHERE  REFNO = '" & Dtr.Item("REFNO").ToString & "' AND REFNODATA = '" & Dtr.Item("REFNODATA").ToString & "' "
                        Sql1 = Sql1 + " Order by REFNO, REFNODATA, LinkFilePDF asc "

                        Dim Dt1 As New DataTable
                        Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)

                        Dim intNo1 As Integer = 1
                        Dim intLength As Integer = 0
                        Dim intLength2 As Integer = 0
                        Dim intLength3 As Integer = 0
                        Dim strLinkFilePDF As String = ""
                        For Each Dtr1 As DataRow In Dt1.Rows
                            strLinkFilePDF = Dtr1.Item("AttFile3").ToString
                            intLength2 = Dtr1.Item("AttFile3").Length
                            intLength = Dtr1.Item("Filename3").Length
                            intLength3 = intLength2 - intLength

                            If IsDBNull(Dtr1.Item("AttFile3").ToString) Or Dtr1.Item("AttFile3").ToString = "" Then
                                strPathAttFile = "-"
                            Else
                                strPathAttFile = Mid(Dtr1.Item("AttFile3").ToString, 1, intLength3)
                            End If


                        Next


                        'Dim Sql2 As String = "SELECT *  "
                        'Sql2 = Sql2 + " FROM  QEa_DocSys_ReceiveDoc "
                        'Sql2 = Sql2 + " WHERE  REFNO = '" & Dtr.Item("REFNO").ToString & "' AND REFNODATA = '" & Dtr.Item("REFNODATA").ToString & "' "
                        'Sql2 = Sql2 + " Order by REFNO, REFNODATA, RRSNO asc "

                        Dim strRRSNODATA As String = "-"
                        'Dim Dt2 As New DataTable

                        'Dt2 = DB_CMD.GetData_Table(Sql2, DB_CMD.ObjConn)
                        'For Each Dtr2 As DataRow In Dt2.Rows
                        '    strRRSNODATA = Dtr2.Item("RRSNO").ToString
                        'Next


                        Dim command As New SqlCommand("SELECT  * FROM QEa_DocSys_ReceiveDoc " &
                                     " WHERE  REFNO = '" & Dtr.Item("REFNO").ToString & "'" &
                                     "AND REFNODATA = '" & Dtr.Item("REFNODATA").ToString & "'", DB_CMD.ObjConn)
                        Dim table As New DataTable
                        Dim adapter As New SqlDataAdapter(command)
                        Dim ds As New DataSet
                        adapter.Fill(table)

                        If table.Rows.Count > 0 Then
                            strRRSNODATA = table.Rows(0).Item("RRSNO").ToString
                        End If


                        Application.DoEvents()
                        .Rows.Add()

                        .Item(0, .Rows.Count - 2).Value = intNo
                        .Item(1, .Rows.Count - 2).Value = Dtr.Item("REFNO").ToString
                        .Item(2, .Rows.Count - 2).Value = Dtr.Item("DOCNO").ToString
                        .Item(3, .Rows.Count - 2).Value = Dtr.Item("DOCNAME").ToString
                        .Item(4, .Rows.Count - 2).Value = Dtr.Item("REVNO").ToString
                        .Item(5, .Rows.Count - 2).Value = strMANAGEFind
                        .Item(6, .Rows.Count - 2).Value = Dtr.Item("REASON").ToString
                        .Item(7, .Rows.Count - 2).Value = Dtr.Item("EFFDATE").ToString
                        .Item(8, .Rows.Count - 2).Value = strLinkFilePDF
                        '.Item(9, .Rows.Count - 2).Value = Dtr.Item("REFNODATA").ToString
                        .Item(9, .Rows.Count - 2).Value = strDOCTYPEFind
                        .Item(10, .Rows.Count - 2).Value = strRRSNODATA


                        With dgvData2
                            Application.DoEvents()
                            .Rows.Add()

                            .Item(0, .Rows.Count - 2).Value = intNo
                            .Item(1, .Rows.Count - 2).Value = Dtr.Item("DOCNO").ToString
                            .Item(2, .Rows.Count - 2).Value = Dtr.Item("DOCNAME").ToString
                            .Item(3, .Rows.Count - 2).Value = Dtr.Item("REVNO").ToString
                            .Item(4, .Rows.Count - 2).Value = strMANAGEFind
                            .Item(5, .Rows.Count - 2).Value = Dtr.Item("EFFDATE").ToString
                            .Item(6, .Rows.Count - 2).Value = strLinkFilePDF
                            .Item(7, .Rows.Count - 2).Value = strRRSNODATA
                            .Item(8, .Rows.Count - 2).Value = Dtr.Item("REFNODATA").ToString


                        End With


                        strDOCNOSendMail = strDOCNOSendMail & "," & Dtr.Item("DOCNO").ToString

                        If strRefNoSendMailCheck <> Dtr.Item("REFNO").ToString Then

                            strRefNoSendMailCheck = Dtr.Item("REFNO").ToString
                            strRefNoSendMail = strRefNoSendMail & "," & Dtr.Item("REFNO").ToString

                        End If

                        If strPathAttFileCheck <> strPathAttFile Then

                            strPathAttFileData = strPathAttFileData & "," & strPathAttFile
                            strPathAttFileCheck = strPathAttFile

                        End If


                        If strEFFDATEDATACheck <> Dtr.Item("EFFDATE").ToString Then

                            strEFFDATEDATACheck = Dtr.Item("EFFDATE").ToString
                            strEFFDATEDATA = strEFFDATEDATA & "," & Dtr.Item("EFFDATE").ToString

                        End If




                    End With

            End Select


            intNo = intNo + 1
            '
        Next
        strRefNoSendMailCheck = ""


        strRefNoSendMail = Mid(strRefNoSendMail.Trim(), 2, 99999)
        strPathAttFileData = Mid(strPathAttFileData.Trim(), 2, 99999)
        If strEFFDATEDATA <> "" Then
            strEFFDATEDATA = Mid(strEFFDATEDATA.Trim(), 2, 99999)
        End If
        ' strRefNoSendMail = strRefNoSendMail.Trim().Remove(strRefNoSendMail.Length - 1)


        bntTO.Enabled = True
        bntCC.Enabled = True
        bntSendEmailData.Enabled = True

        Me.dgvDetail.AllowUserToAddRows = False
        Me.dgvP2.AllowUserToAddRows = False
        Me.dgvData2.AllowUserToAddRows = False
    End Sub

    Private Sub FrmDocumentSystem_SendMail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Call ShowReFNOFM()
        ' Call ShowReFNOTO()



        TxtEmailFM1.Text = strEmailTo

        Call Grid()
        Call DeptDATASel()

    End Sub

    Sub DeptDATASel()

        Dim command As New SqlCommand("SELECT  DeptCod FROM  QEm_Dept  ORDER BY DeptCod  ", DB_CMD.ObjConn)
        Dim table As New DataTable
        Dim adapter As New SqlDataAdapter(command)
        Dim ds As New DataSet
        adapter.Fill(table)


        adapter.Fill(ds, "QEm_Dept")
        If table.Rows.Count > 0 Then
            TxtDOCDEPT.DisplayMember = "DeptCod"
            TxtDOCDEPT.ValueMember = "DeptCod"
            TxtDOCDEPT.DataSource = ds.Tables("QEm_Dept")
        End If


        Exit Sub
    End Sub



    Sub ShowReFNOFM()

        Dim strsql As String = ""

        If strDeptData = "SD" Then

            strsql = "Select REFNO FROM QEa_DocSysItem WHERE SELECTSYSTEM = '" & strSELECTSYSTEMEmail & "' GROUP BY REFNO ORDER BY REFNO DESC "
        ElseIf strDeptData = "HR" Or strDeptData = "GA" Or strDeptData = "HRGA" Then

            strsql = "Select REFNO FROM QEa_DocSysItem WHERE SELECTSYSTEM = '" & strSELECTSYSTEMEmail & "'  AND PETITIONDEPT = '" & strDeptData & "' GROUP BY REFNO ORDER BY REFNO DESC "
        Else

            strsql = "Select REFNO FROM QEa_DocSysItem WHERE SELECTSYSTEM = '" & strSELECTSYSTEMEmail & "'  AND (PETITIONDEPT = 'HR' OR PETITIONDEPT = 'GA') GROUP BY REFNO ORDER BY REFNO DESC "
        End If


        'Dim command As New SqlCommand("Select REFNO FROM QEa_DocSysItem GROUP BY REFNO ORDER BY REFNO DESC ", DB_CMD.ObjConn)
        Dim command As New SqlCommand(strsql, DB_CMD.ObjConn)
        Dim table As New DataTable
        Dim adapter As New SqlDataAdapter(command)
        Dim ds As New DataSet
        adapter.Fill(table)


        adapter.Fill(ds, "QEa_DocSysItem")
        If table.Rows.Count > 0 Then
            TxtRefNoFM.DisplayMember = "REFNO"
            TxtRefNoFM.ValueMember = "REFNO"
            TxtRefNoFM.DataSource = ds.Tables("QEa_DocSysItem")

        End If

        Exit Sub


    End Sub

    Sub ShowReFNOTO()

        Dim strsql As String = ""
        If strDeptData = "SD" Then

            strsql = "Select REFNO FROM QEa_DocSysItem WHERE SELECTSYSTEM = '" & strSELECTSYSTEMEmail & "' GROUP BY REFNO ORDER BY REFNO DESC "
        ElseIf strDeptData = "HR" Or strDeptData = "GA" Or strDeptData = "HRGA" Then

            strsql = "Select REFNO FROM QEa_DocSysItem WHERE SELECTSYSTEM = '" & strSELECTSYSTEMEmail & "'  AND PETITIONDEPT = '" & strDeptData & "' GROUP BY REFNO ORDER BY REFNO DESC "
        Else

            strsql = "Select REFNO FROM QEa_DocSysItem WHERE SELECTSYSTEM = '" & strSELECTSYSTEMEmail & "'  AND (PETITIONDEPT = 'HR' OR PETITIONDEPT = 'GA') GROUP BY REFNO ORDER BY REFNO DESC "
        End If


        'Dim command As New SqlCommand("Select REFNO FROM QEa_DocSysItem GROUP BY REFNO ORDER BY REFNO DESC ", DB_CMD.ObjConn)
        Dim command As New SqlCommand(strsql, DB_CMD.ObjConn)
        Dim table As New DataTable
        Dim adapter As New SqlDataAdapter(command)
        Dim ds As New DataSet
        adapter.Fill(table)


        adapter.Fill(ds, "QEa_DocSysItem")
        If table.Rows.Count > 0 Then
            TxtRefNoTO.DisplayMember = "REFNO"
            TxtRefNoTO.ValueMember = "REFNO"
            TxtRefNoTO.DataSource = ds.Tables("QEa_DocSysItem")

        End If

        Exit Sub



    End Sub

    Private Sub TxtStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtStatus.SelectedIndexChanged


        Select Case TxtStatus.Text

            Case "รอ SD รับ DAR"
                dgvP2.Visible = False
                dgvDetail.Visible = True
                dgvData2.Visible = False
            Case "รอ MR อนุมัติ", "MR ไม่อนุมัติ"
                dgvP2.Visible = False
                dgvDetail.Visible = True
                dgvData2.Visible = False
            Case "รอเอกสารลงนาม"
                dgvP2.Visible = True
                dgvDetail.Visible = False
                dgvData2.Visible = False
            Case "รอประกาศใช้", "รอ SD Chief ทวนสอบ"
                dgvP2.Visible = False
                dgvDetail.Visible = False
                dgvData2.Visible = True

            Case "รอ ผู้จัดการฝ่ายอนุมัติ", "ผู้จัดการฝ่ายไม่อนุมัติ", "รอ Document Control จัดการ", "SD ไม่อนุมัติ", "รอ SD Section Head อนุมัติ", "SD Section Head ไม่อนุมัติ", "รอจัดทำเอกสาร", "รอ SD จัดทำเอกสาร"
                dgvP2.Visible = False
                dgvDetail.Visible = True
                dgvData2.Visible = False

        End Select

        Call ClearEmail()

        If strDeptData = "GA" Or strDeptData = "SD" Or strDeptData = "HRGA" Then
            TxtDOCDEPT.Enabled = True
        Else
            TxtDOCDEPT.Enabled = False
            TxtDOCDEPT.Text = strDeptData

        End If
    End Sub



    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub
    Private Sub GetHostName()
        Try

            strHostName = System.Net.Dns.GetHostName()

            'strBranch = Mid(strHostName, 1, 1)
            ''strBranch = "N"
            ''= strDept


        Catch ex As Exception
            MsgBox("เกิดข้อผิดพลาดแก้ไขข้อมูล GetHostName  ", MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub ToolStrip3_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip3.ItemClicked

    End Sub

    Private Sub bntSendEmailData_Click(sender As Object, e As EventArgs) Handles bntSendEmailData.Click
        Call GetHostName()

        If TxtEmailFM1.Text = "" Then
            MsgBox("เลือก Email ด้วย")
            TxtEmailFM1.Focus()
            Exit Sub
        End If

        If txtToEmail1.Text = "" Then
            MsgBox("เลือก Email ด้วย")
            txtToEmail1.Focus()
            Exit Sub
        End If

        'If TxtEmailCC1.Text = "" Then
        '    MsgBox("เลือก Email ด้วย")
        '    TxtEmailCC1.Focus()
        '    Exit Sub
        'End If

        Select Case TxtStatus.Text

            Case "รอ ผู้จัดการฝ่ายอนุมัติ", "ผู้จัดการฝ่ายไม่อนุมัติ", "รอ Document Control จัดการ", "SD ไม่อนุมัติ", "รอ SD Section Head อนุมัติ", "SD Section Head ไม่อนุมัติ", "รอจัดทำเอกสาร"

                Call SendEmail_P5()
            Case "รอ SD รับ DAR"
                Call SendEmail_P4()
            Case "รอ MR อนุมัติ", "MR ไม่อนุมัติ"
                Call SendEmail_P1()
            Case "รอเอกสารลงนาม"
                Call SendEmail_P2()
            Case "รอประกาศใช้", "รอ SD Chief ทวนสอบ"
                Call SendEmail_P3()
        End Select


        Call UpdateStatusEmail()


        Call ClearEmail()


    End Sub

    Private Sub txtSELECTSYSTEM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtSELECTSYSTEM.SelectedIndexChanged

        dgvDetail.Rows.Clear()
        dgvP2.Rows.Clear()
        dgvData2.Rows.Clear()

        Select Case txtSELECTSYSTEM.Text

            Case "Document System"

                strSELECTSYSTEMEmail = "DS"

            Case "Department"

                strSELECTSYSTEMEmail = "DP"

            Case "KM"

                strSELECTSYSTEMEmail = "KM"

        End Select




        Call ShowReFNOFM()
        Call ShowReFNOTO()




        TxtRefNoFM.Text = ""
        TxtRefNoTO.Text = ""
        TxtStatus.Text = ""
        ' TxtStatus.DataSource = Nothing
        TxtStatus.Items.Clear()

        Select Case txtSELECTSYSTEM.Text
            Case "Document System"


                If strDeptData = "SD" Then

                    TxtDOCDEPT.Enabled = True
                    TxtStatus.Items.Add("")
                    TxtStatus.Items.Add("รอ ผู้จัดการฝ่ายอนุมัติ")
                    TxtStatus.Items.Add("ผู้จัดการฝ่ายไม่อนุมัติ")
                    TxtStatus.Items.Add("รอ SD รับ DAR")
                    TxtStatus.Items.Add("รอ Document Control จัดการ")
                    TxtStatus.Items.Add("รอ SD จัดทำเอกสาร")
                    TxtStatus.Items.Add("SD ไม่อนุมัติ")
                    TxtStatus.Items.Add("รอ SD Section Head อนุมัติ")
                    TxtStatus.Items.Add("SD Section Head ไม่อนุมัติ")
                    TxtStatus.Items.Add("รอ MR อนุมัติ")
                    TxtStatus.Items.Add("MR ไม่อนุมัติ")
                    TxtStatus.Items.Add("รอจัดทำเอกสาร")
                    TxtStatus.Items.Add("รอเอกสารลงนาม")
                    TxtStatus.Items.Add("รอประกาศใช้")
                    TxtStatus.Items.Add("รอ SD Chief ทวนสอบ")


                ElseIf strDeptData = "GA" Or strDeptData = "HR" Or strDeptData = "HRGA" Then
                    TxtStatus.Items.Add("")
                    TxtStatus.Items.Add("รอ ผู้จัดการฝ่ายอนุมัติ")
                    TxtStatus.Items.Add("ผู้จัดการฝ่ายไม่อนุมัติ")
                    TxtStatus.Items.Add("รอจัดทำเอกสาร")
                    TxtStatus.Items.Add("รอ SD รับ DAR")
                Else

                    TxtDOCDEPT.Enabled = False
                    TxtDOCDEPT.Text = strDeptData

                    TxtStatus.Items.Add("")
                    TxtStatus.Items.Add("รอ ผู้จัดการฝ่ายอนุมัติ")
                    TxtStatus.Items.Add("ผู้จัดการฝ่ายไม่อนุมัติ")
                    TxtStatus.Items.Add("รอ SD รับ DAR")

                End If


            Case "Department"


                If strDeptData = "SD" Then
                    TxtDOCDEPT.Enabled = True
                    TxtStatus.Items.Add("")
                    TxtStatus.Items.Add("รอ ผู้จัดการฝ่ายอนุมัติ")
                    TxtStatus.Items.Add("ผู้จัดการฝ่ายไม่อนุมัติ")
                    TxtStatus.Items.Add("รอ SD รับ DAR")
                    TxtStatus.Items.Add("รอ Document Control จัดการ")
                    TxtStatus.Items.Add("รอ SD จัดทำเอกสาร")
                    TxtStatus.Items.Add("SD ไม่อนุมัติ")
                    TxtStatus.Items.Add("รอ SD Section Head อนุมัติ")
                    TxtStatus.Items.Add("SD Section Head ไม่อนุมัติ")
                    TxtStatus.Items.Add("รอ MR อนุมัติ")
                    TxtStatus.Items.Add("MR ไม่อนุมัติ")
                    TxtStatus.Items.Add("รอจัดทำเอกสาร")
                    TxtStatus.Items.Add("รอเอกสารลงนาม")
                    TxtStatus.Items.Add("รอประกาศใช้")
                    TxtStatus.Items.Add("รอ SD Chief ทวนสอบ")


                ElseIf strDeptData = "GA" Or strDeptData = "HR" Or strDeptData = "HRGA" Then
                    TxtStatus.Items.Add("")
                    TxtStatus.Items.Add("รอ ผู้จัดการฝ่ายอนุมัติ")
                    TxtStatus.Items.Add("ผู้จัดการฝ่ายไม่อนุมัติ")
                    TxtStatus.Items.Add("รอ Document Control จัดการ")
                    TxtStatus.Items.Add("รอเอกสารลงนาม")
                    TxtStatus.Items.Add("รอประกาศใช้")
                Else

                    TxtDOCDEPT.Enabled = False
                    TxtDOCDEPT.Text = strDeptData

                    TxtStatus.Items.Add("")
                    TxtStatus.Items.Add("รอ ผู้จัดการฝ่ายอนุมัติ")
                    TxtStatus.Items.Add("ผู้จัดการฝ่ายไม่อนุมัติ")
                    TxtStatus.Items.Add("รอ Document Control จัดการ")
                    TxtStatus.Items.Add("รอเอกสารลงนาม")
                    TxtStatus.Items.Add("รอประกาศใช้")

                End If

            Case "KM"

                If strDeptData = "SD" Then

                    TxtDOCDEPT.Enabled = True
                    TxtStatus.Items.Add("")
                    TxtStatus.Items.Add("รอ ผู้จัดการฝ่ายอนุมัติ")
                    TxtStatus.Items.Add("ผู้จัดการฝ่ายไม่อนุมัติ")
                    TxtStatus.Items.Add("รอ SD รับ DAR")
                    TxtStatus.Items.Add("รอ Document Control จัดการ")
                    TxtStatus.Items.Add("รอ SD จัดทำเอกสาร")
                    TxtStatus.Items.Add("SD ไม่อนุมัติ")
                    TxtStatus.Items.Add("รอ SD Section Head อนุมัติ")
                    TxtStatus.Items.Add("SD Section Head ไม่อนุมัติ")
                    TxtStatus.Items.Add("รอ MR อนุมัติ")
                    TxtStatus.Items.Add("MR ไม่อนุมัติ")
                    TxtStatus.Items.Add("รอจัดทำเอกสาร")
                    TxtStatus.Items.Add("รอเอกสารลงนาม")
                    TxtStatus.Items.Add("รอประกาศใช้")
                    TxtStatus.Items.Add("รอ SD Chief ทวนสอบ")

                ElseIf strDeptData = "GA" Or strDeptData = "HR" Or strDeptData = "HRGA" Then

                    TxtStatus.Items.Add("")
                    TxtStatus.Items.Add("รอ ผู้จัดการฝ่ายอนุมัติ")
                    TxtStatus.Items.Add("ผู้จัดการฝ่ายไม่อนุมัติ")
                    TxtStatus.Items.Add("รอ SD รับ DAR")

                Else

                    TxtDOCDEPT.Enabled = False
                    TxtDOCDEPT.Text = strDeptData

                    TxtStatus.Items.Add("")
                    TxtStatus.Items.Add("รอ ผู้จัดการฝ่ายอนุมัติ")
                    TxtStatus.Items.Add("ผู้จัดการฝ่ายไม่อนุมัติ")
                    TxtStatus.Items.Add("รอ SD รับ DAR")

                End If

        End Select


        Call ClearEmail()







        Call Grid()

    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Call SelectFile()
        For Each row As DataGridViewRow In grdAttFile.Rows

            If Me.TxtFilename.Text = CStr(row.Cells("Filename").Value) Then

                MsgBox("ไฟล์นี้มีในระบบเเล้ว กรูณาเปลี่ยนชื่อไฟล์ใหม่ หรือเปลี่ยนไฟล์แนบใหม่")
                Exit Sub

            End If

        Next

        grdAttFile.Rows.Add(1)
        grdAttFile.Rows(grdAttFile.Rows.Count - 1).Cells("RequestAttFile").Value = TxtSourceFile.Text
        grdAttFile.Rows(grdAttFile.Rows.Count - 1).Cells("Filename").Value = TxtFilename.Text
    End Sub

    Private Sub SelectFile()
        Dim Dl As New OpenFileDialog
        If Dl.ShowDialog = DialogResult.OK Then
            Exts = IO.Path.GetExtension(Dl.FileName)
            Me.TxtFilename.Text = Dl.SafeFileName
            Me.TxtSourceFile.Text = Dl.FileName
            ' Me.TxtDescription.Focus()
        Else
            Exts = Nothing
        End If
    End Sub
    Private Function ReadWordDoc(ByVal filename As String) As Byte()
        Dim fs As New System.IO.FileStream(filename, IO.FileMode.Open)
        Dim br As New System.IO.BinaryReader(fs)
        Dim data() As Byte = br.ReadBytes(CInt(fs.Length))
        br.Close()
        fs.Close()
        Return data
    End Function


    Sub ClearEmail()
        TxtInputEmail.Text = ""
        txtToEmail1.Text = ""
        TxtEmailCC1.Text = ""
        'TxtStatus.Text = ""
        TxtDOCDEPT.Text = ""
        TxtRefNoFM.Text = ""
        TxtRefNoTO.Text = ""

        bntTO.Enabled = False
        bntCC.Enabled = False
        bntSendEmailData.Enabled = False


        dgvData2.Rows.Clear()
        dgvDetail.Rows.Clear()
        dgvP2.Rows.Clear()
        grdAttFile.Rows.Clear()

    End Sub

    Sub UpdateStatusDAR()


        Try



            'If TxtRptBy.Checked = True Then
            '    strStatus = "รอ อนุมัติการออก CAR"
            'End If

            'If TxtAppMrApproveY.Checked = True Then
            '    strStatus = "รอ ตอบกลับ CAR"
            'End If

            'If TxtAppMrApproveN.Checked = True Then

            '    strStatus = "ไม่อนุมัติให้ออก CAR"

            'End If

            'If TxtAppMgr.Checked = True Then
            '    strStatus = "รอ พิจารณาผลตอบกลับ CAR"
            'End If


            'If TxtLinkFilePDF.Text = "" Then

            '    strStatus = "รอเอกสารลงนาม"

            'End If


            'If TxtQEoff8.Checked = True Then

            '    strStatus = "รอ QE Chief ทวนสอบ"

            'End If


            'If TxtQE8.Checked = True Then

            '    strStatus = "Close DAR"

            'End If







        Catch ex As Exception

        End Try


    End Sub

    Private Sub TxtDOCDEPT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtDOCDEPT.SelectedIndexChanged
        dgvDetail.Rows.Clear()
        dgvP2.Rows.Clear()
    End Sub

    Private Sub TxtRefNoFM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtRefNoFM.SelectedIndexChanged
        dgvDetail.Rows.Clear()
        dgvP2.Rows.Clear()
    End Sub

    Private Sub TxtRefNoTO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtRefNoTO.SelectedIndexChanged
        dgvDetail.Rows.Clear()
        dgvP2.Rows.Clear()
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

        If TxtEmailFM1.Text = "" Then
            MsgBox("เลือก Email ด้วย")
            TxtEmailFM1.Focus()
            Exit Sub
        End If

        If txtToEmail1.Text = "" Then
            MsgBox("เลือก Email ด้วย")
            txtToEmail1.Focus()
            Exit Sub
        End If

        'If TxtEmailCC1.Text = "" Then
        '    MsgBox("เลือก Email ด้วย")
        '    TxtEmailCC1.Focus()
        '    Exit Sub
        'End If

        Select Case TxtStatus.Text

            Case "รอ MR อนุมัติ"
                Call SendEmail_P1()
            Case "รอเอกสารลงนาม"
                Call SendEmail_P2()
            Case "รอประกาศใช้"
                Call SendEmail_P3()

        End Select

        Call UpdateStatusEmail()

    End Sub

    Sub UpdateStatusEmail()
        Dim strStatus As String = ""

        Try


            If TxtStatus.Text = "รอเอกสารลงนาม" Then
                strStatus = "ส่ง Email เเจ้งให้ลงนามเอกสารแแล้ว"
            End If

            For Each row As DataGridViewRow In Me.dgvP2.Rows

                Dim myCommand As New SqlCommand("Update QEa_DocSysItem Set Status = @Status " &
                                               "WHERE REFNO = '" & (row.Cells("REFFNO2").Value.ToString) & "' " &
                                               "And REFNODATA ='" & (row.Cells("REFNODATA2").Value.ToString) & "' ", DB_CMD.ObjConn)

                myCommand.Parameters.Add("@Status", SqlDbType.VarChar).Value = strStatus
                ' myCommand.Parameters.Add("@DateVerify", SqlDbType.VarChar).Value = TxtDateVerify.Text

                Dim rowsAffected As Integer = myCommand.ExecuteNonQuery


            Next



        Catch ex As Exception

        End Try


    End Sub


    Sub SendEmail_P1()



        Dim strStatusRepair As String = ""
        Dim strSubjectEmail As String = ""

        'If CommandTypeData = "Addnew" Then
        '    strStatusRepair = "เปิดใบเเจ้งซ่อม"
        '    strSubjectEmail = TxtOther.Text & "( ใบเเจ้งซ่อมระบบคอมพิวเตอร์ เลขที่ : " & TxtJobNo.Text & ") "
        'Else
        '    strStatusRepair = "รอดำเนินการ"
        '    strSubjectEmail = "กำหนดผู้รับผิดชอบงาน โดยฝ่าย iT เลขที่ใบเเจ้งซ่อม : " & TxtJobNo.Text & ""
        'End If

        Dim smtp As New SmtpClient("10.1.1.5")
        Dim mail As New MailMessage()
        'Call GetHostName()

        strStepSendEmail = "ส่งอนุมัติออก CAR ให้ SD Manager "

        mail.From = New MailAddress(TxtEmailFM1.Text)


        mail.To.Add(txtToEmail1.Text)
        If TxtEmailCC1.Text <> "" Then
            mail.CC.Add(TxtEmailCC1.Text)
        End If
        mail.IsBodyHtml = True


        strRefNoSendMail = ""
        strRefNoSendMailCheck = ""
        strDOCNOSendMail = ""
        strDOCNOSendMailCheck = ""
        For Each row As DataGridViewRow In dgvDetail.Rows

            If strRefNoSendMailCheck <> CStr(row.Cells("REFNO").Value) Then

                strRefNoSendMailCheck = CStr(row.Cells("REFNO").Value)
                strRefNoSendMail = strRefNoSendMail & "," & CStr(row.Cells("REFNO").Value)
            End If


            If strDOCNOSendMailCheck <> CStr(row.Cells("DOCNO").Value) Then
                strDOCNOSendMailCheck = CStr(row.Cells("DOCNO").Value)
                strDOCNOSendMail = strDOCNOSendMail & "," & CStr(row.Cells("DOCNO").Value)
            End If


        Next

        strRefNoSendMail = Mid(strRefNoSendMail, 2, 9999)

        strDOCNOSendMail = Mid(strDOCNOSendMail, 2, 9999)

        For rowNum As Integer = 0 To dgvDetail.Rows.Count - 1
            ' dgvData2(0, rowNum) = rowNum + 1
            dgvDetail.Rows(rowNum).Cells(0).Value = (rowNum + 1).ToString

        Next




        If TxtStatus.Text = "รอ MR อนุมัติ" Then
            mail.Subject = "แจ้ง MR พิจารณาใบคำขอจัดการเอกสาร  : (  " & strRefNoSendMail & "  ) "
        ElseIf TxtStatus.Text = "MR ไม่อนุมัติ" Then
            mail.Subject = "MR ไม่อนุมัติ เอกสารเลขที่  :  (  " & strDOCNOSendMail & "  ) "
        End If

        '************************************************************************
        If TxtStatus.Text = "รอ MR อนุมัติ" Then
            Select Case strBranchConn
                Case "TP"
                    mail.Body = mail.Body + "<tr><td><b><font-size: 5pt color=BLACK> เรียน  MR </b></b></Font><br/><br/></td></tr>"
                    mail.Body = mail.Body + "<table><tr><td><h4><font color=Blue>       โปรดพิจารณา คำขอการจัดการเอกสารใน Document System Program เลขที่อ้างอิง  :  " & strRefNoSendMail & " : ดังรายละเอียดตามตารางด้านล่าง  </font></h2><br/><br/></td></tr></table>"

                Case "KB"
                    mail.Body = mail.Body + "<tr><td><b><font-size: 5pt color=BLACK> เรียน  MR </b></b></Font><br/><br/></td></tr>"
                    mail.Body = mail.Body + "<table><tr><td><h4><font color=Blue>       โปรดพิจารณา คำขอการจัดการเอกสารใน Document System Program เลขที่อ้างอิง  :  " & strRefNoSendMail & " : ดังรายละเอียดตามตารางด้านล่าง  </font></h2><br/><br/></td></tr></table>"

            End Select
        ElseIf TxtStatus.Text = "MR ไม่อนุมัติ" Then

            mail.Body = mail.Body + "<tr><td><b><font-size: 5pt color=BLACK> เรียน ฝ่ายงานที่เกี่ยวข้อง </b></b></Font><br/><br/></td></tr>"
            mail.Body = mail.Body + "<table><tr><td><h4><font color=Blue>  โปรดทบทวนเอกสารเลขที่   :  " & strDOCNOSendMail & " : เนื่องจาก MR ไม่อนุมัติ ดังรายละเอียดตามตารางด้านล่าง  </font></h2><br/><br/></td></tr></table>"



        End If

        mail.Body = mail.Body + "<tr><td><b><font-size: 6pt><font color=BLUE>หมายเหตุ : " & TxtInputEmail.Text & "</b></b></Font></Font><br/><br/><br/></td></tr>"


        'Table start.
        Dim html As String = "<table cellpadding='5' cellspacing='0' style='border: 1px solid #ccc;font-size: 9pt'>"

        'Adding HeaderRow.
        html &= "<tr>"

        For Each column As DataGridViewColumn In dgvDetail.Columns
            html &= "<th style='background-color: #BEE9F0;border: 1px solid #ccc'>" & column.HeaderText & "</th>"
        Next
        html &= "</tr>"

        'Adding DataRow.
        For Each row As DataGridViewRow In dgvDetail.Rows
            html &= "<tr>"

            Dim intno As Integer = 0
            For Each cell As DataGridViewCell In row.Cells
                ' If intNoColumn <> 1 And intNoColumn <> 6 And intNoColumn <> 9 Then

                Select Case intno
                    Case 0
                        html &= "<td style='width:30px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                    Case 1
                        html &= "<td style='width:100px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                    Case 2
                        html &= "<td style='width:100px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                    Case 3
                        html &= "<td style='width:400px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                    Case 4
                        html &= "<td style='width:50px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                    Case 5
                        html &= "<td style='width:90px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                    Case 6
                        html &= "<td style='width:400px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                    Case 7
                        html &= "<td style='width:100px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                    Case 8
                        html &= "<td style='width:70px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                    Case 9
                        html &= "<td style='width:150px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                End Select

                intno = intno + 1

                'End If

                'intNoColumn = intNoColumn + 1
            Next

            html &= "</tr>"
        Next



        'Table end.
        html &= "</table>"


        mail.Body = mail.Body + html

        mail.Body = mail.Body + "รายงานโดย : " & StrUserName & "<br/>"
        mail.Body = mail.Body + "ฝ่ายงาน / หน่วยงาน : " & strDeptData & "<br/>"
        mail.Body = mail.Body + "Sent from computer name : " & strHostName & "<br/>"
        mail.Body = mail.Body + "This email is auto-generated."

        mail.SubjectEncoding = System.Text.Encoding.GetEncoding(65001)
        mail.BodyEncoding = System.Text.Encoding.GetEncoding(65001)

        '  mail.Attachments.Add(New Attachment("D:\DaTA\Config -.xlsx"))


        For Each row As DataGridViewRow In grdAttFile.Rows

            mail.Attachments.Add(New Attachment(CStr(row.Cells("RequestAttFile").Value)))

        Next

        Try

            smtp.Send(mail)
            Application.DoEvents()

            MsgBox("Send Mail Complete  ", CType(MsgBoxStyle.Information + MsgBoxStyle.OkOnly, MsgBoxStyle))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            smtp.Dispose()
        End Try



    End Sub

    Sub SendEmail_P2()

        Dim strStatusRepair As String = ""
        Dim strSubjectEmail As String = ""

        'If CommandTypeData = "Addnew" Then
        '    strStatusRepair = "เปิดใบเเจ้งซ่อม"
        '    strSubjectEmail = TxtOther.Text & "( ใบเเจ้งซ่อมระบบคอมพิวเตอร์ เลขที่ : " & TxtJobNo.Text & ") "
        'Else
        '    strStatusRepair = "รอดำเนินการ"
        '    strSubjectEmail = "กำหนดผู้รับผิดชอบงาน โดยฝ่าย iT เลขที่ใบเเจ้งซ่อม : " & TxtJobNo.Text & ""
        'End If

        Dim smtp As New SmtpClient("10.1.1.5")
        Dim mail As New MailMessage()
        'Call GetHostName()

        strStepSendEmail = "ส่งอนุมัติออก CAR ให้ SD Manager "

        mail.From = New MailAddress(TxtEmailFM1.Text)


        '  StrUserEmail = ""
        'Dim Sql As String = "Select * from ITm_User where UserNam ='" & TxtServPersn.Text & "' "
        'Dim Dt As New DataTable
        'Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
        'Dim strBranchID As String = ""
        'For Each Dtr As DataRow In Dt.Rows

        '    StrUserEmail = Dtr.Item("UserEmail").ToString

        'Next





        'If TxtBranch.Text = "TP" Then

        '    mail.To.Add("isdiv@sunif.co.th")
        'Else
        '    mail.To.Add("itkb@sunif.co.th")
        'End If

        'If txtToEmail1.Text <> "" Then
        '    StrUserEmail = txtToEmail1.Text & StrUserEmail
        'Else
        '    StrUserEmail = StrUserEmail
        'End If
        strDOCNOSendMail = ""
        strDOCNOSendMailCheck = ""
        For Each row As DataGridViewRow In dgvP2.Rows
            If strDOCNOSendMailCheck <> CStr(row.Cells("DataGridViewTextBoxColumn3").Value) Then
                strDOCNOSendMailCheck = CStr(row.Cells("DataGridViewTextBoxColumn3").Value)
                strDOCNOSendMail = strDOCNOSendMail & "," & CStr(row.Cells("DataGridViewTextBoxColumn3").Value)

            End If
        Next



        For rowNum As Integer = 0 To dgvP2.Rows.Count - 1
            ' dgvData2(0, rowNum) = rowNum + 1
            dgvP2.Rows(rowNum).Cells(0).Value = (rowNum + 1).ToString

        Next




        mail.To.Add(txtToEmail1.Text)

        If TxtEmailCC1.Text <> "" Then
            mail.CC.Add(TxtEmailCC1.Text)
        End If
        mail.IsBodyHtml = True

        strDOCNOSendMail = Mid(strDOCNOSendMail, 2, 5000)

        mail.Subject = "แจ้งผู้จัดการฝ่ายและผู้จัดทำ ลงนามเอกสารต้นฉบับ เลขที่ (  " & strDOCNOSendMail & "  ) "

        '************************************************************************
        '' mail.Body = "<center><table><tr><td><h2><font color=Blue>Email  แจ้งให้ลงนามเอกสารต้นฉบับ</font></h2><br/><br/></td></tr></table></center>"


        'Table start.
        ' Dim html As String = "<table cellpadding='5' cellspacing='0' style='border: 1px solid #ccc;font-size: 9pt'>"

        'Adding HeaderRow.

        'html &= "เรียนผู้ที่เกี่ยวข้องฝ่าย"
        Dim strxx As String = "      "

        '  mail.Body = mail.Body + "<tr><td><b><font-size: 7pt color=RED> &nbsp;  &nbsp; &nbsp;&nbsp; เลขที่อ้างอิง : " & strRefNoSendMail & " : ซึ่งมีรายละเอียด ตามตารางด้านล่าง </b></b></Font></Font><br/></td></tr>"
        '  mail.Body = mail.Body + "<tr><td><b><font-size: 7pt color=BLUE> &nbsp;  &nbsp; &nbsp;&nbsp; ขอให้ผู้ที่เกี่ยวข้องเข้าไปลงนามเอกสารให้ครบ ภายใน 2 วันหลังจากที่ได้รับ Mail นี้ด้วยนะคะ</b></b></Font></Font><br/><br/><br/></td></tr>"
        Select Case strBranchConn
            Case "TP"

                mail.Body = mail.Body + "<tr><td><b><font-size: 7pt color=BLACK> เรียน  ผู้จัดทำเอกสาร / ผู้จัดการฝ่าย </b></b></Font><br/><br/></td></tr>"
                mail.Body = mail.Body + "<tr><td><b><font-size: 7pt color=BLACK> &nbsp;  &nbsp; &nbsp;&nbsp; โปรดลงนาม(Digital sign)ในเอกสารต้นฉบับ เลขที่ : " & strDOCNOSendMail & " : ที่ยื่นคำขอจัดการผ่าน Document System Program </b></b></Font></Font><br/></td></tr>"
                mail.Body = mail.Body + "<tr><td><b><font-size: 9pt><font color=RED> &nbsp;  &nbsp; &nbsp;&nbsp;  ซึ่งไฟล์เอกสารถูกวางไว้ที่ Server I:\01-Document Control\00. Document File Original for sign\ </b></b></Font></Font><br/></td></tr>"
                mail.Body = mail.Body + "<tr><td><b><font-size: 9pt><font color=BLUE> &nbsp;  &nbsp; &nbsp;&nbsp; ขอให้ Dc ฝ่ายติดตามการลงนาม ทั้งในเอกสาร และ Program ให้แล้วเสร็จภายใน 3 วัน นับจากวันที่ได้รับแจ้งนี้ ดังรายละเอียดตามตารางด้านล่าง </b></b></Font></Font><br/><br/><br/></td></tr>"

            Case "KB"


                mail.Body = mail.Body + "<tr><td><b><font-size: 7pt color=BLACK> เรียน  ผู้จัดทำเอกสาร / ผู้จัดการฝ่าย </b></b></Font><br/><br/></td></tr>"
                mail.Body = mail.Body + "<tr><td><b><font-size: 7pt color=BLACK> &nbsp;  &nbsp; &nbsp;&nbsp; โปรดลงนาม(Digital sign)ในเอกสารต้นฉบับ เลขที่ : " & strDOCNOSendMail & " : ที่ยื่นคำขอจัดการผ่าน Document System Program </b></b></Font></Font><br/></td></tr>"
                mail.Body = mail.Body + "<tr><td><b><font-size: 9pt><font color=RED> &nbsp;  &nbsp; &nbsp;&nbsp;  ซึ่งไฟล์เอกสารถูกวางไว้ที่ Server K:\ISO14001\Document control\00. Document File Original for sign\ </b></b></Font></Font><br/></td></tr>"
                mail.Body = mail.Body + "<tr><td><b><font-size: 9pt><font color=BLUE> &nbsp;  &nbsp; &nbsp;&nbsp; ขอให้ Dc ฝ่ายติดตามการลงนาม ทั้งในเอกสาร และ Program ให้แล้วเสร็จภายใน 3 วัน นับจากวันที่ได้รับแจ้งนี้ ดังรายละเอียดตามตารางด้านล่าง </b></b></Font></Font><br/><br/><br/></td></tr>"


        End Select


        mail.Body = mail.Body + "<tr><td><b><font-size: 7 pt><font color=BLUE>หมายเหตุ : " & TxtInputEmail.Text & "</b></b></Font></Font><br/><br/><br/></td></tr>"

        'Table start.
        Dim html As String = "<table cellpadding='5' cellspacing='0' style='border: 1px solid #ccc;font-size: 9pt'>"
        '<br/><br/>
        'Adding HeaderRow.
        html &= "<tr>"

        For Each column As DataGridViewColumn In dgvP2.Columns
            html &= "<th style='background-color: #E7EFBA;border: 1px solid #ccc'>" & column.HeaderText & "</th>"
        Next
        html &= "</tr>"

        'Adding DataRow.
        For Each row As DataGridViewRow In dgvP2.Rows
            html &= "<tr>"

            Dim intno As Integer = 0
            For Each cell As DataGridViewCell In row.Cells
                ' If intNoColumn <> 1 And intNoColumn <> 6 And intNoColumn <> 9 Then

                Select Case intno
                    Case 0
                        html &= "<td style='width:30px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                    Case 1
                        html &= "<td style='width:100px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                    Case 2
                        html &= "<td style='width:100px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                    Case 3
                        html &= "<td style='width:400px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                    Case 4
                        html &= "<td style='width:50px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                    Case 5
                        html &= "<td style='width:90px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                    Case 6
                        html &= "<td style='width:400px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                    Case 7
                        html &= "<td style='width:100px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                    Case 8
                        html &= "<td style='width:250px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                    Case 9
                        html &= "<td style='width:120px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                    Case 10
                        html &= "<td style='width:100px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                End Select

                intno = intno + 1

                'End If

                'intNoColumn = intNoColumn + 1
            Next

            html &= "</tr>"

        Next
        'Table end.
        html &= "</table>"

        mail.Body = mail.Body + html

        mail.Body = mail.Body + "<br/><br/>"
        ' mail.Body = mail.Body + "<tr><td><b><font-size: 9pt><font color=RED><br/><br/> &nbsp;  &nbsp; &nbsp;&nbsp; ** โปรดดำเนินการให้แล้วเสร็จ ก่อนวันบังคับใช้ 2 วัน  นะคะ </b></b></Font></Font><br/></td></tr>"
        ' mail.Body = mail.Body + "<tr><td><b><font-size: 9pt><font color=BLUE><br/><br/> &nbsp;  &nbsp; &nbsp;&nbsp; ** เมื่อลงนามเอกสารเสร็จเเล้วให้เข้าโปรแกรม Document System เพื่อเข้าไป Approve ในระบบด้วยค่ะ *** </b></b></Font></Font><br/><br/><br/></td></tr>"
        mail.Body = mail.Body + "รายงานโดย : " & StrUserName & "<br/>"
        mail.Body = mail.Body + "ฝ่ายงาน / หน่วยงาน : " & strDeptData & "<br/>"
        mail.Body = mail.Body + "Sent from computer name : " & strHostName & "<br/><br/>"
        mail.Body = mail.Body + "This email is auto-generated."

        mail.SubjectEncoding = System.Text.Encoding.GetEncoding(65001)
        mail.BodyEncoding = System.Text.Encoding.GetEncoding(65001)

        '  mail.Attachments.Add(New Attachment("D:\DaTA\Config -.xlsx"))

        For Each row As DataGridViewRow In grdAttFile.Rows

            mail.Attachments.Add(New Attachment(CStr(row.Cells("RequestAttFile").Value)))

        Next

        Try
            smtp.Send(mail)
            Application.DoEvents()

            MsgBox("Send Mail Complete  ", CType(MsgBoxStyle.Information + MsgBoxStyle.OkOnly, MsgBoxStyle))


            'For Each row As DataGridViewRow In dgvP2.Rows

            '    Dim myCommand As New SqlCommand("Update QEa_DocSys_Dar Set PrintCheck2 = @PrintCheck2 ,PrintDate2 = @PrintDate2 " &
            '                                  "WHERE REFNO = '" & (row.Cells("REFFNO2").Value.ToString) & "' " &
            '                                  "And DOCNO ='" & (row.Cells("DataGridViewTextBoxColumn3").Value.ToString) & "' ", DB_CMD.ObjConn)

            '    myCommand.Parameters.Add("@PrintCheck2", SqlDbType.VarChar).Value = "จัดการ"
            '    myCommand.Parameters.Add("@PrintDate2", SqlDbType.VarChar).Value = TxtDateData.Text

            '    ' myCommand.Parameters.Add("@DateVerify", SqlDbType.VarChar).Value = TxtDateVerify.Text

            '    Dim rowsAffected As Integer = myCommand.ExecuteNonQuery
            'Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            smtp.Dispose()
        End Try

    End Sub

    Sub SendEmail_P3()


        Dim strStatusRepair As String = ""
        Dim strSubjectEmail As String = ""

        'If CommandTypeData = "Addnew" Then
        '    strStatusRepair = "เปิดใบเเจ้งซ่อม"
        '    strSubjectEmail = TxtOther.Text & "( ใบเเจ้งซ่อมระบบคอมพิวเตอร์ เลขที่ : " & TxtJobNo.Text & ") "
        'Else
        '    strStatusRepair = "รอดำเนินการ"
        '    strSubjectEmail = "กำหนดผู้รับผิดชอบงาน โดยฝ่าย iT เลขที่ใบเเจ้งซ่อม : " & TxtJobNo.Text & ""
        'End If

        Dim smtp As New SmtpClient("10.1.1.5")
        Dim mail As New MailMessage()
        'Call GetHostName()

        strStepSendEmail = "FSSC22000 & ISO14001 Document Changes Information & Distribution "

        mail.From = New MailAddress(TxtEmailFM1.Text)


        '  StrUserEmail = ""
        'Dim Sql As String = "Select * from ITm_User where UserNam ='" & TxtServPersn.Text & "' "
        'Dim Dt As New DataTable
        'Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
        'Dim strBranchID As String = ""
        'For Each Dtr As DataRow In Dt.Rows

        '    StrUserEmail = Dtr.Item("UserEmail").ToString

        'Next





        'If TxtBranch.Text = "TP" Then

        '    mail.To.Add("isdiv@sunif.co.th")
        'Else
        '    mail.To.Add("itkb@sunif.co.th")
        'End If

        'If txtToEmail1.Text <> "" Then
        '    StrUserEmail = txtToEmail1.Text & StrUserEmail
        'Else
        '    StrUserEmail = StrUserEmail
        'End If
        'strDOCNOSendMail = ""
        'strRefNoSendMailCheck = ""
        'strRefNoSendMail = ""
        'strEFFDATEDATACheck = ""
        'strEFFDATEDATA = ""

        'strPathAttFileCheck = ""

        'strPathAttFile = ""
        'strPathAttFileData = ""

        'For Each row As DataGridViewRow In dgvData2.Rows

        '    strDOCNOSendMail = strDOCNOSendMail & "," & CStr(row.Cells("DocNO_dgvData2").Value)

        '    If strRefNoSendMailCheck <> CStr(row.Cells("REFNODATA3").Value) Then

        '        strRefNoSendMailCheck = CStr(row.Cells("REFNODATA3").Value)
        '        strRefNoSendMail = strRefNoSendMail & "," & CStr(row.Cells("REFNODATA3").Value)

        '    End If


        '    If strEFFDATEDATACheck <> CStr(row.Cells("DataGridViewTextBoxColumn14").Value) Then

        '        strEFFDATEDATACheck = CStr(row.Cells("DataGridViewTextBoxColumn14").Value)
        '        strEFFDATEDATA = strEFFDATEDATA & "," & CStr(row.Cells("DataGridViewTextBoxColumn14").Value)

        '    End If



        '    Dim Sql1 As String = "SELECT  REFNO, REFNODATA, AttFile3,Filename3 "
        '    Sql1 = Sql1 + " FROM  QEa_AttFile "
        '    Sql1 = Sql1 + " WHERE  REFNODATA = '" & CStr(row.Cells("REFNODATA3").Value) & "' AND DOCNO = '" & CStr(row.Cells("DocNO_dgvData2").Value) & "' "
        '    Sql1 = Sql1 + " Order by REFNODATA, LinkFilePDF asc "

        '    Dim Dt1 As New DataTable
        '    Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)

        '    Dim intNo1 As Integer = 1
        '    Dim intLength As Integer = 0
        '    Dim intLength2 As Integer = 0
        '    Dim intLength3 As Integer = 0
        '    Dim strLinkFilePDF As String = ""
        '    For Each Dtr1 As DataRow In Dt1.Rows
        '        strLinkFilePDF = Dtr1.Item("AttFile3").ToString
        '        intLength2 = Dtr1.Item("AttFile3").Length
        '        intLength = Dtr1.Item("Filename3").Length
        '        intLength3 = intLength2 - intLength

        '        If IsDBNull(Dtr1.Item("AttFile3").ToString) Or Dtr1.Item("AttFile3").ToString = "" Then
        '            strPathAttFile = "-"
        '        Else
        '            strPathAttFile = Mid(Dtr1.Item("AttFile3").ToString, 1, intLength3)
        '        End If


        '    Next


        '    If strPathAttFileCheck <> strPathAttFile Then




        '        strPathAttFileData = strPathAttFileData & "," & strPathAttFile
        '        strPathAttFileCheck = strPathAttFile

        '    End If

        'Next
        strDOCNOSendMail = ""

        For Each row As DataGridViewRow In dgvData2.Rows

            strDOCNOSendMail = strDOCNOSendMail & "," & CStr(row.Cells("DocNO_dgvData2").Value)
        Next

        strDOCNOSendMail = Mid(strDOCNOSendMail, 2, 9999)


        For rowNum As Integer = 0 To dgvData2.Rows.Count - 1
            ' dgvData2(0, rowNum) = rowNum + 1
            dgvData2.Rows(rowNum).Cells(0).Value = (rowNum + 1).ToString

        Next


        mail.To.Add(txtToEmail1.Text)

        If TxtEmailCC1.Text <> "" Then
            mail.CC.Add(TxtEmailCC1.Text)
        End If
        mail.IsBodyHtml = True




        '************************************************************************
        '' mail.Body = "<center><table><tr><td><h2><font color=Blue>Email  แจ้งให้ลงนามเอกสารต้นฉบับ</font></h2><br/><br/></td></tr></table></center>"


        'Table start.
        ' Dim html As String = "<table cellpadding='5' cellspacing='0' style='border: 1px solid #ccc;font-size: 9pt'>"

        'Adding HeaderRow.

        'html &= "เรียนผู้ที่เกี่ยวข้องฝ่าย"
        Dim strxx As String = "      "


        '*********************************************


        '*********************************************



        '  mail.Body = mail.Body + "<tr><td><b><font-size: 7pt color=RED> &nbsp;  &nbsp; &nbsp;&nbsp; เลขที่อ้างอิง : " & strRefNoSendMail & " : ซึ่งมีรายละเอียด ตามตารางด้านล่าง </b></b></Font></Font><br/></td></tr>"
        '  mail.Body = mail.Body + "<tr><td><b><font-size: 7pt color=BLUE> &nbsp;  &nbsp; &nbsp;&nbsp; ขอให้ผู้ที่เกี่ยวข้องเข้าไปลงนามเอกสารให้ครบ ภายใน 2 วันหลังจากที่ได้รับ Mail นี้ด้วยนะคะ</b></b></Font></Font><br/><br/><br/></td></tr>"
        ' StrPathServer = Mid(StrPathServer, 3, 1000)

        Select Case TxtStatus.Text
            Case "รอประกาศใช้"

                If strBranchConn = "TP" Then
                    StrPathServer = "I:\01-Document Control\0. Master list  for Document"
                Else
                    StrPathServer = "K:\ISO14001\Document control"
                End If
                mail.Subject = "Inform the effective date  of document No. ( " & strDOCNOSendMail & " ) "
                mail.Body = mail.Body + "<tr><td><b><font-size: 7pt color=BLACK> เรียน  ทุกท่าน / หน่วยงานที่เกี่ยวข้อง </b></b></Font><br/><br/></td></tr>"
                mail.Body = mail.Body + "<tr><td><b><font-size: 7pt color=BLACK> &nbsp;  &nbsp; &nbsp;&nbsp; ฝ่ายพัฒนาระบบได้ </Font></Font><font-size: 7pt color=BLUE> จัดการเอกสาร</Font></Font> ไว้ใน <font-size: 7pt color=RED>  Master list Document System program</Font> และ Server </b></b></Font></Font><br/></td></tr>"
                mail.Body = mail.Body + "<tr><td><b><font-size: 7pt><font color=BLUE> " & StrPathServer & " </b></b></Font></Font><br/></td></tr>"
                mail.Body = mail.Body + "<tr><td><b><font-size: 7pt><font color=RED>รายละเอียดของเอกสาร และวันที่บังคับใช้ ระบุตามตารางด้านล่างนี้</b></b></Font></Font><br/></td></tr>"
                mail.Body = mail.Body + "<br/>"
                mail.Body = mail.Body + "<tr><td><b><font-size: 7pt><font color=RED>ขอให้หน่วยงานที่ได้รับเเจ้งทำการอ่านศึกษาเอกสารดังกล่าว และฝึกอบรมเอกสารก่อนวันบังคับใช้ด้วย</b></b></Font></Font><br/></td></tr>"
                mail.Body = mail.Body + "<tr><td><b><font-size: 7pt><font color=BLUE>และขอให้ Document Control ฝ่ายเข้าไปกด รับ - คืน เอกสารใน Document System Program ด้วยนะคะ </b></b></Font></Font><br/><br/><br/></td></tr>"


                'mail.Subject = "Inform the effective date  of document No. " & strRefNoSendMail & " "
                'mail.Body = mail.Body + "<tr><td><b><font-size: 7pt color=BLACK> เรียน  ทุกท่าน / หน่วยงานที่เกี่ยวข้อง </b></b></Font><br/><br/></td></tr>"
                'mail.Body = mail.Body + "<tr><td><b><font-size: 7pt color=BLACK> &nbsp;  &nbsp; &nbsp;&nbsp; ฝ่ายดูเเลระบบมาตรฐานได้</Font></Font><font-size: 7pt color=BLUE> จัดการเอกสาร</Font></Font> ไว้ใน <font-size: 7pt color=RED>  Master list Document System program</Font> และ Server </b></b></Font></Font><br/></td></tr>"
                'mail.Body = mail.Body + "<tr><td><b><font-size: 7pt><font color=BLUE> " & StrPathServer & " </b></b></Font></Font><br/></td></tr>"
                'mail.Body = mail.Body + "<tr><td><b><font-size: 7pt><font color=RED>ซึ่งมีผลบังคับใช้ตั้งเเต่วันที่ : " & strEFFDATEDATA & " ดังรายละเอียดในตารางด้านล่างนี้ </b></b></Font></Font><br/></td></tr>"
                'mail.Body = mail.Body + "<tr><td><b><font-size: 7pt><font color=RED>ขอให้หน่วยงานที่ได้รับเเจ้งทำการอ่านศึกษาเอกสารดังกล่าว และฝึกอบรมเอกสารก่อนวันบังคับใช้ด้วยนะคะ</b></b></Font></Font><br/></td></tr>"
                'mail.Body = mail.Body + "<tr><td><b><font-size: 7pt><font color=BLUE>และขอให้ Document Control ฝ่าย " & TxtDOCDEPT.Text & " เข้าไปกดรับ - คืน เอกสารใน Document System Program ด้วยนะคะ </b></b></Font></Font><br/><br/><br/></td></tr>"


            Case "รอ SD Chief ทวนสอบ"

                mail.Subject = "เเจ้ง SD Chief ทวนสอบเอกสาร "
                mail.Body = mail.Body + "<tr><td><b><font-size: 7pt color=BLACK>เรียน SD Chief </b></b></Font><br/><br/></td></tr>"
                mail.Body = mail.Body + "<tr><td><b><font-size: 7pt color=RED> &nbsp;  &nbsp; &nbsp;&nbsp; กรุณา ทวนสอบเอกสาร ตามเลขที่อ้างอิง ดังรายละเอียดตามตารางด้านล่าง ให้ด้วยค่ะ </Font><br/><br/><br/></td></tr>"

        End Select



        mail.Body = mail.Body + "<tr><td><b><font-size: 7 pt><font color=BLUE>หมายเหตุ : " & TxtInputEmail.Text & "</b></b></Font></Font><br/><br/><br/></td></tr>"


        'Table start.

        Dim html As String = "<table cellpadding='5' cellspacing='0' style='border: 1px solid #ccc;font-size: 9pt'>"
        '<br/><br/>
        'Adding HeaderRow.
        html &= "<tr>"
        '  Dim intNoColumn As Integer = 0
        For Each column As DataGridViewColumn In dgvData2.Columns
            '  If intNoColumn <> 1 And intNoColumn <> 6 And intNoColumn <> 9 Then
            html &= "<th style='background-color: #B8DBFD;border: 1px solid #ccc'>" & column.HeaderText & "</th>"
            '  End If

            ' intNoColumn = intNoColumn + 1
        Next
        html &= "</tr>"

        'Adding DataRow.
        'intNoColumn = 0

        For Each row As DataGridViewRow In dgvData2.Rows
            html &= "<tr>"
            Dim intno As Integer = 0
            For Each cell As DataGridViewCell In row.Cells
                ' If intNoColumn <> 1 And intNoColumn <> 6 And intNoColumn <> 9 Then

                Select Case intno
                    Case 0
                        html &= "<td style='width:30px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                    Case 1
                        html &= "<td style='width:100px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                    Case 2
                        html &= "<td style='width:300px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                    Case 3
                        html &= "<td style='width:50px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                    Case 4
                        html &= "<td style='width:110px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                    Case 5
                        html &= "<td style='width:90px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                    Case 6
                        html &= "<td style='width:200px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                    Case 7
                        html &= "<td style='width:120px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                    Case 8
                        html &= "<td style='width:100px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                End Select

                intno = intno + 1

                'End If

                'intNoColumn = intNoColumn + 1
            Next

            html &= "</tr>"

        Next
        'Table end.

        html &= "</table>"

        mail.Body = mail.Body + html

        ' mail.Body = mail.Body + "<tr><td><b><font-size: 9pt><font color=RED><br/><br/> &nbsp;  &nbsp; &nbsp;&nbsp; ** โปรดดำเนินการให้แล้วเสร็จ ก่อนวันบังคับใช้ 2 วัน  นะคะ </b></b></Font></Font><br/></td></tr>"
        ' mail.Body = mail.Body + "<tr><td><b><font-size: 9pt><font color=BLUE><br/><br/> &nbsp;  &nbsp; &nbsp;&nbsp; ** เมื่อลงนามเอกสารเสร็จเเล้วให้เข้าโปรแกรม Document System เพื่อเข้าไป Approve ในระบบด้วยค่ะ *** </b></b></Font></Font><br/><br/><br/></td></tr>"
        mail.Body = mail.Body + "<br/><br/>"
        mail.Body = mail.Body + "รายงานโดย : " & StrUserName & "<br/>"
        mail.Body = mail.Body + "ฝ่ายงาน / หน่วยงาน : " & strDeptData & "<br/>"
        mail.Body = mail.Body + "Sent from computer name : " & strHostName & "<br/><br/>"
        mail.Body = mail.Body + "This email is auto-generated."

        mail.SubjectEncoding = System.Text.Encoding.GetEncoding(65001)

        mail.BodyEncoding = System.Text.Encoding.GetEncoding(65001)

        '  mail.Attachments.Add(New Attachment("D:\DaTA\Config -.xlsx"))

        For Each row As DataGridViewRow In grdAttFile.Rows

            mail.Attachments.Add(New Attachment(CStr(row.Cells("RequestAttFile").Value)))

        Next

        Try

            smtp.Send(mail)
            Application.DoEvents()

            MsgBox("Send Mail Complete  ", CType(MsgBoxStyle.Information + MsgBoxStyle.OkOnly, MsgBoxStyle))


            Dim strCopy4 As String = ""
            Dim strServer4 As String = ""
            Dim strLink4 As String = ""
            Dim strHardCopy5 As String = ""
            Dim strEmail5 As String = TxtDateData.Text
            Dim strHardCopy6 As String = ""
            Dim strServer6 As String = ""
            ' Dim strLinkPdf7 As String = ""


            For Each row As DataGridViewRow In dgvData2.Rows

                ' For Each row As DataGridViewRow In dgvP2.Rows
                '4.การจัดกการสำเนา , ปรับรูปแบบ , ทวนสอบ Link
                If (row.Cells("MANAGE3").Value.ToString) = "RECORD" Then
                    strCopy4 = "-"
                    strHardCopy5 = "-"

                Else

                    strCopy4 = TxtDateData.Text
                    strHardCopy5 = TxtDateData.Text


                End If

                If (row.Cells("MANAGE3").Value.ToString) = "ขอสำเนาเพิ่ม" Or (row.Cells("MANAGE3").Value.ToString) = "ขอสำเนาทดแทน" Or (row.Cells("MANAGE3").Value.ToString) = "ยกเลิกสำเนา" Then
                    strServer4 = "-"
                    strLink4 = "-"

                    strHardCopy6 = TxtDateData.Text
                    strServer6 = TxtDateData.Text
                Else
                    strServer4 = TxtDateData.Text
                    strLink4 = TxtDateData.Text

                End If


                '5. การแจกจ่าย / การแจ้ง  E-mail


                Dim myCommand As New SqlCommand("Update QEa_DocSys_Dar Set Copy4  = @Copy4 ,Server4 = @Server4,Link4 = @Link4, HardCopy5= @HardCopy5,Email5 = @Email5,HardCopy6 = @HardCopy6,Server6 = @Server6 " &
                                        "WHERE REFNODATA = '" & (row.Cells("REFNODATA3").Value.ToString) & "' ", DB_CMD.ObjConn)


                myCommand.Parameters.Add("@Copy4", SqlDbType.VarChar).Value = strCopy4
                myCommand.Parameters.Add("@Server4", SqlDbType.VarChar).Value = strServer4
                myCommand.Parameters.Add("@Link4", SqlDbType.VarChar).Value = strLink4
                myCommand.Parameters.Add("@HardCopy5", SqlDbType.VarChar).Value = strHardCopy5
                myCommand.Parameters.Add("@Email5", SqlDbType.VarChar).Value = strEmail5
                myCommand.Parameters.Add("@HardCopy6", SqlDbType.VarChar).Value = strHardCopy6
                myCommand.Parameters.Add("@Server6", SqlDbType.VarChar).Value = strServer6

                ' myCommand.Parameters.Add("@DateVerify", SqlDbType.VarChar).Value = TxtDateVerify.Text

                Dim rowsAffected As Integer = myCommand.ExecuteNonQuery

            Next


            For Each row As DataGridViewRow In dgvData2.Rows


                Dim myCommand As New SqlCommand("Update QEa_CourseMaster Set UPDDT  = @UPDDT " &
                                       "WHERE DOCNO = '" & (row.Cells("DocNO_dgvData2").Value.ToString) & "'  ", DB_CMD.ObjConn)

                myCommand.Parameters.Add("@UPDDT", SqlDbType.VarChar).Value = TxtDateData.Text

                Dim rowsAffected As Integer = myCommand.ExecuteNonQuery

            Next







        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            smtp.Dispose()
        End Try

    End Sub
    Sub SendEmail_P4()

        Dim strStatusRepair As String = ""
        Dim strSubjectEmail As String = ""

        'If CommandTypeData = "Addnew" Then
        '    strStatusRepair = "เปิดใบเเจ้งซ่อม"
        '    strSubjectEmail = TxtOther.Text & "( ใบเเจ้งซ่อมระบบคอมพิวเตอร์ เลขที่ : " & TxtJobNo.Text & ") "
        'Else
        '    strStatusRepair = "รอดำเนินการ"
        '    strSubjectEmail = "กำหนดผู้รับผิดชอบงาน โดยฝ่าย iT เลขที่ใบเเจ้งซ่อม : " & TxtJobNo.Text & ""
        'End If

        Dim smtp As New SmtpClient("10.1.1.5")
        Dim mail As New MailMessage()
        'Call GetHostName()

        strStepSendEmail = "ส่งอนุมัติออก CAR ให้ SD Manager "

        mail.From = New MailAddress(TxtEmailFM1.Text)


        mail.To.Add(txtToEmail1.Text)
        If TxtEmailCC1.Text <> "" Then
            mail.CC.Add(TxtEmailCC1.Text)
        End If
        mail.IsBodyHtml = True



        strRefNoSendMail = ""
        strRefNoSendMailCheck = ""
        For Each row As DataGridViewRow In dgvDetail.Rows

            If strRefNoSendMailCheck <> CStr(row.Cells("REFNO").Value) Then

                strRefNoSendMailCheck = CStr(row.Cells("REFNO").Value)
                strRefNoSendMail = strRefNoSendMail & "," & CStr(row.Cells("REFNO").Value)
            End If


        Next

        strRefNoSendMail = Mid(strRefNoSendMail, 2, 9999)

        For rowNum As Integer = 0 To dgvDetail.Rows.Count - 1
            ' dgvData2(0, rowNum) = rowNum + 1
            dgvDetail.Rows(rowNum).Cells(0).Value = (rowNum + 1).ToString

        Next



        mail.Subject = "แจ้ง SD จัดการใบคำขอจัดการเอกสาร (  " & strRefNoSendMail & "  ) "

        '************************************************************************


        mail.Body = mail.Body + "<tr><td><b><font-size: 8pt color=BLACK> เรียน ฝ่าย SD </b></b></Font><br/><br/></td></tr>"
        mail.Body = mail.Body + "<tr><td><b><font-size: 8pt color=RED> &nbsp;  &nbsp; &nbsp;&nbsp; ทางฝ่ายได้ยื่นคำขอจัดการเอการ ใน Document System Program  แจ้งขอให้ดำเนินการใบคำขอจัดการเอกสาร ตามเลขที่อ้างอิง " & strRefNoSendMail & " ดังรายละเอียดตามตารางด้านล่าง </Font><br/><br/><br/></td></tr>"

        'mail.Body = mail.Body + "<tr><td><b><font-size: 7pt color=RED> &nbsp;  &nbsp; &nbsp;&nbsp; ฝ่าย " & TxtDOCDEPT.Text & "  ได้ขอดำเนินจัดการเอกสาร  เลขที่อ้างอิง " & strRefNoSendMail & " ซึ่งมีรายละเอียด ตามตาราง </Font></Font><font-size: 10pt color=BLUE> จัดการเอกสาร</Font></Font> ไว้ใน <font-size: 7pt color=RED>  Document System Program </Font> ไว้ใน </b></b></Font></Font><br/><br/><br/></td></tr>"


        'Case "TP"

        '    mail.Body = "<center><table><tr><td><h4><font color=Blue>ช่วยอนุมัติ DAR-TP เลขที่อ้างอิง :  " & strRefNoSendMail & " : ให้ด้วยค่ะ </font></h2><br/><br/></td></tr></table></center>"


        'Case "KB"

        '    mail.Body = "<center><table><tr><td><h4><font color=Blue>ช่วยอนุมัติ DAR-KB เลขที่อ้างอิง :  " & strRefNoSendMail & " : ให้ด้วยค่ะ  </font></h2><br/><br/></td></tr></table></center>"



        mail.Body = mail.Body + "<tr><td><b><font-size: 8 pt><font color=BLUE>หมายเหตุ : " & TxtInputEmail.Text & "</b></b></Font></Font><br/><br/><br/></td></tr>"

        'Table start.
        Dim html As String = "<table cellpadding='5' cellspacing='0' style='border: 1px solid #ccc;font-size: 9pt'>"

        'Adding HeaderRow.
        html &= "<tr>"
        Dim intNoColumn As Integer = 0
        For Each column As DataGridViewColumn In dgvDetail.Columns

            html &= "<th style='background-color: #CAF6EA;border: 1px solid #ccc'>" & column.HeaderText & "</th>"

        Next
        html &= "</tr>"

        'Adding DataRow.
        For Each row As DataGridViewRow In dgvDetail.Rows
            html &= "<tr>"

            Dim intno As Integer = 0
            For Each cell As DataGridViewCell In row.Cells
                ' If intNoColumn <> 1 And intNoColumn <> 6 And intNoColumn <> 9 Then

                Select Case intno
                    Case 0
                        html &= "<td style='width:30px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                    Case 1
                        html &= "<td style='width:100px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                    Case 2
                        html &= "<td style='width:100px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                    Case 3
                        html &= "<td style='width:400px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                    Case 4
                        html &= "<td style='width:50px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                    Case 5
                        html &= "<td style='width:90px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                    Case 6
                        html &= "<td style='width:400px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                    Case 7
                        html &= "<td style='width:100px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                    Case 8
                        html &= "<td style='width:70px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                    Case 9
                        html &= "<td style='width:150px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                End Select

                intno = intno + 1

                'End If

                'intNoColumn = intNoColumn + 1
            Next

            html &= "</tr>"

        Next

        'Table end.
        html &= "</table>"


        mail.Body = mail.Body + html

        mail.Body = mail.Body + "รายงานโดย : " & StrUserName & "<br/>"
        mail.Body = mail.Body + "ฝ่ายงาน / หน่วยงาน : " & strDeptData & "<br/>"
        mail.Body = mail.Body + "Sent from computer name : " & strHostName & "<br/>"
        mail.Body = mail.Body + "This email is auto-generated."

        mail.SubjectEncoding = System.Text.Encoding.GetEncoding(65001)
        mail.BodyEncoding = System.Text.Encoding.GetEncoding(65001)

        '  mail.Attachments.Add(New Attachment("D:\DaTA\Config -.xlsx"))
        For Each row As DataGridViewRow In grdAttFile.Rows

            mail.Attachments.Add(New Attachment(CStr(row.Cells("RequestAttFile").Value)))

        Next
        Try

            smtp.Send(mail)
            Application.DoEvents()


            MsgBox("Send Mail Complete  ", CType(MsgBoxStyle.Information + MsgBoxStyle.OkOnly, MsgBoxStyle))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            smtp.Dispose()
        End Try



    End Sub

    Sub SendEmail_P5()

        Dim strStatusRepair As String = ""
        Dim strSubjectEmail As String = ""

        'If CommandTypeData = "Addnew" Then
        '    strStatusRepair = "เปิดใบเเจ้งซ่อม"
        '    strSubjectEmail = TxtOther.Text & "( ใบเเจ้งซ่อมระบบคอมพิวเตอร์ เลขที่ : " & TxtJobNo.Text & ") "
        'Else
        '    strStatusRepair = "รอดำเนินการ"
        '    strSubjectEmail = "กำหนดผู้รับผิดชอบงาน โดยฝ่าย iT เลขที่ใบเเจ้งซ่อม : " & TxtJobNo.Text & ""
        'End If

        Dim smtp As New SmtpClient("10.1.1.5")
        Dim mail As New MailMessage()
        'Call GetHostName()

        strStepSendEmail = "ส่งอนุมัติออก CAR ให้ SD Manager "

        mail.From = New MailAddress(TxtEmailFM1.Text)


        mail.To.Add(txtToEmail1.Text)
        If TxtEmailCC1.Text <> "" Then
            mail.CC.Add(TxtEmailCC1.Text)
        End If
        mail.IsBodyHtml = True



        'For Each row As DataGridViewRow In dgvDetail.Rows

        '    strRefNoSendMail = CStr(row.Cells("Email").Value)

        'Next

        strRefNoSendMail = ""
        strRefNoSendMailCheck = ""
        For Each row As DataGridViewRow In dgvDetail.Rows

            If strRefNoSendMailCheck <> CStr(row.Cells("REFNO").Value) Then

                strRefNoSendMailCheck = CStr(row.Cells("REFNO").Value)
            strRefNoSendMail = strRefNoSendMail & "," & CStr(row.Cells("REFNO").Value)
            End If


        Next

        strRefNoSendMail = Mid(strRefNoSendMail, 2, 9999)

        For rowNum As Integer = 0 To dgvDetail.Rows.Count - 1
            ' dgvData2(0, rowNum) = rowNum + 1
            dgvDetail.Rows(rowNum).Cells(0).Value = (rowNum + 1).ToString

        Next

        Select Case TxtStatus.Text
            Case "รอ ผู้จัดการฝ่ายอนุมัติ"
                mail.Subject = "แจ้งผู้จัดการฝ่ายพิจารณาใบคำขอจัดการเอกสาร (  " & strRefNoSendMail & "  ) "
                mail.Body = mail.Body + "<tr><td><b><font-size: 7pt color=BLACK>เรียน ผู้จัดการฝ่าย </b></b></Font><br/><br/></td></tr>"
                mail.Body = mail.Body + "<tr><td><b><font-size: 7pt color=RED> &nbsp;  &nbsp; &nbsp;&nbsp; โปรดพิจารณา คำขอจัดการเอกสาร ใน Document System Program เลขที่อ้างอิง : " & strRefNoSendMail & " ดังรายละเอียดตามตารางด้านล่าง </Font><br/><br/><br/></td></tr>"


            Case "ผู้จัดการฝ่ายไม่อนุมัติ"
                mail.Subject = "ผู้จัดการฝ่ายไม่อนุมัติใบคำขอจัดการเอกสาร (  " & strRefNoSendMail & "  ) "
                mail.Body = mail.Body + "<tr><td><b><font-size: 7pt color=BLACK>เรียน ผู้จัดการฝ่าย </b></b></Font><br/><br/></td></tr>"
                mail.Body = mail.Body + "<tr><td><b><font-size: 7pt color=RED> &nbsp;  &nbsp; &nbsp;&nbsp; เลขที่อ้างอิง : " & strRefNoSendMail & " ดังรายละเอียดตามตารางด้านล่าง อยู่ขั้นตอน : ผู้จัดการฝ่ายไม่อนุมัติใบคำขอจัดการเอกสาร </Font><br/><br/><br/></td></tr>"


            Case "SD ไม่อนุมัติ"
                mail.Subject = "ฝ่าย SD ไม่อนุมัติเอกสาร (  " & strRefNoSendMail & "  ) "
                mail.Body = mail.Body + "<tr><td><b><font-size: 7pt color=BLACK>เรียน SD Section Head / MR </b></b></Font><br/><br/></td></tr>"
                mail.Body = mail.Body + "<tr><td><b><font-size: 7pt color=RED> &nbsp;  &nbsp; &nbsp;&nbsp; เลขที่อ้างอิง : " & strRefNoSendMail & " ดังรายละเอียดตามตารางด้านล่าง อยู่ขั้นตอน : ฝ่าย SD ไม่อนุมัติเอกสาร </Font><br/><br/><br/></td></tr>"

            Case "รอ SD Section Head อนุมัติ"
                mail.Subject = "รอฝ่าย SD Section Head อนุมัติ (  " & strRefNoSendMail & "  ) "
                mail.Body = mail.Body + "<tr><td><b><font-size: 7pt color=BLACK>เรียน SD Section Head / MR </b></b></Font><br/><br/></td></tr>"
                mail.Body = mail.Body + "<tr><td><b><font-size: 7pt color=RED> &nbsp;  &nbsp; &nbsp;&nbsp; เลขที่อ้างอิง : " & strRefNoSendMail & " ดังรายละเอียดตามตารางด้านล่าง อยู่ขั้นตอน : รอฝ่าย SD Section Head อนุมัติเอกสาร </Font><br/><br/><br/></td></tr>"

            Case "SD Section Head ไม่อนุมัติ"
                mail.Subject = "ฝ่าย SD Section Head ไม่อนุมัติ (  " & strRefNoSendMail & "  ) "
                mail.Body = mail.Body + "<tr><td><b><font-size: 7pt color=BLACK>เรียน SD Section Head / MR </b></b></Font><br/><br/></td></tr>"
                mail.Body = mail.Body + "<tr><td><b><font-size: 7pt color=RED> &nbsp;  &nbsp; &nbsp;&nbsp; เลขที่อ้างอิง : " & strRefNoSendMail & " ดังรายละเอียดตามตารางด้านล่าง อยู่ขั้นตอน : ฝ่าย SD Section Head ไม่อนุมัติเอกสาร </Font><br/><br/><br/></td></tr>"


            Case "รอ SD จัดทำเอกสาร"
                mail.Subject = "รอ SD จัดทำเอกสาร (  " & strRefNoSendMail & "  ) "
                mail.Body = mail.Body + "<tr><td><b><font-size: 7pt color=BLACK>เรียน SD Staff </b></b></Font><br/><br/></td></tr>"
                mail.Body = mail.Body + "<tr><td><b><font-size: 7pt color=RED> &nbsp;  &nbsp; &nbsp;&nbsp; เลขที่อ้างอิง : " & strRefNoSendMail & " ดังรายละเอียดตามตารางด้านล่าง อยู่ขั้นตอน : รอ ฝ่าย SD จัดทำเอกสารเอกสาร </Font><br/><br/><br/></td></tr>"

            Case "รอ Document Control จัดการ"
                mail.Subject = "รอ Document Control จัดการ(  " & strRefNoSendMail & "  ) "
                mail.Body = mail.Body + "<tr><td><b><font-size: 7pt color=BLACK>เรียน SD Staff </b></b></Font><br/><br/></td></tr>"
                mail.Body = mail.Body + "<tr><td><b><font-size: 7pt color=RED> &nbsp;  &nbsp; &nbsp;&nbsp; เลขที่อ้างอิง : " & strRefNoSendMail & " ดังรายละเอียดตามตารางด้านล่าง อยู่ขั้นตอน : รอ Document Control จัดการ </Font><br/><br/><br/></td></tr>"




        End Select






        mail.Body = mail.Body + "<tr><td><b><font-size: 7 pt><font color=BLUE>หมายเหตุ : " & TxtInputEmail.Text & "</b></b></Font></Font><br/><br/><br/></td></tr>"





        'Case "TP"

        '    mail.Body = "<center><table><tr><td><h4><font color=Blue>ช่วยอนุมัติ DAR-TP เลขที่อ้างอิง :  " & strRefNoSendMail & " : ให้ด้วยค่ะ </font></h2><br/><br/></td></tr></table></center>"


        'Case "KB"

        '    mail.Body = "<center><table><tr><td><h4><font color=Blue>ช่วยอนุมัติ DAR-KB เลขที่อ้างอิง :  " & strRefNoSendMail & " : ให้ด้วยค่ะ  </font></h2><br/><br/></td></tr></table></center>"




        'Table start.
        Dim html As String = "<table cellpadding='5' cellspacing='0' style='border: 1px solid #ccc;font-size: 9pt'>"

        'Adding HeaderRow.
        html &= "<tr>"

        For Each column As DataGridViewColumn In dgvDetail.Columns
            html &= "<th style='background-color: #F6CAD6;border: 1px solid #ccc'>" & column.HeaderText & "</th>"
        Next
        html &= "</tr>"

        'Adding DataRow.
        For Each row As DataGridViewRow In dgvDetail.Rows
            html &= "<tr>"

            Dim intno As Integer = 0
            For Each cell As DataGridViewCell In row.Cells
                ' If intNoColumn <> 1 And intNoColumn <> 6 And intNoColumn <> 9 Then

                Select Case intno
                    Case 0
                        html &= "<td style='width:30px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                    Case 1
                        html &= "<td style='width:100px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                    Case 2
                        html &= "<td style='width:100px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                    Case 3
                        html &= "<td style='width:400px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                    Case 4
                        html &= "<td style='width:50px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                    Case 5
                        html &= "<td style='width:90px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                    Case 6
                        html &= "<td style='width:400px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                    Case 7
                        html &= "<td style='width:100px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                    Case 8
                        html &= "<td style='width:70px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                    Case 9
                        html &= "<td style='width:150px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                End Select

                intno = intno + 1

                'End If

                'intNoColumn = intNoColumn + 1
            Next


            html &= "</tr>"
        Next

        'Table end.
        html &= "</table>"


        mail.Body = mail.Body + html

        mail.Body = mail.Body + "รายงานโดย : " & StrUserName & "<br/>"
        mail.Body = mail.Body + "ฝ่ายงาน / หน่วยงาน : " & strDeptData & "<br/>"
        mail.Body = mail.Body + "Sent from computer name : " & strHostName & "<br/>"
        mail.Body = mail.Body + "This email is auto-generated."

        mail.SubjectEncoding = System.Text.Encoding.GetEncoding(65001)
        mail.BodyEncoding = System.Text.Encoding.GetEncoding(65001)

        '  mail.Attachments.Add(New Attachment("D:\DaTA\Config -.xlsx"))
        For Each row As DataGridViewRow In grdAttFile.Rows

            mail.Attachments.Add(New Attachment(CStr(row.Cells("RequestAttFile").Value)))

        Next

        Try
            smtp.Send(mail)
            Application.DoEvents()

            MsgBox("Send Mail Complete  ", CType(MsgBoxStyle.Information + MsgBoxStyle.OkOnly, MsgBoxStyle))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            smtp.Dispose()
        End Try

    End Sub

    Private Sub Panel7_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel7.MouseClick
        'For rowNum As Integer = 0 To dgvData2.Rows.Count - 1
        '    ' dgvData2(0, rowNum) = rowNum + 1
        '    dgvData2.Rows(rowNum).Cells(0).Value = (rowNum + 1).ToString
        'Next
    End Sub
End Class