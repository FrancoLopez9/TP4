using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    /// <summary>
    /// Esta clase representa el controlador de fachada
    /// </summary>
    class Fachada
    {
       /// <summary>
       /// Este metodo realiza la division de numeros enteros
       /// </summary>
       /// <param name="pDividendo">Este parametro representa al numero dividendo</param>
       /// <param name="pDivisor">Este parametro representa al numero divisor</param>
       public void Dividir(int pDividendo, int pDivisor)
        {
            Matematica pMatematica = new Matematica();
            try
            {
                double pResultado = pMatematica.Dividir(pDividendo, pDivisor);
                Console.WriteLine("El resultado es: " + pResultado);

            }
            catch (DivisionPorCeroException pException)
            {
                Console.WriteLine(pException.Message);
                Console.WriteLine(pException.StackTrace);
            }
            
        }
    }
}
