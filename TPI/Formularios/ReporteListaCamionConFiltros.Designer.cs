
namespace TPI.Formularios
{
    partial class ReporteListaCamionConFiltros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rVListadoCamionesConFiltro = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.lblPatente = new System.Windows.Forms.Label();
            this.lblListadoCamiones = new System.Windows.Forms.Label();
            this.btnBuscarCamiones = new System.Windows.Forms.Button();
            this.txtCantCombustibleMax = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.cmbModelo = new System.Windows.Forms.ComboBox();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.lblCantCombMax = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.txtCantCombustibleMin = new System.Windows.Forms.TextBox();
            this.lbly = new System.Windows.Forms.Label();
            this.lblEntre = new System.Windows.Forms.Label();
            this.lblLitros = new System.Windows.Forms.Label();
            this.lblLitros2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // rVListadoCamionesConFiltro
            // 
            this.rVListadoCamionesConFiltro.BackColor = System.Drawing.Color.DarkCyan;
            this.rVListadoCamionesConFiltro.LocalReport.ReportEmbeddedResource = "TPI.ConjuntoDeDatos.ListadoDeCamiones.rdlc";
            this.rVListadoCamionesConFiltro.Location = new System.Drawing.Point(55, 214);
            this.rVListadoCamionesConFiltro.Name = "rVListadoCamionesConFiltro";
            this.rVListadoCamionesConFiltro.ServerReport.BearerToken = null;
            this.rVListadoCamionesConFiltro.Size = new System.Drawing.Size(692, 370);
            this.rVListadoCamionesConFiltro.TabIndex = 6;
            this.rVListadoCamionesConFiltro.Load += new System.EventHandler(this.rVListadoCamionesConFiltro_Load);
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(182, 126);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(100, 20);
            this.txtPatente.TabIndex = 1;
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatente.ForeColor = System.Drawing.Color.White;
            this.lblPatente.Location = new System.Drawing.Point(96, 125);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(78, 21);
            this.lblPatente.TabIndex = 2;
            this.lblPatente.Text = "Patente:";
            // 
            // lblListadoCamiones
            // 
            this.lblListadoCamiones.AutoSize = true;
            this.lblListadoCamiones.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoCamiones.ForeColor = System.Drawing.Color.White;
            this.lblListadoCamiones.Location = new System.Drawing.Point(257, 9);
            this.lblListadoCamiones.Name = "lblListadoCamiones";
            this.lblListadoCamiones.Size = new System.Drawing.Size(261, 30);
            this.lblListadoCamiones.TabIndex = 3;
            this.lblListadoCamiones.Text = "Listado de camiones";
            // 
            // btnBuscarCamiones
            // 
            this.btnBuscarCamiones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(189)))));
            this.btnBuscarCamiones.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnBuscarCamiones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnBuscarCamiones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCamiones.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCamiones.ForeColor = System.Drawing.Color.LightGray;
            this.btnBuscarCamiones.Location = new System.Drawing.Point(598, 121);
            this.btnBuscarCamiones.Name = "btnBuscarCamiones";
            this.btnBuscarCamiones.Size = new System.Drawing.Size(115, 58);
            this.btnBuscarCamiones.TabIndex = 6;
            this.btnBuscarCamiones.Text = "Buscar camiones";
            this.btnBuscarCamiones.UseVisualStyleBackColor = false;
            this.btnBuscarCamiones.Click += new System.EventHandler(this.btnBuscarCamiones_Click);
            // 
            // txtCantCombustibleMax
            // 
            this.txtCantCombustibleMax.Location = new System.Drawing.Point(380, 160);
            this.txtCantCombustibleMax.Name = "txtCantCombustibleMax";
            this.txtCantCombustibleMax.Size = new System.Drawing.Size(100, 20);
            this.txtCantCombustibleMax.TabIndex = 4;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.ForeColor = System.Drawing.Color.White;
            this.lblModelo.Location = new System.Drawing.Point(101, 155);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(73, 21);
            this.lblModelo.TabIndex = 7;
            this.lblModelo.Text = "Modelo:";
            // 
            // cmbModelo
            // 
            this.cmbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModelo.FormattingEnabled = true;
            this.cmbModelo.Location = new System.Drawing.Point(183, 158);
            this.cmbModelo.Name = "cmbModelo";
            this.cmbModelo.Size = new System.Drawing.Size(99, 21);
            this.cmbModelo.TabIndex = 2;
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(189)))));
            this.btnLimpiarCampos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnLimpiarCampos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.ForeColor = System.Drawing.Color.LightGray;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(598, 40);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(115, 58);
            this.btnLimpiarCampos.TabIndex = 5;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // lblCantCombMax
            // 
            this.lblCantCombMax.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantCombMax.ForeColor = System.Drawing.Color.White;
            this.lblCantCombMax.Location = new System.Drawing.Point(335, 71);
            this.lblCantCombMax.Name = "lblCantCombMax";
            this.lblCantCombMax.Size = new System.Drawing.Size(185, 48);
            this.lblCantCombMax.TabIndex = 6;
            this.lblCantCombMax.Text = "Cantidad de litros de combustible máximos:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::TPI.Properties.Resources.Close_Icon;
            this.btnCerrar.Location = new System.Drawing.Point(772, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(21, 22);
            this.btnCerrar.TabIndex = 33;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::TPI.Properties.Resources.Minimize_Icon;
            this.btnMinimizar.Location = new System.Drawing.Point(745, 9);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(21, 22);
            this.btnMinimizar.TabIndex = 34;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // txtCantCombustibleMin
            // 
            this.txtCantCombustibleMin.Location = new System.Drawing.Point(380, 130);
            this.txtCantCombustibleMin.Name = "txtCantCombustibleMin";
            this.txtCantCombustibleMin.Size = new System.Drawing.Size(100, 20);
            this.txtCantCombustibleMin.TabIndex = 3;
            // 
            // lbly
            // 
            this.lbly.AutoSize = true;
            this.lbly.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbly.ForeColor = System.Drawing.Color.White;
            this.lbly.Location = new System.Drawing.Point(352, 157);
            this.lbly.Name = "lbly";
            this.lbly.Size = new System.Drawing.Size(22, 21);
            this.lbly.TabIndex = 36;
            this.lbly.Text = "y:";
            // 
            // lblEntre
            // 
            this.lblEntre.AutoSize = true;
            this.lblEntre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntre.ForeColor = System.Drawing.Color.White;
            this.lblEntre.Location = new System.Drawing.Point(319, 128);
            this.lblEntre.Name = "lblEntre";
            this.lblEntre.Size = new System.Drawing.Size(55, 21);
            this.lblEntre.TabIndex = 37;
            this.lblEntre.Text = "Entre:";
            // 
            // lblLitros
            // 
            this.lblLitros.AutoSize = true;
            this.lblLitros.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLitros.ForeColor = System.Drawing.Color.White;
            this.lblLitros.Location = new System.Drawing.Point(486, 127);
            this.lblLitros.Name = "lblLitros";
            this.lblLitros.Size = new System.Drawing.Size(48, 21);
            this.lblLitros.TabIndex = 38;
            this.lblLitros.Text = "Litros";
            // 
            // lblLitros2
            // 
            this.lblLitros2.AutoSize = true;
            this.lblLitros2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLitros2.ForeColor = System.Drawing.Color.White;
            this.lblLitros2.Location = new System.Drawing.Point(486, 157);
            this.lblLitros2.Name = "lblLitros2";
            this.lblLitros2.Size = new System.Drawing.Size(48, 21);
            this.lblLitros2.TabIndex = 39;
            this.lblLitros2.Text = "Litros";
            // 
            // ReporteListaCamionConFiltros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(800, 627);
            this.Controls.Add(this.lblLitros2);
            this.Controls.Add(this.lblLitros);
            this.Controls.Add(this.lblEntre);
            this.Controls.Add(this.lbly);
            this.Controls.Add(this.txtCantCombustibleMin);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.cmbModelo);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblCantCombMax);
            this.Controls.Add(this.txtCantCombustibleMax);
            this.Controls.Add(this.btnBuscarCamiones);
            this.Controls.Add(this.lblListadoCamiones);
            this.Controls.Add(this.lblPatente);
            this.Controls.Add(this.txtPatente);
            this.Controls.Add(this.rVListadoCamionesConFiltro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReporteListaCamionConFiltros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de camiones con filtro";
            this.Load += new System.EventHandler(this.ReporteListaCamionConFiltros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rVListadoCamionesConFiltro;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.Label lblListadoCamiones;
        private System.Windows.Forms.Button btnBuscarCamiones;
        private System.Windows.Forms.TextBox txtCantCombustibleMax;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.ComboBox cmbModelo;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Label lblCantCombMax;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.TextBox txtCantCombustibleMin;
        private System.Windows.Forms.Label lbly;
        private System.Windows.Forms.Label lblEntre;
        private System.Windows.Forms.Label lblLitros;
        private System.Windows.Forms.Label lblLitros2;
    }
}