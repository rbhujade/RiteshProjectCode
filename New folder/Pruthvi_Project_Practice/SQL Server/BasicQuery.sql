CREATE TABLE EmployeeDetails (
    Id INT PRIMARY KEY,
    Name VARCHAR(100),
    Age INT,
    Salary DECIMAL(10, 2),
	DepartmentId INT
);

CREATE TABLE Department (
    Id INT PRIMARY KEY,
    Description VARCHAR(100) ,
	Location VARCHAR(100)
);

INSERT INTO Department (Id, Description, Location)
VALUES 
(1, 'Human Resources', 'New York'),
(2, 'Finance', 'San Francisco'),
(3, 'IT', 'Chicago'),
(4, 'Marketing', 'Los Angeles'),
(5, 'Sales', 'Houston'),
(6, 'Operations', 'Seattle'),
(7, 'Customer Support', 'Austin');
------------------------------------------
INSERT INTO EmployeeDetails (Id, Name, Age, Salary, DepartmentId)
VALUES 
(1, 'John Doe', 30, 60000, 1),
(2, 'Jane Smith', 25, 50000, 2),
(3, 'Michael Brown', 40, 75000, 7),
(4, 'Emily Johnson', 35, 68000, 3),
(5, 'Chris Evans', 28, 55000, 4),
(6, 'Sarah Davis', 45, 80000, 5),
(7, 'David Wilson', 32, 62000, 6),
(8, 'Laura Thompson', 29, 57000, 7),
(9, 'James Taylor', 50, 90000, 3),
(10, 'Anna Harris', 26, 52000, 7),
(11, 'Daniel Lee', 31, 59000, 3),
(12, 'Sophia Clark', 27, 54000, 2),
(13, 'Henry Lewis', 38, 70000, 6),
(14, 'Olivia Walker', 33, 65000, 4),
(15, 'Noah Allen', 29, 56000, 1),
(16, 'Isabella Scott', 41, 72000, 3),
(17, 'William Green', 36, 69000, 2),
(18, 'Mia Baker', 24, 48000, 5),
(19, 'Benjamin King', 46, 87000, 2),
(20, 'Charlotte Turner', 34, 67000, 4),
(21, 'Liam Phillips', 30, 61000, 6),
(22, 'Amelia Campbell', 28, 53000, 3),
(23, 'Mason Mitchell', 42, 74000, 5),
(24, 'Evelyn Perez', 39, 71000, 4),
(25, 'Logan Parker', 35, 66000, 3),
(26, 'Abigail Rivera', 37, 68000, 2),
(27, 'Jacob Roberts', 26, 51000, 6),
(28, 'Ava Cooper', 44, 79000, 5),
(29, 'Elijah Edwards', 31, 62000, 2),
(30, 'Emily Morris', 29, 57000, 4),
(31, 'Alexander White', 48, 87000, 3),
(32, 'Grace Collins', 33, 64000, 1),
(33, 'Ethan Hall', 28, 56000, 2),
(34, 'Harper Torres', 43, 76000, 1),
(35, 'Sebastian Young', 37, 70000, 3),
(36, 'Ella Peterson', 32, 63000, 5),
(37, 'Lucas Sanchez', 27, 87000, 3),
(38, 'Lily Price', 45, 82000, 7),
(39, 'Jackson Howard', 40, 75000, 2),
(40, 'Zoe Morgan', 34, 66000, 3),
(41, 'Aiden Cox', 31, 61000, 2),
(42, 'Aria Ward', 30, 60000, 4),
(43, 'Matthew Hughes', 39, 72000, 1),
(44, 'Scarlett Rogers', 29, 58000, 7),
(45, 'Samuel Ramirez', 41, 74000, 3),
(46, 'Victoria Brooks', 36, 69000, 6),
(47, 'Joseph Powell', 35, 67000, 1),
(48, 'Penelope Bell', 38, 71000, 2),
(49, 'Gabriel Bailey', 33, 64000, 7),
(50, 'Hannah Reed', 26, 53000, 1);

-- DELETE FROM EmployeeDetails
--===================================================================================================
SELECT * FROM EmployeeDetails WHERE DepartmentId = 6
SELECT * FROM Department

-- RANK()
SELECT Id, Name, Salary, RANK() OVER (ORDER BY Salary DESC) AS SalaryRank
FROM EmployeeDetails

-- DENSE_RANK()
SELECT Id, Name, Salary, DENSE_RANK() OVER (ORDER BY Salary DESC) AS SalaryRank
FROM EmployeeDetails

-- Nth salary
SELECT *
FROM 
(
	SELECT Id, Name, Salary, DENSE_RANK() OVER (ORDER BY Salary DESC) AS SalaryRank
	FROM EmployeeDetails
)Temp
WHERE SalaryRank = 2

-- ROW_NUMBER()
SELECT Id, Name, Salary, ROW_NUMBER() OVER (ORDER BY Salary DESC) AS SalaryRank
FROM EmployeeDetails

-- CTE
-- Avg salary by dept wise
;WITH DeptSalary AS
(
	SELECT d.Id, d.Description, AVG(e.Salary) AS 'AVG'
	FROM EmployeeDetails e
	JOIN Department d ON e.DepartmentId = d.Id
	GROUP BY d.Description, d.Id
)
SELECT DS.*, D.Location 
FROM DeptSalary DS
JOIN Department D ON D.Id = DS.Id

-- PIVOT
CREATE TABLE Sales (
    SalesPerson NVARCHAR(50),
    Month NVARCHAR(10),
    SalesAmount DECIMAL(10, 2)
);

INSERT INTO Sales (SalesPerson, Month, SalesAmount)
VALUES 
('John Doe', 'January', 5000),
('John Doe', 'February', 6000),
('John Doe', 'March', 5500),
('Jane Smith', 'January', 7000),
('Jane Smith', 'February', 8000),
('Jane Smith', 'March', 7500);

SELECT SalesPerson,	
	ISNULL([January],0),
	ISNULL([February],0),
	ISNULL([March],0)
FROM Sales
PIVOT
(
	SUM(SalesAmount)
	FOR Month IN ([January],[February],[March])
)PVT

-- Dynamic Pivot
DECLARE @columns NVARCHAR(MAX), @sql NVARCHAR(MAX);
SELECT @columns = STRING_AGG(QUOTENAME(Month),',')
FROM (SELECT DISTINCT Month FROM Sales) AS M

SET @sql = 'SELECT SalesPerson,'+@columns+'
			FROM Sales
			PIVOT
			(
				SUM(SalesAmount)
				FOR Month IN ('+@columns+')
			)PVT'
EXEC sp_executesql @sql

-- UNPIVOT