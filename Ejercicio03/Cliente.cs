using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Cliente
    {
        private string iNroDocumento;
        private string iNombre;
        private TipoDocumento iTipoDocumento;

        public Cliente() { }
        public Cliente(TipoDocumento pTipoDocumento, string pNroDocumento, string pNombre)
        {
            this.iTipoDocumento = pTipoDocumento;
            this.iNroDocumento = pNroDocumento;
            this.iNroDocumento = pNombre;

        }

        public TipoDocumento TipoDocumento
        {
            get { return this.iTipoDocumento; }
            set { iTipoDocumento = value; }
        }

        public string NroDocumento
        {
            get { return this.iNroDocumento; }
            set { iNroDocumento = value; }
        }

        public string Nombre
        {
            get { return this.iNombre; }
            set { iNombre = value; }
        }
    }
}
