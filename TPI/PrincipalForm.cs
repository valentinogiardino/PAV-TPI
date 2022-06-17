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
using TPI.Formularios;

namespace TPI
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm(Empleado emp)
        {
            
            InitializeComponent();           
            
        }

        private void estacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void altaModeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_Modelo ventana = new ABM_Modelo();
            ventana.ShowDialog();           
        }

        private void altaMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_Marca ventana = new ABM_Marca();
            ventana.ShowDialog();            
           
        }

        private void altaCamionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaCamion ventana = new AltaCamion();
            ventana.ShowDialog();
        }

        private void altaCiudadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaCiudad ventana = new AltaCiudad();
            ventana.Show();
        }

        private void altaCombustibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaCombustible ventana = new AltaCombustible();
            ventana.ShowDialog();
        }

        private void altaTanqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaTanque ventana = new AltaTanque();
            ventana.ShowDialog();
        }

        private void altaTurnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaTurno ventana = new AltaTurno();
            ventana.ShowDialog();
        }

        private void altaPaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaPais ventana = new AltaPais();
            ventana.ShowDialog();
        }

        private void altaProvinciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaProvincia ventana = new AltaProvincia();
            ventana.ShowDialog();
        }

        private void altaEstacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaEstacion ventana = new AltaEstacion();
            ventana.ShowDialog();
        }
    }
}
