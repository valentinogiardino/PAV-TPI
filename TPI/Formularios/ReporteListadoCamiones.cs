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
    public partial class ReporteListadoCamiones : Form
    {
        public ReporteListadoCamiones()
        {
            InitializeComponent();
        }

        private void ReporteListadoCamiones_Load(object sender, EventArgs e)
        {

            this.rVListadoCamiones.RefreshReport();
        }

        private void rVListadoCamiones_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            try
            {
                tabla = AD_Camiones.ObtenerListadoCamiones();
            }
            catch (Exception)
            {

                MessageBox.Show("Error al obtener el listado de camiones.");
            }
           

            ReportDataSource ds = new ReportDataSource("DatosCamiones", tabla);

            rVListadoCamiones.LocalReport.DataSources.Clear();
            rVListadoCamiones.LocalReport.DataSources.Add(ds);
            rVListadoCamiones.LocalReport.Refresh();
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
