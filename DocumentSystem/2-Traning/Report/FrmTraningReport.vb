Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Reflection
Imports Microsoft.Reporting.WinForms
Public Class FrmTraningReport

    Public CommandType As String
    Public EditNo As String
    Dim strCri As String

    Dim strConn As String
    Dim Conn As New SqlConnection
    Dim da As SqlDataAdapter
    Dim ds As New DataSet
    Dim comSave As New SqlCommand
    Dim comDelete As New SqlCommand
    Dim comUpdate As New SqlCommand
    Private Sub bntPrinting_Click(sender As Object, e As EventArgs) Handles bntPrinting.Click
        Dim sqlinsert As String
        ' Dim strStartDate As String = substring(TxtStartDate.Text, 6, 4) & "-" & substring(TxtStartDate.Text, 3, 2) & "-" & substring(TxtStartDate.Text, 1, 2)
        Dim Dt As New DataTable

        CmdExcute("DELETE FROM QEt_Training_Report  WHERE ComName='" & strHostName & "' ", DB_CMD.ObjConn)

        Dim Sql1 As String = "Select A.EmployeeNo, C.EmployeeName, A.DOCNO, B.DOCNAME, A.REVNO , A.EFFDATE, A.TrnnDate, A.Result, A.Approve, A.Remark, A.Dept "
        Sql1 = Sql1 + "  From QEa_Training_History As A LEFT OUTER Join  QEa_CourseMaster As B On A.DOCNO = B.DOCNO LEFT OUTER Join QEa_Training_Person As C On A.EmployeeNo = C.EmployeeNo "
        Sql1 = Sql1 + "Group By A.EmployeeNo, C.EmployeeName, A.DOCNO, B.DOCNAME, A.TrnnDate, A.Result, A.Approve, A.Remark, A.Dept, A.REVNO, A.EFFDATE "
        Sql1 = Sql1 + " HAVING A.DOCNO ='" & TxtDOCNO.Text & "' "
        Sql1 = Sql1 + " And A.Dept   ='" & TxtDOCDEPT.Text & "' "
        Sql1 = Sql1 + " And A.REVNO In ( Select  MAX(REVNO) From QEa_Training_History "
        Sql1 = Sql1 + " Where DOCNO ='" & TxtDOCNO.Text & "' AND Dept   ='" & TxtDOCDEPT.Text & "') "

        Dim Dt1 As New DataTable
        Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)

        Dim intNo As Integer = 1
        Dim strstatus As String = ""
        For Each Dtr1 As DataRow In Dt1.Rows

            '  MsgBox("xxxxx")
            sqlinsert = "INSERT INTO QEt_Training_Report(EmployeeNo,EmployeeName,DOCNO,DOCNAME,REVNO,EFFDATE,TrnnDate,Result,Approve,Remark,Dept,ComName) " &
                                "VALUES(@EmployeeNo,@EmployeeName,@DOCNO,@DOCNAME,@REVNO,@EFFDATE,@TrnnDate,@Result,@Approve,@Remark,@Dept,@ComName)"

            With comSave
                .Parameters.Clear()

                .Parameters.Add("@EmployeeNo", SqlDbType.VarChar).Value = Dtr1.Item("EmployeeNo").ToString
                .Parameters.Add("@EmployeeName", SqlDbType.VarChar).Value = Dtr1.Item("EmployeeName").ToString
                .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = Dtr1.Item("DOCNO").ToString
                .Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = Dtr1.Item("DOCNAME").ToString
                .Parameters.Add("@REVNO", SqlDbType.Int).Value = Dtr1.Item("REVNO").ToString
                .Parameters.Add("@EFFDATE", SqlDbType.Date).Value = Dtr1.Item("EFFDATE").ToString
                .Parameters.Add("@TrnnDate", SqlDbType.Date).Value = Dtr1.Item("TrnnDate").ToString
                .Parameters.Add("@Result", SqlDbType.Int).Value = Dtr1.Item("Result").ToString
                .Parameters.Add("@Approve", SqlDbType.VarChar).Value = Dtr1.Item("Approve").ToString
                .Parameters.Add("@Remark", SqlDbType.VarChar).Value = Dtr1.Item("Remark").ToString
                .Parameters.Add("@Dept", SqlDbType.VarChar).Value = Dtr1.Item("Dept").ToString
                .Parameters.Add("@ComName", SqlDbType.VarChar).Value = strHostName

                .CommandText = sqlinsert
                .Connection = DB_CMD.ObjConn
                .ExecuteNonQuery()

            End With

        Next


        If strBranchConn = "TP" Then

            Me.GetReport()
        Else
            Me.GetReport_KB()

        End If


        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        FrmMainMenu.PictureBox2.Enabled = True
        Me.Close()
    End Sub

    Private Sub FrmTraningReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If DB_CMD.ObjConn.State = ConnectionState.Closed Then ConnectSQL()

        '  Call Grid()

        Call GetHostName()
        Me.ReportViewer1.RefreshReport()
    End Sub

    'Sub Grid()
    '    Me.dgvDetail.AllowUserToAddRows = False
    '    With Me.dgvDetail
    '        .RowsDefaultCellStyle.BackColor = Color.WhiteSmoke
    '        .AlternatingRowsDefaultCellStyle.BackColor = Color.White
    '        '.AlternatingRowsDefaultCellStyle.Font.arial, 
    '        .DefaultCellStyle.Font = New Font("Arial", 8)
    '        .DefaultCellStyle.BackColor = Color.White
    '        .AlternatingRowsDefaultCellStyle.Font = New Font("Arial", 8)
    '        .ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 8, FontStyle.Bold)
    '        .CellBorderStyle = DataGridViewCellBorderStyle.Single
    '        .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
    '        .GridColor = Color.LightGray
    '    End With



    'End Sub

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

    Private Sub GetReport()

        Me.Cursor = Cursors.WaitCursor

        Dim StrComname = My.Computer.Name.ToString



        Dim adapter As DsTrainingReportTableAdapters.DtTrainingReportTPTableAdapter = New DsTrainingReportTableAdapters.DtTrainingReportTPTableAdapter
        Dim table As New DsTrainingReport.DtTrainingReportTPDataTable
        Dim MyNewDataSource As New ReportDataSource("DsTrainingReport", DirectCast(table, DataTable))


        ' adapter.FillRecieptUsage(table, TxtCodeFrom.Text, txtToCode.Text, DTP1.Value.ToString("yyyyMMdd"), DTP2.Value.ToString("yyyyMMdd"), txtFromWH.Text, TxtToWH.Text, TxtCodeFrom.Text, txtToCode.Text, DTP1.Value.ToString("yyyyMMdd"), DTP2.Value.ToString("yyyyMMdd"), txtFromWH.Text, TxtToWH.Text)
        ' adapter.FillWarning(table, DTP1.Value.ToString("yyyy-MM-dd").Trim, DTP2.Value.ToString("yyyy-MM-dd").Trim, StrComname)
        ' adapter.FillProdday(table, DTP1.Value.ToString("yyyyMMdd"), TxtFromItem.Text, txtToItem.Text, DTP1.Value.ToString("yyyyMMdd"), TxtFromItem.Text, txtToItem.Text)
        'adapter.FillSumAP(table)
        ' adapter.FillSumAP(table, DTP1.Value.ToString("yyyyMMdd"), DTP2.Value.ToString("yyyyMMdd"), TxtCompany.Text)
        adapter.FillTrainingReportTP(table, strHostName)
        'adapter.FillBomDetail(table)
        'adapter.FillReportQE(table)
        Me.ReportViewer1.LocalReport.ReportPath = ".\2-Traning\Report\RptTrainingReport_TP.rdlc"

        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(MyNewDataSource)

        '  Dim p1 As New ReportParameter("RptP1", "Item From  : " & TxtItemFM.Text & "                            To Item  : " & TxtItemTO.Text & "                                  From Date : " & DptDateFM.Value.ToString("yyyy-MM-dd") & "        To Date : " & DptDateTO.Value.ToString("yyyy-MM-dd"))
        'Dim p2 As New ReportParameter("RptP2", "Transfer to W/H:  " & txtToWH.Text & "       Transfer to Location :  " & TxtToLocation.Text)

        ' ' ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2})
        ' ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1})

        Me.ReportViewer1.LocalReport.Refresh()
        Me.ReportViewer1.RefreshReport()
        Me.Cursor = Cursors.Default

    End Sub



    Private Sub GetReport_KB()

        Me.Cursor = Cursors.WaitCursor

        Dim StrComname = My.Computer.Name.ToString



        Dim adapter As DsTrainingReport_KBTableAdapters.DtTrainingReport_KBTableAdapter = New DsTrainingReport_KBTableAdapters.DtTrainingReport_KBTableAdapter
        Dim table As New DsTrainingReport_KB.DtTrainingReport_KBDataTable
        Dim MyNewDataSource As New ReportDataSource("DsTrainingReport_KB", DirectCast(table, DataTable))


        ' adapter.FillRecieptUsage(table, TxtCodeFrom.Text, txtToCode.Text, DTP1.Value.ToString("yyyyMMdd"), DTP2.Value.ToString("yyyyMMdd"), txtFromWH.Text, TxtToWH.Text, TxtCodeFrom.Text, txtToCode.Text, DTP1.Value.ToString("yyyyMMdd"), DTP2.Value.ToString("yyyyMMdd"), txtFromWH.Text, TxtToWH.Text)
        ' adapter.FillWarning(table, DTP1.Value.ToString("yyyy-MM-dd").Trim, DTP2.Value.ToString("yyyy-MM-dd").Trim, StrComname)
        ' adapter.FillProdday(table, DTP1.Value.ToString("yyyyMMdd"), TxtFromItem.Text, txtToItem.Text, DTP1.Value.ToString("yyyyMMdd"), TxtFromItem.Text, txtToItem.Text)
        'adapter.FillSumAP(table)
        ' adapter.FillSumAP(table, DTP1.Value.ToString("yyyyMMdd"), DTP2.Value.ToString("yyyyMMdd"), TxtCompany.Text)
        adapter.FillTrainingReport_KB(table, strHostName)
        'adapter.FillBomDetail(table)
        'adapter.FillReportQE(table)
        Me.ReportViewer1.LocalReport.ReportPath = ".\2-Traning\Report\RptTrainingReport_KB.rdlc"

        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(MyNewDataSource)

        '  Dim p1 As New ReportParameter("RptP1", "Item From  : " & TxtItemFM.Text & "                            To Item  : " & TxtItemTO.Text & "                                  From Date : " & DptDateFM.Value.ToString("yyyy-MM-dd") & "        To Date : " & DptDateTO.Value.ToString("yyyy-MM-dd"))
        'Dim p2 As New ReportParameter("RptP2", "Transfer to W/H:  " & txtToWH.Text & "       Transfer to Location :  " & TxtToLocation.Text)

        ' ' ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2})
        ' ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1})

        Me.ReportViewer1.LocalReport.Refresh()
        Me.ReportViewer1.RefreshReport()
        Me.Cursor = Cursors.Default



    End Sub

End Class