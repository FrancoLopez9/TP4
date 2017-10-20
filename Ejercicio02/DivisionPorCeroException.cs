using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    /// <summary>
    /// \Esta clase representa a la excepcion que surge por dividir un numero por 0.
    /// </summary>
    class DivisionPorCeroException : Exception
    {
        public DivisionPorCeroException(string message) : base(message) { }
    }
}
