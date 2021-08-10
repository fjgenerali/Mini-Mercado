using Angeles.Controlers;
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

namespace Angeles.Formularios
{
    public partial class VentaCerrada : Form
    {
        public VentaCerrada()
        {
        AngelesContext db = new AngelesContext();
        var losCli = from cli
                     in db.Clientes
                     select cli;
        List<Cliente> misClientes = new List<Cliente>();
        Cliente c = new Cliente();
            foreach (var item in losCli)
            {
                c = (Cliente) item;
        misClientes.Add(c);
            }
            


            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {

            VentasController vCont = new VentasController();
           
            List<ProductoVirtual> listaP = new List<ProductoVirtual>();
          

            foreach (var item in CarritoVirtual.productoVirtuals)
            {
                
                listaP.Add(item);
            }

            grdVentaCerrada.DataSource = listaP;
            grdVentaCerrada.Refresh();
            this.Close();

            vCont.vaciarCarriro();
        }

        private void VentaCerrada_Load(object sender, EventArgs e)
        {
            VentasController vCont = new VentasController();
            vCont.vender();
            List<ProductoVirtual> listaP = new List<ProductoVirtual>();


            foreach (var item in CarritoVirtual.productoVirtuals)
            {
                
                listaP.Add(item);
            }
            lblCambio.Text = Convert.ToString(CarritoVirtual.cambioCliente);
            lblTotal.Text = Convert.ToString(CarritoVirtual.total);
            grdVentaCerrada.DataSource = listaP;
            grdVentaCerrada.Refresh();

        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
