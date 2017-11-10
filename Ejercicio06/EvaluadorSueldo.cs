using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    /// <summary>
    /// Clase que representa la evaluacion al cliente en base a su sueldo
    /// </summary>
    public class EvaluadorSueldo : IEvaluador
    {
        private double iSueldoMinimo;

        public EvaluadorSueldo(double pSueldoMinimo)
        {
            this.iSueldoMinimo = pSueldoMinimo;
        }

        /// <summary>
        /// Metodo que valida al cliente segun el sueldo que posee
        /// </summary>
        /// <param name="pSolicitud"></param>
        /// <returns></returns>
        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            return pSolicitud.Cliente.Empleo.Sueldo >= this.iSueldoMinimo;
        }
    }
}
