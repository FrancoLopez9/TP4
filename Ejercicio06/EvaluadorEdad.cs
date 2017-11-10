using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    /// <summary>
    /// Clase que representa la evaluacion al cliente en base a la edad
    /// </summary>
    public class EvaluadorEdad : IEvaluador
    {
        private double iEdadMinima;
        private double iEdadMaxima;

        public EvaluadorEdad(double pEdadMinima, double pEdadMaxima)
        {
            this.iEdadMinima = pEdadMinima;
            this.iEdadMaxima = pEdadMaxima;
        }

        /// <summary>
        /// Metodo que valida al cliente segun la edad correspondiente
        /// </summary>
        /// <param name="pSolicitud"></param>
        /// <returns></returns>
        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            DateTime fechaActual = DateTime.Today;
            DateTime fechaNacimiento = pSolicitud.Cliente.FechaNacimiento;
            int edad = fechaActual.Year - fechaNacimiento.Year;

            return (edad >= this.iEdadMinima) && (edad <= this.iEdadMaxima);
        }
    }
}
