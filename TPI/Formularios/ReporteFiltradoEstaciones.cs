using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using TPI.AccesoADatos;

namespace TPI.Formularios
{
    public partial class ReporteFiltradoEstaciones : Form
    {
        public ReporteFiltradoEstaciones()
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
        private void ReporteFiltradoEstaciones_Load(object sender, EventArgs e)
        {
            this.rvFiltradoEstaciones.RefreshReport();
            CargarCmbCiudad();

        }

        private void CargarCmbCiudad()
        {
            cmbCiudad.DataSource = AD_Estacion.ObtenerCiudad();
            cmbCiudad.DisplayMember = "nombre";
            cmbCiudad.ValueMember = "idCiudad";
            cmbCiudad.SelectedIndex = -1;
        }


        private void rvFiltradoEstaciones_Load(object sender, EventArgs e)
        {

            DataTable tabla = new DataTable();
            tabla = AD_Estacion.ObtenerListadoEstacion();

            ReportDataSource ds = new ReportDataSource("DataSetEstaciones", tabla);

            rvFiltradoEstaciones.LocalReport.DataSources.Clear();
            rvFiltradoEstaciones.LocalReport.DataSources.Add(ds);
            rvFiltradoEstaciones.LocalReport.Refresh();
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            string cuit = txtCuit.Text;
            string nroSucursal = txtNumSucursal.Text;
            string calle = txtCalle.Text;
            string nroCalle = txtNroCalle.Text;
            DataTable tabla = new DataTable();
            try
            {
                if (cmbCiudad.SelectedIndex == -1)
                {
                    tabla = AD_Estacion.ObtenerEstacionesFiltradas(cuit, nroSucursal, -1, calle, nroCalle);
                }
                else
                {
                    tabla = AD_Estacion.ObtenerEstacionesFiltradas(cuit, nroSucursal, (int)cmbCiudad.SelectedValue, calle, nroCalle);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error al obtener las estaciones.");
            }
            
            

           
           

            ReportDataSource ds = new ReportDataSource("DataSetEstaciones", tabla);

            rvFiltradoEstaciones.LocalReport.DataSources.Clear();
            rvFiltradoEstaciones.LocalReport.DataSources.Add(ds);
            rvFiltradoEstaciones.RefreshReport();
        }

        private void LimpiarCampos() 
        {
            txtCalle.Text = "";
            txtCuit.Text = "";
            txtNroCalle.Text = "";
            txtNumSucursal.Text = "";
            cmbCiudad.SelectedIndex = -1;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
