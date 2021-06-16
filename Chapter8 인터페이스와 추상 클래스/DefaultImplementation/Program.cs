using System;

namespace DefaultImplementation
{
    interface ILogger
    {
        void WriteLog(string message);
        
        void WriteError(string error)   // 새로운 메소드 추가   
        {
            WriteLog($"Error : {error}");
        }
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine($"{DateTime.Now.ToLocalTime()}, {message}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();
            logger.WriteLog("System Up");
            logger.WriteError("System Fail");

            ConsoleLogger clogger = new ConsoleLogger();
            clogger.WriteLog("System Up");  //OK
            //clogger.WriteError("System Fail");    Error

        }
    }
}
