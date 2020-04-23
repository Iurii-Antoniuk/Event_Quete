using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Events_quest
{
    public class FileStreamOutputLogger
    {
        public void OnLogSent(object source, LogEventArgs e)
        { 
            Write(e.LogMessage);
        }

        public void Write(string message)
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(baseDir, "EventLog.txt"), true))
            {
                outputFile.WriteLine(message);
            }
        }
    }
}
