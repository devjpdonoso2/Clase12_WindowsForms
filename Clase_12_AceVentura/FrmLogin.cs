using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Clase_12_AceVentura.Classes;

namespace Clase_12_AceVentura
{
    public partial class FrmLogin : Form
    {
        private List<Usuario> usuariosPosibles;
        public FrmLogin()
        {
            usuariosPosibles = new List<Usuario>();
            MockUsuarios();
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string validacion = ValidarFormulario();
            if (validacion != string.Empty)
            {
                MessageBox.Show(validacion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Autenticar();
            }

        }

        private string ValidarFormulario()
        {
            string _textoSalidaValidacion = string.Empty;
            if (txtUsername.Text == string.Empty)
            {
                _textoSalidaValidacion = _textoSalidaValidacion + "Falta campo Requerido: Username"
                    + Environment.NewLine;
            }

            if (txtPassword.Text == string.Empty)
            {
                _textoSalidaValidacion = _textoSalidaValidacion + "Falta campo Requerido: Password"
                    + Environment.NewLine;
            }

            return _textoSalidaValidacion;

        }

        private void Autenticar()
        {
            Usuario usuarioEncontrado = usuariosPosibles.Where(
                usuario => usuario.Username == txtUsername.Text
                && usuario.Password == txtPassword.Text).FirstOrDefault();

            if (usuarioEncontrado != null)
            {
                FrmPrincipal principal = new FrmPrincipal(usuarioEncontrado);
                principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void MockUsuarios()
        {
            usuariosPosibles.Add(new Usuario("prueba", "123", "Juan Perez"));
            usuariosPosibles.Add(new Usuario("otro", "456", "Jose Gonzalez"));
        }
    }
}
