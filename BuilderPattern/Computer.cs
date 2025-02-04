using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Computer
    {
        public string CPU { get; set; }
        public string RAM { get; set; }
        public string Storage { get; set; }
        public string GPU { get; set; }
        public void ShowSpecifications()
        {
            Console.WriteLine($"Computer Specifications: \nCPU: {CPU}, RAM: {RAM}, Storage: {Storage}, GPU: {GPU}");
        }
    }
}

