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

create table Amenities (
	AmenitiesID int primary key identity(1,1),
	Amenities varchar(30) not null
)
go

create table Rate (
	RateID int primary key identity(1,1),
	Rate money not null
)
go

create table Rooms (
	RoomID int primary key identity(1,1),
	[Floor] int not null,
	OccupancyLimit int not null,
	RoomTypeID int foreign key references RoomType(RoomTypeID) not null,
	AmenitiesID int foreign key references Amenities(AmenitiesID) not null,
	RateID int foreign key references Rate(RateID) not null
)
go

create table AmenitiesRooms (
	AmenitiesID int foreign key references Amenities(AmenitiesID) not null,
	RoomID int foreign key references Rooms(RoomID) not null
)
go

alter table AmenitiesRooms
add constraint PK_AmenitiesRooms
primary key (AmenitiesID, RoomID)

create table RateRooms (
	RateID int foreign key references Rate(RateID) not null,
	RoomID int foreign key references Rooms(RoomID) not null
)
go

alter table RateRooms
add constraint PK_RateRooms
primary key (RateID, RoomID)

create table Customer (
	CustomerID int primary key identity(1,1),
	FirstName nvarchar(30) not null,
	LastName nvarchar(30) not null,
	Phone nvarchar(15) not null,
	Email nvarchar(45) not null,
	Age int not null,
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

create table BillingAddOns (
	BillingAddOnsID int primary key identity(1,1),
	BillingAddOns nvarchar(30) not null,
	BillingAddOnsPricing money not null,
	CustomerID int foreign key references Customer(CustomerID) not null
)
go

create table BillingAddOnsCustomer (
	BillingAddOnsID int foreign key references BillingAddOns(BillingAddOnsID) not null,
	CustomerID int foreign key references Customer(CustomerID) not null
)
go

alter table BillingAddOnsCustomer
add constraint PK_BillingAddOnsCustomer
primary key (BillingAddOnsID, CustomerID)

create table Billing (
	BillingID int primary key identity(1,1),
	Tax int not null,
	Total money not null,
	CustomerID int foreign key references Customer(CustomerID) not null
)
go

alter table Customer
add BillingID int foreign key references Billing(BillingID) not null;

create table BillingDetails (
	BillingID int primary key foreign key references Billing(BillingID) not null,
	RateID int foreign key references Rate(RateID) not null,
	RoomRate money not null,
	BillingAddOnsID int foreign key references BillingAddOns(BillingAddOnsID) not null,
	BillingAddOnsPricing money not null
)
go

create table CustomerReservations (
	CustomerID int foreign key references Customer(CustomerID) not null,
	ReservationID int foreign key references Reservations(ReservationID) not null
)
go

alter table CustomerReservations
add constraint PK_CustomerReservations
primary key (CustomerID, ReservationID)
go