using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    public class GestorPrestamos
    {

        private IDictionary<TipoCliente, IEvaluador> iEvaluadoresPorCliente;

        public GestorPrestamos()
        {
            this.iEvaluadoresPorCliente = new Dictionary<TipoCliente, IEvaluador>();

            this.iEvaluadoresPorCliente.Add(TipoCliente.NoCliente, this.CrearEvaluadoresNoCliente());

            this.iEvaluadoresPorCliente.Add(TipoCliente.Cliente, this.CrearEvaluadoresCliente());
        }

        private IEvaluador CrearEvaluadoresNoCliente()
        {
            EvaluadorCompuesto evaluadorCompuesto = new EvaluadorCompuesto();

            evaluadorCompuesto.AagregarEvaluador(new EvaluadorCantidadCuotas(12));

            evaluadorCompuesto.AagregarEvaluador(new EvaluadorMonto(20000));

            return evaluadorCompuesto;
        }

        private IEvaluador CrearEvaluadoresCliente()
        {
            EvaluadorCompuesto evaluadorCompuesto = new EvaluadorCompuesto();

            evaluadorCompuesto.AagregarEvaluador(new EvaluadorCantidadCuotas(32));

            evaluadorCompuesto.AagregarEvaluador(new EvaluadorMonto(100000));

            return evaluadorCompuesto;
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            IEvaluador evaluador = this.iEvaluadoresPorCliente[pSolicitud.Cliente.TipoCliente];

            return evaluador.EsValida(pSolicitud);

        }

    }
}
