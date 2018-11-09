using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ5
{
    public class ValidadorSolicitudes // Controlador
    {
        /// <summary>
        /// Retorna el valor de validez según el GestorPrestamos que se pasa como parámetro, y la SolicitudPrestamo que se le pasa como parámetro.
        /// </summary>
        /// <param name="pGestor">GestorPrestamos que se usa para validar la solicitud.</param>
        /// <param name="pSolicitud">SolicitudPrestamo a validar.</param>
        /// <returns>bool</returns>
        public bool Validar(GestorPrestamos pGestor, SolicitudPrestamo pSolicitud)
        {
            return pGestor.EsValida(pSolicitud);
        }
    }
}
