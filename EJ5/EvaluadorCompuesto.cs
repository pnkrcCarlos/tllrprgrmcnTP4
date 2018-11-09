using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ5
{
    public class EvaluadorCompuesto : IEvaluador
    {
        private ICollection<IEvaluador> iEvaluadores;

        /// <summary>
        /// Crea una nueva instancia de EvaluadorAntiguedadLaboral.
        /// </summary>
        public EvaluadorCompuesto()
        {
            iEvaluadores = new List<IEvaluador>();
        }

        /// <summary>
        /// Retorna si una solicitud es o no válida para los evaluadores que componen al evaluador actual.
        /// </summary>
        /// <param name="pSolicitud">Solicitud a evaluar.</param>
        /// <returns>bool</returns>
        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            foreach (IEvaluador evaluador in this.iEvaluadores)
            {
                if (!evaluador.EsValida(pSolicitud))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Agregar un IEvaluador al evaluador actual.
        /// </summary>
        /// <param name="pEvaluador"></param>
        public void AgregarEvaluador(IEvaluador pEvaluador)
        {
            this.iEvaluadores.Add(pEvaluador);
        }
    }
}
