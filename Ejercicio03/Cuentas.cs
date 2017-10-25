using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Cuentas
    {
        private Cliente iCliente;
        private Cuenta iCuentaCorriente;
        private Cuenta iCajaAhorro;

        public Cuentas(Cliente pCliente)
        {
            this.iCliente = pCliente;
            this.iCuentaCorriente = new Cuenta(1500, 1000);
            this.iCajaAhorro = new Cuenta(1500, 1000);
        }

        public Cuenta CuentaCorriente
        {
            get { return this.iCuentaCorriente; }

        }

        public Cuenta CajaAhorro
        {
            get { return this.iCajaAhorro; }

        }
    }
}
