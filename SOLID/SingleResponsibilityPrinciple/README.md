# SingleResponsibilityPrinciple Folder

## Purpose
This folder contains the implementation of classes that follow the **Single Responsibility Principle (SRP)**, one of the key SOLID principles. Each class is responsible for only one task, making the code cleaner and easier to maintain.

### Classes:
- **EmailValidator**: Validates email addresses.
- **PhoneNumberValidator**: Validates phone numbers.
- **PasswordValidator**: Validates passwords.

## How SRP is Applied
Each class here is responsible for only one validation task, following the principle that a class should have only one reason to change. For example, if we needed to change the email validation logic, we would only modify the `EmailValidator` class.
