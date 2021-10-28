using System;
using System.Collections.Generic;

namespace Action
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

            Action<Product> act = p =>
            {
                p.Price += p.Price * 0.1;
            };

            list.ForEach(p => { p.Price += p.Price * 0.1; });

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}
