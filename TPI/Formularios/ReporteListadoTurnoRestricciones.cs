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
    public partial class ReporteListadoTurnoRestricciones : Form
    {
        public ReporteListadoTurnoRestricciones()
        {
            InitializeComponent();
        }

        private void ReporteListadoTurnoRestricciones_Load(object sender, EventArgs e)
        {

            this.reportTurnosRestricciones.RefreshReport();
            CargarComboNombres();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
            DataTable tabla = new DataTable();
            string horaDesde = txtHoraDesde.Text;
            string horaHasta = txtHoraHasta.Text;

            if (cmbNombreTurno.SelectedIndex == -1)
            {
                if (txtHoraDesde.Text == "  :")  
                {
                    horaDesde = "";
                }
                if (txtHoraHasta.Text == "  :")
                {
                    horaHasta = "";
                }

                try
                {
                    tabla = AD_Turno.ObtenerListadoTurnosReporteRestricciones(txtCuitEstacion.Text, "", horaDesde, horaHasta);
                }
                catch (Exception)
                {

                    MessageBox.Show("Error al obtener el listado de turnos");
                }
               
            }
            else
            {
                if (txtHoraDesde.Text == "  :")
                {
                    horaDesde = "";
                }
                if (txtHoraHasta.Text == "  :")
                {
                    horaHasta = "";
                }

                try
                {
                    tabla = AD_Turno.ObtenerListadoTurnosReporteRestricciones(txtCuitEstacion.Text, cmbNombreTurno.SelectedValue.ToString(), horaDesde, horaHasta);
                }
                catch (Exception)
                {

                    MessageBox.Show("Error al obtener el listado de turnos");
                }
                
            }

            ReportDataSource ds = new ReportDataSource("DatosTurnos", tabla);

            reportTurnosRestricciones.LocalReport.DataSources.Clear();
            reportTurnosRestricciones.LocalReport.DataSources.Add(ds);
            reportTurnosRestricciones.RefreshReport();
        }

        private void reportTurnosRestricciones_Load(object sender, EventArgs e)
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

            reportTurnosRestricciones.LocalReport.DataSources.Clear();
            reportTurnosRestricciones.LocalReport.DataSources.Add(ds);
            reportTurnosRestricciones.LocalReport.Refresh();
        }

        private void CargarComboNombres() 
        {
            try
            {
                cmbNombreTurno.DataSource = AD_Turno.ObtenerNombresTurno();
                cmbNombreTurno.DisplayMember = "nombreTurno";
                cmbNombreTurno.ValueMember = "nombreTurno";
                cmbNombreTurno.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar turnos");
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtCuitEstacion.Text = "";
            txtHoraDesde.Text = "";
            txtHoraHasta.Text = "";
            cmbNombreTurno.SelectedIndex = -1;
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