using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI.AccesoADatos;
using TPI.Entidades;

namespace TPI
{
    public partial class AltaEmpleado : Form
    {
        public AltaEmpleado()
        {
            InitializeComponent();
        }

        private void AltaEmpleado_Load(object sender, EventArgs e)
        {
            CargarComboTipoDocumentos();
            CargarComboCiudades();
            CargarGrilla();
            txtFechaIngreso.Text = AdaptarFecha(DateTime.Today);
            btnActualizarEmpleado.Enabled = false;
            btnBorrarEmpleado.Enabled = false;
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

        private void CargarGrilla()
        {
            try
            {
                grillaEmpleados.DataSource = AD_Empleados.ObtenerGrilla();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar la grilla");
            }
        }

        private void CargarComboTipoDocumentos()
        {
            try
            {
                cmbTipoDocumento.DataSource = AD_Varios.ObtenerTipoDocumentos();
                cmbTipoDocumento.DisplayMember = "nombre";
                cmbTipoDocumento.ValueMember = "tipoDoc";
                cmbTipoDocumento.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tipos de documento");
            }
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

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtLegajo.Text = "";
            txtCuil.Text = "";
            txtNroDocumento.Text = "";
            txtCalle.Text = "";
            txtNroCasa.Text = "";
            chkGerente.Checked = false;
            txtFechaIngreso.Text = "";
        }

        private Empleado ObtenerDatosEmpleado()
        {
            Empleado e = new Empleado();
            if (cmbTipoDocumento.SelectedValue != null || cmbCiudad.SelectedValue != null)
            {
                e.NombreEmpleado = txtNombre.Text.Trim();
                e.ApellidoEmpleado = txtApellido.Text.Trim();
                e.LegajoDeEmpleado = txtLegajo.Text.Trim();
                e.CuilEmpleado = txtCuil.Text.Trim();
                e.TipoDocEmpleado = (int)cmbTipoDocumento.SelectedValue;
                e.NroDocumentoEmpleado = txtNroDocumento.Text.Trim();
                e.IdCiudadEmpleado = (int)cmbCiudad.SelectedValue;
                e.CalleEmpleado = txtCalle.Text.Trim();
                e.NroCalleEmpleado = txtNroCasa.Text.Trim();
                if (chkGerente.Checked)
                {
                    e.GerenteEmpleado = true;
                }
                else
                {
                    e.GerenteEmpleado = false;
                }
                e.FechaIngresoEmpleado = DateTime.Parse(txtFechaIngreso.Text);
            }
            return e;
        }
        private void btnGuardarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                Empleado empleado = ObtenerDatosEmpleado();
                bool resultado = AD_Empleados.AgregarEmpleadoABD(empleado);
                if (resultado)
                {
                    MessageBox.Show("Empleado guardado con éxito");
                    CargarComboTipoDocumentos();
                    CargarComboCiudades();
                    LimpiarCampos();
                    CargarGrilla();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al guardar empleado");
            }
        }

        private void grillaEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnActualizarEmpleado.Enabled = true;
            btnBorrarEmpleado.Enabled = true;
            btnGuardarEmpleado.Enabled = false;
            DataGridViewRow filaSeleccionada = grillaEmpleados.Rows[indice];
            int tipoDocumento = int.Parse(filaSeleccionada.Cells["tipoDocumento"].Value.ToString());
            string nroDocumento = filaSeleccionada.Cells["nroDocumento"].Value.ToString();
            Empleado empleado = AD_Empleados.ObtenerDatosEmpleado(tipoDocumento, nroDocumento);
            LimpiarCampos();
            CargarCampos(empleado);
        }

        private void CargarCampos(Empleado e)
        {
            txtNombre.Text = e.NombreEmpleado;
            txtApellido.Text = e.ApellidoEmpleado;
            txtLegajo.Text = e.LegajoDeEmpleado;
            txtCuil.Text = e.CuilEmpleado;
            cmbTipoDocumento.SelectedValue = e.TipoDocEmpleado;
            txtNroDocumento.Text = e.NroDocumentoEmpleado;
            cmbCiudad.SelectedValue = e.IdCiudadEmpleado;
            txtCalle.Text = e.CalleEmpleado;
            txtNroCasa.Text = e.NroCalleEmpleado;
            if (e.GerenteEmpleado)
            {
                chkGerente.Checked = true;
            }
            else
            {
                chkGerente.Checked = false;
            }
            DateTime fecha = e.FechaIngresoEmpleado;
            txtFechaIngreso.Text = AdaptarFecha(fecha);
        }

        private void btnActualizarEmpleado_Click(object sender, EventArgs e)
        {
            Empleado empleado = ObtenerDatosEmpleado();
            bool resultado = AD_Empleados.ActualizarEmpleadoABD(empleado);
            if (resultado)
            {
                MessageBox.Show("Empleado actualizado con éxito");
                CargarComboTipoDocumentos();
                CargarComboCiudades();
                LimpiarCampos();
                CargarGrilla();
                btnGuardarEmpleado.Enabled = true;
                btnActualizarEmpleado.Enabled = false;
                btnBorrarEmpleado.Enabled = false;
            }
            else
            {
                MessageBox.Show("Error al actualizar empleado");
            }
        }

        private void btnBorrarEmpleado_Click(object sender, EventArgs e)
        {
            Empleado empleado = ObtenerDatosEmpleado();
            DialogResult result= MessageBox.Show("¿Esta seguro que quiere borrar el empleado?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                bool resultado = AD_Empleados.BorrarEmpleadoABD(empleado);
                if (resultado)
                {
                    MessageBox.Show("Empleado borrado con éxito");
                    CargarComboTipoDocumentos();
                    CargarComboCiudades();
                    LimpiarCampos();
                    CargarGrilla();
                    btnGuardarEmpleado.Enabled = true;
                    btnActualizarEmpleado.Enabled = false;
                    btnBorrarEmpleado.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Error al borrar empleado");
                }
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarComboCiudades();
            CargarComboTipoDocumentos();
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
