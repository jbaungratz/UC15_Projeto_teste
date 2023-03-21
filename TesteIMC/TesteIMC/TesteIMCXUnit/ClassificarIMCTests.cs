using TestarIMC;
using TesteIMC;
using Xunit;

namespace TesteIMCXUnit
{
    public class ClassificarIMCTests
    {
        
        [Fact]

        public void ClassificarIMC_RetornaResultado()
        {
            //Arrange
            double imc = 28;


            //Act
            var classificacaoIMC = Operacoes.ClassificarIMC(imc);

            //Assert

            Assert.Equal("Sobrepeso", classificacaoIMC);
        }

        [Theory]
        [InlineData(28, "Sobrepeso")]
        [InlineData(31, "Obesidade Grau I")]
        [InlineData(22, "Abaixo do Peso")]
        [InlineData(23, "Peso Normal")]

        public void ClassificarIMC_RetornaResultado_ParaUmaListaDeValores(double primNumero, string resultadoEsperado) 
        {
            var resultadoDoIMC = Operacoes.ClassificarIMC(primNumero);
            Assert.Equal(resultadoEsperado, resultadoDoIMC);
        } 


    }
}
