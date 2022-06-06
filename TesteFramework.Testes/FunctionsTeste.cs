using System.Collections.Generic;
using TesteFramework.Core;
using Xunit;

namespace TesteFramework.Testes
{
    public class FunctionsTeste
    {

        [Fact]
        public void RetornarDivisoresEPrimosRetornaCorretamente()
        {
            //Arranje
            int numero = 45;
            DivisoresEPrimos result;
            
            //Act
            result = Functions.RetornarDivisoresEPrimos(numero);

            //Assert
            Assert.Equal(result.Divisores, new List<int> { 1, 3, 5, 9, 15, 45 });
            Assert.Equal(result.DivisoresPrimos, new List<int> { 3, 5 });

        }


    }
}
