
namespace TPI
{
    partial class AltaEstacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaEstacion));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.txtNroSuc = new System.Windows.Forms.TextBox();
            this.txtNombreSuc = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtNroCalle = new System.Windows.Forms.TextBox();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.txtNroDoc = new System.Windows.Forms.TextBox();
            this.gdrEstacion = new System.Windows.Forms.DataGridView();
            this.numSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuitEstacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calleNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCiudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroDocGerente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDocGerente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarEstacion = new System.Windows.Forms.Button();
            this.btnModificarEstacion = new System.Windows.Forms.Button();
            this.btnEliminarEstacion = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gdrEstacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(382, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alta de Estación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(351, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "C.U.I.T:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(248, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Número de Sucursal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(269, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre Sucursal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(354, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Calle:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(299, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nro de Calle:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(339, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ciudad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(239, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "Nro Doc del Gerente:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(232, 381);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 21);
            this.label9.TabIndex = 9;
            this.label9.Text = "Tipo Doc del Gerente: ";
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(419, 89);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(168, 20);
            this.txtCuit.TabIndex = 1;
            // 
            // txtNroSuc
            // 
            this.txtNroSuc.Location = new System.Drawing.Point(419, 132);
            this.txtNroSuc.Name = "txtNroSuc";
            this.txtNroSuc.Size = new System.Drawing.Size(168, 20);
            this.txtNroSuc.TabIndex = 2;
            // 
            // txtNombreSuc
            // 
            this.txtNombreSuc.Location = new System.Drawing.Point(419, 177);
            this.txtNombreSuc.Name = "txtNombreSuc";
            this.txtNombreSuc.Size = new System.Drawing.Size(168, 20);
            this.txtNombreSuc.TabIndex = 3;
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(419, 223);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(168, 20);
            this.txtCalle.TabIndex = 4;
            // 
            // txtNroCalle
            // 
            this.txtNroCalle.Location = new System.Drawing.Point(419, 258);
            this.txtNroCalle.Name = "txtNroCalle";
            this.txtNroCalle.Size = new System.Drawing.Size(168, 20);
            this.txtNroCalle.TabIndex = 5;
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(419, 295);
            this.cmbCiudad.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(168, 21);
            this.cmbCiudad.TabIndex = 6;
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Location = new System.Drawing.Point(419, 380);
            this.cmbTipoDoc.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(168, 21);
            this.cmbTipoDoc.TabIndex = 8;
            // 
            // txtNroDoc
            // 
            this.txtNroDoc.Location = new System.Drawing.Point(419, 335);
            this.txtNroDoc.Name = "txtNroDoc";
            this.txtNroDoc.Size = new System.Drawing.Size(168, 20);
            this.txtNroDoc.TabIndex = 7;
            // 
            // gdrEstacion
            // 
            this.gdrEstacion.AllowUserToAddRows = false;
            this.gdrEstacion.AllowUserToDeleteRows = false;
            this.gdrEstacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.gdrEstacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrEstacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numSucursal,
            this.cuitEstacion,
            this.nombre,
            this.calle,
            this.calleNro,
            this.idCiudad,
            this.nroDocGerente,
            this.tipoDocGerente});
            this.gdrEstacion.Location = new System.Drawing.Point(622, 72);
            this.gdrEstacion.Margin = new System.Windows.Forms.Padding(2);
            this.gdrEstacion.Name = "gdrEstacion";
            this.gdrEstacion.ReadOnly = true;
            this.gdrEstacion.RowHeadersWidth = 51;
            this.gdrEstacion.RowTemplate.Height = 24;
            this.gdrEstacion.Size = new System.Drawing.Size(649, 482);
            this.gdrEstacion.TabIndex = 18;
            this.gdrEstacion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrEstacion_CellClick);
            // 
            // numSucursal
            // 
            this.numSucursal.DataPropertyName = "numSucursal";
            this.numSucursal.HeaderText = "Numero Sucursal";
            this.numSucursal.MinimumWidth = 6;
            this.numSucursal.Name = "numSucursal";
            this.numSucursal.ReadOnly = true;
            this.numSucursal.Width = 125;
            // 
            // cuitEstacion
            // 
            this.cuitEstacion.DataPropertyName = "cuitEstacion";
            this.cuitEstacion.HeaderText = "C.U.I.T";
            this.cuitEstacion.MinimumWidth = 6;
            this.cuitEstacion.Name = "cuitEstacion";
            this.cuitEstacion.ReadOnly = true;
            this.cuitEstacion.Width = 125;
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
            // calle
            // 
            this.calle.DataPropertyName = "calle";
            this.calle.HeaderText = "Calle";
            this.calle.MinimumWidth = 6;
            this.calle.Name = "calle";
            this.calle.ReadOnly = true;
            this.calle.Width = 125;
            // 
            // calleNro
            // 
            this.calleNro.DataPropertyName = "calleNro";
            this.calleNro.HeaderText = "Nro Calle";
            this.calleNro.MinimumWidth = 6;
            this.calleNro.Name = "calleNro";
            this.calleNro.ReadOnly = true;
            this.calleNro.Width = 125;
            // 
            // idCiudad
            // 
            this.idCiudad.DataPropertyName = "idCiudad";
            this.idCiudad.HeaderText = "Id Ciudad";
            this.idCiudad.MinimumWidth = 6;
            this.idCiudad.Name = "idCiudad";
            this.idCiudad.ReadOnly = true;
            this.idCiudad.Width = 125;
            // 
            // nroDocGerente
            // 
            this.nroDocGerente.DataPropertyName = "nroDocGerente";
            this.nroDocGerente.HeaderText = "Documento Gerente";
            this.nroDocGerente.MinimumWidth = 6;
            this.nroDocGerente.Name = "nroDocGerente";
            this.nroDocGerente.ReadOnly = true;
            this.nroDocGerente.Width = 125;
            // 
            // tipoDocGerente
            // 
            this.tipoDocGerente.DataPropertyName = "tipoDocGerente";
            this.tipoDocGerente.HeaderText = "Tipo Documento Gerente";
            this.tipoDocGerente.MinimumWidth = 6;
            this.tipoDocGerente.Name = "tipoDocGerente";
            this.tipoDocGerente.ReadOnly = true;
            this.tipoDocGerente.Width = 125;
            // 
            // btnAgregarEstacion
            // 
            this.btnAgregarEstacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.btnAgregarEstacion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnAgregarEstacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnAgregarEstacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEstacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEstacion.ForeColor = System.Drawing.Color.LightGray;
            this.btnAgregarEstacion.Location = new System.Drawing.Point(498, 424);
            this.btnAgregarEstacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarEstacion.Name = "btnAgregarEstacion";
            this.btnAgregarEstacion.Size = new System.Drawing.Size(120, 60);
            this.btnAgregarEstacion.TabIndex = 19;
            this.btnAgregarEstacion.Text = "Guardar Estación";
            this.btnAgregarEstacion.UseVisualStyleBackColor = false;
            this.btnAgregarEstacion.Click += new System.EventHandler(this.btnAgregarEstacion_Click);
            // 
            // btnModificarEstacion
            // 
            this.btnModificarEstacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.btnModificarEstacion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnModificarEstacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnModificarEstacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarEstacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarEstacion.ForeColor = System.Drawing.Color.LightGray;
            this.btnModificarEstacion.Location = new System.Drawing.Point(360, 424);
            this.btnModificarEstacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarEstacion.Name = "btnModificarEstacion";
            this.btnModificarEstacion.Size = new System.Drawing.Size(120, 60);
            this.btnModificarEstacion.TabIndex = 20;
            this.btnModificarEstacion.Text = "Actualizar Estación";
            this.btnModificarEstacion.UseVisualStyleBackColor = false;
            this.btnModificarEstacion.Click += new System.EventHandler(this.btnModificarEstacion_Click);
            // 
            // btnEliminarEstacion
            // 
            this.btnEliminarEstacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.btnEliminarEstacion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnEliminarEstacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnEliminarEstacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarEstacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEstacion.ForeColor = System.Drawing.Color.LightGray;
            this.btnEliminarEstacion.Location = new System.Drawing.Point(239, 494);
            this.btnEliminarEstacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarEstacion.Name = "btnEliminarEstacion";
            this.btnEliminarEstacion.Size = new System.Drawing.Size(120, 60);
            this.btnEliminarEstacion.TabIndex = 21;
            this.btnEliminarEstacion.Text = "Eliminar Estación";
            this.btnEliminarEstacion.UseVisualStyleBackColor = false;
            this.btnEliminarEstacion.Click += new System.EventHandler(this.btnEliminarEstacion_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.btnLimpiarCampos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnLimpiarCampos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.ForeColor = System.Drawing.Color.LightGray;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(239, 424);
            this.btnLimpiarCampos.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(120, 60);
            this.btnLimpiarCampos.TabIndex = 22;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 585);
            this.panel1.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::TPI.Properties.Resources.Close_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(1250, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 22);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::TPI.Properties.Resources.Minimize_Icon;
            this.btnMinimizar.Location = new System.Drawing.Point(1222, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(21, 22);
            this.btnMinimizar.TabIndex = 24;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // AltaEstacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1283, 585);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnEliminarEstacion);
            this.Controls.Add(this.btnModificarEstacion);
            this.Controls.Add(this.btnAgregarEstacion);
            this.Controls.Add(this.gdrEstacion);
            this.Controls.Add(this.txtNroDoc);
            this.Controls.Add(this.cmbTipoDoc);
            this.Controls.Add(this.cmbCiudad);
            this.Controls.Add(this.txtNroCalle);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.txtNombreSuc);
            this.Controls.Add(this.txtNroSuc);
            this.Controls.Add(this.txtCuit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AltaEstacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Estación";
            this.Load += new System.EventHandler(this.AltaEstacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdrEstacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.TextBox txtNroSuc;
        private System.Windows.Forms.TextBox txtNombreSuc;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.TextBox txtNroCalle;
        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.ComboBox cmbTipoDoc;
        private System.Windows.Forms.TextBox txtNroDoc;
        private System.Windows.Forms.DataGridView gdrEstacion;
        private System.Windows.Forms.Button btnAgregarEstacion;
        private System.Windows.Forms.Button btnModificarEstacion;
        private System.Windows.Forms.Button btnEliminarEstacion;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuitEstacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn calleNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCiudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroDocGerente;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDocGerente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnMinimizar;
    }
}