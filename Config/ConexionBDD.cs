using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_1._3_Grupo_1.Config
{
    internal class ConexionBDD
    {
        private static readonly string connectionString;

        static ConexionBDD()
        {
            connectionString = "Server=BLADIMIR-DESKTO\\SQLEXPRESS;Database=Cooperativa El Idolo;User Id=sa;Password=123;";
        }

        public static SqlConnection GetConnection()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al conectar a la base de datos", ex);
            }
        }
    }
}
