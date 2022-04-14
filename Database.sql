----------------------------------------------------
--
-- Dao Hai Nam, http://www.daohainam.com
--
----------------------------------------------------

CREATE DATABASE Demo3Tiers
GO

USE Demo3Tiers
GO

CREATE TABLE LoginUser
(
	LoginName NVARCHAR (30) CONSTRAINT pk_LoginUser PRIMARY KEY,
	LoginPassword NVARCHAR (30) NOT NULL
)
GO

CREATE TABLE Book
(
	BookId UNIQUEIDENTIFIER CONSTRAINT pk_Book PRIMARY KEY,
	Title NVARCHAR (200) NOT NULL,
	Author NVARCHAR (200) NOT NULL,
	Price FLOAT NOT NULL CONSTRAINT chk_Price_Is_NonNegative CHECK (Price >= 0)
)
GO

INSERT INTO LoginUser VALUES ('admin', 'admin')
INSERT INTO LoginUser VALUES ('guest', 'guest')

INSERT INTO Book VALUES (NEWID(), N'Debugging Applications for Microsoft .NET and Microsoft Windows', N'John Robbins', 58.97)
INSERT INTO Book VALUES (NEWID(), N'Windows via C/C++', N'Jeffrey M. Richter, Christophe Nasarre', 44.09)
INSERT INTO Book VALUES (NEWID(), N'Windows System Programming (4th Edition)', N'Johnson M. Hart', 54.59)
INSERT INTO Book VALUES (NEWID(), N'Developing Drivers with the Windows Driver Foundation', N'Penny Orwick, Guy Smith', 37.79)
GO