using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ5
{
    public class SolicitudPrestamo
    {
        private double iMonto;
        private int iCantidadCuotas;
        private Cliente iCliente;

        /// <summary>
        /// Crea una nueva instancia de SolicitudPrestamo.
        /// </summary>
        /// <param name="pCliente"></param>
        /// <param name="pMonto"></param>
        /// <param name="pCantidadCuotas"></param>
        public SolicitudPrestamo(Cliente pCliente, double pMonto, int pCantidadCuotas)
        {
            this.iCliente = pCliente;
            this.iMonto = pMonto;
            this.iCantidadCuotas = pCantidadCuotas;
        }

        /// <summary>
        /// Retorna el monto de la solicitud actual.
        /// </summary>
        public double Monto { get { return this.iMonto; } }

        /// <summary>
        /// Retorna la cantidad de cuotas de la solicitud actual.
        /// </summary>
        public int CantidadCuotas { get { return this.iCantidadCuotas; } }

        /// <summary>
        /// Retorna el Cliente de la solicitud actual.
        /// </summary>
        public Cliente Cliente { get { return this.iCliente; } }
    }
}
