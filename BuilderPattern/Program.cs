using BuilderPattern;

IComputerBuilder builder = new ComputerBuilder();
Director director = new Director();


Computer gamingPC = director.BuildGamingPC(builder);
gamingPC.ShowSpecifications();

Console.WriteLine("\n");

Computer officePC = director.BuildOfficePC(builder);
officePC.ShowSpecifications();

Console.WriteLine("\n");

Computer customPC = builder.SetCPU("AMD Ryzen 7")
                                   .SetRAM("64GB")
                                   .SetStorage("2TB SSD")
                                   .SetGPU("NVIDIA RTX 3080")
                                   .Build();

customPC.ShowSpecifications();



