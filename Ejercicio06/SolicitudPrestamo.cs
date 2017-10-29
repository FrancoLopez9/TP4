using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    public class SolicitudPrestamo
    {

        private Cliente iCliente;

        private double iMonto;

        private int iCantidadCuotas;

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
