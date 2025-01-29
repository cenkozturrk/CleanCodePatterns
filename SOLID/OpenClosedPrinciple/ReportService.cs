using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClosedPrinciple
{
    public class ReportService
    {
        private readonly Report _report;

        public ReportService(Report report)
        {
            _report = report;
        }

        public void GenerateReport()
        {
            _report.GenerateReport(); 
        }
    }

}
