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
    public class ServicioAplicacionCliente : IServicioAplicacionCliente
    {
        private readonly IServicioDominioCliente _servicioDominioCliente;
        public ServicioAplicacionCliente(IServicioDominioCliente servicioDominioCliente)
        {
            _servicioDominioCliente = servicioDominioCliente;
        }
        public Task<ClienteDto> ObtenerClientes()
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegistrarCliente(ClienteDto cliente)
        {
            return _servicioDominioCliente.RegistrarCliente(new Cliente
            {
                Nombre = cliente.Nombre,
                Apellido = cliente.Apellido,
                IdTipoDocumento = cliente.IdTipoDocumento,
                NumeroDocumento = cliente.NumeroDocumento,
                Direccion = cliente.Direccion,
                Telefono = cliente.Telefono,
                FechaNacimiento = cliente.FechaNacimiento
            });
        }
    }
}
