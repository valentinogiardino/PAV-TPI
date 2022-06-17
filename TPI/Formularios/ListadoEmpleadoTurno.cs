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
    public partial class ListadoEmpleadoTurno : Form
    {
        public ListadoEmpleadoTurno()
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

        private void ListadoEmpleadoTurno_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            this.reportViewer1.RefreshReport();
        }

        private void LimpiarCampos()
        {
            txtFechaDesde.Text = "";
            txtFechaHasta.Text = "";
            txtTop.Text = "";
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            txtTop.Focus();
        }

        private bool DatosCargados()
        {
            bool DatosCargados = false;
            if ((txtTop.Text == "") && (txtFechaDesde.Text == "") && (txtFechaHasta.Text == ""))
            {
                return DatosCargados;
            }
            else
            {
                DatosCargados = true;
                return DatosCargados;
            }
        }



        private void btnBuscarEmpleados_Click(object sender, EventArgs e)
        {

            try
            {
                int top = 0;
                string fechaDesde = "";
                string fechaHasta = "";
                bool resultado = DatosCargados();
                if (resultado)
                {
                    if (txtTop.Value != 0)
                    {
                        top = (int)txtTop.Value;
                    }
                    if (txtFechaDesde.Text != "")
                    {
                        fechaDesde = txtFechaDesde.Text.ToString();
                    }
                    if (txtFechaHasta.Text != "")
                    {
                        fechaHasta = txtFechaHasta.Text.ToString();
                    }
                    DataTable tabla = new DataTable();
                    tabla = AD_Asistencia.ObtenerListadoDeEmpleadoMasTurnos(top, fechaDesde, fechaHasta);

                    ReportDataSource ds = new ReportDataSource("DatosEmpleadoTurno", tabla);
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(ds);
                    reportViewer1.RefreshReport();
                }
                else
                {
                    MessageBox.Show("Seleccione los filtros");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar los empleados con más turnos");
            }
        }



    }
}
