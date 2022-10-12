Imports System
Imports System.Data
Imports System.Data.Sqlclient
Imports System.Data.Sql
'****************************************************************
Public Class C_QEa_DocSysItem

Dim Cnn as New SqlClient.SqlConnection 
Dim ValREFNO  as  String
'****************************************************************
    Property REFNO() as  String
    Get 
         Return  ValREFNO
    End Get 
    Set(ByVal value As  String) 
         ValREFNO= Value
    End Set 
    End Property 
'****************************************************************
Dim ValREFNODATA  as  String
'****************************************************************
    Property REFNODATA() as  String
    Get 
         Return  ValREFNODATA
    End Get 
    Set(ByVal value As  String) 
         ValREFNODATA= Value
    End Set 
    End Property 
'****************************************************************
Dim ValDARNO  as  String
'****************************************************************
    Property DARNO() as  String
    Get 
         Return  ValDARNO
    End Get 
    Set(ByVal value As  String) 
         ValDARNO= Value
    End Set 
    End Property 
'****************************************************************
Dim ValSTATUS  as  String
'****************************************************************
    Property STATUS() as  String
    Get 
         Return  ValSTATUS
    End Get 
    Set(ByVal value As  String) 
         ValSTATUS= Value
    End Set 
    End Property 
'****************************************************************
Dim ValDOCTYPE  as  String
'****************************************************************
    Property DOCTYPE() as  String
    Get 
         Return  ValDOCTYPE
    End Get 
    Set(ByVal value As  String) 
         ValDOCTYPE= Value
    End Set 
    End Property 
'****************************************************************
Dim ValMANUAL  as  String
'****************************************************************
    Property MANUAL() as  String
    Get 
         Return  ValMANUAL
    End Get 
    Set(ByVal value As  String) 
         ValMANUAL= Value
    End Set 
    End Property 
'****************************************************************
Dim ValPROCEDURED  as  String
'****************************************************************
    Property PROCEDURED() as  String
    Get 
         Return  ValPROCEDURED
    End Get 
    Set(ByVal value As  String) 
         ValPROCEDURED= Value
    End Set 
    End Property 
'****************************************************************
Dim ValWORKIN  as  String
'****************************************************************
    Property WORKIN() as  String
    Get 
         Return  ValWORKIN
    End Get 
    Set(ByVal value As  String) 
         ValWORKIN= Value
    End Set 
    End Property 
'****************************************************************
Dim ValSTANDARD  as  String
'****************************************************************
    Property STANDARD() as  String
    Get 
         Return  ValSTANDARD
    End Get 
    Set(ByVal value As  String) 
         ValSTANDARD= Value
    End Set 
    End Property 
'****************************************************************
Dim ValRECORD  as  String
'****************************************************************
    Property RECORD() as  String
    Get 
         Return  ValRECORD
    End Get 
    Set(ByVal value As  String) 
         ValRECORD= Value
    End Set 
    End Property 
'****************************************************************
Dim ValKM  as  String
'****************************************************************
    Property KM() as  String
    Get 
         Return  ValKM
    End Get 
    Set(ByVal value As  String) 
         ValKM= Value
    End Set 
    End Property 
'****************************************************************
Dim ValORGJD  as  String
'****************************************************************
    Property ORGJD() as  String
    Get 
         Return  ValORGJD
    End Get 
    Set(ByVal value As  String) 
         ValORGJD= Value
    End Set 
    End Property 
'****************************************************************
Dim ValMANAGE  as  String
'****************************************************************
    Property MANAGE() as  String
    Get 
         Return  ValMANAGE
    End Get 
    Set(ByVal value As  String) 
         ValMANAGE= Value
    End Set 
    End Property
    '****************************************************************
    Dim ValSELECTSYSTEM As String
    '****************************************************************
    Property SELECTSYSTEM() As String
        Get
            Return ValSELECTSYSTEM
        End Get
        Set(ByVal value As String)
            ValSELECTSYSTEM = value
        End Set
    End Property
    '****************************************************************
    Dim ValACTCPYSel As String
    '****************************************************************
    Property ACTCPYSel() As String
        Get
            Return ValACTCPYSel
        End Get
        Set(ByVal value As String)
            ValACTCPYSel = value
        End Set
    End Property
    '****************************************************************
    Dim ValACTOBS  as  String
