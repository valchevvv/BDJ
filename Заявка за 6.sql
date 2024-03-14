create database bdz12v_1	

use bdz12v_1

create table Cities(
id int primary key IDENTITY,
name nvarchar(40)
)

create table Trains(
id int primary key IDENTITY,
places int,
type nvarchar(20)
)

create table Routes(
id int primary key IDENTITY,
train int foreign key references Trains(id),
start_date datetime,
end_date datetime,
normal_price decimal,
first_class decimal default null,
sleeper_class decimal default null
)

create table Route_Stops(
route int foreign key references Routes(id),
city int foreign key references Cities(id),
number int,
arrival datetime
)

create table Users(
id int primary key IDENTITY,
name nvarchar(100),
username nvarchar(40),
password text,
isAdmin bit default 0
)

insert into Users (name, username, password, isAdmin) values 
('Admin Admin', 'Admin', 'admin_pass', 1);

create table Reservations(
id int primary key IDENTITY,
passenger int foreign key references Users(id),
route int foreign key references Routes(id),
board int foreign key references Cities(id),
arrive int foreign key references Cities(id)
)







