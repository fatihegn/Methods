using System;

namespace ObjectOrientedProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bireysel Müşteri
            Individual c1 = new Individual();
            c1.Id = 1;
            c1.CustomerNo = "111";
            c1.FullName = "Fatih EŞGÜN";
            c1.TcNo = "1111";
            
            // Şirket 
            Corporate cc1 = new Corporate();
            cc1.Id = 2;
            cc1.CustomerNo = "222";
            cc1.CompanyName = "Elsa Software";
            cc1.TaxNo = "1234567890";
            Customer c5 = new Individual();
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(c1);
            customerManager.Add(c5);
              
        }
    }
}
