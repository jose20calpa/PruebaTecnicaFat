using Aplicacion.ContratosAplicacion;
using Aplicacion.Dtos;
using Dominio.ContratosServiciosDominio;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.ImplementacionesAplicacion
{
    public class ServicioAplicacionProducto : IServicioAplicacionProducto
    {
        private readonly IServicioDominioProducto _servicioDominioProducto;
        public ServicioAplicacionProducto(IServicioDominioProducto servicioDominioProducto)
        {
            _servicioDominioProducto = servicioDominioProducto;
        }
        public Task<ProductoDto> ObtenerProductos()
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegistrarProducto(ProductoDto producto)
        {
            var productoE = new Producto()
            {
                Nombre = producto.Nombre,
                Cantidad = producto.Cantidad,
                Precio = producto.Precio,
                Descripcion = producto.Descripcion
            };
            return _servicioDominioProducto.RegistrarProducto(productoE);
        }

        public Task<bool> RegistrarStockProducto(ProductoDto producto)
        {
            var productoE = new Producto()
            {
                IdProducto = producto.IdProducto,
                Cantidad = producto.Cantidad,
            };
            return _servicioDominioProducto.RegistrarStockProducto(productoE);
        }
    }
}
