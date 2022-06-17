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
    public partial class AltaTanque : Form
    {
        public AltaTanque()
        {
            InitializeComponent();
        }

        private void LimpiarCampos()
        {
            txtNumeroTanque.Text = "";
            cmbCuitEstacion.SelectedIndex = -1;
            txtVolMaximo.Text = "";
            txtMinLit.Text = "";
            cmbIdCombustible.SelectedIndex = -1;
            txtVolDisponible.Text = "";
            cmbCuitEstacion.Focus();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            btnActualizarTanque.Enabled = false;
            btnBorrarTanque.Enabled = false;
        }

        private void AltaTanque_Load(object sender, EventArgs e)
        {
            LimpiarCampos();

            btnActualizarTanque.Enabled = false;
            btnBorrarTanque.Enabled = false;

            CargarComboCuitEstacion();
            CargarComboIdCombustible();
            CargarGrilla();
        }

        private void CargarComboCuitEstacion()
        {
            cmbCuitEstacion.DataSource = AD_Tanque.ObtenerCuitEstacion();
            cmbCuitEstacion.DisplayMember = "nombre";
            cmbCuitEstacion.ValueMember = "cuitEstacion";
            cmbCuitEstacion.SelectedIndex = -1;
        }

        private void CargarComboIdCombustible()
        {
            cmbIdCombustible.DataSource = AD_Tanque.ObtenerIdCombustible();
            cmbIdCombustible.DisplayMember = "nombre";
            cmbIdCombustible.ValueMember = "idCombustible";
            cmbIdCombustible.SelectedIndex = -1;
        }

        private void CargarGrilla()
        {

            try
            {
                grdTanque.DataSource = AD_Tanque.ObtenerListadoTanques();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener Tanques...");
            }
        }

        private void btnGuardarTanque_Click(object sender, EventArgs e)
        {
            Tanque t = ObtenerDatosTanqueAGuardar();

            bool resultado = AD_Tanque.AgregarTanqueABD(t);
            if (resultado)
            {
                MessageBox.Show("Tanque Agregado con éxito!");
                LimpiarCampos();
                CargarComboCuitEstacion();
                CargarComboIdCombustible();
                CargarGrilla();
                cmbCuitEstacion.Focus();

            }
            else
            {
                MessageBox.Show("Error al agregar el Tanque...");
            }
        }

        private Tanque ObtenerDatosTanqueAGuardar()
        {
            Tanque t = new Tanque();

            t.CuitEstacionTanque = (string)cmbCuitEstacion.SelectedValue;
            t.VolMaxCombustible = float.Parse(txtVolMaximo.Text);
            t.MinLitTanque = float.Parse(txtMinLit.Text);
            t.IdCombustibleTanque = (int)cmbIdCombustible.SelectedValue;
            t.VolDisponibleTanque = float.Parse(txtVolDisponible.Text);

            return t;
        }

        private Tanque ObtenerDatosTanqueAModificar()
        {
            Tanque t = new Tanque();

            t.NumDeTanque = int.Parse(txtNumeroTanque.Text);
            t.CuitEstacionTanque = (string)cmbCuitEstacion.SelectedValue;
            t.VolMaxCombustible = float.Parse(txtVolMaximo.Text);
            t.MinLitTanque = float.Parse(txtMinLit.Text);
            t.IdCombustibleTanque = (int)cmbIdCombustible.SelectedValue;
            t.VolDisponibleTanque = float.Parse(txtVolDisponible.Text);

            return t;
        }

        private void grdTanque_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnActualizarTanque.Enabled = true;
            btnBorrarTanque.Enabled = true;
            DataGridViewRow filaSeleccionada = grdTanque.Rows[indice];
            string numTanque = filaSeleccionada.Cells["numTanque"].Value.ToString();
            string cuitEstacion = filaSeleccionada.Cells["cuitEstacion"].Value.ToString();
            Tanque t = ObtenerTanque(numTanque, cuitEstacion);
            LimpiarCampos();
            CargarCampos(t);
        }

        private void CargarCampos(Tanque t)
        {
            txtNumeroTanque.Text = t.NumDeTanque.ToString();
            cmbCuitEstacion.SelectedValue = t.CuitEstacionTanque;
            txtVolMaximo.Text = t.VolMaxCombustible.ToString();
            txtMinLit.Text = t.MinLitTanque.ToString();
            cmbIdCombustible.SelectedValue = t.IdCombustibleTanque;
            txtVolDisponible.Text = t.VolDisponibleTanque.ToString();
        }

        private Tanque ObtenerTanque(string numTanque, string cuitEstacion)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Tanque t = new Tanque();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetTanque";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@numTanque", numTanque);
                cmd.Parameters.AddWithValue("@cuitEstacion", cuitEstacion);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    t.NumDeTanque = int.Parse(dr["numTanque"].ToString());
                    t.CuitEstacionTanque = dr["cuitEstacion"].ToString();
                    t.VolMaxCombustible = float.Parse(dr["volMax"].ToString());
                    t.MinLitTanque = float.Parse(dr["minLit"].ToString());
                    t.IdCombustibleTanque = int.Parse(dr["idCombustible"].ToString());
                    t.VolDisponibleTanque = float.Parse(dr["volDisponible"].ToString());

                }
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }


            return t;
        }

        private void btnActualizarTanque_Click(object sender, EventArgs e)
        {
            Tanque t = ObtenerDatosTanqueAModificar();
            bool resultado = ActualizarTanque(t);
            if (resultado)
            {
                MessageBox.Show("Tanque actualizado con éxito!");
                LimpiarCampos();

                btnActualizarTanque.Enabled = false;
                btnBorrarTanque.Enabled = false;

                CargarComboCuitEstacion();
                CargarComboIdCombustible();
                CargarGrilla();
                cmbCuitEstacion.Focus();
            }
            else
            {
                MessageBox.Show("Error al actualizar tanques...");
            }
        }

        private bool ActualizarTanque(Tanque t)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ActualizarTanque";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@numTanque", t.NumDeTanque);
                cmd.Parameters.AddWithValue("@cuitEstacion", t.CuitEstacionTanque);
                cmd.Parameters.AddWithValue("@volMax", t.VolMaxCombustible);
                cmd.Parameters.AddWithValue("@minLit", t.MinLitTanque);
                cmd.Parameters.AddWithValue("@idCombustible", t.IdCombustibleTanque);
                cmd.Parameters.AddWithValue("@volDisponible", t.VolDisponibleTanque);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }


            return resultado;
        }

        private void btnBorrarTanque_Click(object sender, EventArgs e)
        {
            Tanque t = ObtenerDatosTanqueAModificar();
            bool resultado = BorrarTanque(t);
            if (resultado)
            {
                MessageBox.Show("Tanque borrado con éxito!");
                LimpiarCampos();

                btnActualizarTanque.Enabled = false;
                btnBorrarTanque.Enabled = false;

                CargarComboCuitEstacion();
                CargarComboIdCombustible();
                CargarGrilla();
                cmbCuitEstacion.Focus();
            }
            else
            {
                MessageBox.Show("Error al borrar el tanque...");
            }
        }

        private bool BorrarTanque(Tanque t)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "BorrarTanque";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@numTanque", t.NumDeTanque);
                cmd.Parameters.AddWithValue("@cuitEstacion", t.CuitEstacionTanque);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }

            return resultado;
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
