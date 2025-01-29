using SOLID.DependencyInversionPrinciple;

INotification emailNotification = new EmailNotification(); 
//INotification emailNotification = new SMSNotification(); 

// Inject the dependency into NotificationService
var notificationService = new NotificationService(emailNotification);

// Send the notification
notificationService.SendNotification("Hello, this is a message sent through Dependency Inversion!");
