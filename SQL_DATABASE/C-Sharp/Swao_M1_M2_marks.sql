use _1_MasterCampus
go

select * from [dbo].[CollegeMaster]

update [dbo].[CollegeMaster] set M1=M1+M2
update [dbo].[CollegeMaster] set M2=M1-M2
update [dbo].[CollegeMaster] set M1=M1-M2

select * from [dbo].[CollegeMaster]