using Aplicacion.ContratosAplicacion;
using Aplicacion.ImplementacionesAplicacion;
using Dominio.ContratosRepositorios;
using Dominio.ContratosServiciosDominio;
using Dominio.ImplementacionesServicioDominio;
using Infraestructura.ImplementacionesRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace IoC
{
    public static class Contenedor
    {
        public static IUnityContainer BuildUnityContainer()
        {
            var contenedor = new UnityContainer();
            #region aplicacion
            contenedor.RegisterType<IServicioAplicacionProducto, ServicioAplicacionProducto>();
            contenedor.RegisterType<IServicioAplicacionCliente, ServicioAplicacionCliente>();
            contenedor.RegisterType<IServicioAplicacionVenta, ServicioAplicacionVenta>();
            #endregion
            #region dominio
            contenedor.RegisterType<IServicioDominioProducto, ServicioDominioProducto>();
            contenedor.RegisterType<IServicioDominioCliente, ServicioDominioCliente>();
            contenedor.RegisterType<IServicioDominioVenta, ServicioDominioVenta>();
            #endregion

            #region infraestructura
            contenedor.RegisterType<IRepositorioProducto, RepositorioProducto>();
            contenedor.RegisterType<IRepositorioCiente, RepositorioCliente>();
            contenedor.RegisterType<IRepositorioVenta, RepositorioVenta>();
            #endregion

            return contenedor;
        }
    }
}
