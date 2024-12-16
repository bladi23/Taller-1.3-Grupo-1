using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taller_1._3_Grupo_1.Controller;

namespace Taller_1._3_Grupo_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_InicioSesion_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txt_Usuario.Text.Trim();
            string contrasena = btn_Contrasena.Text.Trim();
            try
            {
                UsuariosController _usuariosController = new UsuariosController();
                var usuariomodel = _usuariosController.AutenticarUsuario(nombreUsuario, contrasena);
                if (usuariomodel != null)
                {
                    MessageBox.Show("Bienvenido al sistema");
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Recuperar_Click(object sender, EventArgs e)
        {
            frm_Recuperacion _recuperacion = new frm_Recuperacion();
            _recuperacion.ShowDialog();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            txt_Usuario.Clear();
            btn_Contrasena.Clear();
        }
    }
}
