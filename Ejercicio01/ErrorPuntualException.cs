using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    /// <summary>
    /// Clase que representa el Error Puntual en la Capa de Persistencia
    /// </summary>
    class ErrorPuntualException : ApplicationException
    {
        private DateTime iFecha;

        /// <summary>
        /// Crea un Error Puntual
        /// </summary>
        /// <param name="message"> mensaje de la Excepcion</param>
        /// <param name="pFecha"> fecha en que se produjo la Excepcion</param>
        public ErrorPuntualException(string message, DateTime pFecha) : base(message)
        {
            this.iFecha = pFecha;
        }

        public DateTime Fecha
        {
            get { return this.iFecha; }
        }
    }
}
