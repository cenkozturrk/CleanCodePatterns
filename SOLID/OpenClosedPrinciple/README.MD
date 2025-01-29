## Open/Closed Principle (OCP) Demonstration with Abstract Class

This project demonstrates the **Open/Closed Principle** (OCP) using an **abstract class** to create a **Business Report Generation System**. The system allows the addition of new report types without modifying the existing codebase.

### Key Features:
- **Abstract `Report` Class**: The base class for all report types, providing default functionality and an abstract method for generating reports.
- **Extensibility**: New report types can be added by creating new classes that inherit from the `Report` class.
- **Closed for Modification**: Existing classes and logic do not need to be changed when adding new reports.
- **Open for Extension**: The system is easily extended by adding new implementations of the `Report` class.

---


This demonstrates how the **Open/Closed Principle** can be applied using an abstract class to keep the system flexible and maintainable as it grows.
