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
    public partial class NuevoRemito : Form
    {
        public NuevoRemito()
        {
            InitializeComponent();
        }

        private void NuevoRemito_Load(object sender, EventArgs e)
        {
            CargarFecha();
            CargarComboCuitEstacion();
            CargarComboPatenteCamion();
            CargarComboNombrCombustible();
            ObtenerNumRemito();
        }

        private void CargarFecha()
        {
            txtFecha.Text = AdaptarFecha(DateTime.Today);
        }

        private string AdaptarFecha(DateTime fecha)
        {
            string dia = "";
            string mes = "";
            string año = "";
            dia = fecha.Date.Day.ToString();
            if (dia.Length == 1)
            {
                dia = "0" + dia;
            }
            mes = fecha.Date.Month.ToString();
            if (mes.Length == 1)
            {
                mes = "0" + mes;
            }
            año = fecha.Date.Year.ToString();

            string fechaAdaptada = dia + mes + año;
            return fechaAdaptada;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void CargarComboCuitEstacion()
        {

            cmbCuitEstacion.DataSource = AD_Remitos.ObtenerCuitEstacion();
            cmbCuitEstacion.DisplayMember = "nombre";
            cmbCuitEstacion.ValueMember = "cuitEstacion";
            cmbCuitEstacion.SelectedIndex = -1;

        }


        private void CargarComboPatenteCamion()
        {

            cmbPatenteCamion.DataSource = AD_Remitos.ObtenerPatente();
            cmbPatenteCamion.DisplayMember = "patente";
            cmbPatenteCamion.ValueMember = "patente";
            cmbPatenteCamion.SelectedIndex = -1;

        }


        private void CargarComboNombrCombustible()
        {
            cmbCombustible.DataSource = AD_Remitos.ObtenerNombreComb();
            cmbCombustible.DisplayMember = "nombre";
            cmbCombustible.ValueMember = "idCombustible";
            cmbCombustible.SelectedIndex = -1;
        }

        private void btnAgregarCombustible_Click(object sender, EventArgs e)
        {
            if ((cmbCombustible.SelectedIndex != -1) && (txtPrecioUnitario.Value != 0) && (txtCantidadComb.Value != 0))
            {
                if (grdCombustible.Rows.Count < 2)
                {
                    grdCombustible.Rows.Add(cmbCombustible.SelectedValue, txtCantidadComb.Text, txtPrecioUnitario.Text);
                    LimpiarCampos();
                    btnGenerarRemito.Enabled = true;
                    btnLimpiarGrilla.Enabled = true;
                    txtCantidadComb.Value = 0;
                    txtPrecioUnitario.Value = 0;
                }
                else
                {
                    MessageBox.Show("Solo se pueden enviar Hasta 2 Combustibles por Remito.");
                }
            }
            else
            {
                MessageBox.Show("Debe cargar los campos Requeridos.");
            }
            
        }

        private void ObtenerNumRemito()
        {
            int id = AD_Remitos.ObtenerUltimoNumRemito();
            txtINroRemito.Text = (id + 1).ToString();

        }

        private void btnGenerarRemito_Click(object sender, EventArgs e)
        {
            if ((cmbPatenteCamion.SelectedIndex != -1) && (cmbCuitEstacion.SelectedIndex != -1))
            {
                try
                {
                    List<int> listaCombustibles = new List<int>();
                    List<float> listaPrecios = new List<float>();
                    List<float> listaCantidad = new List<float>();

                    for (int i = 0; i < grdCombustible.Rows.Count; i++)
                    {
                        listaCombustibles.Add(int.Parse(grdCombustible.Rows[i].Cells[0].Value.ToString()));
                        listaCantidad.Add(float.Parse(grdCombustible.Rows[i].Cells[1].Value.ToString()));
                        listaPrecios.Add(float.Parse(grdCombustible.Rows[i].Cells[2].Value.ToString()));
                    }

                    bool resultado = AD_Remitos.AltaRemito(txtINroRemito.Text, cmbCuitEstacion.SelectedValue.ToString(), txtFecha.Text, cmbPatenteCamion.SelectedValue.ToString(), listaCombustibles, listaCantidad, listaPrecios);

                    if (resultado)
                    {
                        MessageBox.Show("Remito generado con exito");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al generar el remito");
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Error al Generar Remito.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese todos los datos.");
            }
            
            
        }


        private void LimpiarCampos()
        {
            txtCantidadComb.Text = "";
            txtPrecioUnitario.Text = "";
            cmbCombustible.SelectedIndex = -1;

        }

        private void LimpiarGrilla()
        {
            grdCombustible.Rows.Clear();
        }

        private void btnLimpiarGrilla_Click(object sender, EventArgs e)
        {
            LimpiarGrilla();
        }
    }
}
