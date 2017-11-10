using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    /// <summary>
    /// Clase que representa la evaluacion al cliente en base al monto que pide el mismo
    /// </summary>
    public class EvaluadorMonto : IEvaluador
    {

        private double iMontoMaximo;

        public EvaluadorMonto(double pMontoMaximo)
        {
            this.iMontoMaximo = pMontoMaximo;
        }

        /// <summary>
        /// Metodo que valida al cliente segun el monto que demanda
        /// </summary>
        /// <param name="pSolicitud"></param>
        /// <returns></returns>
        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            return pSolicitud.Monto <= this.iMontoMaximo;
        }

    }
}
