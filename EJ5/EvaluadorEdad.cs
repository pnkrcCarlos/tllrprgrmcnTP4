using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ5
{
    class EvaluadorEdad : IEvaluador
    {
        private int iEdadMinima;
        private int iEdadMaxima;

        public EvaluadorEdad(int pEdadMinima, int pEdadMaxima)
        {
            this.iEdadMinima = pEdadMinima;
            this.iEdadMaxima = pEdadMaxima;
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            int edadCliente = CalculoTemporal.DiferenciaAnual(pSolicitud.Cliente.FechaNacimiento, DateTime.Today);
            return (edadCliente >= iEdadMinima && edadCliente < iEdadMaxima);
        }
    }
}
