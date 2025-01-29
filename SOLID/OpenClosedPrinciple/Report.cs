using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClosedPrinciple
{
    public abstract class Report
    {
        public abstract void GenerateReport();
      
        public void DisplayReportHeader(string reportName)
        {
            Console.WriteLine($"----- {reportName} -----");
        }
    }

}
