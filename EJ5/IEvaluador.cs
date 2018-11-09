using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ5
{
    public interface IEvaluador
    {
        /// <summary>
        /// Retorna si una solicitud es o no válida.
        /// </summary>
        /// <param name="pSolicitud">Solicitud a evaluar.</param>
        /// <returns>bool</returns>
        bool EsValida(SolicitudPrestamo pSolicitud);
    }
}
