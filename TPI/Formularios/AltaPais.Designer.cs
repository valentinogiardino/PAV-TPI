
namespace TPI
{
    partial class AltaPais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaPais));
            this.txtNombrePais = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grdPais = new System.Windows.Forms.DataGridView();
            this.IdPais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpiarDatos = new System.Windows.Forms.Button();
            this.btnActualizarPais = new System.Windows.Forms.Button();
            this.btnGuardarPais = new System.Windows.Forms.Button();
            this.btnBorrarPais = new System.Windows.Forms.Button();
            this.txtIdDelPais = new System.Windows.Forms.TextBox();
            this.labelIdDelPais = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdPais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombrePais
            // 
            this.txtNombrePais.Location = new System.Drawing.Point(397, 93);
            this.txtNombrePais.Name = "txtNombrePais";
            this.txtNombrePais.Size = new System.Drawing.Size(168, 20);
            this.txtNombrePais.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(257, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre del País:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(413, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Alta de País";
            // 
            // grdPais
            // 
            this.grdPais.AllowUserToAddRows = false;
            this.grdPais.AllowUserToDeleteRows = false;
            this.grdPais.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.grdPais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPais,
            this.Nombre});
            this.grdPais.Location = new System.Drawing.Point(614, 50);
            this.grdPais.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grdPais.Name = "grdPais";
            this.grdPais.ReadOnly = true;
            this.grdPais.RowHeadersWidth = 51;
            this.grdPais.RowTemplate.Height = 24;
            this.grdPais.Size = new System.Drawing.Size(295, 290);
            this.grdPais.TabIndex = 6;
            this.grdPais.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPais_CellClick);
            // 
            // IdPais
            // 
            this.IdPais.DataPropertyName = "idPais";
            this.IdPais.HeaderText = "IdPais";
            this.IdPais.MinimumWidth = 6;
            this.IdPais.Name = "IdPais";
            this.IdPais.ReadOnly = true;
            this.IdPais.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 250;
            // 
            // btnLimpiarDatos
            // 
            this.btnLimpiarDatos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnLimpiarDatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnLimpiarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarDatos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarDatos.ForeColor = System.Drawing.Color.LightGray;
            this.btnLimpiarDatos.Location = new System.Drawing.Point(223, 186);
            this.btnLimpiarDatos.Name = "btnLimpiarDatos";
            this.btnLimpiarDatos.Size = new System.Drawing.Size(100, 60);
            this.btnLimpiarDatos.TabIndex = 7;
            this.btnLimpiarDatos.Text = "Limpiar Campos";
            this.btnLimpiarDatos.UseVisualStyleBackColor = true;
            this.btnLimpiarDatos.Click += new System.EventHandler(this.btnLimpiarDatos_Click);
            // 
            // btnActualizarPais
            // 
            this.btnActualizarPais.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnActualizarPais.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnActualizarPais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarPais.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarPais.ForeColor = System.Drawing.Color.LightGray;
            this.btnActualizarPais.Location = new System.Drawing.Point(351, 186);
            this.btnActualizarPais.Name = "btnActualizarPais";
            this.btnActualizarPais.Size = new System.Drawing.Size(100, 60);
            this.btnActualizarPais.TabIndex = 8;
            this.btnActualizarPais.Text = "Actualizar";
            this.btnActualizarPais.UseVisualStyleBackColor = true;
            this.btnActualizarPais.Click += new System.EventHandler(this.buttonActualizarPaís_Click);
            // 
            // btnGuardarPais
            // 
            this.btnGuardarPais.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnGuardarPais.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnGuardarPais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPais.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPais.ForeColor = System.Drawing.Color.LightGray;
            this.btnGuardarPais.Location = new System.Drawing.Point(477, 186);
            this.btnGuardarPais.Name = "btnGuardarPais";
            this.btnGuardarPais.Size = new System.Drawing.Size(100, 60);
            this.btnGuardarPais.TabIndex = 9;
            this.btnGuardarPais.Text = "Guardar ";
            this.btnGuardarPais.UseVisualStyleBackColor = true;
            this.btnGuardarPais.Click += new System.EventHandler(this.buttonGuardarPais_Click);
            // 
            // btnBorrarPais
            // 
            this.btnBorrarPais.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnBorrarPais.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnBorrarPais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarPais.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarPais.ForeColor = System.Drawing.Color.LightGray;
            this.btnBorrarPais.Location = new System.Drawing.Point(223, 268);
            this.btnBorrarPais.Name = "btnBorrarPais";
            this.btnBorrarPais.Size = new System.Drawing.Size(100, 60);
            this.btnBorrarPais.TabIndex = 10;
            this.btnBorrarPais.Text = "Borrar País";
            this.btnBorrarPais.UseVisualStyleBackColor = true;
            this.btnBorrarPais.Click += new System.EventHandler(this.btnBorrarPais_Click);
            // 
            // txtIdDelPais
            // 
            this.txtIdDelPais.Enabled = false;
            this.txtIdDelPais.Location = new System.Drawing.Point(397, 62);
            this.txtIdDelPais.Name = "txtIdDelPais";
            this.txtIdDelPais.Size = new System.Drawing.Size(168, 20);
            this.txtIdDelPais.TabIndex = 16;
            this.txtIdDelPais.Visible = false;
            // 
            // labelIdDelPais
            // 
            this.labelIdDelPais.AutoSize = true;
            this.labelIdDelPais.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdDelPais.ForeColor = System.Drawing.Color.White;
            this.labelIdDelPais.Location = new System.Drawing.Point(303, 62);
            this.labelIdDelPais.Name = "labelIdDelPais";
            this.labelIdDelPais.Size = new System.Drawing.Size(91, 21);
            this.labelIdDelPais.TabIndex = 15;
            this.labelIdDelPais.Text = "Id del País:";
            this.labelIdDelPais.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.panel1.BackgroundImage = global::TPI.Properties.Resources.descarga;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 379);
            this.panel1.TabIndex = 14;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::TPI.Properties.Resources.Minimize_Icon;
            this.btnMinimizar.Location = new System.Drawing.Point(860, 11);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(21, 22);
            this.btnMinimizar.TabIndex = 13;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click_1);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::TPI.Properties.Resources.Close_Icon;
            this.btnCerrar.Location = new System.Drawing.Point(886, 11);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(21, 22);
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // AltaPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(917, 379);
            this.Controls.Add(this.txtIdDelPais);
            this.Controls.Add(this.labelIdDelPais);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnBorrarPais);
            this.Controls.Add(this.btnGuardarPais);
            this.Controls.Add(this.btnActualizarPais);
            this.Controls.Add(this.btnLimpiarDatos);
            this.Controls.Add(this.grdPais);
            this.Controls.Add(this.txtNombrePais);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AltaPais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de País";
            this.Load += new System.EventHandler(this.AltaPais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombrePais;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdPais;
        private System.Windows.Forms.Button btnLimpiarDatos;
        private System.Windows.Forms.Button btnActualizarPais;
        private System.Windows.Forms.Button btnGuardarPais;
        private System.Windows.Forms.Button btnBorrarPais;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtIdDelPais;
        private System.Windows.Forms.Label labelIdDelPais;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPais;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}