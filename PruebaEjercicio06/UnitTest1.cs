using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio06;

namespace PruebaEjercicio06
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Cliente cliente1 = new Cliente("Enrique", "Lagos", new DateTime(1920, 01, 19), TipoCliente.Cliente, new Empleo(150000, new DateTime(1940, 02, 20)));
        }
    }
}
