using Aplicacion.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.ContratosAplicacion
{
    public interface IServicioAplicacionProducto
    {
        Task<bool> RegistrarProducto(ProductoDto producto);
        Task<ProductoDto> ObtenerProductos();
        Task<bool> RegistrarStockProducto(ProductoDto producto);
    }
}
