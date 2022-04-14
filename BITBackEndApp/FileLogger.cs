using System;
using System.IO;

namespace BITBackEndApp
{
    public class FileLogger : LogBase
    {
        public string filePath = "logger.txt";
        public override void Log(string message)
        {
            using (StreamWriter streamWriter = new StreamWriter(filePath))
            {
                streamWriter.WriteLine(message);
                streamWriter.Close();
            }
        }
    }
}
