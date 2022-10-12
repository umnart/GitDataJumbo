Imports System
Imports System.Data
Imports System.Data.Sqlclient
Imports System.Data.Sql
'****************************************************************
Public Class C_QEa_Training_Assign

Dim Cnn as New SqlClient.SqlConnection 
Dim ValEmployeeNo  as  String
'****************************************************************
    Property EmployeeNo() as  String
    Get 
         Return  ValEmployeeNo
    End Get 
    Set(ByVal value As  String) 
         ValEmployeeNo= Value
    End Set 
    End Property 
'****************************************************************
Dim ValDOCNO  as  String
'****************************************************************
    Property DOCNO() as  String
    Get 
         Return  ValDOCNO
    End Get 
    Set(ByVal value As  String) 
         ValDOCNO= Value
    End Set 
    End Property 
'****************************************************************
Dim ValDOCDEPT  as  String
'****************************************************************
    Property DOCDEPT() as  String
    Get 
         Return  ValDOCDEPT
    End Get 
    Set(ByVal value As  String) 
         ValDOCDEPT= Value
    End Set 
    End Property 
'****************************************************************
Dim ValMD  as  String
'****************************************************************
    Property MD() as  String
    Get 
         Return  ValMD
    End Get 
    Set(ByVal value As  String) 
         ValMD= Value
    End Set 
    End Property 
'****************************************************************
Dim ValDept  as  String
'****************************************************************
    Property Dept() as  String
    Get 
         Return  ValDept
    End Get 
    Set(ByVal value As  String) 
         ValDept= Value
    End Set 
    End Property 
'****************************************************************
Dim ValAssSeq  as  String
'****************************************************************
    Property AssSeq() as  String
    Get 
         Return  ValAssSeq
    End Get 
    Set(ByVal value As  String) 
         ValAssSeq= Value
    End Set 
    End Property 
'****************************************************************
Dim ValAssign  as  String
'****************************************************************
    Property Assign() as  String
    Get 
         Return  ValAssign
    End Get 
    Set(ByVal value As  String) 
         ValAssign= Value
    End Set 
    End Property 
'****************************************************************
Dim ValTrainer  as  String
'****************************************************************
    Property Trainer() as  String
    Get 
         Return  ValTrainer
    End Get 
    Set(ByVal value As  String) 
         ValTrainer= Value
    End Set 
    End Property 
'****************************************************************
Dim ValMthdCode  as  String
'****************************************************************
    Property MthdCode() as  String
    Get 
         Return  ValMthdCode
    End Get 
    Set(ByVal value As  String) 
         ValMthdCode= Value
    End Set 
    End Property 
'****************************************************************
Dim ValApprove  as  String
'****************************************************************
    Property Approve() as  String
    Get 
         Return  ValApprove
    End Get 
    Set(ByVal value As  String) 
         ValApprove= Value
    End Set 
    End Property 
'****************************************************************
Dim ValStartDate  as  String
'****************************************************************
    Property StartDate() as  String
    Get 
         Return  ValStartDate
    End Get 
    Set(ByVal value As  String) 
         ValStartDate= Value
    End Set 
    End Property
    '****************************************************************
    Dim ValRetrainFreq As String
    '****************************************************************
    Property RetrainFreq() As String
        Get
            Return ValRetrainFreq
        End Get
        Set(ByVal value As String)
            ValRetrainFreq = value
        End Set
    End Property
    '****************************************************************
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
    Public Function SQlServerConnect(ByVal Server As String, ByVal Userid As String, ByVal Password As String,Database as String) As Boolean
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
          Dim Cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand(Sql, Cnn)
          Cmd.ExecuteNonQuery()
          CmdExcute = True
          Catch ex As Exception
          CmdExcute = False
          MsgBox(Err.Description)
    End Try
End Function


