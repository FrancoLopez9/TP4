using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    /// <summary>
    /// Esta clase representa la division de numeros enteros.
    /// </summary>
    class Matematica 
    {
        /// <summary>
        /// Este metodo representa la division de numeros enteros.
        /// </summary>
        /// <param name="pDividendo">Este parametro representa al dividendo</param>
        /// <param name="pDivisor">Este parametro representa al divisor</param>
        /// <returns></returns>
        public double Dividir(int pDividendo, int pDivisor)
        {
            if (pDivisor == 0)
            {
                throw new DivisionPorCeroException("*******No se puede dividir por cero********");
            }
            else
            {
                return (double)pDividendo / (double)pDivisor;
            }
        }
    }
}
