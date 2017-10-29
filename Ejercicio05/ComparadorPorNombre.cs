using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    /// <summary>
    /// Clase que representa un comparador que ordena segun el nombre completo del usuario.
    /// </summary>
    public class ComparadorPorNombre : IComparer<Usuario>
    {
        public int Compare(Usuario pUsuario1, Usuario pUsuario2)
        {
            return string.Compare(pUsuario1.NombreCompleto, pUsuario2.NombreCompleto);
        }
    }
}
