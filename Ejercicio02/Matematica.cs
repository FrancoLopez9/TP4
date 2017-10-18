using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Matematica
    {
        public double Dividir(int pDividendo, int pDivisor)
        {
            if (pDivisor == 0)
            {
                throw new DivisionPorCeroException("No se puede dividir por cero");
            }
            else
            {
                return pDividendo / pDivisor;
            }
        }
    }
}
