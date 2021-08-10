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
    public partial class FormVentaCredito : Form
    {
        Producto p = null;
        ProductoVirtual pv = null;
        public FormVentaCredito()
        {
            InitializeComponent();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            VentasController vCont = new VentasController();
            ICollection<Producto> lProductos = null;
            lProductos = vCont.BuscarProducto(txtNombre.Text, txtCodigo.Text);


            gridProductos.DataSource = lProductos;
        
          }

        private void GridProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                p = (Producto)(gridProductos.Rows[e.RowIndex].DataBoundItem);
            }
        }

        private void GrdVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                pv = (ProductoVirtual)(grdVenta.Rows[e.RowIndex].DataBoundItem);
            }
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
                

                grdVenta.DataSource = lPv1;

                grdVenta.Refresh();
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


            CarritoVirtual.contado = false;

            MenuPanel mp = new MenuPanel();
            mp.AbrirFormEnPanel(new VentaCredito());
            mp.Show();
            //VentaCredito v = new VentaCredito();
            //v.Show();
        }

        private void FormVentaCredito_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            grdVenta.Refresh();
            gridProductos.Refresh();
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


                grdVenta.DataSource = lPv1;
                grdVenta.Refresh();
                gridProductos.Refresh();
            }
        }
    }
}
