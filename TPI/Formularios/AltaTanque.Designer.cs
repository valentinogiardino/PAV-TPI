
namespace TPI
{
    partial class AltaTanque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaTanque));
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumeroTanque = new System.Windows.Forms.Label();
            this.txtNumeroTanque = new System.Windows.Forms.TextBox();
            this.lblCuitEstacion = new System.Windows.Forms.Label();
            this.txtVolMaximo = new System.Windows.Forms.TextBox();
            this.lblVolMax = new System.Windows.Forms.Label();
            this.txtMinLit = new System.Windows.Forms.TextBox();
            this.lblMinLit = new System.Windows.Forms.Label();
            this.lblIdCombustible = new System.Windows.Forms.Label();
            this.txtVolDisponible = new System.Windows.Forms.TextBox();
            this.lblVolDisponible = new System.Windows.Forms.Label();
            this.cmbCuitEstacion = new System.Windows.Forms.ComboBox();
            this.cmbIdCombustible = new System.Windows.Forms.ComboBox();
            this.btnGuardarTanque = new System.Windows.Forms.Button();
            this.btnBorrarTanque = new System.Windows.Forms.Button();
            this.btnActualizarTanque = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.grdTanque = new System.Windows.Forms.DataGridView();
            this.numTanque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuitEstacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEstacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minLit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDeCombustible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlYpf = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdTanque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(301, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alta de nuevo tanque";
            // 
            // lblNumeroTanque
            // 
            this.lblNumeroTanque.AutoSize = true;
            this.lblNumeroTanque.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroTanque.ForeColor = System.Drawing.Color.White;
            this.lblNumeroTanque.Location = new System.Drawing.Point(295, 75);
            this.lblNumeroTanque.Name = "lblNumeroTanque";
            this.lblNumeroTanque.Size = new System.Drawing.Size(164, 21);
            this.lblNumeroTanque.TabIndex = 1;
            this.lblNumeroTanque.Text = "Número de tanque:";
            // 
            // txtNumeroTanque
            // 
            this.txtNumeroTanque.Enabled = false;
            this.txtNumeroTanque.Location = new System.Drawing.Point(465, 78);
            this.txtNumeroTanque.Name = "txtNumeroTanque";
            this.txtNumeroTanque.Size = new System.Drawing.Size(121, 20);
            this.txtNumeroTanque.TabIndex = 0;
            // 
            // lblCuitEstacion
            // 
            this.lblCuitEstacion.AutoSize = true;
            this.lblCuitEstacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuitEstacion.ForeColor = System.Drawing.Color.White;
            this.lblCuitEstacion.Location = new System.Drawing.Point(379, 111);
            this.lblCuitEstacion.Name = "lblCuitEstacion";
            this.lblCuitEstacion.Size = new System.Drawing.Size(80, 21);
            this.lblCuitEstacion.TabIndex = 3;
            this.lblCuitEstacion.Text = "Estación:";
            // 
            // txtVolMaximo
            // 
            this.txtVolMaximo.Location = new System.Drawing.Point(465, 150);
            this.txtVolMaximo.Name = "txtVolMaximo";
            this.txtVolMaximo.Size = new System.Drawing.Size(121, 20);
            this.txtVolMaximo.TabIndex = 2;
            // 
            // lblVolMax
            // 
            this.lblVolMax.AutoSize = true;
            this.lblVolMax.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolMax.ForeColor = System.Drawing.Color.White;
            this.lblVolMax.Location = new System.Drawing.Point(310, 150);
            this.lblVolMax.Name = "lblVolMax";
            this.lblVolMax.Size = new System.Drawing.Size(149, 21);
            this.lblVolMax.TabIndex = 5;
            this.lblVolMax.Text = "Volumen máximo:";
            // 
            // txtMinLit
            // 
            this.txtMinLit.Location = new System.Drawing.Point(465, 186);
            this.txtMinLit.Name = "txtMinLit";
            this.txtMinLit.Size = new System.Drawing.Size(121, 20);
            this.txtMinLit.TabIndex = 3;
            // 
            // lblMinLit
            // 
            this.lblMinLit.AutoSize = true;
            this.lblMinLit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinLit.ForeColor = System.Drawing.Color.White;
            this.lblMinLit.Location = new System.Drawing.Point(326, 185);
            this.lblMinLit.Name = "lblMinLit";
            this.lblMinLit.Size = new System.Drawing.Size(133, 21);
            this.lblMinLit.TabIndex = 7;
            this.lblMinLit.Text = "Mínimo de litros:";
            // 
            // lblIdCombustible
            // 
            this.lblIdCombustible.AutoSize = true;
            this.lblIdCombustible.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCombustible.ForeColor = System.Drawing.Color.White;
            this.lblIdCombustible.Location = new System.Drawing.Point(289, 222);
            this.lblIdCombustible.Name = "lblIdCombustible";
            this.lblIdCombustible.Size = new System.Drawing.Size(171, 21);
            this.lblIdCombustible.TabIndex = 9;
            this.lblIdCombustible.Text = "Tipo de combustible:";
            // 
            // txtVolDisponible
            // 
            this.txtVolDisponible.Location = new System.Drawing.Point(466, 256);
            this.txtVolDisponible.Name = "txtVolDisponible";
            this.txtVolDisponible.Size = new System.Drawing.Size(121, 20);
            this.txtVolDisponible.TabIndex = 5;
            // 
            // lblVolDisponible
            // 
            this.lblVolDisponible.AutoSize = true;
            this.lblVolDisponible.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolDisponible.ForeColor = System.Drawing.Color.White;
            this.lblVolDisponible.Location = new System.Drawing.Point(295, 256);
            this.lblVolDisponible.Name = "lblVolDisponible";
            this.lblVolDisponible.Size = new System.Drawing.Size(165, 21);
            this.lblVolDisponible.TabIndex = 11;
            this.lblVolDisponible.Text = "Volumen disponible:";
            // 
            // cmbCuitEstacion
            // 
            this.cmbCuitEstacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCuitEstacion.FormattingEnabled = true;
            this.cmbCuitEstacion.Location = new System.Drawing.Point(465, 111);
            this.cmbCuitEstacion.Name = "cmbCuitEstacion";
            this.cmbCuitEstacion.Size = new System.Drawing.Size(121, 21);
            this.cmbCuitEstacion.TabIndex = 1;
            // 
            // cmbIdCombustible
            // 
            this.cmbIdCombustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdCombustible.FormattingEnabled = true;
            this.cmbIdCombustible.Location = new System.Drawing.Point(466, 222);
            this.cmbIdCombustible.Name = "cmbIdCombustible";
            this.cmbIdCombustible.Size = new System.Drawing.Size(121, 21);
            this.cmbIdCombustible.TabIndex = 4;
            // 
            // btnGuardarTanque
            // 
            this.btnGuardarTanque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.btnGuardarTanque.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnGuardarTanque.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnGuardarTanque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarTanque.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarTanque.ForeColor = System.Drawing.Color.LightGray;
            this.btnGuardarTanque.Location = new System.Drawing.Point(483, 303);
            this.btnGuardarTanque.Name = "btnGuardarTanque";
            this.btnGuardarTanque.Size = new System.Drawing.Size(115, 59);
            this.btnGuardarTanque.TabIndex = 6;
            this.btnGuardarTanque.Text = "Guardar tanque";
            this.btnGuardarTanque.UseVisualStyleBackColor = false;
            this.btnGuardarTanque.Click += new System.EventHandler(this.btnGuardarTanque_Click);
            // 
            // btnBorrarTanque
            // 
            this.btnBorrarTanque.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnBorrarTanque.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnBorrarTanque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarTanque.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarTanque.ForeColor = System.Drawing.Color.LightGray;
            this.btnBorrarTanque.Location = new System.Drawing.Point(241, 381);
            this.btnBorrarTanque.Name = "btnBorrarTanque";
            this.btnBorrarTanque.Size = new System.Drawing.Size(115, 59);
            this.btnBorrarTanque.TabIndex = 8;
            this.btnBorrarTanque.Text = "Borrar tanque";
            this.btnBorrarTanque.UseVisualStyleBackColor = true;
            this.btnBorrarTanque.Click += new System.EventHandler(this.btnBorrarTanque_Click);
            // 
            // btnActualizarTanque
            // 
            this.btnActualizarTanque.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnActualizarTanque.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnActualizarTanque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarTanque.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarTanque.ForeColor = System.Drawing.Color.LightGray;
            this.btnActualizarTanque.Location = new System.Drawing.Point(362, 303);
            this.btnActualizarTanque.Name = "btnActualizarTanque";
            this.btnActualizarTanque.Size = new System.Drawing.Size(115, 59);
            this.btnActualizarTanque.TabIndex = 7;
            this.btnActualizarTanque.Text = "Actualizar tanque";
            this.btnActualizarTanque.UseVisualStyleBackColor = true;
            this.btnActualizarTanque.Click += new System.EventHandler(this.btnActualizarTanque_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnLimpiarCampos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.ForeColor = System.Drawing.Color.LightGray;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(241, 303);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(115, 59);
            this.btnLimpiarCampos.TabIndex = 9;
            this.btnLimpiarCampos.Text = "Limpiar campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // grdTanque
            // 
            this.grdTanque.AllowUserToAddRows = false;
            this.grdTanque.AllowUserToDeleteRows = false;
            this.grdTanque.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.grdTanque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTanque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numTanque,
            this.cuitEstacion,
            this.nombreEstacion,
            this.volMax,
            this.minLit,
            this.tipoDeCombustible,
            this.volDisponible});
            this.grdTanque.Location = new System.Drawing.Point(604, 49);
            this.grdTanque.Name = "grdTanque";
            this.grdTanque.ReadOnly = true;
            this.grdTanque.Size = new System.Drawing.Size(647, 391);
            this.grdTanque.TabIndex = 19;
            this.grdTanque.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTanque_CellClick);
            // 
            // numTanque
            // 
            this.numTanque.DataPropertyName = "numTanque";
            this.numTanque.HeaderText = "Número de tanque";
            this.numTanque.Name = "numTanque";
            this.numTanque.ReadOnly = true;
            this.numTanque.Width = 90;
            // 
            // cuitEstacion
            // 
            this.cuitEstacion.DataPropertyName = "cuitEstacion";
            this.cuitEstacion.HeaderText = "CUIT Estación";
            this.cuitEstacion.Name = "cuitEstacion";
            this.cuitEstacion.ReadOnly = true;
            this.cuitEstacion.Width = 90;
            // 
            // nombreEstacion
            // 
            this.nombreEstacion.DataPropertyName = "nombre";
            this.nombreEstacion.HeaderText = "Estación";
            this.nombreEstacion.Name = "nombreEstacion";
            this.nombreEstacion.ReadOnly = true;
            this.nombreEstacion.Width = 90;
            // 
            // volMax
            // 
            this.volMax.DataPropertyName = "volMax";
            this.volMax.HeaderText = "Volumen máximo";
            this.volMax.Name = "volMax";
            this.volMax.ReadOnly = true;
            this.volMax.Width = 90;
            // 
            // minLit
            // 
            this.minLit.DataPropertyName = "minLit";
            this.minLit.HeaderText = "Mínimo de litros";
            this.minLit.Name = "minLit";
            this.minLit.ReadOnly = true;
            this.minLit.Width = 90;
            // 
            // tipoDeCombustible
            // 
            this.tipoDeCombustible.DataPropertyName = "nombre1";
            this.tipoDeCombustible.HeaderText = "Tipo de combustible";
            this.tipoDeCombustible.Name = "tipoDeCombustible";
            this.tipoDeCombustible.ReadOnly = true;
            this.tipoDeCombustible.Width = 90;
            // 
            // volDisponible
            // 
            this.volDisponible.DataPropertyName = "volDisponible";
            this.volDisponible.HeaderText = "Volumen disponible";
            this.volDisponible.Name = "volDisponible";
            this.volDisponible.ReadOnly = true;
            this.volDisponible.Width = 90;
            // 
            // pnlYpf
            // 
            this.pnlYpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.pnlYpf.BackgroundImage = global::TPI.Properties.Resources.descarga;
            this.pnlYpf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlYpf.Location = new System.Drawing.Point(0, -3);
            this.pnlYpf.Name = "pnlYpf";
            this.pnlYpf.Size = new System.Drawing.Size(220, 484);
            this.pnlYpf.TabIndex = 20;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::TPI.Properties.Resources.Minimize_Icon;
            this.btnMinimizar.Location = new System.Drawing.Point(1203, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(21, 22);
            this.btnMinimizar.TabIndex = 22;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::TPI.Properties.Resources.Close_Icon;
            this.btnCerrar.Location = new System.Drawing.Point(1230, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(21, 22);
            this.btnCerrar.TabIndex = 21;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // AltaTanque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1263, 479);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.pnlYpf);
            this.Controls.Add(this.grdTanque);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnActualizarTanque);
            this.Controls.Add(this.btnBorrarTanque);
            this.Controls.Add(this.btnGuardarTanque);
            this.Controls.Add(this.cmbIdCombustible);
            this.Controls.Add(this.cmbCuitEstacion);
            this.Controls.Add(this.txtVolDisponible);
            this.Controls.Add(this.lblVolDisponible);
            this.Controls.Add(this.lblIdCombustible);
            this.Controls.Add(this.txtMinLit);
            this.Controls.Add(this.lblMinLit);
            this.Controls.Add(this.txtVolMaximo);
            this.Controls.Add(this.lblVolMax);
            this.Controls.Add(this.lblCuitEstacion);
            this.Controls.Add(this.txtNumeroTanque);
            this.Controls.Add(this.lblNumeroTanque);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AltaTanque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de tanque";
            this.Load += new System.EventHandler(this.AltaTanque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdTanque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumeroTanque;
        private System.Windows.Forms.TextBox txtNumeroTanque;
        private System.Windows.Forms.Label lblCuitEstacion;
        private System.Windows.Forms.TextBox txtVolMaximo;
        private System.Windows.Forms.Label lblVolMax;
        private System.Windows.Forms.TextBox txtMinLit;
        private System.Windows.Forms.Label lblMinLit;
        private System.Windows.Forms.Label lblIdCombustible;
        private System.Windows.Forms.TextBox txtVolDisponible;
        private System.Windows.Forms.Label lblVolDisponible;
        private System.Windows.Forms.ComboBox cmbCuitEstacion;
        private System.Windows.Forms.ComboBox cmbIdCombustible;
        private System.Windows.Forms.Button btnGuardarTanque;
        private System.Windows.Forms.Button btnBorrarTanque;
        private System.Windows.Forms.Button btnActualizarTanque;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.DataGridView grdTanque;
        private System.Windows.Forms.Panel pnlYpf;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn numTanque;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuitEstacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEstacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn volMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn minLit;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDeCombustible;
        private System.Windows.Forms.DataGridViewTextBoxColumn volDisponible;
    }
}