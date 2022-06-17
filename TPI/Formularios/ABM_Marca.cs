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

namespace TPI.Formularios
{
    public partial class ABM_Marca : Form
    {
        public ABM_Marca()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ABM_Marca_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarGrilla();

        }

        private void LimpiarCampos()
        {         
                txtId.Text = "";
                txtMarca.Text = "";                           
        }

        private void CargarGrilla()
        {

            try
            {
                grdMarca.DataSource = AD_Camion.ObtenerMarca();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener Marcas de Camion.");
            }
        }

        private void CargarGrillatxt(string valor)
        {

            try
            {
                grdMarca.DataSource = AD_Camion.ObtenerListadoMarcatxt(valor);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener Marcas de Camion.");
            }


        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtMarca.Text.Equals(""))
            {
                CargarGrilla();
                return;
            }
            if (txtMarca.Text != (""))
            {
                string valor = txtMarca.Text;
                CargarGrillatxt(valor);
                return;
            }
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Marca mar = ObtenerDatosMarca();
            bool resultado = false;
            
            try
            {
                resultado = AD_Camion.AgregarMarcaABD(mar);
                if (resultado)
                {
                    MessageBox.Show("Marca Agregada con exito!");
                    LimpiarCampos();
                    CargarGrilla();
                    btnActualizar.Enabled = false;
                    btnEliminar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Error al agregar la Marca.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al agregar la Marca");
            }
        }

        private Marca ObtenerDatosMarca()
        {
            Marca mar = new Marca();
            bool hayMarca = true;

            if (txtMarca.Text.Equals(""))
            {
                hayMarca = false;
                MessageBox.Show("Ingrese la marca");
                txtMarca.Focus();
            }
            
            if (hayMarca)
            {
                mar.NombreDeMarca = txtMarca.Text.Trim();
            }         
            
            return mar;
        }

        private void grdMarca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = grdMarca.Rows[indice];
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            string id = filaSeleccionada.Cells["idMarca"].Value.ToString();
            Marca mar = new Marca();
            try
            {
                mar = AD_Camion.ObtenerMarca(id);
            }
            catch (Exception)
            {

                MessageBox.Show("Error al obtener Marca");
            }                      

            LimpiarCampos();
            CargarCampos(mar);
        }

        private void CargarCampos(Marca mar)
        {
            txtId.Text = mar.IdDeMarca.ToString();
            txtMarca.Text = mar.NombreDeMarca;
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int idMar = int.Parse(txtId.Text);
            Marca mar = ObtenerDatosMarca(idMar);
            bool resultado = false;
            try
            {
                resultado = AD_Camion.ActualizarMarca(mar);
                if (resultado)
                {
                    MessageBox.Show("Marca Actualizado Correctamente!");
                    LimpiarCampos();
                    btnActualizar.Enabled = false;
                    btnEliminar.Enabled = false;
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("Error al actualizar Marca.");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error al actualizar la Marca");
            }
           
        }

        private Marca ObtenerDatosMarca(int id)
        {
            Marca mar = new Marca();
            mar.IdDeMarca = id;
            mar.NombreDeMarca = txtMarca.Text.Trim();

            return mar;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idMod = int.Parse(txtId.Text);
            Marca mar = ObtenerDatosMarca(idMod);
            try
            {
                bool resultado = AD_Camion.EliminarMarcaABD(mar);
                if (resultado)
                {
                    MessageBox.Show("Marca eliminada con éxito");
                    LimpiarCampos();
                    CargarGrilla();
                    btnActualizar.Enabled = false;
                    btnEliminar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Error al eliminar Marca");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al eliminar Marca");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }
    }
}
