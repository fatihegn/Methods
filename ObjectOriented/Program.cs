using System;

namespace ObjectOriented
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            p1.Id = 1;
            p1.CategoryId = 2;
            p1.ProductName = "Desk";
            p1.UnitPrice = 575;
            p1.UnitsInStock = 3;
            Product p2 = new Product
            {
                Id = 2,
                CategoryId = 5,
                UnitsInStock = 5,
                ProductName = "Pencil",
                UnitPrice = 125
            };
            ProductManager productManager = new ProductManager();
            Console.Write("Password : ");
            string val = Console.ReadLine();
            
            if (val=="x")
            {
               productManager.Add(p1);
            }
            else
            {
                Console.Write("error");
            }
            
            
            
            Console.ReadKey();
        }
    }
}
