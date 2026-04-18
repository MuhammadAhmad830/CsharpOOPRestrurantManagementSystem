Restaurant Management System

A professional desktop application developed using C# (.NET Framework) and Microsoft SQL Server.
This project is built using a 3-Tier Architecture (UI, Business Logic, Data Layer) to ensure scalability, maintainability, and clean separation of concerns. It efficiently manages restaurant operations, inventory, and user authentication.

🛠 Tech Stack
Language: C#
Framework: .NET Framework (Windows Forms)
Database: Microsoft SQL Server
Data Access: ADO.NET
IDE: Visual Studio 2022
🏗 System Architecture (3-Tier)

This project follows a layered architecture to improve code organization and maintainability:

1️⃣ Presentation Layer (UI Layer)

Responsible for user interaction and interface design.

LoginPage: Handles authentication (Admin & Cashier roles)
AdminForm: Main dashboard for system management
AddItem: Interface for adding new inventory items
2️⃣ Business Logic Layer (BL Layer)

Contains core business rules and object-oriented design.

Item.cs: Base class for all products
FoodItem.cs / DrinkItem.cs: Derived classes using inheritance
Implements OOP principles such as encapsulation and inheritance
3️⃣ Data Access Layer (DL Layer)

Manages all database operations and communication with SQL Server.

DatabaseHelper.cs: Centralized database connection handler
ItemDL.cs / CashierDL.cs: Handles CRUD operations using SQL queries
Uses parameterized queries for secure data handling
🔑 Key Features
🔐 Secure Authentication
Role-based login system (Admin & Cashier)
Protection against SQL Injection using parameterized queries
📦 Inventory Management (CRUD)
Create: Add new food and drink items
Read: Display inventory using DataGridView
Update: Modify existing records
Delete: Remove items from database
🚀 How to Run
Clone the repository
Open SQL Server Management Studio (SSMS)
Run the provided SQL scripts to create database and tables
Update the connection string in App.config
Open the solution file (.sln) in Visual Studio 2022
Build and run the project (F5)
💡 Key Programming Concepts Used
Encapsulation: Business logic separated from UI layer
Inheritance: Used for product categorization (Food & Drink items)
Exception Handling: Proper try-catch blocks for error management
Resource Management: Efficient use of using statements for database connections
Layered Architecture: Clean separation of concerns for scalability
📌 Summary

This project demonstrates a real-world implementation of a restaurant management system using layered architecture, object-oriented programming principles, and secure database integration. It is designed to be scalable, maintainable, and easy to extend with additional features in the future.
