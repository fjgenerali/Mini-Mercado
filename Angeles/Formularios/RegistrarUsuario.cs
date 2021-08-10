using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Angeles.Controlers;
using BibliotecaAngeles.Modelo;
namespace Angeles.Formularios
{
    public partial class RegistrarUsuario : Form
    {
        public RegistrarUsuario()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AngelesContext db = new AngelesContext();
            UsuariosController cUsu = new UsuariosController();
            if (cUsu.agregarUsuario(txtCedula.Text, txtNombre.Text, txtClave.Text, "V"))

                lblMensaje.Text = "Usuario agregado correctamente";
            else
                lblMensaje.Text = "Error";
        }
    }
}
