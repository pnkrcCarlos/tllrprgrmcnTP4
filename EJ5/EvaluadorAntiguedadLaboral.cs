using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ5
{
    class EvaluadorAntiguedadLaboral : IEvaluador
    {
        private int iAntiguedadMinima;

        public EvaluadorAntiguedadLaboral(int pAntiguedadMinima)
        {
            this.iAntiguedadMinima = pAntiguedadMinima;
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            return CalculoTemporal.DiferenciaMensual(pSolicitud.Cliente.Empleo.FechaIngreso, DateTime.Today) >= this.iAntiguedadMinima;
        }
    }
}
