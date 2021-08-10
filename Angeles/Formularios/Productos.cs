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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
           
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
           
            ProductoController pCont = new ProductoController();
            lblExito.Text = "";
          if(  pCont.agregarProducto(txtNombre.Text, ( txtCodigo.Text),Convert.ToDecimal( txtCosto.Text), Convert.ToDecimal(txtPorsentaje.Text), Convert.ToDecimal(txtStoock.Text), Convert.ToDecimal(txtStockMin.Text)))
            {
                lblExito.Text = "Producto Agregado correctamente";
            }
            else
            {
                lblExito.Text = "Producto ya existe (nombre o codigo repetido)";
            }
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
           
        }
           

        private void Productos_Load(object sender, EventArgs e)
        {

        }

        private void BtnEditarProducto_Click(object sender, EventArgs e)
        {
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) || e.KeyChar < 0)
            {
                MessageBox.Show("Solo se permiten numeros psitivos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) || e.KeyChar < 0)
            {
                MessageBox.Show("Solo se permiten numeros psitivos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtPorsentaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) || e.KeyChar < 0)
            {
                MessageBox.Show("Solo se permiten numeros psitivos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtStoock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) || e.KeyChar < 0)
            {
                MessageBox.Show("Solo se permiten numeros psitivos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtStockMin_KeyPress(object sender, KeyPressEventArgs e)
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
