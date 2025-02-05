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
    }
}
