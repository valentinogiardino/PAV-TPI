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
    public partial class AltaTipoDoc : Form
    {

        public AltaTipoDoc()
        {
            InitializeComponent();
        }

        private void TipoDoc_Load(object sender, EventArgs e)
        {
            
            CargarGrillaTipoDoc();
            btnActualizar.Enabled = false;
            btnBorrar.Enabled = false;
            LimpiarCampos();
        }

        private void CargarGrillaTipoDoc()
        {
            try
            {
                grillaTipoDoc.DataSource = AD_TipoDoc.ObtenerListadoTipoDoc();
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudieron cargar tipos de documentos correctamente");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtAgregarTipoDoc.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del tipo de documento");
            }
            else
            {
                try
                {
                    string nombre = txtAgregarTipoDoc.Text;
                    bool resultado = AD_TipoDoc.InsertarTipoDoc(nombre);
                    if (resultado)
                    {
                        MessageBox.Show("Tipo de documento dado de alta con exito");
                        LimpiarCampos();
                        CargarGrillaTipoDoc();
                        txtAgregarTipoDoc.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Error al insertar nuevo tipo de documento");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al insertar nuevo tipo de documento");
                    txtAgregarTipoDoc.Focus();
                }
            }
        }

        private void LimpiarCampos() 
        {
            txtAgregarTipoDoc.Text = "";
            txtIdTipoDoc.Text = "";
        }

        private void grillaTipoDoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnActualizar.Enabled = true;
            btnBorrar.Enabled = true;
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = grillaTipoDoc.Rows[indice];

            string id = filaSeleccionada.Cells["tipoDoc"].Value.ToString();

            TipoDoc td = AD_TipoDoc.ObtenerTipoDocABD(id);
            LimpiarCampos();
            CargarCampos(td);
        }

        private void CargarCampos(TipoDoc td) 
        {
            txtAgregarTipoDoc.Text = td.NombreTipoDeDoc;
            txtIdTipoDoc.Text = td.IdTipoDeDoc.ToString();
        }

        

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtAgregarTipoDoc.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del tipo de documento");
            }
            else
            {
                TipoDoc td = new TipoDoc();
                td.IdTipoDeDoc = int.Parse(txtIdTipoDoc.Text.Trim());
                td.NombreTipoDeDoc = txtAgregarTipoDoc.Text.Trim();
                bool resultado = AD_TipoDoc.ActualizarTipoDoc(td);
                if (resultado)
                {
                    MessageBox.Show("Tipo de documento actualizada con exito");
                    LimpiarCampos();
                    CargarGrillaTipoDoc();
                }
                else
                {
                    MessageBox.Show("Error al actualizar tipo de documento");
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("¿Esta seguro que quiere borrar el tipo de documento?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

                TipoDoc td = new TipoDoc();
                td.IdTipoDeDoc = int.Parse(txtIdTipoDoc.Text.Trim());
                td.NombreTipoDeDoc = txtAgregarTipoDoc.Text.Trim();
                bool resultado = AD_TipoDoc.BorrarTipoDoc(td);
                if (resultado)
                {
                    MessageBox.Show("Tipo de documento borrado con exito");
                    LimpiarCampos();
                    CargarGrillaTipoDoc();
                }
                else
                {
                    MessageBox.Show("Error al borrar tipo de documento");
                }
               
            }
            else
            {
                LimpiarCampos();
            }


            
        }
    }
}