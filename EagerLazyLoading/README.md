# Lazy Loading & Eager Loading 

## Overview  
This layer demonstrates the difference between **Lazy Loading** and **Eager Loading** in Entity Framework Core with AsNoTracking(). These techniques control how related data is retrieved from the database.  

## Lazy Loading  
Lazy Loading loads related data **only when accessed** in code. It minimizes initial database queries but can lead to performance issues due to multiple queries.  

## Eager Loading  
Eager Loading fetches related data immediately. It is useful when all related entities are needed at once.
