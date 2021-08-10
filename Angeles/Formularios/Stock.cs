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
    public partial class Stock : Form
    {
        public Stock()
        {
            //AngelesContext db = new AngelesContext();
            //ProductoController pCont = new ProductoController();
            //List<Producto> p = pCont.misProductos();
            //grdTodos.DataSource = p;
            InitializeComponent();

        }

        private void Stock_Load(object sender, EventArgs e)
        {
            AngelesContext db = new AngelesContext();
            ProductoController pCont = new ProductoController();
            grdTodos.DataSource = pCont.misProductos();
            grdAlerta.DataSource = pCont.alertaStock();
            
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
        }
    }
}
