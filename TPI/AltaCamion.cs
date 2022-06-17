using System;
using TPI.Entidades;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using TPI.AccesoADatos;

namespace TPI
{
    public partial class AltaCamion : Form
    {
        public AltaCamion()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        // AJUSTES DE LOS BOTONES CERRAR Y MINIMIZAR

        private void AltaCamion_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            btnActualizarCamion.Enabled = false;
            btnEliminarCamion.Enabled = false;
            CargarGrilla();
        }

        private void LimpiarCampos()
        {
            txtPatente.Text = "";
            txtIdModelo.Text = "";
            txtCantCombustibleMax.Text = "";

        }

        private void CargarGrilla()
        {
            try
            {
                gdrCamiones.DataSource = AD_Camiones.ObtenerListadoCamiones();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al obtener listado de camiones");
            }

        }
        // CARGA EN LA GRILLA LOS DATOS PRESENTES EN LA BD DE LA TABLA CAMION

        private Camion ObtenerDatosCamion()
        {
            Camion c = new Camion();
            bool hayPatente = true;
            bool hayModelo = true;
            bool hayCantCombustibleMax = true;
            if (txtPatente.Text.Equals(""))
            {
                hayPatente = false;
                MessageBox.Show("Ingrese la Patente");
                txtPatente.Focus();

            }
            else
            {
                hayPatente = true;
                if (txtIdModelo.Text.Equals(""))
                {
                    hayPatente = false;
                    MessageBox.Show("Ingrese el Id del Modelo");
                    txtIdModelo.Focus();

                }
                else
                {
                    hayModelo = true;
                    if (txtCantCombustibleMax.Text.Equals(""))
                    {
                        hayCantCombustibleMax = false;
                        MessageBox.Show("Ingrese la Cantidad de Combustible Máxima");
                        txtCantCombustibleMax.Focus();

                    }
                    else
                    {
                        hayCantCombustibleMax = true;
                    }
                }
            }


            if (hayPatente && hayModelo && hayCantCombustibleMax)
            {
                c.PatenteCamion = txtPatente.Text.Trim();
                c.IdModeloCamion = int.Parse(txtIdModelo.Text);
                c.CantCombustibleMaxCamion = float.Parse(txtCantCombustibleMax.Text);
            }
            return c;

        }
        // OBTIENE LOS DATOS DE LA VENTANA PARA CREAR UN NUEVO OBJETO CAMION

        private void btnGuardarCamion_Click(object sender, EventArgs e)
        {
            bool resul = false;
            Camion c = ObtenerDatosCamion();
            try
            {
                resul = AD_Camiones.ConsultarCamion(txtPatente.Text); //SE VALIDA QUE LA PATENTE A CARGAR NO EXISTA YA PARA OTRO CAMION DEL SISTEMA
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error");
            }
            if (resul)
            {
                MessageBox.Show("Patente No Disponible - Ingrese Otra");
                txtPatente.Focus();
            }
            else
            {
                try
                {
                    bool resultado = AD_Camiones.InsertarCamionABD(c);
                    if (resultado)
                    {
                        MessageBox.Show("Camión Dado de Alta Exitosamente");
                        LimpiarCampos();
                        CargarGrilla();
                        txtPatente.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Error al insertar nuevo Camion");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar nuevo Camion");
                }
            }
            
        }
        // HACE LA LLAMADA PARA CARGAR UN NUEVO OBJETO CAMION EN LA BD. DE SER EXITOSO MUESTRA MSJ, LIMPIA LOS CAMPOS Y ACTUALIZA LA GRILLA


        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            btnGuardarCamion.Enabled = true;
            btnActualizarCamion.Enabled = false;
            btnEliminarCamion.Enabled = false;
            txtPatente.Enabled = true;
        }


        private void gdrCamiones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnActualizarCamion.Enabled = true;
            btnEliminarCamion.Enabled = true;
            btnGuardarCamion.Enabled = false;
            txtPatente.Enabled = false;
            DataGridViewRow filaSeleccionada = gdrCamiones.Rows[indice];
            string patente = filaSeleccionada.Cells["Patente"].Value.ToString();
            try
            {
                Camion c = AD_Camiones.ObtenerCamion(patente);
                LimpiarCampos();
                CargarCampos(c);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al obtener los datos del Camion");
            }

        }
        // AL HACER CLICK EN UNA CELDA DE LA GRILLA, ACTIVA LA OPCION ACTUALIZAR CAMION. OBTIENE LA PATENTE DEL CAMION SELECCIONADO Y LA MANDA COMO PARAMETRO AL METODO OBTENER CAMION(patente).

        private void CargarCampos(Camion c)
        {
            txtPatente.Text = c.PatenteCamion;
            txtIdModelo.Text = c.IdModeloCamion.ToString();
            txtCantCombustibleMax.Text = c.CantCombustibleMaxCamion.ToString();

        }
        // CARGA LOS ATRIBUTOS DEL OBJETO CAMION EN LOS CAMPOS DE LA VENTANA.

        private void btnActualizarCamion_Click(object sender, EventArgs e)
        {
            Camion c = ObtenerDatosCamion();
            try
            {
                bool resultado = AD_Camiones.ActualizarCamionABD(c);
                if (resultado)
                {
                    MessageBox.Show("Camion actualizado con éxito");
                    LimpiarCampos();
                    btnGuardarCamion.Enabled = true;
                    txtPatente.Enabled = true;
                    CargarGrilla();

                }
                else
                {
                    MessageBox.Show("Error al actualizar camion");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar camion");

            }
            // LLAMA AL METODO ACTUALIZARCIUDADABD(C) Y ACTUALIZA LA GRILLA.

        }
        private void btnEliminarCamion_Click(object sender, EventArgs e)
        {
            Camion c = ObtenerDatosCamion();
            try
            {
                bool resultado = AD_Camiones.EliminarCamionABD(c);
                if (resultado)
                {
                    MessageBox.Show("Ciudad eliminado con éxito");
                    LimpiarCampos();
                    btnGuardarCamion.Enabled = true;
                    txtPatente.Enabled = true;
                    btnEliminarCamion.Enabled = false;
                    btnActualizarCamion.Enabled = false;
                    CargarGrilla();

                }
                else
                {
                    MessageBox.Show("Error al eliminado ciudad");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar ciudad");

            }
        }
        // LLAMA AL METODO ELIMINARCIUDADABD() Y ACTUALIZA LA GRILLA.

                
    }
}
        