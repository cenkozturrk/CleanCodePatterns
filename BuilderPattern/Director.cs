using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Director
    {
        public Computer BuildGamingPC(IComputerBuilder builder)
        {
            return builder.SetCPU("Intel i9")
                      .SetRAM("32GB")
                      .SetStorage("1TB SSD")
                      .SetGPU("NVIDIA RTX 4090")
                      .Build();
        }
        public Computer BuildOfficePC(IComputerBuilder builder)
        {
            return builder.SetCPU("Intel i5")
                          .SetRAM("16GB")
                          .SetStorage("512GB SSD")
                          .SetGPU("Integrated Graphics")
                          .Build();
        }
    }
}
