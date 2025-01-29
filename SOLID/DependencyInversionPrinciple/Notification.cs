using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversionPrinciple
{
    public class EmailNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Email sent: {message}");
        }
    }

    public class SMSNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"SMS sent: {message}");
        }
    }


}
