# Interface Segregation Principle (ISP)

The Interface Segregation Principle ensures that no class is forced to implement methods it does not need. This folder demonstrates how to apply ISP by creating small, role-specific interfaces.

---

## Key Features

- **Base Interfaces:** `IWorkable` , `IReportable` , `ILeadable`
- **Implemented Classes:** `Manager`, `Analyst` ,  `Intern`
- **Purpose:** Ensure that classes implement only the methods they require, promoting focused and reusable interfaces.

---

The aim is to demonstrate how ISP promotes better design by breaking large interfaces into smaller, focused ones, ensuring that classes depend only on what they use.
