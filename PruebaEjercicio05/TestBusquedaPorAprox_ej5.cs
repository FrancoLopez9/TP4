using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

using Ejercicio05;


namespace PruebaEjercicio05
{
    [TestClass]
    public class TestBusquedaPorAprox_ej5
    {
        [TestMethod]
        public void TestBusquedaPorAprox_5()
        {
            Usuario usuario1 = new Usuario("A30", "Carlito", "altocarl@gmail.com");
            Usuario usuario2 = new Usuario("A10", "Lili", "megalili@gmail.com");
            Usuario usuario3 = new Usuario("A50", "Poli", "superpoli@gmail.com");
            Usuario usuario4 = new Usuario("A91", "Ana", "ultraana@gmail.com");
            Usuario usuario5 = new Usuario("A60", "Tomi", "eltomito@gmail.com");

            RepositorioUsuarios repo = new RepositorioUsuarios();

            IList<Usuario> listaEsperada = new List<Usuario>();

            listaEsperada.Add(usuario1);
            listaEsperada.Add(usuario2);
            listaEsperada.Add(usuario3);

            repo.Agregar(usuario1);
            repo.Agregar(usuario2);
            repo.Agregar(usuario3);
            repo.Agregar(usuario4);
            repo.Agregar(usuario5);

            IList<Usuario> listaActual = repo.BusquedaAproxPorNombre("li");

            Assert.AreEqual(listaEsperada[0], listaActual[0]);
            Assert.AreEqual(listaEsperada[1], listaActual[1]);
            Assert.AreEqual(listaEsperada[2], listaActual[2]);


        }

    }
}
