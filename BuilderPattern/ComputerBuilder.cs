using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class ComputerBuilder : IComputerBuilder
    {
        private Computer _computer = new Computer();
        public IComputerBuilder SetCPU(string cpu)
        {
            _computer.CPU = cpu;
            return this;
        }

        public IComputerBuilder SetRAM(string ram)
        {
            _computer.RAM = ram;
            return this;
        }

        public IComputerBuilder SetStorage(string storage)
        {
            _computer.Storage = storage;
            return this;
        }

        public IComputerBuilder SetGPU(string gpu)
        {
            _computer.GPU = gpu;
            return this;
        }

        public Computer Build()
        {
            return _computer;
        }
    }
}
