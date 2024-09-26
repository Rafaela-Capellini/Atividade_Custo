using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustoFuncionarioApp.Models;
using System;

namespace CustoFuncionarioApp.Models.Tests
{
    [TestClass]
    public class CustoTests
    {
        private Custo _custo;

        [TestInitialize]
        public void Inicializar()
        {
            _custo = new Custo();
        }

        /*-------------------------------------------------*/

        [TestMethod]
        [DataRow(15000, 0)]
        [DataRow(1300, 0.075)]
        [DataRow(2350, 0.09)]
        [DataRow(3111, 0.12)]
        [DataRow(7021, 0.14)]
        
        [DataRow(1780.21, 0.09)]
        public void salario_DeveRetornarAliquotaInss(double salario, double esper)
        {
            // Arrange
            _custo.SalarioBruto = (decimal)salario;
            decimal esperado = (decimal)esper;

            // Act
            decimal obtido = _custo.getINSS_Aliquota();

            // Assert
            Assert.AreEqual(esperado, obtido, 2);
        }

        [TestMethod]

        [ExpectedException(typeof(ArgumentOutOfRangeException))]

        [DataRow(-7821, 0)]
        public void  Salarionegatio_DeveRetornarnada(double salario, double esper)
        {
            // Arrange
            _custo.SalarioBruto = (decimal)salario;
            decimal esperado = (decimal)esper;

            // Act
            decimal obtido = _custo.getINSS_Aliquota();

            // Assert
            Assert.AreEqual(esperado, obtido, 2);
        }

       

        [TestMethod]
        [DataRow(15000, 0)]
        [DataRow(1300, 97.50)]
        [DataRow(2350, 211.50)]
        [DataRow(3111, 373.32)]
        [DataRow(7021, 982.94)]
        
        [DataRow(1780.21, 160.21)]
        public void SalarioInss_RetornaValorPercentual(double salario, double esper)
        {
            // Arrange
            _custo.SalarioBruto = (decimal)salario;
            decimal esperado = (decimal)esper;

            // Act
            decimal obtido = _custo.getINSS_Valor();

            // Assert
            Assert.AreEqual(esperado, obtido, 2);
        }



        [TestMethod()]

        [ExpectedException(typeof(ArgumentOutOfRangeException))]

        [DataRow(-7821, 0)]
        public void SalarioInss_RetornaValorPercentualnega(double salario, double esper)
        {
            // Arrange
            _custo.SalarioBruto = (decimal)salario;
            decimal esperado = (decimal)esper;

            // Act
            decimal obtido = _custo.getINSS_Valor();

            // Assert
            Assert.AreEqual(esperado, obtido, 2);
        }

        /*-------------------------------------------------*/


        [TestMethod()]
        [DataRow(15000, 1200)]
        [DataRow(1300, 104)]
        [DataRow(2350, 188)]
        [DataRow(3111, 248.88)]
        [DataRow(7021, 561.68)]
        
        [DataRow(1780.21, 142.41)]
        public void FGTSSalario_CalculandooitoPorcent(double salario, double esper)
        {
            // Arrange
            _custo.SalarioBruto = (decimal)salario;
            decimal esperado = (decimal)esper;


            
            // Act
            decimal obtido = _custo.getFGTS();

            // Assert
            Assert.AreEqual(esperado, obtido, 2);
        }
        [TestMethod()]

        [ExpectedException(typeof(ArgumentOutOfRangeException))]

        [DataRow(-7821, 0)]
        public void FGTSSalarioNega_CalculandooitoPorcent(double salario, double esper)
        {
            // Arrange
            _custo.SalarioBruto = (decimal)salario;
            decimal esperado = (decimal)esper;



            // Act
            decimal obtido = _custo.getFGTS();

            // Assert
            Assert.AreEqual(esperado, obtido, 2);
        }

        /*-------------------------------------------------*/


        //em aver
        [TestMethod()]
        [DataRow(15000, 15000)]
        [DataRow(1300, 1300)]
        [DataRow(2350, 2350)]
        [DataRow(3111, 3111)]
        [DataRow(7021, 7021)]
       
