Option Explicit On
Option Strict On
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Data.OleDb
Public Class FrmUpdateDataFromSA
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
    Private Sub FrmUpdateDataFromSA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If connKBSA.State = ConnectionState.Closed Then
            connKBSA.ConnectionString = ClassConnect.ConnectionKBSA
            connKBSA.Open()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Call ShowData()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub bntChangeStartDate_Click(sender As Object, e As EventArgs) Handles bntChangeStartDate.Click
        If strBranchConn = "TP" Then
            '  Call ShowData()
            Call ShowDataMaster()
        Else
            ' Call ShowDataSQL()
            Call ShowDataSQLMaster()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call UpdateMaster()

    End Sub
    Sub UpdateMaster()
        With Me.dgvData

            For i As Integer = 0 To .Rows.Count - 1

                Dim myCommand As New SqlCommand("Update QEa_CourseMaster Set STATUS = @STATUS " &
                                              "WHERE DOCNO = '" & CType((dgvData.Rows(i).Cells(0).Value), String) & "' ", DB_CMD.ObjConn)
                myCommand.Parameters.Add("@STATUS", SqlDbType.VarChar).Value = CType((dgvData.Rows(i).Cells(2).Value), String)

                Dim rowsAffected As Integer = myCommand.ExecuteNonQuery

            Next
        End With

        MsgBox("OK")


    End Sub
    Sub SAVESA()
        With Me.dgvData

            For i As Integer = 0 To .Rows.Count - 1


                Dim sqlinsert As String


                'CmdExcute("DELETE FROM QEa_CourseMaster WHERE DOCNO ='" & CType((dgvData.Rows(i).Cells(0).Value), String) & "' AND  DOCTYPE ='" & CType((dgvData.Rows(i).Cells(8).Value), String) & "' AND  REVNO =" & CType((dgvData.Rows(i).Cells(4).Value), String) & " AND DOCDEPT ='" & CType((dgvData.Rows(i).Cells(3).Value), String) & "'", DB_CMD.ObjConn)


                sqlinsert = "INSERT INTO QEa_CourseMaster(DOCNO,DOCNAME,STATUS,DOCDEPT,REVNO,EFFDATE,DOCTYPE,AttachFile,REASON,DOCSHARE,BRANCHDATA,SELECTSYSTEM) " &
                            "VALUES(@DOCNO,@DOCNAME,@STATUS,@DOCDEPT,@REVNO,@EFFDATE,@DOCTYPE,@AttachFile,@REASON,@DOCSHARE,@BRANCHDATA,@SELECTSYSTEM)"

                With comSave
                    .Parameters.Clear()
                    .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = CType((dgvData.Rows(i).Cells(0).Value), String)
                    .Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = CType((dgvData.Rows(i).Cells(1).Value), String)
                    .Parameters.Add("@STATUS", SqlDbType.VarChar).Value = CType((dgvData.Rows(i).Cells(2).Value), String)
                    .Parameters.Add("@DOCDEPT", SqlDbType.VarChar).Value = CType((dgvData.Rows(i).Cells(3).Value), String)
                    .Parameters.Add("@REVNO", SqlDbType.Int).Value = CType((dgvData.Rows(i).Cells(4).Value), String)
                    ' TxtEFFDATE.Text = Mid(CType((dgvData.Rows(i).Cells(5).Value), String), 1, 10)
                    If IsDBNull(CType((dgvData.Rows(i).Cells(5).Value), String)) Or CType((dgvData.Rows(i).Cells(5).Value), String) = "" Then
                        .Parameters.Add("@EFFDATE", SqlDbType.Date).Value = TxtEFFDATE.Text
                    Else
                        .Parameters.Add("@EFFDATE", SqlDbType.Date).Value = CType((dgvData.Rows(i).Cells(5).Value), String)
                    End If

                    If IsDBNull(dgvData.Rows(i).Cells(8).Value) Then

                        .Parameters.Add("@DOCTYPE", SqlDbType.VarChar).Value = "MNL"
                    Else
                        .Parameters.Add("@DOCTYPE", SqlDbType.VarChar).Value = CType((dgvData.Rows(i).Cells(8).Value), String)

                    End If


                    If IsDBNull(dgvData.Rows(i).Cells(7).Value) Then
                        .Parameters.Add("@AttachFile", SqlDbType.VarChar).Value = ""
                    Else

                        .Parameters.Add("@AttachFile", SqlDbType.VarChar).Value = CType((dgvData.Rows(i).Cells(7).Value), String)

                    End If
                    If IsDBNull(dgvData.Rows(i).Cells(6).Value) Then

                        .Parameters.Add("@REASON", SqlDbType.VarChar).Value = " "
                    Else
                        .Parameters.Add("@REASON", SqlDbType.VarChar).Value = CType((dgvData.Rows(i).Cells(6).Value), String)
                    End If


                    .Parameters.Add("@DOCSHARE", SqlDbType.VarChar).Value = strBranchConn
                    .Parameters.Add("@BRANCHDATA", SqlDbType.VarChar).Value = strBranchConn

                    If CType((dgvData.Rows(i).Cells(3).Value), String) = "DC" Then

                        .Parameters.Add("@SELECTSYSTEM", SqlDbType.VarChar).Value = "DS"
                    Else
                        .Parameters.Add("@SELECTSYSTEM", SqlDbType.VarChar).Value = CType((dgvData.Rows(i).Cells(3).Value), String)
                    End If



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

        Dim dt_SelectDataSA = ClassConnect.getDataSetSA("Select QEa_CrseRev.CrseCode, QEa_CrseMst.CrseNam, QEa_CrseRev.RevSts, QEa_CrseRev.DeptCod, QEa_CrseRev.RevNo, QEa_CrseRev.RevDate, QEa_CrseRev.DescThai, QEa_CrseMst.AttachFile, QEa_CrseMst.CrseTypCode " &
                                                        "FROM QEa_CrseRev LEFT JOIN QEa_CrseMst On QEa_CrseRev.CrseCode = QEa_CrseMst.CrseCode  ORDER BY QEa_CrseRev.CrseCode,QEa_CrseRev.RevNo", mytransDB, "")

        'Dim dt_SelectDataSA = ClassConnect.getDataSetSA("Select QEa_CrseRev.CrseCode, QEa_CrseMst.CrseNam, QEa_CrseRev.RevSts, QEa_CrseRev.DeptCod, QEa_CrseRev.RevNo, QEa_CrseRev.RevDate, QEa_CrseRev.DescThai, QEa_CrseMst.AttachFile, QEa_CrseMst.CrseTypCode " &
        '                                                "FROM QEa_CrseRev LEFT JOIN QEa_CrseMst On QEa_CrseRev.CrseCode = QEa_CrseMst.CrseCode WHERE QEa_CrseRev.CrseCode= 'Att.1-A'  ORDER BY QEa_CrseRev.CrseCode,QEa_CrseRev.RevNo", mytransDB, "")

        If dt_SelectDataSA.Rows.Count > 0 Then
            Dim intNo As Integer = 1
            For i As Integer = 0 To dt_SelectDataSA.Rows.Count - 1
                With dgvData
                    ' intM = 1
                    'intW = 1

                    Application.DoEvents()
                    .Rows.Add()

                    .Item(0, .Rows.Count - 2).Value = dt_SelectDataSA.Rows(i).Item("CrseCode").ToString
                    .Item(1, .Rows.Count - 2).Value = dt_SelectDataSA.Rows(i).Item("CrseNam").ToString
                    .Item(2, .Rows.Count - 2).Value = dt_SelectDataSA.Rows(i).Item("RevSts").ToString
                    .Item(3, .Rows.Count - 2).Value = dt_SelectDataSA.Rows(i).Item("DeptCod").ToString
                    .Item(4, .Rows.Count - 2).Value = dt_SelectDataSA.Rows(i).Item("RevNo").ToString
                    .Item(5, .Rows.Count - 2).Value = dt_SelectDataSA.Rows(i).Item("RevDate").ToString
                    If dt_SelectDataSA.Rows(i).Item("DescThai").ToString = "" Then
                        .Item(6, .Rows.Count - 2).Value = " "
                    Else
                        .Item(6, .Rows.Count - 2).Value = Replace(dt_SelectDataSA.Rows(i).Item("DescThai").ToString, """", "")
                    End If

                    .Item(7, .Rows.Count - 2).Value = dt_SelectDataSA.Rows(i).Item("AttachFile").ToString
                    .Item(8, .Rows.Count - 2).Value = dt_SelectDataSA.Rows(i).Item("CrseTypCode").ToString
                    .Item(9, .Rows.Count - 2).Value = intNo
                End With

                intNo = intNo + 1
                ' grdCheck.Rows(grdCheck.Rows.Count - 1).Cells("Supplier1").Value = dt_SelectDataSA.Rows(i).Item("Supplier").ToString
            Next
        End If
        ' dgvData.AutoResizeColumns()
        Me.dgvData.AllowUserToAddRows = False


        MsgBox("OK")
    End Sub

    Sub ShowDataMaster()


        Me.dgvData.AllowUserToAddRows = True

        Dim dt_SelectDataSA = ClassConnect.getDataSetSA("Select * " &
                                                        "FROM QEa_CrseMst  ORDER BY CrseCode", mytransDB, "")

        'Dim dt_SelectDataSA = ClassConnect.getDataSetSA("Select QEa_CrseRev.CrseCode, QEa_CrseMst.CrseNam, QEa_CrseRev.RevSts, QEa_CrseRev.DeptCod, QEa_CrseRev.RevNo, QEa_CrseRev.RevDate, QEa_CrseRev.DescThai, QEa_CrseMst.AttachFile, QEa_CrseMst.CrseTypCode " &
        '                                                "FROM QEa_CrseRev LEFT JOIN QEa_CrseMst On QEa_CrseRev.CrseCode = QEa_CrseMst.CrseCode WHERE QEa_CrseRev.CrseCode= 'Att.1-A'  ORDER BY QEa_CrseRev.CrseCode,QEa_CrseRev.RevNo", mytransDB, "")

        If dt_SelectDataSA.Rows.Count > 0 Then
            Dim intNo As Integer = 1
            For i As Integer = 0 To dt_SelectDataSA.Rows.Count - 1
                With dgvData
                    ' intM = 1
                    'intW = 1

                    Application.DoEvents()
                    .Rows.Add()

                    .Item(0, .Rows.Count - 2).Value = dt_SelectDataSA.Rows(i).Item("CrseCode").ToString
                    .Item(1, .Rows.Count - 2).Value = dt_SelectDataSA.Rows(i).Item("CrseNam").ToString
                    .Item(2, .Rows.Count - 2).Value = dt_SelectDataSA.Rows(i).Item("CrseSts").ToString

                End With

                intNo = intNo + 1
                ' grdCheck.Rows(grdCheck.Rows.Count - 1).Cells("Supplier1").Value = dt_SelectDataSA.Rows(i).Item("Supplier").ToString
            Next
        End If
        ' dgvData.AutoResizeColumns()
        Me.dgvData.AllowUserToAddRows = False


        MsgBox("OK")
    End Sub


    Sub ShowDataSQL()


        Me.dgvData.AllowUserToAddRows = True

        Dim dt_SelectDataSA = ClassConnect.getDataSetKBSA("SELECT QEa_CrseRev.CrseCode, QEa_CrseMst.CrseNam, QEa_CrseRev.RevSts, QEa_CrseRev.DeptCod, QEa_CrseRev.RevNo, QEa_CrseRev.RevDate, QEa_CrseRev.DescThai, QEa_CrseMst.AttachFile, QEa_CrseMst.CrseTypCode " &
                                                        "FROM QEa_CrseRev LEFT JOIN QEa_CrseMst ON QEa_CrseRev.CrseCode = QEa_CrseMst.CrseCode  ORDER BY QEa_CrseRev.CrseCode,QEa_CrseRev.RevNo", mytrans, "")

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

                    .Item(0, .Rows.Count - 2).Value = dt_SelectDataSA.Rows(i).Item("CrseCode").ToString
                    .Item(1, .Rows.Count - 2).Value = dt_SelectDataSA.Rows(i).Item("CrseNam").ToString
                    .Item(2, .Rows.Count - 2).Value = dt_SelectDataSA.Rows(i).Item("RevSts").ToString
                    .Item(3, .Rows.Count - 2).Value = dt_SelectDataSA.Rows(i).Item("DeptCod").ToString
                    .Item(4, .Rows.Count - 2).Value = dt_SelectDataSA.Rows(i).Item("RevNo").ToString
                    .Item(5, .Rows.Count - 2).Value = dt_SelectDataSA.Rows(i).Item("RevDate").ToString
                    If dt_SelectDataSA.Rows(i).Item("DescThai").ToString = "" Then
                        .Item(6, .Rows.Count - 2).Value = " "
                    Else
                        .Item(6, .Rows.Count - 2).Value = Replace(dt_SelectDataSA.Rows(i).Item("DescThai").ToString, """", "")
                    End If

                    .Item(7, .Rows.Count - 2).Value = dt_SelectDataSA.Rows(i).Item("AttachFile").ToString
                    .Item(8, .Rows.Count - 2).Value = dt_SelectDataSA.Rows(i).Item("CrseTypCode").ToString
                    .Item(9, .Rows.Count - 2).Value = intNo
                End With

                intNo = intNo + 1
                ' grdCheck.Rows(grdCheck.Rows.Count - 1).Cells("Supplier1").Value = dt_SelectDataSA.Rows(i).Item("Supplier").ToString
            Next
        End If
        ' dgvData.AutoResizeColumns()
        Me.dgvData.AllowUserToAddRows = False


        MsgBox("OK")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        T1.Text = "1"


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        Dim FirstCharacter As Integer = T1.Text.IndexOf("2")
        ' WriteLine(FirstCharacter)
        MsgBox(FirstCharacter)



    End Sub

    Sub ShowDataSQLMaster()


        Me.dgvData.AllowUserToAddRows = True

        Dim dt_SelectDataSA = ClassConnect.getDataSetKBSA("SELECT * " &
                                                        "FROM QEa_CrseMst  ORDER BY CrseCode ", mytrans, "")

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

                    .Item(0, .Rows.Count - 2).Value = dt_SelectDataSA.Rows(i).Item("CrseCode").ToString
                    .Item(1, .Rows.Count - 2).Value = dt_SelectDataSA.Rows(i).Item("CrseNam").ToString
                    .Item(2, .Rows.Count - 2).Value = dt_SelectDataSA.Rows(i).Item("CrseSts").ToString

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