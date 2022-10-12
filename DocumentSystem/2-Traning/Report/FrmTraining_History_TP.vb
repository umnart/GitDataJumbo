Imports Microsoft.Reporting.WinForms
Public Class FrmTraining_History_TP
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub

    Private Sub FrmTraining_History_TP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '   Call GetHostName()


    End Sub

    Private Sub GetReport()

        Me.Cursor = Cursors.WaitCursor

        Dim StrComname = My.Computer.Name.ToString



        Dim adapter As DsTraining_History_TPTableAdapters.DtTraining_History_TPTableAdapter = New DsTraining_History_TPTableAdapters.DtTraining_History_TPTableAdapter
        Dim table As New DsTraining_History_TP.DtTraining_History_TPDataTable
        Dim MyNewDataSource As New ReportDataSource("DsTraining_History_TP", DirectCast(table, DataTable))


        ' adapter.FillRecieptUsage(table, TxtCodeFrom.Text, txtToCode.Text, DTP1.Value.ToString("yyyyMMdd"), DTP2.Value.ToString("yyyyMMdd"), txtFromWH.Text, TxtToWH.Text, TxtCodeFrom.Text, txtToCode.Text, DTP1.Value.ToString("yyyyMMdd"), DTP2.Value.ToString("yyyyMMdd"), txtFromWH.Text, TxtToWH.Text)
        ' adapter.FillWarning(table, DTP1.Value.ToString("yyyy-MM-dd").Trim, DTP2.Value.ToString("yyyy-MM-dd").Trim, StrComname)
        ' adapter.FillProdday(table, DTP1.Value.ToString("yyyyMMdd"), TxtFromItem.Text, txtToItem.Text, DTP1.Value.ToString("yyyyMMdd"), TxtFromItem.Text, txtToItem.Text)
        'adapter.FillSumAP(table)
        ' adapter.FillSumAP(table, DTP1.Value.ToString("yyyyMMdd"), DTP2.Value.ToString("yyyyMMdd"), TxtCompany.Text)
        adapter.FillTraining_History_TP(table, strEmployeeNoRpt, strDeptRpt)
        'adapter.FillBomDetail(table)
        'adapter.FillReportQE(table)
        Me.ReportViewer1.LocalReport.ReportPath = ".\2-Traning\Report\RptTraining_History_TP.rdlc"

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


        Dim adapter As DsTraining_History_KBTableAdapters.DtTraining_History_KBTableAdapter = New DsTraining_History_KBTableAdapters.DtTraining_History_KBTableAdapter
        Dim table As New DsTraining_History_KB.DtTraining_History_KBDataTable
        Dim MyNewDataSource As New ReportDataSource("DsTraining_History_KB", DirectCast(table, DataTable))


        ' adapter.FillRecieptUsage(table, TxtCodeFrom.Text, txtToCode.Text, DTP1.Value.ToString("yyyyMMdd"), DTP2.Value.ToString("yyyyMMdd"), txtFromWH.Text, TxtToWH.Text, TxtCodeFrom.Text, txtToCode.Text, DTP1.Value.ToString("yyyyMMdd"), DTP2.Value.ToString("yyyyMMdd"), txtFromWH.Text, TxtToWH.Text)
        ' adapter.FillWarning(table, DTP1.Value.ToString("yyyy-MM-dd").Trim, DTP2.Value.ToString("yyyy-MM-dd").Trim, StrComname)
        ' adapter.FillProdday(table, DTP1.Value.ToString("yyyyMMdd"), TxtFromItem.Text, txtToItem.Text, DTP1.Value.ToString("yyyyMMdd"), TxtFromItem.Text, txtToItem.Text)
        'adapter.FillSumAP(table)
        ' adapter.FillSumAP(table, DTP1.Value.ToString("yyyyMMdd"), DTP2.Value.ToString("yyyyMMdd"), TxtCompany.Text)
        adapter.FillTraining_History_KB(table, strEmployeeNoRpt, strDeptRpt)
        'adapter.FillBomDetail(table)
        'adapter.FillReportQE(table)
        Me.ReportViewer1.LocalReport.ReportPath = ".\2-Traning\Report\RptTraining_History_KB.rdlc"

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

    Private Sub GetReport_LastRev_TP()

        Me.Cursor = Cursors.WaitCursor

        Dim StrComname = My.Computer.Name.ToString


        Dim adapter As DsTraining_History_LastRev_TPTableAdapters.DtTraining_History_LastRev_TPTableAdapter = New DsTraining_History_LastRev_TPTableAdapters.DtTraining_History_LastRev_TPTableAdapter
        Dim table As New DsTraining_History_LastRev_TP.DtTraining_History_LastRev_TPDataTable
        Dim MyNewDataSource As New ReportDataSource("DsTraining_History_LastRev_TP", DirectCast(table, DataTable))


        ' adapter.FillRecieptUsage(table, TxtCodeFrom.Text, txtToCode.Text, DTP1.Value.ToString("yyyyMMdd"), DTP2.Value.ToString("yyyyMMdd"), txtFromWH.Text, TxtToWH.Text, TxtCodeFrom.Text, txtToCode.Text, DTP1.Value.ToString("yyyyMMdd"), DTP2.Value.ToString("yyyyMMdd"), txtFromWH.Text, TxtToWH.Text)
        ' adapter.FillWarning(table, DTP1.Value.ToString("yyyy-MM-dd").Trim, DTP2.Value.ToString("yyyy-MM-dd").Trim, StrComname)
        ' adapter.FillProdday(table, DTP1.Value.ToString("yyyyMMdd"), TxtFromItem.Text, txtToItem.Text, DTP1.Value.ToString("yyyyMMdd"), TxtFromItem.Text, txtToItem.Text)
        'adapter.FillSumAP(table)
        ' adapter.FillSumAP(table, DTP1.Value.ToString("yyyyMMdd"), DTP2.Value.ToString("yyyyMMdd"), TxtCompany.Text)
        adapter.FillTraining_History_LastRev_TP(table, strEmployeeNoRpt, strDeptRpt)
        'adapter.FillBomDetail(table)
        'adapter.FillReportQE(table)
        Me.ReportViewer1.LocalReport.ReportPath = ".\2-Traning\Report\RptTraining_History_LastRev_TP.rdlc"

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

    Private Sub GetReport_LastRev_KB()

        Me.Cursor = Cursors.WaitCursor

        Dim StrComname = My.Computer.Name.ToString


        Dim adapter As DsTraining_History_LastRev_KBTableAdapters.DtTraining_History_LastRev_KBTableAdapter = New DsTraining_History_LastRev_KBTableAdapters.DtTraining_History_LastRev_KBTableAdapter
        Dim table As New DsTraining_History_LastRev_KB.DtTraining_History_LastRev_KBDataTable
        Dim MyNewDataSource As New ReportDataSource("DsTraining_History_LastRev_KB", DirectCast(table, DataTable))


        ' adapter.FillRecieptUsage(table, TxtCodeFrom.Text, txtToCode.Text, DTP1.Value.ToString("yyyyMMdd"), DTP2.Value.ToString("yyyyMMdd"), txtFromWH.Text, TxtToWH.Text, TxtCodeFrom.Text, txtToCode.Text, DTP1.Value.ToString("yyyyMMdd"), DTP2.Value.ToString("yyyyMMdd"), txtFromWH.Text, TxtToWH.Text)
        ' adapter.FillWarning(table, DTP1.Value.ToString("yyyy-MM-dd").Trim, DTP2.Value.ToString("yyyy-MM-dd").Trim, StrComname)
        ' adapter.FillProdday(table, DTP1.Value.ToString("yyyyMMdd"), TxtFromItem.Text, txtToItem.Text, DTP1.Value.ToString("yyyyMMdd"), TxtFromItem.Text, txtToItem.Text)
        'adapter.FillSumAP(table)
        ' adapter.FillSumAP(table, DTP1.Value.ToString("yyyyMMdd"), DTP2.Value.ToString("yyyyMMdd"), TxtCompany.Text)
        adapter.FillDsTraining_History_LastRev_KB(table, strEmployeeNoRpt, strDeptRpt)
        'adapter.FillBomDetail(table)
        'adapter.FillReportQE(table)
        Me.ReportViewer1.LocalReport.ReportPath = ".\2-Traning\Report\RptTraining_History_LastRev_KB.rdlc"

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


    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub

    Private Sub bntFind_Click(sender As Object, e As EventArgs) Handles bntFind.Click
        Select Case TxtShowData.Text
            Case "Show All RevNo."

                If strBranchConn = "TP" Then
                    Call GetReport()
                Else
                    Call GetReport_KB()
                End If

            Case "Last RevNo."
                If strBranchConn = "TP" Then
                    Call GetReport_LastRev_TP()
                Else
                    Call GetReport_LastRev_KB()
                End If
        End Select


        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class