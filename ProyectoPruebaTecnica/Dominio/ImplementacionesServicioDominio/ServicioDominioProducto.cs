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
    public class ServicioDominioProducto : IServicioDominioProducto
    {
        private readonly IRepositorioProducto _repositorioProducto;
        public ServicioDominioProducto(IRepositorioProducto repositorioProducto)
        {
            this._repositorioProducto = repositorioProducto;
        }
        public async Task<List<Producto>> ObtenerProductos()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> RegistrarProducto(Producto producto)
        {
           return await _repositorioProducto.RegistrarProducto(producto);
           
        }

        public async Task<bool> RegistrarStockProducto(Producto producto)
        {
            return await _repositorioProducto.RegistrarStockProducto(producto);
        }
    }
}
