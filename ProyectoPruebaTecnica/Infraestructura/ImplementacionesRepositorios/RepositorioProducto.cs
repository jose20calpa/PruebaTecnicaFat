using Dominio.ContratosRepositorios;
using Dominio.Entidades;
using Infraestructura.Contexto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.ImplementacionesRepositorios
{
    public class RepositorioProducto : IRepositorioProducto
    {
        private ContextoDatos conexion = new ContextoDatos();
        public Task<Producto> ObtenerProductos()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> RegistrarProducto(Producto producto)
        {
            try
            {
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = await conexion.AbrirConexion();
                    comando.CommandText = "SP_REGISTRAR_PRODUCTO";
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.Add("@nombre", SqlDbType.NVarChar,100).Value = producto.Nombre;
                    comando.Parameters.Add("@precio", SqlDbType.Float).Value = producto.Precio;
                    comando.Parameters.Add("@cantidad", SqlDbType.Int).Value = producto.Cantidad;
                    comando.Parameters.Add("@descripcion", SqlDbType.NVarChar, 100).Value = producto.Descripcion;
                    await comando.ExecuteNonQueryAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                await conexion.CerrarConexion();
            }
        }

        public async Task<bool> RegistrarStockProducto(Producto producto)
        {
            try
            {
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = await conexion.AbrirConexion();
                    comando.CommandText = "SP_REGISTRAR_STOCK_PRODUCTO";
                    comando.CommandType = CommandType.StoredProcedure;
                    
                    comando.Parameters.Add("@IdProducto", SqlDbType.Int).Value = producto.IdProducto;
                    comando.Parameters.Add("@cantidad", SqlDbType.Int).Value = producto.Cantidad;
                    await comando.ExecuteNonQueryAsync();
                    return true;
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                await conexion.CerrarConexion();
            }
        }
    }
}
