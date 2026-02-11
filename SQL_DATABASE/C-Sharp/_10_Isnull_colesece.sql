select * from contact_stu;

select name,isnull(email,'no email give') from contact_stu;

select name, COALESCE(email,fatherphone,motherphone,'No contact rovided') from contact_stu; 