        [DataRow(1780.21, 1780.21)]
        public void decimoterceirooSalario_valor(double salario, double esper)
        {
            // Arrange
            _custo.SalarioBruto = (decimal)salario;
            decimal esperado = (decimal)esper;

            // Act
            decimal obtido = _custo.get13oSalario();

            // Assert
            Assert.AreEqual(esperado, obtido, 2);
        }


        [TestMethod()]

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
 
        
        [DataRow(-7821, 0)]
        public void decimoterceirooSalarionega_valor(double salario, double esper)
        {
           
            // Arrange
            _custo.SalarioBruto = (decimal)salario;
            decimal esperado = (decimal)esper;

            // Act
            decimal obtido = _custo.get13oSalario();

            // Assert
            Assert.AreEqual(esperado, obtido, 2);
        }

        /*-------------------------------------------------*/

        [TestMethod()]


        [DataRow(15000, 20000)]
        [DataRow(1300, 1733.33)]
        [DataRow(2350, 3133.33)]
        [DataRow(3111, 4148)]
        [DataRow(7021, 9361.33)]
        [DataRow(1780.21, 2373.61)]

        public void Salario_ferias(double salario, double esper)
        {
            // Arrange
            _custo.SalarioBruto = (decimal)salario;
            decimal esperado = (decimal)esper;

            // Act
            decimal obtido = _custo.getFerias();

            // Assert
            Assert.AreEqual(esperado, obtido, 2);
        }

        [TestMethod()]


        [ExpectedException(typeof(ArgumentOutOfRangeException))]

        [DataRow(-7821, 0)]

        public void Salarionegar_ferias(double salario, double esper)
        {
            // Arrange
            _custo.SalarioBruto = (decimal)salario;
            decimal esperado = (decimal)esper;

            // Act
            decimal obtido = _custo.getFerias();

            // Assert
            Assert.AreEqual(esperado, obtido, 2);
        }


        /*-------------------------------------------------*/


        [TestMethod()]


        [DataRow(15000, 29.29)]
        [DataRow(1300, 28.66)]
        [DataRow(2350, 28.54)]
        [DataRow(3111, 28.30)]
        [DataRow(7021, 28.14)]
       
        [DataRow(1780.21, 28.54)]

        public void Retorna_PorcentualDespesa(double salario, double esper)
        {
            // Arrange
            _custo.SalarioBruto = (decimal)salario;
            decimal esperado = (decimal)esper;

            // Act
            decimal valorDespesa = (decimal)salario;
            decimal obtido = _custo.getPercentualDespesa(valorDespesa);

            // Assert
            Assert.AreEqual(esperado, obtido, 2);
        }

        [TestMethod()]


        [ExpectedException(typeof(ArgumentOutOfRangeException))]

        [DataRow(-7821, 0)]

        public void NãoRetorna_PorcentualDespesa(double salario, double esper)
        {
            // Arrange
            _custo.SalarioBruto = (decimal)salario;
            decimal esperado = (decimal)esper;

            // Act
            decimal valorDespesa = (decimal)salario;
            decimal obtido = _custo.getPercentualDespesa(valorDespesa);

            // Assert
            Assert.AreEqual(esperado, obtido, 2);
        }
        /*-------------------------------------------------*/


        [TestMethod()]

        [DataRow(15000, 51200)]
        [DataRow(1300, 4534.83)]
        [DataRow(2350, 8232.83)]
        [DataRow(3111, 10992.20)]
        [DataRow(7021, 24947.95)]
       
        [DataRow(1780.21, 6236.65)]

        public void getCusto_TotalTest(double salario, double esper)
        {
            _custo.SalarioBruto = (decimal)salario;
            decimal esperado = (decimal)esper;

            // Act
            decimal obtido = _custo.getCustoTotal();

            // Assert
            Assert.AreEqual(esperado, obtido, 2);
        }

        [TestMethod()]


        [ExpectedException(typeof(ArgumentOutOfRangeException))]

        [DataRow(-7821, 0)]

        public void NãogetCusto_TotalTest(double salario, double esper)
        {
            _custo.SalarioBruto = (decimal)salario;
            decimal esperado = (decimal)esper;

            // Act
            decimal obtido = _custo.getCustoTotal();

            // Assert
            Assert.AreEqual(esperado, obtido, 2);
        }
        /*-------------------------------------------------*/
    }
}
