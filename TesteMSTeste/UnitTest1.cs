using Projeto_teste;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TesteMSTeste
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SomarDoisNumeros()
        {
            //Arrange = Preparação
            double pNum = 1;
            double sNum = 2;
            double rNum = 3;

            //Act = Ação
            var resultado = Operacoes.Somar(pNum, sNum);

            //Assert = Verificação
            Assert.AreEqual(rNum, resultado);
        }

        //Arrange
        [DataTestMethod]
        [DataRow(1,1,2)]
        [DataRow(2,2,4)]
        [DataRow(3,1,2)]

        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum) 
        {
            //Act
            var resultado = Operacoes.Somar(pNum, sNum);

            //Assert
            Assert.AreEqual(rNum, resultado);

        }
    }
}