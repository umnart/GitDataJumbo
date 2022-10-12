Imports Microsoft.Reporting.WinForms
Public Class FrmTraining_History_Retraining_Report
    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load
        '   Call GetHostName()
        If strBranchConn = "TP" Then
            Call GetReport()

        Else
            Call GetReport_KB()
        End If
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub


    Private Sub GetReport()


        Me.Cursor = Cursors.WaitCursor

        Dim StrComname = My.Computer.Name.ToString



        Dim adapter As DsHistory_Retraining_Report_TPTableAdapters.DtHistory_ReTraining_TPTableAdapter = New DsHistory_Retraining_Report_TPTableAdapters.DtHistory_ReTraining_TPTableAdapter
        Dim table As New DsHistory_Retraining_Report_TP.DtHistory_ReTraining_TPDataTable
        Dim MyNewDataSource As New ReportDataSource("DsHistory_Retraining_Report_TP", DirectCast(table, DataTable))


        ' adapter.FillRecieptUsage(table, TxtCodeFrom.Text, txtToCode.Text, DTP1.Value.ToString("yyyyMMdd"), DTP2.Value.ToString("yyyyMMdd"), txtFromWH.Text, TxtToWH.Text, TxtCodeFrom.Text, txtToCode.Text, DTP1.Value.ToString("yyyyMMdd"), DTP2.Value.ToString("yyyyMMdd"), txtFromWH.Text, TxtToWH.Text)
        ' adapter.FillWarning(table, DTP1.Value.ToString("yyyy-MM-dd").Trim, DTP2.Value.ToString("yyyy-MM-dd").Trim, StrComname)
        ' adapter.FillProdday(table, DTP1.Value.ToString("yyyyMMdd"), TxtFromItem.Text, txtToItem.Text, DTP1.Value.ToString("yyyyMMdd"), TxtFromItem.Text, txtToItem.Text)
        'adapter.FillSumAP(table)
        ' adapter.FillSumAP(table, DTP1.Value.ToString("yyyyMMdd"), DTP2.Value.ToString("yyyyMMdd"), TxtCompany.Text)
        adapter.FillHistory_ReTraining_TP(table, strEmployeeNoRpt, strDeptRpt, strYearDateFm, strYearDateTo)
        'adapter.FillBomDetail(table)
        'adapter.FillReportQE(table)
        Me.ReportViewer1.LocalReport.ReportPath = ".\2-Traning\Report\RptHistory_Retraining_Report_TP.rdlc"

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



        Dim adapter As DsHistory_Retraining_Report_KBTableAdapters.DtHistory_Retraining_Report_KBTableAdapter = New DsHistory_Retraining_Report_KBTableAdapters.DtHistory_Retraining_Report_KBTableAdapter
        Dim table As New DsHistory_Retraining_Report_KB.DtHistory_Retraining_Report_KBDataTable
        Dim MyNewDataSource As New ReportDataSource("DsHistory_Retraining_Report_KB", DirectCast(table, DataTable))


        ' adapter.FillRecieptUsage(table, TxtCodeFrom.Text, txtToCode.Text, DTP1.Value.ToString("yyyyMMdd"), DTP2.Value.ToString("yyyyMMdd"), txtFromWH.Text, TxtToWH.Text, TxtCodeFrom.Text, txtToCode.Text, DTP1.Value.ToString("yyyyMMdd"), DTP2.Value.ToString("yyyyMMdd"), txtFromWH.Text, TxtToWH.Text)
        ' adapter.FillWarning(table, DTP1.Value.ToString("yyyy-MM-dd").Trim, DTP2.Value.ToString("yyyy-MM-dd").Trim, StrComname)
        ' adapter.FillProdday(table, DTP1.Value.ToString("yyyyMMdd"), TxtFromItem.Text, txtToItem.Text, DTP1.Value.ToString("yyyyMMdd"), TxtFromItem.Text, txtToItem.Text)
        'adapter.FillSumAP(table)
        ' adapter.FillSumAP(table, DTP1.Value.ToString("yyyyMMdd"), DTP2.Value.ToString("yyyyMMdd"), TxtCompany.Text)
        adapter.FillHistory_Retraining_Report_KB(table, strEmployeeNoRpt, strDeptRpt, strYearDateFm, strYearDateTo)
        'adapter.FillBomDetail(table)
        'adapter.FillReportQE(table)
        Me.ReportViewer1.LocalReport.ReportPath = ".\2-Traning\Report\RptHistory_Retraining_Report_KB.rdlc"

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