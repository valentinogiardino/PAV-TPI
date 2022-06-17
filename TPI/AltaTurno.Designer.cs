
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
            this.cuitEstacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreTurno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbCuitEstacion = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdTurno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBorrarTurno
            // 
            this.btnBorrarTurno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarTurno.Location = new System.Drawing.Point(644, 340);
            this.btnBorrarTurno.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrarTurno.Name = "btnBorrarTurno";
            this.btnBorrarTurno.Size = new System.Drawing.Size(160, 89);
            this.btnBorrarTurno.TabIndex = 24;
            this.btnBorrarTurno.Text = "Borrar Turno";
            this.btnBorrarTurno.UseVisualStyleBackColor = true;
            this.btnBorrarTurno.Click += new System.EventHandler(this.btnBorrarTurno_Click);
            // 
            // btnGuardarTurno
            // 
            this.btnGuardarTurno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarTurno.Location = new System.Drawing.Point(289, 340);
            this.btnGuardarTurno.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarTurno.Name = "btnGuardarTurno";
            this.btnGuardarTurno.Size = new System.Drawing.Size(160, 89);
            this.btnGuardarTurno.TabIndex = 23;
            this.btnGuardarTurno.Text = "Guardar ";
            this.btnGuardarTurno.UseVisualStyleBackColor = true;
            this.btnGuardarTurno.Click += new System.EventHandler(this.btnGuardarTurno_Click);
            // 
            // btnActualizarTurno
            // 
            this.btnActualizarTurno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarTurno.Location = new System.Drawing.Point(472, 340);
            this.btnActualizarTurno.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizarTurno.Name = "btnActualizarTurno";
            this.btnActualizarTurno.Size = new System.Drawing.Size(160, 89);
            this.btnActualizarTurno.TabIndex = 22;
            this.btnActualizarTurno.Text = "Actualizar datos";
            this.btnActualizarTurno.UseVisualStyleBackColor = true;
            this.btnActualizarTurno.Click += new System.EventHandler(this.btnActualizarTurno_Click);
            // 
            // btnLimpiarDatos
            // 
            this.btnLimpiarDatos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarDatos.Location = new System.Drawing.Point(289, 194);
            this.btnLimpiarDatos.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiarDatos.Name = "btnLimpiarDatos";
            this.btnLimpiarDatos.Size = new System.Drawing.Size(160, 66);
            this.btnLimpiarDatos.TabIndex = 21;
            this.btnLimpiarDatos.Text = "Limpiar Datos";
            this.btnLimpiarDatos.UseVisualStyleBackColor = true;
            this.btnLimpiarDatos.Click += new System.EventHandler(this.btnLimpiarDatos_Click);
            // 
            // grdTurno
            // 
            this.grdTurno.AllowUserToDeleteRows = false;
            this.grdTurno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTurno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cuitEstacion,
            this.nombreTurno,
            this.descripcion});
            this.grdTurno.Location = new System.Drawing.Point(825, 61);
            this.grdTurno.Name = "grdTurno";
            this.grdTurno.ReadOnly = true;
            this.grdTurno.RowHeadersWidth = 51;
            this.grdTurno.RowTemplate.Height = 24;
            this.grdTurno.Size = new System.Drawing.Size(508, 357);
            this.grdTurno.TabIndex = 20;
            this.grdTurno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTurno_CellContentClick);
            // 
            // txtNombreTurno
            // 
            this.txtNombreTurno.Location = new System.Drawing.Point(536, 115);
            this.txtNombreTurno.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreTurno.Name = "txtNombreTurno";
            this.txtNombreTurno.Size = new System.Drawing.Size(223, 22);
            this.txtNombreTurno.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(338, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nombre del Turno:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(564, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 33);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 467);
            this.panel1.TabIndex = 27;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::TPI.Properties.Resources.Minimize_Icon;
            this.btnMinimizar.Location = new System.Drawing.Point(1269, 13);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(28, 27);
            this.btnMinimizar.TabIndex = 26;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::TPI.Properties.Resources.Close_Icon;
            this.btnCerrar.Location = new System.Drawing.Point(1305, 13);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(28, 27);
            this.btnCerrar.TabIndex = 25;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(466, 157);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(293, 22);
            this.txtDescripcion.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(330, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 23);
            this.label3.TabIndex = 28;
            this.label3.Text = "Descripción:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(330, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 23);
            this.label4.TabIndex = 30;
            this.label4.Text = "Cuit de la Estación:";
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
            // descripcion
            // 
            this.descripcion.FillWeight = 200F;
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.MinimumWidth = 6;
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 250;
            // 
            // cmbCuitEstacion
            // 
            this.cmbCuitEstacion.FormattingEnabled = true;
            this.cmbCuitEstacion.Location = new System.Drawing.Point(536, 69);
            this.cmbCuitEstacion.Name = "cmbCuitEstacion";
            this.cmbCuitEstacion.Size = new System.Drawing.Size(223, 24);
            this.cmbCuitEstacion.TabIndex = 31;
            // 
            // AltaTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1341, 467);
            this.Controls.Add(this.cmbCuitEstacion);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn cuitEstacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreTurno;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.ComboBox cmbCuitEstacion;
    }
}