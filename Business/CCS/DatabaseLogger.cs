using System;

namespace Business.CCS
{
    public partial class FileLogger2
    {
        public class DatabaseLogger : ILogger
        {
            public void Log()
            {
                Console.WriteLine("Veritabanına Loglandı.");
            }
        }
    }
}
