------------cursor-----

declare cursor_name cursor
for select_statment;

open cursor_name;

fetch next from cursor variable_list;

while @@fetch_status = 0
begin
	fetch next from cursor_name;
end


close cursor_name;

deallocate cursor_name;
------CTE----
with cte_name(column_name)
as (query)
select * from cte_name
----
with cte 
as (select distinct Course from TB_Student)
select * from cte
---------
with 
cte1 as (query1),
cte2 as (query2)
select * from cte1
union
select * from cte2

---------View----------
create view Test_View as
select * from TB_Employee


create table TB_Product
(
	Product_ID int not null identity primary key,
	Product_Name varchar(50) not null,
	Category int not null,
)


create table TB_Inventory
(
	Inventory_ID int not null identity primary key,
	Product_ID int not null,
	Inventory_Name varchar(50),
	quantity INT,  
	min_level INT,  
	max_level INT,
	CONSTRAINT fk_Product_ID Foreign key (Product_ID) References TB_Product(Product_ID)
)


create table xyz
(
	xyz_id int not null identity primary key,
	name varchar(50) not null
)

create table pqr
(
	pqr_id int not null identity primary key,
	xyz_id int not null,
	constraint fk_pqr_id foreign key(xyz_id) references xyz(xyz_id)
)