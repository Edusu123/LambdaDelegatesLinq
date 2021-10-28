using Func.Entities;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Func
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

            Func<Product, string> func = NameUpper;

            //List<string> result = list.Select(NameUpper).ToList();
            //List<string> result = list.Select(func).ToList();
            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();


            foreach (string name in result)
            {
                Console.WriteLine(name);
            }
        }

        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}
