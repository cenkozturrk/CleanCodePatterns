using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SOLID.InterfaceSegregationPrinciple.Interfaces;

namespace SOLID.InterfaceSegregationPrinciple
{
    public class Manager : IWorkable, IReportable, ILeadable
    {
        public void CreateReport()
        {
            string writeToConsole = "Manager is creating performance reports.";
            Console.WriteLine(writeToConsole);
        }

        public void LeadTeam()
        {
            string writeToConsole = "Manager is leading the team";
            Console.WriteLine(writeToConsole);
        }

        public void Work()
        {
            string writeToConsole = "Manager is working on high-level tasks.";
            Console.WriteLine(writeToConsole);
        }
    }
  
    public class Analyst : IWorkable, IReportable
    {
        public void Work()
        {
            string writeToConsole = "Analyst is analyzing data.";
            Console.WriteLine(writeToConsole);
        }

        public void CreateReport()
        {
            string writeToConsole = "Analyst is creating detailed reports.";
            Console.WriteLine(writeToConsole);
        }
    }
    public class Intern : IWorkable
    {
        public void Work()
        {
            string writeToConsole = "Intern is working on assigned tasks.";
            Console.WriteLine(writeToConsole);
        }
    }
}
