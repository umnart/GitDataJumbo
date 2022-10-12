SELECT        TOP (100) PERCENT dbo.QEa_Training_History.EmployeeNo, dbo.QEa_Training_History.DOCNO, dbo.QEa_Training_History.REVNO, dbo.QEa_Training_History.DOCDEPT, dbo.QEa_Training_History.MD, 
                         dbo.QEa_Training_History.EFFDATE, dbo.QEa_Training_History.MthdCode, dbo.QEa_Training_History.TrnnDate, dbo.QEa_Training_History.Result, dbo.QEa_Training_History.Approve, dbo.QEa_Training_History.Remark, 
                         dbo.QEa_Training_History.Dept, dbo.QEa_Training_Assign.StartDate
FROM            dbo.QEa_Training_History LEFT OUTER JOIN
                         dbo.QEa_Training_Assign ON dbo.QEa_Training_History.EmployeeNo = dbo.QEa_Training_Assign.EmployeeNo AND dbo.QEa_Training_History.DOCNO = dbo.QEa_Training_Assign.DOCNO AND 
                         dbo.QEa_Training_History.Dept = dbo.QEa_Training_Assign.Dept
WHERE        (dbo.QEa_Training_History.EFFDATE >= CONVERT(DATETIME, '2021-01-01 00:00:00', 102)) AND (dbo.QEa_Training_History.Result = 0) AND (dbo.QEa_Training_History.Dept = 'IT') AND 
                         (dbo.QEa_Training_Assign.StartDate >= CONVERT(DATETIME, '2006-01-01 00:00:00', 102))
ORDER BY dbo.QEa_Training_History.DOCNO, dbo.QEa_Training_History.REVNO