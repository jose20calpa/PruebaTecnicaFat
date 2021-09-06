using Aplicacion.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.ContratosAplicacion
{
    public interface IServicioAplicacionCliente
    {
        Task<bool> RegistrarCliente(ClienteDto producto);
        Task<ClienteDto> ObtenerClientes();
    }
}
