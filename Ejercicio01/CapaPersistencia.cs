using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class CapaPersistencia
    {
        public CapaPersistencia()
        {
            throw new ErrorPuntualException("Se ha producido un error", DateTime.Now);
        }

        public void Ejecutar()
        {
            Console.WriteLine("Se ha ejecutado correctamente.");
            Console.ReadKey();
        }
    }
}
