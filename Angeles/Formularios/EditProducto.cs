using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaAngeles.Modelo;
using Angeles.Controlers;
namespace Angeles.Formularios
{
    public partial class EditProducto : Form
    {
        Producto p = null;
        ProductoVirtual pv = null;
        public EditProducto()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            txtCodigoBarra.Text = Convert.ToString(p.codigoDeBarras);
            txtNombre.Text = Convert.ToString(p.nombre);
            txtPorsGanancia.Text = Convert.ToString(p.porsGanancia);
            txtPrecioCosto.Text = Convert.ToString(p.pCosto);
            txtStock.Text = Convert.ToString(p.stockActual);
            txtStockMin.Text = Convert.ToString(p.stockMinimo);
        }

        private void GrdProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                p = (Producto)(grdProductos.Rows[e.RowIndex].DataBoundItem);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            AngelesContext db = new AngelesContext();
            ProductoController pCont = new ProductoController();
            if (pCont.modificarProducto(p.idProducto, txtNombre.Text, (txtCodigoBarra.Text), Convert.ToDecimal(txtPrecioCosto.Text), Convert.ToDecimal(txtPorsGanancia.Text), Convert.ToDecimal(txtStock.Text), Convert.ToDecimal(txtStockMin.Text)))
                lblMenaje.Text = "Cambios Guardados";
            else
                lblMenaje.Text = "Error";
            grdProductos.DataSource = pCont.misProductos();
            grdProductos.Refresh();
        }

        private void EditProducto_Load(object sender, EventArgs e)
        {
            AngelesContext db = new AngelesContext();
            ProductoController pCont = new ProductoController();
            grdProductos.DataSource = pCont.misProductos();
            grdProductos.Refresh();
        }

        private void LblMenaje_Click(object sender, EventArgs e)
        {

        }

        private void TxtCodigoBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) || e.KeyChar < 0)
            {
                MessageBox.Show("Solo se permiten numeros psitivos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtPrecioCosto_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPrecioCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) || e.KeyChar < 0)
            {
                MessageBox.Show("Solo se permiten numeros psitivos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtPorsGanancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) || e.KeyChar < 0)
            {
                MessageBox.Show("Solo se permiten numeros psitivos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) )
            {
                MessageBox.Show("Solo se permiten numeros ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
