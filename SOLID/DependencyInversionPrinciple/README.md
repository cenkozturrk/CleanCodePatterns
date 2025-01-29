## Dependency Inversion Principle (DIP)

The **Dependency Inversion Principle** states that:

1. High-level modules should not depend on low-level modules. Both should depend on abstractions.
2. Abstractions should not depend on details. The details should depend on abstractions.

In this example, we implement the **NotificationService** that sends messages via different channels like Email and SMS.

### Key Features:
- **Abstraction (`INotification`)**: Defines a contract for notification channels.
- **Concrete Implementations**:  
  - `EmailNotification` sends an email.  
  - `SMSNotification` sends an SMS.
- **NotificationService**: Sends notifications without knowing the concrete implementation, following DIP.
- **Dependency Injection**: Demonstrates how dependencies can be injected, making the system flexible and decoupled.
  
