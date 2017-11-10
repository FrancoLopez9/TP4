using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    /// <summary>
    /// Clase que representa el controlador de fachada
    /// </summary>
    class Fachada
    {
       
        /// <summary>
        /// Metodo que valida si el tipo de cliente es correcto
        /// </summary>
        /// <param name="pSolicitud"> Solicitud de prestamo del cliente </param>
        /// <returns></returns>
        public bool ValidarSolicitudTipoCliente(SolicitudPrestamo pSolicitud)
        {
            GestorPrestamos iGestor = new GestorPrestamos();
                 
            return iGestor.EsValida(pSolicitud);
                       
        }

        /// <summary>
        /// Metodo que valida si al cliente se le aprueba la solicitud que pide 
        /// </summary>
        /// <param name="pSolicitud"></param>
        /// <returns></returns>
        public bool ValidarSolicitudReglas(SolicitudPrestamo pSolicitud)
        {
            EvaluadorCompuesto iEvaluador = new EvaluadorCompuesto();

            return iEvaluador.EsValida(pSolicitud);
        }
        



    }
}
