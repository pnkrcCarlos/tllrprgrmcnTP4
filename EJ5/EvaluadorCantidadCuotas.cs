using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ5
{
    public class EvaluadorCantidadCuotas : IEvaluador
    {
        private int iCantidadMaximaCuotas;

        /// <summary>
        /// Crea una nueva instancia de EvaluadorCantidadCuotas.
        /// </summary>
        /// <param name="pCantidadMaximaCuotas">Cantidad máxima de cuotas que se pueden tener para considerar a la solicitud como válida.</param>
        public EvaluadorCantidadCuotas(int pCantidadMaximaCuotas)
        {
            this.iCantidadMaximaCuotas = pCantidadMaximaCuotas;
        }

        /// <summary>
        /// Retorna si una solicitud es o no válida para el evaluador actual.
        /// </summary>
        /// <param name="pSolicitud">Solicitud a evaluar.</param>
        /// <returns>bool</returns>
        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            return pSolicitud.CantidadCuotas <= this.iCantidadMaximaCuotas;
        }
    }
}
