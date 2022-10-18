create database InvoiceDB
Use InvoiceDB

Create table Users(
	UserId int primary key,
    Name nvarchar(200) not null,
    Password nvarchar(200) not null,
    Email nvarchar(256) not null,
    CreatedOn datetime default CURRENT_TIMESTAMP,
    LastLoginOn datetime)
    
    
Create table Invoices(
	InvoiceId int primary key,
    
)
    
    