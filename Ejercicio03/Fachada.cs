using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Fachada
    {
        private Cuentas iCuentas;

        public Fachada()
        {
            this.iCuentas = new Cuentas(new Cliente(TipoDocumento.DNI, "13171597", "Fabian"));
        }

        public double MostrarSaldoCajaAhorro()
        {
            return this.iCuentas.CajaAhorro.Saldo;

        }

        public double MostrarSaldoCuentaCorriente()
        {
            return this.iCuentas.CuentaCorriente.Saldo;
        }

        public void AcreditarSaldoCajaAhorro(double pSaldo)
        {
            this.iCuentas.CajaAhorro.AcreditarSaldo(pSaldo);
        }

        public void AcreditarSaldoCuentaCorriente(double pSaldo)
        {
            this.iCuentas.CuentaCorriente.AcreditarSaldo(pSaldo);
        }

        public Boolean DebitarSaldoCajaAhorro(double pSaldo)
        {
            return iCuentas.CajaAhorro.DebitarSaldo(pSaldo);
        }

        public Boolean DebitarSaldoCuentaCorriente(double pSaldo)
        {
            return iCuentas.CuentaCorriente.DebitarSaldo(pSaldo);
        }


    }
}
