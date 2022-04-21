using System;

namespace ObjectOriented3
{
    class MessageLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Mesaj  gönderildi");
        }
    }
}
