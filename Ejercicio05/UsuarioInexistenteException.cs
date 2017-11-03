using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    class UsuarioInexistenteException : Exception
    {
        public UsuarioInexistenteException(string message) : base(message) { }
    }
}
