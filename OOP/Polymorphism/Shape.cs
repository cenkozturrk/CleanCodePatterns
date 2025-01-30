using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism
{
    public abstract class Shape
    {
        public abstract void Draw();
    }

    //or
    //class Shape
    //{
    //    public virtual void Draw()            
    //    {
    //        Console.WriteLine("This is my virtual class and I can override it where there is the appropriate space");
    //    }
    //}

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle");
        }
    }
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawint a Rectangle");
        }
    }

    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Triangle.");
        }
    }

}
