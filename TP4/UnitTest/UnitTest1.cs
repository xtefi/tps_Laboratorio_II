using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LlenarSilo_SiRecibe_HumedadNegativa_DeberiaRetornarFalse()
        {
            //Arrange
            Acopio silo = new Acopio();
            bool actual;
            int toneladas =50;
            double humedad=-2;
            //Act
            actual = silo.LlenarSilo(toneladas, humedad);
            //Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
       
        public void VaciarSilo_SiCantidadToneladas_EsIgualALimiteMaximo()
        {
            //Arrange
            Acopio silo = new Acopio();
            int toneladas = 50;
            double humedad = 3;
            int actual;
            int esperado=1;
            //Act
            silo.LlenarSilo(toneladas, humedad);
            actual = silo.VaciarSilo(toneladas);
            //Assert
            Assert.AreEqual(actual, esperado);
        }
    }
}