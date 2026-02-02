create procedure USP_PASSBYGRACE_1
AS
BEGIN
update #m1_marks set m1 = m1+5 where m1<35
select * from #m1_marks
END