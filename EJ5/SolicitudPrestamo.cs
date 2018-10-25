using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ5
{
    class SolicitudPrestamo
    {
        private double iMonto;
        private int iCantidadCuotas;
        private Cliente iCliente;

        public SolicitudPrestamo(Cliente pCliente, double pMonto, int pCantidadCuotas)
        {
            this.iCliente = pCliente;
            this.iMonto = pMonto;
            this.iCantidadCuotas = pCantidadCuotas;
        }

        public double Monto { get { return this.iMonto; } }

        public int CantidadCuotas { get { return this.iCantidadCuotas; } }

        public Cliente Cliente { get { return this.iCliente; } }
    }
}
