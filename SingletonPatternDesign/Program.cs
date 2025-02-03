using SingletonPattern;

Console.WriteLine("Enter log messages (type 'exit' to quit):");
while (true)
{
    Console.Write("Log: ");
    string input = Console.ReadLine();
    if (input?.ToLower() == "exit")
        break;
    Logger.Instance.Log(input);
}