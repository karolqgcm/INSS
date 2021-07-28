using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using INSS;

namespace INSSTeste
{
    [TestClass]
    public class CalculadorINSSTeste
    {
        [TestMethod]
        public void TestMethod1()
        {

            //Arrange
            CalculardorINSS calculardorINSS = new CalculardorINSS();

            var data2011 = new DateTime(2011, 07, 28);
            var data2012 = new DateTime(2012, 07, 28);

            //Valores 2011
            var salario1_2011 = 0;           
            var salario2_2011 = 1106.90M;    
            var salario3_2011 = 1844.83M;    
            var salario4_2011 = 1844.84M;    
            var salario5_2011 = 3689.66M;    
            var salario6_2011 = 4000;        

            //Valores 2012
            var salario1_2012 = 0;
            var salario2_2012 = 1000;
            var salario3_2012 = 1500;
            var salario4_2012 = 1500.01M;
            var salario5_2012 = 3000.01M;
            var salario6_2012 = 5000;

            //Assert
            var descontoEsperado1_2011 = salario1_2011 * 0.08M;
            var desconto1_2011 = calculardorINSS.CalcularDesconto(data2011, salario1_2011);
            Assert.AreEqual(descontoEsperado1_2011, desconto1_2011);

            var descontoEsperado2_2011 = salario2_2011 * 0.08M;
            var desconto2_2011 = calculardorINSS.CalcularDesconto(data2011, salario2_2011);
            Assert.AreEqual(descontoEsperado2_2011, desconto2_2011);

            var descontoEsperado3_2011 = salario3_2011 * 0.09M;
            var desconto3_2011 = calculardorINSS.CalcularDesconto(data2011, salario3_2011);
            Assert.AreEqual(descontoEsperado3_2011, desconto3_2011);

            var descontoEsperado4_2011 = salario4_2011 * 0.11M;
            var desconto4_2011 = calculardorINSS.CalcularDesconto(data2011, salario4_2011);
            Assert.AreEqual(descontoEsperado4_2011, desconto4_2011);

            var descontoEsperado5_2011 = salario5_2011 * 0.11M;
            var desconto5_2011 = calculardorINSS.CalcularDesconto(data2011, salario5_2011);
            Assert.AreEqual(descontoEsperado5_2011, desconto5_2011);

            var descontoEsperado6_2011 = 405.86M;
            var desconto6_2011 = calculardorINSS.CalcularDesconto(data2011, salario6_2011);
            Assert.AreEqual(descontoEsperado6_2011, desconto6_2011);



            var descontoEsperado1_2012 = salario1_2012 * 0.07M;
            var desconto1_2012 = calculardorINSS.CalcularDesconto(data2012, salario1_2012);
            Assert.AreEqual(descontoEsperado1_2012, desconto1_2012);

            var descontoEsperado2_2012 = salario2_2012 * 0.07M;
            var desconto2_2012 = calculardorINSS.CalcularDesconto(data2012, salario2_2012);
            Assert.AreEqual(descontoEsperado2_2012, desconto2_2012);

            var descontoEsperado3_2012 = salario3_2012 * 0.08M;
            var desconto3_2012 = calculardorINSS.CalcularDesconto(data2012, salario3_2012);
            Assert.AreEqual(descontoEsperado3_2012, desconto3_2012);

            var descontoEsperado4_2012 = salario4_2012 * 0.09M;
            var desconto4_2012 = calculardorINSS.CalcularDesconto(data2012, salario4_2012);
            Assert.AreEqual(descontoEsperado4_2012, desconto4_2012);

            var descontoEsperado5_2012 = salario5_2012 * 0.11M;
            var desconto5_2012 = calculardorINSS.CalcularDesconto(data2012, salario5_2012);
            Assert.AreEqual(descontoEsperado5_2012, desconto5_2012);

            var descontoEsperado6_2012 = 500M;
            var desconto6_2012 = calculardorINSS.CalcularDesconto(data2012, salario6_2012);
            Assert.AreEqual(descontoEsperado6_2012, desconto6_2012);
        }
    }
}
