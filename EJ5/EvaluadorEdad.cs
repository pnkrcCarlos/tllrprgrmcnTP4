using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ5
{
    public class EvaluadorEdad : IEvaluador
    {
        private int iEdadMinima;
        private int iEdadMaxima;

        /// <summary>
        /// Crea una nueva instancia de EvaluadorEdad.
        /// </summary>
        /// <param name="pEdadMinima">Edad mínima para considerar a la solicitud como válida.</param>
        /// <param name="pEdadMaxima">Edad máxima para considerar a la solicitud como válida.</param>
        public EvaluadorEdad(int pEdadMinima, int pEdadMaxima)
        {
            this.iEdadMinima = pEdadMinima;
            this.iEdadMaxima = pEdadMaxima;
        }

        /// <summary>
        /// Retorna si una solicitud es o no válida para el evaluador actual.
        /// </summary>
        /// <param name="pSolicitud">Solicitud a evaluar.</param>
        /// <returns>bool</returns>
        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            int edadCliente = CalculoTemporal.DiferenciaAnual(pSolicitud.Cliente.FechaNacimiento, DateTime.Today);
            return (edadCliente >= iEdadMinima && edadCliente < iEdadMaxima);
        }
    }
}
