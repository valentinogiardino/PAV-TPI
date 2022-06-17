
namespace TPI.Formularios
{
    partial class ReporteListadoTurnoRestricciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteListadoTurnoRestricciones));
            this.reportTurnosRestricciones = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CUIT = new System.Windows.Forms.Label();
            this.txtCuitEstacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbNombreTurno = new System.Windows.Forms.ComboBox();
            this.txtHoraDesde = new System.Windows.Forms.MaskedTextBox();
            this.txtHoraHasta = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // reportTurnosRestricciones
            // 
            this.reportTurnosRestricciones.BackColor = System.Drawing.Color.DarkCyan;
            this.reportTurnosRestricciones.LocalReport.ReportEmbeddedResource = "TPI.ConjuntoDeDatos.DatosTurnos.rdlc";
            this.reportTurnosRestricciones.Location = new System.Drawing.Point(16, 214);
            this.reportTurnosRestricciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reportTurnosRestricciones.Name = "reportTurnosRestricciones";
            this.reportTurnosRestricciones.ServerReport.BearerToken = null;
            this.reportTurnosRestricciones.Size = new System.Drawing.Size(695, 400);
            this.reportTurnosRestricciones.TabIndex = 0;
            this.reportTurnosRestricciones.Load += new System.EventHandler(this.reportTurnosRestricciones_Load);
            // 
            // CUIT
            // 
            this.CUIT.AutoSize = true;
            this.CUIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.CUIT.ForeColor = System.Drawing.Color.White;
            this.CUIT.Location = new System.Drawing.Point(12, 39);
            this.CUIT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CUIT.Name = "CUIT";
            this.CUIT.Size = new System.Drawing.Size(149, 24);
            this.CUIT.TabIndex = 1;
            this.CUIT.Text = "Cuit de estacion:";
            // 
            // txtCuitEstacion
            // 
            this.txtCuitEstacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtCuitEstacion.Location = new System.Drawing.Point(16, 74);
            this.txtCuitEstacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCuitEstacion.Name = "txtCuitEstacion";
            this.txtCuitEstacion.Size = new System.Drawing.Size(155, 20);
            this.txtCuitEstacion.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(245, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Turno:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(245, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hora hasta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hora desde:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(594, 128);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(119, 59);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Generar Reporte";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbNombreTurno
            // 
            this.cmbNombreTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cmbNombreTurno.FormattingEnabled = true;
            this.cmbNombreTurno.Location = new System.Drawing.Point(249, 74);
            this.cmbNombreTurno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbNombreTurno.Name = "cmbNombreTurno";
            this.cmbNombreTurno.Size = new System.Drawing.Size(155, 21);
            this.cmbNombreTurno.TabIndex = 10;
            // 
            // txtHoraDesde
            // 
            this.txtHoraDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtHoraDesde.Location = new System.Drawing.Point(16, 167);
            this.txtHoraDesde.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHoraDesde.Mask = "00:00";
            this.txtHoraDesde.Name = "txtHoraDesde";
            this.txtHoraDesde.Size = new System.Drawing.Size(155, 20);
            this.txtHoraDesde.TabIndex = 13;
            this.txtHoraDesde.ValidatingType = typeof(System.DateTime);
            // 
            // txtHoraHasta
            // 
            this.txtHoraHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtHoraHasta.Location = new System.Drawing.Point(249, 167);
            this.txtHoraHasta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHoraHasta.Mask = "00:00";
            this.txtHoraHasta.Name = "txtHoraHasta";
            this.txtHoraHasta.Size = new System.Drawing.Size(155, 20);
            this.txtHoraHasta.TabIndex = 14;
            this.txtHoraHasta.ValidatingType = typeof(System.DateTime);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(189)))));
            this.btnLimpiarCampos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnLimpiarCampos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(451, 128);
            this.btnLimpiarCampos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(119, 59);
            this.btnLimpiarCampos.TabIndex = 15;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::TPI.Properties.Resources.Close_Icon;
            this.btnCerrar.Location = new System.Drawing.Point(705, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(21, 22);
            this.btnCerrar.TabIndex = 43;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::TPI.Properties.Resources.Minimize_Icon;
            this.btnMinimizar.Location = new System.Drawing.Point(678, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(21, 22);
            this.btnMinimizar.TabIndex = 44;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 45;
            this.label4.Text = "Filtros";
            // 
            // ReporteListadoTurnoRestricciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(743, 628);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.txtHoraHasta);
            this.Controls.Add(this.txtHoraDesde);
            this.Controls.Add(this.cmbNombreTurno);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCuitEstacion);
            this.Controls.Add(this.CUIT);
            this.Controls.Add(this.reportTurnosRestricciones);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReporteListadoTurnoRestricciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteListadoTurnoRestricciones";
            this.Load += new System.EventHandler(this.ReporteListadoTurnoRestricciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportTurnosRestricciones;
        private System.Windows.Forms.Label CUIT;
        private System.Windows.Forms.TextBox txtCuitEstacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmbNombreTurno;
        private System.Windows.Forms.MaskedTextBox txtHoraDesde;
        private System.Windows.Forms.MaskedTextBox txtHoraHasta;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.Label label4;
    }
}