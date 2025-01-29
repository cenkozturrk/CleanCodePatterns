using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClosedPrinciple
{
    public class SalesReport : Report
    {
        public override void GenerateReport()
        {
            DisplayReportHeader("Sales Report");
            Console.WriteLine("Generating Sales Report...");
            // logic things.
            Console.WriteLine("Sales Report Generated.");
        }
    }


}
