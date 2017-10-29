using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    public class EvaluadorCompuesto : IEvaluador
    {

        private IList<IEvaluador> iEvaluadores;

        public EvaluadorCompuesto()
        {
            this.iEvaluadores = new List<IEvaluador>();
        }

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

        public void AagregarEvaluador(IEvaluador pEvaluador)
        {
            this.iEvaluadores.Add(pEvaluador);
        }
    }
}
