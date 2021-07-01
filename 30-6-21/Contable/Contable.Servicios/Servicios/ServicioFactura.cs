using Contable.DataAccess;
using Contable.DataAccess.DTO;
using Contable.DataAccess.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contable.Servicios.Servicios
{
    public class ServicioFactura : IServicioFactura
    {
        SifhaDbContext contex_ = new SifhaDbContext();


        public ServicioFactura()
        {
            
            
        }

        public void ActualizarFactura(Factura facturaActualizable)
        {


            if (contex_.Facturas.Find(facturaActualizable.Id) != null)
            {
                if (String.IsNullOrEmpty(facturaActualizable.RNC) || string.IsNullOrEmpty(facturaActualizable.NFC) || string.IsNullOrEmpty(facturaActualizable.NumeroFactura))
                {
                    throw new ArgumentNullException("Factura o Rnc invalido");
                }
                else
                {
                    contex_.Facturas.Update(facturaActualizable);
                    contex_.SaveChanges();
                }
            }
            else
            {
                throw new ArgumentNullException("Factura no encontrada para actualizar");

            }
        }

        public void AnularFactura(int facturaId)
        {
            
            var factura = contex_.Facturas.Find(facturaId);
            if (factura != null && factura.Estado == "ACTIVO")
            {
                factura.Anulada = true;
                contex_.SaveChanges();
            }
            else
            {
                throw new Exception("La factura no existe.");
            }

        }
           

        public List<Factura> BusquedaAll(ParameterosBusquedaFactura criterio)
        {

            var facturas = contex_.Facturas.AsQueryable();

            
            if (String.IsNullOrEmpty(criterio.RNC) == false)
            {
                // select * from facturas where rnc == @rnc
                facturas = facturas.Where(X => X.RNC == criterio.RNC);
            }

            if(String.IsNullOrEmpty(criterio.NFC) == false)
            {
                // facturas = select * from facturas
                facturas = facturas.Where(X => X.NFC == criterio.NFC);
                // facturas = select * from facturas where nfc = @nfc
            }

            // 01/01/0000
            if (criterio.FechaInicio != null)
            {
                // select * from facturas where rnc = @rnc and nfc = @nfc and fecha > @fechaInico
                facturas = facturas.Where(x => x.Fecha >= criterio.FechaInicio);
            }

            if(criterio.FechaFinal != null)
            {
                // select * from facturas where rnc = @rnc and nfc = @nfc and fecha > @fechaInico and fecha < @fechaFinal
                facturas = facturas.Where(x => x.Fecha <= criterio.FechaFinal);
            }

            return facturas.ToList();


        }

        public Factura BusquedaFacturaVentaPorNCF(string Literal, int NCF)
        {
            throw new NotImplementedException();
        }

        public List<Factura> BusquedaRNC(int numRnc)
        {
            throw new NotImplementedException();
        }


        public void Dispose()
        {
            contex_.Dispose();
        }

        public void EnviarFacturaCorreo(int idFacturar)
        {
            throw new NotImplementedException();
        }

        public Factura GrabarFactura(Factura AgregarFactura)
        {
            
            if (String.IsNullOrEmpty(AgregarFactura.RNC) || string.IsNullOrEmpty(AgregarFactura.NFC) || string.IsNullOrEmpty(AgregarFactura.NumeroFactura))
            {
                throw new ArgumentNullException("Factura o Rnc invalido");
            }
            else {

                AgregarFactura.Estado = "ACTIVO";
                contex_.Facturas.Add(AgregarFactura);
                contex_.SaveChanges();
                

                return AgregarFactura;
            }
        }
        public Factura ObtenerFacturaPorId(int idFactura)
        {
            
            var factura = contex_.Facturas.Find(idFactura);
            contex_.Dispose();
            return factura;
        }
    }
}

