﻿using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Fatih");
            Console.WriteLine(isimler.Length);
            isimler.Add("baran");
            Console.WriteLine(isimler.Length);
            
            
        }
    }
}
