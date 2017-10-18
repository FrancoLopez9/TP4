using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Fachada
    {
        //borrar este comentario
        public Dividir()
        {
            Console.WriteLine("Ingrese el valor del Dividendo: ");
            int pDividendo = System.Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del Divisor: ");
            int pDivisor = System.Convert.ToInt16(Console.ReadLine());
            Matematica pMatematica = new Matematica();
            try
            {
                double pResultado = pMatematica.Dividir(pDividendo, pDivisor);
                con
            }
            catch
        }
    }
}
