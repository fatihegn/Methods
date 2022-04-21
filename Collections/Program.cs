using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // diziler üzerinde ekleme gibi işlemler sadece tanımlandığında yapılır 
            // dolayısıla sonradan değişiklik yapmak zordur bu yüzden Collections kullanılır.


            //string[] isimler = new string[] { "Ali AK", "Fatma PAK" };
            //Console.WriteLine(isimler[0]);

            List<string> isimler2 = new List<string> { "Ali AK", "Fatma PAK" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            isimler2.Add("Fatih");
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[0]);
            Console.ReadKey();
        }
    }
}
