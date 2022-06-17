
namespace TPI.Formularios
{
    partial class ReporteListaEmpleadoRestricciones
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.chkGerente = new System.Windows.Forms.CheckBox();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.lblGerente = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblCuil = new System.Windows.Forms.Label();
            this.txtCuil = new System.Windows.Forms.TextBox();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.txtNroDocumento = new System.Windows.Forms.MaskedTextBox();
            this.lblNroDocumento = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnBuscarEmpleado = new System.Windows.Forms.Button();
            this.bD3K7G09_2021DataSet1 = new TPI.BD3K7G09_2021DataSet1();
            this.btnLimpiarDatos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K7G09_2021DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.DarkCyan;
            reportDataSource3.Name = "DataSetEmpleado";
            reportDataSource4.Name = "DataSetEmpleadoRestricciones";
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TPI.ConjuntoDeDatos.DatosEmpleado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 288);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1151, 497);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(365, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(339, 37);
            this.label3.TabIndex = 53;
            this.label3.Text = "Listado de Empleados";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::TPI.Properties.Resources.Minimize_Icon;
            this.btnMinimizar.Location = new System.Drawing.Point(1115, 9);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(21, 22);
            this.btnMinimizar.TabIndex = 55;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::TPI.Properties.Resources.Close_Icon;
            this.btnCerrar.Location = new System.Drawing.Point(1142, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(21, 22);
            this.btnCerrar.TabIndex = 54;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // chkGerente
            // 
            this.chkGerente.AutoSize = true;
            this.chkGerente.ForeColor = System.Drawing.Color.White;
            this.chkGerente.Location = new System.Drawing.Point(958, 87);
            this.chkGerente.Name = "chkGerente";
            this.chkGerente.Size = new System.Drawing.Size(42, 21);
            this.chkGerente.TabIndex = 66;
            this.chkGerente.Text = "Si";
            this.chkGerente.UseVisualStyleBackColor = true;
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.BackColor = System.Drawing.Color.White;
            this.cmbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCiudad.ForeColor = System.Drawing.Color.Black;
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(174, 140);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(171, 24);
            this.cmbCiudad.TabIndex = 59;
            // 
            // lblGerente
            // 
            this.lblGerente.AutoSize = true;
            this.lblGerente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGerente.ForeColor = System.Drawing.Color.White;
            this.lblGerente.Location = new System.Drawing.Point(856, 85);
            this.lblGerente.Name = "lblGerente";
            this.lblGerente.Size = new System.Drawing.Size(96, 23);
            this.lblGerente.TabIndex = 76;
            this.lblGerente.Text = "Gerente:";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.ForeColor = System.Drawing.Color.White;
            this.lblCiudad.Location = new System.Drawing.Point(80, 141);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(88, 23);
            this.lblCiudad.TabIndex = 75;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // lblCuil
            // 
            this.lblCuil.AutoSize = true;
            this.lblCuil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuil.ForeColor = System.Drawing.Color.White;
            this.lblCuil.Location = new System.Drawing.Point(456, 140);
            this.lblCuil.Name = "lblCuil";
            this.lblCuil.Size = new System.Drawing.Size(58, 23);
            this.lblCuil.TabIndex = 74;
            this.lblCuil.Text = "CUIL:";
            // 
            // txtCuil
            // 
            this.txtCuil.BackColor = System.Drawing.Color.White;
            this.txtCuil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCuil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuil.ForeColor = System.Drawing.Color.Black;
            this.txtCuil.Location = new System.Drawing.Point(520, 140);
            this.txtCuil.Name = "txtCuil";
            this.txtCuil.Size = new System.Drawing.Size(171, 23);
            this.txtCuil.TabIndex = 62;
            // 
            // txtLegajo
            // 
            this.txtLegajo.BackColor = System.Drawing.Color.White;
            this.txtLegajo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLegajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLegajo.ForeColor = System.Drawing.Color.Black;
            this.txtLegajo.Location = new System.Drawing.Point(520, 111);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(171, 23);
            this.txtLegajo.TabIndex = 58;
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegajo.ForeColor = System.Drawing.Color.White;
            this.lblLegajo.Location = new System.Drawing.Point(434, 111);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(80, 23);
            this.lblLegajo.TabIndex = 73;
            this.lblLegajo.Text = "Legajo:";
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.BackColor = System.Drawing.Color.White;
            this.txtNroDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNroDocumento.ForeColor = System.Drawing.Color.Black;
            this.txtNroDocumento.Location = new System.Drawing.Point(621, 83);
            this.txtNroDocumento.Mask = "99999999";
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.Size = new System.Drawing.Size(70, 22);
            this.txtNroDocumento.TabIndex = 64;
            this.txtNroDocumento.ValidatingType = typeof(int);
            // 
            // lblNroDocumento
            // 
            this.lblNroDocumento.AutoSize = true;
            this.lblNroDocumento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroDocumento.ForeColor = System.Drawing.Color.White;
            this.lblNroDocumento.Location = new System.Drawing.Point(422, 82);
            this.lblNroDocumento.Name = "lblNroDocumento";
            this.lblNroDocumento.Size = new System.Drawing.Size(193, 23);
            this.lblNroDocumento.TabIndex = 70;
            this.lblNroDocumento.Text = "N° de documento:";
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.White;
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.Color.Black;
            this.txtApellido.Location = new System.Drawing.Point(174, 111);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(171, 23);
            this.txtApellido.TabIndex = 57;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.White;
            this.lblApellido.Location = new System.Drawing.Point(71, 111);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(97, 23);
            this.lblApellido.TabIndex = 68;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(174, 82);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(171, 23);
            this.txtNombre.TabIndex = 56;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(73, 82);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(95, 23);
            this.lblNombre.TabIndex = 67;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(189)))));
            this.btnBuscarEmpleado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnBuscarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarEmpleado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarEmpleado.ForeColor = System.Drawing.Color.LightGray;
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(860, 194);
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(188, 66);
            this.btnBuscarEmpleado.TabIndex = 78;
            this.btnBuscarEmpleado.Text = "Buscar Empleado";
            this.btnBuscarEmpleado.UseVisualStyleBackColor = false;
            this.btnBuscarEmpleado.Click += new System.EventHandler(this.btnBuscarEmpleado_Click);
            // 
            // bD3K7G09_2021DataSet1
            // 
            this.bD3K7G09_2021DataSet1.DataSetName = "BD3K7G09_2021DataSet1";
            this.bD3K7G09_2021DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnLimpiarDatos
            // 
            this.btnLimpiarDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(189)))));
            this.btnLimpiarDatos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnLimpiarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarDatos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarDatos.ForeColor = System.Drawing.Color.LightGray;
            this.btnLimpiarDatos.Location = new System.Drawing.Point(516, 194);
            this.btnLimpiarDatos.Name = "btnLimpiarDatos";
            this.btnLimpiarDatos.Size = new System.Drawing.Size(188, 66);
            this.btnLimpiarDatos.TabIndex = 79;
            this.btnLimpiarDatos.Text = "Limpiar Datos";
            this.btnLimpiarDatos.UseVisualStyleBackColor = false;
            this.btnLimpiarDatos.Click += new System.EventHandler(this.btnLimpiarDatos_Click);
            // 
            // ReporteListaEmpleadoRestricciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(1169, 797);
            this.Controls.Add(this.btnLimpiarDatos);
            this.Controls.Add(this.btnBuscarEmpleado);
            this.Controls.Add(this.chkGerente);
            this.Controls.Add(this.cmbCiudad);
            this.Controls.Add(this.lblGerente);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.lblCuil);
            this.Controls.Add(this.txtCuil);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.lblLegajo);
            this.Controls.Add(this.txtNroDocumento);
            this.Controls.Add(this.lblNroDocumento);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReporteListaEmpleadoRestricciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Empleados";
            this.Load += new System.EventHandler(this.ReporteListaEmpleadoRestricciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K7G09_2021DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.CheckBox chkGerente;
        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.Label lblGerente;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblCuil;
        private System.Windows.Forms.TextBox txtCuil;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.MaskedTextBox txtNroDocumento;
        private System.Windows.Forms.Label lblNroDocumento;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnBuscarEmpleado;
        private BD3K7G09_2021DataSet1 bD3K7G09_2021DataSet1;
        private System.Windows.Forms.Button btnLimpiarDatos;
    }
}