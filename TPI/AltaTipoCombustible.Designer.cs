
namespace TPI
{
    partial class AltaTipoCombustible
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaTipoCombustible));
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtIdTipoCombustible = new System.Windows.Forms.TextBox();
            this.lblIdTipoCombustible = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblnombre = new System.Windows.Forms.Label();
            this.grillaTipoCombustible = new System.Windows.Forms.DataGridView();
            this.codTipoCombustible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreTipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAgregarTipoCombustible = new System.Windows.Forms.TextBox();
            this.lblTipoCombustible = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTipoCombustible)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBorrar
            // 
            this.btnBorrar.Enabled = false;
            this.btnBorrar.Location = new System.Drawing.Point(120, 151);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(115, 27);
            this.btnBorrar.TabIndex = 20;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // txtIdTipoCombustible
            // 
            this.txtIdTipoCombustible.Enabled = false;
            this.txtIdTipoCombustible.Location = new System.Drawing.Point(362, 77);
            this.txtIdTipoCombustible.Name = "txtIdTipoCombustible";
            this.txtIdTipoCombustible.Size = new System.Drawing.Size(164, 22);
            this.txtIdTipoCombustible.TabIndex = 19;
            // 
            // lblIdTipoCombustible
            // 
            this.lblIdTipoCombustible.AutoSize = true;
            this.lblIdTipoCombustible.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdTipoCombustible.Location = new System.Drawing.Point(88, 75);
            this.lblIdTipoCombustible.Name = "lblIdTipoCombustible";
            this.lblIdTipoCombustible.Size = new System.Drawing.Size(235, 24);
            this.lblIdTipoCombustible.TabIndex = 18;
            this.lblIdTipoCombustible.Text = "ID Tipo de Combustible:";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Enabled = false;
            this.btnActualizar.Location = new System.Drawing.Point(267, 151);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(115, 27);
            this.btnActualizar.TabIndex = 17;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(411, 151);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(115, 27);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(34, 112);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(280, 24);
            this.lblnombre.TabIndex = 15;
            this.lblnombre.Text = "Nombre tipo de combustible:";
            // 
            // grillaTipoCombustible
            // 
            this.grillaTipoCombustible.AllowUserToAddRows = false;
            this.grillaTipoCombustible.AllowUserToDeleteRows = false;
            this.grillaTipoCombustible.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaTipoCombustible.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codTipoCombustible,
            this.nombreTipoDoc});
            this.grillaTipoCombustible.Location = new System.Drawing.Point(120, 193);
            this.grillaTipoCombustible.Name = "grillaTipoCombustible";
            this.grillaTipoCombustible.ReadOnly = true;
            this.grillaTipoCombustible.RowHeadersWidth = 51;
            this.grillaTipoCombustible.RowTemplate.Height = 24;
            this.grillaTipoCombustible.Size = new System.Drawing.Size(406, 235);
            this.grillaTipoCombustible.TabIndex = 14;
            this.grillaTipoCombustible.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaTipoCombustible_CellContentClick);
            // 
            // codTipoCombustible
            // 
            this.codTipoCombustible.DataPropertyName = "codTipoCombustible";
            this.codTipoCombustible.HeaderText = "ID";
            this.codTipoCombustible.MinimumWidth = 6;
            this.codTipoCombustible.Name = "codTipoCombustible";
            this.codTipoCombustible.ReadOnly = true;
            this.codTipoCombustible.Width = 90;
            // 
            // nombreTipoDoc
            // 
            this.nombreTipoDoc.DataPropertyName = "nombre";
            this.nombreTipoDoc.HeaderText = "Nombre";
            this.nombreTipoDoc.MinimumWidth = 6;
            this.nombreTipoDoc.Name = "nombreTipoDoc";
            this.nombreTipoDoc.ReadOnly = true;
            this.nombreTipoDoc.Width = 200;
            // 
            // txtAgregarTipoCombustible
            // 
            this.txtAgregarTipoCombustible.Location = new System.Drawing.Point(362, 112);
            this.txtAgregarTipoCombustible.Name = "txtAgregarTipoCombustible";
            this.txtAgregarTipoCombustible.Size = new System.Drawing.Size(164, 22);
            this.txtAgregarTipoCombustible.TabIndex = 13;
            // 
            // lblTipoCombustible
            // 
            this.lblTipoCombustible.AutoSize = true;
            this.lblTipoCombustible.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCombustible.Location = new System.Drawing.Point(181, 19);
            this.lblTipoCombustible.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoCombustible.Name = "lblTipoCombustible";
            this.lblTipoCombustible.Size = new System.Drawing.Size(282, 33);
            this.lblTipoCombustible.TabIndex = 12;
            this.lblTipoCombustible.Text = "Tipo de combustible";
            // 
            // AltaTipoCombustible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 450);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.txtIdTipoCombustible);
            this.Controls.Add(this.lblIdTipoCombustible);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.grillaTipoCombustible);
            this.Controls.Add(this.txtAgregarTipoCombustible);
            this.Controls.Add(this.lblTipoCombustible);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AltaTipoCombustible";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaTipoCombustible";
            this.Load += new System.EventHandler(this.AltaTipoCombustible_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaTipoCombustible)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox txtIdTipoCombustible;
        private System.Windows.Forms.Label lblIdTipoCombustible;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.DataGridView grillaTipoCombustible;
        private System.Windows.Forms.TextBox txtAgregarTipoCombustible;
        private System.Windows.Forms.Label lblTipoCombustible;
        private System.Windows.Forms.DataGridViewTextBoxColumn codTipoCombustible;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreTipoDoc;
    }
}