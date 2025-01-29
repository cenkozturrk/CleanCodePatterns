using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClosedPrinciple
{
    public class EmployeeReport : Report
    {
        public override void GenerateReport()
        {
            DisplayReportHeader("Employee Report");
            Console.WriteLine("Generating Employee Report...");
            //  logic things.
            Console.WriteLine("Employee Report Generated.");
        }
    }

}
