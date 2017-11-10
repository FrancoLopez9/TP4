using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    /// <summary>
    /// Clase que representa una solicitud de prestamo
    /// </summary>
    public class SolicitudPrestamo
    {

        private Cliente iCliente;

        private double iMonto;

        private int iCantidadCuotas;
                
        /// <summary>
        /// Constructor de una solicitud de prestamo a partir de un cliente, monto y cantidad de cuotas
        /// </summary>
        /// <param name="pCliente"></param>
        /// <param name="pMonto"></param>
        /// <param name="pCantidadCoutas"></param>
        public SolicitudPrestamo(Cliente pCliente, double pMonto, int pCantidadCoutas)
        {
            this.iCliente = pCliente;
            this.iMonto = pMonto;
            this.iCantidadCuotas = pCantidadCoutas;
            
        }

        public Cliente Cliente { get { return this.iCliente; } }

        public double Monto { get { return this.iMonto; } }

        public int CantidadCuotas { get { return this.iCantidadCuotas; } }

      
    }
}
