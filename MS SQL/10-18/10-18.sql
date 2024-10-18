USE Shop

--CREATE TABLE Customers(
--	CustomerID INT PRIMARY KEY IDENTITY(1,1),  
--	FirstName NVARCHAR(50),
--	LastName NVARCHAR(50)
--)

--CREATE TABLE Products(
--	ProductID INT PRIMARY KEY IDENTITY(1,1),  
--	ProductName NVARCHAR(50),
--	Price DECIMAL(10,2)
--)

--CREATE TABLE Orders(
--	OrderID INT PRIMARY KEY IDENTITY(1,1),  
--	CustomerID INT NOT NULL FOREIGN KEY REFERENCES Customers(CustomerID),
--	OrderDate DATE CHECK(OrderDate > '2020-01-01')
--)

--CREATE TABLE OrderProduct(
--	OrderID INT  NOT NULL FOREIGN KEY REFERENCES Orders(OrderID),
--	ProductID INT NOT NULL FOREIGN KEY REFERENCES Products(ProductID),
--	Quantity INT CHECK(Quantity > 0)

--	PRIMARY KEY (OrderID, ProductID)
--)

--DROP TABLE OrderProduct;
--DROP TABLE Orders;
--DROP TABLE Products;
--DROP TABLE Customers;

----------------------------------------------


