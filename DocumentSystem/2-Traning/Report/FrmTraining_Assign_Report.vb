Imports Microsoft.Reporting.WinForms
Public Class FrmTraining_Assign_Report
    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load




        Select Case strFormAssign
            Case "Assign"

                Label5.Text = " แบบกำหนดการฝึกอบรม ณ จุดปฏิบัติงาน"

                If strBranchConn = "TP" Then
                    Call GetReport()
                Else
                    Call GetReport_KB()
                End If
               ' Me.ReportViewer1.RefreshReport()
            Case "Retraining"

                Label5.Text = " แบบกำหนดการฝึกอบรม ณ จุดปฏิบัติงาน ( Re-Training )"
                If strBranchConn = "TP" Then
                    Call GetReport_Retraing()
                Else
                    Call GetReport_Retraing_KB()
                End If
                ' Me.ReportViewer1.RefreshReport()

        End Select

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub

    Private Sub GetReport()

        Me.Cursor = Cursors.WaitCursor

        Dim StrComname = My.Computer.Name.ToString

        Dim adapter As DsTraining_Assign_ReportTableAdapters.DtTraining_Assign_ReportTableAdapter = New DsTraining_Assign_ReportTableAdapters.DtTraining_Assign_ReportTableAdapter
        Dim table As New DsTraining_Assign_Report.DtTraining_Assign_ReportDataTable
        Dim MyNewDataSource As New ReportDataSource("DsTraining_Assign_Report", DirectCast(table, DataTable))

        adapter.FillTraining_Assign_Report(table, strEmployeeNoRpt, strDeptRpt)

        Me.ReportViewer1.LocalReport.ReportPath = ".\2-Traning\Report\RptTraining_Assign_Report_TP.rdlc"

        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(MyNewDataSource)

        Me.ReportViewer1.LocalReport.Refresh()
        Me.ReportViewer1.RefreshReport()
        Me.Cursor = Cursors.Default




    End Sub

    Private Sub GetReport_KB()

        Me.Cursor = Cursors.WaitCursor

        Dim StrComname = My.Computer.Name.ToString

        Dim adapter As DsTraining_Assign_Report_KBTableAdapters.Dt_Training_Assign_Report_KBTableAdapter = New DsTraining_Assign_Report_KBTableAdapters.Dt_Training_Assign_Report_KBTableAdapter
        Dim table As New DsTraining_Assign_Report_KB.Dt_Training_Assign_Report_KBDataTable
        Dim MyNewDataSource As New ReportDataSource("DsTraining_Assign_Report_KB", DirectCast(table, DataTable))

        adapter.FillTraining_Assign_Report_KB(table, strEmployeeNoRpt, strDeptRpt)

        Me.ReportViewer1.LocalReport.ReportPath = ".\2-Traning\Report\RptTraining_Assign_Report_KB.rdlc"

        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(MyNewDataSource)

        Me.ReportViewer1.LocalReport.Refresh()
        Me.ReportViewer1.RefreshReport()
        Me.Cursor = Cursors.Default


    End Sub


    Private Sub GetReport_Retraing()

        Me.Cursor = Cursors.WaitCursor

        Dim StrComname = My.Computer.Name.ToString

        Dim adapter As DsTraining_Assign_Retraining_Report_TPTableAdapters.DtTraining_Assign_Retraining_Report_TPTableAdapter = New DsTraining_Assign_Retraining_Report_TPTableAdapters.DtTraining_Assign_Retraining_Report_TPTableAdapter
        Dim table As New DsTraining_Assign_Retraining_Report_TP.DtTraining_Assign_Retraining_Report_TPDataTable
        Dim MyNewDataSource As New ReportDataSource("DsTraining_Assign_Retraining_Report_TP", DirectCast(table, DataTable))

        adapter.FillTraining_Assign_Retraining_Report_TP(table, strDeptRpt, strEmployeeNoRpt, strYearDateFm, strYearDateTo)

        Me.ReportViewer1.LocalReport.ReportPath = ".\2-Traning\Report\RptTraining_Assign_Retraing_Report_TP.rdlc"

        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(MyNewDataSource)

        Me.ReportViewer1.LocalReport.Refresh()
        Me.ReportViewer1.RefreshReport()
        Me.Cursor = Cursors.Default




    End Sub

    Private Sub GetReport_Retraing_KB()

        Me.Cursor = Cursors.WaitCursor

        Dim StrComname = My.Computer.Name.ToString

        Dim adapter As DsTraining_Assign_Retraining_Report_KBTableAdapters.DtTraining_Assign_Retraining_Report_KBTableAdapter = New DsTraining_Assign_Retraining_Report_KBTableAdapters.DtTraining_Assign_Retraining_Report_KBTableAdapter
        Dim table As New DsTraining_Assign_Retraining_Report_KB.DtTraining_Assign_Retraining_Report_KBDataTable
        Dim MyNewDataSource As New ReportDataSource("DsTraining_Assign_Retraining_Report_KB", DirectCast(table, DataTable))

        adapter.FillTraining_Assign_Retraining_Report_KB(table, strDeptRpt, strEmployeeNoRpt, strYearDateFm, strYearDateTo)

        Me.ReportViewer1.LocalReport.ReportPath = ".\2-Traning\Report\RptTraining_Assign_Retraing_Report_KB.rdlc"

        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(MyNewDataSource)

        Me.ReportViewer1.LocalReport.Refresh()
        Me.ReportViewer1.RefreshReport()
        Me.Cursor = Cursors.Default




    End Sub

    Private Sub Panel_Head_Paint(sender As Object, e As PaintEventArgs) Handles Panel_Head.Paint

    End Sub
End Class