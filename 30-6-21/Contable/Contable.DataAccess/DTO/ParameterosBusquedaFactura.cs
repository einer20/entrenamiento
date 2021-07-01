using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contable.DataAccess.DTO
{
    public class ParameterosBusquedaFactura
    {
        public string RNC { get; set; }

        public string NFC { get; set; }

        public string NombreCliente { get; set; }

        public string Proveedor { get; set; }

        public DateTime? FechaInicio { get; set; }
        
        public DateTime? FechaFinal { get; set; }

    }
}
