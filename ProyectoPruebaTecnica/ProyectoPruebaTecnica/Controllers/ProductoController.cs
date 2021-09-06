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
    [RoutePrefix("Api/Producto")]
    public class ProductoController : ApiController
    {
        private readonly IServicioAplicacionProducto servicioAplicacionProducto;
        public ProductoController(IServicioAplicacionProducto servicioAplicacionProducto)
        {
            this.servicioAplicacionProducto = servicioAplicacionProducto;
        }
        [Route("CrearProducto")]
        [HttpPost]
        [AllowAnonymous]
        public async Task<IHttpActionResult> RegistrarProducto([FromBody] ProductoModel producto)
        {
            try
            {
                var estado = await servicioAplicacionProducto.RegistrarProducto(new ProductoDto
                {
                    Nombre = producto.Nombre,
                    Precio = producto.Precio,
                    Cantidad = producto.Cantidad,
                    Descripcion = producto.Descripcion
                });
                if (estado)
                    return Ok("Ok");
                else
                    return InternalServerError(new Exception("Error al crear el producto"));
            }
            catch
            {
                return InternalServerError(new Exception("Error al crear el producto"));
            }
        }
        [Route("RegistrarStock")]
        [HttpPost]
        [AllowAnonymous]
        public async Task<IHttpActionResult> RegistrarStockProducto([FromBody] ProductoModel producto)
        {
            try
            {
                var estado = await servicioAplicacionProducto.RegistrarStockProducto(new ProductoDto
                {
                    IdProducto = producto.IdProducto,
                    Cantidad = producto.Cantidad
                });
                return Ok("Ok");
            }
            catch
            {
                return InternalServerError();
            }
        }
        [Route("ObtenerProductos")]
        [HttpPost]
        [AllowAnonymous]
        public async Task<IHttpActionResult> ConsultarProductos([FromBody] ProductoModel producto)
        {
            try
            {
                var listaProductos = await servicioAplicacionProducto.ObtenerProductos();
                return Ok(listaProductos);
            }
            catch
            {
                return InternalServerError();
            }
        }
    }
}
