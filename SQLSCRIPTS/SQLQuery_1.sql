USE master
GO
IF NOT EXISTS (
 SELECT name
 FROM sys.databases
 WHERE name = N'Direct-Messages'
)
 CREATE DATABASE [Direct-Messages];
GO
IF SERVERPROPERTY('ProductVersion') > '12'
 ALTER DATABASE [Direct-Messages] SET QUERY_STORE=ON;
GO

create table dbo.Users(
    UserId int not null primary key, 
    username nvarchar(60) not null, 
    password nvarchar(100) not null, 
    
);
go
