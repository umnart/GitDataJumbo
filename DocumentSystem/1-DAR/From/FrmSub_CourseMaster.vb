Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class FrmSub_CourseMaster

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
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub FrmSub_CourseMaster_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CenterToScreen()

        If strBranchConn = "TP" Then
            Label1.Text = "TP"
            Label2.Text = "KB"

        ElseIf strBranchConn = "KB" Then
            Label1.Text = "KB"
            Label2.Text = "TP"
        End If


        Call LoadData()

        If FrmDocumentSystem.TXTDOCSHARE.Text = "TP-KB" Then
            Call LoadDataGrid2()
        End If
    End Sub


    Sub LoadData()

        Dim cri As String = ""



        Me.dgvMaster1.AllowUserToAddRows = True

        Dim Sql As String = "Select DOCNO, REVNO, EFFDATE, DOCNAME, STATUS from QEa_CourseMaster "
        Sql = Sql + " WHERE DOCNO = '" & FrmDocumentSystem.TxtDOCNO.Text & "' "
        Sql = Sql + " ORDER BY DOCNO, REVNO asc"
        Dim Dt As New DataTable
        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
        dgvMaster1.Rows.Clear()

        Dim intNo As Integer = 1
        For Each Dtr As DataRow In Dt.Rows
            With dgvMaster1


                Application.DoEvents()
                .Rows.Add()
                .Item(0, .Rows.Count - 2).Value = Dtr.Item("DOCNO").ToString
                .Item(1, .Rows.Count - 2).Value = Dtr.Item("REVNO").ToString
                .Item(2, .Rows.Count - 2).Value = Mid(Dtr.Item("EFFDATE").ToString, 1, 10)
                .Item(3, .Rows.Count - 2).Value = Dtr.Item("DOCNAME").ToString

                If Dtr.Item("STATUS").ToString = "A" Then
                    .Item(4, .Rows.Count - 2).Value = "Active"
                ElseIf Dtr.Item("STATUS").ToString = "I" Then
                    .Item(4, .Rows.Count - 2).Value = "InActive"
                End If
                ' .Item(4, .Rows.Count - 2).Value = Dtr.Item("STATUS").ToString

            End With

            TxtDOCNO.Text = Dtr.Item("DOCNO").ToString
            TxtDOCNAME.Text = Dtr.Item("DOCNAME").ToString
            TxtEFFDATE.Text = Mid(Dtr.Item("EFFDATE").ToString, 1, 10)
            TxtREVNO.Text = Dtr.Item("REVNO").ToString



        Next

        '   dgvMaster1.AutoResizeColumns()

        Me.dgvMaster1.AllowUserToAddRows = False


    End Sub

    Sub LoadDataGrid2()


        Select Case strBranchConn
            Case "TP"
                If ConnKB.State = ConnectionState.Closed Then
                    ConnKB.ConnectionString = ClassConnect.ConnectionKB
                    ConnKB.Open()
                End If

                Me.dgvMaster2.AllowUserToAddRows = True

                Dim Sql As String = "Select DOCNO, REVNO, EFFDATE, DOCNAME, STATUS from QEa_CourseMaster "
                Sql = Sql + " WHERE DOCNO = '" & FrmDocumentSystem.TxtDOCNO.Text & "' "
                Sql = Sql + " ORDER BY DOCNO, REVNO asc"
                Dim Dt As New DataTable
                Dt = DB_CMD.GetData_Table(Sql, ConnKB)
                dgvMaster2.Rows.Clear()

                Dim intNo As Integer = 1
                For Each Dtr As DataRow In Dt.Rows
                    With dgvMaster2


                        Application.DoEvents()
                        .Rows.Add()
                        .Item(0, .Rows.Count - 2).Value = Dtr.Item("DOCNO").ToString
                        .Item(1, .Rows.Count - 2).Value = Dtr.Item("REVNO").ToString
                        .Item(2, .Rows.Count - 2).Value = Mid(Dtr.Item("EFFDATE").ToString, 1, 10)
                        .Item(3, .Rows.Count - 2).Value = Dtr.Item("DOCNAME").ToString

                        If Dtr.Item("STATUS").ToString = "A" Then
                            .Item(4, .Rows.Count - 2).Value = "Active"
                        ElseIf Dtr.Item("STATUS").ToString = "I" Then
                            .Item(4, .Rows.Count - 2).Value = "InActive"
                        End If
                        ' .Item(4, .Rows.Count - 2).Value = Dtr.Item("STATUS").ToString

                    End With

                    'TxtDOCNO.Text = Dtr.Item("DOCNO").ToString
                    'TxtDOCNAME.Text = Dtr.Item("DOCNAME").ToString
                    'TxtEFFDATE.Text = Mid(Dtr.Item("EFFDATE").ToString, 1, 10)
                    'TxtREVNO.Text = Dtr.Item("REVNO").ToString



                Next

                '   dgvMaster1.AutoResizeColumns()

                Me.dgvMaster2.AllowUserToAddRows = False



            Case "KB"


                If connTP.State = ConnectionState.Closed Then
                    connTP.ConnectionString = ClassConnect.ConnectionTP
                    connTP.Open()
                End If

                Me.dgvMaster2.AllowUserToAddRows = True

                Dim Sql As String = "Select DOCNO, REVNO, EFFDATE, DOCNAME, STATUS from QEa_CourseMaster "
                Sql = Sql + " WHERE DOCNO = '" & FrmDocumentSystem.TxtDOCNO.Text & "' "
                Sql = Sql + " ORDER BY DOCNO, REVNO asc"
                Dim Dt As New DataTable
                Dt = DB_CMD.GetData_Table(Sql, connTP)
                dgvMaster2.Rows.Clear()

                Dim intNo As Integer = 1
                For Each Dtr As DataRow In Dt.Rows
                    With dgvMaster2


                        Application.DoEvents()
                        .Rows.Add()
                        .Item(0, .Rows.Count - 2).Value = Dtr.Item("DOCNO").ToString
                        .Item(1, .Rows.Count - 2).Value = Dtr.Item("REVNO").ToString
                        .Item(2, .Rows.Count - 2).Value = Mid(Dtr.Item("EFFDATE").ToString, 1, 10)
                        .Item(3, .Rows.Count - 2).Value = Dtr.Item("DOCNAME").ToString

                        If Dtr.Item("STATUS").ToString = "A" Then
                            .Item(4, .Rows.Count - 2).Value = "Active"
                        ElseIf Dtr.Item("STATUS").ToString = "I" Then
                            .Item(4, .Rows.Count - 2).Value = "InActive"
                        End If
                        ' .Item(4, .Rows.Count - 2).Value = Dtr.Item("STATUS").ToString

                    End With

                    'TxtDOCNO.Text = Dtr.Item("DOCNO").ToString
                    'TxtDOCNAME.Text = Dtr.Item("DOCNAME").ToString
                    'TxtEFFDATE.Text = Mid(Dtr.Item("EFFDATE").ToString, 1, 10)
                    'TxtREVNO.Text = Dtr.Item("REVNO").ToString



                Next

                '   dgvMaster1.AutoResizeColumns()

                Me.dgvMaster2.AllowUserToAddRows = False



        End Select






    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub
End Class