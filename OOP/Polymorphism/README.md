## OOP - Polymorphism

## Overview
This folder demonstrates the concept of **Polymorphism**, a core principle of Object-Oriented Programming (OOP). Polymorphism allows methods in derived classes to override methods in a base class, enabling dynamic method resolution during runtime.

## Key Features
- **Dynamic Method Resolution**: The `Draw` method in the base `Shape` class is overridden by derived classes like `Circle`, `Rectangle`, and `Triangle`.
- **Flexibility**: Allows the program to call the appropriate `Draw` method depending on the object type, even when referred to by the base class.

## Example Details
1. **Base Class**: The `Shape` class defines an abstract method `Draw`.
2. **Derived Classes**:
   - `Circle`: Implements its version of the `Draw` method.
   - `Rectangle`: Implements its version of the `Draw` method.
   - `Triangle`: Implements its version of the `Draw` method.
3. **Usage**: A list of `Shape` objects is iterated to call the `Draw` method dynamically for each object type.

