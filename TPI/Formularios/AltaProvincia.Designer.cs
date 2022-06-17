
namespace TPI
{
    partial class AltaProvincia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaProvincia));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIdProvincia = new System.Windows.Forms.TextBox();
            this.labelIdDeLaProvincia = new System.Windows.Forms.Label();
            this.btnBorrarProvincia = new System.Windows.Forms.Button();
            this.btnGuardarProvincia = new System.Windows.Forms.Button();
            this.btnActualizarProvincia = new System.Windows.Forms.Button();
            this.btnLimpiarDatos = new System.Windows.Forms.Button();
            this.grdProvincia = new System.Windows.Forms.DataGridView();
            this.IdProvincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombreProvincia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdProvincia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(204, 375);
            this.panel1.TabIndex = 15;
            // 
            // txtIdProvincia
            // 
            this.txtIdProvincia.Enabled = false;
            this.txtIdProvincia.Location = new System.Drawing.Point(398, 53);
            this.txtIdProvincia.Name = "txtIdProvincia";
            this.txtIdProvincia.Size = new System.Drawing.Size(168, 20);
            this.txtIdProvincia.TabIndex = 26;
            this.txtIdProvincia.Visible = false;
            // 
            // labelIdDeLaProvincia
            // 
            this.labelIdDeLaProvincia.AutoSize = true;
            this.labelIdDeLaProvincia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdDeLaProvincia.ForeColor = System.Drawing.Color.White;
            this.labelIdDeLaProvincia.Location = new System.Drawing.Point(251, 53);
            this.labelIdDeLaProvincia.Name = "labelIdDeLaProvincia";
            this.labelIdDeLaProvincia.Size = new System.Drawing.Size(148, 21);
            this.labelIdDeLaProvincia.TabIndex = 25;
            this.labelIdDeLaProvincia.Text = "Id de la Provincia:";
            this.labelIdDeLaProvincia.Visible = false;
            // 
            // btnBorrarProvincia
            // 
            this.btnBorrarProvincia.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnBorrarProvincia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnBorrarProvincia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarProvincia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarProvincia.ForeColor = System.Drawing.Color.LightGray;
            this.btnBorrarProvincia.Location = new System.Drawing.Point(229, 288);
            this.btnBorrarProvincia.Name = "btnBorrarProvincia";
            this.btnBorrarProvincia.Size = new System.Drawing.Size(100, 60);
            this.btnBorrarProvincia.TabIndex = 24;
            this.btnBorrarProvincia.Text = "Borrar Provincia";
            this.btnBorrarProvincia.UseVisualStyleBackColor = true;
            this.btnBorrarProvincia.Click += new System.EventHandler(this.btnBorrarProvincia_Click);
            // 
            // btnGuardarProvincia
            // 
            this.btnGuardarProvincia.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnGuardarProvincia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnGuardarProvincia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarProvincia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarProvincia.ForeColor = System.Drawing.Color.LightGray;
            this.btnGuardarProvincia.Location = new System.Drawing.Point(482, 195);
            this.btnGuardarProvincia.Name = "btnGuardarProvincia";
            this.btnGuardarProvincia.Size = new System.Drawing.Size(100, 60);
            this.btnGuardarProvincia.TabIndex = 23;
            this.btnGuardarProvincia.Text = "Guardar ";
            this.btnGuardarProvincia.UseVisualStyleBackColor = true;
            this.btnGuardarProvincia.Click += new System.EventHandler(this.btnGuardarProvincia_Click);
            // 
            // btnActualizarProvincia
            // 
            this.btnActualizarProvincia.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnActualizarProvincia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnActualizarProvincia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarProvincia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarProvincia.ForeColor = System.Drawing.Color.LightGray;
            this.btnActualizarProvincia.Location = new System.Drawing.Point(356, 195);
            this.btnActualizarProvincia.Name = "btnActualizarProvincia";
            this.btnActualizarProvincia.Size = new System.Drawing.Size(100, 60);
            this.btnActualizarProvincia.TabIndex = 22;
            this.btnActualizarProvincia.Text = "Actualizar ";
            this.btnActualizarProvincia.UseVisualStyleBackColor = true;
            this.btnActualizarProvincia.Click += new System.EventHandler(this.btnActualizarProvincia_Click);
            // 
            // btnLimpiarDatos
            // 
            this.btnLimpiarDatos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnLimpiarDatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnLimpiarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarDatos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarDatos.ForeColor = System.Drawing.Color.LightGray;
            this.btnLimpiarDatos.Location = new System.Drawing.Point(229, 195);
            this.btnLimpiarDatos.Name = "btnLimpiarDatos";
            this.btnLimpiarDatos.Size = new System.Drawing.Size(100, 60);
            this.btnLimpiarDatos.TabIndex = 21;
            this.btnLimpiarDatos.Text = "Limpiar";
            this.btnLimpiarDatos.UseVisualStyleBackColor = true;
            this.btnLimpiarDatos.Click += new System.EventHandler(this.btnLimpiarDatos_Click);
            // 
            // grdProvincia
            // 
            this.grdProvincia.AllowUserToAddRows = false;
            this.grdProvincia.AllowUserToDeleteRows = false;
            this.grdProvincia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.grdProvincia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProvincia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProvincia,
            this.Nombre,
            this.nombrePais});
            this.grdProvincia.Location = new System.Drawing.Point(614, 53);
            this.grdProvincia.Margin = new System.Windows.Forms.Padding(2);
            this.grdProvincia.Name = "grdProvincia";
            this.grdProvincia.ReadOnly = true;
            this.grdProvincia.RowHeadersWidth = 51;
            this.grdProvincia.RowTemplate.Height = 24;
            this.grdProvincia.Size = new System.Drawing.Size(295, 290);
            this.grdProvincia.TabIndex = 20;
            this.grdProvincia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProvincia_CellClick);
            // 
            // IdProvincia
            // 
            this.IdProvincia.DataPropertyName = "idProvincia";
            this.IdProvincia.HeaderText = "IdProvincia";
            this.IdProvincia.MinimumWidth = 6;
            this.IdProvincia.Name = "IdProvincia";
            this.IdProvincia.ReadOnly = true;
            this.IdProvincia.Width = 80;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 130;
            // 
            // nombrePais
            // 
            this.nombrePais.DataPropertyName = "idPais";
            this.nombrePais.HeaderText = "País";
            this.nombrePais.MinimumWidth = 6;
            this.nombrePais.Name = "nombrePais";
            this.nombrePais.ReadOnly = true;
            this.nombrePais.Width = 130;
            // 
            // txtNombreProvincia
            // 
            this.txtNombreProvincia.Location = new System.Drawing.Point(398, 84);
            this.txtNombreProvincia.Name = "txtNombreProvincia";
            this.txtNombreProvincia.Size = new System.Drawing.Size(168, 20);
            this.txtNombreProvincia.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(206, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nombre de la Provincia:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(393, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 30);
            this.label1.TabIndex = 17;
            this.label1.Text = "Alta de Provincia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(351, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 21);
            this.label3.TabIndex = 27;
            this.label3.Text = "País:";
            // 
            // cmbPais
            // 
            this.cmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(398, 114);
            this.cmbPais.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(168, 21);
            this.cmbPais.TabIndex = 28;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::TPI.Properties.Resources.Minimize_Icon;
            this.btnMinimizar.Location = new System.Drawing.Point(868, 5);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(21, 22);
            this.btnMinimizar.TabIndex = 30;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::TPI.Properties.Resources.Close_Icon;
            this.btnCerrar.Location = new System.Drawing.Point(895, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(21, 22);
            this.btnCerrar.TabIndex = 29;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // AltaProvincia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(918, 375);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.cmbPais);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdProvincia);
            this.Controls.Add(this.labelIdDeLaProvincia);
            this.Controls.Add(this.btnBorrarProvincia);
            this.Controls.Add(this.btnGuardarProvincia);
            this.Controls.Add(this.btnActualizarProvincia);
            this.Controls.Add(this.btnLimpiarDatos);
            this.Controls.Add(this.grdProvincia);
            this.Controls.Add(this.txtNombreProvincia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AltaProvincia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaProvincia";
            this.Load += new System.EventHandler(this.AltaProvincia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdProvincia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtIdProvincia;
        private System.Windows.Forms.Label labelIdDeLaProvincia;
        private System.Windows.Forms.Button btnBorrarProvincia;
        private System.Windows.Forms.Button btnGuardarProvincia;
        private System.Windows.Forms.Button btnActualizarProvincia;
        private System.Windows.Forms.Button btnLimpiarDatos;
        private System.Windows.Forms.DataGridView grdProvincia;
        private System.Windows.Forms.TextBox txtNombreProvincia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProvincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePais;
    }
}