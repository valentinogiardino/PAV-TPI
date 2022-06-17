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
    public partial class AltaCiudad : Form
    {
        public AltaCiudad()
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
        // AJUSTES DE LOS BOTONES CERRAR Y MINIMIZAR

        private void AltaCiudad_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            btnActualizarCiudad.Enabled = false;
            btnEliminarCiudad.Enabled = false;
            CargarGrilla();
        }

        private void LimpiarCampos()
        {
            txtIdCiudad.Text = "";
            txtNombreCiudad.Text = "";
            txtIdProvincia.Text = "";
            txtNombreCiudad.Focus();
            
        }
        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            btnActualizarCiudad.Enabled = false;
            btnEliminarCiudad.Enabled = false;
            btnGuardarCiudad.Enabled = true;
        }
        private void CargarGrilla()
        {
            try
            {
                gdrCiudades.DataSource = AD_Ciudades.ObtenerListadoCiudades();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al obtener listado de ciudaddes");
            }

        }
        // CARGA EN LA GRILLA LOS DATOS PRESENTES EN LA BD DE LA TABLA CIUDAD

        private Ciudad ObtenerDatosCiudad()
        {
            Ciudad c = new Ciudad();
            bool hayNombre = true;
            bool hayIdProvincia = true;
            
            if (txtNombreCiudad.Text.Equals(""))
            {
                hayNombre = false;
                MessageBox.Show("Ingrese el nombre de la ciudad");
                txtNombreCiudad.Focus();

            }
            else
            {
                hayNombre = true;
                if (txtIdProvincia.Text.Equals(""))
                {
                    hayIdProvincia = false;
                    MessageBox.Show("Ingrese el Id de la provincia");
                    txtIdProvincia.Focus();

                }
                else
                {
                    hayIdProvincia = true;
                }
            }


            if (hayIdProvincia && hayNombre)
            {
                if (txtIdCiudad.Text.Equals(""))
                {
                    c.NombreCiudad = txtNombreCiudad.Text.Trim();
                    c.IdProvinciaCiudad = int.Parse(txtIdProvincia.Text);
                }
                else
                {
                    c.IdCiudad = int.Parse(txtIdCiudad.Text);
                    c.NombreCiudad = txtNombreCiudad.Text.Trim();
                    c.IdProvinciaCiudad = int.Parse(txtIdProvincia.Text);
                }
                
                
            }
            return c;


        }
        // OBTIENE LOS DATOS DE LA VENTANA PARA CREAR UN NUEVO OBJETO CIUDAD

        private void btnGuardarCiudad_Click(object sender, EventArgs e)
        {
            bool resul = false;
            Ciudad c = ObtenerDatosCiudad();
            try
            {
                resul = AD_Ciudades.ConsultarCiudad(c); //SE VALIDA QUE NO HAYA UNA CIUDAD CARGADA CON EL MISMO NOMBRE PARA ESA PROVINCIA
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error");
            }
            if (resul)
            {
                MessageBox.Show("La ciudad ya se encontraba cargada en el sistema");
                txtNombreCiudad.Focus();
            }
            else
            {
                try
                {
                    bool resultado = AD_Ciudades.InsertarCiudadABD(c);
                    if (resultado)
                    {
                        MessageBox.Show("Ciudad Dada de Alta Exitosamente");
                        LimpiarCampos();
                        CargarGrilla();
                        txtNombreCiudad.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Error al insertar nueva Ciudad");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar nueva Ciudad");

                }
            }
            
        }
        // HACE LA LLAMADA PARA CARGAR UN NUEVO OBJETO CIUDAD EN LA BD. DE SER EXITOSO MUESTRA MSJ, LIMPIA LOS CAMPOS Y ACTUALIZA LA GRILLA


        private void gdrCiudades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnActualizarCiudad.Enabled = true;
            btnEliminarCiudad.Enabled = true;
            btnGuardarCiudad.Enabled = false;
            DataGridViewRow filaSeleccionada = gdrCiudades.Rows[indice];
            int idCiudad = int.Parse(filaSeleccionada.Cells["IdCiudad"].Value.ToString());
            try
            {
                Ciudad c = AD_Ciudades.ObtenerCiudad(idCiudad);
                LimpiarCampos();
                CargarCampos(c);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al obtener los datos de la Ciudad");
            }
        }
       
        // AL HACER CLICK EN UNA CELDA DE LA GRILLA, ACTIVA LA OPCION ACTUALIZAR CIUDAD. OBTIENE LA ID DE LA CIUDAD SELECCIONADA Y LA MANDA COMO PARAMETRO AL METODO OBTENER CIUDAD(idCiudad).


        private void CargarCampos(Ciudad c)
        {
            txtIdCiudad.Text = c.IdCiudad.ToString();
            txtNombreCiudad.Text = c.NombreCiudad;
            txtIdProvincia.Text = c.IdProvinciaCiudad.ToString();
        }
        // CARGA LOS ATRIBUTOS DEL OBJETO CIUDAD EN LOS CAMPOS DE LA VENTANA.

        private void btnActualizarCiudad_Click(object sender, EventArgs e)
        {
            Ciudad c = ObtenerDatosCiudad();
            try
            {
                bool resultado = AD_Ciudades.ActualizarCiudadABD(c);
                if (resultado)
                {
                    MessageBox.Show("Ciudad actualizada con éxito");
                    LimpiarCampos();
                    btnGuardarCiudad.Enabled = true;
                    CargarGrilla();

                }
                else
                {
                    MessageBox.Show("Error al actualizar ciudad");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar ciudad");

            }
            // LLAMA AL METODO ACTUALIZARCIUDADABD(C) Y ACTUALIZA LA GRILLA.
        }

        private void btnEliminarCiudad_Click(object sender, EventArgs e)
        {
            Ciudad c = ObtenerDatosCiudad();
            try
            {
                bool resultado = AD_Ciudades.EliminarCiudadABD(c);
                if (resultado)
                {
                    MessageBox.Show("Ciudad eliminada con éxito");
                    LimpiarCampos();
                    btnGuardarCiudad.Enabled = true;
                    btnEliminarCiudad.Enabled = false;
                    btnActualizarCiudad.Enabled = false;
                    CargarGrilla();

                }
                else
                {
                    MessageBox.Show("Error al eliminar ciudad");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar ciudad");

            }
        }
        // LLAMA AL METODO ELIMINARCAMIONABD() Y ACTUALIZA LA GRILLA.
    }


   



}

