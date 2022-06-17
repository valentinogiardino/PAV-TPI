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
    public partial class ListadoAsistencias : Form
    {
        public ListadoAsistencias()
        {
            InitializeComponent();
        }

        private void ListadoAsistencias_Load(object sender, EventArgs e)
        {

            this.reporteAsistencia.RefreshReport();
        }

        private void reporteAsistencia_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Asistencia.ObtenerListadoDeAsistencias();

            ReportDataSource ds = new ReportDataSource("DatosAsistencia", tabla);

            reporteAsistencia.LocalReport.DataSources.Clear();
            reporteAsistencia.LocalReport.DataSources.Add(ds);
            reporteAsistencia.LocalReport.Refresh();
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
