using Microsoft.Reporting.WinForms;
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

namespace TPI.Formularios
{
    public partial class ReporteListaTanques : Form
    {
        public ReporteListaTanques()
        {
            InitializeComponent();
        }

        private void ReporteListaTanques_Load(object sender, EventArgs e)
        {
            this.reporteTanques.RefreshReport(); 
        }

        private void reporteTanques_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            try
            {
                tabla = AD_Tanque.ObtenerListadoTanquesReporte();
            }
            catch (Exception)
            {

                MessageBox.Show("error al obtener listado de tanques");
            }
            
            ReportDataSource ds = new ReportDataSource("ConjuntoDeDatosTanque", tabla);

            reporteTanques.LocalReport.DataSources.Clear();
            reporteTanques.LocalReport.DataSources.Add(ds);
            reporteTanques.LocalReport.Refresh();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