'****************************************************************
    Property ACTOBS() as  String
    Get 
         Return  ValACTOBS
    End Get 
    Set(ByVal value As  String) 
         ValACTOBS= Value
    End Set 
    End Property
    '****************************************************************
    Dim ValUndoDocSelect As String
    '****************************************************************
    Property UndoDocSelect() As String
        Get
            Return ValUndoDocSelect
        End Get
        Set(ByVal value As String)
            ValUndoDocSelect = value
        End Set
    End Property
    '****************************************************************
    Dim ValCTRPL  as  String
'****************************************************************
    Property CTRPL() as  String
    Get 
         Return  ValCTRPL
    End Get 
    Set(ByVal value As  String) 
         ValCTRPL= Value
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
Dim ValDOCNAME  as  String
'****************************************************************
    Property DOCNAME() as  String
    Get 
         Return  ValDOCNAME
    End Get 
    Set(ByVal value As  String) 
         ValDOCNAME= Value
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
Dim ValREVNO  as  Single
'****************************************************************
    Property REVNO() as  Single
    Get 
         Return  ValREVNO
    End Get 
    Set(ByVal value As  Single) 
         ValREVNO= Value
    End Set 
    End Property 
'****************************************************************
Dim ValEFFDATE  as  String
'****************************************************************
    Property EFFDATE() as  String
    Get 
         Return  ValEFFDATE
    End Get 
    Set(ByVal value As  String) 
         ValEFFDATE= Value
    End Set 
    End Property 
'****************************************************************
Dim ValDOCSHARE  as  String
'****************************************************************
    Property DOCSHARE() as  String
    Get 
         Return  ValDOCSHARE
    End Get 
    Set(ByVal value As  String) 
         ValDOCSHARE= Value
    End Set 
    End Property 
'****************************************************************
Dim ValREASON  as  String
'****************************************************************
    Property REASON() as  String
    Get 
         Return  ValREASON
    End Get 
    Set(ByVal value As  String) 
         ValREASON= Value
    End Set 
    End Property 
'****************************************************************
Dim ValTYPEATTFILE  as  String
'****************************************************************
    Property TYPEATTFILE() as  String
    Get 
         Return  ValTYPEATTFILE
    End Get 
    Set(ByVal value As  String) 
         ValTYPEATTFILE= Value
    End Set 
    End Property 
'****************************************************************
Dim ValMGRAPP  as  String
'****************************************************************
    Property MGRAPP() as  String
    Get 
         Return  ValMGRAPP
    End Get 
    Set(ByVal value As  String) 
         ValMGRAPP= Value
    End Set 
    End Property 
'****************************************************************
Dim ValMGRNAME  as  String
'****************************************************************
    Property MGRNAME() as  String
    Get 
         Return  ValMGRNAME
    End Get 
    Set(ByVal value As  String) 
         ValMGRNAME= Value
    End Set 
    End Property 
'****************************************************************
Dim ValMGRDATE  as  String
'****************************************************************
    Property MGRDATE() as  String
    Get 
         Return  ValMGRDATE
    End Get 
    Set(ByVal value As  String) 
         ValMGRDATE= Value
    End Set 
    End Property 
'****************************************************************
Dim ValMGRREASON  as  String
'****************************************************************
    Property MGRREASON() as  String
    Get 
         Return  ValMGRREASON
    End Get 
    Set(ByVal value As  String) 
         ValMGRREASON= Value
    End Set 
    End Property 
