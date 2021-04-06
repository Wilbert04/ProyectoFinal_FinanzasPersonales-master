using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal.DAL
{
    public class Contexto : DbContext
    {
        
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Cuentas> Cuentas { get; set; }
        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<Presupuestos> Presupuestos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=DATA\ProductoDB3.db");
        }
    }
}
