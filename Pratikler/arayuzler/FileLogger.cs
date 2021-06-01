using System;

namespace arayuzler
{
    public class FileLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Dosya'ya log yazar");
            
        }
    }
}