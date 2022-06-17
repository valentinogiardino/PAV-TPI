
namespace TPI
{
    partial class AltaModelo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaModelo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grdModelo = new System.Windows.Forms.DataGridView();
            this.idModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdModelo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alta de Modelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de Modelo:";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(232, 100);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(168, 20);
            this.txtModelo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(139, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Marca :";
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(232, 154);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(168, 21);
            this.cmbMarca.TabIndex = 4;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(280, 322);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 54);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar Modelo";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // grdModelo
            // 
            this.grdModelo.AllowUserToAddRows = false;
            this.grdModelo.AllowUserToDeleteRows = false;
            this.grdModelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdModelo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idModelo,
            this.nombreModelo,
            this.idMarca});
            this.grdModelo.Location = new System.Drawing.Point(451, 100);
            this.grdModelo.Name = "grdModelo";
            this.grdModelo.ReadOnly = true;
            this.grdModelo.Size = new System.Drawing.Size(444, 338);
            this.grdModelo.TabIndex = 6;
            // 
            // idModelo
            // 
            this.idModelo.DataPropertyName = "idModelo";
            this.idModelo.HeaderText = "ID Modelo";
            this.idModelo.Name = "idModelo";
            this.idModelo.ReadOnly = true;
            this.idModelo.Width = 60;
            // 
            // nombreModelo
            // 
            this.nombreModelo.DataPropertyName = "nombreModelo";
            this.nombreModelo.HeaderText = "Nombre de Modelo";
            this.nombreModelo.Name = "nombreModelo";
            this.nombreModelo.ReadOnly = true;
            this.nombreModelo.Width = 175;
            // 
            // idMarca
            // 
            this.idMarca.DataPropertyName = "nombreMarca";
            this.idMarca.HeaderText = "Marca";
            this.idMarca.Name = "idMarca";
            this.idMarca.ReadOnly = true;
            this.idMarca.Width = 175;
            // 
            // AltaModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 450);
            this.Controls.Add(this.grdModelo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AltaModelo";
            this.Text = "Alta de Modelo";
            this.Load += new System.EventHandler(this.AltaModelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdModelo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView grdModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMarca;
    }
}