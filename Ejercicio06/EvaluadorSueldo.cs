using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    class EvaluadorSueldo
    {
        private double iSueldoMinimo;

        public EvaluadorSueldo(double pSueldoMinimo)
        {
            this.iSueldoMinimo = pSueldoMinimo;
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            return pSolicitud.Cliente.Empleo.Sueldo <= this.iSueldoMinimo;
        }
    }
}
