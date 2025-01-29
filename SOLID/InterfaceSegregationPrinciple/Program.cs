using SOLID.InterfaceSegregationPrinciple;

Manager manager = new Manager();
Intern intern = new Intern();
Analyst analyst = new Analyst();

Console.WriteLine("Manager:");
manager.Work();
manager.CreateReport();
manager.LeadTeam();

Console.WriteLine("\nAnalyst:");
analyst.Work();
analyst.CreateReport();

Console.WriteLine("\nIntern:");
intern.Work();
