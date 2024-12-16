using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Taller_1._3_Grupo_1.Config;

namespace Taller_1._3_Grupo_1.Models
{
    public class UsuariosModels
    {
        public int IDUsuario { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }

        public static UsuariosModels Autenticar(string nombreUsuario, string contrasena)
        {
            UsuariosModels usuario = null;
            try
            {
                using (SqlConnection connection = ConexionBDD.GetConnection())
                {
                    string query = "SELECT * FROM Usuarios WHERE Usuario = @Usuario AND Contrasena = @Contrasena";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Usuario", nombreUsuario);
                    command.Parameters.AddWithValue("@Contrasena", contrasena);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        usuario = new UsuariosModels
                        {
                            IDUsuario = reader.GetInt32(reader.GetOrdinal("IDUsuario")),
                            Usuario = reader.GetString(reader.GetOrdinal("Usuario")),
                            Contrasena = reader.GetString(reader.GetOrdinal("Contrasena"))
                        };
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new Exception("Error de SQL al autenticar el usuario: " + sqlEx.Message, sqlEx);
            }
            catch (Exception ex)
            {
                throw new Exception("Error general al autenticar el usuario: " + ex.Message, ex);
            }
            return usuario;
        }
    }
}
