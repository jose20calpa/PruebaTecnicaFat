using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ContratosRepositorios
{
    public interface IRepositorioVenta
    {
        Task<int> RegistrarVenta(int IdCliente);
        Task<decimal> RegistrarVentaProductos(List<Producto> Productos, int IdVenta);
        Task<bool> ActualizarVenta(int IdVenta,decimal Total);
    }
}
