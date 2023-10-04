using Microsoft.EntityFrameworkCore;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData
{
    public class VentaRepository
    {
        private Contexto dbContext;

        public VentaRepository(Contexto context)
        {
            dbContext = context;
        }

        // Método para agregar una nueva venta
        public void AgregarVenta(Venta venta)
        {
            dbContext.Ventas.Add(venta);
            dbContext.SaveChanges();
        }

        // Método para obtener todas las ventas
        public List<Venta> ObtenerTodasLasVentas()
        {
            return dbContext.Ventas.ToList();
        }

        // Método para obtener una venta por su ID
        public Venta ObtenerVentaPorId(int ventaId)
        {
            return dbContext.Ventas.Find(ventaId);
        }

        // Método para actualizar una venta
        public void ActualizarVenta(Venta venta)
        {
            dbContext.Entry(venta).State = EntityState.Modified;
            dbContext.SaveChanges();
        }

        // Método para eliminar una venta por su ID
        public void EliminarVenta(int ventaId)
        {
            var venta = dbContext.Ventas.Find(ventaId);
            if (venta != null)
            {
                dbContext.Ventas.Remove(venta);
                dbContext.SaveChanges();
            }
        }
    }
}
