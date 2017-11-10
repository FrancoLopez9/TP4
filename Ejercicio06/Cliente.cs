using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    /// <summary>
    /// Clase que representa a un cliente
    /// </summary>
    public class Cliente
    {

        private String iNombre;

        private String iApellido;

        private DateTime iFechaNacimiento;

        private TipoCliente iTipoCliente;

        private Empleo iEmpleo;

        /// <summary>
        /// Constructor para el cliente a partir del nombre, apellido, fecha de nacimiento, tipo de cliente y empleo
        /// </summary>
        /// <param name="pNombre"> Nombre del cliente </param>
        /// <param name="pApellido"> Apellido del cliente </param>
        /// <param name="pFechaNacimiento"> Fecha de nacimiento del cliente </param>
        /// <param name="pTipoCliente"> Tipo de cliente </param>
        /// <param name="pEmpleo"> Empleo del cliente </param>
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
