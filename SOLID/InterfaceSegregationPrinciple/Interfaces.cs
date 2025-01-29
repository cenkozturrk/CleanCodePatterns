using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegregationPrinciple
{
    public class Interfaces
    {
        public interface IWorkable
        {
            void Work();
        }

        public interface IReportable
        {
            void CreateReport();
        }

        public interface ILeadable
        {
            void LeadTeam();
        }
    }
}
