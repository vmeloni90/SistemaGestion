using SistemaGestionEntities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace SistemaGestionData
{
    public class Contexto : DbContext
    {
       
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<ProductoVendido> ProductosVendidos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
            @"Server=(localdb)\MSSQLLocalDB;Database=SistemaGestion;Trusted_Connection=True;TrustServerCertificate=Yes;");
        }
        
    }
}
