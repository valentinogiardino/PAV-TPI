
namespace TPI
{
    partial class AltaTipoDoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaTipoDoc));
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.txtAgregarTipoDoc = new System.Windows.Forms.TextBox();
            this.grillaTipoDoc = new System.Windows.Forms.DataGridView();
            this.tipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreTipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblnombre = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblIdTipoDoc = new System.Windows.Forms.Label();
            this.txtIdTipoDoc = new System.Windows.Forms.TextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTipoDoc)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDoc.Location = new System.Drawing.Point(190, 20);
            this.lblTipoDoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(277, 33);
            this.lblTipoDoc.TabIndex = 1;
            this.lblTipoDoc.Text = "Tipo de documento";
            // 
            // txtAgregarTipoDoc
            // 
            this.txtAgregarTipoDoc.Location = new System.Drawing.Point(371, 113);
            this.txtAgregarTipoDoc.Name = "txtAgregarTipoDoc";
            this.txtAgregarTipoDoc.Size = new System.Drawing.Size(164, 22);
            this.txtAgregarTipoDoc.TabIndex = 2;
            // 
            // grillaTipoDoc
            // 
            this.grillaTipoDoc.AllowUserToAddRows = false;
            this.grillaTipoDoc.AllowUserToDeleteRows = false;
            this.grillaTipoDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaTipoDoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipoDoc,
            this.nombreTipoDoc});
            this.grillaTipoDoc.Location = new System.Drawing.Point(129, 194);
            this.grillaTipoDoc.Name = "grillaTipoDoc";
            this.grillaTipoDoc.ReadOnly = true;
            this.grillaTipoDoc.RowHeadersWidth = 51;
            this.grillaTipoDoc.RowTemplate.Height = 24;
            this.grillaTipoDoc.Size = new System.Drawing.Size(406, 235);
            this.grillaTipoDoc.TabIndex = 3;
            this.grillaTipoDoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaTipoDoc_CellContentClick);
            // 
            // tipoDoc
            // 
            this.tipoDoc.DataPropertyName = "tipoDoc";
            this.tipoDoc.HeaderText = "ID";
            this.tipoDoc.MinimumWidth = 6;
            this.tipoDoc.Name = "tipoDoc";
            this.tipoDoc.ReadOnly = true;
            this.tipoDoc.Width = 90;
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
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(43, 113);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(272, 24);
            this.lblnombre.TabIndex = 6;
            this.lblnombre.Text = "Nombre tipo de documento:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(420, 152);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(115, 27);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Enabled = false;
            this.btnActualizar.Location = new System.Drawing.Point(276, 152);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(115, 27);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblIdTipoDoc
            // 
            this.lblIdTipoDoc.AutoSize = true;
            this.lblIdTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdTipoDoc.Location = new System.Drawing.Point(97, 76);
            this.lblIdTipoDoc.Name = "lblIdTipoDoc";
            this.lblIdTipoDoc.Size = new System.Drawing.Size(218, 24);
            this.lblIdTipoDoc.TabIndex = 9;
            this.lblIdTipoDoc.Text = "ID Tipo de documento";
            // 
            // txtIdTipoDoc
            // 
            this.txtIdTipoDoc.Enabled = false;
            this.txtIdTipoDoc.Location = new System.Drawing.Point(371, 78);
            this.txtIdTipoDoc.Name = "txtIdTipoDoc";
            this.txtIdTipoDoc.Size = new System.Drawing.Size(164, 22);
            this.txtIdTipoDoc.TabIndex = 10;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Enabled = false;
            this.btnBorrar.Location = new System.Drawing.Point(129, 152);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(115, 27);
            this.btnBorrar.TabIndex = 11;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // AltaTipoDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 441);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.txtIdTipoDoc);
            this.Controls.Add(this.lblIdTipoDoc);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.grillaTipoDoc);
            this.Controls.Add(this.txtAgregarTipoDoc);
            this.Controls.Add(this.lblTipoDoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AltaTipoDoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo Documento";
            this.Load += new System.EventHandler(this.TipoDoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaTipoDoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.TextBox txtAgregarTipoDoc;
        private System.Windows.Forms.DataGridView grillaTipoDoc;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblIdTipoDoc;
        private System.Windows.Forms.TextBox txtIdTipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreTipoDoc;
        private System.Windows.Forms.Button btnBorrar;
    }
}