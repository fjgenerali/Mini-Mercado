using Angeles.Controlers;
using BibliotecaAngeles.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Angeles.Formularios
{
    public partial class LoginModerno : Form
    {
        public LoginModerno()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void LoginModerno_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnAcceder_Click(object sender, EventArgs e)
        {
            UsuariosController uCont = new UsuariosController();
            if (uCont.logearUsuario(txtNombre.Text, txtClave.Text))
            {
                
                this.Hide();
                MenuPanel mp = new MenuPanel();
                mp.AbrirFormEnPanel(new Stock());
                mp.Show();
            }
            else
            {
                lblMensaje.Text = "Usuario o clave equivocada";
            }
        }

        private void TxtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "USUARIO")
            {
           
                txtNombre.Text ="";
                txtNombre.ForeColor = Color.White;

            }
            
        }

        private void TxtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {

                txtNombre.Text = "USUARIO";
                txtNombre.ForeColor =Color.White;
            }
           
        }

        private void TxtClave_Leave(object sender, EventArgs e)
        {
            if (txtClave.Text == "")
            {

                txtClave.Text = "CONTRESEÑA";
                txtClave.ForeColor = Color.White;
                txtClave.UseSystemPasswordChar = false;
            }
            
        }

        private void TxtClave_Enter(object sender, EventArgs e)
        {
            if (txtClave.Text == "CONTRESEÑA")
            {

                txtClave.Text ="";
                txtClave.ForeColor = Color.White;
                txtClave.UseSystemPasswordChar = true;
            }

        }

        private void TxtNombre_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void TxtNombre_CursorChanged(object sender, EventArgs e)
        {
           
        }
    }
}
    
