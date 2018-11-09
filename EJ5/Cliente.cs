using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ5
{
    public class Cliente
    {
        private String iNombre;
        private String iApellido;
        private DateTime iFechaNacimiento;
        private TipoCliente iTipoCliente = TipoCliente.NoCliente;
        private Empleo iEmpleo;

        /// <summary>
        /// Crea una nueva instancia de la clase Cliente.
        /// </summary>
        /// <param name="pNombre">Nombre del Cliente.</param>
        /// <param name="pApellido">Apellido del Cliente.</param>
        /// <param name="pFechaNacimiento">Fecha de nacimiento del Cliente.</param>
        /// <param name="pEmpleo">Empleo del Cliente.</param>
        public Cliente(String pNombre, String pApellido, DateTime pFechaNacimiento, Empleo pEmpleo)
        {
            this.iNombre = pNombre;
            this.iApellido = pApellido;
            this.iFechaNacimiento = pFechaNacimiento;
            this.iEmpleo = pEmpleo;
        }

        /// <summary>
        /// Retorna el nombre del Cliente.
        /// </summary>
        public String Nombre { get { return this.iNombre; } }

        /// <summary>
        /// Retorna el apellido del Cliente.
        /// </summary>
        public String Apellido { get { return this.iApellido; } }

        /// <summary>
        /// Retorna la fecha de nacimiento del Cliente.
        /// </summary>
        public DateTime FechaNacimiento { get { return this.iFechaNacimiento; } }

        /// <summary>
        /// Retorna el Empleo del Cliente.
        /// </summary>
        public Empleo Empleo { get { return this.iEmpleo; } }
        
        /// <summary>
        /// Establece o retorna el TipoCliente del Cliente.
        /// </summary>
        public TipoCliente TipoCliente
        {
            get { return this.iTipoCliente; }
            set { this.iTipoCliente = value; }
        }
    }
}
