using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TareasASP.Models;

namespace TareasASP.Data
{
    public class TareasASPContext : DbContext
    {
        public TareasASPContext (DbContextOptions<TareasASPContext> options)
            : base(options)
        {
        }

        public DbSet<TareasASP.Models.ListaTareas> ListaTareas { get; set; } = default!;
        public DbSet<TareasASP.Models.Tarea> Tarea { get; set; } = default!;

        /**
         * Para establecer el tipo de borrado de claves foráneas
         * En este caso nos interesa Borrado en cascada.
         * Con Restrict no nos permitiría borrar una lista mientras tuviese tareas y no es lo que interesa.
         */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach(var foreignKey in modelBuilder.Model.GetEntityTypes().SelectMany(x => x.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Cascade;
            }
        }
    }
}
