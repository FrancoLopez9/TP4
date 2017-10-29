using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    /// <summary>
    /// Clase que representa un comparador que ordena segun el correo del electronico del usuario.
    /// </summary>
    public class ComparadorPorCorreoElectronico : IComparer<Usuario>
    {
        public int Compare(Usuario pUsuario1, Usuario pUsuario2)
        {
            return string.Compare(pUsuario1.CorreoElectronico, pUsuario2.CorreoElectronico);
        }
    }
}
