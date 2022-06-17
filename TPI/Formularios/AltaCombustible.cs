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
    public partial class AltaCombustible : Form
    {
        public AltaCombustible()
        {
            InitializeComponent();
        }

        private void LimpiarCampos()
        {
            txtIdCombustible.Text = "";
            txtNombreCombustible.Text = "";
            cmbTipoDeCombustible.SelectedIndex = -1;
            txtPrecioUnitario.Text = "";
            txtNombreCombustible.Focus();
        }

        private void AltaCombustible_Load(object sender, EventArgs e)
        {
            LimpiarCampos();

            btnActualizarCombustible.Enabled = false;
            btnBorrarCombustible.Enabled = false;

            CargarComboTiposDeCombustible();
            CargarGrilla();

        }

        private void CargarComboTiposDeCombustible()
        {
            cmbTipoDeCombustible.DataSource = AD_Combustible.ObtenerTipoCombustible();
            cmbTipoDeCombustible.DisplayMember = "nombre";
            cmbTipoDeCombustible.ValueMember = "codTipoCombustible";
            cmbTipoDeCombustible.SelectedIndex = -1;
        }

        private void CargarGrilla()
        {

            try
            {
                GrdCombustible.DataSource = AD_Combustible.ObtenerListadoCombustibles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener Combustibles.");
            }


        }

        private void btnGuardarCombustible_Click(object sender, EventArgs e)
        {
            bool datos = DatosCargados();
            if (datos)
            {
                Combustible com = ObtenerDatosCombustibleAGuardar();

                bool resultado = AD_Combustible.AgregarCombustibleABD(com);
                if (resultado)
                {
                    MessageBox.Show("Combustible Agregado con exito!");
                    LimpiarCampos();

                    btnActualizarCombustible.Enabled = false;
                    btnBorrarCombustible.Enabled = false;

                    CargarComboTiposDeCombustible();
                    CargarGrilla();
                    txtNombreCombustible.Focus();
                }
                else
                {
                    MessageBox.Show("Error al agregar el Combustible...");
                }
            }
            else
            {
                MessageBox.Show("Verifique que los campos estén cargados e intente nuevamente...");
            }

        }

        private Combustible ObtenerDatosCombustibleAGuardar()
        {
            Combustible com = new Combustible();

            com.CodTipoDeCombustible = (int)cmbTipoDeCombustible.SelectedValue;
            com.NombreDeCombustible = txtNombreCombustible.Text.Trim();
            com.PrecioUnitarioDeCombustible = float.Parse(txtPrecioUnitario.Text);

            return com;
        }

        private void btnLimpiarDatos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            btnActualizarCombustible.Enabled = false;
            btnBorrarCombustible.Enabled = false;
        }

        private void GrdCombustible_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnActualizarCombustible.Enabled = true;
            btnBorrarCombustible.Enabled = true;
            DataGridViewRow filaSeleccionada = GrdCombustible.Rows[indice];
            string idCombustible = filaSeleccionada.Cells["IdCombustible"].Value.ToString();
            Combustible com = ObtenerCombustible(idCombustible);
            LimpiarCampos();
            CargarCampos(com);
        }

        private void CargarCampos(Combustible com)
        {
            txtIdCombustible.Text = com.IdDeCombustible.ToString();
            cmbTipoDeCombustible.SelectedValue = com.CodTipoDeCombustible;
            txtNombreCombustible.Text = com.NombreDeCombustible;
            txtPrecioUnitario.Text = com.PrecioUnitarioDeCombustible.ToString();
        }

        private Combustible ObtenerCombustible(string idCombustible)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Combustible com = new Combustible();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetCombustibleIdCombustible";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idCombustible", idCombustible);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    com.IdDeCombustible = int.Parse(dr["idCombustible"].ToString());
                    com.CodTipoDeCombustible = int.Parse(dr["codTipoCombustible"].ToString());
                    com.NombreDeCombustible = dr["nombre"].ToString();
                    com.PrecioUnitarioDeCombustible = float.Parse(dr["PrecioUnitario"].ToString());

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


            return com;
        }

        private void btnActualizarCombustible_Click(object sender, EventArgs e)
        { 
            Combustible com = ObtenerDatosCombustibleAModificar();
            bool resultado = ActualizarCombustible(com);
            if (resultado)
            {
                MessageBox.Show("Combustible actualizado con éxito!");
                LimpiarCampos();

                btnActualizarCombustible.Enabled = false;
                btnBorrarCombustible.Enabled = false;

                CargarGrilla();
                CargarComboTiposDeCombustible();
                txtNombreCombustible.Focus();
            }
            else
            {
                MessageBox.Show("Error al actualizar combustibles...");
            }
        }

        private Combustible ObtenerDatosCombustibleAModificar()
        {
            Combustible com = new Combustible();

            com.IdDeCombustible = int.Parse(txtIdCombustible.Text);
            com.CodTipoDeCombustible = (int)cmbTipoDeCombustible.SelectedValue;
            com.NombreDeCombustible = txtNombreCombustible.Text.Trim();
            com.PrecioUnitarioDeCombustible = float.Parse(txtPrecioUnitario.Text);

            return com;
        }

        private bool ActualizarCombustible(Combustible com)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ActualizarCombustible";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idCombustible", com.IdDeCombustible);
                cmd.Parameters.AddWithValue("@codTipoComb", com.CodTipoDeCombustible);
                cmd.Parameters.AddWithValue("@nombre", com.NombreDeCombustible);
                cmd.Parameters.AddWithValue("@precioUni", com.PrecioUnitarioDeCombustible);
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

        private void btnBorrarCombustible_Click(object sender, EventArgs e)
        {
            Combustible com = ObtenerDatosCombustibleAModificar();
            bool resultado = BorrarCombustible(com);
            if (resultado)
            {
                MessageBox.Show("Combustible borrado con éxito!");
                LimpiarCampos();

                btnActualizarCombustible.Enabled = false;
                btnBorrarCombustible.Enabled = false;

                CargarGrilla();
                CargarComboTiposDeCombustible();
                txtNombreCombustible.Focus();
            }
            else
            {
                MessageBox.Show("Error al borrar el combustible");

            }
        }

        private bool BorrarCombustible(Combustible com)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "BorrarCombustible";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idCombustible", com.IdDeCombustible);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("El Combustible seleccionado tiene uno o más tanques asociados, por favor elimine los tanques e intente nuevamente...");
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

        private bool DatosCargados()
        {
            bool DatosCargados = false;
            if ((txtNombreCombustible.Text == "") || (cmbTipoDeCombustible.SelectedIndex == -1) || (txtPrecioUnitario.Text == ""))
            {
                return DatosCargados;
            }
            else
            {
                DatosCargados = true;
                return DatosCargados;
            }
        }
    }
}
