using AbstractFactoryPattern;

Console.Write("Enter Theme (light/dark): ");
string userSelectedTheme = Console.ReadLine();

try
{
    IUIFactory factory = UIFactoryProvider.GetFactory(userSelectedTheme);

    IButton button = factory.CreateButton();
    ITextBox textBox = factory.CreateTextBox();

    button.Render();
    textBox.Render();
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}