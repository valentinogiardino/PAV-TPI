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
    public partial class ReporteListaEmpleadoRestricciones : Form
    {
        public ReporteListaEmpleadoRestricciones()
        {
            InitializeComponent();
        }

        private void ReporteListaEmpleadoRestricciones_Load(object sender, EventArgs e)
        {
            CargarComboCiudades();
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

                MessageBox.Show("Error al obtener el listado de empleados+-");
            }
            

            ReportDataSource ds = new ReportDataSource("DataSetEmpleado", tabla);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
        }

        private void CargarComboCiudades()
        {
            try
            {
                cmbCiudad.DataSource = AD_Varios.ObtenerCiudades();
                cmbCiudad.DisplayMember = "nombre";
                cmbCiudad.ValueMember = "idCiudad";
                cmbCiudad.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar ciudades");
            }
        }

        private bool DatosCargados()
        {
            bool DatosCargados = false;
            if ((txtNombre.Text == "") && (txtApellido.Text == "") && (txtNroDocumento.Text == "") && (txtLegajo.Text == "") && (txtCuil.Text == "") && (cmbCiudad.SelectedIndex == -1) && (chkGerente.Checked == false)) 
            {
                return DatosCargados;
            }
            else
            {
                DatosCargados = true;
                return DatosCargados;
            }
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string nroDoc = txtNroDocumento.Text;
            string legajo = txtLegajo.Text;
            string cuil = txtCuil.Text;
            int idCiudad = 0;
            bool gerente = false;
            



                if (chkGerente.Checked)
                {
                    gerente = true;
                }

                else
                {
                    gerente = false;
                }

                if (cmbCiudad.SelectedIndex != -1)
                {
                    idCiudad = int.Parse(cmbCiudad.SelectedValue.ToString());
                    DataTable tabla = new DataTable();
                try
                {
                    tabla = AD_Empleados.ObtenerListadoEmpleadoReporteRestricciones(nombre, apellido, nroDoc, cuil, legajo, idCiudad, gerente);
                }
                catch (Exception)
                {

                    MessageBox.Show("Error al obtener el listado de empleados");
                }
                

                    ReportDataSource ds = new ReportDataSource("DataSetEmpleado", tabla);

                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(ds);
                    reportViewer1.RefreshReport();
                }

                else
                {
                    DataTable tabla = new DataTable();
                try
                {
                    tabla = AD_Empleados.ObtenerListadoEmpleadoReporteRestriccionesCiudad(nombre, apellido, nroDoc, cuil, legajo, gerente);
                }
                catch (Exception)
                {

                    MessageBox.Show("Error al obtener el listado de empleados");
                }
                

                    ReportDataSource ds = new ReportDataSource("DataSetEmpleado", tabla);

                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(ds);
                    reportViewer1.RefreshReport();
                }
        }

        private void btnLimpiarDatos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCuil.Text = "";
            txtLegajo.Text = "";
            txtNroDocumento.Text = "";
            chkGerente.Checked = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
