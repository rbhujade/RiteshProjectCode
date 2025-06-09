select * from Persons

row_number() over(PARTITION by partition_expression order by sort_expression asc|desc)


select ROW_NUMBER() OVER(PARTITION BY country order by country asc) as num, * from Persons

SELECT *, ROW_NUMBER() OVER (ORDER BY price) AS row_num  FROM Persons;

select * ,ROW_NUMBER() OVER (ORDER BY Price desc ) as row_num from Persons;

--3rd salary
with cte 
as (select ROW_NUMBER() over(order by Price desc) as row_num, * from Persons)
select * from cte where row_num = 3;

--
SELECT * FROM 
(SELECT ROW_NUMBER() OVER (ORDER BY price) AS row_num, person_name, product, price  FROM Persons) P  
WHERE row_num > 3 AND row_num <= 6;  