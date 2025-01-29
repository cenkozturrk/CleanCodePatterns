//using SOLID.SingleResponsibilityPrinciple;
//using System.ComponentModel.DataAnnotations;
//using static SOLID.SingleResponsibilityPrinciple.UserInputValidator;


//Console.WriteLine("The Single Responsibility Principle (SRP) states that a class should have only one reason to change.");
//Console.WriteLine("In this example, each class has a single responsibility: validating one type of input.");
//Console.WriteLine("Now, let's test our input validation:");


//var emailValidator = new EmailValidator();
//var phoneValidator = new PhoneNumberValidator();
//var passwordValidator = new PasswordValidator();

//// Prompt user for email, phone number, and password
//Console.WriteLine("Enter your Email:");
//string email = Console.ReadLine();
//Console.WriteLine("Enter your Phone Number:");
//string phoneNumber = Console.ReadLine();
//Console.WriteLine("Enter your Password:");
//string password = Console.ReadLine();

//// Validate user input
//Console.WriteLine("\nValidation Results:");

//// Email Validation
//if (emailValidator.Validate(email))
//    Console.WriteLine("Email is valid.");
//else
//    Console.WriteLine("Email is invalid.");

//// Phone number Validation
//if (phoneValidator.Validate(phoneNumber))
//    Console.WriteLine("Phone number is valid.");
//else
//    Console.WriteLine("Phone number is invalid.");

//// Password Validation
//if (passwordValidator.Validate(password))
//    Console.WriteLine("Password is valid.");
//else
//    Console.WriteLine("Password is invalid. Make sure it's at least 8 characters long.");

