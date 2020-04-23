using System;

namespace Events_quest
{   
    public class Program
    {
        static void Main(string[] args)
        {
            var publisher = new LogPublisher();
            var consoleLogger = new StandardOutputLogger();
            var fileLogger = new FileStreamOutputLogger();

            publisher.LogSent += consoleLogger.OnLogSent;
            publisher.LogSent += fileLogger.OnLogSent;

            publisher.SendLog();
        }
    }
}