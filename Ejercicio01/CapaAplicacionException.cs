using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    /// <summary>
    /// Clase que representa la excepcion tratada en la capa de aplicacion
    /// </summary>
    public class CapaAplicacionException : ApplicationException
    {
        private DateTime iFechaErrorAplicacion;
        private DateTime iFechaErrorPuntual;

        /// <summary>
        /// Crea una excepcion propia de la Capa de Aplicacion
        /// </summary>
        /// <param name="message"> mensaje de la Excepcion</param>
        /// <param name="pFechaErrorAplicacion"> fecha en que se produce la Excepcion</param>
        /// <param name="pFechaErrorPuntual"> fecha en la que se habia producido el Error puntual propagado</param>
        public CapaAplicacionException(string message, DateTime pFechaErrorAplicacion, DateTime pFechaErrorPuntual) : base(message)
        {
            this.iFechaErrorAplicacion = pFechaErrorAplicacion;
            this.iFechaErrorPuntual = pFechaErrorPuntual;
        }

        public DateTime FechaErrorAplicacion
        {
            get { return this.iFechaErrorAplicacion; }
        }
        public DateTime FechaErrorPuntual
        {
            get { return this.iFechaErrorPuntual; }
        }
    }
}

