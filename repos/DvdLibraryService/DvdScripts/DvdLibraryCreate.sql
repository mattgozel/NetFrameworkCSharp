use master
go

alter database Dvds set single_user with rollback immediate;
go

drop database Dvds;

create database Dvds
go

use Dvds
go

create table Dvd (
	DvdID int primary key identity(1, 1),
	Title varchar(30) not null,
	ReleaseYear int,
	Director varchar(30),
	Rating nvarchar(10),
	Notes nvarchar(200)
)
go