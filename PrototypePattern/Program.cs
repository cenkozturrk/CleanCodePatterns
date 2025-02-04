//using PrototypePattern;

////              SHALLOW COPY        //

//Employee original = new Employee("Cenk", "Software Developer", 80000);
//original.DisplayInfo();

//Employee clonedEmployee = original.Clone();
//clonedEmployee.Name = "Bob"; 

//clonedEmployee.DisplayInfo();


//                  DEEP COPY        //
using PrototypePattern;

Employee original = new Employee("Alice", "Software Developer", 80000, new Address("123 Main St", "Toronto"));
original.DisplayInfo();

Employee clonedEmployee = original.Clone();
clonedEmployee.Name = "Bob";
clonedEmployee.Address.Street = "456 New Ave"; 

Console.WriteLine("\nAfter Cloning and Modification:");
clonedEmployee.DisplayInfo();
