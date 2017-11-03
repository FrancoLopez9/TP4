using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

using Ejercicio05;

namespace PruebaEjercicio05
{
    [TestClass]
    public class TestOrdenarPorNombre_ej5
    {
        [TestMethod]
        public void TestOrdenarPorNombre_5()
        {
            Usuario usuario1 = new Usuario("A30", "Carlito", "altocarl@gmail.com");
            Usuario usuario2 = new Usuario("A10", "Lili", "megalili@gmail.com");
            Usuario usuario3 = new Usuario("A50", "Poli", "superpoli@gmail.com");
            Usuario usuario4 = new Usuario("A91", "Ana", "ultraana@gmail.com");
            Usuario usuario5 = new Usuario("A60", "Tomi", "eltomito@gmail.com");


            RepositorioUsuarios repo = new RepositorioUsuarios();

            ComparadorPorNombre comparador = new ComparadorPorNombre();

            IList<Usuario> listita = new List<Usuario>();

            listita.Add(usuario4);
            listita.Add(usuario1);
            listita.Add(usuario2);
            listita.Add(usuario3);
            listita.Add(usuario5);


            repo.Agregar(usuario1);
            repo.Agregar(usuario2);
            repo.Agregar(usuario3);
            repo.Agregar(usuario4);
            repo.Agregar(usuario5);

            Assert.AreEqual(listita[0], repo.ObtenerOrdenadosPor(comparador)[0]);
            Assert.AreEqual(listita[1], repo.ObtenerOrdenadosPor(comparador)[1]);
            Assert.AreEqual(listita[2], repo.ObtenerOrdenadosPor(comparador)[2]);
            Assert.AreEqual(listita[3], repo.ObtenerOrdenadosPor(comparador)[3]);
            Assert.AreEqual(listita[4], repo.ObtenerOrdenadosPor(comparador)[4]);
        }
    }
}
