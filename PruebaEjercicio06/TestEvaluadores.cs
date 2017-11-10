using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio06;

namespace PruebaEjercicio06
{
    [TestClass]
    public class TestEvaluadores
    {
        [TestMethod]
        public void TestEvaluadorEdad()
        {
            Cliente clienteTrue = new Cliente("Enrique", "Lagos", new DateTime(1960, 01, 19), TipoCliente.Cliente, new Empleo(150000, new DateTime(1980, 02, 20)));
            Cliente clienteFalse = new Cliente("Enrique", "Lagos", new DateTime(1920, 01, 19), TipoCliente.Cliente, new Empleo(150000, new DateTime(1940, 02, 20)));

            SolicitudPrestamo solicitudTrue = new SolicitudPrestamo(clienteTrue, 70000, 30);
            SolicitudPrestamo solicitudFalse = new SolicitudPrestamo(clienteFalse, 70000, 30);

            EvaluadorEdad evalEdad = new EvaluadorEdad(18, 75);
                  
            Assert.IsTrue(evalEdad.EsValida(solicitudTrue));
            Assert.IsFalse(evalEdad.EsValida(solicitudFalse));
        }

        [TestMethod]
        public void TestEvaluadorMonto()
        {
            Cliente clienteTrue = new Cliente("Enrique", "Lagos", new DateTime(1960, 01, 19), TipoCliente.Cliente, new Empleo(150000, new DateTime(1980, 02, 20)));
            Cliente clienteFalse = new Cliente("Enrique", "Lagos", new DateTime(1920, 01, 19), TipoCliente.Cliente, new Empleo(150000, new DateTime(1940, 02, 20)));

            SolicitudPrestamo solicitudTrue = new SolicitudPrestamo(clienteTrue, 70000, 30);
            SolicitudPrestamo solicitudFalse = new SolicitudPrestamo(clienteFalse, 170000, 30);

            EvaluadorMonto evalMonto = new EvaluadorMonto(100000);

            Assert.IsTrue(evalMonto.EsValida(solicitudTrue));
            Assert.IsFalse(evalMonto.EsValida(solicitudFalse));
        }

        [TestMethod]
        public void TestEvaluadorSueldo()
        {
            Cliente clienteTrue = new Cliente("Enrique", "Lagos", new DateTime(1960, 01, 19), TipoCliente.Cliente, new Empleo(150000, new DateTime(1980, 02, 20)));
            Cliente clienteFalse = new Cliente("Enrique", "Lagos", new DateTime(1920, 01, 19), TipoCliente.Cliente, new Empleo(1000, new DateTime(1940, 02, 20)));

            SolicitudPrestamo solicitudTrue = new SolicitudPrestamo(clienteTrue, 70000, 30);
            SolicitudPrestamo solicitudFalse = new SolicitudPrestamo(clienteFalse, 70000, 30);

            EvaluadorSueldo evalSueldo = new EvaluadorSueldo(5000);

            Assert.IsTrue(evalSueldo.EsValida(solicitudTrue));
            Assert.IsFalse(evalSueldo.EsValida(solicitudFalse));
        }

        [TestMethod]
        public void TestEvaluadorAntiguedad()
        {
            Cliente clienteTrue = new Cliente("Enrique", "Lagos", new DateTime(1960, 01, 19), TipoCliente.Cliente, new Empleo(150000, new DateTime(1980, 02, 20)));
            Cliente clienteFalse = new Cliente("Enrique", "Lagos", new DateTime(1920, 01, 19), TipoCliente.Cliente, new Empleo(150000, new DateTime(2017, 10, 12)));

            SolicitudPrestamo solicitudTrue = new SolicitudPrestamo(clienteTrue, 70000, 30);
            SolicitudPrestamo solicitudFalse = new SolicitudPrestamo(clienteFalse, 70000, 30);

            EvaluadorAntiguedadLaboral evalAntiguedad = new EvaluadorAntiguedadLaboral(6);

            Assert.IsTrue(evalAntiguedad.EsValida(solicitudTrue));
            Assert.IsFalse(evalAntiguedad.EsValida(solicitudFalse));
        }

        [TestMethod]
        public void TestEvaluadorCantCuotas()
        {
            Cliente clienteTrue = new Cliente("Enrique", "Lagos", new DateTime(1960, 01, 19), TipoCliente.Cliente, new Empleo(150000, new DateTime(1980, 02, 20)));
            Cliente clienteFalse = new Cliente("Enrique", "Lagos", new DateTime(1920, 01, 19), TipoCliente.Cliente, new Empleo(150000, new DateTime(2017, 10, 12)));

            SolicitudPrestamo solicitudTrue = new SolicitudPrestamo(clienteTrue, 70000, 30);
            SolicitudPrestamo solicitudFalse = new SolicitudPrestamo(clienteFalse, 70000, 48);

            EvaluadorCantidadCuotas evalAntiguedad = new EvaluadorCantidadCuotas(32);

            Assert.IsTrue(evalAntiguedad.EsValida(solicitudTrue));
            Assert.IsFalse(evalAntiguedad.EsValida(solicitudFalse));
        }

    }
}
