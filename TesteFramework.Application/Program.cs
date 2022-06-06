using System;
using TesteFramework.Core;
using TesteFramework.Application.Extensions;

namespace TesteFramework.Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro para calcular seus divisores e divisores primos: ");
            int calcular = int.Parse(Console.ReadLine());

            var divisoresEPrimos = Functions.RetornarDivisoresEPrimos(calcular);

            Console.WriteLine("\nDivisores:");
            divisoresEPrimos.Divisores.PrintarArray();
            Console.WriteLine("\nDivisores Primos:");
            divisoresEPrimos.DivisoresPrimos.PrintarArray();

            Console.ReadLine();
        }
    }
}
