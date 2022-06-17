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
    public partial class AltaProvincia : Form
    {
        public AltaProvincia()
        {
            InitializeComponent();
        }


        private void AltaProvincia_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarComboPais();
            CargarGrilla();
            btnActualizarProvincia.Enabled = false;
            btnBorrarProvincia.Enabled = false;
        }

        private void LimpiarCampos()
        {
            txtIdProvincia.Text = "";
            txtNombreProvincia.Text = "";
            cmbPais.SelectedIndex = -1;
        }

        private void CargarGrilla()
        {

            try
            {
                grdProvincia.DataSource = AD_Varios.ObtenerListadoProvincia();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener Provincias.");
            }


        }

        private void CargarComboPais()
        {
            try
            {
                cmbPais.DataSource = AD_Varios.ObtenerPaises();
                cmbPais.DisplayMember = "nombre";
                cmbPais.ValueMember = "idPais";
                cmbPais.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el combo Paises");
            }
        }

        private void btnGuardarProvincia_Click(object sender, EventArgs e)
        {
            Provincia p = ObtenerDatosProvincia();

            bool resultado = AD_Varios.AgregarProvinciaABD(p);
            if (resultado)
            {
                MessageBox.Show("Provincia agregada con exito!");
                LimpiarCampos();
                CargarGrilla();

            }
            else
            {
                MessageBox.Show("Error al agregar la Provincia.");
            }
        }

        private Provincia ObtenerDatosProvincia()
        {
            Provincia p = new Provincia();
            bool hayProvincia = true;
            bool hayPais = true;

            if (txtNombreProvincia.Text.Equals(""))
            {
                MessageBox.Show("Ingrese Nombre Provincia!");
                txtNombreProvincia.Focus();
                hayProvincia = false;
            }
            else
            {
                if (cmbPais.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un Pais!");
                    hayPais = false;
                }
            }

            if (hayPais && hayProvincia)
            {
                p.IdDeLaProvincia = txtIdProvincia.Text.Trim();
                p.NombreDeLaProvincia = txtNombreProvincia.Text.Trim();
                p.IdDelPais = cmbPais.SelectedValue.ToString();
            }

            
            return p;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizarProvincia_Click(object sender, EventArgs e)
        {
            Provincia p = ObtenerDatosProvincia();
            try
            {
                bool resultado = AD_Varios.ActualizarProvinciaABD(p);
                if (resultado)
                {
                    MessageBox.Show("Provincia actualizada con éxito");
                    LimpiarCampos();
                    btnGuardarProvincia.Enabled = true;
                    labelIdDeLaProvincia.Visible = false;
                    txtIdProvincia.Visible = false;
                    btnActualizarProvincia.Enabled = false;
                    btnBorrarProvincia.Enabled = false;
                    CargarGrilla();

                }
                else
                {
                    MessageBox.Show("Error al actualizar Provincia");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar Provincia");

            }
        }

        private void CargarCampos(Provincia p)
        {   
            
            txtIdProvincia.Text = p.IdDeLaProvincia.ToString();
            txtNombreProvincia.Text = p.NombreDeLaProvincia;
            cmbPais.SelectedValue = p.IdDelPais;
        }


        private void btnBorrarProvincia_Click(object sender, EventArgs e)
        {
            Provincia p = ObtenerDatosProvincia();
            try
            {
                bool resultado = AD_Varios.EliminarProvinciaABD(p);
                if (resultado)
                {
                    MessageBox.Show("Provincia eliminada con éxito");
                    LimpiarCampos();
                    btnGuardarProvincia.Enabled = true;
                    btnBorrarProvincia.Enabled = false;
                    btnActualizarProvincia.Enabled = false;
                    CargarGrilla();

                }
                else
                {
                    MessageBox.Show("Error al eliminar Provincia");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar Provincia");

            }
        }

        private void btnLimpiarDatos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void grdProvincia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            labelIdDeLaProvincia.Visible = true;
            txtIdProvincia.Visible = true;
            btnActualizarProvincia.Enabled = true;
            btnBorrarProvincia.Enabled = true;
            btnGuardarProvincia.Enabled = false;
            DataGridViewRow filaSeleccionada = grdProvincia.Rows[indice];
            int idProvincia = int.Parse(filaSeleccionada.Cells["IdProvincia"].Value.ToString());
            try
            {
                Provincia p = AD_Varios.ObtenerProvincia(idProvincia);
                LimpiarCampos();
                CargarCampos(p);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al obtener los datos de la Provincia");
            }
        }
    }
}
