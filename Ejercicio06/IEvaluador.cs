using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    /// <summary>
    /// Interfaz que representa un evaluador
    /// </summary>
    public interface IEvaluador
    {

        bool EsValida(SolicitudPrestamo pSolicitud);

    }
}
