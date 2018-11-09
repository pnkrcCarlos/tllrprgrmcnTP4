using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ5
{
    public class GestorPrestamos
    {
        private static GestorPrestamos cInstancia;

        private static IEvaluador EV_EDAD = new EvaluadorEdad(18, 75);
        private static IEvaluador EV_ANTIGUEDAD = new EvaluadorAntiguedadLaboral(6);
        private static IEvaluador EV_SUELDO = new EvaluadorSueldo(5000);

        private Dictionary<TipoCliente, EvaluadorCompuesto> iEvaluadoresPorCliente;

        private GestorPrestamos()
        {
            // Inicializar
            this.iEvaluadoresPorCliente = new Dictionary<TipoCliente, EvaluadorCompuesto>();

            // Evaluadores para NoCliente
            EvaluadorCompuesto evNoCliente = new EvaluadorCompuesto();
            evNoCliente.AgregarEvaluador(EV_EDAD);
            evNoCliente.AgregarEvaluador(EV_ANTIGUEDAD);
            evNoCliente.AgregarEvaluador(EV_SUELDO);
            evNoCliente.AgregarEvaluador(new EvaluadorMonto(20000));
            evNoCliente.AgregarEvaluador(new EvaluadorCantidadCuotas(12));
            this.iEvaluadoresPorCliente.Add(TipoCliente.NoCliente, evNoCliente);

            // Evaluadores para Cliente
            EvaluadorCompuesto evCliente = new EvaluadorCompuesto();
            evCliente.AgregarEvaluador(EV_EDAD);
            evCliente.AgregarEvaluador(EV_ANTIGUEDAD);
            evCliente.AgregarEvaluador(EV_SUELDO);
            evCliente.AgregarEvaluador(new EvaluadorMonto(100000));
            evCliente.AgregarEvaluador(new EvaluadorCantidadCuotas(32));
            this.iEvaluadoresPorCliente.Add(TipoCliente.Cliente, evCliente);

            // Evaluadores para ClienteGold
            EvaluadorCompuesto evClienteGold = new EvaluadorCompuesto();
            evClienteGold.AgregarEvaluador(EV_EDAD);
            evClienteGold.AgregarEvaluador(EV_ANTIGUEDAD);
            evClienteGold.AgregarEvaluador(EV_SUELDO);
            evClienteGold.AgregarEvaluador(new EvaluadorMonto(150000));
            evClienteGold.AgregarEvaluador(new EvaluadorCantidadCuotas(60));
            this.iEvaluadoresPorCliente.Add(TipoCliente.ClienteGold, evClienteGold);

            // Evaluadores para ClientePlatinum
            EvaluadorCompuesto evClientePlatinum = new EvaluadorCompuesto();
            
            evClientePlatinum.AgregarEvaluador(EV_EDAD);
            evClientePlatinum.AgregarEvaluador(EV_ANTIGUEDAD);
            evClientePlatinum.AgregarEvaluador(EV_SUELDO);
            evClientePlatinum.AgregarEvaluador(new EvaluadorMonto(200000));
            evClientePlatinum.AgregarEvaluador(new EvaluadorCantidadCuotas(60));
            this.iEvaluadoresPorCliente.Add(TipoCliente.ClientePlatinum, evClientePlatinum);
        }

        /// <summary>
        /// Retorna si una solicitud es o no válida.
        /// </summary>
        /// <param name="pSolicitud">Solicitud a evaluar.</param>
        /// <returns>bool</returns>
        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            return this.iEvaluadoresPorCliente[pSolicitud.Cliente.TipoCliente].EsValida(pSolicitud);
        }

        /// <summary>
        /// Devuelve la instancia de GestorPrestamos
        /// </summary>
        public static GestorPrestamos Instancia
        {
            get
            {
                if (cInstancia == null)
                {
                    cInstancia = new GestorPrestamos();
                }
                return cInstancia;
            }
        }
    }
}
