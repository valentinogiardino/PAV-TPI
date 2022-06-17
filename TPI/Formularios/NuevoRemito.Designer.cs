
namespace TPI.Formularios
{
    partial class NuevoRemito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoRemito));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.txtINroRemito = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.MaskedTextBox();
            this.grdCombustible = new System.Windows.Forms.DataGridView();
            this.IdCombustible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadLitros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioLitro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCuitEstacion = new System.Windows.Forms.ComboBox();
            this.cmbPatenteCamion = new System.Windows.Forms.ComboBox();
            this.cmbCombustible = new System.Windows.Forms.ComboBox();
            this.btnGenerarRemito = new System.Windows.Forms.Button();
            this.btnAgregarCombustible = new System.Windows.Forms.Button();
            this.txtPrecioUnitario = new System.Windows.Forms.NumericUpDown();
            this.txtCantidadComb = new System.Windows.Forms.NumericUpDown();
            this.btnLimpiarGrilla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCombustible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioUnitario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadComb)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(204, 534);
            this.panel1.TabIndex = 16;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::TPI.Properties.Resources.Minimize_Icon;
            this.btnMinimizar.Location = new System.Drawing.Point(880, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(21, 22);
            this.btnMinimizar.TabIndex = 19;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::TPI.Properties.Resources.Close_Icon;
            this.btnCerrar.Location = new System.Drawing.Point(906, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(21, 22);
            this.btnCerrar.TabIndex = 18;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(412, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 30);
            this.label1.TabIndex = 20;
            this.label1.Text = "Generar remito";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.Color.White;
            this.labelFecha.Location = new System.Drawing.Point(360, 158);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(63, 21);
            this.labelFecha.TabIndex = 21;
            this.labelFecha.Text = "Fecha:";
            // 
            // txtINroRemito
            // 
            this.txtINroRemito.Enabled = false;
            this.txtINroRemito.Location = new System.Drawing.Point(424, 62);
            this.txtINroRemito.Name = "txtINroRemito";
            this.txtINroRemito.Size = new System.Drawing.Size(168, 20);
            this.txtINroRemito.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(273, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 21);
            this.label4.TabIndex = 23;
            this.label4.Text = "Número de remito:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(260, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 21);
            this.label2.TabIndex = 25;
            this.label2.Text = "Patente del camión:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(238, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 21);
            this.label3.TabIndex = 27;
            this.label3.Text = "Nombre de la Estación:";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(424, 158);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(2);
            this.txtFecha.Mask = "00/00/0000";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(76, 20);
            this.txtFecha.TabIndex = 29;
            this.txtFecha.ValidatingType = typeof(System.DateTime);
            // 
            // grdCombustible
            // 
            this.grdCombustible.AllowUserToAddRows = false;
            this.grdCombustible.AllowUserToDeleteRows = false;
            this.grdCombustible.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCombustible.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCombustible,
            this.CantidadLitros,
            this.PrecioLitro});
            this.grdCombustible.Location = new System.Drawing.Point(242, 281);
            this.grdCombustible.Margin = new System.Windows.Forms.Padding(2);
            this.grdCombustible.Name = "grdCombustible";
            this.grdCombustible.ReadOnly = true;
            this.grdCombustible.RowHeadersWidth = 51;
            this.grdCombustible.RowTemplate.Height = 24;
            this.grdCombustible.Size = new System.Drawing.Size(496, 154);
            this.grdCombustible.TabIndex = 31;
            // 
            // IdCombustible
            // 
            this.IdCombustible.HeaderText = "ID Combustible";
            this.IdCombustible.MinimumWidth = 6;
            this.IdCombustible.Name = "IdCombustible";
            this.IdCombustible.ReadOnly = true;
            this.IdCombustible.Width = 125;
            // 
            // CantidadLitros
            // 
            this.CantidadLitros.HeaderText = "Cantidad Litros";
            this.CantidadLitros.MinimumWidth = 6;
            this.CantidadLitros.Name = "CantidadLitros";
            this.CantidadLitros.ReadOnly = true;
            this.CantidadLitros.Width = 150;
            // 
            // PrecioLitro
            // 
            this.PrecioLitro.HeaderText = "Precio por Litro";
            this.PrecioLitro.MinimumWidth = 6;
            this.PrecioLitro.Name = "PrecioLitro";
            this.PrecioLitro.ReadOnly = true;
            this.PrecioLitro.Width = 150;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(412, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 21);
            this.label5.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(238, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 21);
            this.label6.TabIndex = 36;
            this.label6.Text = "Combustible:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(474, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 21);
            this.label7.TabIndex = 37;
            this.label7.Text = "Precio Unitario:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(686, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 21);
            this.label8.TabIndex = 39;
            this.label8.Text = "Cantidad De Litros:";
            // 
            // cmbCuitEstacion
            // 
            this.cmbCuitEstacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCuitEstacion.FormattingEnabled = true;
            this.cmbCuitEstacion.Location = new System.Drawing.Point(424, 92);
            this.cmbCuitEstacion.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCuitEstacion.Name = "cmbCuitEstacion";
            this.cmbCuitEstacion.Size = new System.Drawing.Size(168, 21);
            this.cmbCuitEstacion.TabIndex = 41;
            // 
            // cmbPatenteCamion
            // 
            this.cmbPatenteCamion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPatenteCamion.FormattingEnabled = true;
            this.cmbPatenteCamion.Location = new System.Drawing.Point(424, 128);
            this.cmbPatenteCamion.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPatenteCamion.Name = "cmbPatenteCamion";
            this.cmbPatenteCamion.Size = new System.Drawing.Size(168, 21);
            this.cmbPatenteCamion.TabIndex = 42;
            // 
            // cmbCombustible
            // 
            this.cmbCombustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCombustible.FormattingEnabled = true;
            this.cmbCombustible.Location = new System.Drawing.Point(347, 232);
            this.cmbCombustible.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCombustible.Name = "cmbCombustible";
            this.cmbCombustible.Size = new System.Drawing.Size(108, 21);
            this.cmbCombustible.TabIndex = 44;
            // 
            // btnGenerarRemito
            // 
            this.btnGenerarRemito.Enabled = false;
            this.btnGenerarRemito.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnGenerarRemito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnGenerarRemito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarRemito.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarRemito.ForeColor = System.Drawing.Color.LightGray;
            this.btnGenerarRemito.Location = new System.Drawing.Point(806, 466);
            this.btnGenerarRemito.Name = "btnGenerarRemito";
            this.btnGenerarRemito.Size = new System.Drawing.Size(120, 56);
            this.btnGenerarRemito.TabIndex = 45;
            this.btnGenerarRemito.Text = "Generar remito";
            this.btnGenerarRemito.UseVisualStyleBackColor = true;
            this.btnGenerarRemito.Click += new System.EventHandler(this.btnGenerarRemito_Click);
            // 
            // btnAgregarCombustible
            // 
            this.btnAgregarCombustible.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnAgregarCombustible.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnAgregarCombustible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCombustible.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCombustible.ForeColor = System.Drawing.Color.LightGray;
            this.btnAgregarCombustible.Location = new System.Drawing.Point(807, 281);
            this.btnAgregarCombustible.Name = "btnAgregarCombustible";
            this.btnAgregarCombustible.Size = new System.Drawing.Size(120, 56);
            this.btnAgregarCombustible.TabIndex = 46;
            this.btnAgregarCombustible.Text = "Agregar Combustible";
            this.btnAgregarCombustible.UseVisualStyleBackColor = true;
            this.btnAgregarCombustible.Click += new System.EventHandler(this.btnAgregarCombustible_Click);
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.DecimalPlaces = 2;
            this.txtPrecioUnitario.Location = new System.Drawing.Point(605, 234);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(75, 20);
            this.txtPrecioUnitario.TabIndex = 48;
            // 
            // txtCantidadComb
            // 
            this.txtCantidadComb.DecimalPlaces = 2;
            this.txtCantidadComb.Location = new System.Drawing.Point(851, 235);
            this.txtCantidadComb.Name = "txtCantidadComb";
            this.txtCantidadComb.Size = new System.Drawing.Size(75, 20);
            this.txtCantidadComb.TabIndex = 49;
            // 
            // btnLimpiarGrilla
            // 
            this.btnLimpiarGrilla.Enabled = false;
            this.btnLimpiarGrilla.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnLimpiarGrilla.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnLimpiarGrilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarGrilla.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarGrilla.ForeColor = System.Drawing.Color.LightGray;
            this.btnLimpiarGrilla.Location = new System.Drawing.Point(663, 466);
            this.btnLimpiarGrilla.Name = "btnLimpiarGrilla";
            this.btnLimpiarGrilla.Size = new System.Drawing.Size(120, 56);
            this.btnLimpiarGrilla.TabIndex = 50;
            this.btnLimpiarGrilla.Text = "Limpiar Grilla";
            this.btnLimpiarGrilla.UseVisualStyleBackColor = true;
            this.btnLimpiarGrilla.Click += new System.EventHandler(this.btnLimpiarGrilla_Click);
            // 
            // NuevoRemito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(939, 534);
            this.Controls.Add(this.btnLimpiarGrilla);
            this.Controls.Add(this.txtCantidadComb);
            this.Controls.Add(this.txtPrecioUnitario);
            this.Controls.Add(this.btnAgregarCombustible);
            this.Controls.Add(this.btnGenerarRemito);
            this.Controls.Add(this.cmbCombustible);
            this.Controls.Add(this.cmbPatenteCamion);
            this.Controls.Add(this.cmbCuitEstacion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grdCombustible);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtINroRemito);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NuevoRemito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoRemito";
            this.Load += new System.EventHandler(this.NuevoRemito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCombustible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioUnitario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadComb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.TextBox txtINroRemito;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtFecha;
        private System.Windows.Forms.DataGridView grdCombustible;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCuitEstacion;
        private System.Windows.Forms.ComboBox cmbPatenteCamion;
        private System.Windows.Forms.ComboBox cmbCombustible;
        private System.Windows.Forms.Button btnGenerarRemito;
        private System.Windows.Forms.Button btnAgregarCombustible;
        private System.Windows.Forms.NumericUpDown txtPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCombustible;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadLitros;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioLitro;
        private System.Windows.Forms.NumericUpDown txtCantidadComb;
        private System.Windows.Forms.Button btnLimpiarGrilla;
    }
}