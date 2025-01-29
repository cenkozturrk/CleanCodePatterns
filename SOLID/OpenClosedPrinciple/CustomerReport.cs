using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClosedPrinciple
{
    public class CustomerReport : Report
    {
        public override void GenerateReport()
        {
            DisplayReportHeader("Customer Report");
            Console.WriteLine("Generating Customer Report...");
            //  logic things.
            Console.WriteLine("Customer Report Generated.");
        }
    }


}
