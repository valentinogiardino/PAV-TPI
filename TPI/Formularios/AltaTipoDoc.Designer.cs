
namespace TPI
{
    partial class AltaTipoDoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaTipoDoc));
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.txtAgregarTipoDoc = new System.Windows.Forms.TextBox();
            this.grillaTipoDoc = new System.Windows.Forms.DataGridView();
            this.tipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreTipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblnombre = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblIdTipoDoc = new System.Windows.Forms.Label();
            this.txtIdTipoDoc = new System.Windows.Forms.TextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.pnlYpf = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTipoDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDoc.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTipoDoc.Location = new System.Drawing.Point(237, 24);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(250, 30);
            this.lblTipoDoc.TabIndex = 1;
            this.lblTipoDoc.Text = "Tipo de documento";
            // 
            // txtAgregarTipoDoc
            // 
            this.txtAgregarTipoDoc.Location = new System.Drawing.Point(444, 138);
            this.txtAgregarTipoDoc.Margin = new System.Windows.Forms.Padding(2);
            this.txtAgregarTipoDoc.Name = "txtAgregarTipoDoc";
            this.txtAgregarTipoDoc.Size = new System.Drawing.Size(124, 20);
            this.txtAgregarTipoDoc.TabIndex = 2;
            // 
            // grillaTipoDoc
            // 
            this.grillaTipoDoc.AllowUserToAddRows = false;
            this.grillaTipoDoc.AllowUserToDeleteRows = false;
            this.grillaTipoDoc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.grillaTipoDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaTipoDoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipoDoc,
            this.nombreTipoDoc});
            this.grillaTipoDoc.Location = new System.Drawing.Point(572, 54);
            this.grillaTipoDoc.Margin = new System.Windows.Forms.Padding(2);
            this.grillaTipoDoc.Name = "grillaTipoDoc";
            this.grillaTipoDoc.ReadOnly = true;
            this.grillaTipoDoc.RowHeadersWidth = 51;
            this.grillaTipoDoc.RowTemplate.Height = 24;
            this.grillaTipoDoc.Size = new System.Drawing.Size(280, 341);
            this.grillaTipoDoc.TabIndex = 3;
            this.grillaTipoDoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaTipoDoc_CellContentClick);
            // 
            // tipoDoc
            // 
            this.tipoDoc.DataPropertyName = "tipoDoc";
            this.tipoDoc.HeaderText = "ID";
            this.tipoDoc.MinimumWidth = 6;
            this.tipoDoc.Name = "tipoDoc";
            this.tipoDoc.ReadOnly = true;
            this.tipoDoc.Width = 90;
            // 
            // nombreTipoDoc
            // 
            this.nombreTipoDoc.DataPropertyName = "nombre";
            this.nombreTipoDoc.HeaderText = "Nombre";
            this.nombreTipoDoc.MinimumWidth = 6;
            this.nombreTipoDoc.Name = "nombreTipoDoc";
            this.nombreTipoDoc.ReadOnly = true;
            this.nombreTipoDoc.Width = 200;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.ForeColor = System.Drawing.Color.Snow;
            this.lblnombre.Location = new System.Drawing.Point(198, 138);
            this.lblnombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(234, 21);
            this.lblnombre.TabIndex = 6;
            this.lblnombre.Text = "Nombre tipo de documento:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.LightGray;
            this.btnAgregar.Location = new System.Drawing.Point(444, 253);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 60);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Guardar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.btnActualizar.Enabled = false;
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.LightGray;
            this.btnActualizar.Location = new System.Drawing.Point(328, 253);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(100, 60);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblIdTipoDoc
            // 
            this.lblIdTipoDoc.AutoSize = true;
            this.lblIdTipoDoc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdTipoDoc.ForeColor = System.Drawing.Color.Snow;
            this.lblIdTipoDoc.Location = new System.Drawing.Point(243, 107);
            this.lblIdTipoDoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdTipoDoc.Name = "lblIdTipoDoc";
            this.lblIdTipoDoc.Size = new System.Drawing.Size(189, 21);
            this.lblIdTipoDoc.TabIndex = 9;
            this.lblIdTipoDoc.Text = "ID Tipo de documento:";
            // 
            // txtIdTipoDoc
            // 
            this.txtIdTipoDoc.Enabled = false;
            this.txtIdTipoDoc.Location = new System.Drawing.Point(444, 110);
            this.txtIdTipoDoc.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdTipoDoc.Name = "txtIdTipoDoc";
            this.txtIdTipoDoc.Size = new System.Drawing.Size(124, 20);
            this.txtIdTipoDoc.TabIndex = 10;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.btnBorrar.Enabled = false;
            this.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnBorrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.LightGray;
            this.btnBorrar.Location = new System.Drawing.Point(202, 335);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(100, 60);
            this.btnBorrar.TabIndex = 11;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // pnlYpf
            // 
            this.pnlYpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.pnlYpf.BackgroundImage = global::TPI.Properties.Resources.descarga;
            this.pnlYpf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlYpf.Location = new System.Drawing.Point(-3, -63);
            this.pnlYpf.Name = "pnlYpf";
            this.pnlYpf.Size = new System.Drawing.Size(196, 484);
            this.pnlYpf.TabIndex = 12;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::TPI.Properties.Resources.Minimize_Icon;
            this.btnMinimizar.Location = new System.Drawing.Point(799, 11);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(21, 22);
            this.btnMinimizar.TabIndex = 20;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::TPI.Properties.Resources.Close_Icon;
            this.btnCerrar.Location = new System.Drawing.Point(826, 11);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(21, 22);
            this.btnCerrar.TabIndex = 19;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(202, 253);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 60);
            this.button1.TabIndex = 21;
            this.button1.Text = "Limpiar Campos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AltaTipoDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(867, 406);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.pnlYpf);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.txtIdTipoDoc);
            this.Controls.Add(this.lblIdTipoDoc);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.grillaTipoDoc);
            this.Controls.Add(this.txtAgregarTipoDoc);
            this.Controls.Add(this.lblTipoDoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AltaTipoDoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo Documento";
            this.Load += new System.EventHandler(this.TipoDoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaTipoDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.TextBox txtAgregarTipoDoc;
        private System.Windows.Forms.DataGridView grillaTipoDoc;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblIdTipoDoc;
        private System.Windows.Forms.TextBox txtIdTipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreTipoDoc;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Panel pnlYpf;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Button button1;
    }
}