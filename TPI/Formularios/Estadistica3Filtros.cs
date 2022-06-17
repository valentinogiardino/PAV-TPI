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
    public partial class Estadistica3Filtros : Form
    {
        public Estadistica3Filtros()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Estadistica3Filtros_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            CargarComboPais();
            CargarComboCriterios();
            
        }

        private void LimpiarCampos()
        {
            cmbPais.SelectedValue = -1;
            cmbProvincia.SelectedValue = -1;
            cmbCiudad.SelectedValue = -1;
            cmbCriterios.SelectedIndex = -1;
            cmbPais.Enabled = true;
            cmbProvincia.Enabled = true;
            cmbCiudad.Enabled = true;
        }
        private void CargarComboPais()
        {
            try
            {

                cmbPais.DataSource = AD_Ciudades.ObtenerPais();
                cmbPais.DisplayMember = "nombre";
                cmbPais.ValueMember = "idPais";
                cmbPais.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los Paises");

            }
        }


        private void cmbPais_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbProvincia.Enabled = true;
            int idPais = int.Parse(cmbPais.SelectedValue.ToString());
            cmbProvincia.DataSource = AD_Ciudades.ObtenerProvincia(idPais);
            cmbProvincia.DisplayMember = "nombre";
            cmbProvincia.ValueMember = "idProvincia";
            cmbProvincia.SelectedIndex = -1;
            if (cmbCriterios.SelectedIndex == 1)
            {
                cmbPais.Enabled = true;
                cmbProvincia.Enabled = false;
                cmbCiudad.Enabled = false;
                
            }
            if (cmbCriterios.SelectedIndex == 2)
            {
                cmbPais.Enabled = true;
                cmbProvincia.Enabled = true;
                cmbCiudad.Enabled = false;
                
            }
            if (cmbCriterios.SelectedIndex == 0 || cmbCriterios.SelectedIndex == -1)
            {
                cmbPais.Enabled = true;
                cmbProvincia.Enabled = true;
                cmbCiudad.Enabled = true;
            }
        }

        private void cmbProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbCiudad.Enabled = true;
            int idProvincia = int.Parse(cmbProvincia.SelectedValue.ToString());
            cmbCiudad.DataSource = AD_Ciudades.ObtenerCiudad2(idProvincia);
            cmbCiudad.DisplayMember = "nombre";
            cmbCiudad.ValueMember = "idCiudad";
            cmbCiudad.SelectedIndex = -1;
            if (cmbCriterios.SelectedIndex == 1)
            {
                cmbPais.Enabled = true;
                cmbProvincia.Enabled = false;
                cmbCiudad.Enabled = false;
            }
            if (cmbCriterios.SelectedIndex == 2)
            {
                cmbPais.Enabled = true;
                cmbProvincia.Enabled = true;
                cmbCiudad.Enabled = false;
            }
            if (cmbCriterios.SelectedIndex == 0 || cmbCriterios.SelectedIndex == -1)
            {
                cmbPais.Enabled = true;
                cmbProvincia.Enabled = true;
                cmbCiudad.Enabled = true;
            }
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCriterios.SelectedIndex != -1)
                {
                    if (cmbCriterios.SelectedIndex == 0)
                    {
                        

                        if (cmbPais.SelectedIndex != -1)
                        {
                            int pais = (int)cmbPais.SelectedValue;
                            if (cmbProvincia.SelectedIndex != -1)
                            {
                                int provincia = (int)cmbProvincia.SelectedValue;
                                if (cmbCiudad.SelectedIndex != -1)
                                {
                                    int ciudad = (int)cmbCiudad.SelectedValue;
                                    DataTable tabla = new DataTable();
                                    tabla = AD_Tanque.ObtenerEstadistica3Filtro(ciudad);

                                    ReportDataSource ds = new ReportDataSource("DatosEstadistcasCombXEstacion", tabla);

                                    reportViewer1.LocalReport.DataSources.Clear();
                                    reportViewer1.LocalReport.DataSources.Add(ds);
                                    reportViewer1.RefreshReport();
                                }

                                else
                                {

                                    DataTable tabla = new DataTable();
                                    tabla = AD_Tanque.ObtenerEstadistica3FiltroProv(provincia);

                                    ReportDataSource ds = new ReportDataSource("DatosEstadistcasCombXEstacion", tabla);

                                    reportViewer1.LocalReport.DataSources.Clear();
                                    reportViewer1.LocalReport.DataSources.Add(ds);
                                    reportViewer1.RefreshReport();
                                }
                            }
                            else
                            {
                                DataTable tabla = new DataTable();
                                tabla = AD_Tanque.ObtenerEstadistica3FiltroPais(pais);

                                ReportDataSource ds = new ReportDataSource("DatosEstadistcasCombXEstacion", tabla);

                                reportViewer1.LocalReport.DataSources.Clear();
                                reportViewer1.LocalReport.DataSources.Add(ds);
                                reportViewer1.RefreshReport();
                            }

                        }

                        else
                        {
                            DataTable tabla = new DataTable();
                            tabla = AD_Tanque.ObtenerEstadistica3();

                            ReportDataSource ds = new ReportDataSource("DatosEstadistcasCombXEstacion", tabla);

                            reportViewer1.LocalReport.DataSources.Clear();
                            reportViewer1.LocalReport.DataSources.Add(ds);
                            reportViewer1.RefreshReport();
                        }
                    }
                    else
                    {
                        if (cmbCriterios.SelectedIndex == 1)
                        {
                            cmbPais.Enabled = true;
                            cmbProvincia.Enabled = false;
                            cmbCiudad.Enabled = false;

                            if (cmbPais.SelectedIndex != -1)
                            {
                                cmbPais.Enabled = true;
                                cmbProvincia.Enabled = false;
                                cmbCiudad.Enabled = false;
                                int pais2 = (int)cmbPais.SelectedValue;
                                DataTable tabla = new DataTable();
                                tabla = AD_Tanque.ObtenerEstadistica3FiltroAgrupadoPais(pais2);

                                ReportDataSource ds = new ReportDataSource("DatosEstadistcasCombXEstacion", tabla);

                                reportViewer1.LocalReport.DataSources.Clear();
                                reportViewer1.LocalReport.DataSources.Add(ds);
                                reportViewer1.RefreshReport();
                            }
                            else
                            {
                                cmbPais.Enabled = true;
                                cmbProvincia.Enabled = false;
                                cmbCiudad.Enabled = false;
                                DataTable tabla = new DataTable();
                                tabla = AD_Tanque.ObtenerEstadistica3FiltroAgrupadoPaisSinFiltro();

                                ReportDataSource ds = new ReportDataSource("DatosEstadistcasCombXEstacion", tabla);

                                reportViewer1.LocalReport.DataSources.Clear();
                                reportViewer1.LocalReport.DataSources.Add(ds);
                                reportViewer1.RefreshReport();
                            }
                        }
                        else
                        {
                            if (cmbCriterios.SelectedIndex == 2)
                            {
                                cmbPais.Enabled = true;
                                cmbProvincia.Enabled = true;
                                cmbCiudad.Enabled = false;

                                if (cmbPais.SelectedIndex != -1 && cmbProvincia.SelectedIndex != -1)
                                {
                                    cmbPais.Enabled = true;
                                    cmbProvincia.Enabled = true;
                                    cmbCiudad.Enabled = false;
                                    int provinica3 = (int)cmbProvincia.SelectedValue;
                                    DataTable tabla = new DataTable();
                                    tabla = AD_Tanque.ObtenerEstadistica3FiltroAgrupadoCiudad(provinica3);

                                    ReportDataSource ds = new ReportDataSource("DatosEstadistcasCombXEstacion", tabla);

                                    reportViewer1.LocalReport.DataSources.Clear();
                                    reportViewer1.LocalReport.DataSources.Add(ds);
                                    reportViewer1.RefreshReport();
                                }
                                else
                                {   
                                    if (cmbPais.SelectedIndex != -1)
                                    {
                                        cmbPais.Enabled = true;
                                        cmbProvincia.Enabled = true;
                                        cmbCiudad.Enabled = false;
                                        int pais3 = (int)cmbPais.SelectedValue;
                                        DataTable tabla = new DataTable();
                                        tabla = AD_Tanque.ObtenerEstadistica3FiltroAgrupadoCiudadFiltroPais(pais3);

                                        ReportDataSource ds = new ReportDataSource("DatosEstadistcasCombXEstacion", tabla);

                                        reportViewer1.LocalReport.DataSources.Clear();
                                        reportViewer1.LocalReport.DataSources.Add(ds);
                                        reportViewer1.RefreshReport();
                                    }
                                    else
                                    {
                                        cmbPais.Enabled = true;
                                        cmbProvincia.Enabled = true;
                                        cmbCiudad.Enabled = false;
                                        DataTable tabla = new DataTable();
                                        tabla = AD_Tanque.ObtenerEstadistica3FiltroAgrupadoCiudadSinFiltro();

                                        ReportDataSource ds = new ReportDataSource("DatosEstadistcasCombXEstacion", tabla);

                                        reportViewer1.LocalReport.DataSources.Clear();
                                        reportViewer1.LocalReport.DataSources.Add(ds);
                                        reportViewer1.RefreshReport();
                                    }
                                }
                            }
                            else
                            {
                                
                            }
                        }
                    }
                }
                }
                

            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error");
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Tanque.ObtenerEstadistica3();

            ReportDataSource ds = new ReportDataSource("DatosEstadistcasCombXEstacion", tabla);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.RefreshReport();
        }

        private void CargarComboCriterios()
        {
            cmbCriterios.Items.Add("Agrupado por estacion");
            cmbCriterios.Items.Add("Agrupado por provincia");
            cmbCriterios.Items.Add("Agrupado por ciudad");
        }

        private void cmbCriterios_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void cmbCriterios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCriterios.SelectedIndex == 1)
            {
                cmbPais.Enabled = true;
                cmbProvincia.Enabled = false;
                cmbCiudad.Enabled = false;
                cmbProvincia.SelectedIndex = -1;
                cmbCiudad.SelectedIndex = -1;
            }
            if (cmbCriterios.SelectedIndex == 2)
            {
                cmbPais.Enabled = true;
                cmbProvincia.Enabled = true;
                cmbCiudad.Enabled = false;
                cmbCiudad.SelectedIndex = -1;
            }
            if (cmbCriterios.SelectedIndex == 0 || cmbCriterios.SelectedIndex == -1)
            {
                cmbPais.Enabled = true;
                cmbProvincia.Enabled = true;
                cmbCiudad.Enabled = true;
            }
        }
    }
}
