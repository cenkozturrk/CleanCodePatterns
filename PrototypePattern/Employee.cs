using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class Employee : IPrototype<Employee>
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
        public Address Address { get; set; }

        public Employee(string name, string position, int salary, Address address)
        {
            Name = name;
            Position = position;
            Salary = salary;
            Address = address;
        }
        public Employee Clone()
        {
            return new Employee(Name,Position,Salary,Address.Close());
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Employee: {Name}, Position: {Position}, Salary: ${Salary}, Address: {Address.Street}, {Address.City}");
        }
    }
}

