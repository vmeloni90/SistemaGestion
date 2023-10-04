using Microsoft.EntityFrameworkCore;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SistemaGestionData.Contexto;

namespace SistemaGestionData
{
    public class ProductoRepository
    {
        private readonly Contexto context;

        public ProductoRepository(Contexto dbContext)
        {
            context = dbContext;
        }

        public void AgregarProducto(Producto producto)
        {
            if (producto == null)
            {
                throw new ArgumentNullException(nameof(producto));
            }

            context.Productos.Add(producto);
            context.SaveChanges();
        }

        public Producto ObtenerProductoPorId(int productoId)
        {
            return context.Productos.Find(productoId);
        }

        public List<Producto> ObtenerTodosLosProductos()
        {
            return context.Productos.ToList();
        }

        public void ActualizarProducto(Producto producto)
        {
            if (producto == null)
            {
                throw new ArgumentNullException(nameof(producto));
            }

            context.Entry(producto).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void EliminarProducto(int productoId)
        {
            var producto = context.Productos.Find(productoId);
            if (producto != null)
            {
                context.Productos.Remove(producto);
                context.SaveChanges();
            }
        }
    }
}
