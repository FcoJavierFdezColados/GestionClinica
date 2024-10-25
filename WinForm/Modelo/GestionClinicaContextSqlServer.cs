using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm.Modelo
{
    public class GestionClinicaContextSqlServer: DbContext
    {
        public DbSet<Cita> Citas { get; set; }
        public DbSet<Doctor> Doctores { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            

            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=GestionClinicaDb");
        }
    }
}
