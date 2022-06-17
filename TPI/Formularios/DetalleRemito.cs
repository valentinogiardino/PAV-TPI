using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI.AccesoADatos;

namespace TPI
{
    public partial class DetalleRemito : Form
    {
        public DetalleRemito()
        {
            InitializeComponent();
        }

        public DetalleRemito(string numRemito, string cuitEstacion)
        {

            InitializeComponent();
            CargarGrilla(numRemito, cuitEstacion);
            lblCUIT.Text = cuitEstacion.ToString();
            lblRemito.Text = numRemito.ToString();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DetalleRemito_Load(object sender, EventArgs e)
        {
            
        }

        private void CargarGrilla(string numRemito, string cuitEstacion)
        {
            

            try
            {
                gdrDetalleRemito.DataSource = AD_Remitos.ObtenerListadoDetalleRemitoEspecial(numRemito, cuitEstacion);
            }
            catch (Exception)
            {

                MessageBox.Show("Error al obtener las estaciones");
            }

        }
    }
}
