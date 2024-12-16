using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller_1._3_Grupo_1.Models;

namespace Taller_1._3_Grupo_1.Controller
{
    internal class UsuariosController
    {
        public UsuariosModels AutenticarUsuario(string nombreUsuario, string Contrasena)
        {
            return UsuariosModels.Autenticar(nombreUsuario, Contrasena);
        }
    }
}
