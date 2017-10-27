using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejericicio03
{
    /// <summary>
    /// Excepcion para cuando la cuenta no tiene fondos al debitar.
    /// </summary>
    class SinFondosException : Exception
    {
        public SinFondosException(string message) : base(message) { }
    }
}
