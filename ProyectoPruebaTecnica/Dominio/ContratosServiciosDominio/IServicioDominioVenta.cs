using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ContratosServiciosDominio
{
    public interface IServicioDominioVenta
    {
        Task<bool> RegistrarVenta(Venta venta);
    }
}
