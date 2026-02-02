with AvgM2ByDept AS(
	SELECT Department,AVG(M2) AS AvgM2
	FROM CollegeMaster
	GROUP BY Department
)
SELECT * FROM AvgM2ByDept;


SELECT DISTINCT m1
FROM CollegeMaster
ORDER BY m1 DESC
OFFSET 2 ROWS
FETCH NEXT 1 ROW ONLY;


SELECT Department,SUM(m1) AS TOT 
FROM CollegeMaster
GROUP BY Department
ORDER BY TOT DESC
OFFSET 0 ROWS
FETCH NEXT 1 ROW ONLY;

