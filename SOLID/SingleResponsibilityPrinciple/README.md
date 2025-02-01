# UnitOfWork Pattern 

## Purpose
This project demonstrates the **Unit of Work** pattern in **.NET Core**, ensuring better data management by handling multiple repository operations within a single transaction.

## Features
- Implements the **Unit of Work** design pattern.
- Uses **Repository Pattern** for database interactions.
- Includes **Entity Framework Core (EF Core)** with an **In-Memory Database** for testing.
- Provides a **testable and structured** approach to database operations.

## How the Unit of Work Pattern is Applied
- **UnitOfWork.cs**: Manages database transactions and multiple repositories.
- **Repository.cs**: A generic repository that interacts with the database.
- **Service Layer**: Calls repositories through the Unit of Work to perform actions.