'****************************************************************
Dim ValPETITIONNAME  as  String
'****************************************************************
    Property PETITIONNAME() as  String
    Get 
         Return  ValPETITIONNAME
    End Get 
    Set(ByVal value As  String) 
         ValPETITIONNAME= Value
    End Set 
    End Property 
'****************************************************************
Dim ValPETITIONDATE  as  String
'****************************************************************
    Property PETITIONDATE() as  String
    Get 
         Return  ValPETITIONDATE
    End Get 
    Set(ByVal value As  String) 
         ValPETITIONDATE= Value
    End Set 
    End Property 
'****************************************************************
Dim ValPETITIONDEPT  as  String
'****************************************************************
    Property PETITIONDEPT() as  String
    Get 
         Return  ValPETITIONDEPT
    End Get 
    Set(ByVal value As  String) 
         ValPETITIONDEPT= Value
    End Set 
    End Property
    '****************************************************************
    Dim ValMGRID As String
    '****************************************************************
    Property MGRID() As String
        Get
            Return ValMGRID
        End Get
        Set(ByVal value As String)
            ValMGRID = value
        End Set
    End Property
    '****************************************************************
    Dim ValPETITIONID As String
    '****************************************************************
    Property PETITIONID() As String
        Get
            Return ValPETITIONID
        End Get
        Set(ByVal value As String)
            ValPETITIONID = value
        End Set
    End Property
    '****************************************************************
    Dim ValPETITIONBRANCH As String
    '****************************************************************
    Property PETITIONBRANCH() As String
        Get
            Return ValPETITIONBRANCH
        End Get
        Set(ByVal value As String)
            ValPETITIONBRANCH = value
        End Set
    End Property
    ' ****************************************************************
    Dim ValDocCtrl As String
    '****************************************************************
    Property DocCtrl() As String
        Get
            Return ValDocCtrl
        End Get
        Set(ByVal value As String)
            ValDocCtrl = value
        End Set
    End Property



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
             Sql="Insert Into QEa_DocSysItem ("
             Sql=Sql +" REFNO,"
             Sql=Sql +" REFNODATA,"
             Sql=Sql +" DARNO,"
             Sql=Sql +" STATUS,"
             Sql=Sql +" DOCTYPE,"
             Sql=Sql +" MANUAL,"
             Sql=Sql +" PROCEDURED,"
             Sql=Sql +" WORKIN,"
             Sql=Sql +" STANDARD,"
             Sql=Sql +" RECORD,"
             Sql=Sql +" KM,"
             Sql=Sql +" ORGJD,"
            Sql = Sql + " MANAGE,"
            '  Sql = Sql + " CheckDelete,"
            Sql = Sql + " SELECTSYSTEM,"
            Sql = Sql + " ACTCPYSel,"
            Sql =Sql +" ACTOBS,"
            Sql = Sql + " UndoDocSelect,"
            Sql =Sql +" CTRPL,"
             Sql=Sql +" DOCNO,"
             Sql=Sql +" DOCNAME,"
             Sql=Sql +" DOCDEPT,"
             Sql=Sql +" REVNO,"
             Sql=Sql +" EFFDATE,"
             Sql=Sql +" DOCSHARE,"
             Sql=Sql +" REASON,"
            Sql = Sql + " TYPEATTFILE,"
            Sql = Sql + " MGRID,"
            Sql =Sql +" MGRAPP,"
             Sql=Sql +" MGRNAME,"
             Sql=Sql +" MGRDATE,"
            Sql = Sql + " MGRREASON,"
            Sql = Sql + " PETITIONID,"
            Sql =Sql +" PETITIONNAME,"
             Sql=Sql +" PETITIONDATE,"
             Sql=Sql +" PETITIONDEPT,"
            Sql = Sql + " PETITIONBRANCH"
            ' Sql = Sql + " DocCtrl"
            Sql =Sql +" ) Values ("
             Sql=Sql +" '"&  REFNO & "',"
             Sql=Sql +" '"&  REFNODATA & "',"
             Sql=Sql +" '"&  DARNO & "',"
             Sql=Sql +" '"&  STATUS & "',"
             Sql=Sql +" '"&  DOCTYPE & "',"
             Sql=Sql +" '"&  MANUAL & "',"
             Sql=Sql +" '"&  PROCEDURED & "',"
             Sql=Sql +" '"&  WORKIN & "',"
             Sql=Sql +" '"&  STANDARD & "',"
             Sql=Sql +" '"&  RECORD & "',"
             Sql=Sql +" '"&  KM & "',"
             Sql=Sql +" '"&  ORGJD & "',"
            Sql = Sql + " '" & MANAGE & "',"
            ' Sql = Sql + " '" & CheckDelete & "',"
            Sql = Sql + " '" & SELECTSYSTEM & "',"
            Sql = Sql + " '" & ACTCPYSel & "',"
            Sql =Sql +" '"&  ACTOBS & "',"
            Sql = Sql + " '" & UndoDocSelect & "',"
            Sql =Sql +" '"&  CTRPL & "',"
             Sql=Sql +" '"&  DOCNO & "',"
             Sql=Sql +" '"&  DOCNAME & "',"
             Sql=Sql +" '"&  DOCDEPT & "',"
            Sql = Sql + "  " & REVNO & " ,"
            Sql =Sql +" '"&  EFFDATE & "',"
             Sql=Sql +" '"&  DOCSHARE & "',"
             Sql=Sql +" '"&  REASON & "',"
            Sql = Sql + " '" & TYPEATTFILE & "',"
            Sql = Sql + " '" & MGRID & "',"
            Sql =Sql +" '"&  MGRAPP & "',"
             Sql=Sql +" '"&  MGRNAME & "',"
             Sql=Sql +" '"&  MGRDATE & "',"
            Sql = Sql + " '" & MGRREASON & "',"
            Sql = Sql + " '" & PETITIONID & "',"
            Sql =Sql +" '"&  PETITIONNAME & "',"
             Sql=Sql +" '"&  PETITIONDATE & "',"
             Sql=Sql +" '"&  PETITIONDEPT & "',"
            Sql = Sql + " '" & PETITIONBRANCH & "'"
            'Sql = Sql + " '" & DocCtrl & "'"
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
             Sql="Update QEa_DocSysItem Set "
             Sql=Sql+" REFNO ='"& REFNO &"',"
             Sql=Sql+" REFNODATA ='"& REFNODATA &"',"
             Sql=Sql+" DARNO ='"& DARNO &"',"
            ' Sql=Sql+" STATUS ='"& STATUS &"',"
            Sql =Sql+" DOCTYPE ='"& DOCTYPE &"',"
             Sql=Sql+" MANUAL ='"& MANUAL &"',"
             Sql=Sql+" PROCEDURED ='"& PROCEDURED &"',"
             Sql=Sql+" WORKIN ='"& WORKIN &"',"
             Sql=Sql+" STANDARD ='"& STANDARD &"',"
             Sql=Sql+" RECORD ='"& RECORD &"',"
             Sql=Sql+" KM ='"& KM &"',"
             Sql=Sql+" ORGJD ='"& ORGJD &"',"
            Sql = Sql + " MANAGE ='" & MANAGE & "',"
            ' Sql = Sql + " CheckDelete ='" & CheckDelete & "',"
            Sql = Sql + " SELECTSYSTEM ='" & SELECTSYSTEM & "',"
            Sql = Sql + " ACTCPYSel ='" & ACTCPYSel & "',"
            Sql =Sql+" ACTOBS ='"& ACTOBS &"',"
            Sql = Sql + " UndoDocSelect ='" & UndoDocSelect & "',"
            Sql =Sql+" CTRPL ='"& CTRPL &"',"
             Sql=Sql+" DOCNO ='"& DOCNO &"',"
             Sql=Sql+" DOCNAME ='"& DOCNAME &"',"
             Sql=Sql+" DOCDEPT ='"& DOCDEPT &"',"
             Sql=Sql+" REVNO ="& REVNO &","
             Sql=Sql+" EFFDATE ='"& EFFDATE &"',"
             Sql=Sql+" DOCSHARE ='"& DOCSHARE &"',"
             Sql=Sql+" REASON ='"& REASON &"',"
            Sql = Sql + " TYPEATTFILE ='" & TYPEATTFILE & "',"
            Sql = Sql + " MGRID ='" & MGRID & "',"
            Sql =Sql+" MGRAPP ='"& MGRAPP &"',"
             Sql=Sql+" MGRNAME ='"& MGRNAME &"',"
             Sql=Sql+" MGRDATE ='"& MGRDATE &"',"
            Sql = Sql + " MGRREASON ='" & MGRREASON & "',"
            Sql = Sql + " PETITIONID ='" & PETITIONID & "',"
            Sql =Sql+" PETITIONNAME ='"& PETITIONNAME &"',"
             Sql=Sql+" PETITIONDATE ='"& PETITIONDATE &"',"
             Sql=Sql+" PETITIONDEPT ='"& PETITIONDEPT &"',"
            Sql = Sql + " PETITIONBRANCH ='" & PETITIONBRANCH & "'"
            ' Sql = Sql + " DocCtrl ='" & DocCtrl & "'"
            Sql = Sql + "Where REFNO= '" & REFNO & "' AND REFNODATA = '" & REFNODATA & "' "
            Return Sql
   Catch ex As Exception 

   End Try

