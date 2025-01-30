using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Employee(string name, int id)
        {
            Name = name;
            ID = id;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Name : {Name}, ID : {ID}");
        }
    }
}
