Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class C_QEa_Training_ReTaining_Assign

    Dim Cnn As New SqlClient.SqlConnection
    Dim ValEmployeeNo As String
    '****************************************************************
    Property EmployeeNo() As String
        Get
            Return ValEmployeeNo
        End Get
        Set(ByVal value As String)
            ValEmployeeNo = value
        End Set
    End Property
    '****************************************************************
    Dim ValDOCNO As String
    '****************************************************************
    Property DOCNO() As String
        Get
            Return ValDOCNO
        End Get
        Set(ByVal value As String)
            ValDOCNO = value
        End Set
    End Property
    '****************************************************************
    Dim ValDOCDEPT As String
    '****************************************************************
    Property DOCDEPT() As String
        Get
            Return ValDOCDEPT
        End Get
        Set(ByVal value As String)
            ValDOCDEPT = value
        End Set
    End Property
    '****************************************************************
    Dim ValMD As String
    '****************************************************************
    Property MD() As String
        Get
            Return ValMD
        End Get
        Set(ByVal value As String)
            ValMD = value
        End Set
    End Property
    '****************************************************************
    Dim ValDept As String
    '****************************************************************
    Property Dept() As String
        Get
            Return ValDept
        End Get
        Set(ByVal value As String)
            ValDept = value
        End Set
    End Property
    '****************************************************************
    Dim ValAssSeq As String
    '****************************************************************
    Property AssSeq() As String
        Get
            Return ValAssSeq
        End Get
        Set(ByVal value As String)
            ValAssSeq = value
        End Set
    End Property
    '****************************************************************
    Dim ValAssign As String
    '****************************************************************
    Property Assign() As String
        Get
            Return ValAssign
        End Get
        Set(ByVal value As String)
            ValAssign = value
        End Set
    End Property
    '****************************************************************
    Dim ValTrainer As String
    '****************************************************************
    Property Trainer() As String
        Get
            Return ValTrainer
        End Get
        Set(ByVal value As String)
            ValTrainer = value
        End Set
    End Property
    '****************************************************************
    Dim ValMthdCode As String
    '****************************************************************
    Property MthdCode() As String
        Get
            Return ValMthdCode
        End Get
        Set(ByVal value As String)
            ValMthdCode = value
        End Set
    End Property
    '****************************************************************
    Dim ValApprove As String
    '****************************************************************
    Property Approve() As String
        Get
            Return ValApprove
        End Get
        Set(ByVal value As String)
            ValApprove = value
        End Set
    End Property
    '****************************************************************
    Dim ValStartDate As String
    '****************************************************************
    Property StartDate() As String
        Get
            Return ValStartDate
        End Get
        Set(ByVal value As String)
            ValStartDate = value
        End Set
    End Property
    '****************************************************************
    Dim ValRemark As String
    '****************************************************************
    Property Remark() As String
        Get
            Return ValRemark
        End Get
        Set(ByVal value As String)
            ValRemark = value
        End Set
    End Property
    '****************************************************************
    '****************************************************************
    '****************************************************************
    Public Function SQlServerConnect(ByVal Server As String, ByVal Userid As String, ByVal Password As String, Database As String) As Boolean
        Try
            With Cnn
                If .State Then .Close()
                Cnn.ConnectionString = "server=" & Server & ";uid=" & Userid & ";pwd=" & Password & ";database=" & Database & ""
                .Open()
                SQlServerConnect = True
            End With
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Function

    Public Function CmdExcute(ByVal sql As String) As Boolean
        Try
            If Cnn.State = ConnectionState.Closed Then Cnn.Open()
            Dim Cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand(sql, Cnn)
            Cmd.ExecuteNonQuery()
            CmdExcute = True
        Catch ex As Exception
            CmdExcute = False
            MsgBox(Err.Description)
        End Try
    End Function


    '****************************************************************
    Public Function SqlCommandInsert() As String
        SqlCommandInsert = Nothing
        Try
            Dim Sql As String = ""
            Sql = "Insert Into QEa_Training_ReTaining_Assign ("
            Sql = Sql + " EmployeeNo,"
            Sql = Sql + " DOCNO,"
            Sql = Sql + " DOCDEPT,"
            Sql = Sql + " MD,"
            Sql = Sql + " Dept,"
            Sql = Sql + " AssSeq,"
            Sql = Sql + " Assign,"
            Sql = Sql + " Trainer,"
            Sql = Sql + " MthdCode,"
            Sql = Sql + " Approve,"
            Sql = Sql + " StartDate,"
            Sql = Sql + " Remark"
            Sql = Sql + " ) Values ("
            Sql = Sql + " '" & EmployeeNo & "',"
            Sql = Sql + " '" & DOCNO & "',"
            Sql = Sql + " '" & DOCDEPT & "',"
            Sql = Sql + " '" & MD & "',"
            Sql = Sql + " '" & Dept & "',"
            Sql = Sql + " '" & AssSeq & "',"
            Sql = Sql + " '" & Assign & "',"
            Sql = Sql + " '" & Trainer & "',"
            Sql = Sql + " '" & MthdCode & "',"
            Sql = Sql + " '" & Approve & "',"
            Sql = Sql + " '" & StartDate & "',"
            Sql = Sql + " '" & Remark & "'"
            Sql = Sql + ")"
            Return Sql
        Catch ex As Exception

        End Try

    End Function
    '****************************************************************
    Public Function SqlCommandUpdate() As String
        SqlCommandUpdate = Nothing
        Try
            Dim Sql As String = ""
            Sql = "Update QEa_Training_ReTaining_Assign Set "
            Sql = Sql + " EmployeeNo ='" & EmployeeNo & "',"
            Sql = Sql + " DOCNO ='" & DOCNO & "',"
            Sql = Sql + " DOCDEPT ='" & DOCDEPT & "',"
            Sql = Sql + " MD ='" & MD & "',"
            Sql = Sql + " Dept ='" & Dept & "',"
            Sql = Sql + " AssSeq ='" & AssSeq & "',"
            Sql = Sql + " Assign ='" & Assign & "',"
            Sql = Sql + " Trainer ='" & Trainer & "',"
            Sql = Sql + " MthdCode ='" & MthdCode & "',"
            Sql = Sql + " Approve ='" & Approve & "',"
            Sql = Sql + " StartDate ='" & StartDate & "',"
            Sql = Sql + " Remark ='" & Remark & "'"
            Sql = Sql + "Where EmployeeNo= " & EmployeeNo & ""
            Return Sql
        Catch ex As Exception

        End Try

    End Function

    '****************************************************************
    Public Function GetData(SqlCommand As String, Cnn As SqlClient.SqlConnection) As Boolean
        Dim Cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand(SqlCommand, Cnn)
        Dim Dr As SqlClient.SqlDataReader = Cmd.ExecuteReader
        CleareData()

        While Dr.Read
            EmployeeNo = Dr.Item("EmployeeNo")
            DOCNO = Dr.Item("DOCNO")
            DOCDEPT = Dr.Item("DOCDEPT")
            MD = Dr.Item("MD")
            Dept = Dr.Item("Dept")
            AssSeq = Dr.Item("AssSeq")
            Assign = Dr.Item("Assign")
            Trainer = Dr.Item("Trainer")
            MthdCode = Dr.Item("MthdCode")
            Approve = Dr.Item("Approve")
            StartDate = Dr.Item("StartDate")
            Remark = Dr.Item("Remark")
        End While
        Dr.Close()
        Dr = Nothing

    End Function
    '****************************************************************
    Public Function CleareData() As Boolean
        EmployeeNo = Nothing
        DOCNO = Nothing
        DOCDEPT = Nothing
        MD = Nothing
        Dept = Nothing
        AssSeq = Nothing
        Assign = Nothing
        Trainer = Nothing
        MthdCode = Nothing
        Approve = Nothing
        StartDate = Nothing
        Remark = Nothing

    End Function

    '****************************************************************
    'Public Function AppendData() As Boolean
    '    '      Try
    '    '       With  C_QEa_Training_Assign
    '    '               .EmployeeNo=TxtEmployeeNo.Text
    '    '               .DOCNO=TxtDOCNO.Text
    '    '               .DOCDEPT=TxtDOCDEPT.Text
    '    '               .MD=TxtMD.Text
    '    '               .Dept=TxtDept.Text
    '    '               .AssSeq=TxtAssSeq.Text
    '    '               .Assign=TxtAssign.Text
    '    '               .Trainer=TxtTrainer.Text
    '    '               .MthdCode=TxtMthdCode.Text
    '    '               .Approve=TxtApprove.Text
    '    '               .StartDate=TxtStartDate.Text
    '    '               .Remark=TxtRemark.Text

    '    '       End with 
    '    '      Catch ex As Exception 
    '    'End Try 
    'End Function

End Class
