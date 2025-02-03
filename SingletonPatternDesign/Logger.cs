using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public sealed class Logger
    {
        private static readonly Lazy<Logger> _instance = new Lazy<Logger>(() => new Logger());
        private static readonly object _lock = new object();
        private readonly string _logFilePath = "log.txt";
        private Logger()
        {
        }
        public static Logger Instance
        {
            get { return _instance.Value; }
        }
        public void Log(string message)
        {
            lock (_lock)
            {
                string logEntry = $"{DateTime.Now}: {message}";
                Console.WriteLine(logEntry);
                File.AppendAllText(_logFilePath, logEntry + Environment.NewLine);
            }
        }
    }
}
