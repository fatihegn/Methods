using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented3
{
    class DataBaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanı kaydı");
        }
    }
}
