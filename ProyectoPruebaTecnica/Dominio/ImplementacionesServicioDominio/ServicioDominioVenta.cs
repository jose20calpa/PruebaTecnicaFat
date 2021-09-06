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
    public class ServicioDominioVenta : IServicioDominioVenta
    {
        private IRepositorioVenta _repositorioVenta;
        public ServicioDominioVenta(IRepositorioVenta repositorioVenta)
        {
            this._repositorioVenta = repositorioVenta;
        }
        public async Task<bool> RegistrarVenta(Venta venta)
        {
            var idVenta = await _repositorioVenta.RegistrarVenta(venta.IdCliente);
            var total = await _repositorioVenta.RegistrarVentaProductos(venta.Productos, idVenta);
            var estado = await _repositorioVenta.ActualizarVenta(idVenta,total);
            return estado;
        }
    }
}
