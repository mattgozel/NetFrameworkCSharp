use Dvds
go

if exists (select * from INFORMATION_SCHEMA.ROUTINES where ROUTINE_NAME = 'SelectAllDvds')
drop procedure SelectAllDvds
go

create procedure SelectAllDvds
as
select * from Dvd
go

if exists (select * from INFORMATION_SCHEMA.ROUTINES where ROUTINE_NAME = 'SelectDvdByID')
drop procedure SelectDvdByID
go

create procedure SelectDvdByID (@DvdID int)
as
select * from Dvd
where DvdID = @DvdID
go

if exists (select * from INFORMATION_SCHEMA.ROUTINES where ROUTINE_NAME = 'InsertDvd')
drop procedure InsertDvd
go

create procedure InsertDvd(@Title varchar(30), @ReleaseYear int, @Director varchar(30), @Rating nvarchar(10), @Notes nvarchar(200))
as
insert into Dvd (Title, ReleaseYear, Director, Rating, Notes)
values (@Title, @ReleaseYear, @Director, @Rating, @Notes)

go

if exists (select * from INFORMATION_SCHEMA.ROUTINES where ROUTINE_NAME = 'UpdateDvd')
drop procedure UpdateDvd
go

create procedure UpdateDvd(@DvdID int, @Title varchar(30), @ReleaseYear int, @Director varchar(30), @Rating nvarchar(10), @Notes nvarchar(200))
as
update Dvd
set Title = @Title,
	ReleaseYear = @ReleaseYear,
	Director = @Director,
	Rating = @Rating,
	Notes = @Notes
where DvdID = @DvdID
go

if exists (select * from INFORMATION_SCHEMA.ROUTINES where ROUTINE_NAME = 'DeleteDvd')
drop procedure DeleteDvd
go

create procedure DeleteDvd (@DvdID int)
as
delete from Dvd
where DvdID = @DvdID
go