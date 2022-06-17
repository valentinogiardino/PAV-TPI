using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using TPI.AccesoADatos;

namespace TPI.Formularios
{
    public partial class ReporteListadoEstaciones : Form
    {
        public ReporteListadoEstaciones()
        {
            InitializeComponent();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReporteListadoEstaciones_Load(object sender, EventArgs e)
        {

            this.reportViewerEstaciones.RefreshReport();
        }

        private void reportViewerEstaciones_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            try
            {
                tabla = AD_Estacion.ObtenerListadoEstacion();
            }
            catch (Exception)
            {

                MessageBox.Show("Error al obtener el listado de estaciones.");
            }
           
            
            ReportDataSource ds = new ReportDataSource("DataSetEstaciones", tabla);

            reportViewerEstaciones.LocalReport.DataSources.Clear();
            reportViewerEstaciones.LocalReport.DataSources.Add(ds);
            reportViewerEstaciones.LocalReport.Refresh();
        }
    }
}
