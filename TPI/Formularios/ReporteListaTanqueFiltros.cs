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
    public partial class ReporteListaTanqueFiltros : Form
    {
        public ReporteListaTanqueFiltros()
        {
            InitializeComponent();
        }

        private void ReporteListaTanqueFiltros_Load(object sender, EventArgs e)
        {
            CargarComboEstacion();
            CargarComboTiposDeCombustible();
            this.ReporteTanqueFiltro.RefreshReport();
        }

        private void ReporteTanqueFiltro_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Tanque.ObtenerListadoTanquesReporte();
            ReportDataSource ds = new ReportDataSource("ConjuntoDeDatosTanque", tabla);

            ReporteTanqueFiltro.LocalReport.DataSources.Clear();
            ReporteTanqueFiltro.LocalReport.DataSources.Add(ds);
            ReporteTanqueFiltro.LocalReport.Refresh();
        }

        private void CargarComboEstacion()
        {
            cmbEstacion.DataSource = AD_Tanque.ObtenerCuitEstacion();
            cmbEstacion.DisplayMember = "nombre";
            cmbEstacion.ValueMember = "cuitEstacion";
            cmbEstacion.SelectedIndex = -1;
        }

        private void CargarComboTiposDeCombustible()
        {
            cmbTipoComb.DataSource = AD_Combustible.ObtenerTipoCombustible();
            cmbTipoComb.DisplayMember = "nombre";
            cmbTipoComb.ValueMember = "codTipoCombustible";
            cmbTipoComb.SelectedIndex = -1;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNroTanque.Text = "";
            txtVolMax.Text = "";
            txtVolDisp.Text = "";
            txtMinLit.Text = "";
            cmbTipoComb.SelectedIndex = -1;
            cmbEstacion.SelectedIndex = -1;
        }

        private bool obtenerDatos()
        {
            if (txtNroTanque.Text != "" || txtVolMax.Text != "" || cmbTipoComb.SelectedIndex != -1 || txtVolDisp.Text != "" || txtMinLit.Text !="" || cmbEstacion.SelectedIndex != -1)
            {
                return true;
            }
            MessageBox.Show("Seleccione Filtros por favor!");
            return false;


        }
        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            string nroTanque = "" ;
            string estacion = "";
            string volMax = "";
            string minLit = "";
            string tipoComb = "";
            string volDisp = "";
            bool resultado = obtenerDatos();
            
            if (resultado)
            {
                try
                {
                    if (txtNroTanque.Text != "")
                    {
                        nroTanque = txtNroTanque.Text;
                    }
                    if (cmbEstacion.SelectedIndex != -1)
                    {
                        estacion = cmbEstacion.SelectedValue.ToString();
                    }
                    if(txtVolMax.Text != "")
                    {
                        volMax = txtVolMax.Text;
                    }
                    if(txtMinLit.Text != "")
                    {
                        minLit = txtMinLit.Text;
                    }
                    if(cmbTipoComb.SelectedIndex != -1)
                    {
                        tipoComb = cmbTipoComb.SelectedValue.ToString();
                    }
                    if(txtVolDisp.Text != "")
                    {
                        volDisp = txtVolDisp.Text;
                    }

                    DataTable tabla = new DataTable();
                    tabla = AD_Tanque.ObtenerListaTanquesConFiltro(nroTanque, estacion, volMax, minLit, tipoComb, volDisp);

                    ReportDataSource ds = new ReportDataSource("ConjuntoDeDatosTanque", tabla);

                    ReporteTanqueFiltro.LocalReport.DataSources.Clear();
                    ReporteTanqueFiltro.LocalReport.DataSources.Add(ds);
                    ReporteTanqueFiltro.RefreshReport();

                }
                catch (Exception)
                {

                    MessageBox.Show("Error al obtener el listado de tanques");
                }
            }


        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
    
}
