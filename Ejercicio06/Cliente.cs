using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    public class Cliente
    {

        private String iNombre;

        private String iApellido;

        private DateTime iFechaNacimiento;

        private TipoCliente iTipoCliente;

        private Empleo iEmpleo;

        public Cliente(String pNombre, String pApellido, DateTime pFechaNacimiento, TipoCliente pTipoCliente, Empleo pEmpleo)
        {
            this.iNombre = pNombre;
            this.iApellido = pApellido;
            this.iFechaNacimiento = pFechaNacimiento;
            this.iTipoCliente = pTipoCliente;
            this.iEmpleo = pEmpleo;
        }

        public String Nombre { get { return this.iNombre; } }

        public String Apellido { get { return this.iApellido; } }

        public DateTime FechaNacimiento { get { return this.iFechaNacimiento; } }

        public TipoCliente TipoCliente { get { return this.iTipoCliente; } }

        public Empleo Empleo { get { return this.iEmpleo; } }

    }
}
