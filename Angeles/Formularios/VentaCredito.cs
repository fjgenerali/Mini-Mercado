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
    public partial class VentaCredito : Form
    {
        public VentaCredito()
        {
            InitializeComponent();
            AngelesContext db = new AngelesContext();
            var losCli = from cli
                         in db.Clientes
                         select cli;
            List<Cliente> misClientes = new List<Cliente>();
            Cliente c = new Cliente();
            foreach (var item in losCli)
            {
                c = (Cliente)item;
                misClientes.Add(c);
            }
            dropCliente.DataSource = misClientes.ToList();
           
            VentasController vCont = new VentasController();
            // vCont.vender();
            List<ProductoVirtual> listaP = new List<ProductoVirtual>();


            foreach (var item in CarritoVirtual.productoVirtuals)
            {

                listaP.Add(item);
            }

            lblT.Text = Convert.ToString(CarritoVirtual.total);
            grdVentaCredito.DataSource = listaP;
            grdVentaCredito.Refresh();
        }

        private void VentaCredito_Load(object sender, EventArgs e)
        {
            VentasController vCont = new VentasController();
         // vCont.vender();
            List<ProductoVirtual> listaP = new List<ProductoVirtual>();


            foreach (var item in CarritoVirtual.productoVirtuals)
            {

                listaP.Add(item);
            }
            
            lblT.Text = Convert.ToString(CarritoVirtual.total);
            grdVentaCredito.DataSource = listaP;
            grdVentaCredito.Refresh();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Cliente c = (Cliente)dropCliente.SelectedItem;
            CarritoVirtual.cliente = c.idCliente;
            VentasController vCont = new VentasController();
            vCont.venderCredito();
            List<ProductoVirtual> listaP = new List<ProductoVirtual>();
           
            
            foreach (var item in CarritoVirtual.productoVirtuals)
            {

                listaP.Add(item);
            }

            grdVentaCredito.DataSource = listaP;
            grdVentaCredito.Refresh();
            this.Hide();
            vCont.vaciarCarriro();
            this.Close();

        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            
        }

        private void GrdVentaCredito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
