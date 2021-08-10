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
using System.Windows.Navigation;
using System.Windows.Shapes;
using BibliotecaAngeles.Modelo;
using Angeles.Controlers;
using Angeles.Formularios;
using System.Web.Mvc;

namespace FachadaWPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnEntrar_Click(object sender, RoutedEventArgs e)
        {
            AngelesContext db = new AngelesContext();
            UsuariosController uCont = new UsuariosController();
            if (uCont.logearUsuario(txtUsuario.Text, txtClave.Text))
            {

                if (LoginData.key == LoginData.pass && LoginData.loginID == LoginData.Admin)
                {
                    AdminBox a = new AdminBox();            
                    a.Show();
                    this.Hide();
                }
                else
                {
                    Vender v = new Vender();
                    v.Show();
                    this.Hide();
                }
            }
            else
            {
                btnMensaje.Content = "Usuario o clave equivocada";
            }
        }

        private void BtnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
