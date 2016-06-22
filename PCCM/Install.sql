use master
go
drop database dbPccm
go
create database dbPccm
go
use dbPccm
go

CREATE TABLE tbMember
  (
    MemberID      INT IDENTITY (1,1) PRIMARY KEY,
    FirstName     VARCHAR(MAX),
    LastName      VARCHAR(MAX),
    Address       VARCHAR(MAX),
    City          VARCHAR(MAX),
    PhoneNumber   VARCHAR(MAX),
    UserName      VARCHAR(MAX),
    Password      VARCHAR(MAX),
    AccessLevel   BIT  --0 = ADMIN , 1 = MEMBER
  )
-- insert into member
INSERT INTO tbMember(FirstName,LastName,Address,City,PhoneNumber,UserName,Password,AccessLevel) VALUES 
--insert for admin
('earl','lagaya','595 fleming avenue','winnipeg','204-504-7276','earllagaya','adminpassword',0),
--insert for member
('random','random','random','random','222-222-2222','random','random',1)
go
create proc spLogin
  (
  @UserName VARCHAR(MAX),
  @Password VARCHAR(MAX)
  )
  AS BEGIN 
    IF EXISTS (SELECT UserName, Password FROM tbMember where UserName = @UserName and Password = @Password)
	  BEGIN 
	    SELECT * FROM tbMember where UserName = @UserName and Password = @Password
	  END
	ELSE
	  BEGIN
	   SELECT 'INVALID' AS UserName
	  END
	END
GO
