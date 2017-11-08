using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    class EvaluadorEdad
    {
        private double iEdadMinima;
        private double iEdadMaxima;

        public EvaluadorEdad(double pEdadMinima, double pEdadMaxima)
        {
            this.iEdadMinima = pEdadMinima;
            this.iEdadMaxima = pEdadMaxima;
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            DateTime fechaActual = DateTime.Today;
            DateTime fechaNacimiento = pSolicitud.Cliente.FechaNacimiento;
            int edad = fechaActual.Year - fechaNacimiento.Year;

            return edad <= this.iEdadMinima;
        }
    }
}
