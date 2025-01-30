using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    public class Manager : Employee
    {
        public string Department {get;set;}

        public Manager(int id, string name, string department) : base(name , id)
        {
            Department = department;
        }
        public override void DisplayDetails()
        {
            string result = $"Department : {Department}";

            base.DisplayDetails();
            Console.WriteLine(result);
        }
    }
}
