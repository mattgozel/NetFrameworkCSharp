use master
go

alter database HotelReservationSchema set single_user with rollback immediate;
go

drop database HotelReservationSchema;

create database HotelReservationSchema
go

use HotelReservationSchema
go

create table RoomType (
	RoomTypeID int primary key identity(1,1),
	RoomType varchar(30) not null
)
go

create table RoomAmenities (
	RoomAmenitiesID int primary key identity(1,1),
	RoomAmenities varchar(30) not null
)
go

create table RoomRate (
	RoomRateID int primary key identity(1,1),
	RoomRate money not null
)
go

create table Rooms (
	RoomID int primary key identity(1,1),
	[Floor] int not null,
	OccupancyLimit int not null,
	RoomTypeID int foreign key references RoomType(RoomTypeID) not null,
	RoomAmenitiesID int foreign key references RoomAmenities(RoomAmenitiesID) not null,
	RoomRateID int foreign key references RoomRate(RoomRateID) not null
)
go

create table Customer (
	CustomerID int primary key identity(1,1),
	FirstName nvarchar(30) not null,
	LastName nvarchar(30) not null,
	Phone nvarchar(15) not null,
	Email nvarchar(45) not null,
	Street nvarchar(100) null,
	City nvarchar(30) null,
	[State] char(2) null,
	ZipCode varchar(5) null,
	Country nvarchar(30) null
)
go

create table PromotionCode (
	PromotionCodeID int primary key identity(1,1),
	PromotionCodeName nvarchar(30) not null,
	StartDate date not null,
	EndDate date null,
	Discount nvarchar(5) not null
)
go

create table Reservations (
	ReservationID int primary key identity(1,1),
	CustomerID int foreign key references Customer(CustomerID) not null,
	StartDate date not null,
	EndDate date not null,
	RoomID int foreign key references Rooms(RoomID) not null,
	PromotionCodeID int foreign key references PromotionCode(PromotionCodeID)
)
go

create table Guests (
	GuestID int primary key identity(1,1),
	ReservationID int foreign key references Reservations(ReservationID) not null,
	FirstName nvarchar(30) not null,
	LastName nvarchar(30) not null,
	Age int not null
)
go

create table GuestAddOns (
	GuestAddOnsID int primary key identity(1,1),
	GuestAddOns nvarchar(30) not null,
	GuestAddOnsPricing money not null,
	CustomerID int foreign key references Customer(CustomerID) not null
)
go

create table Billing (
	BillingID int primary key identity(1,1),
	Tax int not null,
	Total money not null,
	CustomerID int foreign key references Customer(CustomerID) not null
)
go

create table BillingDetails (
	BillingID int primary key foreign key references Billing(BillingID) not null,
	RoomRateID int foreign key references RoomRate(RoomRateID) not null,
	RoomRate money not null,
	GuestAddOnsID int foreign key references GuestAddOns(GuestAddOnsID) not null,
	GuestAddOnsPricing money not null
)
go