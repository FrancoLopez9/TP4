using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    /// <summary>
    /// Clase que representa el empleo del cliente
    /// </summary>
    public class Empleo
    {

        private double iSueldo;

        private DateTime iFechaIngreso;

        /// <summary>
        /// Constructor del empleo a partir del sueldo y fecha de ingreso del cliente
        /// </summary>
        /// <param name="pSueldo"></param>
        /// <param name="pFechaIngreso"></param>
        public Empleo(double pSueldo, DateTime pFechaIngreso)
        {
            this.iSueldo = pSueldo;
            this.iFechaIngreso = pFechaIngreso;
        }

        public double Sueldo { get { return this.iSueldo; } }

        public DateTime FechaIngreso { get { return this.iFechaIngreso; } }

    }
}
