--select *, CONVERT(DATE,StartDate,105) AS tEST FROM QEa_Training_Person
--where CONVERT(DATE,StartDate,105) between  '2006-01-01'  and '2006-12-31'
--ORDER BY MD,StartDate





--SELECT    QEa_Training_Assign.EmployeeNo, qEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT,QEa_Training_Assign.MthdCode,QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, 
--                         MAX(QEa_CourseMaster.REVNO) AS MAXREVNO, MAX(QEa_CourseMaster.EFFDATE) as MAXEFFDATE ,CONVERT(DATE,QEa_CourseMaster.EFFDATE,105) AS CONVERTDATE 
--FROM            QEa_Training_Assign LEFT OUTER JOIN
--                         QEa_CourseMaster ON QEa_Training_Assign.DOCNO = QEa_CourseMaster.DOCNO AND QEa_Training_Assign.DOCDEPT = QEa_CourseMaster.DOCDEPT
--GROUP BY QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT,QEa_Training_Assign.MthdCode,QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, QEa_CourseMaster.REVNO, 
--                         QEa_CourseMaster.EFFDATE
--HAVING         EmployeeNo ='A499365'
--AND CONVERT(DATE,QEa_CourseMaster.EFFDATE,105)  > '2006-12-01'


--SELECT    QEa_Training_Assign.EmployeeNo, qEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT,QEa_Training_Assign.MthdCode,QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, "
--   Sql = Sql + "                        MAX(QEa_CourseMaster.REVNO) AS MAXREVNO, MAX(QEa_CourseMaster.EFFDATE) as MAXEFFDATE ,CONVERT(DATE,QEa_CourseMaster.EFFDATE,105) AS CONVERTDATE "
--  Sql = Sql + "FROM            QEa_Training_Assign LEFT OUTER JOIN  QEa_CourseMaster ON QEa_Training_Assign.DOCNO = QEa_CourseMaster.DOCNO AND QEa_Training_Assign.DOCDEPT = QEa_CourseMaster.DOCDEPT"
--  Sql = Sql + "GROUP BY QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT,QEa_Training_Assign.MthdCode,QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, QEa_CourseMaster.REVNO, "
--  Sql = Sql + " QEa_CourseMaster.EFFDATE"
--  Sql = Sql + "HAVING EmployeeNo ='A499365'"
--  Sql = Sql + "AND CONVERT(DATE,QEa_CourseMaster.EFFDATE,105)  <= '2006-12-01'"



--SELECT    QEa_Training_Assign.EmployeeNo, qEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT,QEa_Training_Assign.MthdCode,QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, 
--                         MAX(QEa_CourseMaster.REVNO) AS MAXREVNO, MAX(QEa_CourseMaster.EFFDATE) as MAXEFFDATE ,CONVERT(DATE,QEa_CourseMaster.EFFDATE,105) AS CONVERTDATE 
--FROM            QEa_Training_Assign LEFT OUTER JOIN
--                         QEa_CourseMaster ON QEa_Training_Assign.DOCNO = QEa_CourseMaster.DOCNO AND QEa_Training_Assign.DOCDEPT = QEa_CourseMaster.DOCDEPT
--GROUP BY QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT,QEa_Training_Assign.MthdCode,QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS,MAX(QEa_CourseMaster.REVNO), MAX(QEa_CourseMaster.EFFDATE)
                     
--HAVING         EmployeeNo ='A499365'
--AND CONVERT(DATE,QEa_CourseMaster.EFFDATE,105) <= '2006-12-01'
--AND STATUS ='A'






SELECT        dbo.QEa_Training_Assign.EmployeeNo, dbo.QEa_Training_Assign.DOCNO, dbo.QEa_CourseMaster.DOCNAME, dbo.QEa_Training_Assign.DOCDEPT, dbo.QEa_Training_Assign.MthdCode, dbo.QEa_Training_Assign.Approve, 
                         dbo.QEa_CourseMaster.STATUS, MAX(dbo.QEa_CourseMaster.REVNO) AS MAXREVNO, MAX(dbo.QEa_CourseMaster.EFFDATE) AS MAXEFFDATE
FROM            dbo.QEa_Training_Assign LEFT OUTER JOIN
                         dbo.QEa_CourseMaster ON dbo.QEa_Training_Assign.DOCNO = dbo.QEa_CourseMaster.DOCNO AND dbo.QEa_Training_Assign.DOCDEPT = dbo.QEa_CourseMaster.DOCDEPT
WHERE	CONVERT(DATE,QEa_CourseMaster.EFFDATE,105) <= '2006-12-01'
GROUP BY dbo.QEa_Training_Assign.EmployeeNo, dbo.QEa_Training_Assign.DOCNO, dbo.QEa_CourseMaster.DOCNAME, dbo.QEa_Training_Assign.DOCDEPT, dbo.QEa_Training_Assign.MthdCode, dbo.QEa_Training_Assign.Approve, 
                         dbo.QEa_CourseMaster.STATUS
HAVING        (dbo.QEa_Training_Assign.EmployeeNo = 'A499365') AND (dbo.QEa_CourseMaster.STATUS = 'A')


SELECT QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT, QEa_Training_Assign.MthdCode, QEa_Training_Assign.Approve, 
                         QEa_CourseMaster.STATUS, QEa_CourseMaster.REVNO , QEa_CourseMaster.EFFDATE
FROM            QEa_Training_Assign LEFT OUTER JOIN QEa_CourseMaster ON QEa_Training_Assign.DOCNO = QEa_CourseMaster.DOCNO AND QEa_Training_Assign.DOCDEPT = QEa_CourseMaster.DOCDEPT
WHERE	CONVERT(DATE,QEa_CourseMaster.EFFDATE,105) > '2006-12-01'
AND        (QEa_Training_Assign.EmployeeNo = 'A499365') AND (QEa_CourseMaster.STATUS = 'A')
ORDER BY QEa_Training_Assign.DOCNO ,QEa_CourseMaster.REVNO