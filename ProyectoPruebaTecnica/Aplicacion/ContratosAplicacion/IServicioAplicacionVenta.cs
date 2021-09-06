using Aplicacion.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.ContratosAplicacion
{
    public interface IServicioAplicacionVenta
    {
        Task<bool> RegistrarVenta(VentaDto venta);
    }
}
