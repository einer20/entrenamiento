using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contable.Servicios.Modelos
{

    [Table("pacientes_prueba")]
    public class Paciente
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage ="El nombre no puede ser mayor a 20 caracteres")]
        public String Nombre { get; set; }

        public String Apellido { get; set; }

        public string Direccion { get; set; }
    }
}
