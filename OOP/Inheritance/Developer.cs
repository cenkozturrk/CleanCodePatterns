using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    public class Developer : Employee
    {        
        public string ProgrammingLanguage { get; set; }
        
        public Developer(int id, string name,string programmingLanguage) : base(name,id)
        {
            ProgrammingLanguage = programmingLanguage;
        }
        public override void DisplayDetails()
        {
            string result = $"Programming Language : {ProgrammingLanguage}";

            base.DisplayDetails();
            Console.WriteLine(result);
        }
    }
}
