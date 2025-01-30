using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Encapsulation
{
    public class BankAccount
    {
        private decimal balance;

        public BankAccount(decimal initialBalance = 0)
        {
            string result = "Initial balance cannot be negative.";
            if (initialBalance < 0)
                throw new ArgumentOutOfRangeException(result);
            balance = initialBalance;
        }
        public void Deposit(decimal amount)
        {
            string result = "Deposit amount must be greater than zero.";
            if (balance <= 0)
                throw new ArgumentOutOfRangeException(result);
            balance += amount;
            Console.WriteLine($"Deposited {amount:C}. Current balance: {balance:C}");
        }
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)         
                throw new ArgumentException("Withdrawal amount must be greater than zero.");            

            if (amount > balance)            
                throw new InvalidOperationException("Insufficient funds for this withdrawal.");
            

            balance -= amount;
            Console.WriteLine($"Withdrew {amount:C}. Current balance: {balance:C}");
        }
        public decimal GetBalance()
        {
            return balance;
        }
    }
}
