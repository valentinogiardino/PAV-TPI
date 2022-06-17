
namespace TPI.Formularios
{
    partial class Remitos
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerarRemito = new System.Windows.Forms.Button();
            this.grdRemitosExistentes = new System.Windows.Forms.DataGridView();
            this.numRemito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuitEstacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCuitEstacion = new System.Windows.Forms.TextBox();
            this.txtNumRemito = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdRemitosExistentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(228, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 30);
            this.label1.TabIndex = 18;
            this.label1.Text = "Remitos";
            // 
            // btnGenerarRemito
            // 
            this.btnGenerarRemito.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnGenerarRemito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnGenerarRemito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarRemito.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarRemito.ForeColor = System.Drawing.Color.LightGray;
            this.btnGenerarRemito.Location = new System.Drawing.Point(460, 370);
            this.btnGenerarRemito.Name = "btnGenerarRemito";
            this.btnGenerarRemito.Size = new System.Drawing.Size(100, 60);
            this.btnGenerarRemito.TabIndex = 22;
            this.btnGenerarRemito.Text = "Generar remito";
            this.btnGenerarRemito.UseVisualStyleBackColor = true;
            this.btnGenerarRemito.Click += new System.EventHandler(this.btnGenerarRemito_Click);
            // 
            // grdRemitosExistentes
            // 
            this.grdRemitosExistentes.AllowUserToAddRows = false;
            this.grdRemitosExistentes.AllowUserToDeleteRows = false;
            this.grdRemitosExistentes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.grdRemitosExistentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRemitosExistentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numRemito,
            this.cuitEstacion,
            this.fecha,
            this.patente});
            this.grdRemitosExistentes.Location = new System.Drawing.Point(217, 59);
            this.grdRemitosExistentes.Margin = new System.Windows.Forms.Padding(2);
            this.grdRemitosExistentes.Name = "grdRemitosExistentes";
            this.grdRemitosExistentes.ReadOnly = true;
            this.grdRemitosExistentes.RowHeadersWidth = 51;
            this.grdRemitosExistentes.RowTemplate.Height = 24;
            this.grdRemitosExistentes.Size = new System.Drawing.Size(472, 306);
            this.grdRemitosExistentes.TabIndex = 23;
            this.grdRemitosExistentes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdRemitosExistentes_CellContentClick);
            // 
            // numRemito
            // 
            this.numRemito.DataPropertyName = "numRemito";
            this.numRemito.HeaderText = "Numero Remito";
            this.numRemito.MinimumWidth = 6;
            this.numRemito.Name = "numRemito";
            this.numRemito.ReadOnly = true;
            this.numRemito.Width = 150;
            // 
            // cuitEstacion
            // 
            this.cuitEstacion.DataPropertyName = "cuitEstacion";
            this.cuitEstacion.HeaderText = "Cuit Estación";
            this.cuitEstacion.MinimumWidth = 6;
            this.cuitEstacion.Name = "cuitEstacion";
            this.cuitEstacion.ReadOnly = true;
            this.cuitEstacion.Width = 150;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "Fecha ";
            this.fecha.MinimumWidth = 6;
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 125;
            // 
            // patente
            // 
            this.patente.DataPropertyName = "patente";
            this.patente.HeaderText = "Patente Camión";
            this.patente.MinimumWidth = 6;
            this.patente.Name = "patente";
            this.patente.ReadOnly = true;
            this.patente.Width = 150;
            // 
            // btnDetalle
            // 
            this.btnDetalle.Enabled = false;
            this.btnDetalle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnDetalle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalle.ForeColor = System.Drawing.Color.LightGray;
            this.btnDetalle.Location = new System.Drawing.Point(583, 370);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(100, 60);
            this.btnDetalle.TabIndex = 24;
            this.btnDetalle.Text = "Ver detalle remito";
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::TPI.Properties.Resources.Minimize_Icon;
            this.btnMinimizar.Location = new System.Drawing.Point(638, 7);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(21, 22);
            this.btnMinimizar.TabIndex = 17;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::TPI.Properties.Resources.Close_Icon;
            this.btnCerrar.Location = new System.Drawing.Point(663, 7);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(21, 22);
            this.btnCerrar.TabIndex = 16;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.panel1.BackgroundImage = global::TPI.Properties.Resources.descarga;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.txtCuitEstacion);
            this.panel1.Controls.Add(this.txtNumRemito);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 441);
            this.panel1.TabIndex = 15;
            // 
            // txtCuitEstacion
            // 
            this.txtCuitEstacion.Enabled = false;
            this.txtCuitEstacion.Location = new System.Drawing.Point(125, 20);
            this.txtCuitEstacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtCuitEstacion.Name = "txtCuitEstacion";
            this.txtCuitEstacion.Size = new System.Drawing.Size(76, 20);
            this.txtCuitEstacion.TabIndex = 26;
            this.txtCuitEstacion.Visible = false;
            // 
            // txtNumRemito
            // 
            this.txtNumRemito.Enabled = false;
            this.txtNumRemito.Location = new System.Drawing.Point(25, 20);
            this.txtNumRemito.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumRemito.Name = "txtNumRemito";
            this.txtNumRemito.Size = new System.Drawing.Size(76, 20);
            this.txtNumRemito.TabIndex = 25;
            this.txtNumRemito.Visible = false;
            // 
            // btnCargar
            // 
            this.btnCargar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnCargar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.Color.LightGray;
            this.btnCargar.Location = new System.Drawing.Point(344, 370);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(100, 60);
            this.btnCargar.TabIndex = 25;
            this.btnCargar.Text = "Recargar Remitos";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // Remitos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(698, 441);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.grdRemitosExistentes);
            this.Controls.Add(this.btnGenerarRemito);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Remitos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remitos";
            this.Load += new System.EventHandler(this.Remitos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdRemitosExistentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerarRemito;
        private System.Windows.Forms.DataGridView grdRemitosExistentes;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.TextBox txtNumRemito;
        private System.Windows.Forms.TextBox txtCuitEstacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn numRemito;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuitEstacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn patente;
        private System.Windows.Forms.Button btnCargar;
    }
}