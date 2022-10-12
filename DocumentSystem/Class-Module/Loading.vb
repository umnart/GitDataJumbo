Public Class Loading
    Dim maxProcess As Integer
    Dim percentOfProcess, checkPercent As Double
    Dim strLoading As String
    Dim strSuccess As String
    Dim count As Integer

    Public Function SetData(ByVal max As Integer, Optional ByVal str As String = "", Optional ByVal success As String = "")
        maxProcess = max
        strLoading = str
        strSuccess = success
        'ProgressBar.Value = 0
        'GroupBox.Text = strLoading
    End Function
    Public Sub nextProcess()
        count += 1
        percentOfProcess = Convert.ToDouble((count) / maxProcess) * 100
        percentOfProcess = Math.Floor(percentOfProcess)

        ' ProgressBar.Value = percentOfProcess

        If percentOfProcess <> checkPercent Then
            'GroupBox.Text = strLoading & "  " & percentOfProcess & "%"
            FrmTraining_History.Label1.Text = strLoading & "  " & percentOfProcess & "%"
            checkPercent = percentOfProcess
        End If

        If percentOfProcess = 100 Then
            '  MainMemuForm.Cursor = Cursors.Default
            FrmTraining_History.Cursor = Cursors.Default
            If strSuccess <> "" Then
                MsgBox(strSuccess, MsgBoxStyle.Information, "Success")
            End If
            Threading.Thread.Sleep(1000)
            'Me.Close()

        End If
    End Sub
End Class
