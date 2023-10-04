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
    public class ProductoVendidoRepository
    {
        private readonly Contexto _contexto;

        public ProductoVendidoRepository(Contexto contexto)
        {
            _contexto = contexto ?? throw new ArgumentNullException(nameof(contexto));
        }

        // Método para obtener todos los productos vendidos
        public List<ProductoVendido> ObtenerTodosLosProductosVendidos()
        {
            return _contexto.ProductosVendidos.ToList();
        }

        // Método para obtener un producto vendido por su ID
        public ProductoVendido ObtenerProductoVendidoPorId(int productoVendidoId)
        {
            return _contexto.ProductosVendidos.FirstOrDefault(p => p.Id == productoVendidoId);
        }

        // Método para agregar un nuevo producto vendido
        public void AgregarProductoVendido(ProductoVendido productoVendido)
        {
            _contexto.ProductosVendidos.Add(productoVendido);
            _contexto.SaveChanges();
        }

        // Método para actualizar un producto vendido existente
        public void ActualizarProductoVendido(ProductoVendido productoVendido)
        {
            _contexto.Entry(productoVendido).State = EntityState.Modified;
            _contexto.SaveChanges();
        }

        // Método para eliminar un producto vendido por su ID
        public void EliminarProductoVendido(int productoVendidoId)
        {
            var productoVendido = _contexto.ProductosVendidos.FirstOrDefault(p => p.Id == productoVendidoId);
            if (productoVendido != null)
            {
                _contexto.ProductosVendidos.Remove(productoVendido);
                _contexto.SaveChanges();
            }
        }
    }
}
