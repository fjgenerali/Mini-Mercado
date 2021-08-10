using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Angeles.Controlers;
using BibliotecaAngeles.Modelo;
using System.Data.SqlClient;
namespace FachadaWPF
{
    /// <summary>
    /// Lógica de interacción para AdminBox.xaml
    /// </summary>
    public partial class AdminBox : Window
    {
        public AdminBox()
        {
            InitializeComponent();
        }

        private void BtnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            if (LoginData.Admin != LoginData.loginID || LoginData.loginID == null)
            {
                MainWindow lg = new MainWindow();
                lg.Show();
                this.Hide();

            }
            UsuariosController uCont = new UsuariosController();
            bool resultado = false;
            resultado = uCont.agregarUsuario(txtNombre.Text, txtNombre.Text, txtClave.Text, lblTipo.Content.ToString() );
            if (resultado)
            {
                lblMensaje.Content = "Usuario registrado con exito";
                
            }
            else lblMensaje.Content = "Error";
        }

        private void BtnProductos_Click(object sender, RoutedEventArgs e)
        {
            Producto p = new Producto();
            p.Show();
            this.Hide();
        }

        private void BtnVender_Click(object sender, RoutedEventArgs e)
        {
            Vender v = new Vender();
            v.Show();
            this.Hide();
        }
    }
}
