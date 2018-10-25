using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ5
{
    class Cliente
    {
        private String iNombre;
        private String iApellido;
        private DateTime iFechaNacimiento;
        private TipoCliente iTipoCliente = TipoCliente.NoCliente;
        private Empleo iEmpleo;

        public Cliente(String pNombre, String pApellido, DateTime pFechaNacimiento, Empleo pEmpleo)
        {
            this.iNombre = pNombre;
            this.iApellido = pApellido;
            this.iFechaNacimiento = pFechaNacimiento;
            this.iEmpleo = pEmpleo;
        }

        public String Nombre { get { return this.iNombre; } }

        public String Apellido { get { return this.iApellido; } }

        public DateTime FechaNacimiento { get { return this.iFechaNacimiento; } }

        public Empleo Empleo { get { return this.iEmpleo; } }
        
        public TipoCliente TipoCliente
        {
            get { return this.iTipoCliente; }
            set { this.iTipoCliente = value; }
        }
    }
}
