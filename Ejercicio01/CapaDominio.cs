using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    /// <summary>
    /// Clase que representa la 4ta Capa
    /// </summary>
    class CapaDominio
    {
        /// <summary>
        /// Llama al metodo Ejecutar de la siguiente Capa
        /// </summary>
        public void Ejecutar()
        {
            CapaPersistencia pCapaPersistencia = new CapaPersistencia();
            pCapaPersistencia.Ejecutar();
        }
    }
}
