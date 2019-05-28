using System;

namespace _14_ChainOfResponsibility
{

    class Program
    {
        private static AbstractLogger getChainOfLoggers()
        {

            AbstractLogger errorLogger = new ErrorLogger(AbstractLogger.ERROR);
            AbstractLogger fileLogger = new FileLogger(AbstractLogger.DEBUG);
            AbstractLogger consoleLogger = new ConsoleLogger(AbstractLogger.INFO);

            errorLogger.setNextLogger(fileLogger);
            fileLogger.setNextLogger(consoleLogger);

            return errorLogger;
        }
        static void Main(string[] args)
        {
            AbstractLogger loggerChain = getChainOfLoggers();
            loggerChain.logMessage(AbstractLogger.INFO,
               "This is an information.");

            loggerChain.logMessage(AbstractLogger.DEBUG,
               "This is an debug level information.");

            loggerChain.logMessage(AbstractLogger.ERROR,
               "This is an error information.");
            Console.WriteLine("Hello World!");
        }
    }
}
