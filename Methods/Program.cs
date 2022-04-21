using System;


namespace Methods
{
    class Program
    {
        // metotlar için ufak bir tekrar.
        static void Main(string[] args)
        {
            Product p1 = new Product();
            p1.Name = "Casper";
            p1.Price = 1250;
            p1.Description = "Monitör";

            Product p2 = new Product();
            p2.Name = "Toshiba";
            p2.Price = 1600;
            p2.Description = "Monitör";

            Product[] Products = new Product[] { p1, p2 };
            foreach (var product in Products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Description);
                Console.WriteLine("_____________");
            }
            Console.ReadKey();
        }
    }
}
