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
    public partial class ReporteListadoTurnos : Form
    {
        public ReporteListadoTurnos()
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

        private void ReporteListadoTurnos_Load(object sender, EventArgs e)
        {

            this.reportTurnos.RefreshReport();
        }

        private void reportTurnos_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            try
            {
                tabla = AD_Turno.ObtenerListadoTurnosReporte();
            }
            catch (Exception)
            {

                MessageBox.Show("Error al obtener el listado de turnos");
            }
            

            ReportDataSource ds = new ReportDataSource("DatosTurnos", tabla);

            reportTurnos.LocalReport.DataSources.Clear();
            reportTurnos.LocalReport.DataSources.Add(ds);
            reportTurnos.LocalReport.Refresh();
        }
    }
}
