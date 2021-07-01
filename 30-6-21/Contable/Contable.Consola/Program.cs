using Contable.Servicios;
using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using Dapper;
using System.Linq;
using Contable.DataAccess.Modelos;
using Contable.DataAccess;
using Contable.Servicios.Servicios;

namespace Contable.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ServicioFactura servicioFactura = new ServicioFactura();

            servicioFactura.GrabarFactura(new Factura {
                Fecha = new DateTime(year: 2021, month:7, day:20),
                RNC = "RN22",
                NumeroFactura = "44ccc",
                NFC = "fff",

            });

            servicioFactura.GrabarFactura(new Factura
            {
                Fecha = new DateTime(year: 2021, month: 7, day: 21),
                RNC = "RN44",
                NumeroFactura = "44ccc",
                NFC = "fff",

            });

            servicioFactura.GrabarFactura(new Factura
            {
                Fecha = new DateTime(year: 2021, month: 6, day: 20),
                RNC = "RN85",
                NumeroFactura = "44ccc",
                NFC = "fff",

            });

            servicioFactura.GrabarFactura(new Factura
            {
                Fecha = new DateTime(year: 2021, month: 7, day:23),
                RNC = "RNH",
                NumeroFactura = "44ccc",
                NFC = "fff",

            });

            List<Factura> facturas = servicioFactura.BusquedaAll(new DataAccess.DTO.ParameterosBusquedaFactura());


            servicioFactura.Dispose();
            Console.WriteLine("Cantidad de facturas encontradas:" + facturas.Count());



            Console.ReadLine();
        }

    }


}
