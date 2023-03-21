using Microsoft.VisualStudio.TestTools.UnitTesting;
using TesteIMC;

namespace TestarIMC
{
    //Classe de teste para executar
    [TestClass]

    public class CalculoIMCTests
    {
        [TestMethod]
        public void CalcularIMC()
        {
            //Arrange
            double peso = 110;
            double altura = 1.79;
            
            //Act
            var resultadoIMC = Operacoes.CalcularIMC(peso, altura);

            //Assert

            Assert.AreEqual(34.33, resultadoIMC);
        }
    }
}
