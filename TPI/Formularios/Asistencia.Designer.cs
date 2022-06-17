
namespace TPI.Formularios
{
    partial class Asistencia
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCuitEstacion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbNombreTurno = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.cmbDocEmpleado = new System.Windows.Forms.ComboBox();
            this.txtFecha = new System.Windows.Forms.MaskedTextBox();
            this.labelFecha = new System.Windows.Forms.Label();
            this.grdEmpleado = new System.Windows.Forms.DataGridView();
            this.NroDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarEmpleado = new System.Windows.Forms.Button();
            this.btnGenerarAsistencia = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLimpiarGrilla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.panel1.BackgroundImage = global::TPI.Properties.Resources.descarga;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 491);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(224, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 30);
            this.label1.TabIndex = 21;
            this.label1.Text = "Asistencia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(226, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "Nombre Estación:";
            // 
            // cmbCuitEstacion
            // 
            this.cmbCuitEstacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCuitEstacion.FormattingEnabled = true;
            this.cmbCuitEstacion.Location = new System.Drawing.Point(369, 95);
            this.cmbCuitEstacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCuitEstacion.Name = "cmbCuitEstacion";
            this.cmbCuitEstacion.Size = new System.Drawing.Size(168, 21);
            this.cmbCuitEstacion.TabIndex = 1;
            this.cmbCuitEstacion.SelectedIndexChanged += new System.EventHandler(this.cmbCuitEstacion_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(249, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 21);
            this.label2.TabIndex = 44;
            this.label2.Text = "Nombre Turno:";
            // 
            // cmbNombreTurno
            // 
            this.cmbNombreTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombreTurno.FormattingEnabled = true;
            this.cmbNombreTurno.Location = new System.Drawing.Point(369, 131);
            this.cmbNombreTurno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbNombreTurno.Name = "cmbNombreTurno";
            this.cmbNombreTurno.Size = new System.Drawing.Size(168, 21);
            this.cmbNombreTurno.TabIndex = 2;
            this.cmbNombreTurno.SelectedIndexChanged += new System.EventHandler(this.cmbNombreTurno_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(210, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 21);
            this.label3.TabIndex = 46;
            this.label3.Text = "Nro Doc Empleado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(490, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 21);
            this.label5.TabIndex = 47;
            this.label5.Text = "Tipo Doc:";
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Location = new System.Drawing.Point(570, 232);
            this.cmbTipoDoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(78, 21);
            this.cmbTipoDoc.TabIndex = 5;
            // 
            // cmbDocEmpleado
            // 
            this.cmbDocEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDocEmpleado.FormattingEnabled = true;
            this.cmbDocEmpleado.ItemHeight = 13;
            this.cmbDocEmpleado.Location = new System.Drawing.Point(369, 232);
            this.cmbDocEmpleado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbDocEmpleado.Name = "cmbDocEmpleado";
            this.cmbDocEmpleado.Size = new System.Drawing.Size(116, 21);
            this.cmbDocEmpleado.TabIndex = 4;
            this.cmbDocEmpleado.SelectedIndexChanged += new System.EventHandler(this.cmbDocEmpleado_SelectedIndexChanged);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(369, 167);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFecha.Mask = "00/00/0000";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(76, 20);
            this.txtFecha.TabIndex = 3;
            this.txtFecha.ValidatingType = typeof(System.DateTime);
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.Color.White;
            this.labelFecha.Location = new System.Drawing.Point(305, 167);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(63, 21);
            this.labelFecha.TabIndex = 50;
            this.labelFecha.Text = "Fecha:";
            // 
            // grdEmpleado
            // 
            this.grdEmpleado.AllowUserToAddRows = false;
            this.grdEmpleado.AllowUserToDeleteRows = false;
            this.grdEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroDoc,
            this.tipoDoc,
            this.nombre,
            this.apellido});
            this.grdEmpleado.Location = new System.Drawing.Point(213, 288);
            this.grdEmpleado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grdEmpleado.Name = "grdEmpleado";
            this.grdEmpleado.ReadOnly = true;
            this.grdEmpleado.RowHeadersWidth = 51;
            this.grdEmpleado.RowTemplate.Height = 24;
            this.grdEmpleado.Size = new System.Drawing.Size(520, 122);
            this.grdEmpleado.TabIndex = 52;
            // 
            // NroDoc
            // 
            this.NroDoc.DataPropertyName = "nroDoc";
            this.NroDoc.HeaderText = "Nro Documento";
            this.NroDoc.MinimumWidth = 6;
            this.NroDoc.Name = "NroDoc";
            this.NroDoc.ReadOnly = true;
            this.NroDoc.Width = 125;
            // 
            // tipoDoc
            // 
            this.tipoDoc.DataPropertyName = "tipoDoc";
            this.tipoDoc.HeaderText = "Tipo Documento";
            this.tipoDoc.MinimumWidth = 6;
            this.tipoDoc.Name = "tipoDoc";
            this.tipoDoc.ReadOnly = true;
            this.tipoDoc.Width = 125;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 125;
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "apellido";
            this.apellido.HeaderText = "Apellido";
            this.apellido.MinimumWidth = 6;
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            this.apellido.Width = 125;
            // 
            // btnAgregarEmpleado
            // 
            this.btnAgregarEmpleado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnAgregarEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnAgregarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEmpleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEmpleado.ForeColor = System.Drawing.Color.LightGray;
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(671, 226);
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(197, 32);
            this.btnAgregarEmpleado.TabIndex = 6;
            this.btnAgregarEmpleado.Text = "Agregar Empleado";
            this.btnAgregarEmpleado.UseVisualStyleBackColor = true;
            this.btnAgregarEmpleado.Click += new System.EventHandler(this.btnAgregarEmpleado_Click);
            // 
            // btnGenerarAsistencia
            // 
            this.btnGenerarAsistencia.Enabled = false;
            this.btnGenerarAsistencia.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnGenerarAsistencia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnGenerarAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarAsistencia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarAsistencia.ForeColor = System.Drawing.Color.LightGray;
            this.btnGenerarAsistencia.Location = new System.Drawing.Point(748, 424);
            this.btnGenerarAsistencia.Name = "btnGenerarAsistencia";
            this.btnGenerarAsistencia.Size = new System.Drawing.Size(120, 56);
            this.btnGenerarAsistencia.TabIndex = 7;
            this.btnGenerarAsistencia.Text = "Generar Asistencia";
            this.btnGenerarAsistencia.UseVisualStyleBackColor = true;
            this.btnGenerarAsistencia.Click += new System.EventHandler(this.btnGenerarAsistencia_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::TPI.Properties.Resources.Minimize_Icon;
            this.btnMinimizar.Location = new System.Drawing.Point(819, 11);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(21, 22);
            this.btnMinimizar.TabIndex = 54;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::TPI.Properties.Resources.Close_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(848, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 22);
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnLimpiarGrilla
            // 
            this.btnLimpiarGrilla.Enabled = false;
            this.btnLimpiarGrilla.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnLimpiarGrilla.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnLimpiarGrilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarGrilla.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarGrilla.ForeColor = System.Drawing.Color.LightGray;
            this.btnLimpiarGrilla.Location = new System.Drawing.Point(613, 424);
            this.btnLimpiarGrilla.Name = "btnLimpiarGrilla";
            this.btnLimpiarGrilla.Size = new System.Drawing.Size(120, 56);
            this.btnLimpiarGrilla.TabIndex = 55;
            this.btnLimpiarGrilla.Text = "Limpiar Grilla";
            this.btnLimpiarGrilla.UseVisualStyleBackColor = true;
            this.btnLimpiarGrilla.Click += new System.EventHandler(this.btnLimpiarGrilla_Click);
            // 
            // Asistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(878, 491);
            this.Controls.Add(this.btnLimpiarGrilla);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGenerarAsistencia);
            this.Controls.Add(this.btnAgregarEmpleado);
            this.Controls.Add(this.grdEmpleado);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.cmbDocEmpleado);
            this.Controls.Add(this.cmbTipoDoc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbNombreTurno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCuitEstacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Asistencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asistencia";
            this.Load += new System.EventHandler(this.Asistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCuitEstacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbNombreTurno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTipoDoc;
        private System.Windows.Forms.ComboBox cmbDocEmpleado;
        private System.Windows.Forms.MaskedTextBox txtFecha;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.DataGridView grdEmpleado;
        private System.Windows.Forms.Button btnAgregarEmpleado;
        private System.Windows.Forms.Button btnGenerarAsistencia;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.Button btnLimpiarGrilla;
    }
}