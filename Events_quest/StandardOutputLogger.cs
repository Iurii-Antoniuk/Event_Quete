using System;
using System.Collections.Generic;
using System.Text;

namespace Events_quest
{
    public class StandardOutputLogger
    {
        public void OnLogSent(object source, LogEventArgs e)
        {
            Write(e.LogMessage);
        }

        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}