End Function 

'****************************************************************
Public Function GetData(SqlCommand as String ,Cnn as SqlClient.SqlConnection)as Boolean 
Dim Cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand(Sqlcommand, Cnn)
        Dim Dr As SqlClient.SqlDataReader = Cmd.ExecuteReader
        ' Dr.Close()
        ' Dr = Nothing
        CleareData()
    While Dr.Read
            REFNO = Dr.Item("REFNO")
            REFNODATA = Dr.Item("REFNODATA")
            DARNO = Dr.Item("DARNO")
            STATUS = Dr.Item("STATUS")
            DOCTYPE = Dr.Item("DOCTYPE")
            MANUAL = Dr.Item("MANUAL")
            PROCEDURED = Dr.Item("PROCEDURED")
            WORKIN = Dr.Item("WORKIN")
            STANDARD = Dr.Item("STANDARD")
            RECORD = Dr.Item("RECORD")
            KM = Dr.Item("KM")
            ORGJD = Dr.Item("ORGJD")
            MANAGE = Dr.Item("MANAGE")
            ' CheckDelete = Dr.Item("CheckDelete")
            SELECTSYSTEM = Dr.Item("SELECTSYSTEM")
            ACTCPYSel = Dr.Item("ACTCPYSel")
            ACTOBS = Dr.Item("ACTOBS")
            UndoDocSelect = Dr.Item("UndoDocSelect")
            CTRPL = Dr.Item("CTRPL")
            DOCNO = Dr.Item("DOCNO")
            DOCNAME = Dr.Item("DOCNAME")
            DOCDEPT = Dr.Item("DOCDEPT")
            REVNO = Dr.Item("REVNO")
            EFFDATE = Dr.Item("EFFDATE")
            DOCSHARE = Dr.Item("DOCSHARE")
            REASON = Dr.Item("REASON")
            TYPEATTFILE = Dr.Item("TYPEATTFILE")
            MGRID = Dr.Item("MGRID")
            MGRAPP = Dr.Item("MGRAPP")
            MGRNAME = Dr.Item("MGRNAME")
            MGRDATE = Dr.Item("MGRDATE")
            MGRREASON = Dr.Item("MGRREASON")
            PETITIONID = Dr.Item("PETITIONID")
            PETITIONNAME = Dr.Item("PETITIONNAME")
            PETITIONDATE = Dr.Item("PETITIONDATE")
            PETITIONDEPT = Dr.Item("PETITIONDEPT")
            PETITIONBRANCH = Dr.Item("PETITIONBRANCH")
            'DocCtrl = Dr.Item("DocCtrl")
        End While
        Dr.Close 
    Dr=Nothing 

