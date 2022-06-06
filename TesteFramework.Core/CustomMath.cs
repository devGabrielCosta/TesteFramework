using System.Collections.Generic;
using System.Linq;

namespace TesteFramework.Core
{
    public static class CustomMath
    {    
        public static List<int> CalcularDivisores(int numero)
        {
            var divisores = new List<int>();

            for (int i = 1; i <= numero/i; i++)
                if (numero % i == 0)
                {
                    divisores.Add(i);
                    divisores.Add(numero / i);
                }

            return divisores.OrderBy(x => x).Distinct().ToList();
        }

        public static bool NumeroPrimo(int numero)
        {
            var divisores = CalcularDivisores(numero);
            if (divisores.Count == 2)
                return true;
            
            return false;
        }

    }
}
