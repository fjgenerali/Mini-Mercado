using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using BibliotecaAngeles.Modelo;
using Angeles.Controlers;
namespace Angeles.Formularios
{
    public partial class MenuPanel : Form
    {
        public MenuPanel()
        {
            InitializeComponent();
            
            this.btnLogOut.Visible = true;
            //this.btnFull.Visible = false;
           //  escodoBotones();
            ocultoPanelBotones();
            // this.AbrirFormEnPanel(new Login());
            this.WindowState = FormWindowState.Maximized;
            this.btnLogin.Visible = false;
            escodoBotonesComun() ;

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            if (panelVertical.Width==240)
            {
                panelVertical.Width = 55;
                pnlIniBtn.Width = 55;
                pnlProdBtn.Width = 55;
                pnlCliBtn.Width = 55;
                pnlCliBtn.Width = 55;
                btnProductos.Text = "";
                btnVender.Text = "";
                btnClientes.Text = "";
                btnCobrarCredito.Text = "";
            }
            else
            { panelVertical.Width = 240;
                pnlProdBtn.Width = 240;
                pnlCliBtn.Width = 240;
                pnlCliBtn.Width = 240;
                btnProductos.Text = "Productos";
                btnVender.Text = "Vender";
                btnClientes.Text = "Clientes";
                btnCobrarCredito.Text = "Cobrar Creditos";
            }
        }

        private void MenuTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnFull_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnVentana.Visible = true;
            btnFull.Visible = false;
        }

        private void BtnVentana_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnVentana.Visible = false;
            btnFull.Visible = true;
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MenuTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public  void AbrirFormEnPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        private void BtnProductos_Click(object sender, EventArgs e)
        {
          
            this.mostrarSubmenus(pnlProdBtn);
        }
        

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //this.btnLogin.Visible = false;
            //this.btnLogOut.Visible = true;
            //this.AbrirFormEnPanel(new Login());
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginModerno l = new LoginModerno();
            l.Show();
        }
        private void escodoBotones()
        {
            
            this.btnVender.Hide();
            this.btnStock.Hide();
            this.btnProductos.Hide();
            this.btnCobrarCredito.Hide();
            this.btnClientes.Hide();
        }
        public void muestroBotones()
        {
            this.btnVentana.Show();
            this.btnStock.Show();
            this.btnProductos.Show();
            this.btnCobrarCredito.Show();
            this.btnClientes.Show();
        }
        public void muestroBotonesComun()
        {
            if (!LoginData.soyAdmin)
            {
                btnEdicatCliente.Hide();
                btnEditarProd.Hide();
            }
            else { 
                this.btnVentana.Show();
            this.btnStock.Show();
            this.btnProductos.Show();
            this.btnCobrarCredito.Show();
            this.btnClientes.Show();
            }
        }
        private void escodoBotonesComun()
        {

        }

        public void ocultoPanelBotones()
        {
            pnlProdBtn.Visible = false;
            pnlCliBtn.Visible = false;
            pnlVendBtn.Visible = false;
        }
        public void ocultoSubmenus()
        {
            if (pnlProdBtn.Visible == true)
            {
                pnlProdBtn.Visible = false;
            }
            if (pnlCliBtn.Visible == true)
            {
                pnlCliBtn.Visible = false;
            }
            if (pnlVendBtn.Visible == true)
            {
                pnlVendBtn.Visible = false;
            }
        }
        public  void mostrarSubmenus(Panel subMenu)
        {
            if (subMenu.Visible==false)
            {
                ocultoSubmenus();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnProductos_Click_1(object sender, EventArgs e)
        {
            this.mostrarSubmenus(pnlProdBtn);
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            this.mostrarSubmenus(pnlCliBtn);
        }

        private void BtnVender_Click(object sender, EventArgs e)
        {
            this.mostrarSubmenus(pnlVendBtn);
        }

        private void BtnCobrarCredito_Click(object sender, EventArgs e)
        {
            this.AbrirFormEnPanel(new PagarCuenta());
        }

        private void BtnNuevoProd_Click(object sender, EventArgs e)
        {
             this.AbrirFormEnPanel(new Productos());
        }

        private void BtnEditarProd_Click(object sender, EventArgs e)
        {
            this.AbrirFormEnPanel(new EditProducto());
        }

        private void BtnStock_Click(object sender, EventArgs e)
        {
            this.AbrirFormEnPanel(new Stock());
        }

        private void BtnNuevoCliente_Click(object sender, EventArgs e)
        {
            this.AbrirFormEnPanel(new RegistroCliente());
        }

        private void BtnVentaCredito_Click(object sender, EventArgs e)
        {
           
            
            this.AbrirFormEnPanel(new FormVentaCredito());
            
        }

        private void BtnVentaEfectivo_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormVentaEfectivo());
        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnCaja_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Caja());
        }
    }
}
