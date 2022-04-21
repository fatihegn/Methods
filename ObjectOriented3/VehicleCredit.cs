using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented3
{
    class VehicleCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Taşıt Kredisi Ödeme planı");
        }

        public void FAQ()
        {
            throw new NotImplementedException();
        }
    }
}
