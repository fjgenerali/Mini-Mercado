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
using Angeles.Formularios;

namespace Angeles.Formularios
{
    public partial class FormVentaEfectivo : Form
    {
        Producto p = null;
        ProductoVirtual pv = null;
        public FormVentaEfectivo()
        {
            InitializeComponent();
        }

        private void GridProd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                p = (Producto)(gridProd.Rows[e.RowIndex].DataBoundItem);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            VentasController vCont = new VentasController();
            ICollection<Producto> lProductos = null;
            lProductos = vCont.BuscarProducto(txtNombre.Text, txtCodigo.Text);


            gridProd.DataSource = lProductos;
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            VentasController vCont = new VentasController();
            bool test = false;
            if (p != null)
            {


                test = vCont.agregar(p.idProducto);
                decimal totalPagar = 0;
                List<ProductoVirtual> lPv1 = new List<ProductoVirtual>();
                if (test)
                {

                    foreach (var item in CarritoVirtual.productoVirtuals)
                    {
                        lPv1.Add(item);
                        totalPagar = totalPagar + (item.pVenta * item.cantidad);
                    }
                }

                lblTotal.Text = Convert.ToString(totalPagar);
                if (txtPagaCon.Text != "" && Convert.ToInt32(txtPagaCon.Text) >= 0)
                    lblCambio.Text = Convert.ToString(Convert.ToDecimal(txtPagaCon.Text) - totalPagar);


                gridVenta.DataSource = lPv1;

                gridVenta.Refresh();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            gridVenta.Refresh();
            gridProd.Refresh();
            VentasController vCont = new VentasController();
            decimal totalPagar = 0;

            List<ProductoVirtual> lPv1 = new List<ProductoVirtual>();
            if (CarritoVirtual.productoVirtuals != null)
            {
                vCont.quitarCompra(pv.idProducto);
                foreach (var item in CarritoVirtual.productoVirtuals)
                {
                    lPv1.Add(item);
                    totalPagar = totalPagar + (item.pVenta * item.cantidad);
                }
                lblTotal.Text = Convert.ToString(totalPagar);
                if (txtPagaCon.Text != "" && Convert.ToInt32(txtPagaCon.Text) >= 0)
                    lblCambio.Text = Convert.ToString(Convert.ToDecimal(txtPagaCon.Text) - totalPagar);

                gridVenta.DataSource = lPv1;
                gridVenta.Refresh();
                gridProd.Refresh();
            }
        }

        private void GridVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                pv = (ProductoVirtual)(gridVenta.Rows[e.RowIndex].DataBoundItem);
            }
        }

        private void TxtPagaCon_TextChanged(object sender, EventArgs e)
        {
            if (CarritoVirtual.productoVirtuals != null)
            {
                if (txtPagaCon.Text != "" && Convert.ToInt32(txtPagaCon.Text) >= 0)
                {


                    gridVenta.Refresh();
                    gridProd.Refresh();
                    VentasController vCont = new VentasController();
                    List<ProductoVirtual> lPv1 = new List<ProductoVirtual>();
                    decimal totalPagar = 0;

                    foreach (var item in CarritoVirtual.productoVirtuals)
                    {
                        lPv1.Add(item);
                        totalPagar = totalPagar + (item.pVenta * item.cantidad);
                    }
                    lblTotal.Text = Convert.ToString(totalPagar);
                    lblCambio.Text = Convert.ToString(Convert.ToDecimal(txtPagaCon.Text) - totalPagar);

                    CarritoVirtual.total = totalPagar;
                    CarritoVirtual.cambioCliente = (Convert.ToDecimal(txtPagaCon.Text) - totalPagar);


                    gridVenta.DataSource = lPv1;
                    gridVenta.Refresh();
                    gridProd.Refresh();
                }
            }
        }

        private void BtnVender_Click(object sender, EventArgs e)
        {
            decimal totalPagar = 0;

            foreach (var item in CarritoVirtual.productoVirtuals)
            {
                totalPagar = totalPagar + (item.pVenta * item.cantidad);
            }
            CarritoVirtual.total = totalPagar;
            

                CarritoVirtual.contado = true;

          

            VentaCerrada v = new VentaCerrada();
            v.Show();

        }

        private void PanelGrid_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelTop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
