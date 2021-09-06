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
    public class RepositorioCliente : IRepositorioCiente
    {
        private ContextoDatos conexion = new ContextoDatos();
        public Task<Cliente> ObtenerClientes()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> RegistrarCliente(Cliente cliente)
        {
            try
            {
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = await conexion.AbrirConexion();
                    comando.CommandText = "SP_REGISTRAR_CLIENTE";
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 100).Value = cliente.Nombre;
                    comando.Parameters.Add("@Apellido", SqlDbType.NVarChar, 100).Value = cliente.Apellido;
                    comando.Parameters.Add("@TipoDocumento", SqlDbType.NVarChar, 100).Value = cliente.IdTipoDocumento;
                    comando.Parameters.Add("@NumeroDocumento", SqlDbType.NVarChar, 100).Value = cliente.NumeroDocumento;
                    comando.Parameters.Add("@Direccion", SqlDbType.NVarChar,100).Value = cliente.Direccion;
                    comando.Parameters.Add("@Telefono", SqlDbType.NVarChar,100).Value = cliente.Telefono;
                    comando.Parameters.Add("@FechaNacimiento", SqlDbType.DateTime).Value = cliente.FechaNacimiento;
                    await comando.ExecuteNonQueryAsync();
                    return true;
                }
            }
            catch(Exception ex)
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
