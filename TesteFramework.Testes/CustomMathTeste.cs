using System.Collections.Generic;
using TesteFramework.Core;
using Xunit;

namespace TesteFramework.Testes
{
    public class CustomMathTeste
    {
        [Fact]
        public void CalcularDivisorRetornaDivisoresCorretamente()
        {
            //Arranje
            int numero = 45;
            List<int> result;

            //Act
            result = CustomMath.CalcularDivisores(numero);

            //Assert
            Assert.Equal(result, new List<int> { 1, 3, 5, 9, 15, 45 });

        }
        
        [Theory]
        [InlineData(1, false)]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(5, true)]
        [InlineData(6, false)]
        [InlineData(10, false)]
        [InlineData(17, true)]
        public void NumeroPrimoRetornaPrimosCorretamente(int numero, bool expectedResult)
        {
            //Arranje
            bool result;

            //Act
            result = CustomMath.NumeroPrimo(numero);

            //Assert
            Assert.Equal(result, expectedResult);

        }
    }
}
