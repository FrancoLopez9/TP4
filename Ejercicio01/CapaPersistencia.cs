using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    /// <summary>
    /// Clase que representa la 5ta Capa
    /// </summary>
    class CapaPersistencia
    {
        /// <summary>
        /// Crea el nivel de Capa Persistencia y lanza la Excepcion ErrorPuntualException
        /// </summary>
        public CapaPersistencia()
        {
            throw new ErrorPuntualException("Se ha producido un error", DateTime.Now);
        }

        /// <summary>
        /// A modo de ejemplo escribe una sentencia pero no llega a ejecutarse por las excepciones
        /// </summary>
        public void Ejecutar()
        {
            Console.WriteLine("Se ha ejecutado correctamente.");
            Console.ReadKey();
        }
    }
}
