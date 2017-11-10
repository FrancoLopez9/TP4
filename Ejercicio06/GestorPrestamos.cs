using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    /// <summary>
    /// Clase que representa la gestion de las solicitudes de prestamos
    /// </summary>
    public class GestorPrestamos
    {

        private IDictionary<TipoCliente, IEvaluador> iEvaluadoresPorCliente;

        /// <summary>
        /// Constructor de GestorPrestamos
        /// </summary>
        public GestorPrestamos()
        {
            this.iEvaluadoresPorCliente = new Dictionary<TipoCliente, IEvaluador>();

            this.iEvaluadoresPorCliente.Add(TipoCliente.NoCliente, this.CrearEvaluadoresNoCliente());

            this.iEvaluadoresPorCliente.Add(TipoCliente.Cliente, this.CrearEvaluadoresCliente());

            this.iEvaluadoresPorCliente.Add(TipoCliente.ClienteGold, this.CrearEvaluadoresClienteGold());

            this.iEvaluadoresPorCliente.Add(TipoCliente.ClientePlatinum, this.CrearEvaluadoresClientePlatinum());
        }

        /// <summary>
        /// Metodo que crea un evaluador de No Cliente
        /// </summary>
        /// <returns></returns>
        private IEvaluador CrearEvaluadoresNoCliente()
        {
            EvaluadorCompuesto evaluadorCompuesto = new EvaluadorCompuesto();

            evaluadorCompuesto.AagregarEvaluador(new EvaluadorCantidadCuotas(12));

            evaluadorCompuesto.AagregarEvaluador(new EvaluadorMonto(20000));

            return evaluadorCompuesto;
        }

        /// <summary>
        /// Metodo que crea un evaluador de Cliente
        /// </summary>
        /// <returns></returns>
        private IEvaluador CrearEvaluadoresCliente()
        {
            EvaluadorCompuesto evaluadorCompuesto = new EvaluadorCompuesto();

            evaluadorCompuesto.AagregarEvaluador(new EvaluadorCantidadCuotas(32));

            evaluadorCompuesto.AagregarEvaluador(new EvaluadorMonto(100000));

            return evaluadorCompuesto;
        }

        /// <summary>
        /// Metodo que crea un evaluador de Cliente Gold
        /// </summary>
        /// <returns></returns>
        private IEvaluador CrearEvaluadoresClienteGold()
        {
            EvaluadorCompuesto evaluadorCompuesto = new EvaluadorCompuesto();

            evaluadorCompuesto.AagregarEvaluador(new EvaluadorCantidadCuotas(60));

            evaluadorCompuesto.AagregarEvaluador(new EvaluadorMonto(150000));

            return evaluadorCompuesto;
        }

        /// <summary>
        /// Metodo que crea un evaluador de Cliente Platinum
        /// </summary>
        /// <returns></returns>
        private IEvaluador CrearEvaluadoresClientePlatinum()
        {
            EvaluadorCompuesto evaluadorCompuesto = new EvaluadorCompuesto();

            evaluadorCompuesto.AagregarEvaluador(new EvaluadorCantidadCuotas(60));

            evaluadorCompuesto.AagregarEvaluador(new EvaluadorMonto(200000));

            return evaluadorCompuesto;
        }

        /// <summary>
        /// Metodo que valida segun el tipo de cliente
        /// </summary>
        /// <param name="pSolicitud"></param>
        /// <returns></returns>
        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            IEvaluador evaluador = this.iEvaluadoresPorCliente[pSolicitud.Cliente.TipoCliente];

            return evaluador.EsValida(pSolicitud);

        }

    }
}
