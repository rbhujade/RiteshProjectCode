select * from Persons;
select * from Audit_Persons;


select * from TB_Employee
insert into TB_Employee values('Ritesh','ritesh@mail.com','pune')
--------Trigger---------
create trigger trg_insert_Employee
on TB_Employee
for insert
as
begin
	declare @id int
	select @id = ID from inserted
	insert into Audit_Persons
	values ('Add Employee with id '+ cast(@id as varchar(10)) + ' on ' + cast(getdate() as varchar(22)))
end
-------------

--create table Audit_Persons
--(
--	ID int identity,
--	Audit_Action  text
--)

create procedure sp_person
@person_name varchar(50)
as
begin
select * from Persons where person_name =@person_name
end
--------

select * from Persons;

select * 
into temp_tb
from Persons;

select COALESCE(person_name,product) from Persons;

select product,
case 
	when price < 20000 then 'cheap'
	when price > 20000 then 'expensive'
	else 'non'
end
from Persons

--select * from TB_Student

create index student_index
on TB_Student (ID) 