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
    public partial class ReporteListaCamionConFiltros : Form
    {
        public ReporteListaCamionConFiltros()
        {
            InitializeComponent();
        }

        private void ReporteListaCamionConFiltros_Load(object sender, EventArgs e)
        {
            CargarComboMarca();
            LimpiarCampos();
            this.rVListadoCamionesConFiltro.RefreshReport();
        }

        private void LimpiarCampos()
        {
            txtPatente.Text = "";
            cmbModelo.SelectedIndex = -1;
            txtCantCombustibleMax.Text = "";
            txtCantCombustibleMin.Text = "";
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            txtPatente.Focus();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarComboMarca()
        {
            try
            {
                cmbModelo.DataSource = AD_Camiones.ObtenerModelo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los Modelos");

            }

            cmbModelo.DisplayMember = "nombreModelo";
            cmbModelo.ValueMember = "idModelo";
            cmbModelo.SelectedIndex = -1;
        }

        private void rVListadoCamionesConFiltro_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Camiones.ObtenerListadoCamiones();

            ReportDataSource ds = new ReportDataSource("DatosCamiones", tabla);

            rVListadoCamionesConFiltro.LocalReport.DataSources.Clear();
            rVListadoCamionesConFiltro.LocalReport.DataSources.Add(ds);
            rVListadoCamionesConFiltro.LocalReport.Refresh();
        }


        private bool DatosCargados()
        {
            bool DatosCargados = false;
            if ((txtPatente.Text == "") && (cmbModelo.SelectedIndex == -1) && (txtCantCombustibleMax.Text == "") && (txtCantCombustibleMin.Text == ""))
            {
                return DatosCargados;
            }
            else
            {
                DatosCargados = true;
                return DatosCargados;
            }
        }


        private void btnBuscarCamiones_Click(object sender, EventArgs e)
        {
            string patente = txtPatente.Text;
            string modelo = "";
            float cantidadMin = 0;
            float cantidadMax = 10000000000;
            bool resultado = DatosCargados();
            if (resultado)
            {
                if (cmbModelo.SelectedIndex != -1)
                {
                    modelo = cmbModelo.Text;
                }

                if (txtCantCombustibleMax.Text != "")
                {
                    cantidadMax = float.Parse(txtCantCombustibleMax.Text);
                }

                if (txtCantCombustibleMin.Text != "")
                {
                    cantidadMin = float.Parse(txtCantCombustibleMin.Text);
                }

                DataTable tabla = new DataTable();
                tabla = AD_Camiones.ObtenerListadoCamionesConFiltro(patente, modelo, cantidadMin, cantidadMax);

                ReportDataSource ds = new ReportDataSource("DatosCamiones", tabla);

                rVListadoCamionesConFiltro.LocalReport.DataSources.Clear();
                rVListadoCamionesConFiltro.LocalReport.DataSources.Add(ds);
                rVListadoCamionesConFiltro.RefreshReport();
            }
            else
            {
                MessageBox.Show("Seleccione al menos un filtro de búsqueda!");
            }

        }
    }
}
