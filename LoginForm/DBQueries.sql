create database InvoiceDB;
Use InvoiceDB;

Create table Users(
	UserId int primary key,
    Name nvarchar(200) not null,
    Password nvarchar(200) not null,
    Email nvarchar(256) not null,
    CreatedOn datetime default CURRENT_TIMESTAMP,
    LastLoginOn datetime);
    
Insert into Users(UserId,Name,Password,Email) Values(1,'sandeep','deep','sandeep.sappal96@gmail.com');
    
    
create table Invoices
(
    GRNo int auto_increment unique,
    Date	datetime default current_timestamp not null,
    VehicalNo nvarchar(250) not null,
    LocationFrom nvarchar(250) not null,
    LocationTo nvarchar(250) not null,
    GoodsValue decimal not null,
    InvoiceNo nvarchar(250) not null,
    GSTType nvarchar(250) not null,
    ConsignerName nvarchar(250) not null,
    ConsignerGSTNo nvarchar(250),
    ConsignerMobile nvarchar(250) not null,
    ConsignerEmail nvarchar(250),
    ConsignerState nvarchar(250) not null,
    ConsignerCity nvarchar(250) not null,
    ConsignerAddress text not null,
    ConsigneeName nvarchar(250) not null,
    ConsigneeGSTNo nvarchar(250),
    ConsigneeMobile nvarchar(250) not null,
    ConsigneeEmail nvarchar(250),
    ConsigneeState nvarchar(250) not null,
    ConsigneeCity nvarchar(250) not null,
    ConsigneeAddress text not null
);
    
    