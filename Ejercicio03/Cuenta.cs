using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Cuenta
    {
        private double iSaldo;
        private double iAcuerdo;

        public Cuenta() { }
        public Cuenta(double pAcuerdo)
        {
            this.iAcuerdo = pAcuerdo;
        }
        public Cuenta(double pSaldoInicial, double pAcuerdo)
        {
            this.iSaldo = pSaldoInicial;
            this.iAcuerdo = pAcuerdo;
        }

        public double Saldo
        {
            get { return this.iSaldo; }
            set { iSaldo = value; }
        }

        public double Acuerdo
        {
            get { return this.iAcuerdo; }
            set { iAcuerdo = value; }
        }

        public void AcreditarSaldo(double pSaldo)
        {
            Saldo = Saldo + pSaldo;
        }

        public Boolean DebitarSaldo(double pSaldo)
        {
            if (Saldo + Acuerdo >= pSaldo)
            {
                Saldo = Saldo - pSaldo;
                return true;
            }
            else
            {
                throw new SinFondosException("*******No se ha podido debitar ya que no hay fondos********"); 
            }
        }

    }
}
