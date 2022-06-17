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
    public partial class AltaModelo : Form
    {
        public AltaModelo()
        {
            InitializeComponent();
        }

        private void LimpiarCampos()
        {
            txtModelo.Text = "";
        }

        private void AltaModelo_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarComboMarca();
            CargarGrilla();

        }

        private void CargarComboMarca()
        {
            cmbMarca.DataSource = AD_Camion.ObtenerMarca();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Modelo mod = ObtenerDatosModelo();

            bool resultado = AD_Camion.AgregarModeloABD(mod);
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

        private Modelo ObtenerDatosModelo()
        {
            Modelo mod = new Modelo();

            mod.NombreDelModelo = txtModelo.Text.Trim();
            mod.IdDeMarca = (int)cmbMarca.SelectedValue;

            return mod;
        }
    }
}
