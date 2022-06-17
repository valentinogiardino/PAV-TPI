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
    public partial class ReporteListaEmpleado : Form
    {
        public ReporteListaEmpleado()
        {
            InitializeComponent();
        }

        private void ReporteListaEmpleado_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            try
            {
                tabla = AD_Empleados.ObtenerListadoEmpleadoReporte();
            }
            catch (Exception)
            {

                MessageBox.Show("Error al obtener el listado de empleados");
            }
            

            ReportDataSource ds = new ReportDataSource("DataSetEmpleado", tabla);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
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
