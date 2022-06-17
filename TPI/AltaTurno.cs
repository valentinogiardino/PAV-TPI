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

namespace TPI
{
    public partial class AltaTurno : Form
    {
        public AltaTurno()
        {
            InitializeComponent();
        }

        private void AltaTurno_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarComboEstacion();
            CargarGrilla();
            
        }

        private void LimpiarCampos()
        {
            cmbCuitEstacion.SelectedIndex = -1;
            txtNombreTurno.Text = "";
            txtDescripcion.Text = "";
        }

        private void CargarGrilla()
        {

            try
            {
                grdTurno.DataSource = AD_Turno.ObtenerListadoTurno();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener Turnos.");
            }


        }

        private void btnGuardarTurno_Click(object sender, EventArgs e)
        {
            Turno t = ObtenerDatosTurno();

            bool resultado = AD_Turno.AgregarTurnoABD(t);
            if (resultado)
            {
                MessageBox.Show("Turno agregado con exito!");
                LimpiarCampos();
                CargarGrilla();

            }
            else
            {
                MessageBox.Show("Error al agregar el Turno.");
            }
        }

        private Turno ObtenerDatosTurno()
        {
            Turno t = new Turno();
            t.CuitDeLaEstacion = cmbCuitEstacion.SelectedValue.ToString();
            t.NombreDelTurno = txtNombreTurno.Text.Trim();
            t.DescripcionDelTurno = txtDescripcion.Text.Trim();
            return t;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizarTurno_Click(object sender, EventArgs e)
        {
            Turno t = ObtenerDatosTurno();
            try
            {
                bool resultado = AD_Turno.ActualizarTurnoABD(t);
                if (resultado)
                {
                    MessageBox.Show("Turno actualizado con éxito");
                    LimpiarCampos();
                    btnGuardarTurno.Enabled = true;
                    btnActualizarTurno.Enabled = false;
                    btnBorrarTurno.Enabled = false;
                    CargarGrilla();

                }
                else
                {
                    MessageBox.Show("Error al actualizar Turno");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar Turno");

            }
        }

        private void CargarCampos(Turno t)
        {
            cmbCuitEstacion.SelectedValue = t.CuitDeLaEstacion;
            txtNombreTurno.Text = t.NombreDelTurno;
            txtDescripcion.Text = t.DescripcionDelTurno;
        }

        private void grdTurno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnActualizarTurno.Enabled = true;
            btnBorrarTurno.Enabled = true;
            btnGuardarTurno.Enabled = false;
            DataGridViewRow filaSeleccionada = grdTurno.Rows[indice];
            string cuitEstacion = filaSeleccionada.Cells["cuitEstacion"].Value.ToString();
            try
            {
                Turno t = AD_Turno.ObtenerTurno(cuitEstacion);
                LimpiarCampos();
                CargarCampos(t);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al obtener los datos del Turno");
            }
        }

        private void btnBorrarTurno_Click(object sender, EventArgs e)
        {
            Turno t = ObtenerDatosTurno();
            try
            {
                bool resultado = AD_Turno.EliminarTurnoABD(t);
                if (resultado)
                {
                    MessageBox.Show("Turno eliminado con éxito");
                    LimpiarCampos();
                    btnGuardarTurno.Enabled = true;
                    btnBorrarTurno.Enabled = false;
                    btnActualizarTurno.Enabled = false;
                    CargarGrilla();

                }
                else
                {
                    MessageBox.Show("Error al eliminar Turno");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar Turno");

            }
        }

        private void btnLimpiarDatos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void CargarComboEstacion()
        {
            try
            {
                cmbCuitEstacion.DataSource = AD_Turno.ObtenerCuitsEstacion();
                cmbCuitEstacion.DisplayMember = "cuitEstacion";
                cmbCuitEstacion.ValueMember = "cuitEstacion";
                cmbCuitEstacion.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el combo Estaciones");
            }
        }
    }
}
