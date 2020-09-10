/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [BookingId]
      ,[CustomerId]
      ,[MovieId]
      ,[BookingNumber]
      ,[Quantity]
  FROM [Cinema].[dbo].[Booking]

  /****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [MovieId]
      ,[Title]
      ,[Price]
  FROM [Cinema].[dbo].[Movie]

  /****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [CustomerId]
      ,[Mail]
      ,[FirstName]
      ,[LastName]
  FROM [Cinema].[dbo].[Customer]