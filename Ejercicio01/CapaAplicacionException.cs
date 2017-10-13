using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    public class CapaAplicacionException : ApplicationException
    {
        //Atributos
        private DateTime iFecha;

        //Constructor
        public CapaAplicacionException(string pMensaje, DateTime pFecha) : base(pMensaje)
        {
            iFecha = pFecha;
        }

        public DateTime Fecha
        {
            get { return this.iFecha; }
        }
    }
}

