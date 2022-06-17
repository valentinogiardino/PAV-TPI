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
    public partial class ReporteListadoCombustibleFiltros : Form
    {
        public ReporteListadoCombustibleFiltros()
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

        private void ReporteListadoCombustibleFiltros_Load(object sender, EventArgs e)
        {
            CargarComboTiposDeCombustible();
            LimpiarCampos();
            this.ReporteCombFiltro.RefreshReport();
            
        }

        private void CargarComboTiposDeCombustible()
        {
            cmbTipoComb.DataSource = AD_Combustible.ObtenerTipoCombustible();
            cmbTipoComb.DisplayMember = "nombre";
            cmbTipoComb.ValueMember = "codTipoCombustible";
            cmbTipoComb.SelectedIndex = -1;
        }

        private bool obtenerDatos() 
        {
            if (txtMax.Text != "" || txtMin.Text !=  "" || cmbTipoComb.SelectedIndex != -1 || txtNom.Text != "")
            {
                return true;
            }
            MessageBox.Show("Seleccione Filtros por favor!");
            return  false;


        }

        private void LimpiarCampos()
        {
            txtMax.Text = "";
            txtMin.Text = "";
            txtNom.Text = "";
            cmbTipoComb.SelectedIndex = -1;
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
             bool resultado = obtenerDatos();

            if (resultado)
            {
                try
                {
                    if (txtMax.Text != "" && txtMin.Text == "" && cmbTipoComb.SelectedIndex == -1 && txtNom.Text == "")
                    {
                        DataTable tabla = new DataTable();
                        tabla = AD_Combustible.ObtenerListadoCombustiblesReporteMax(txtMax.Text);

                        ReportDataSource ds = new ReportDataSource("DataSetCombustible", tabla);

                        ReporteCombFiltro.LocalReport.DataSources.Clear();
                        ReporteCombFiltro.LocalReport.DataSources.Add(ds);
                        ReporteCombFiltro.RefreshReport();
                    }
                    else if (txtMax.Text != "" && txtMin.Text != "" && cmbTipoComb.SelectedIndex == -1 && txtNom.Text == "")
                    {
                        DataTable tabla = new DataTable();
                        tabla = AD_Combustible.ObtenerListadoCombustiblesReporteMinMax(txtMin.Text, txtMax.Text);

                        ReportDataSource ds = new ReportDataSource("DataSetCombustible", tabla);

                        ReporteCombFiltro.LocalReport.DataSources.Clear();
                        ReporteCombFiltro.LocalReport.DataSources.Add(ds);
                        ReporteCombFiltro.RefreshReport();
                    }
                    else if (txtMax.Text != "" && txtMin.Text == "" && cmbTipoComb.SelectedIndex != -1 && txtNom.Text == "")
                    {
                        DataTable tabla = new DataTable();
                        tabla = AD_Combustible.ObtenerListadoCombustiblesReporteMaxCmb(txtMax.Text, cmbTipoComb.SelectedValue.ToString());

                        ReportDataSource ds = new ReportDataSource("DataSetCombustible", tabla);

                        ReporteCombFiltro.LocalReport.DataSources.Clear();
                        ReporteCombFiltro.LocalReport.DataSources.Add(ds);
                        ReporteCombFiltro.RefreshReport();
                    }
                    else if (txtMax.Text != "" && txtMin.Text == "" && cmbTipoComb.SelectedIndex == -1 && txtNom.Text != "")
                    {
                        DataTable tabla = new DataTable();
                        tabla = AD_Combustible.ObtenerListadoCombustiblesReporteMaxNom(txtMax.Text, txtNom.Text);

                        ReportDataSource ds = new ReportDataSource("DataSetCombustible", tabla);

                        ReporteCombFiltro.LocalReport.DataSources.Clear();
                        ReporteCombFiltro.LocalReport.DataSources.Add(ds);
                        ReporteCombFiltro.RefreshReport();
                    }
                    else if (txtMax.Text != "" && txtMin.Text != "" && cmbTipoComb.SelectedIndex != -1 && txtNom.Text == "")
                    {
                        DataTable tabla = new DataTable();
                        tabla = AD_Combustible.ObtenerListadoCombustiblesReporteMaxMinCmb(txtMax.Text, txtMin.Text, cmbTipoComb.SelectedValue.ToString());

                        ReportDataSource ds = new ReportDataSource("DataSetCombustible", tabla);

                        ReporteCombFiltro.LocalReport.DataSources.Clear();
                        ReporteCombFiltro.LocalReport.DataSources.Add(ds);
                        ReporteCombFiltro.RefreshReport();
                    }
                    else if (txtMax.Text == "" && txtMin.Text != "" && cmbTipoComb.SelectedIndex != -1 && txtNom.Text != "")
                    {
                        DataTable tabla = new DataTable();
                        tabla = AD_Combustible.ObtenerListadoCombustiblesReporteMinCmbNom(txtMin.Text, cmbTipoComb.SelectedValue.ToString(), txtNom.Text);

                        ReportDataSource ds = new ReportDataSource("DataSetCombustible", tabla);

                        ReporteCombFiltro.LocalReport.DataSources.Clear();
                        ReporteCombFiltro.LocalReport.DataSources.Add(ds);
                        ReporteCombFiltro.RefreshReport();
                    }
                    else if (txtMax.Text != "" && txtMin.Text != "" && cmbTipoComb.SelectedIndex == -1 && txtNom.Text != "")
                    {
                        DataTable tabla = new DataTable();
                        tabla = AD_Combustible.ObtenerListadoCombustiblesReporteMaxMinNom(txtMax.Text, txtMin.Text, txtNom.Text);

                        ReportDataSource ds = new ReportDataSource("DataSetCombustible", tabla);

                        ReporteCombFiltro.LocalReport.DataSources.Clear();
                        ReporteCombFiltro.LocalReport.DataSources.Add(ds);
                        ReporteCombFiltro.RefreshReport();
                    }
                    else if (txtMax.Text != "" && txtMin.Text == "" && cmbTipoComb.SelectedIndex != -1 && txtNom.Text != "")
                    {
                        DataTable tabla = new DataTable();
                        tabla = AD_Combustible.ObtenerListadoCombustiblesReporteMaxCmbNom(txtMax.Text, cmbTipoComb.SelectedValue.ToString(), txtNom.Text);

                        ReportDataSource ds = new ReportDataSource("DataSetCombustible", tabla);

                        ReporteCombFiltro.LocalReport.DataSources.Clear();
                        ReporteCombFiltro.LocalReport.DataSources.Add(ds);
                        ReporteCombFiltro.RefreshReport();
                    }
                    else if (txtMax.Text == "" && txtMin.Text != "" && cmbTipoComb.SelectedIndex == -1 && txtNom.Text == "")
                    {
                        DataTable tabla = new DataTable();
                        tabla = AD_Combustible.ObtenerListadoCombustiblesReporteMin(txtMin.Text);

                        ReportDataSource ds = new ReportDataSource("DataSetCombustible", tabla);

                        ReporteCombFiltro.LocalReport.DataSources.Clear();
                        ReporteCombFiltro.LocalReport.DataSources.Add(ds);
                        ReporteCombFiltro.RefreshReport();
                    }
                    else if (txtMax.Text == "" && txtMin.Text != "" && cmbTipoComb.SelectedIndex != -1 && txtNom.Text == "")
                    {
                        DataTable tabla = new DataTable();
                        tabla = AD_Combustible.ObtenerListadoCombustiblesReporteMinCmb(txtMin.Text, cmbTipoComb.SelectedValue.ToString());

                        ReportDataSource ds = new ReportDataSource("DataSetCombustible", tabla);

                        ReporteCombFiltro.LocalReport.DataSources.Clear();
                        ReporteCombFiltro.LocalReport.DataSources.Add(ds);
                        ReporteCombFiltro.RefreshReport();
                    }
                    else if (txtMax.Text == "" && txtMin.Text != "" && cmbTipoComb.SelectedIndex == -1 && txtNom.Text != "")
                    {
                        DataTable tabla = new DataTable();
                        tabla = AD_Combustible.ObtenerListadoCombustiblesReporteMinNom(txtMin.Text, txtNom.Text);

                        ReportDataSource ds = new ReportDataSource("DataSetCombustible", tabla);

                        ReporteCombFiltro.LocalReport.DataSources.Clear();
                        ReporteCombFiltro.LocalReport.DataSources.Add(ds);
                        ReporteCombFiltro.RefreshReport();
                    }
                    else if (txtMax.Text == "" && txtMin.Text == "" && cmbTipoComb.SelectedIndex != -1 && txtNom.Text == "")
                    {

                        DataTable tabla = new DataTable();
                        tabla = AD_Combustible.ObtenerListadoCombustiblesReporteCmb(cmbTipoComb.SelectedValue.ToString());

                        ReportDataSource ds = new ReportDataSource("DataSetCombustible", tabla);

                        ReporteCombFiltro.LocalReport.DataSources.Clear();
                        ReporteCombFiltro.LocalReport.DataSources.Add(ds);
                        ReporteCombFiltro.RefreshReport();
                    }
                    else if (txtMax.Text == "" && txtMin.Text == "" && cmbTipoComb.SelectedIndex != -1 && txtNom.Text != "")
                    {
                        DataTable tabla = new DataTable();
                        tabla = AD_Combustible.ObtenerListadoCombustiblesReporteCmbNom(cmbTipoComb.SelectedValue.ToString(), txtNom.Text);

                        ReportDataSource ds = new ReportDataSource("DataSetCombustible", tabla);

                        ReporteCombFiltro.LocalReport.DataSources.Clear();
                        ReporteCombFiltro.LocalReport.DataSources.Add(ds);
                        ReporteCombFiltro.RefreshReport();
                    }

                    else if (txtMax.Text == "" && txtMin.Text == "" && cmbTipoComb.SelectedIndex == -1 && txtNom.Text != "")
                    {
                        DataTable tabla = new DataTable();
                        tabla = AD_Combustible.ObtenerListadoCombustiblesReporteNom(txtNom.Text);

                        ReportDataSource ds = new ReportDataSource("DataSetCombustible", tabla);

                        ReporteCombFiltro.LocalReport.DataSources.Clear();
                        ReporteCombFiltro.LocalReport.DataSources.Add(ds);
                        ReporteCombFiltro.RefreshReport();
                    }
                    else if (txtMax.Text != "" && txtMin.Text != "" && cmbTipoComb.SelectedIndex != -1 && txtNom.Text != "")
                    {
                        DataTable tabla = new DataTable();
                        tabla = AD_Combustible.ObtenerListadoCombustiblesReporteMaxMinCmbNom(txtMax.Text, txtMin.Text, cmbTipoComb.SelectedValue.ToString(), txtNom.Text);

                        ReportDataSource ds = new ReportDataSource("DataSetCombustible", tabla);

                        ReporteCombFiltro.LocalReport.DataSources.Clear();
                        ReporteCombFiltro.LocalReport.DataSources.Add(ds);
                        ReporteCombFiltro.RefreshReport();
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Error al recuperar los datos.");
                }
                LimpiarCampos();
            }
        }

        private void ReporteCombFiltro_Load(object sender, EventArgs e)
        {
            
            DataTable tabla = new DataTable();
            tabla = AD_Combustible.ObtenerListadoCombustiblesReporte();

            ReportDataSource ds = new ReportDataSource("DataSetCombustible", tabla);

            ReporteCombFiltro.LocalReport.DataSources.Clear();
            ReporteCombFiltro.LocalReport.DataSources.Add(ds);
            ReporteCombFiltro.LocalReport.Refresh();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
