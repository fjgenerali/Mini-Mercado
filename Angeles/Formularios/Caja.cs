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
    public partial class Caja : Form
    {
        Detalle d = null;
        public Caja()
        {
            InitializeComponent();
        }

        private void BtnDia_Click(object sender, EventArgs e)
        {
            grdBoleta1.Refresh();
            lblCredito.Text = "";
            lblGanancia.Text = "";
            AngelesContext db = new AngelesContext();
            CajaController cCont = new CajaController();
            if (cCont.cajaDia())
            {
                lblGanancia.Text =Convert.ToString( CajaVirtual.GananciaDia);
                lblCredito.Text = Convert.ToString(CajaVirtual.CreditoDia);
            }
            grdBoleta1.DataSource = cCont.listaBoletasDia();
        }

        private void BtnMes_Click(object sender, EventArgs e)
        {
            grdBoleta1.Refresh();
            lblCredito.Text = "";
            lblGanancia.Text = "";
            AngelesContext db = new AngelesContext();
            CajaController cCont = new CajaController();
            if (cCont.cajaMes())
            {
                lblGanancia.Text = Convert.ToString(CajaVirtual.GananciaMes);
                lblCredito.Text = Convert.ToString(CajaVirtual.CreditoMes);
            }
            grdBoleta1.DataSource = cCont.listaBoletasMes();

        }

        private void BtnAnio_Click(object sender, EventArgs e)
        {
            grdBoleta1.Refresh();
            lblCredito.Text = "";
            lblGanancia.Text = "";
            AngelesContext db = new AngelesContext();
            CajaController cCont = new CajaController();
            if (cCont.cajaAnio())
            {
                lblGanancia.Text = Convert.ToString(CajaVirtual.GananciaAnio);
                lblCredito.Text = Convert.ToString(CajaVirtual.CreditoAnio);
            }
            grdBoleta1.DataSource = cCont.listaBoletasAnio();

        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            
        }

        private void GrdBoleta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void GrdSeleccion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }

        private void GrdSeleccion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GrdBoleta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GrdBoleta1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Boleta b = new Boleta();
            if (e.RowIndex >= 0)
            {

                b = (Boleta)(grdBoleta1.Rows[e.RowIndex].DataBoundItem);

            }
            CajaController pCont = new CajaController();
            AngelesContext db = new AngelesContext();

            if (b != null)
            {
                List<Detalle> lPv1 = new List<Detalle>();
                var litd = from det
                           in db.Detalles
                           where det.boleta.idBoleta == b.idBoleta
                           select det;

                foreach (var item in litd)
                {

                    lPv1.Add((Detalle)item);
                }
                grdSeleccion.DataSource = lPv1.ToList();
                grdSeleccion.Refresh();
            }
        }
    }
}
