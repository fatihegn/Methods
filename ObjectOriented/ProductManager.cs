﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName+" eklendi");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi");
        }
        public void Delete(Product product)
        {
            Console.WriteLine(product.ProductName + " silindi");
        }
        
        
    }
}
