
namespace TPI
{
    partial class AltaTurno
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
            this.btnBorrarTurno = new System.Windows.Forms.Button();
            this.btnGuardarTurno = new System.Windows.Forms.Button();
            this.btnActualizarTurno = new System.Windows.Forms.Button();
            this.btnLimpiarDatos = new System.Windows.Forms.Button();
            this.grdTurno = new System.Windows.Forms.DataGridView();
            this.txtNombreTurno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCuitEstacion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDesde = new System.Windows.Forms.MaskedTextBox();
            this.txtHasta = new System.Windows.Forms.MaskedTextBox();
            this.cuitEstacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreTurno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDesde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaHasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdTurno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBorrarTurno
            // 
            this.btnBorrarTurno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnBorrarTurno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnBorrarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarTurno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarTurno.ForeColor = System.Drawing.Color.LightGray;
            this.btnBorrarTurno.Location = new System.Drawing.Point(224, 367);
            this.btnBorrarTurno.Name = "btnBorrarTurno";
            this.btnBorrarTurno.Size = new System.Drawing.Size(100, 60);
            this.btnBorrarTurno.TabIndex = 24;
            this.btnBorrarTurno.Text = "Borrar Turno";
            this.btnBorrarTurno.UseVisualStyleBackColor = true;
            this.btnBorrarTurno.Click += new System.EventHandler(this.btnBorrarTurno_Click);
            // 
            // btnGuardarTurno
            // 
            this.btnGuardarTurno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnGuardarTurno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnGuardarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarTurno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarTurno.ForeColor = System.Drawing.Color.LightGray;
            this.btnGuardarTurno.Location = new System.Drawing.Point(483, 280);
            this.btnGuardarTurno.Name = "btnGuardarTurno";
            this.btnGuardarTurno.Size = new System.Drawing.Size(100, 60);
            this.btnGuardarTurno.TabIndex = 23;
            this.btnGuardarTurno.Text = "Guardar ";
            this.btnGuardarTurno.UseVisualStyleBackColor = true;
            this.btnGuardarTurno.Click += new System.EventHandler(this.btnGuardarTurno_Click);
            // 
            // btnActualizarTurno
            // 
            this.btnActualizarTurno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnActualizarTurno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnActualizarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarTurno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarTurno.ForeColor = System.Drawing.Color.LightGray;
            this.btnActualizarTurno.Location = new System.Drawing.Point(350, 280);
            this.btnActualizarTurno.Name = "btnActualizarTurno";
            this.btnActualizarTurno.Size = new System.Drawing.Size(100, 60);
            this.btnActualizarTurno.TabIndex = 22;
            this.btnActualizarTurno.Text = "Actualizar datos";
            this.btnActualizarTurno.UseVisualStyleBackColor = true;
            this.btnActualizarTurno.Click += new System.EventHandler(this.btnActualizarTurno_Click);
            // 
            // btnLimpiarDatos
            // 
            this.btnLimpiarDatos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnLimpiarDatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnLimpiarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarDatos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarDatos.ForeColor = System.Drawing.Color.LightGray;
            this.btnLimpiarDatos.Location = new System.Drawing.Point(224, 280);
            this.btnLimpiarDatos.Name = "btnLimpiarDatos";
            this.btnLimpiarDatos.Size = new System.Drawing.Size(100, 60);
            this.btnLimpiarDatos.TabIndex = 21;
            this.btnLimpiarDatos.Text = "Limpiar Campos";
            this.btnLimpiarDatos.UseVisualStyleBackColor = true;
            this.btnLimpiarDatos.Click += new System.EventHandler(this.btnLimpiarDatos_Click);
            // 
            // grdTurno
            // 
            this.grdTurno.AllowUserToAddRows = false;
            this.grdTurno.AllowUserToDeleteRows = false;
            this.grdTurno.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.grdTurno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTurno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cuitEstacion,
            this.nombreTurno,
            this.horaDesde,
            this.horaHasta,
            this.descripcion});
            this.grdTurno.Location = new System.Drawing.Point(619, 50);
            this.grdTurno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grdTurno.Name = "grdTurno";
            this.grdTurno.ReadOnly = true;
            this.grdTurno.RowHeadersWidth = 51;
            this.grdTurno.RowTemplate.Height = 24;
            this.grdTurno.Size = new System.Drawing.Size(454, 377);
            this.grdTurno.TabIndex = 20;
            this.grdTurno.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTurno_CellClick);
            // 
            // txtNombreTurno
            // 
            this.txtNombreTurno.Location = new System.Drawing.Point(402, 93);
            this.txtNombreTurno.Name = "txtNombreTurno";
            this.txtNombreTurno.Size = new System.Drawing.Size(168, 20);
            this.txtNombreTurno.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(254, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nombre del Turno:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(413, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 30);
            this.label1.TabIndex = 17;
            this.label1.Text = "Alta de Turno";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.panel1.BackgroundImage = global::TPI.Properties.Resources.descarga;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 461);
            this.panel1.TabIndex = 27;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::TPI.Properties.Resources.Minimize_Icon;
            this.btnMinimizar.Location = new System.Drawing.Point(1052, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(21, 22);
            this.btnMinimizar.TabIndex = 26;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::TPI.Properties.Resources.Close_Icon;
            this.btnCerrar.Location = new System.Drawing.Point(1079, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(21, 22);
            this.btnCerrar.TabIndex = 25;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(401, 215);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(169, 20);
            this.txtDescripcion.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(291, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 21);
            this.label3.TabIndex = 28;
            this.label3.Text = "Descripción:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(248, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 21);
            this.label4.TabIndex = 30;
            this.label4.Text = "Cuit de la Estación:";
            // 
            // cmbCuitEstacion
            // 
            this.cmbCuitEstacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCuitEstacion.FormattingEnabled = true;
            this.cmbCuitEstacion.Location = new System.Drawing.Point(402, 56);
            this.cmbCuitEstacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCuitEstacion.Name = "cmbCuitEstacion";
            this.cmbCuitEstacion.Size = new System.Drawing.Size(168, 21);
            this.cmbCuitEstacion.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(296, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 21);
            this.label5.TabIndex = 34;
            this.label5.Text = "Hora Hasta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(293, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 21);
            this.label6.TabIndex = 32;
            this.label6.Text = "Hora Desde:";
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(403, 128);
            this.txtDesde.Mask = "00:00";
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(47, 20);
            this.txtDesde.TabIndex = 35;
            this.txtDesde.ValidatingType = typeof(System.DateTime);
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(402, 165);
            this.txtHasta.Mask = "00:00";
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(47, 20);
            this.txtHasta.TabIndex = 36;
            this.txtHasta.ValidatingType = typeof(System.DateTime);
            // 
            // cuitEstacion
            // 
            this.cuitEstacion.DataPropertyName = "cuitEstacion";
            this.cuitEstacion.HeaderText = "Cuit Estación";
            this.cuitEstacion.MinimumWidth = 6;
            this.cuitEstacion.Name = "cuitEstacion";
            this.cuitEstacion.ReadOnly = true;
            this.cuitEstacion.Width = 80;
            // 
            // nombreTurno
            // 
            this.nombreTurno.DataPropertyName = "nombreTurno";
            this.nombreTurno.HeaderText = "Nombre";
            this.nombreTurno.MinimumWidth = 6;
            this.nombreTurno.Name = "nombreTurno";
            this.nombreTurno.ReadOnly = true;
            this.nombreTurno.Width = 125;
            // 
            // horaDesde
            // 
            this.horaDesde.DataPropertyName = "horaDesde";
            this.horaDesde.HeaderText = "Hora Desde";
            this.horaDesde.Name = "horaDesde";
            this.horaDesde.ReadOnly = true;
            // 
            // horaHasta
            // 
            this.horaHasta.DataPropertyName = "horaHasta";
            this.horaHasta.HeaderText = "Hora Hasta";
            this.horaHasta.Name = "horaHasta";
            this.horaHasta.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.FillWeight = 200F;
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.MinimumWidth = 6;
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 250;
            // 
            // AltaTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1105, 461);
            this.Controls.Add(this.txtHasta);
            this.Controls.Add(this.cmbCuitEstacion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDesde);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnBorrarTurno);
            this.Controls.Add(this.btnGuardarTurno);
            this.Controls.Add(this.btnActualizarTurno);
            this.Controls.Add(this.btnLimpiarDatos);
            this.Controls.Add(this.grdTurno);
            this.Controls.Add(this.txtNombreTurno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AltaTurno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaTurno";
            this.Load += new System.EventHandler(this.AltaTurno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdTurno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Button btnBorrarTurno;
        private System.Windows.Forms.Button btnGuardarTurno;
        private System.Windows.Forms.Button btnActualizarTurno;
        private System.Windows.Forms.Button btnLimpiarDatos;
        private System.Windows.Forms.DataGridView grdTurno;
        private System.Windows.Forms.TextBox txtNombreTurno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCuitEstacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtDesde;
        private System.Windows.Forms.MaskedTextBox txtHasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuitEstacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreTurno;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaHasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
    }
}