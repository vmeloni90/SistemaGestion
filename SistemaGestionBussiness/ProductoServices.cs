﻿using SistemaGestionData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public class ProductoServices: IProductoServices
    {
        private IProductoRepository _productoRepository;

        public ProductoServices(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }
    }
}
