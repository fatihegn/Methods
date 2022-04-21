using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented3
{
    class RecourseManager
    {  // method  injection
        public void DoRecourse(ICreditManager creditManager,List<ILoggerService> loggerServices)
        { 
            creditManager.Calculate();
            // aynı anda hem telefona mesaj iletilmesi ve veritabanı kaydı için koleksiyonları kullandık.
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }
        public void CreditInfo(List<ICreditManager> credits)
        {
            foreach (var item in credits)
            {
                item.Calculate();
            }
        }
    }
}
