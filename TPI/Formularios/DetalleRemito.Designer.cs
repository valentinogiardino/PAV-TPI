
namespace TPI
{
    partial class DetalleRemito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalleRemito));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.gdrDetalleRemito = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.idCombustible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantLitrosCombustible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioXLitro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCUIT = new System.Windows.Forms.Label();
            this.lblRemito = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdrDetalleRemito)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(272, 543);
            this.panel1.TabIndex = 16;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::TPI.Properties.Resources.Minimize_Icon;
            this.btnMinimizar.Location = new System.Drawing.Point(865, 0);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(28, 27);
            this.btnMinimizar.TabIndex = 19;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::TPI.Properties.Resources.Close_Icon;
            this.btnCerrar.Location = new System.Drawing.Point(899, 0);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(28, 27);
            this.btnCerrar.TabIndex = 18;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // gdrDetalleRemito
            // 
            this.gdrDetalleRemito.AllowUserToAddRows = false;
            this.gdrDetalleRemito.AllowUserToDeleteRows = false;
            this.gdrDetalleRemito.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.gdrDetalleRemito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrDetalleRemito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCombustible,
            this.cantLitrosCombustible,
            this.precioXLitro});
            this.gdrDetalleRemito.Location = new System.Drawing.Point(379, 153);
            this.gdrDetalleRemito.Name = "gdrDetalleRemito";
            this.gdrDetalleRemito.ReadOnly = true;
            this.gdrDetalleRemito.RowHeadersWidth = 51;
            this.gdrDetalleRemito.RowTemplate.Height = 24;
            this.gdrDetalleRemito.Size = new System.Drawing.Size(429, 390);
            this.gdrDetalleRemito.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(280, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 37);
            this.label1.TabIndex = 21;
            this.label1.Text = "Detalle Remito";
            // 
            // idCombustible
            // 
            this.idCombustible.DataPropertyName = "idCombustible";
            this.idCombustible.HeaderText = "ID Combustible";
            this.idCombustible.MinimumWidth = 6;
            this.idCombustible.Name = "idCombustible";
            this.idCombustible.ReadOnly = true;
            this.idCombustible.Width = 125;
            // 
            // cantLitrosCombustible
            // 
            this.cantLitrosCombustible.DataPropertyName = "cantLitrosCombustible";
            this.cantLitrosCombustible.HeaderText = "Cantidad de litros por Combustible";
            this.cantLitrosCombustible.MinimumWidth = 6;
            this.cantLitrosCombustible.Name = "cantLitrosCombustible";
            this.cantLitrosCombustible.ReadOnly = true;
            this.cantLitrosCombustible.Width = 125;
            // 
            // precioXLitro
            // 
            this.precioXLitro.DataPropertyName = "precioXLitro";
            this.precioXLitro.HeaderText = "Precio por Litro";
            this.precioXLitro.MinimumWidth = 6;
            this.precioXLitro.Name = "precioXLitro";
            this.precioXLitro.ReadOnly = true;
            this.precioXLitro.Width = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(280, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 23);
            this.label5.TabIndex = 22;
            this.label5.Text = "Cuit Estacion:";
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCUIT.ForeColor = System.Drawing.Color.White;
            this.lblCUIT.Location = new System.Drawing.Point(428, 79);
            this.lblCUIT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(52, 23);
            this.lblCUIT.TabIndex = 23;
            this.lblCUIT.Text = "CUIT";
            // 
            // lblRemito
            // 
            this.lblRemito.AutoSize = true;
            this.lblRemito.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemito.ForeColor = System.Drawing.Color.White;
            this.lblRemito.Location = new System.Drawing.Point(457, 117);
            this.lblRemito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemito.Name = "lblRemito";
            this.lblRemito.Size = new System.Drawing.Size(80, 23);
            this.lblRemito.TabIndex = 25;
            this.lblRemito.Text = "REMITO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(283, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "Numero Remito:";
            // 
            // DetalleRemito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(931, 543);
            this.Controls.Add(this.lblRemito);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCUIT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gdrDetalleRemito);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DetalleRemito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetalleRemito";
            this.Load += new System.EventHandler(this.DetalleRemito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdrDetalleRemito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.DataGridView gdrDetalleRemito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCombustible;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantLitrosCombustible;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioXLitro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.Label lblRemito;
        private System.Windows.Forms.Label label3;
    }
}