using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    /// <summary>
    /// Clase que representa un Usuario.
    /// </summary>
    public class Usuario
    {
        //Atributos
        private String iCodigo;
        private String iNombreCompleto;
        private String iCorreoElectronico;


        public Usuario() { }
        /// <summary>
        /// Crea un usuario a partir del codigo, nombre completo y correo electronico.
        /// </summary>
        /// <param name="pCodigo"></param>
        /// <param name="pNombreCompleto"></param>
        /// <param name="pCorreoElectronico"></param>
        public Usuario(String pCodigo, String pNombreCompleto, String pCorreoElectronico)
        {
            this.iCodigo = pCodigo;
            this.iNombreCompleto = pNombreCompleto;
            this.iCorreoElectronico = pCorreoElectronico;
        }

        //Propiedades
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

        public override bool Equals(object value)
        {
            if (value == null)
            {
                return false;
            }
            Usuario pUsuario = value as Usuario;
            return (pUsuario != null)
                && (Codigo == pUsuario.Codigo);
        }

        public override int GetHashCode()
        {
            return iCodigo.GetHashCode();
        }
    }
}
