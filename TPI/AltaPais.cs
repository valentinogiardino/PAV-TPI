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
    public partial class AltaPais : Form
    {
        public AltaPais()
        {
            InitializeComponent();

        }

        private void buttonGuardarPais_Click(object sender, EventArgs e)
        {
            Pais p = ObtenerDatosPais();

            bool resultado = AD_Varios.AgregarPaisABD(p);
            if (resultado)
            {
                MessageBox.Show("País agregado con exito!");
                LimpiarCampos();
                CargarGrilla();

            }
            else
            {
                MessageBox.Show("Error al agregar el País.");
            }
        }

        private void btnLimpiarDatos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtIdDelPais.Text = "";
            txtNombrePais.Text = "";
        }

        private Pais ObtenerDatosPais()
        {
            Pais p = new Pais();
            p.NombreDelPais = txtNombrePais.Text.Trim();
            p.IdDelPais = txtIdDelPais.Text.Trim();
            return p;
        }

        private void CargarGrilla()
        {

            try
            {
                grdPais.DataSource = AD_Varios.ObtenerListadoPais();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener Paises.");
            }


        }

        private void AltaPais_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarGrilla();
            btnActualizarPais.Enabled = false;
            btnBorrarPais.Enabled = false;
        }


        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonActualizarPaís_Click(object sender, EventArgs e)
        {
            Pais p = ObtenerDatosPais();
            try
            {
                bool resultado = AD_Varios.ActualizarPaisABD(p);
                if (resultado)
                {
                    MessageBox.Show("Pais actualizado con éxito");
                    LimpiarCampos();
                    btnGuardarPais.Enabled = true;
                    btnActualizarPais.Enabled = false;
                    btnBorrarPais.Enabled = false;
                    labelIdDelPais.Visible = false;
                    txtIdDelPais.Visible = false;
                    CargarGrilla();

                }
                else
                {
                    MessageBox.Show("Error al actualizar Pais");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar Pais");

            }
        }


        private void CargarCampos(Pais p)
        {
            txtIdDelPais.Text = p.IdDelPais.ToString();
            txtNombrePais.Text = p.NombreDelPais;
        }

        private void grdPais_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            labelIdDelPais.Visible = true;
            txtIdDelPais.Visible = true;
            btnActualizarPais.Enabled = true;
            btnBorrarPais.Enabled = true;
            btnGuardarPais.Enabled = false;
            DataGridViewRow filaSeleccionada = grdPais.Rows[indice];
            int idPais = int.Parse(filaSeleccionada.Cells["IdPais"].Value.ToString());
            try
            {
                Pais p = AD_Varios.ObtenerPais(idPais);
                LimpiarCampos();
                CargarCampos(p);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al obtener los datos del País");
            }
        }

        private void btnBorrarPais_Click(object sender, EventArgs e)
        {
            Pais p = ObtenerDatosPais();
            try
            {
                bool resultado = AD_Varios.EliminarPaisABD(p);
                if (resultado)
                {
                    MessageBox.Show("País eliminado con éxito");
                    LimpiarCampos();
                    btnGuardarPais.Enabled = true;
                    btnBorrarPais.Enabled = false;
                    btnActualizarPais.Enabled = false;
                    CargarGrilla();

                }
                else
                {
                    MessageBox.Show("Error al eliminar País");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar País");

            }
        }
    }
}
