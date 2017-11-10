using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    /// <summary>
    /// Clase que representa la evaluacion a un cliente segun distintas reglas
    /// </summary>
    public class EvaluadorCompuesto : IEvaluador
    {

        private IList<IEvaluador> iEvaluadores;

        public EvaluadorCompuesto()
        {
            this.iEvaluadores = new List<IEvaluador>();
        }

        /// <summary>
        /// Metodo que valida al cliente segun las diferentes reglas
        /// </summary>
        /// <param name="pSolicitud"></param>
        /// <returns></returns>
        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            bool esValida = true;

            IEnumerator<IEvaluador> enumerador = this.iEvaluadores.GetEnumerator();

            while (esValida && enumerador.MoveNext())
            {
                esValida = enumerador.Current.EsValida(pSolicitud);
            }

            return esValida;
        }

        /// <summary>
        /// Metodo que agrega evaluadores nuevos
        /// </summary>
        /// <param name="pEvaluador"></param>
        public void AagregarEvaluador(IEvaluador pEvaluador)
        {
            this.iEvaluadores.Add(pEvaluador);
        }
    }
}
