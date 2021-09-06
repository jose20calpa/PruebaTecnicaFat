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
    public class RepositorioVenta : IRepositorioVenta
    {
        private ContextoDatos conexion = new ContextoDatos();

        public async Task<bool> ActualizarVenta(int IdVenta, decimal Total)
        {
            try
            {
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = await conexion.AbrirConexion();
                    comando.CommandText = "SP_ACTUALIZAR_VENTA";
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.Add("@IdVenta", SqlDbType.Int).Value = IdVenta;
                    comando.Parameters.Add("@Total", SqlDbType.Float).Value=  Total;
                    await comando.ExecuteNonQueryAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                await conexion.CerrarConexion();

            }
        }

        public async Task<int> RegistrarVenta(int IdClente)
        {
            try
            {
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = await conexion.AbrirConexion();
                    comando.CommandText = "SP_REGISTRAR_VENTA";
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.Add("@IdCliente", SqlDbType.Int).Value = IdClente;
                    comando.Parameters.Add("@IdCompra", SqlDbType.Int).Direction = ParameterDirection.Output;
                    await comando.ExecuteNonQueryAsync();
                    int IdCompra= Convert.ToInt32(comando.Parameters["@IdCompra"].Value);
                    

                    return IdCompra;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                await conexion.CerrarConexion();

            }
        }

        public async Task<decimal> RegistrarVentaProductos(List<Producto> Productos, int IdVenta)
        {
            decimal total = 0;
            try
            {
                foreach (var producto in Productos)
                {
                    using (SqlCommand comando = new SqlCommand())
                    {
                        comando.Connection = await conexion.AbrirConexion();
                        comando.CommandText = "SP_REGISTRAR_VENTA_PRODUCTOS";
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.Add("@IdCompra", SqlDbType.Int).Value = IdVenta;
                        comando.Parameters.Add("@IdProducto", SqlDbType.Int).Value = producto.IdProducto;
                        comando.Parameters.Add("@Cantidad", SqlDbType.Int).Value = producto.Cantidad;
                        comando.Parameters.Add("@Subtotal", SqlDbType.Float).Direction = ParameterDirection.Output;
                        await comando.ExecuteNonQueryAsync();
                        total = total +Convert.ToDecimal(comando.Parameters["@Subtotal"].Value);


                    }
                }
                return total;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                await conexion.CerrarConexion();
            }
        }
    }
}
