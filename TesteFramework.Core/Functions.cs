using System.Collections.Generic;

namespace TesteFramework.Core
{
    public static class Functions
    {

        public static DivisoresEPrimos RetornarDivisoresEPrimos(int numero)
        {
            var divisores = CustomMath.CalcularDivisores(numero);
            var divisoresPrimos = new List<int>();

            foreach (int divisor in divisores)
                if (CustomMath.NumeroPrimo(divisor))
                    divisoresPrimos.Add(divisor);
                
            return new DivisoresEPrimos(divisores, divisoresPrimos);
        }
        
    }
}
