using System;

namespace Delegates
{
    class Program
    {
        delegate double BinaryNumericOperation(double n1, double n2);

        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Sum; // assinatura das funções é igual
            //BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Sum) // assinatura das funções é igual

            double result = op(a, b);
            //double result = op.Invoke(a, b);
            Console.WriteLine(result);
        }
    }
}
