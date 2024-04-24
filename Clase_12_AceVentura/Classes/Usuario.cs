using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_12_AceVentura.Classes
{
    public class Usuario
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string NombreUsuario { get; set; }

        public Usuario(string username, string password, string nombreUsuario)
        {
            Username = username;
            Password = password;
            NombreUsuario = nombreUsuario;
        }
    }
}
