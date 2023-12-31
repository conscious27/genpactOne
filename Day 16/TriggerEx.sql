drop database ExerciseDb

create database ExerciseDb
use ExerciseDb

create table Student
( SId int Primary Key,
SName nvarchar(50) not null,
SEmail nvarchar(50) not null unique,
SContact nvarchar(50) not null unique check
( SContact like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))

insert into Student values(1, 'Chaitanya', 'cp@gmail.com', '8787654567')
insert into Student values(2, 'Amit', 'amit@gmail.com', '9878654321')
insert into Student values(3, 'Rahul', 'rahulgmail.com', '7654565676')

create table Fee
( SId int foreign key references Student(SId),
SFee float,
SMonth int,
SYear int,
Constraint SFpk Primary key (SId, SFee, SMonth))

drop table fee

create table PayConformation
(SId int,
Name nvarchar(50),
Email nvarchar(50),
Fee Float,
PaidOnDate date)

alter trigger trgFeePayConfirmation
on Fee
after insert
as
declare @id int
declare @fee float
declare @month int
declare @year int
declare @email nvarchar(50)
declare @name nvarchar(50)

select @id=SId from inserted
select @name=s.SName from Student s where s.SId = @id
select @email=s.SEmail from Student s where s.SId = @id
select @fee=SFee from inserted
select @month=SMonth from inserted
select @year=SYear from inserted

insert into PayConformation (SId, Name, Email, Fee, PaidOnDate) values
(@id, @name, @email, @fee, convert(date,convert(nvarchar(50),@month) + '/1/' + convert(nvarchar(50),@year)))

print 'Pay details added'


drop trigger trgFeePayConfirmation
insert into Fee Values(1, 1000, 10, 2022)
insert into Fee Values(2, 2000, 1, 2023)
insert into Fee Values(3, 1500, 3, 2023)
insert into Fee Values(1, 500, 5, 2023)
insert into Fee Values(2, 500, 7, 2023)

select * from PayConformation