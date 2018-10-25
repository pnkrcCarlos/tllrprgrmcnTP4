using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ5
{
    class CalculoTemporal
    {
        public static int DiferenciaMensual(DateTime pDesde, DateTime pHasta)
        {
            int m = (pHasta.Year * 12 + pHasta.Month) - (pDesde.Year * 12 + pDesde.Month);
            if (pHasta.Day < pDesde.Day) { m--; }
            return m;
        }

        public static int DiferenciaAnual(DateTime pDesde, DateTime pHasta)
        {
            int a = pHasta.Year - pDesde.Year;
            if (pHasta.Month < pDesde.Month || pHasta.Day < pDesde.Day) { a--; }
            return a;
        }
    }
}
