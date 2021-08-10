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
using System.Data.SqlClient;
using Angeles.Controlers;

namespace FachadaWPF
{
    /// <summary>
    /// Lógica de interacción para Vender.xaml
    /// </summary>
    public partial class Vender : Window
    {
        public Vender()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, RoutedEventArgs e)
        {
            VentasController vCont = new VentasController();
          
            List<Producto> p = new List<Producto>();
            vCont.BuscarProducto(txtNombre.Text, txtCodigo.Text);
            grdProductos.DataContext = vCont.BuscarProducto(txtNombre.Text, txtCodigo.Text).ToList() ;

        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            VentasController vCont = new VentasController();

            grdProductosVen.DataContext = CarritoVirtual.productoVirtuals.ToList();
          
        }

        private void GrdProductos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void GrdProductos_DragOver(object sender, DragEventArgs e)
        {

        }

        private void GrdProductosVen_DragOver(object sender, DragEventArgs e)
        {

        }

        private void GrdProductos_Drop(object sender, DragEventArgs e)
        {

        }

        private void GrdProductosVen_Drop(object sender, DragEventArgs e)
        {

        }

        private void GrdProductos_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {

        }

        private void GrdProductos_CurrentCellChanged(object sender, EventArgs e)
        {
           
        }
    }
}
