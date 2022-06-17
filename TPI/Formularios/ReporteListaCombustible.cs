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
    public partial class ReporteListaCombustible : Form
    {
        public ReporteListaCombustible()
        {
            InitializeComponent();
        }

        private void ReporteListaCombustible_Load(object sender, EventArgs e)
        {
            this.reporteCombustible.RefreshReport();
        }


        private void reporteCombustible_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            try
            {
                tabla = AD_Combustible.ObtenerListadoCombustiblesReporte();
            }
            catch (Exception)
            {

                MessageBox.Show("Error al obtener el listado de Combustibles.");
            }
            

            ReportDataSource ds = new ReportDataSource("DataSetCombustible", tabla);

            reporteCombustible.LocalReport.DataSources.Clear();
            reporteCombustible.LocalReport.DataSources.Add(ds);
            reporteCombustible.LocalReport.Refresh();

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
