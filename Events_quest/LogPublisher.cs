using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Events_quest
{
    public class LogEventArgs : EventArgs
    {
        public string LogMessage { get; set; }
    }
    
    public class LogPublisher
    {     
        public event EventHandler<LogEventArgs> LogSent;

        public void SendLog()
        {
            while (true)
            {
                string logMessage = $"Here I am, creating a log again! The " +
                    $"current time is: {DateTime.Now}";
                OnLogSent(logMessage);
                Thread.Sleep(5000);
            }
        }

        protected virtual void OnLogSent(string logMessage)
        {
            if (LogSent != null)
            {
                LogSent(this, new LogEventArgs {LogMessage = logMessage });
            }
        }

    }
}
