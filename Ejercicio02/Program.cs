using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********CALCULADORA DIVISORA***********");
            Console.WriteLine("Ingrese el valor del Dividendo: ");
            int pDividendo = System.Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del Divisor: ");
            int pDivisor = System.Convert.ToInt16(Console.ReadLine());
            Fachada pFachada = new Fachada();
            pFachada.Dividir(pDividendo, pDivisor);
            Console.ReadKey();
        }
    }
}
