using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contable.DataAccess.Modelos
{
    [Table("facturas")]
    public class Factura
    {
        [Key]
        public int Id { get; set; }

        [Column("numero_factura")]
        public string NumeroFactura { get; set; }

        [Column("fecha")]
        public DateTime Fecha { get; set; }

        public string Estado { get; set; }

        public bool Anulada { get; set; }

        public string RNC { get; set; }

        [Column("nfc")]
        public string NFC { get; set; }
    }
}
