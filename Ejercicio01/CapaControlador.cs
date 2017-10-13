using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    /// <summary>
    /// Clase que representa la 2da Capa
    /// </summary>
    class CapaControlador
    {
        /// <summary>
        /// Llama al metodo Ejecutar de la siguiente Capa
        /// </summary>
        public void Ejecutar()
        {
            CapaAplicacion pCapaAplicacion = new CapaAplicacion();
            pCapaAplicacion.Ejecutar();
        }
    }
}
