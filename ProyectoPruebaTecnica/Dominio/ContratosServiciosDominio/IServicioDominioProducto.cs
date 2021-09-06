using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ContratosServiciosDominio
{
    public interface IServicioDominioProducto
    {
        Task<bool> RegistrarProducto(Producto producto);
        Task<List<Producto>> ObtenerProductos();
        Task<bool> RegistrarStockProducto(Producto producto);
    }
}
