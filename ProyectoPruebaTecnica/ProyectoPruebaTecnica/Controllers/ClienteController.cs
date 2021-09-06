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
    [RoutePrefix("Api/Cliente")]
    public class ClienteController : ApiController
    {
        private readonly IServicioAplicacionCliente _servicioAplicacionCliente;
        
        public ClienteController(IServicioAplicacionCliente servicioAplicacionCliente)
        {
            _servicioAplicacionCliente = servicioAplicacionCliente;
        }
        [Route("CrearCliente")]
        [HttpPost]
        [AllowAnonymous]
        public async Task<IHttpActionResult> CrearCliente([FromBody] ClienteModel cliente)
        {
            try
            {

                var listaProductos = await _servicioAplicacionCliente.RegistrarCliente(new ClienteDto
                {
                    Nombre = cliente.Nombre,
                    Apellido = cliente.Apellido,
                    NumeroDocumento = cliente.NumeroDocumento,
                    IdTipoDocumento = cliente.IdTipoDocumento,
                    Direccion = cliente.Direccion,
                    Telefono = cliente.Telefono,
                    FechaNacimiento = cliente.FechaNacimiento
                    
                });
                return Ok("Creado");
            }
            catch
            {
                return InternalServerError();
            }
        }

    }
}
