using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

using Ejercicio04;

namespace PruebaEjercicio04
{
    [TestClass]
    public class RepositorioUsuariosTest
    {
        [TestMethod]
        public void TestAgregar()
        {
            Usuario usuario1 = new Usuario("A30", "Carlito", "altocarl@gmail.com");
            Usuario usuario2 = new Usuario("A10", "Lili", "megalili@gmail.com");
            Usuario usuario3 = new Usuario("A50", "Poli", "superpoli@gmail.com");
            Usuario usuario4 = new Usuario("A91", "Ana", "ultraana@gmail.com");
            Usuario usuario5 = new Usuario("A60", "Tomi", "eltomito@gmail.com");

           
            RepositorioUsuarios repo = new RepositorioUsuarios();

            repo.Agregar(usuario1);
            repo.Agregar(usuario2);
            repo.Agregar(usuario3);
            repo.Agregar(usuario4);
            repo.Agregar(usuario5);

            IDictionary<String, Usuario>  resultadoEsperado = repo.Diccionario;

            Usuario value = new Usuario();
            repo.Diccionario.TryGetValue("A91", out value);
            Assert.AreEqual(value, usuario4);


        }
    }
}
