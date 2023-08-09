use staffDb

select * from Dept
select * from Salary
select * from Staff

select abs(Salary) from Staff
select round(Salary, 4) from Staff
select convert(int, Salary) from Staff
select upper(Dname) from Dept
select lower(Designation) from Staff
select ltrim(Designation) from Staff


insert into Staff values (1, 'Chaitanya', 'Pradhan', 'Developer', rand([5]), 1)

delete from Staff where Id=1

select Id, Fname, Lname, Designation, Salary from Staff
Select left(Fname, 1) from Staff

select id, left(Fname, 1) +' . ' + left(Lname,1) + ' . ' as 'Initial', Fname, Lname, Salary from Staff

select Fname + '->' + Lname + '->' + Designation as 'First Name -> Last Name -> Designation' from Staff
select Fname + '->' + Lname + '->' + convert(nvarchar(50),Id) as 'First Name -> Last Name -> Id' from Staff

------------------------------------------------------------------------------------------------------------------

select getdate() as Today
select DATEPART(DAY,getDate()) 'DATE'
select DATEPART(MONTH,getDate()) 'MONTH'
select DATEPART(YEAR,getDate()) 'YEAR'

select DATEDIFF(year, '12/12/2019', '12/10/2022')
select DATEDIFF(Month, '12/12/2019', '12/10/2022')
select DATEDIFF(day, '12/12/2019', '12/10/2022')

-----------------------------------------------------------------------------------------------------------------

create table Customer
( CId int primary key identity(1000,1),
CName nvarchar(50) not null,
CEmail nvarchar(50) not null unique,
Contact nvarchar(50) not null unique check 
(Contact like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
CPwd as right(CName, 2) + convert(nvarchar(50),CId) + left(Contact,2) persisted,
MEndDate date not null)


insert into Customer (CName, CEmail, Contact, MEndDate) values ('Chaitanya', 'cp@gmail.com', '9876543212', '12/12/2023') 
insert into Customer (CName, CEmail, Contact, MEndDate) values ('Amit', 'amit@gmail.com', '6789678978', '12/12/2024') 
insert into Customer (CName, CEmail, Contact, MEndDate) values ('Gourav', 'gourav@gmail.com', '3454321234', '12/12/2025') 

--delete from Customer
select CId, CName, CEmail, Contact, CPwd, DATEDIFF(day, getDate(), MEndDate) as 'Days Remain' from Customer

-----------------------------------------------------------------------------------------

create function fnGetFullName
(
@fn nvarchar(50),
@ln nvarchar(50)
)
returns nvarchar(101)
As
begin
return (Select @fn + ' ' +@ln);
end

--Calling the above creaetd function

select dbo.fnGetFullName('Sam', 'Dicosta') as 'Full Name'

select Id, dbo.fnGetFullName(Fname, Lname) as 'Full Name', Salary from Staff


---------------------------------------------------------------------------------

create schema ourSchema

create table ourSchema.Staff
( Id int primary key,
Salary decimal(6,2))

alter table ourSchema.Staff alter column Salary decimal(8,2)

insert into ourSchema.Staff values  (1, 98000.50)
insert into ourSchema.Staff values (2, 75000.25)
insert into ourSchema.Staff values (3, 80000.90)
insert into ourSchema.Staff values (4, 65000.75)

select * from ourSchema.Staff

create function ourSchema.fnGetBonus
(
@sal decimal(8,2)
)
returns decimal(8,2)
As
begin
return (Select @sal*0.15);
end

select Salary,ourSchema.fnGetBonus(Salary) as 'Bonus' from ourSchema.Staff




