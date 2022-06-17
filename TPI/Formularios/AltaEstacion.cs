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
    public partial class AltaEstacion : Form
    {
        public AltaEstacion()
        {
            InitializeComponent();
        }

        private void AltaEstacion_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarComboCiudad();
            CargarComboTipoDoc();
            CargarGrilla();
            btnModificarEstacion.Enabled = false;
            btnEliminarEstacion.Enabled = false;
        }

        private void LimpiarCampos()
        {
            txtCuit.Text = "";
            txtNombreSuc.Text = "";
            txtNroSuc.Text = "";
            txtCalle.Text = "";
            txtNroCalle.Text = "";
            txtNroDoc.Text = "";
            cmbCiudad.SelectedIndex = -1;
            cmbTipoDoc.SelectedIndex = -1;
        }

        private void btnAgregarEstacion_Click(object sender, EventArgs e)
        {
            Estacion est = ObtenerDatosEstacion();
            bool resul = false;
            try
            {
                resul = AD_Estacion.consultarExistenciaEmpleado(txtNroDoc.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }

            if (resul)
            {
                try
                {
                    bool resultado = AD_Estacion.AgregarEstacionABD(est);
                    if (resultado)
                    {
                        MessageBox.Show("Estacion agregada con exito");
                        LimpiarCampos();
                        CargarComboCiudad();
                        CargarComboTipoDoc();
                        CargarGrilla();

                    }
                    else
                    {
                        MessageBox.Show("La Estacion ya esta registrada en el sistema.");
                    }

                }
                catch (Exception)
                {

                    throw;
                }

            }
            else
            {
                MessageBox.Show("El nro de documento del gerente no se encuentra en la Base de Datos");
            }
        }

        private void CargarGrilla()
        {
            try
            {
                gdrEstacion.DataSource = AD_Estacion.ObtenerListadoEstacion();
            }
            catch (Exception)
            {

                MessageBox.Show("Error al obtener las estaciones");
            }

        }

        private void CargarComboCiudad()
        {
            try
            {
                cmbCiudad.DataSource = AD_Estacion.ObtenerCiudad();
                cmbCiudad.DisplayMember = "nombre";
                cmbCiudad.ValueMember = "idCiudad";
                cmbCiudad.SelectedIndex = -1;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CargarComboTipoDoc()
        {
            try
            {
                cmbTipoDoc.DataSource = AD_Estacion.ObtenerTipoDoc();
                cmbTipoDoc.DisplayMember = "nombre";
                cmbTipoDoc.ValueMember = "tipoDoc";
                cmbTipoDoc.SelectedIndex = -1;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private Estacion ObtenerDatosEstacion()
        {
            Estacion e = new Estacion();
            try
            {

                e.NroCuitSuc = txtCuit.Text.Trim();
                e.NumSucursal = int.Parse(txtNroSuc.Text.Trim());
                e.NombreSucursal = txtNombreSuc.Text.Trim();
                e.CalleSucursal = txtCalle.Text.Trim();
                e.NumeroCalleSucursal = txtNroCalle.Text.Trim();
                e.CiudadSucursal = (int)cmbCiudad.SelectedValue;
                e.NroDocGerenteEstacion = txtNroDoc.Text.Trim();
                e.TipoDocGerenteEstacion = (int)cmbTipoDoc.SelectedValue;


            }
            catch (Exception)
            {

                MessageBox.Show("No debe haber campos vacios");
            }

            return e;


        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            btnAgregarEstacion.Enabled = true;
            txtCuit.Enabled = true;
        }

        private void gdrEstacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnModificarEstacion.Enabled = true;
            btnEliminarEstacion.Enabled = true;
            btnAgregarEstacion.Enabled = false;
            txtCuit.Enabled = false;

            DataGridViewRow filaSeleccionada = gdrEstacion.Rows[indice];
            string cuit = filaSeleccionada.Cells["cuitEstacion"].Value.ToString();

            try
            {
                Estacion es = AD_Estacion.ObtenerEstacion(cuit);
                LimpiarCampos();
                CargarCampos(es);

            }
            catch (Exception)
            {

                MessageBox.Show("Error al obtener los datos de la estacion");
            }
        }

        private void CargarCampos(Estacion es)
        {
            txtCuit.Text = es.NroCuitSuc;
            txtNroSuc.Text = es.NumSucursal.ToString();
            txtNombreSuc.Text = es.NombreSucursal;
            txtCalle.Text = es.CalleSucursal;
            txtNroCalle.Text = es.NumeroCalleSucursal;
            cmbCiudad.SelectedValue = es.CiudadSucursal;
            txtNroDoc.Text = es.NroDocGerenteEstacion;
            cmbTipoDoc.SelectedValue = es.TipoDocGerenteEstacion;

        }

        private void btnModificarEstacion_Click(object sender, EventArgs e)
        {
            Estacion es = ObtenerDatosEstacion();
            try
            {
                bool resultado = AD_Estacion.ActualizarEstacionABD(es);
                if(resultado)
                {
                    MessageBox.Show("Estacion actulizada con exito.");
                    LimpiarCampos();
                    btnAgregarEstacion.Enabled = true;
                    txtCuit.Enabled = true;
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("Error al actulizar la estacion.");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error al actulizar la estacion.");
            }
        }

        private void btnEliminarEstacion_Click(object sender, EventArgs e)
        {
            Estacion es = ObtenerDatosEstacion();
            try
            {
                bool resultado = AD_Estacion.EliminarEstacionABD(es);
                if(resultado)
                {
                    MessageBox.Show("Estacion eliminado con éxito");
                    LimpiarCampos();
                    btnAgregarEstacion.Enabled = true;
                    txtCuit.Enabled = true;
                    btnEliminarEstacion.Enabled = false;
                    btnModificarEstacion.Enabled = false;
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("Error al eliminar la estacion");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error debe borrar todos los tanques pertenecientes a esta estación antes");
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
