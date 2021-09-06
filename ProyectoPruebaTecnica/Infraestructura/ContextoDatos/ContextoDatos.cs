using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Contexto
{
    public class ContextoDatos
    {
        private SqlConnection Conexion = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionStringPrueba"].ConnectionString);
        public async Task<SqlConnection> AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                await Conexion.OpenAsync();
            return Conexion;
        }
        public async Task<SqlConnection> CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
