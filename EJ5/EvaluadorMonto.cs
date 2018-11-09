using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ5
{
    public class EvaluadorMonto : IEvaluador
    {
        private double iMontoMaximo;

        /// <summary>
        /// Crea una nueva instancia de EvaluadorMonto.
        /// </summary>
        /// <param name="pMontoMaximo">Monto máximo que se puede solicitar para considerar a la solicitud como válida.</param>
        public EvaluadorMonto(double pMontoMaximo)
        {
            this.iMontoMaximo = pMontoMaximo;
        }

        /// <summary>
        /// Retorna si una solicitud es o no válida para el evaluador actual.
        /// </summary>
        /// <param name="pSolicitud">Solicitud a evaluar.</param>
        /// <returns>bool</returns>
        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            return pSolicitud.Monto <= this.iMontoMaximo;
        }
    }
}
