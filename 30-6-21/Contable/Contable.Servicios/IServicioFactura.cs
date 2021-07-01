using Contable.DataAccess.DTO;
using Contable.DataAccess.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contable.Servicios
{
    public interface IServicioFactura : IDisposable
    {
        Factura ObtenerFacturaPorId(int idFactura);

        void ActualizarFactura(Factura facturaActualizable);

        void AnularFactura(int factura);

        void EnviarFacturaCorreo(int idFacturar);

        Factura GrabarFactura(Factura AgregarFactura);

        List<Factura> BusquedaAll(ParameterosBusquedaFactura criterio);

        List<Factura> BusquedaRNC(int numRnc);

        Factura BusquedaFacturaVentaPorNCF(String Literal, int NCF);


    }
}
