using Dominio.ContratosRepositorios;
using Dominio.ContratosServiciosDominio;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ImplementacionesServicioDominio
{
    public class ServicioDominioCliente : IServicioDominioCliente
    {
        IRepositorioCiente _repositorioCiente;
        public ServicioDominioCliente(IRepositorioCiente repositorioCiente )
        {
            _repositorioCiente = repositorioCiente;
        }
        public async Task<bool> RegistrarCliente(Cliente cliente)
        {
            return await _repositorioCiente.RegistrarCliente(cliente);
        }
    }
}
