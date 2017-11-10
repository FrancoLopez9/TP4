using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    /// <summary>
    /// Clase que representa la evaluacion al cliente en base a la cantidad de cuotas que pide el mismo
    /// </summary>
    public class EvaluadorCantidadCuotas : IEvaluador
    {

        private int iCantidadMaximaCuotas;

        public EvaluadorCantidadCuotas(int pCantidadMaxima)
        {
            this.iCantidadMaximaCuotas = pCantidadMaxima;
        }

        /// <summary>
        /// Metodo que valida al cliente segun la cantidad de cuotas que demanda
        /// </summary>
        /// <param name="pSolicitud"> Solicitud de prestamo del cliente </param>
        /// <returns></returns>
        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            return pSolicitud.CantidadCuotas <= this.iCantidadMaximaCuotas;
        }

    }
}
