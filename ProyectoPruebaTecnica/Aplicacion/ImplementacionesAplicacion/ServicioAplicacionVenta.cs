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
    public class ServicioAplicacionVenta : IServicioAplicacionVenta
    {
        private readonly IServicioDominioVenta _servicioDominioVenta;
        public ServicioAplicacionVenta(IServicioDominioVenta servicioDominioVenta)
        {
            _servicioDominioVenta = servicioDominioVenta;
        }
        public Task<bool> RegistrarVenta(VentaDto venta)
        {
            var listaProducto = venta.Productos.Select(x => new Producto
            {
                Cantidad = x.Cantidad,
                IdProducto = x.IdProducto
            }).ToList();
            return _servicioDominioVenta.RegistrarVenta(new Venta {
                IdCliente = venta.IdCliente,
                Productos = listaProducto
            });
        }
    }
}
