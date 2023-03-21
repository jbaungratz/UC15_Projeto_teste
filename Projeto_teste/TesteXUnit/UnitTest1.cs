using Projeto_teste;

namespace TesteXUnit
{
    public class UnitTest1
    {
        [Fact]
        public void SomarDoisNumeros()
        {
            //Arrange
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;

            //Act
            var resultado = Operacoes.Somar(pNum, sNum);

            //Assert
            Assert.Equal(rNum, resultado);
        }

        //Arrange
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(3, 1, 5)]
        [InlineData(4, 2, 6)]

        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            //Act
            var resultado = Operacoes.Somar(pNum, sNum);

            //Assert
            Assert.Equal(rNum, resultado);
        }

    }

}