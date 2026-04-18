USE master;
GO

IF DB_ID('RestaurantManagementSystem') IS NOT NULL
BEGIN
    ALTER DATABASE RestaurantManagementSystem SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE RestaurantManagementSystem;
END
GO

CREATE DATABASE RestaurantManagementSystem;
GO

USE RestaurantManagementSystem;
GO

CREATE TABLE Items (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    OriginalPrice DECIMAL(10,2) NOT NULL,
    DiscountPrice DECIMAL(10,2) NOT NULL,
    CategoryName NVARCHAR(50) NOT NULL,
    Stock INT NOT NULL DEFAULT 0,
    RemainingStock INT NOT NULL DEFAULT 0,
    Status NVARCHAR(20) DEFAULT 'Available',
    Discount DECIMAL(5,2) DEFAULT 0
);
GO

CREATE TABLE Cashiers (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Contact NVARCHAR(20),
    Email NVARCHAR(100),
    CNIC NVARCHAR(20) UNIQUE,
    Username NVARCHAR(50) UNIQUE,
    Password NVARCHAR(100),
    Status NVARCHAR(20) DEFAULT 'Active'
);
GO

CREATE TABLE Orders (
    OrderID INT IDENTITY(1,1) PRIMARY KEY,
    OrderDate DATETIME DEFAULT GETDATE(),
    TotalAmount DECIMAL(10,2) DEFAULT 0
);
GO

CREATE TABLE OrderDetails (
    DetailID INT IDENTITY(1,1) PRIMARY KEY,
    OrderID INT NOT NULL,
    ItemID INT NOT NULL,
    Quantity INT NOT NULL,
    UnitPrice DECIMAL(10,2) NOT NULL,
    SubTotal DECIMAL(10,2) NOT NULL,

    CONSTRAINT FK_Order FOREIGN KEY (OrderID) 
    REFERENCES Orders(OrderID) ON DELETE CASCADE,

    CONSTRAINT FK_Item FOREIGN KEY (ItemID) 
    REFERENCES Items(Id)
);
GO

INSERT INTO Items 
(Name,OriginalPrice,DiscountPrice,CategoryName,Stock,RemainingStock,Status,Discount)
VALUES
('Biryani',350,315,'Food',50,50,'Available',10),
('Karahi',450,405,'Food',30,30,'Available',10),
('Naan',20,20,'Bread',100,100,'Available',0),
('Roti',10,10,'Bread',200,200,'Available',0),
('Pepsi',80,72,'Drinks',60,60,'Available',10),
('Lassi',120,108,'Drinks',40,40,'Available',10),
('Burger',500,450,'Fast Food',25,25,'Available',10),
('Fries',200,200,'Fast Food',80,80,'Available',0);
GO

INSERT INTO Cashiers
(Name,Contact,Email,CNIC,Username,Password,Status)
VALUES
('Admin User','03001234567','admin@rms.com',
'35202-1234567-1','admin','admin','Active');
GO

CREATE PROCEDURE GetTotalRevenue
AS
BEGIN
    SELECT 
        ISNULL(SUM(TotalAmount),0) AS TotalRevenue,
        COUNT(OrderID) AS TotalOrders
    FROM Orders;
END
GO

CREATE PROCEDURE GetWeeklyRevenue
AS
BEGIN
    SELECT
        CAST(OrderDate AS DATE) AS OrderDay,
        SUM(TotalAmount) AS DailyRevenue
    FROM Orders
    WHERE OrderDate >= DATEADD(DAY,-7,GETDATE())
    GROUP BY CAST(OrderDate AS DATE);
END
GO

CREATE PROCEDURE GetMonthlyRevenue
AS
BEGIN
    SELECT
        YEAR(OrderDate) AS Year,
        MONTH(OrderDate) AS Month,
        SUM(TotalAmount) AS MonthlyRevenue
    FROM Orders
    GROUP BY YEAR(OrderDate), MONTH(OrderDate);
END
GO

PRINT 'DATABASE READY';
GO