using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UsuarioTextBox_Leave(object sender, EventArgs e)
        {
            if(usuarioTextBox.TextLength == 0)
            {
                LoginErrorProvider.SetError(usuarioTextBox, "Datos Requeridos");
            }
            else
            {
                LoginErrorProvider.SetError(usuarioTextBox,"");
            }
        }

        private void ContraseñaTextBox_Leave(object sender, EventArgs e)
        {
            if (contraseñaTextBox.TextLength == 0)
            {
                LoginErrorProvider.SetError(contraseñaTextBox, "Datos Requeridos");
            }
            else
            {
                LoginErrorProvider.SetError(contraseñaTextBox, "");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
