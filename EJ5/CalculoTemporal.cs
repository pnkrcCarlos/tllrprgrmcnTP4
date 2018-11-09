using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ5
{
    public class CalculoTemporal
    {
        private const int meses = 12;

        /// <summary>
        /// Retorna la diferencia de meses entre una fecha y otra.
        /// </summary>
        /// <param name="pDesde">Fecha desde la cual se calcula la diferencia.</param>
        /// <param name="pHasta">Fecha hasta la cual se calcula la diferencia.</param>
        /// <returns></returns>
        public static int DiferenciaMensual(DateTime pDesde, DateTime pHasta)
        {
            int m = Math.Abs((pHasta.Year * meses + pHasta.Month) - (pDesde.Year * meses + pDesde.Month));
            if (pHasta.Day < pDesde.Day) { m--; }
            return m;
        }

        /// <summary>
        /// Retorna la diferencia de años entre una fecha y otra.
        /// </summary>
        /// <param name="pDesde">Fecha desde la cual se calcula la diferencia.</param>
        /// <param name="pHasta">Fecha hasta la cual se calcula la diferencia.</param>
        /// <returns></returns>
        public static int DiferenciaAnual(DateTime pDesde, DateTime pHasta)
        {
            int a = Math.Abs(pHasta.Year - pDesde.Year);
            if (pHasta.Month < pDesde.Month || pHasta.Day < pDesde.Day) { a--; }
            return a;
        }
    }
}
