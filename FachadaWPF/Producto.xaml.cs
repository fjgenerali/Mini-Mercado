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
using BibliotecaAngeles.Modelo;
using Angeles.Controlers;

namespace FachadaWPF
{
    /// <summary>
    /// Lógica de interacción para Producto.xaml
    /// </summary>
    public partial class Producto : Window
    {
        public Producto()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            if (LoginData.Admin != LoginData.loginID || LoginData.loginID == null)
            {
                MainWindow lg = new MainWindow();
                lg.Show();
                this.Hide();
            }
            ProductoController pCont = new ProductoController();
            lblExito.Content = "";
            if (pCont.agregarProducto(txtNombre.Text, Convert.ToInt32(txtCodigo.Text), Convert.ToDecimal(txtCosto.Text), Convert.ToDecimal(txtGanancia.Text), Convert.ToDecimal(txtStock.Text), Convert.ToDecimal(txtStock.Text)))
            {
                lblExito.Content = "Producto Agregado correctamente";
            }
            else
            {
                lblExito.Content = "Producto ya existe (nombre o codigo repetido)";
            }
        }

        private void BtnAtras_Click(object sender, RoutedEventArgs e)
        {
            AdminBox m = new AdminBox();
            m.Show();
            this.Hide();
        }
    }
}
