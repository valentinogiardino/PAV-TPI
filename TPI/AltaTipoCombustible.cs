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
    public partial class AltaTipoCombustible : Form
    {
        public AltaTipoCombustible()
        {
            InitializeComponent();
        }

        private void AltaTipoCombustible_Load(object sender, EventArgs e)
        {
            CargarGrillaTipoCombustible();
            btnActualizar.Enabled = false;
            btnBorrar.Enabled = false;
            LimpiarCampos();
        }

        private void CargarGrillaTipoCombustible()
        {
            try
            {
                grillaTipoCombustible.DataSource = AD_TipoCombustible.ObtenerListadoTipoCombustible();
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudieron cargar tipos de documentos correctamente");
            }
        }

        private void LimpiarCampos()
        {
            txtAgregarTipoCombustible.Text = "";
            txtIdTipoCombustible.Text = "";
        }

        private void grillaTipoCombustible_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnActualizar.Enabled = true;
            btnBorrar.Enabled = true;
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = grillaTipoCombustible.Rows[indice];

            string id = filaSeleccionada.Cells["codTipoCombustible"].Value.ToString();

            TipoCombustible tc = AD_TipoCombustible.ObtenerTipoCombustibleABD(id);
            LimpiarCampos();
            CargarCampos(tc);
        }

        private void CargarCampos(TipoCombustible tc)
        {
            txtAgregarTipoCombustible.Text = tc.NombreTipoDeCombustible;
            txtIdTipoCombustible.Text = tc.IdTipoDeCombustible.ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtAgregarTipoCombustible.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del tipo de combustible");
            }
            else
            {
                TipoCombustible tc = new TipoCombustible();
                tc.IdTipoDeCombustible = int.Parse(txtIdTipoCombustible.Text.Trim());
                tc.NombreTipoDeCombustible = txtAgregarTipoCombustible.Text.Trim();
                bool resultado = AD_TipoCombustible.ActualizarTipoCombustible(tc);
                if (resultado)
                {
                    MessageBox.Show("Tipo de combustible actualizada con exito");
                    LimpiarCampos();
                    CargarGrillaTipoCombustible();
                }
                else
                {
                    MessageBox.Show("Error al actualizar tipo de combustible");
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("¿Esta seguro que quiere borrar el tipo de combustible?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

                TipoCombustible tc = new TipoCombustible();
                tc.IdTipoDeCombustible = int.Parse(txtIdTipoCombustible.Text.Trim());
                tc.NombreTipoDeCombustible = txtAgregarTipoCombustible.Text.Trim();
                bool resultado = AD_TipoCombustible.BorrarTipoCombustible(tc);
                if (resultado)
                {
                    MessageBox.Show("Tipo de combustible borrado con exito");
                    LimpiarCampos();
                    CargarGrillaTipoCombustible();
                }
                else
                {
                    MessageBox.Show("Error al borrar tipo de combustible");
                }
            }
            else
            {
                LimpiarCampos();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtAgregarTipoCombustible.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del tipo de combustible");
            }
            else
            {
                try
                {
                    string nombre = txtAgregarTipoCombustible.Text;
                    bool resultado = AD_TipoCombustible.InsertarTipoCombustible(nombre);
                    if (resultado)
                    {
                        MessageBox.Show("Tipo de combustible dado de alta con exito");
                        LimpiarCampos();
                        CargarGrillaTipoCombustible();
                        txtAgregarTipoCombustible.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Error al insertar nuevo tipo de combustible");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al insertar nuevo tipo de combustible");
                    txtAgregarTipoCombustible.Focus();
                }
            }
        }
    }
    
}
