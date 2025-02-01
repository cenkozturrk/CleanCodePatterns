# Worker Service with Dependency Injection

## Overview
This Worker Service demonstrates a robust, production-ready background service in .NET. It leverages:
- **Entity Framework Core** for data access
- **Dependency Injection** for scoped services
- **Structured Logging** via Microsoft.Extensions.Logging
- **Improved Error Handling & Retry Policies** (e.g., via Polly)
- **Separation of Concerns** by isolating UI, business logic, and data access

## Key Features
- **Interactive Console UI:**  
  Provides options to list and add books to a library database.  
- **Scoped Data Access:**  
  Uses a scoped `LibraryContext` for safe database interactions.  
  

