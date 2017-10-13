using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    /// <summary>
    /// Clase que representa la 1ra Capa
    /// </summary>
    class CapaVista
    {
        /// <summary>
        /// Llama al metodo Ejecutar de la siguiente Capa
        /// </summary>
        public void Ejecutar()
        {
            try
            {
                CapaControlador pCapaControlador = new CapaControlador();
                pCapaControlador.Ejecutar();
            }
            catch (CapaAplicacionException pExcepcion)
            {
                Console.WriteLine(pExcepcion.Message);
                Console.WriteLine("La excepción de aplicación sucedió en: " + pExcepcion.FechaErrorAplicacion);
                Console.WriteLine("La excepción puntual sucedió en: " + pExcepcion.FechaErrorPuntual);
            }
        }
    }
}
