using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    using System;

    public class Logger
    {
        private static Logger instance = null;

        // Private constructor to prevent external instantiation
        private Logger()
        {
            Console.WriteLine("Logger instance created");
        }

        public static Logger GetInstance()
        {
            // Lazy initialization: Create instance only when needed
            if (instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }

        public void LogMessage(string message)
        {
            Console.WriteLine($"[LOG] {DateTime.Now}: {message}");
        }
    }

    class Program9
    {
        static void Main(string[] args)
        {
            // Get the singleton instance of Logger
            Logger logger1 = Logger.GetInstance();
            Logger logger2 = Logger.GetInstance();

            // Both instances are the same
            Console.WriteLine($"Is logger1 equal to logger2? {logger1 == logger2}");

            // Use the singleton instance to log messages
            logger1.LogMessage("This is a log message");
            logger2.LogMessage("Another log message");
        }
    }

}
