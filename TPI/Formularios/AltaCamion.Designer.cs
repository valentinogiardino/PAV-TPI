
namespace TPI
{
    partial class AltaCamion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPatente = new System.Windows.Forms.Label();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.lblCantCombustibleMax = new System.Windows.Forms.Label();
            this.lblIdModelo = new System.Windows.Forms.Label();
            this.gdrCamiones = new System.Windows.Forms.DataGridView();
            this.btnGuardarCamion = new System.Windows.Forms.Button();
            this.btnActualizarCamion = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.txtCantCombustibleMax = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnEliminarCamion = new System.Windows.Forms.Button();
            this.cmbModelo = new System.Windows.Forms.ComboBox();
            this.Patente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantCombustibleMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gdrCamiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(363, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alta de Nuevo Camion";
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatente.ForeColor = System.Drawing.Color.White;
            this.lblPatente.Location = new System.Drawing.Point(413, 122);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(78, 21);
            this.lblPatente.TabIndex = 1;
            this.lblPatente.Text = "Patente:";
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(515, 124);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(100, 20);
            this.txtPatente.TabIndex = 1;
            // 
            // lblCantCombustibleMax
            // 
            this.lblCantCombustibleMax.AutoSize = true;
            this.lblCantCombustibleMax.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantCombustibleMax.ForeColor = System.Drawing.Color.White;
            this.lblCantCombustibleMax.Location = new System.Drawing.Point(235, 193);
            this.lblCantCombustibleMax.Name = "lblCantCombustibleMax";
            this.lblCantCombustibleMax.Size = new System.Drawing.Size(260, 21);
            this.lblCantCombustibleMax.TabIndex = 3;
            this.lblCantCombustibleMax.Text = "Cantidad Combustible Maximo:";
            // 
            // lblIdModelo
            // 
            this.lblIdModelo.AutoSize = true;
            this.lblIdModelo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdModelo.ForeColor = System.Drawing.Color.White;
            this.lblIdModelo.Location = new System.Drawing.Point(418, 155);
            this.lblIdModelo.Name = "lblIdModelo";
            this.lblIdModelo.Size = new System.Drawing.Size(73, 21);
            this.lblIdModelo.TabIndex = 5;
            this.lblIdModelo.Text = "Modelo:";
            // 
            // gdrCamiones
            // 
            this.gdrCamiones.AllowUserToAddRows = false;
            this.gdrCamiones.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.gdrCamiones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gdrCamiones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.gdrCamiones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdrCamiones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdrCamiones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gdrCamiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrCamiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Patente,
            this.IdModelo,
            this.CantCombustibleMax});
            this.gdrCamiones.GridColor = System.Drawing.Color.DarkGray;
            this.gdrCamiones.Location = new System.Drawing.Point(714, 50);
            this.gdrCamiones.Name = "gdrCamiones";
            this.gdrCamiones.ReadOnly = true;
            this.gdrCamiones.Size = new System.Drawing.Size(379, 324);
            this.gdrCamiones.TabIndex = 7;
            this.gdrCamiones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrCamiones_CellClick);
            // 
            // btnGuardarCamion
            // 
            this.btnGuardarCamion.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnGuardarCamion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.btnGuardarCamion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnGuardarCamion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnGuardarCamion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnGuardarCamion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCamion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCamion.ForeColor = System.Drawing.Color.LightGray;
            this.btnGuardarCamion.Location = new System.Drawing.Point(565, 250);
            this.btnGuardarCamion.Name = "btnGuardarCamion";
            this.btnGuardarCamion.Size = new System.Drawing.Size(115, 52);
            this.btnGuardarCamion.TabIndex = 4;
            this.btnGuardarCamion.Text = "Guardar Camion";
            this.btnGuardarCamion.UseVisualStyleBackColor = false;
            this.btnGuardarCamion.Click += new System.EventHandler(this.btnGuardarCamion_Click);
            // 
            // btnActualizarCamion
            // 
            this.btnActualizarCamion.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnActualizarCamion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.btnActualizarCamion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnActualizarCamion.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnActualizarCamion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnActualizarCamion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarCamion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarCamion.ForeColor = System.Drawing.Color.LightGray;
            this.btnActualizarCamion.Location = new System.Drawing.Point(422, 250);
            this.btnActualizarCamion.Name = "btnActualizarCamion";
            this.btnActualizarCamion.Size = new System.Drawing.Size(113, 52);
            this.btnActualizarCamion.TabIndex = 5;
            this.btnActualizarCamion.Text = "Actualizar Camion";
            this.btnActualizarCamion.UseVisualStyleBackColor = false;
            this.btnActualizarCamion.Click += new System.EventHandler(this.btnActualizarCamion_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnLimpiarCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.btnLimpiarCampos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnLimpiarCampos.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnLimpiarCampos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.ForeColor = System.Drawing.Color.LightGray;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(275, 250);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(115, 52);
            this.btnLimpiarCampos.TabIndex = 6;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // txtCantCombustibleMax
            // 
            this.txtCantCombustibleMax.Location = new System.Drawing.Point(515, 195);
            this.txtCantCombustibleMax.Name = "txtCantCombustibleMax";
            this.txtCantCombustibleMax.Size = new System.Drawing.Size(100, 20);
            this.txtCantCombustibleMax.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.panel1.BackgroundImage = global::TPI.Properties.Resources.descarga;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 425);
            this.panel1.TabIndex = 14;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::TPI.Properties.Resources.Minimize_Icon;
            this.btnMinimizar.Location = new System.Drawing.Point(1072, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(21, 22);
            this.btnMinimizar.TabIndex = 16;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click_1);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::TPI.Properties.Resources.Close_Icon;
            this.btnCerrar.Location = new System.Drawing.Point(1099, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(21, 22);
            this.btnCerrar.TabIndex = 15;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // btnEliminarCamion
            // 
            this.btnEliminarCamion.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnEliminarCamion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.btnEliminarCamion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnEliminarCamion.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnEliminarCamion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnEliminarCamion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCamion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCamion.ForeColor = System.Drawing.Color.LightGray;
            this.btnEliminarCamion.Location = new System.Drawing.Point(277, 322);
            this.btnEliminarCamion.Name = "btnEliminarCamion";
            this.btnEliminarCamion.Size = new System.Drawing.Size(113, 52);
            this.btnEliminarCamion.TabIndex = 7;
            this.btnEliminarCamion.Text = "Eliminar Camion";
            this.btnEliminarCamion.UseVisualStyleBackColor = false;
            this.btnEliminarCamion.Click += new System.EventHandler(this.btnEliminarCamion_Click);
            // 
            // cmbModelo
            // 
            this.cmbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModelo.FormattingEnabled = true;
            this.cmbModelo.Location = new System.Drawing.Point(515, 155);
            this.cmbModelo.Name = "cmbModelo";
            this.cmbModelo.Size = new System.Drawing.Size(100, 21);
            this.cmbModelo.TabIndex = 19;
            // 
            // Patente
            // 
            this.Patente.DataPropertyName = "patente";
            this.Patente.HeaderText = "Patente";
            this.Patente.Name = "Patente";
            this.Patente.ReadOnly = true;
            // 
            // IdModelo
            // 
            this.IdModelo.DataPropertyName = "nombreModelo";
            this.IdModelo.HeaderText = "Modelo";
            this.IdModelo.Name = "IdModelo";
            this.IdModelo.ReadOnly = true;
            // 
            // CantCombustibleMax
            // 
            this.CantCombustibleMax.DataPropertyName = "cantCombustibleMax";
            this.CantCombustibleMax.HeaderText = "CantCombustibleMax";
            this.CantCombustibleMax.Name = "CantCombustibleMax";
            this.CantCombustibleMax.ReadOnly = true;
            this.CantCombustibleMax.Width = 150;
            // 
            // AltaCamion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1132, 425);
            this.Controls.Add(this.cmbModelo);
            this.Controls.Add(this.btnEliminarCamion);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCantCombustibleMax);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnActualizarCamion);
            this.Controls.Add(this.btnGuardarCamion);
            this.Controls.Add(this.gdrCamiones);
            this.Controls.Add(this.lblIdModelo);
            this.Controls.Add(this.lblCantCombustibleMax);
            this.Controls.Add(this.txtPatente);
            this.Controls.Add(this.lblPatente);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AltaCamion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Nuevo Camion";
            this.Load += new System.EventHandler(this.AltaCamion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdrCamiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Label lblCantCombustibleMax;
        private System.Windows.Forms.Label lblIdModelo;
        private System.Windows.Forms.DataGridView gdrCamiones;
        private System.Windows.Forms.Button btnGuardarCamion;
        private System.Windows.Forms.Button btnActualizarCamion;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.TextBox txtCantCombustibleMax;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Button btnEliminarCamion;
        private System.Windows.Forms.ComboBox cmbModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantCombustibleMax;
    }
}