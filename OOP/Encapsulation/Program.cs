using OOP.Encapsulation;


Console.WriteLine("Welcome to the Bank Account Demo!");

// Get initial balance from the user
Console.Write("Please enter the initial balance for your account: ");
decimal initialBalance = decimal.Parse(Console.ReadLine());

// Create a new bank account with the entered initial balance
BankAccount account = new BankAccount(initialBalance);
Console.WriteLine($"Initial Balance: {account.GetBalance():C}");

// Get deposit amount from the user
Console.Write("Please enter the amount to deposit: ");
decimal depositAmount = decimal.Parse(Console.ReadLine());
account.Deposit(depositAmount);
Console.WriteLine($"New Balance after deposit: {account.GetBalance():C}");

// Get withdrawal amount from the user
Console.Write("Please enter the amount to withdraw: ");
decimal withdrawAmount = decimal.Parse(Console.ReadLine());

try
{
    account.Withdraw(withdrawAmount);
    Console.WriteLine($"New Balance after withdrawal: {account.GetBalance():C}");
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

// Final balance
Console.WriteLine($"Final Balance: {account.GetBalance():C}");

Console.WriteLine("Demo complete. Press any key to exit.");
Console.ReadKey();



