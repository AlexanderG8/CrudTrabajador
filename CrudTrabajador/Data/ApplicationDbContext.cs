using CrudTrabajador.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudTrabajador.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder) 
        {
            base.OnModelCreating(builder);
            builder.Entity<Trabajador>().ToTable("Trabajadores");
            builder.Entity<Distritos>().ToTable("Distrito");
            builder.Entity<Departamentos>().ToTable("Departamento");
            builder.Entity<Provincias>().ToTable("Provincia");
            builder.Entity<spListarTrabajador>().ToTable("spListarTrabajador");
            
        }
        public DbSet<Trabajador> Trabajador { get; set; }
        public DbSet<Distritos> Distrito { get; set; }
        public DbSet<Provincias> Provincias { get; set; }
        public DbSet<Departamentos> Departamentos { get; set; }
        public DbSet<spListarTrabajador> spListarTrabajador { get; set; }
    }
}
