using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    class ComparadorPorNombre : IComparer<Usuario>
    {
        public int Compare(Usuario pUsuario1, Usuario pUsuario2)
        {
            return string.Compare(pUsuario1.NombreCompleto, pUsuario2.NombreCompleto);
        }
    }
}
