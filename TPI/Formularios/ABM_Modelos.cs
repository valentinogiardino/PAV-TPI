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
    public partial class ABM_Modelo : Form
    {
        public ABM_Modelo()
        {
            InitializeComponent();
        }

        private void LimpiarCampos()
        {
            txtId.Text = "";
            txtModelo.Text = "";
            cmbMarca.SelectedIndex = -1;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AltaModelo_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarComboMarca();
            CargarGrilla();

        }

        private void CargarComboMarca()
        {
            try
            {
                cmbMarca.DataSource = AD_Camion.ObtenerMarca();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las Marcas");
                
            }
            
            cmbMarca.DisplayMember = "nombreMarca";
            cmbMarca.ValueMember = "idMarca";
            cmbMarca.SelectedIndex = -1;
        }

        private void CargarGrilla()
        {

            try
            {
                grdModelo.DataSource = AD_Camion.ObtenerListadoModelo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener Modelos de Camion.");
            }


        }

        private void CargarGrillacmb(int valor)
        {

            try
            {
                grdModelo.DataSource = AD_Camion.ObtenerListadoModelocmb(valor);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener Modelos de Camion.");
            }


        }

        private void CargarGrillatxt(string valor)
        {

            try
            {
                grdModelo.DataSource = AD_Camion.ObtenerListadoModelotxt(valor);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener Modelos de Camion.");
            }


        }
        private void CargarGrillaMixto(int nro, string valor)
        {

            try
            {
                grdModelo.DataSource = AD_Camion.ObtenerListadoModeloMixto(nro, valor);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener Modelos de Camion.");
            }


        }

        private Modelo ObtenerDatosModelo()
        {
            
            Modelo mod = new Modelo();
            bool hayMarca = true;
            bool hayModelo = true;

            if (txtModelo.Text.Equals(""))
            {
                hayModelo = false;
                txtModelo.Focus();
                MessageBox.Show("Ingrese el modelo!");
            }
            else
            {
                if (cmbMarca.SelectedIndex == -1)
                {
                    hayMarca = false;
                    MessageBox.Show("Seleccione una Marca");
                }
            }
                

            if (hayMarca && hayModelo)
            {
                mod.NombreDelModelo = txtModelo.Text.Trim();
                mod.IdDeMarca = (int)cmbMarca.SelectedValue;
            }
            
            

            return mod;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            {
                Modelo mod = ObtenerDatosModelo();
                bool resultado = false;
                try
                {
                   resultado = AD_Camion.AgregarModeloABD(mod);
                    if (resultado)
                    {
                        MessageBox.Show("Modelo Agregado con exito!");
                        LimpiarCampos();
                        CargarComboMarca();
                        CargarGrilla();

                    }
                    else
                    {
                        MessageBox.Show("Error al agregar el Modelo.");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al agregar el modelo a la BD");
                }
                
                
                
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtModelo.Text.Equals("") && cmbMarca.SelectedIndex == -1)
            {
                CargarGrilla();
                return;
            }
            if (txtModelo.Text.Equals("") && cmbMarca.SelectedIndex != -1)
            {
                int valor = (int)cmbMarca.SelectedValue;
                CargarGrillacmb(valor);
                return;
            }
            if (txtModelo.Text != ("") && cmbMarca.SelectedIndex == -1)
            {
                string valor = txtModelo.Text;
                CargarGrillatxt(valor);
                return;
            }
            if (txtModelo.Text != ("") && cmbMarca.SelectedIndex != -1)
            {
                int nro = (int)cmbMarca.SelectedValue;
                string valor = txtModelo.Text;
                CargarGrillaMixto(nro, valor);
            }

        }

        private void grdModelo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = grdModelo.Rows[indice];
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            string modelo = filaSeleccionada.Cells["nombreModelo"].Value.ToString();
            string id = filaSeleccionada.Cells["idMarca"].Value.ToString();
            Modelo mod = new Modelo();
            try
            {
                mod = AD_Camion.ObtenerModelo(modelo, id);
            }
            catch (Exception)
            {

                MessageBox.Show("Error al recuperar el modelo de la BD");
            }
            
            LimpiarCampos();
            CargarCampos(mod);

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int idMod = int.Parse(txtId.Text);
            Modelo mod = ObtenerDatosModelo(idMod);
            bool resultado = false;
            try
            {
                resultado = AD_Camion.ActualizarModelo(mod);
                if (resultado)
                {
                    MessageBox.Show("Modelo Actualizado Correctamente!");
                    LimpiarCampos();
                    CargarComboMarca();
                    CargarGrilla();
                    btnActualizar.Enabled = false;
                    btnEliminar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Error al actualizar Modelo.");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error al actualizar el Modelo");
            }           
        }

        private void CargarCampos(Modelo mod)
        {
            txtId.Text = mod.IdDeModelo.ToString();
            txtModelo.Text = mod.NombreDelModelo;                     
            cmbMarca.SelectedValue = mod.IdDeMarca;
        }

        private Modelo ObtenerDatosModelo(int id)
        {
            Modelo mod = new Modelo();
            mod.IdDeModelo = id;
            mod.NombreDelModelo = txtModelo.Text.Trim();
            mod.IdDeMarca = (int)cmbMarca.SelectedValue;

            return mod;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idMod = int.Parse(txtId.Text);
            Modelo mod = ObtenerDatosModelo(idMod);
            try
            {
                bool resultado = AD_Camion.EliminarModeloABD(mod);
                if (resultado)
                {
                    MessageBox.Show("Modelo eliminado con éxito");
                    LimpiarCampos();                   
                    CargarGrilla();
                    btnActualizar.Enabled = false;
                    btnEliminar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Error al eliminar modelo");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al eliminar modelo");
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
