using Aplicacion.ContratosAplicacion;
using Aplicacion.Dtos;
using ProyectoPruebaTecnica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ProyectoPruebaTecnica.Controllers
{
    [RoutePrefix("Api/Ventas")]
    public class VentaController : ApiController
    {
        private readonly IServicioAplicacionVenta _servicioAplicacionVenta;
        public VentaController(IServicioAplicacionVenta servicioAplicacionVenta)
        {
            _servicioAplicacionVenta = servicioAplicacionVenta;
        }
        [Route("CrearVenta")]
        [HttpPost]
        [AllowAnonymous]
        public async Task<IHttpActionResult> CrearVenta([FromBody] VentaModel venta)
        {
            var listaProducto = venta.Productos.Select(x => new ProductoDto
            {
                Cantidad = x.Cantidad,
                IdProducto = x.IdProducto
            }).ToList();
            var estado = await _servicioAplicacionVenta.RegistrarVenta(new VentaDto
            {
                IdCliente = venta.IdCliente,
                Productos = listaProducto
            });
            return Ok();
        }
    }
}
