using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LiskovSubstitutionPrinciple
{
    public class Rectangle : Shape
    {
      public double Width { get; set; }
      public double Height { get; set; }
        public override double CalculateArea()
        {
            return Width * Height;
        }

    }

    public class Square : Rectangle
    {
        public double Side { get; set; }
        public override double CalculateArea()
        {
            return Side * Side;
        }
    }

    public class AreaCalculator
    {
        public void PrintArea(Shape shape)
        {
            Console.WriteLine($"Area of the shape: {shape.CalculateArea()}");
        }
    }
}
