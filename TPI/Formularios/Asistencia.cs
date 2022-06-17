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
    public partial class Asistencia : Form
    {
        public Asistencia()
        {
            InitializeComponent();
        }

        private void Asistencia_Load(object sender, EventArgs e)
        {
            CargarComboCuitEstacion();
            CargarComboTurno(cmbCuitEstacion.SelectedValue.ToString());
            CargarFecha();
            CargarComboNroDoc(cmbCuitEstacion.SelectedValue.ToString());
            

        }

        private void CargarComboCuitEstacion()
        {
            cmbCuitEstacion.DataSource = AD_Tanque.ObtenerCuitEstacion();
            cmbCuitEstacion.DisplayMember = "nombre";
            cmbCuitEstacion.ValueMember = "cuitEstacion";
            cmbCuitEstacion.SelectedIndex = 0;
        }

        private void CargarComboTurno(string cuitEstacion)
        {
            cmbNombreTurno.DataSource = AD_Asistencia.ObtenerTurnoEstacion(cuitEstacion);
            cmbNombreTurno.DisplayMember = "nombreTurno";
            cmbNombreTurno.ValueMember = "nombreTurno";
            cmbNombreTurno.SelectedIndex = -1;

        }

        private void cmbCuitEstacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int)cmbCuitEstacion.SelectedIndex > 0)
            {
                CargarComboTurno(cmbCuitEstacion.SelectedValue.ToString());
                CargarComboNroDoc(cmbCuitEstacion.SelectedValue.ToString());
                LimpiarGrilla();
            }
            else
            {
                CargarComboCuitEstacion();
                CargarComboTurno(cmbCuitEstacion.SelectedValue.ToString());
                CargarComboNroDoc(cmbCuitEstacion.SelectedValue.ToString());
                LimpiarGrilla();
            }

        }

        private void CargarFecha()
        {
            txtFecha.Text = AdaptarFecha(DateTime.Today);
        }

        private string AdaptarFecha(DateTime fecha)
        {
            string dia = "";
            string mes = "";
            string año = "";
            dia = fecha.Date.Day.ToString();
            if (dia.Length == 1)
            {
                dia = "0" + dia;
            }
            mes = fecha.Date.Month.ToString();
            if (mes.Length == 1)
            {
                mes = "0" + mes;
            }
            año = fecha.Date.Year.ToString();

            string fechaAdaptada = dia + mes + año;
            return fechaAdaptada;
        }


        private void CargarComboNroDoc(string cuitEstacion)
        {
            try
            {
                cmbDocEmpleado.DataSource = AD_Asistencia.ObtenerNroDoc(cuitEstacion);
                cmbDocEmpleado.DisplayMember = "nroDoc";
                cmbDocEmpleado.ValueMember = "nroDoc";
                cmbDocEmpleado.SelectedIndex = -1;
            }
            catch (Exception)
            {

                throw;
            }

            
        }

        private void CargarComboTipoDoc(string nroDoc)
        {
            try
            {
                cmbTipoDoc.DataSource = AD_Asistencia.ObtenerTipoDoc(nroDoc);
                cmbTipoDoc.DisplayMember = "nombre";
                cmbTipoDoc.ValueMember = "tipoDoc";
                cmbTipoDoc.SelectedIndex = -1;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cmbDocEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int)cmbDocEmpleado.SelectedIndex >= 0)
            {
                CargarComboTipoDoc(cmbDocEmpleado.SelectedValue.ToString());
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

        private void LimpiarCampos()
        {
            cmbDocEmpleado.SelectedIndex = -1;
            cmbTipoDoc.SelectedIndex = -1;
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {

            if ((cmbDocEmpleado.SelectedIndex != -1) && (cmbTipoDoc.SelectedIndex != -1) )
            {
                try
                {
                    DataTable tabla = AD_Asistencia.ObtenerEmpleado(cmbDocEmpleado.SelectedValue.ToString(), (int)cmbTipoDoc.SelectedValue);
                    grdEmpleado.Rows.Add(tabla.Rows[0]["nroDoc"], tabla.Rows[0]["tipoDoc"], tabla.Rows[0]["nombre"], tabla.Rows[0]["apellido"]);
                    LimpiarCampos();
                    btnGenerarAsistencia.Enabled = true;
                    btnLimpiarGrilla.Enabled = true;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("No se puede agregar al empleado.");
                }
            }
            else
            {
                MessageBox.Show("Debe Seleccionar un numero de documento y un tipo de documento.");
            }
                     
        }

        private void btnGenerarAsistencia_Click(object sender, EventArgs e)
        {
            List<string> listaDocumentos = new List<string>();
            List<int> listaTipoDocumentos = new List<int>();
            //List<string> listaNombres = new List<string>();
            //List<string> listaApellidos = new List<string>();


            for (int i = 0; i < grdEmpleado.Rows.Count; i++)
            {
                listaDocumentos.Add(grdEmpleado.Rows[i].Cells[0].Value.ToString());
                listaTipoDocumentos.Add(int.Parse(grdEmpleado.Rows[i].Cells[1].Value.ToString()));

            }

            bool resultado = AD_Asistencia.GenerarAsistencia(cmbCuitEstacion.SelectedValue.ToString(), cmbNombreTurno.SelectedValue.ToString(), txtFecha.Text, listaDocumentos, listaTipoDocumentos);

            if (resultado)
            {
                MessageBox.Show("Asistencia generada con exito");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al generar la Asistencia");
            }
        }

        private void LimpiarGrilla()
        {
            grdEmpleado.Rows.Clear();
            btnGenerarAsistencia.Enabled = false;           

        }

        private void cmbNombreTurno_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimpiarGrilla();
        }

        private void btnLimpiarGrilla_Click(object sender, EventArgs e)
        {
            LimpiarGrilla();
        }
    }
}
