Public Class FrmTraining_CrseSet_Find
    Private Sub FrmTraining_CrseSet_Find_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadDataDetail()

        Call Grid()
    End Sub

    Sub LoadDataDetail()

        Dim Sql As String = " SELECT  DeptCodSet, CrseSetCode, CrseSetNam "
        Sql = Sql + " FROM  QEa_Training_CrseSet "
        Sql = Sql + " GROUP BY DeptCodSet, CrseSetCode, CrseSetNam"
        Sql = Sql + " HAVING DeptCodSet = '" & strDeptData & "' "
        Sql = Sql + " ORDER BY CrseSetCode "
        Dim Dt As New DataTable
        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
        dgvDetail.Rows.Clear()

        Dim intNoDetail As Integer = 1
        For Each Dtr As DataRow In Dt.Rows
            With dgvDetail
                ' intM = 1
                'intW = 1

                Application.DoEvents()
                .Rows.Add()
                .Item(0, .Rows.Count - 2).Value = intNoDetail
                .Item(1, .Rows.Count - 2).Value = Dtr.Item("CrseSetCode").ToString
                .Item(2, .Rows.Count - 2).Value = Dtr.Item("CrseSetNam").ToString
                .Item(3, .Rows.Count - 2).Value = Dtr.Item("DeptCodSet").ToString

            End With

            intNoDetail = intNoDetail + 1

        Next



    End Sub


    Sub Grid()




        With Me.dgvDetail
            .RowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            '.AlternatingRowsDefaultCellStyle.Font.arial, 
            .DefaultCellStyle.Font = New Font("Arial", 8)
            .DefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.Font = New Font("Arial", 8)
            .ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 8, FontStyle.Bold)
        End With
    End Sub

    Private Sub dgvMain_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetail.CellContentClick

    End Sub

    Private Sub dgvDetail_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvDetail.CellMouseDoubleClick
        Try


            FrmTraining_CrseSet.TxtCrseSetCode.Text = Me.dgvDetail.Item(1, Me.dgvDetail.CurrentRow.Index).Value.ToString()
            FrmTraining_CrseSet.TxtCrseSetNam1.Text = Me.dgvDetail.Item(2, Me.dgvDetail.CurrentRow.Index).Value.ToString()
            FrmTraining_CrseSet.TxtCrseSetCode.Enabled = True
            FrmTraining_CrseSet.TxtCrseSetNam1.Enabled = True

            FrmTraining_CrseSet.TxtCrseSetCode.ReadOnly = True
            FrmTraining_CrseSet.TxtCrseSetNam1.ReadOnly = False
            StrFunction.CourseSetFind = 1

            Me.Close()
            'Call LoadData()

        Catch ex As Exception

        End Try
    End Sub
End Class