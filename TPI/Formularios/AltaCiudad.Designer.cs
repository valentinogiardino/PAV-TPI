
namespace TPI
{
    partial class AltaCiudad
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminarCiudad = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnActualizarCiudad = new System.Windows.Forms.Button();
            this.btnGuardarCiudad = new System.Windows.Forms.Button();
            this.gdrCiudades = new System.Windows.Forms.DataGridView();
            this.lblIdProvincia = new System.Windows.Forms.Label();
            this.txtNombreCiudad = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIdCiudad = new System.Windows.Forms.Label();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.txtIdCiudad = new System.Windows.Forms.TextBox();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IdCiudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProvincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdrCiudades)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(204, 431);
            this.panel1.TabIndex = 15;
            // 
            // btnEliminarCiudad
            // 
            this.btnEliminarCiudad.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnEliminarCiudad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.btnEliminarCiudad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnEliminarCiudad.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnEliminarCiudad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnEliminarCiudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCiudad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCiudad.ForeColor = System.Drawing.Color.LightGray;
            this.btnEliminarCiudad.Location = new System.Drawing.Point(226, 328);
            this.btnEliminarCiudad.Name = "btnEliminarCiudad";
            this.btnEliminarCiudad.Size = new System.Drawing.Size(113, 52);
            this.btnEliminarCiudad.TabIndex = 7;
            this.btnEliminarCiudad.Text = "Eliminar Ciudad";
            this.btnEliminarCiudad.UseVisualStyleBackColor = false;
            this.btnEliminarCiudad.Click += new System.EventHandler(this.btnEliminarCiudad_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::TPI.Properties.Resources.Minimize_Icon;
            this.btnMinimizar.Location = new System.Drawing.Point(1079, 12);
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
            this.btnCerrar.Location = new System.Drawing.Point(1106, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(21, 22);
            this.btnCerrar.TabIndex = 29;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
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
            this.btnLimpiarCampos.Location = new System.Drawing.Point(224, 256);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(115, 52);
            this.btnLimpiarCampos.TabIndex = 6;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnActualizarCiudad
            // 
            this.btnActualizarCiudad.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnActualizarCiudad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.btnActualizarCiudad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnActualizarCiudad.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnActualizarCiudad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnActualizarCiudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarCiudad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarCiudad.ForeColor = System.Drawing.Color.LightGray;
            this.btnActualizarCiudad.Location = new System.Drawing.Point(371, 256);
            this.btnActualizarCiudad.Name = "btnActualizarCiudad";
            this.btnActualizarCiudad.Size = new System.Drawing.Size(113, 52);
            this.btnActualizarCiudad.TabIndex = 5;
            this.btnActualizarCiudad.Text = "Actualizar Ciudad";
            this.btnActualizarCiudad.UseVisualStyleBackColor = false;
            this.btnActualizarCiudad.Click += new System.EventHandler(this.btnActualizarCiudad_Click);
            // 
            // btnGuardarCiudad
            // 
            this.btnGuardarCiudad.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnGuardarCiudad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.btnGuardarCiudad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnGuardarCiudad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnGuardarCiudad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnGuardarCiudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCiudad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCiudad.ForeColor = System.Drawing.Color.LightGray;
            this.btnGuardarCiudad.Location = new System.Drawing.Point(514, 256);
            this.btnGuardarCiudad.Name = "btnGuardarCiudad";
            this.btnGuardarCiudad.Size = new System.Drawing.Size(115, 52);
            this.btnGuardarCiudad.TabIndex = 4;
            this.btnGuardarCiudad.Text = "Guardar Ciudad";
            this.btnGuardarCiudad.UseVisualStyleBackColor = false;
            this.btnGuardarCiudad.Click += new System.EventHandler(this.btnGuardarCiudad_Click);
            // 
            // gdrCiudades
            // 
            this.gdrCiudades.AllowUserToAddRows = false;
            this.gdrCiudades.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.gdrCiudades.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gdrCiudades.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.gdrCiudades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdrCiudades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdrCiudades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gdrCiudades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrCiudades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCiudad,
            this.Nombre,
            this.IdProvincia,
            this.Pais});
            this.gdrCiudades.GridColor = System.Drawing.Color.DarkGray;
            this.gdrCiudades.Location = new System.Drawing.Point(656, 56);
            this.gdrCiudades.Name = "gdrCiudades";
            this.gdrCiudades.ReadOnly = true;
            this.gdrCiudades.Size = new System.Drawing.Size(442, 343);
            this.gdrCiudades.TabIndex = 23;
            this.gdrCiudades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrCiudades_CellClick);
            // 
            // lblIdProvincia
            // 
            this.lblIdProvincia.AutoSize = true;
            this.lblIdProvincia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProvincia.ForeColor = System.Drawing.Color.White;
            this.lblIdProvincia.Location = new System.Drawing.Point(354, 201);
            this.lblIdProvincia.Name = "lblIdProvincia";
            this.lblIdProvincia.Size = new System.Drawing.Size(85, 21);
            this.lblIdProvincia.TabIndex = 22;
            this.lblIdProvincia.Text = "Provincia:";
            // 
            // txtNombreCiudad
            // 
            this.txtNombreCiudad.Location = new System.Drawing.Point(473, 131);
            this.txtNombreCiudad.Name = "txtNombreCiudad";
            this.txtNombreCiudad.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCiudad.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(362, 128);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(77, 21);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(310, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 28);
            this.label1.TabIndex = 18;
            this.label1.Text = "Alta de Nueva Ciudad";
            // 
            // lblIdCiudad
            // 
            this.lblIdCiudad.AutoSize = true;
            this.lblIdCiudad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCiudad.ForeColor = System.Drawing.Color.White;
            this.lblIdCiudad.Location = new System.Drawing.Point(346, 91);
            this.lblIdCiudad.Name = "lblIdCiudad";
            this.lblIdCiudad.Size = new System.Drawing.Size(93, 21);
            this.lblIdCiudad.TabIndex = 32;
            this.lblIdCiudad.Text = "Id Ciudad:";
            this.lblIdCiudad.Visible = false;
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Location = new System.Drawing.Point(473, 204);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(100, 21);
            this.cmbProvincia.TabIndex = 33;
            // 
            // txtIdCiudad
            // 
            this.txtIdCiudad.Enabled = false;
            this.txtIdCiudad.Location = new System.Drawing.Point(473, 91);
            this.txtIdCiudad.Name = "txtIdCiudad";
            this.txtIdCiudad.Size = new System.Drawing.Size(100, 20);
            this.txtIdCiudad.TabIndex = 34;
            this.txtIdCiudad.Visible = false;
            // 
            // cmbPais
            // 
            this.cmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(473, 165);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(100, 21);
            this.cmbPais.TabIndex = 35;
            this.cmbPais.SelectedIndexChanged += new System.EventHandler(this.cmbPais_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(396, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 21);
            this.label2.TabIndex = 36;
            this.label2.Text = "Pais:";
            // 
            // IdCiudad
            // 
            this.IdCiudad.DataPropertyName = "idCiudad";
            this.IdCiudad.HeaderText = "IdCiudad";
            this.IdCiudad.Name = "IdCiudad";
            this.IdCiudad.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // IdProvincia
            // 
            this.IdProvincia.DataPropertyName = "nombreProvincia";
            this.IdProvincia.HeaderText = "Provincia";
            this.IdProvincia.Name = "IdProvincia";
            this.IdProvincia.ReadOnly = true;
            // 
            // Pais
            // 
            this.Pais.DataPropertyName = "nombrePais";
            this.Pais.HeaderText = "Pais";
            this.Pais.Name = "Pais";
            this.Pais.ReadOnly = true;
            // 
            // AltaCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1144, 431);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPais);
            this.Controls.Add(this.txtIdCiudad);
            this.Controls.Add(this.cmbProvincia);
            this.Controls.Add(this.lblIdCiudad);
            this.Controls.Add(this.btnEliminarCiudad);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnActualizarCiudad);
            this.Controls.Add(this.btnGuardarCiudad);
            this.Controls.Add(this.gdrCiudades);
            this.Controls.Add(this.lblIdProvincia);
            this.Controls.Add(this.txtNombreCiudad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AltaCiudad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Nueva Ciudad";
            this.Load += new System.EventHandler(this.AltaCiudad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdrCiudades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEliminarCiudad;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnActualizarCiudad;
        private System.Windows.Forms.Button btnGuardarCiudad;
        private System.Windows.Forms.DataGridView gdrCiudades;
        private System.Windows.Forms.Label lblIdProvincia;
        private System.Windows.Forms.TextBox txtNombreCiudad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIdCiudad;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.TextBox txtIdCiudad;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCiudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProvincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pais;
    }
}