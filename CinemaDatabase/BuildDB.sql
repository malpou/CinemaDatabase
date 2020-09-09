USE master
IF EXISTS(select * from sys.databases WHERE NAME='cinema')
DROP DATABASE cinema

CREATE DATABASE cinema
USE cinema;

DROP TABLE IF EXISTS customers;
GO
CREATE TABLE customers(
	id int,
	name Varchar);

SELECT * FROM dbo.customers;