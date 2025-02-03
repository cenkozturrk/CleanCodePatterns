using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AbstractFactoryPattern.Factory;

namespace AbstractFactoryPattern
{
    public static class UIFactoryProvider
    {
        public static IUIFactory GetFactory(string theme) => theme.ToLower() switch
        {
            "light" => new LightThemeFactory(),
            "dark" => new DarkThemeFactory(),
            _ => throw new ArgumentException("Invalid theme selected")
        };
    }

}
