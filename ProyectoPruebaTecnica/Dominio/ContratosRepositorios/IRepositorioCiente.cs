using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ContratosRepositorios
{
    public  interface IRepositorioCiente
    {
        Task<bool> RegistrarCliente(Cliente producto);
        Task<Cliente> ObtenerClientes();
    }
}
