using Microsoft.VisualStudio.TestTools.UnitTesting;
using TesteIMC;

namespace TestarIMC
{
    //Classe de teste para executar
    [TestClass]

    public class ClassificarIMCTests
    {
        [TestMethod]
        public void ClassificarIMC()
        {
            //Arrange
            double imc = 28;
            

            //Act
            var classificacaoIMC = Operacoes.ClassificarIMC(imc);

            //Assert

            Assert.AreEqual("Sobrepeso", classificacaoIMC);
        }
    }
}

