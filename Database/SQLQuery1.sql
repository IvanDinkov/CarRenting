Create Database CarRenting;
create table accounts (id int primary key identity not null,
 firstname varchar(15) not null,
 lastname varchar(15) not null,
 username varchar(16)  not null  unique,
 password varchar(16) not null);
 Select * from accounts;

create table cars (id int primary key identity not null, 
brand varchar(10) not null,
model varchar(20) not null,
car_type varchar(10) not null,
price_per_day decimal(10,2) not null,
fuel_consumption varchar(10) not null,
transmission varchar(10) not null,
door_count int not null,
seat_count int not null,
taken_by int,
picture image);

select * from cars;