using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class SinFondosException : Exception
    {
        public SinFondosException(string message) : base(message) { }
    }
}
