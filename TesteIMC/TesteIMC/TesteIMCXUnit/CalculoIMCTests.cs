using TesteIMC;
using Xunit;

namespace TesteIMCXUnit
{
    public class CalculoIMCTests
    {
        //metodo de teste
        [Fact]

        public void CalcularIMC_RetornaResultado()
        {
            //Arrange

            double peso = 65;
            double altura = 1.66;

            //Act

            var resultado = Operacoes.CalcularIMC(peso, altura);

            //Assert

            Assert.Equal(23.59, resultado);

        }

        [Theory]
        [InlineData(80, 1.66, 24.88)]
        [InlineData(100, 1.66, 31.21)]
        [InlineData(80, 1.66, 29.03)]

        public void CalcularIMC_RetornaResultado_ParaUmaListaDeValores(double primNumero, double segNumero, double resultadoEsperado)
        {
            var resultadoDoIMC = Operacoes.CalcularIMC(primNumero, segNumero);
            Assert.Equal(resultadoEsperado, resultadoDoIMC);
        }
    }
}
