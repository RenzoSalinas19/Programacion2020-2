using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace calculadoramvc.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<calculadoramvc.Models.Contacto> Contactos { get; set; }
        public DbSet<calculadoramvc.Models.Registrar> Registrar { get; set; }
    }
}
