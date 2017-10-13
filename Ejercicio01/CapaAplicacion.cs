using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    /// <summary>
    /// Clase que representa la 3ra Capa
    /// </summary>
    class CapaAplicacion
    {
        /// <summary>
        /// Llama al metodo Ejecutar de la siguiente Capa
        /// </summary>
        public void Ejecutar()
        {
            try
            {
                CapaDominio pCapaDominio = new CapaDominio();
                pCapaDominio.Ejecutar();
            }
            catch (ErrorPuntualException pException)
            {
                throw new CapaAplicacionException("La excepción ha sido tratada", DateTime.Now, pException.Fecha);
            }
        }
    }
}
