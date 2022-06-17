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

namespace TPI.Formularios
{
    public partial class Remitos : Form
    {
        public Remitos()
        {
            InitializeComponent();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerarRemito_Click(object sender, EventArgs e)
        {
            NuevoRemito ventana = new NuevoRemito();
            ventana.ShowDialog();
        }

        private void Remitos_Load(object sender, EventArgs e)
        {
           CargarGrilla();
        }

        private void CargarGrilla()
        {
            try
            {
                grdRemitosExistentes.DataSource = AD_Remitos.ObtenerListadoRemitos();
            }
            catch (Exception)
            {

                MessageBox.Show("Error al obtener las estaciones");
            }

        }

        private void grdRemitosExistentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDetalle.Enabled = true;
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = grdRemitosExistentes.Rows[indice];
            string numRemito = (filaSeleccionada.Cells["numRemito"].Value.ToString());
            string cuitEstacion = (filaSeleccionada.Cells["cuitEstacion"].Value.ToString());
            txtNumRemito.Text = numRemito;
            txtCuitEstacion.Text = cuitEstacion;
            

            
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            DetalleRemito ventana = new DetalleRemito(txtNumRemito.Text, txtCuitEstacion.Text);
            ventana.ShowDialog();         
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        //private void ObtenerDatos()
        //{
        //    int indice = e.RowIndex;
        //    DataGridViewRow filaSeleccionada = grdRemitosExistentes.Rows[indice];
        //    int numRemito = int.Parse(filaSeleccionada.Cells["numRemito"].Value.ToString());
        //    int cuitEstacion = int.Parse(filaSeleccionada.Cells["cuitEstacion"].Value.ToString());
        //}
    }
}
