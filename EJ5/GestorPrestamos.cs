using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ5
{
    class GestorPrestamos
    {
        private static IEvaluador EV_EDAD = new EvaluadorEdad(18, 75);
        private static IEvaluador EV_ANTIGUEDAD = new EvaluadorAntiguedadLaboral(6);
        private static IEvaluador EV_SUELDO = new EvaluadorSueldo(5000);

        private Dictionary<TipoCliente, EvaluadorCompuesto> iEvaluadoresPorCliente;

        public GestorPrestamos()
        {
            // Inicializar
            this.iEvaluadoresPorCliente = new Dictionary<TipoCliente, EvaluadorCompuesto>();

            // Evaluadores para NoCliente
            this.iEvaluadoresPorCliente.Add(TipoCliente.NoCliente, new EvaluadorCompuesto());
            this.iEvaluadoresPorCliente[TipoCliente.NoCliente].AgregarEvaluador(EV_EDAD);
            this.iEvaluadoresPorCliente[TipoCliente.NoCliente].AgregarEvaluador(EV_ANTIGUEDAD);
            this.iEvaluadoresPorCliente[TipoCliente.NoCliente].AgregarEvaluador(EV_SUELDO);
            this.iEvaluadoresPorCliente[TipoCliente.NoCliente].AgregarEvaluador(new EvaluadorMonto(20000));
            this.iEvaluadoresPorCliente[TipoCliente.NoCliente].AgregarEvaluador(new EvaluadorCantidadCuotas(12));

            // Evaluadores para Cliente
            this.iEvaluadoresPorCliente.Add(TipoCliente.Cliente, new EvaluadorCompuesto());
            this.iEvaluadoresPorCliente[TipoCliente.Cliente].AgregarEvaluador(EV_EDAD);
            this.iEvaluadoresPorCliente[TipoCliente.Cliente].AgregarEvaluador(EV_ANTIGUEDAD);
            this.iEvaluadoresPorCliente[TipoCliente.Cliente].AgregarEvaluador(EV_SUELDO);
            this.iEvaluadoresPorCliente[TipoCliente.Cliente].AgregarEvaluador(new EvaluadorMonto(100000));
            this.iEvaluadoresPorCliente[TipoCliente.Cliente].AgregarEvaluador(new EvaluadorCantidadCuotas(32));

            // Evaluadores para ClienteGold
            this.iEvaluadoresPorCliente.Add(TipoCliente.ClienteGold, new EvaluadorCompuesto());
            this.iEvaluadoresPorCliente[TipoCliente.ClienteGold].AgregarEvaluador(EV_EDAD);
            this.iEvaluadoresPorCliente[TipoCliente.ClienteGold].AgregarEvaluador(EV_ANTIGUEDAD);
            this.iEvaluadoresPorCliente[TipoCliente.ClienteGold].AgregarEvaluador(EV_SUELDO);
            this.iEvaluadoresPorCliente[TipoCliente.ClienteGold].AgregarEvaluador(new EvaluadorMonto(150000));
            this.iEvaluadoresPorCliente[TipoCliente.ClienteGold].AgregarEvaluador(new EvaluadorCantidadCuotas(60));

            // Evaluadores para ClientePlatinum
            this.iEvaluadoresPorCliente.Add(TipoCliente.ClientePlatinum, new EvaluadorCompuesto());
            this.iEvaluadoresPorCliente[TipoCliente.ClientePlatinum].AgregarEvaluador(EV_EDAD);
            this.iEvaluadoresPorCliente[TipoCliente.ClientePlatinum].AgregarEvaluador(EV_ANTIGUEDAD);
            this.iEvaluadoresPorCliente[TipoCliente.ClientePlatinum].AgregarEvaluador(EV_SUELDO);
            this.iEvaluadoresPorCliente[TipoCliente.ClientePlatinum].AgregarEvaluador(new EvaluadorMonto(200000));
            this.iEvaluadoresPorCliente[TipoCliente.ClientePlatinum].AgregarEvaluador(new EvaluadorCantidadCuotas(60));
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            return this.iEvaluadoresPorCliente[pSolicitud.Cliente.TipoCliente].EsValida(pSolicitud);
        }
    }
}
