Option Explicit On
Option Strict On
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Data.OleDb
Public Class FrmQEa_DocSys_SndDoc
    Dim ConnSA As New OleDbConnection
    Dim strConn As String
    Dim Conn As New SqlConnection
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet
    Dim da2 As SqlDataAdapter
    Dim ds2 As New DataSet
    Dim da3 As SqlDataAdapter
    Dim ds3 As New DataSet
    Dim strSQL As String
    Dim cri As String = ""
    Dim strDateDueStartFM, strDateDueStartTO As String
    Dim IsFindItemcode As Boolean


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

    Dim Exts As String

    Private Sub FrmQEa_DocSys_SndDoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bntChangeStartDate_Click(sender As Object, e As EventArgs) Handles bntChangeStartDate.Click
        Call ShowData()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With Me.dgvData

            For i As Integer = 0 To .Rows.Count - 1


                Dim sqlinsert As String


                ' CmdExcute("DELETE FROM QEa_SendDocToDept ", DB_CMD.ObjConn)


                sqlinsert = "INSERT INTO QEa_SendDocToDept(DOCNO,language,CtypeData,DocCtrl,CopyNo,ToDept,STATUS) " &
                            "VALUES(@DOCNO,@language,@CtypeData,@DocCtrl,@CopyNo,@ToDept,@STATUS)"

                With comSave

                    .Parameters.Clear()
                    .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = CType((dgvData.Rows(i).Cells(0).Value), String)
                    .Parameters.Add("@language", SqlDbType.VarChar).Value = CType((dgvData.Rows(i).Cells(1).Value), String)
                    .Parameters.Add("@CtypeData", SqlDbType.VarChar).Value = CType((dgvData.Rows(i).Cells(2).Value), String)
                    .Parameters.Add("@DocCtrl", SqlDbType.VarChar).Value = CType((dgvData.Rows(i).Cells(3).Value), String)
                    .Parameters.Add("@CopyNo", SqlDbType.VarChar).Value = CType((dgvData.Rows(i).Cells(4).Value), String)
                    .Parameters.Add("@ToDept", SqlDbType.VarChar).Value = CType((dgvData.Rows(i).Cells(5).Value), String)
                    .Parameters.Add("@STATUS", SqlDbType.VarChar).Value = CType((dgvData.Rows(i).Cells(6).Value), String)

                    .CommandText = sqlinsert
                    .Connection = DB_CMD.ObjConn
                    .ExecuteNonQuery()


                End With


            Next


        End With

        MsgBox("OK")

    End Sub

    Sub ShowData()


        Me.dgvData.AllowUserToAddRows = True

        Dim dt_SelectDataSA = ClassConnect.getDataSetSA("SELECT *  " &
                                                        "FROM QEa_DocSys_SndDoc  ORDER BY DocNo", mytransDB, "")

        'Dim dt_SelectDataSA = ClassConnect.getDataSetSA("SELECT QEa_CrseRev.CrseCode, QEa_CrseMst.CrseNam, QEa_CrseRev.RevSts, QEa_CrseRev.DeptCod, QEa_CrseRev.RevNo, QEa_CrseRev.RevDate, QEa_CrseRev.DescThai, QEa_CrseMst.AttachFile, QEa_CrseMst.CrseTypCode " &
        '                                                "FROM QEa_CrseRev LEFT JOIN QEa_CrseMst ON QEa_CrseRev.CrseCode = QEa_CrseMst.CrseCode WHERE QEa_CrseRev.CrseCode= 'Att.1-A'  ORDER BY QEa_CrseRev.CrseCode,QEa_CrseRev.RevNo", mytransDB, "")

        If dt_SelectDataSA.Rows.Count > 0 Then
            Dim intNo As Integer = 1
            For i As Integer = 0 To dt_SelectDataSA.Rows.Count - 1
                With dgvData
                    ' intM = 1
                    'intW = 1

                    Application.DoEvents()
                    .Rows.Add()

                    .Item(0, .Rows.Count - 2).Value = dt_SelectDataSA.Rows(i).Item("DocNo").ToString
                    .Item(1, .Rows.Count - 2).Value = dt_SelectDataSA.Rows(i).Item("Langu").ToString
                    .Item(2, .Rows.Count - 2).Value = dt_SelectDataSA.Rows(i).Item("Ctype").ToString
                    .Item(3, .Rows.Count - 2).Value = dt_SelectDataSA.Rows(i).Item("DocCtrl").ToString
                    .Item(4, .Rows.Count - 2).Value = dt_SelectDataSA.Rows(i).Item("CopyNo").ToString
                    .Item(5, .Rows.Count - 2).Value = dt_SelectDataSA.Rows(i).Item("ToDept").ToString
                    .Item(6, .Rows.Count - 2).Value = dt_SelectDataSA.Rows(i).Item("Status").ToString
                    .Item(7, .Rows.Count - 2).Value = intNo
                End With

                intNo = intNo + 1
                ' grdCheck.Rows(grdCheck.Rows.Count - 1).Cells("Supplier1").Value = dt_SelectDataSA.Rows(i).Item("Supplier").ToString
            Next
        End If
        ' dgvData.AutoResizeColumns()
        Me.dgvData.AllowUserToAddRows = False


        MsgBox("OK")
    End Sub
End Class


