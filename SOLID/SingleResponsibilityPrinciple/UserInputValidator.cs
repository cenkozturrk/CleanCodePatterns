using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SOLID.SingleResponsibilityPrinciple
{
    public class UserInputValidator
    {
        // Email validation class
        public class EmailValidator : IValidator
        {
            public bool Validate(string email)
            {
                var emailRegex = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return Regex.IsMatch(email, emailRegex);
            }
        }
        // Phone number validation class
        public class PhoneNumberValidator : IValidator
        {
            public bool Validate(string phoneNumber)
            {
                var phoneRegex = @"^\+?[1-9]\d{1,14}$";
                return Regex.IsMatch(phoneNumber, phoneRegex);
            }
        }
        // Password validation class
        public class PasswordValidator : IValidator
        {
            public bool Validate(string password)
            {
                return password.Length >= 8; // Basic check: minimum 8 characters
            }
        }


    }
}
