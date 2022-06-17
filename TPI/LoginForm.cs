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
using System.Runtime.InteropServices;

namespace TPI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Legajo")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }
        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Legajo";
                txtUsuario.ForeColor = Color.Silver;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Numero de Documento")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.LightGray;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Numero de Documento";
                txtPass.ForeColor = Color.Silver;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("Usuario") || txtUsuario.Text.Equals("") || txtPass.Text.Equals("Contraseña") || txtPass.Text.Equals(""))
            {
                MessageBox.Show("Ingrese Nombre de Legajo y Numero de Documento");
            }
            else
            {
                string legajoDeEmpleado = txtUsuario.Text;
                string nroDocEmpleado = txtPass.Text;
                bool resultado = false;

                try
                {
                    resultado = AD_Usuarios.ValidarUsuario(legajoDeEmpleado, nroDocEmpleado);
                    if (resultado)
                    {
                        Empleado emp = new Empleado(legajoDeEmpleado, nroDocEmpleado);
                        PrincipalForm ventana = new PrincipalForm(emp);
                        ventana.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario Inexistente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Base de datos no Encontrada.");

                }



            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
