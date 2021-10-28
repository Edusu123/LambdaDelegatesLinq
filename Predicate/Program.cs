﻿using System;
using System.Collections.Generic;

using Predicate.Entities;

namespace Predicate
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.00));
            list.Add(new Product("HD Case", 80.00));

            list.RemoveAll(ProductTest);

            foreach(Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        public static bool ProductTest(Product p)
        {
            return p.Price >= 100;
        }
    }
}
