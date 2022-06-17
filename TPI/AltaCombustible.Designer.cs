
namespace TPI
{
    partial class AltaCombustible
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaCombustible));
            this.lblAltaCombustible = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.GrdCombustible = new System.Windows.Forms.DataGridView();
            this.idCombustible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCombustible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.txtNombreCombustible = new System.Windows.Forms.TextBox();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.lblCodTipoCombustible = new System.Windows.Forms.Label();
            this.cmbTipoDeCombustible = new System.Windows.Forms.ComboBox();
            this.btnLimpiarDatos = new System.Windows.Forms.Button();
            this.btnGuardarCombustible = new System.Windows.Forms.Button();
            this.btnActualizarCombustible = new System.Windows.Forms.Button();
            this.btnBorrarCombustible = new System.Windows.Forms.Button();
            this.lblIdCombustible = new System.Windows.Forms.Label();
            this.txtIdCombustible = new System.Windows.Forms.TextBox();
            this.pnlYpf = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GrdCombustible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAltaCombustible
            // 
            this.lblAltaCombustible.AutoSize = true;
            this.lblAltaCombustible.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaCombustible.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblAltaCombustible.Location = new System.Drawing.Point(267, 41);
            this.lblAltaCombustible.Name = "lblAltaCombustible";
            this.lblAltaCombustible.Size = new System.Drawing.Size(297, 24);
            this.lblAltaCombustible.TabIndex = 0;
            this.lblAltaCombustible.Text = "Alta de nuevo combustible ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(256, 136);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(202, 21);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre de combustible:";
            // 
            // GrdCombustible
            // 
            this.GrdCombustible.AllowUserToAddRows = false;
            this.GrdCombustible.AllowUserToDeleteRows = false;
            this.GrdCombustible.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.GrdCombustible.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdCombustible.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCombustible,
            this.TipoCombustible,
            this.nombre,
            this.precioUnitario});
            this.GrdCombustible.Location = new System.Drawing.Point(735, 53);
            this.GrdCombustible.Name = "GrdCombustible";
            this.GrdCombustible.ReadOnly = true;
            this.GrdCombustible.Size = new System.Drawing.Size(443, 373);
            this.GrdCombustible.TabIndex = 2;
            this.GrdCombustible.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdCombustible_CellClick);
            // 
            // idCombustible
            // 
            this.idCombustible.DataPropertyName = "idCombustible";
            this.idCombustible.HeaderText = "Id ";
            this.idCombustible.Name = "idCombustible";
            this.idCombustible.ReadOnly = true;
            // 
            // TipoCombustible
            // 
            this.TipoCombustible.DataPropertyName = "nombre";
            this.TipoCombustible.HeaderText = "Tipo de combustible";
            this.TipoCombustible.Name = "TipoCombustible";
            this.TipoCombustible.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre1";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // precioUnitario
            // 
            this.precioUnitario.DataPropertyName = "precioUnitario";
            this.precioUnitario.HeaderText = "Precio Unitario";
            this.precioUnitario.Name = "precioUnitario";
            this.precioUnitario.ReadOnly = true;
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioUnitario.ForeColor = System.Drawing.Color.White;
            this.lblPrecioUnitario.Location = new System.Drawing.Point(333, 204);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(125, 21);
            this.lblPrecioUnitario.TabIndex = 3;
            this.lblPrecioUnitario.Text = "Precio Unitario:";
            // 
            // txtNombreCombustible
            // 
            this.txtNombreCombustible.Location = new System.Drawing.Point(464, 136);
            this.txtNombreCombustible.Name = "txtNombreCombustible";
            this.txtNombreCombustible.Size = new System.Drawing.Size(177, 20);
            this.txtNombreCombustible.TabIndex = 1;
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Location = new System.Drawing.Point(464, 207);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(177, 20);
            this.txtPrecioUnitario.TabIndex = 3;
            // 
            // lblCodTipoCombustible
            // 
            this.lblCodTipoCombustible.AutoSize = true;
            this.lblCodTipoCombustible.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodTipoCombustible.ForeColor = System.Drawing.Color.White;
            this.lblCodTipoCombustible.Location = new System.Drawing.Point(287, 170);
            this.lblCodTipoCombustible.Name = "lblCodTipoCombustible";
            this.lblCodTipoCombustible.Size = new System.Drawing.Size(171, 21);
            this.lblCodTipoCombustible.TabIndex = 6;
            this.lblCodTipoCombustible.Text = "Tipo de combustible:";
            // 
            // cmbTipoDeCombustible
            // 
            this.cmbTipoDeCombustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDeCombustible.FormattingEnabled = true;
            this.cmbTipoDeCombustible.Location = new System.Drawing.Point(464, 173);
            this.cmbTipoDeCombustible.Name = "cmbTipoDeCombustible";
            this.cmbTipoDeCombustible.Size = new System.Drawing.Size(177, 21);
            this.cmbTipoDeCombustible.TabIndex = 2;
            // 
            // btnLimpiarDatos
            // 
            this.btnLimpiarDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.btnLimpiarDatos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnLimpiarDatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnLimpiarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarDatos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarDatos.ForeColor = System.Drawing.Color.LightGray;
            this.btnLimpiarDatos.Location = new System.Drawing.Point(493, 367);
            this.btnLimpiarDatos.Name = "btnLimpiarDatos";
            this.btnLimpiarDatos.Size = new System.Drawing.Size(119, 59);
            this.btnLimpiarDatos.TabIndex = 7;
            this.btnLimpiarDatos.Text = "Limpiar datos";
            this.btnLimpiarDatos.UseVisualStyleBackColor = false;
            this.btnLimpiarDatos.Click += new System.EventHandler(this.btnLimpiarDatos_Click);
            // 
            // btnGuardarCombustible
            // 
            this.btnGuardarCombustible.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.btnGuardarCombustible.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(126)))));
            this.btnGuardarCombustible.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnGuardarCombustible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCombustible.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCombustible.ForeColor = System.Drawing.Color.LightGray;
            this.btnGuardarCombustible.Location = new System.Drawing.Point(337, 277);
            this.btnGuardarCombustible.Name = "btnGuardarCombustible";
            this.btnGuardarCombustible.Size = new System.Drawing.Size(119, 59);
            this.btnGuardarCombustible.TabIndex = 4;
            this.btnGuardarCombustible.Text = "Guardar combustible";
            this.btnGuardarCombustible.UseVisualStyleBackColor = false;
            this.btnGuardarCombustible.Click += new System.EventHandler(this.btnGuardarCombustible_Click);
            // 
            // btnActualizarCombustible
            // 
            this.btnActualizarCombustible.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.btnActualizarCombustible.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnActualizarCombustible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarCombustible.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarCombustible.ForeColor = System.Drawing.Color.LightGray;
            this.btnActualizarCombustible.Location = new System.Drawing.Point(493, 277);
            this.btnActualizarCombustible.Name = "btnActualizarCombustible";
            this.btnActualizarCombustible.Size = new System.Drawing.Size(119, 59);
            this.btnActualizarCombustible.TabIndex = 5;
            this.btnActualizarCombustible.Text = "Actualizar combustible";
            this.btnActualizarCombustible.UseVisualStyleBackColor = false;
            this.btnActualizarCombustible.Click += new System.EventHandler(this.btnActualizarCombustible_Click);
            // 
            // btnBorrarCombustible
            // 
            this.btnBorrarCombustible.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.btnBorrarCombustible.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnBorrarCombustible.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnBorrarCombustible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarCombustible.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarCombustible.ForeColor = System.Drawing.Color.LightGray;
            this.btnBorrarCombustible.Location = new System.Drawing.Point(339, 367);
            this.btnBorrarCombustible.Name = "btnBorrarCombustible";
            this.btnBorrarCombustible.Size = new System.Drawing.Size(119, 59);
            this.btnBorrarCombustible.TabIndex = 6;
            this.btnBorrarCombustible.Text = "Borrar combustible";
            this.btnBorrarCombustible.UseVisualStyleBackColor = false;
            this.btnBorrarCombustible.Click += new System.EventHandler(this.btnBorrarCombustible_Click);
            // 
            // lblIdCombustible
            // 
            this.lblIdCombustible.AutoSize = true;
            this.lblIdCombustible.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCombustible.ForeColor = System.Drawing.Color.White;
            this.lblIdCombustible.Location = new System.Drawing.Point(302, 101);
            this.lblIdCombustible.Name = "lblIdCombustible";
            this.lblIdCombustible.Size = new System.Drawing.Size(156, 21);
            this.lblIdCombustible.TabIndex = 7;
            this.lblIdCombustible.Text = "ID de combustible:";
            // 
            // txtIdCombustible
            // 
            this.txtIdCombustible.Enabled = false;
            this.txtIdCombustible.Location = new System.Drawing.Point(464, 104);
            this.txtIdCombustible.Name = "txtIdCombustible";
            this.txtIdCombustible.Size = new System.Drawing.Size(177, 20);
            this.txtIdCombustible.TabIndex = 0;
            // 
            // pnlYpf
            // 
            this.pnlYpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.pnlYpf.BackgroundImage = global::TPI.Properties.Resources.descarga;
            this.pnlYpf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlYpf.Location = new System.Drawing.Point(0, 2);
            this.pnlYpf.Name = "pnlYpf";
            this.pnlYpf.Size = new System.Drawing.Size(220, 484);
            this.pnlYpf.TabIndex = 8;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::TPI.Properties.Resources.Minimize_Icon;
            this.btnMinimizar.Location = new System.Drawing.Point(1175, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(21, 22);
            this.btnMinimizar.TabIndex = 18;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::TPI.Properties.Resources.Close_Icon;
            this.btnCerrar.Location = new System.Drawing.Point(1202, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(21, 22);
            this.btnCerrar.TabIndex = 17;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // AltaCombustible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1235, 485);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.pnlYpf);
            this.Controls.Add(this.txtIdCombustible);
            this.Controls.Add(this.lblIdCombustible);
            this.Controls.Add(this.btnBorrarCombustible);
            this.Controls.Add(this.btnActualizarCombustible);
            this.Controls.Add(this.btnGuardarCombustible);
            this.Controls.Add(this.btnLimpiarDatos);
            this.Controls.Add(this.cmbTipoDeCombustible);
            this.Controls.Add(this.lblCodTipoCombustible);
            this.Controls.Add(this.txtPrecioUnitario);
            this.Controls.Add(this.txtNombreCombustible);
            this.Controls.Add(this.lblPrecioUnitario);
            this.Controls.Add(this.GrdCombustible);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblAltaCombustible);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AltaCombustible";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de combustible";
            this.Load += new System.EventHandler(this.AltaCombustible_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdCombustible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAltaCombustible;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView GrdCombustible;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.TextBox txtNombreCombustible;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.Label lblCodTipoCombustible;
        private System.Windows.Forms.ComboBox cmbTipoDeCombustible;
        private System.Windows.Forms.Button btnLimpiarDatos;
        private System.Windows.Forms.Button btnGuardarCombustible;
        private System.Windows.Forms.Button btnActualizarCombustible;
        private System.Windows.Forms.Button btnBorrarCombustible;
        private System.Windows.Forms.Label lblIdCombustible;
        private System.Windows.Forms.TextBox txtIdCombustible;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCombustible;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCombustible;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitario;
        private System.Windows.Forms.Panel pnlYpf;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
    }
}