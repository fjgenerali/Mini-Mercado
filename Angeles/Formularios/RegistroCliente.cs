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
    public partial class RegistroCliente : Form
    {
        public RegistroCliente()
        {
            InitializeComponent();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            ClienteController cCont = new ClienteController();

            if (cCont.agregarCliente(txtCedula.Text, txtNombreApe.Text, Convert.ToDecimal(txtDeuda.Text)))
                lblEstado.Text = "Cliente Registrado Exitosamente";
            else lblEstado.Text = "Datos erroneos o cliete ya existe";
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            
        }

        private void RegistroCliente_Load(object sender, EventArgs e)
        {

        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) || e.KeyChar < 0)
            {
                MessageBox.Show("Solo se permiten numeros psitivos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtDeuda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) || e.KeyChar < 0)
            {
                MessageBox.Show("Solo se permiten numeros psitivos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