'****************************************************************
Public Function SqlCommandInsert() as  String 
     SqlCommandInsert=nothing 
   Try 
             Dim Sql As String = ""
             Sql="Insert Into QEa_Training_Assign ("
             Sql=Sql +" EmployeeNo,"
             Sql=Sql +" DOCNO,"
             Sql=Sql +" DOCDEPT,"
             Sql=Sql +" MD,"
             Sql=Sql +" Dept,"
             Sql=Sql +" AssSeq,"
             Sql=Sql +" Assign,"
             Sql=Sql +" Trainer,"
             Sql=Sql +" MthdCode,"
             Sql=Sql +" Approve,"
            Sql = Sql + " StartDate,"
            Sql = Sql + " RetrainFreq,"
            Sql =Sql +" Remark"
             Sql=Sql +" ) Values ("
             Sql=Sql +" '"&  EmployeeNo & "',"
             Sql=Sql +" '"&  DOCNO & "',"
             Sql=Sql +" '"&  DOCDEPT & "',"
             Sql=Sql +" '"&  MD & "',"
             Sql=Sql +" '"&  Dept & "',"
             Sql=Sql +" '"&  AssSeq & "',"
             Sql=Sql +" '"&  Assign & "',"
             Sql=Sql +" '"&  Trainer & "',"
             Sql=Sql +" '"&  MthdCode & "',"
             Sql=Sql +" '"&  Approve & "',"
            Sql = Sql + " '" & StartDate & "',"
            Sql = Sql + " '" & RetrainFreq & "',"
            Sql =Sql +" '"&  Remark & "'"
             Sql=Sql +")"
             Return Sql
   Catch ex As Exception 

   End Try

End Function 
'****************************************************************
Public Function SqlCommandUpdate() as  String 
     SqlCommandUpdate=nothing 
   Try 
             Dim Sql As String = ""
             Sql="Update QEa_Training_Assign Set "
             Sql=Sql+" EmployeeNo ='"& EmployeeNo &"',"
             Sql=Sql+" DOCNO ='"& DOCNO &"',"
             Sql=Sql+" DOCDEPT ='"& DOCDEPT &"',"
             Sql=Sql+" MD ='"& MD &"',"
             Sql=Sql+" Dept ='"& Dept &"',"
             Sql=Sql+" AssSeq ='"& AssSeq &"',"
             Sql=Sql+" Assign ='"& Assign &"',"
             Sql=Sql+" Trainer ='"& Trainer &"',"
             Sql=Sql+" MthdCode ='"& MthdCode &"',"
             Sql=Sql+" Approve ='"& Approve &"',"
            Sql = Sql + " StartDate ='" & StartDate & "',"
            Sql = Sql + " StartDate ='" & StartDate & "',"
            Sql = Sql + " RetrainFreq ='" & RetrainFreq & "'"
            Sql = Sql + "Where EmployeeNo= " & EmployeeNo & ""
            Return Sql
   Catch ex As Exception 

   End Try

End Function 

'****************************************************************
Public Function GetData(SqlCommand as String ,Cnn as SqlClient.SqlConnection)as Boolean 
Dim Cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand(Sqlcommand, Cnn)
Dim Dr As SqlClient.SqlDataReader = Cmd.ExecuteReader
    CleareData
    While Dr.Read
         EmployeeNo=Dr.Item("EmployeeNo") 
         DOCNO=Dr.Item("DOCNO") 
         DOCDEPT=Dr.Item("DOCDEPT") 
         MD=Dr.Item("MD") 
         Dept=Dr.Item("Dept") 
         AssSeq=Dr.Item("AssSeq") 
         Assign=Dr.Item("Assign") 
         Trainer=Dr.Item("Trainer") 
         MthdCode=Dr.Item("MthdCode") 
         Approve=Dr.Item("Approve") 
         StartDate=Dr.Item("StartDate")
            Remark = Dr.Item("Remark")
            RetrainFreq = Dr.Item("RetrainFreq")
        End While
    Dr.Close 
    Dr=Nothing 

End Function 
'****************************************************************
Public Function CleareData() as Boolean 
        EmployeeNo=Nothing
        DOCNO=Nothing
        DOCDEPT=Nothing
        MD=Nothing
        Dept=Nothing
        AssSeq=Nothing
        Assign=Nothing
        Trainer=Nothing
        MthdCode=Nothing
        Approve=Nothing
        StartDate=Nothing
        Remark=Nothing

        RetrainFreq = Nothing

    End Function

    '****************************************************************
    'Public Function AppendData() as Boolean
    '        '      Try
    '        '       With  C_QEa_Training_Assign
    '        '               .EmployeeNo=TxtEmployeeNo.Text
    '        '               .DOCNO=TxtDOCNO.Text
    '        '               .DOCDEPT=TxtDOCDEPT.Text
    '        '               .MD=TxtMD.Text
    '        '               .Dept=TxtDept.Text
    '        '               .AssSeq=TxtAssSeq.Text
    '        '               .Assign=TxtAssign.Text
    '        '               .Trainer=TxtTrainer.Text
    '        '               .MthdCode=TxtMthdCode.Text
    '        '               .Approve=TxtApprove.Text
    '        '               .StartDate=TxtStartDate.Text
    '        '               .Remark=TxtRemark.Text

    '        '       End with 
    '        '      Catch ex As Exception 
    '        'End Try 
    '    End Function 

End Class