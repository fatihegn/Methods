using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented3
{
    class PersonalCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("İhtiyaç Kredisi Ödeme planı");
        }

        public void FAQ()
        {
            throw new NotImplementedException();
        }
    }
}
