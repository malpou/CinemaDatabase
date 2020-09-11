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
	INSERT INTO Customer (Mail, FirstName)
	Values ('CutomerA@Mail.com', 'User A')
	INSERT INTO Customer (Mail)
	Values ('CustomerQ@Mail.com')
	INSERT INTO Customer (Mail, FirstName, LastName)
	Values ('CustomerE@Mail.com', 'User', 'E')
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
	INSERT INTO Movie (Title, Price)
	VALUES ('Harry Potter og De Vises Sten', 64)
	INSERT INTO Movie (Title, Price)
	VALUES ('Harry Potter og Hemmelighedernes Kammer', 63)
	INSERT INTO Movie (Title, Price)
	VALUES ('Harry Potter og Fangen fra Azkaban', 82)
	INSERT INTO Movie (Title, Price)
	VALUES ('Harry Potter og Flammernes Pokal', 81)
	INSERT INTO Movie (Title, Price)
	VALUES ('Harry Potter og Fønixordenen', 71)
	INSERT INTO Movie (Title, Price)
	VALUES ('Harry Potter og Halvblodsprinsen', 78)
	INSERT INTO Movie (Title, Price)
	VALUES ('Harry Potter og Dødsregalierne – Del 1', 65)
	INSERT INTO Movie (Title, Price)
	VALUES ('Harry Potter og Dødsregalierne – Del 2', 87)
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