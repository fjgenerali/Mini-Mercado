using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaAngeles.Modelo;
namespace Angeles.Formularios
{
    public partial class PagarCuenta : Form
    {
        public PagarCuenta()
        {
            //AngelesContext db = new AngelesContext();
            //var losCli = from cli
            //            in db.Clientes
            //             select cli;
            //List<Cliente> misClientes = new List<Cliente>();
            //Cliente c = new Cliente();
            //foreach (var item in losCli)
            //{
            //    c = (Cliente)item;
            //    misClientes.Add(c);
            //}
            //dropClientes.DataSource = misClientes;

            InitializeComponent();
        }

        private void PagarCuenta_Load(object sender, EventArgs e)
        {
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
            dropClientes.DataSource = misClientes;
        }

        private void DropClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMensaje.Text = "";
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
         //   dropClientes.DataSource = misClientes;
            c = null;
             c =(Cliente) dropClientes.SelectedItem;
             Cliente   c1 =db.Clientes.Find(c.idCliente);
            lblDeuda.Text = Convert.ToString( c1.deudaPesos);
            lblNombre.Text= Convert.ToString(c1.nombre);

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {

            AngelesContext db = new AngelesContext();
            Cliente c =(Cliente) dropClientes.SelectedItem;
            Cliente c1 = db.Clientes.Find(c.idCliente);
            c1.deudaPesos = c1.deudaPesos - Convert.ToInt32( txtEntrega.Text);
            db.Entry(c1).State = EntityState.Modified;
            db.SaveChanges();
            lblMensaje.Text = "Saldo Actualizado";
       
            lblDeuda.Text = Convert.ToString(c1.deudaPesos);
            lblNombre.Text = Convert.ToString(c1.nombre);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            
            
        }

        private void LblEntrea_Click(object sender, EventArgs e)
        {

        }

        private void TxtEntrega_KeyPress(object sender, KeyPressEventArgs e)
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
