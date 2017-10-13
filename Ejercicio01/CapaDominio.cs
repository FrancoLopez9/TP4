using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class CapaDominio
    {
        public void Ejecutar()
        {
            CapaPersistencia pCapaPersistencia = new CapaPersistencia();
            pCapaPersistencia.Ejecutar();
        }
    }
}
