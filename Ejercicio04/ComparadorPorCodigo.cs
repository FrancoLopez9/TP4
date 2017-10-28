using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    /// <summary>
    /// Clase que representa un comparador que ordena segun el codigo del usuario.
    /// </summary>
    public class ComparadorPorCodigo : IComparer<Usuario>
    {
        public int Compare(Usuario pUsuario1, Usuario pUsuario2)
        {
            return string.Compare(pUsuario1.Codigo, pUsuario2.Codigo);
        }
    }
}
