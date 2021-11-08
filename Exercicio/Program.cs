using Exercicio.Entities;

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o caminho do arquivo: ");
            string path = Console.ReadLine();

            var list = new List<Employee>();

            using(StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] data = line.Split(',');

                    string name = data[0];
                    string email = data[1];
                    double salary = double.Parse(data[2], CultureInfo.InvariantCulture);

                    list.Add(new Employee(name, email, salary));
                }
            }

            Console.Write("\nInsira um valor base: ");
            double baseValue = double.Parse(Console.ReadLine());

            var selectedList = list.Where(p => p.Salary > baseValue)
                                .OrderBy(p => p.Name)
                                .Select(p => p.Email);

            Console.WriteLine($"\nE-mail dos funcionários em ordem alfabética, cujo valor é superior a {baseValue}:");
            foreach(string mail in selectedList)
                Console.WriteLine(mail);

            double salarySum = list.Where(p => p.Name[0] == 'M')
                                .Select(p => p.Salary)
                                .DefaultIfEmpty(0.0)
                                .Sum();

            Console.WriteLine($"\nSoma dos salários dos funcionários que tem o nome começando com a letra M: {salarySum}");

        }
    }
}
