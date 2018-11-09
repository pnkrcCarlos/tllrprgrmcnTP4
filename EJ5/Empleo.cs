using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ5
{
    public class Empleo
    {
        private double iSueldo;
        private DateTime iFechaIngreso;

        /// <summary>
        /// Crea una nueva instancia de la clase Empleo.
        /// </summary>
        /// <param name="pSueldo">Sueldo que se recibe por el Empleo.</param>
        /// <param name="pFechaIngreso">Fecha de ingreso al Empleo.</param>
        public Empleo(double pSueldo, DateTime pFechaIngreso)
        {
            this.iSueldo = pSueldo;
            this.iFechaIngreso = pFechaIngreso;
        }

        /// <summary>
        /// Retorna el sueldo que se recibe por el Empleo.
        /// </summary>
        public double Sueldo { get { return this.iSueldo; } }

        /// <summary>
        /// Retorna la fecha de ingreso al Empleo.
        /// </summary>
        public DateTime FechaIngreso { get { return this.iFechaIngreso; } }
    }
}
