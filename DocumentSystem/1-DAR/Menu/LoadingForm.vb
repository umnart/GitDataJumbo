Public Class LoadingForm
    Dim maxProcess As Integer
    Dim percentOfProcess, checkPercent As Double
    Dim strLoading As String
    Dim strSuccess As String
    Dim count As Integer
    Private Sub LoadingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        ' Cursor = Cursors.WaitCursor
        Me.Cursor = Cursors.WaitCursor
    End Sub

    Public Sub SetData(ByVal max As Integer, Optional ByVal str As String = "", Optional ByVal success As String = "")
        maxProcess = max
        strLoading = str
        strSuccess = success
        ProgressBar.Value = 0
        GroupBox.Text = strLoading
    End Sub
    Public Sub nextProcess()
        count += 1
        percentOfProcess = Convert.ToDouble((count) / maxProcess) * 100
        percentOfProcess = Math.Floor(percentOfProcess)

        ProgressBar.Value = percentOfProcess

        If percentOfProcess <> checkPercent Then
            'GroupBox.Text = strLoading & "  " & percentOfProcess & "%"
            Label1.Text = strLoading & "  " & percentOfProcess & "%"
            checkPercent = percentOfProcess
        End If

        If percentOfProcess = 100 Then
            '  MainMemuForm.Cursor = Cursors.Default
            Me.Cursor = Cursors.Default
            If strSuccess <> "" Then
                MsgBox(strSuccess, MsgBoxStyle.Information, "Success")
            End If
            Threading.Thread.Sleep(1000)
            Me.Close()

        End If
    End Sub
End Class