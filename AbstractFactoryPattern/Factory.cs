using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AbstractFactoryPattern.Buttons;

namespace AbstractFactoryPattern
{
    public class Factory
    {
        public class LightThemeFactory : IUIFactory
        {
            public IButton CreateButton()
            {
                return new LightButton();
            }

            public ITextBox CreateTextBox()
            {
                return new LightTextBox();
            }
        }
        public class DarkThemeFactory : IUIFactory
        {
            public IButton CreateButton()
            {
                return new DarkButton();
            }

            public ITextBox CreateTextBox()
            {
                return new DarkTextBox();
            }
        }
    }
}
