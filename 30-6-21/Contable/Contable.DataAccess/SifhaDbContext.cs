using Contable.DataAccess.Modelos;
using Contable.Servicios.Modelos;
using Microsoft.EntityFrameworkCore;
using System;

namespace Contable.DataAccess
{
    public class SifhaDbContext : DbContext
    {

        public DbSet<Paciente> Pacientes { get; set; }

        public DbSet<Factura> Facturas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=DESKTOP-AMCLO8K\\SQLEXPRESS;user id=fcuser;password=userfc;initial catalog=pruebas");
        }
    }
}
