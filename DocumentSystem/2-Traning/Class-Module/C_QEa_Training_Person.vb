Imports System
Imports System.Data
Imports System.Data.Sqlclient
Imports System.Data.Sql
'****************************************************************
Public Class C_QEa_Training_Person

Dim Cnn as New SqlClient.SqlConnection 
Dim ValEmployeeNo  as  String
    '****************************************************************
    Property EmployeeNo() As String
        Get
            Return ValEmployeeNo
        End Get
        Set(ByVal value As String)
            ValEmployeeNo = Value
        End Set
    End Property

    '****************************************************************
    Dim ValEmployeeName  as  String
    '****************************************************************
    Property EmployeeName() As String
        Get
            Return ValEmployeeName
        End Get
        Set(ByVal value As String)
            ValEmployeeName = Value
        End Set
    End Property


    '****************************************************************
    Dim ValDept  as  String
    '****************************************************************
    Property Dept() As String
        Get
            Return ValDept
        End Get
        Set(ByVal value As String)
            ValDept = Value
        End Set
    End Property

    '****************************************************************
    Dim ValSection As String
    '****************************************************************
    Property Section() As String
        Get
            Return ValSection
        End Get
        Set(ByVal value As String)
            ValSection = value
        End Set
    End Property

    '****************************************************************


    Dim ValBranch  as  String
    '****************************************************************
    Property Branch() As String
        Get
            Return ValBranch
        End Get
        Set(ByVal value As String)
            ValBranch = Value
        End Set
    End Property

    '****************************************************************
    Dim ValLavel  as  String
    '****************************************************************
    Property Lavel() As String
        Get
            Return ValLavel
        End Get
        Set(ByVal value As String)
            ValLavel = Value
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
             Sql="Insert Into QEa_Training_Person ("
             Sql=Sql +" EmployeeNo,"
             Sql=Sql +" EmployeeName,"
            Sql = Sql + " Dept,"
            Sql = Sql + " Section,"
            Sql =Sql +" Branch,"
             Sql=Sql +" Lavel,"
            Sql = Sql + " StartDate,"
            Sql = Sql + " MD"
            Sql =Sql +" ) Values ("
             Sql=Sql +" '"&  EmployeeNo & "',"
             Sql=Sql +" '"&  EmployeeName & "',"
            Sql = Sql + " '" & Dept & "',"
            Sql = Sql + " '" & Section & "',"
            Sql =Sql +" '"&  Branch & "',"
             Sql=Sql +" '"&  Lavel & "',"
            Sql = Sql + " '" & StartDate & "',"
            Sql = Sql + " '" & MD & "'"
            Sql =Sql +")"
             Return Sql
   Catch ex As Exception 

   End Try

End Function 
'****************************************************************
Public Function SqlCommandUpdate() as  String 
     SqlCommandUpdate=nothing 
   Try 
             Dim Sql As String = ""
             Sql="Update QEa_Training_Person Set "
             Sql=Sql+" EmployeeNo ='"& EmployeeNo &"',"
             Sql=Sql+" EmployeeName ='"& EmployeeName &"',"
            Sql = Sql + " Dept ='" & Dept & "',"
            Sql = Sql + " Section ='" & Section & "',"
            Sql =Sql+" Branch ='"& Branch &"',"
             Sql=Sql+" Lavel ='"& Lavel &"',"
            Sql = Sql + " StartDate ='" & StartDate & "',"
            Sql = Sql + " MD ='" & MD & "'"
            Sql = Sql + "Where EmployeeNo= '" & EmployeeNo & "'"
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
         EmployeeName=Dr.Item("EmployeeName")
            Dept = Dr.Item("Dept")
            Section = Dr.Item("Section")
            Branch =Dr.Item("Branch") 
         Lavel=Dr.Item("Lavel")
            StartDate = Dr.Item("StartDate")
            MD = Dr.Item("MD")

        End While
    Dr.Close 
    Dr=Nothing 

End Function 
'****************************************************************
Public Function CleareData() as Boolean 
        EmployeeNo=Nothing
        EmployeeName=Nothing
        Dept = Nothing
        Section = Nothing
        Branch =Nothing
        Lavel=Nothing
        StartDate = Nothing
        MD = Nothing



    End Function

    '****************************************************************
    'Public Function AppendData() as boolean 
    '      Try
    '       With  C_QEa_Training_Person
    '               .EmployeeNo=TxtEmployeeNo.Text
    '               .EmployeeName=TxtEmployeeName.Text
    '               .Dept=TxtDept.Text
    '               .Branch=TxtBranch.Text
    '               .Lavel=TxtLavel.Text
    '               .StartDate=TxtStartDate.Text

    '       End with 
    '      Catch ex As Exception 
    'End Try 
    'End Function 

End Class