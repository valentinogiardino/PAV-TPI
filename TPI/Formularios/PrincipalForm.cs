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
using TPI.Entidades;
using TPI.Formularios;

namespace TPI
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm(Empleado emp)
        {

            InitializeComponent();
            string nombre = NombreLogin(emp);
            lblBienvenida.Text = "Bienvenido " + nombre + "!";
            personalizarMenu();


        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void personalizarMenu()
        {
            panelAltasEstacion.Visible = false;
            panelAltasVarias.Visible = false;
            panelReporte.Visible = false;
            panelReporteFiltros.Visible = false;
        }

        private void ocultarSubmenus()
        {
            if (panelAltasEstacion.Visible == true)
            {
                panelAltasEstacion.Visible = false;
            }
            if (panelAltasVarias.Visible == true)
            {
                panelAltasVarias.Visible = false;
            }
            if (panelReporte.Visible == true)
            {
                panelReporte.Visible = false;
            }
            if (panelReporteFiltros.Visible == true)
            {
                panelReporteFiltros.Visible = false;
            }
        }

        private void mostrarSubmenus(Panel submenu)
        {
            if(submenu.Visible == false)
            {
                ocultarSubmenus();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }
      
        private void CargarFecha()
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {
            CargarFecha();
        }

        private string NombreLogin(Empleado emp)
        {
            string legajo = emp.LegajoDeEmpleado;
            string doc = emp.NroDocumentoEmpleado;
            string nombre = "";
            try
            {
                nombre = AD_Usuarios.ObtenerUsuario(doc, legajo);
                return nombre;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al recuperar el nombre de usuario.");
                return nombre;
            }
            
        }

        private void btnAltasEstacion_Click(object sender, EventArgs e)
        {
            mostrarSubmenus(panelAltasEstacion);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            mostrarSubmenus(panelReporte);
        }

        private void btnAltaEstaciones_Click(object sender, EventArgs e)
        {
            AltaEstacion ventana = new AltaEstacion();
            ventana.ShowDialog();
        }

        private void btnAltaTanques_Click(object sender, EventArgs e)
        {
            AltaTanque ventana = new AltaTanque();
            ventana.ShowDialog();
        }

        private void btnAltaCamiones_Click(object sender, EventArgs e)
        {
            AltaCamion ventana = new AltaCamion();
            ventana.ShowDialog();
        }

        private void btnAltaCombustible_Click(object sender, EventArgs e)
        {
            AltaCombustible ventana = new AltaCombustible();
            ventana.ShowDialog();
        }

        private void btnAltaEmpleado_Click(object sender, EventArgs e)
        {
            AltaEmpleado ventana = new AltaEmpleado();
            ventana.ShowDialog();
        }

        private void btnAltaTurno_Click(object sender, EventArgs e)
        {
            AltaTurno ventana = new AltaTurno();
            ventana.ShowDialog();
        }

        private void btnAltaVarios_Click(object sender, EventArgs e)
        {
            mostrarSubmenus(panelAltasVarias);
        }

        private void btnAltaMarca_Click(object sender, EventArgs e)
        {
            ABM_Marca ventana = new ABM_Marca();
            ventana.ShowDialog();
        }

        private void btnAltaModelo_Click(object sender, EventArgs e)
        {
            ABM_Modelo ventana = new ABM_Modelo();
            ventana.ShowDialog();
        }

        private void btnAltaCiudad_Click(object sender, EventArgs e)
        {
            AltaCiudad ventana = new AltaCiudad();
            ventana.Show();
        }

        private void btnAltaProvincia_Click(object sender, EventArgs e)
        {
            AltaProvincia ventana = new AltaProvincia();
            ventana.ShowDialog();
        }

        private void btnAltaPais_Click(object sender, EventArgs e)
        {
            AltaPais ventana = new AltaPais();
            ventana.ShowDialog();
        }

        private void btnAltaTipoDoc_Click(object sender, EventArgs e)
        {
            AltaTipoDoc ventana = new AltaTipoDoc();
            ventana.ShowDialog();
        }

        private void btnAltaTipoCom_Click(object sender, EventArgs e)
        {
            AltaTipoCombustible ventana = new AltaTipoCombustible();
            ventana.ShowDialog();
        }

        private void btnAsistencias_Click(object sender, EventArgs e)
        {
            Asistencia ventana = new Asistencia();
            ventana.ShowDialog();
            
        }

        private void btnRemito_Click(object sender, EventArgs e)
        {
            Remitos ventana = new Remitos();
            ventana.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReporteListadoCombustibleFiltros ventana = new ReporteListadoCombustibleFiltros();
            ventana.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ReporteListadoCamiones ventana = new ReporteListadoCamiones();
            ventana.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReporteListaCamionConFiltros ventana = new ReporteListaCamionConFiltros();
            ventana.ShowDialog();
        }

        private void btnReporteCombustible_Click(object sender, EventArgs e)
        {
            ReporteListaCombustible ventana = new ReporteListaCombustible();
            ventana.ShowDialog();
        }

        private void btnReporteCamion_Click(object sender, EventArgs e)
        {
            ReporteListadoCamiones ventana = new ReporteListadoCamiones();
            ventana.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReporteListadoCombustibleFiltros ventana = new ReporteListadoCombustibleFiltros();
            ventana.ShowDialog();
        }

        private void btnCamionFiltro_Click(object sender, EventArgs e)
        {
            ReporteListaCamionConFiltros ventana = new ReporteListaCamionConFiltros();
            ventana.ShowDialog();
        }

        private void buttonReporteFiltros_Click(object sender, EventArgs e)
        {
            mostrarSubmenus(panelReporteFiltros);
        }

        private void btnEstacion_Click(object sender, EventArgs e)
        {
            ReporteListadoEstaciones ventana = new ReporteListadoEstaciones();
            ventana.ShowDialog();
        }

        private void btnEstacionesFiltrado_Click(object sender, EventArgs e)
        {
            ReporteFiltradoEstaciones ventana = new ReporteFiltradoEstaciones();
            ventana.ShowDialog();
        }

        private void btnListadoAsistencia_Click(object sender, EventArgs e)
        {
            ListadoAsistencias ventana = new ListadoAsistencias();
            ventana.ShowDialog();
        }

        private void btnReporteEmpleado_Click(object sender, EventArgs e)
        {
            ListadoEmpleadoTurno ventana = new ListadoEmpleadoTurno();
            ventana.ShowDialog();
        }

        private void btnListadoTurnos_Click(object sender, EventArgs e)
        {
            ReporteListadoTurnos ventana = new ReporteListadoTurnos();
            ventana.ShowDialog();
        }

        private void btnReporteTurnoFiltro_Click(object sender, EventArgs e)
        {
            ReporteListadoTurnoRestricciones ventana = new ReporteListadoTurnoRestricciones();
            ventana.ShowDialog();
        }

        private void btnListadoTanque_Click(object sender, EventArgs e)
        {
            ReporteListaTanques ventana = new ReporteListaTanques();
            ventana.ShowDialog();
        }

        private void btnReporteTanqueFiltro_Click(object sender, EventArgs e)
        {
            ReporteListaTanqueFiltros ventana = new ReporteListaTanqueFiltros();
            ventana.ShowDialog();

        }

        private void btnEmpleadosReporte_Click(object sender, EventArgs e)
        {
            ReporteListaEmpleado ventana = new ReporteListaEmpleado();
            ventana.ShowDialog();
        }

        private void btnEmpleadoFiltro_Click(object sender, EventArgs e)
        {
            ReporteListaEmpleadoRestricciones ventana = new ReporteListaEmpleadoRestricciones();
            ventana.ShowDialog();
        }

        private void btnEstadistica3_Click(object sender, EventArgs e)
        {
            ReporteEstadistica3 ventana = new ReporteEstadistica3();
            ventana.ShowDialog();
        }

        private void btnEstadistica3Filtros_Click(object sender, EventArgs e)
        {
            Estadistica3Filtros ventana = new Estadistica3Filtros();
            ventana.ShowDialog();
        }
    }
}
