using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ5
{
    public class EvaluadorAntiguedadLaboral : IEvaluador
    {
        private int iAntiguedadMinima;

        /// <summary>
        /// Crea una nueva instancia de EvaluadorAntiguedadLaboral.
        /// </summary>
        /// <param name="pAntiguedadMinima">Antigüedad laboral mínima que se debe tener para considerar a la solicitud como válida.</param>
        public EvaluadorAntiguedadLaboral(int pAntiguedadMinima)
        {
            this.iAntiguedadMinima = pAntiguedadMinima;
        }

        /// <summary>
        /// Retorna si una solicitud es o no válida para el evaluador actual.
        /// </summary>
        /// <param name="pSolicitud">Solicitud a evaluar.</param>
        /// <returns>bool</returns>
        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            return CalculoTemporal.DiferenciaMensual(pSolicitud.Cliente.Empleo.FechaIngreso, DateTime.Today) >= this.iAntiguedadMinima;
        }
    }
}
