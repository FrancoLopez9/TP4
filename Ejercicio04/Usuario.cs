using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    class Usuario
    {
        private String iCodigo;
        private String iNombreCompleto;
        private String iCorreoElectronico;

        public String Codigo
        {
            get { return this.iCodigo; }
            set { iCodigo = value; }
        }

        public String NombreCompleto
        {
            get { return this.iNombreCompleto; }
            set { iNombreCompleto = value; }
        }

        public String CorreoElectronico
        {
            get { return this.iCorreoElectronico; }
            set { iCorreoElectronico = value; }
        }
    }
}
