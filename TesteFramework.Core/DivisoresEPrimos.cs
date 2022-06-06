using System.Collections.Generic;

namespace TesteFramework.Core
{
    public class DivisoresEPrimos
    {
        public DivisoresEPrimos(List<int> divisores, List<int> divisoresPrimos)
        {
            Divisores = divisores;
            DivisoresPrimos = divisoresPrimos;
        }

        public List<int> Divisores { get; set; }
        public List<int> DivisoresPrimos { get; set; }

    }
}
