using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    class EvaluadorAntiguedadLaboral
    {
        private int iAntiguedadMinima;

        public EvaluadorAntiguedadLaboral(int pAntiguedadMinima)
        {
            this.iAntiguedadMinima = pAntiguedadMinima;
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            DateTime fechaActual = DateTime.Today;
            DateTime fechaIngreso = pSolicitud.Cliente.Empleo.FechaIngreso;
            int antiguedad = fechaActual.Year - fechaIngreso.Year;

            return antiguedad <= this.iAntiguedadMinima;
        }
    }
}
