using OOP.Inheritance;
using System.Xml.Linq;

Console.WriteLine("Enter Employee Type (Manager/Developer): ");
string employeeType = Console.ReadLine();

Console.WriteLine("Enter Employee Name: ");
string name = Console.ReadLine();

Console.WriteLine("Enter Employee ID: ");
int id = int.Parse(Console.ReadLine());

Employee employee;

if (employeeType.Equals("Manager", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("Enter Department: ");
    string department = Console.ReadLine();
    employee = new Manager(id, name, department);
}
else if (employeeType.Equals("Developer", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("Enter Programming Language: ");
    string programmingLanguage = Console.ReadLine();
    employee = new Developer(id, name, programmingLanguage);
}
else
{
    Console.WriteLine("Invalid employee type!");
    return;
}

Console.WriteLine("\nEmployee Details:");
employee.DisplayDetails();
