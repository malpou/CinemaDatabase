IF NOT EXISTS(SELECT *
FROM sys.databases
WHERE name = 'Cinema')
BEGIN
	CREATE DATABASE Cinema
END

GO

USE Cinema

GO

IF NOT EXISTS(SELECT *
FROM sysobjects
WHERE name='Customer')
BEGIN
	CREATE TABLE Customer
	(
		CustomerId int IDENTITY(100,1) PRIMARY KEY,
		Mail VARCHAR(100) NOT NULL,
		FirstName VARCHAR(100),
		LastName VARCHAR(100)
	)
END

IF NOT EXISTS(SELECT *
FROM sysobjects
WHERE name='Movie')
BEGIN
	CREATE TABLE Movie
	(
		MovieId int IDENTITY(100,1) PRIMARY KEY,
		Title VARCHAR(100) NOT NULL,
		Price int NOT NULL
	)
END

IF NOT EXISTS(SELECT *
FROM sysobjects
WHERE name='Booking')
BEGIN
	CREATE TABLE Booking
	(
		BookingId int IDENTITY(100,1) PRIMARY KEY,
		CustomerId int FOREIGN KEY REFERENCES Customer(CustomerId),
		MovieId int FOREIGN KEY REFERENCES Movie(MovieId),
		BookingNumber int NOT NULL,
		Quantity int NOT NULL
	)
END