--CREATE TABLE Customers (
--    CustomerID INT PRIMARY KEY IDENTITY(1,1),
--    FirstName NVARCHAR(50),
--    LastName NVARCHAR(50)
--);

--CREATE TABLE Orders (
--    OrderID INT PRIMARY KEY IDENTITY(1,1),
--    CustomerID INT FOREIGN KEY REFERENCES Customers(CustomerID),
--    OrderDate DATE   

--);

--CREATE TABLE Products (
--    ProductID INT PRIMARY KEY IDENTITY(1,1),
--    ProductName NVARCHAR(50),
--    Price DECIMAL(10, 2)
--);

--CREATE TABLE OrderProducts (
--    OrderID INT FOREIGN KEY REFERENCES Orders(OrderID),
--    ProductID INT FOREIGN KEY REFERENCES Products(ProductID),   

--    Quantity INT,
--    PRIMARY KEY (OrderID, ProductID)
--);


---------------------------------------------------------


INSERT INTO Customers (FirstName, LastName)
VALUES
    ('John', 'Doe'),
    ('Jane', 'Smith'),
    ('Michael', 'Johnson'),
    ('Emily', 'Williams'),
    ('David', 'Brown'),
    ('Olivia', 'Jones'),
    ('William', 'Wilson'),
    ('Sophia', 'Lee');

INSERT INTO Products (ProductName, Price)
VALUES
    ('Laptop', 999.99),
    ('Smartphone', 749.99),
    ('Tablet', 399.99),
    ('Headphones', 199.99),
    ('Speaker', 249.99),
    ('Game Console', 499.99),
    ('Smartwatch', 299.99),
    ('Camera', 599.99),
    ('TV', 999.99),
    ('Refrigerator', 1299.99),
    ('Washing Machine', 799.99),
    ('Dishwasher', 899.99),
    ('Oven', 999.99),
    ('Microwave', 199.99),
    ('Vacuum Cleaner', 299.99),
    ('Air Conditioner', 599.99);

INSERT INTO Orders (CustomerID, OrderDate)
VALUES
    (1, '2024-01-01'),
    (2, '2024-02-02'),
    (3, '2024-03-03'),
    (4, '2024-04-04'),
    (5, '2024-05-05'),
    (6, '2024-06-06'),
    (7, '2024-07-07'),
    (8, '2024-08-08'),
    (1, '2024-09-09'),
    (2, '2024-09-10'),
    (2, '2024-11-11'),
    (4, '2024-12-12'),
    (5, '2024-01-13'),
    (5, '2024-02-14'),
    (7, '2024-03-15'),
    (1, '2024-04-16');

INSERT INTO OrderProducts (OrderID, ProductID, Quantity)
VALUES
    (1, 1, 2),
    (1, 2, 1),
    (1, 13, 3),
    (2, 4, 2),
	(2, 1, 2),
	(2, 10, 2),
    (3, 5, 1),
    (3, 6, 3),
    (4, 7, 2),
    (4, 8, 1),
    (5, 9, 3),
    (5, 10, 2),
    (6, 11, 1),
    (6, 12, 3),
    (6, 13, 2),
    (7, 14, 1),
    (8, 15, 3),
    (8, 16, 2),
    (9, 1, 2),
    (9, 2, 1),
    (10, 3, 5),
    (10, 4, 2),
    (11, 5, 1),
    (11, 6, 3),
    (12, 7, 2),
    (12, 8, 1),
    (13, 9, 3),
    (13, 10, 4),
    (14, 11, 1),
    (14, 14, 3),
    (15, 13, 2),
    (15, 4, 7),
    (16, 15, 3),
    (16, 16, 2),
	(16, 1, 1);