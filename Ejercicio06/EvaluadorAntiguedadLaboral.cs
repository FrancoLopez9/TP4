using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    /// <summary>
    /// Clase que representa la evaluacion al cliente en base a su antiguedad laboral
    /// </summary>
    public class EvaluadorAntiguedadLaboral : IEvaluador
    {
        private int iAntiguedadMinima;

        public EvaluadorAntiguedadLaboral(int pAntiguedadMinima)
        {
            this.iAntiguedadMinima = pAntiguedadMinima;
        }

        /// <summary>
        /// Metodo que valida al cliente segun su antiguedad laboral
        /// </summary>
        /// <param name="pSolicitud"> Solicitud de prestamo del cliente </param>
        /// <returns></returns>
        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            DateTime fechaActual = DateTime.Today;
            DateTime fechaIngreso = pSolicitud.Cliente.Empleo.FechaIngreso;
            TimeSpan antiguedad = fechaActual.Subtract(fechaIngreso);
            double meses = antiguedad.TotalDays / 30;

            return meses >= this.iAntiguedadMinima;
        }
    }
}
