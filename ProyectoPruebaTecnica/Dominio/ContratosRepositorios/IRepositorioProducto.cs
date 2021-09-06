using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ContratosRepositorios
{
    public interface IRepositorioProducto
    {
        Task<bool> RegistrarProducto(Producto producto);
        Task<Producto> ObtenerProductos();
        Task<bool> RegistrarStockProducto(Producto producto);
    }
}