End Function 
'****************************************************************
Public Function CleareData() as Boolean 
        REFNO=Nothing
        REFNODATA=Nothing
        DARNO=Nothing
        STATUS=Nothing
        DOCTYPE=Nothing
        MANUAL=Nothing
        PROCEDURED=Nothing
        WORKIN=Nothing
        STANDARD=Nothing
        RECORD=Nothing
        KM=Nothing
        ORGJD=Nothing
        MANAGE = Nothing
        ' CheckDelete = Nothing
        SELECTSYSTEM = Nothing
        ACTCPYSel = Nothing
        ACTOBS =Nothing
        UndoDocSelect = Nothing
        CTRPL =Nothing
        DOCNO=Nothing
        DOCNAME=Nothing
        DOCDEPT=Nothing
        REVNO=Nothing
        EFFDATE=Nothing
        DOCSHARE=Nothing
        REASON=Nothing
        TYPEATTFILE = Nothing
        MGRID = Nothing
        MGRAPP =Nothing
        MGRNAME=Nothing
        MGRDATE=Nothing
        MGRREASON = Nothing
        PETITIONID = Nothing
        PETITIONNAME =Nothing
        PETITIONDATE=Nothing
        PETITIONDEPT=Nothing
        PETITIONBRANCH = Nothing
        ' DocCtrl = Nothing

    End Function

    '****************************************************************
    'Public Function AppendData() as boolean 
    '      Try
    '       With  C_QEa_DocSysItem
    '               .REFNO=TxtREFNO.Text
    '               .REFNODATA=TxtREFNODATA.Text
    '               .DARNO=TxtDARNO.Text
    '               .STATUS=TxtSTATUS.Text
    '               .DOCTYPE=TxtDOCTYPE.Text
    '               .MANUAL=TxtMANUAL.Text
    '               .PROCEDURED=TxtPROCEDURED.Text
    '               .WORKIN=TxtWORKIN.Text
    '               .STANDARD=TxtSTANDARD.Text
    '               .RECORD=TxtRECORD.Text
    '               .KM=TxtKM.Text
    '               .ORGJD=TxtORGJD.Text
    '               .MANAGE=TxtMANAGE.Text
    '               .ACTNEW=TxtACTNEW.Text
    '               .ACTAMD=TxtACTAMD.Text
    '               .ACTOBS=TxtACTOBS.Text
    '               .ACTCPY=TxtACTCPY.Text
    '               .CTRPL=TxtCTRPL.Text
    '               .DOCNO=TxtDOCNO.Text
    '               .DOCNAME=TxtDOCNAME.Text
    '               .DOCDEPT=TxtDOCDEPT.Text
    '               .REVNO=TxtREVNO.Text
    '               .EFFDATE=TxtEFFDATE.Text
    '               .DOCSHARE=TxtDOCSHARE.Text
    '               .REASON=TxtREASON.Text
    '               .TYPEATTFILE=TxtTYPEATTFILE.Text
    '               .MGRAPP=TxtMGRAPP.Text
    '               .MGRNAME=TxtMGRNAME.Text
    '               .MGRDATE=TxtMGRDATE.Text
    '               .MGRREASON=TxtMGRREASON.Text
    '               .PETITIONNAME=TxtPETITIONNAME.Text
    '               .PETITIONDATE=TxtPETITIONDATE.Text
    '               .PETITIONDEPT=TxtPETITIONDEPT.Text
    '               .PETITIONBRANCH=TxtPETITIONBRANCH.Text

    '       End with 
    '      Catch ex As Exception 
    'End Try 
    'End Function 

End Class