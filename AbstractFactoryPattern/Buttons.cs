using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class Buttons
    {
        public class LightButton : IButton
        {
            public void Render()
            {
                Console.WriteLine("Rendering Light Theme Button.");
            }
        }

        public class DarkButton : IButton
        {
            public void Render()
            {
                Console.WriteLine("Rendering Dark Theme Button.");
            }
        }
        public class LightTextBox : ITextBox
        {
            public void Render()
            {
                Console.WriteLine("Rendering Light Theme TextBox.");
            }
        }
        public class DarkTextBox : ITextBox
        {
            public void Render()
            {
                Console.WriteLine("Rendering Dark Theme TextBox.");
            }
        }
    }
}
