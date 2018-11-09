using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ5
{
    public class EvaluadorSueldo : IEvaluador
    {
        private double iSueldoMinimo;

        /// <summary>
        /// Crea una nueva instancia de EvaluadorSueldo.
        /// </summary>
        /// <param name="pSueldoMinimo">Sueldo mínimo que se debe tener para considerar a la solicitud como válida.</param>
        public EvaluadorSueldo(double pSueldoMinimo)
        {
            this.iSueldoMinimo = pSueldoMinimo;
        }

        /// <summary>
        /// Retorna si una solicitud es o no válida para el evaluador actual.
        /// </summary>
        /// <param name="pSolicitud">Solicitud a evaluar.</param>
        /// <returns>bool</returns>
        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            return pSolicitud.Cliente.Empleo.Sueldo >= iSueldoMinimo;
        }
    }
}
