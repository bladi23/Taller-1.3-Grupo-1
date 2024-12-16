using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller_1._3_Grupo_1
{
    public partial class frm_Recuperacion : Form
    {
        public frm_Recuperacion()
        {
            InitializeComponent();
        }

        private void btn_AceptarR_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txt_UsuarioR.Text;
            string respuestaUsuario = txt_Animal.Text;
            string conexionString = "Server=BLADIMIR-DESKTO\\SQLEXPRESS;Database=Cooperativa El Idolo;User Id=sa;Password=123;";
            string consulta = "SELECT COUNT(*) FROM Clientes WHERE Nombre = @nombre AND AnimalFavorito = @respuesta";

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@nombre", nombreUsuario);
                comando.Parameters.AddWithValue("@respuesta", respuestaUsuario);

                try
                {
                    conexion.Open();
                    int count = (int)comando.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Respuesta correcta.");
                        
                    }
                    else
                    {
                        MessageBox.Show("Respuesta incorrecta. Inténtalo de nuevo.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                }
            }

        }

        private void btn_Atras_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}


       
    

