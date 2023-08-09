create database TriggerDb
use TriggerDb

create table Customer
( CId int primary key,
Fname nvarchar(50) not null,
Lname nvarchar(50) not null,
ODLimit float not null,
MEdate date not null)

create table CustomerLog
( LoginId int primary key identity,
CId int,
Fname nvarchar(50),
Lname nvarchar(50),
ODLimit float,
MEdate date,
ActionTaken nvarchar(100),
ActionTime datetime)

create trigger insertTrigger
on Customer
after insert
as 
declare @id int
declare @fn nvarchar(50)
declare @ln nvarchar(50)
declare @odlimit float
declare @mdate date
select @id=CId from inserted
select @fn=Fname from inserted
select @ln=Lname from inserted
select @odlimit=ODLimit from inserted
select @mdate=MEdate from inserted
insert into CustomerLog (CId, Fname, Lname, ODLimit, MEdate, ActionTaken, ActionTime) 
values (@id, @fn, @ln, @odlimit, @mdate, 'Record Inserted', getdate())
print 'Trigger Fired Action Captured!'


insert into customer (CId, Fname, Lname, ODLimit, MEdate) values (2, 'Raj', 'Kumar', 67000.90, '12/12/2022')
select * from CustomerLog
select * from Customer

---------------------------------------------------------------------------------------------------------
--deleted
alter trigger deleteTrigger
on Customer
after delete
as 
declare @id int
declare @fn nvarchar(50)
declare @ln nvarchar(50)
declare @odlimit float
declare @mdate date
select @id=CId from deleted
select @fn=Fname from deleted
select @ln=Lname from deleted
select @odlimit=ODLimit from deleted
select @mdate=MEdate from deleted
insert into CustomerLog (CId, Fname, Lname, ODLimit, MEdate, ActionTaken, ActionTime) 
values (@id, @fn, @ln, @odlimit, @mdate, 'Record Deleted', getdate())
print 'Trigger Fired Action:Delete Captured!'

delete from Customer where CId=2

select * from CustomerLog
select * from Customer

----------------------------------------------------------------------------------------------
--Updated

create trigger updateTrigger
on Customer
after update
as 
declare @id int
declare @fn nvarchar(50)
declare @ln nvarchar(50)
declare @odlimit float
declare @mdate date
select @id=CId from inserted
select @fn=Fname from inserted
select @ln=Lname from inserted
select @odlimit=ODLimit from inserted
select @mdate=MEdate from inserted
insert into CustomerLog (CId, Fname, Lname, ODLimit, MEdate, ActionTaken, ActionTime) 
values (@id, @fn, @ln, @odlimit, @mdate, 'Record Updated', getdate())
print 'Trigger Fired Action:Update Captured!'

update Customer set Lname = 'Kumari' where CId = 2

select * from Customer
select * from CustomerLog

insert into Customer(CId, Fname, Lname, ODLimit, MEdate) values (5, 'Deep', 'Das', 67000.90, '12/12/2021')
insert into Customer(CId, Fname, Lname, ODLimit, MEdate) values (9, 'Renu', 'Vats', 67000.90, '12/12/2021')
update Customer set ODLimit = 900000 where CId = 9


-----------------------------------------------------------------------------------------------------------------------

--CustomDelete

create trigger insteadofFelTrigger
on Customer
instead of delete
as 
declare @id int
declare @fn nvarchar(50)
declare @ln nvarchar(50)
declare @odlimit float
declare @mdate date
select @id=CId from deleted
select @fn=Fname from deleted
select @ln=Lname from deleted
select @odlimit=ODLimit from deleted
select @mdate=MEdate from deleted
if(@odlimit>=800000)
begin
raiserror('You can not delete this Customer its VIP', 16, 1)
rollback
end
else
begin
delete from Customer where CId = @id
commit;
insert into CustomerLog (CId, Fname, Lname, ODLimit, MEdate, ActionTaken, ActionTime) 
values (@id, @fn, @ln, @odlimit, @mdate, 'InsteadofTrigger:Record Deleted', getdate())
print 'Instead of Trigger say Trigger Fired your deleted action captured!'
end

select * from Customer
select * from CustomerLog
delete from Customer where CId=5
delete from Customer where CId=9