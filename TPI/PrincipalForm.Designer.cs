
namespace TPI
{
    partial class PrincipalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm));
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.empleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaEstacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaTanqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.camionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaCamionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaModeloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.combustibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaCombustibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaTipoCombustibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaTurnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.variosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaPaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaProvinciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaCiudadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaTipoDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.Location = new System.Drawing.Point(324, 113);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(128, 24);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "Bienvenido!";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(231)))));
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadoToolStripMenuItem,
            this.estacionesToolStripMenuItem,
            this.camionToolStripMenuItem,
            this.combustibleToolStripMenuItem,
            this.turnoToolStripMenuItem,
            this.variosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // empleadoToolStripMenuItem
            // 
            this.empleadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaEmpleadoToolStripMenuItem});
            this.empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            this.empleadoToolStripMenuItem.Size = new System.Drawing.Size(103, 23);
            this.empleadoToolStripMenuItem.Text = "Empleado";
            // 
            // altaEmpleadoToolStripMenuItem
            // 
            this.altaEmpleadoToolStripMenuItem.Name = "altaEmpleadoToolStripMenuItem";
            this.altaEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.altaEmpleadoToolStripMenuItem.Text = "Alta Empleado";
            // 
            // estacionesToolStripMenuItem
            // 
            this.estacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaEstacionToolStripMenuItem,
            this.altaTanqueToolStripMenuItem});
            this.estacionesToolStripMenuItem.Name = "estacionesToolStripMenuItem";
            this.estacionesToolStripMenuItem.Size = new System.Drawing.Size(89, 23);
            this.estacionesToolStripMenuItem.Text = "Estacion";
            this.estacionesToolStripMenuItem.Click += new System.EventHandler(this.estacionesToolStripMenuItem_Click);
            // 
            // altaEstacionToolStripMenuItem
            // 
            this.altaEstacionToolStripMenuItem.Name = "altaEstacionToolStripMenuItem";
            this.altaEstacionToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.altaEstacionToolStripMenuItem.Text = "Alta Estacion";
            this.altaEstacionToolStripMenuItem.Click += new System.EventHandler(this.altaEstacionToolStripMenuItem_Click);
            // 
            // altaTanqueToolStripMenuItem
            // 
            this.altaTanqueToolStripMenuItem.Name = "altaTanqueToolStripMenuItem";
            this.altaTanqueToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.altaTanqueToolStripMenuItem.Text = "Alta Tanque";
            this.altaTanqueToolStripMenuItem.Click += new System.EventHandler(this.altaTanqueToolStripMenuItem_Click);
            // 
            // camionToolStripMenuItem
            // 
            this.camionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaCamionToolStripMenuItem,
            this.altaModeloToolStripMenuItem,
            this.altaMarcaToolStripMenuItem});
            this.camionToolStripMenuItem.Name = "camionToolStripMenuItem";
            this.camionToolStripMenuItem.Size = new System.Drawing.Size(85, 23);
            this.camionToolStripMenuItem.Text = "Camion";
            // 
            // altaCamionToolStripMenuItem
            // 
            this.altaCamionToolStripMenuItem.Name = "altaCamionToolStripMenuItem";
            this.altaCamionToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.altaCamionToolStripMenuItem.Text = "Alta Camion";
            this.altaCamionToolStripMenuItem.Click += new System.EventHandler(this.altaCamionToolStripMenuItem_Click);
            // 
            // altaModeloToolStripMenuItem
            // 
            this.altaModeloToolStripMenuItem.Name = "altaModeloToolStripMenuItem";
            this.altaModeloToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.altaModeloToolStripMenuItem.Text = "Alta Modelo";
            this.altaModeloToolStripMenuItem.Click += new System.EventHandler(this.altaModeloToolStripMenuItem_Click);
            // 
            // altaMarcaToolStripMenuItem
            // 
            this.altaMarcaToolStripMenuItem.Name = "altaMarcaToolStripMenuItem";
            this.altaMarcaToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.altaMarcaToolStripMenuItem.Text = "Alta Marca";
            this.altaMarcaToolStripMenuItem.Click += new System.EventHandler(this.altaMarcaToolStripMenuItem_Click);
            // 
            // combustibleToolStripMenuItem
            // 
            this.combustibleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaCombustibleToolStripMenuItem,
            this.altaTipoCombustibleToolStripMenuItem});
            this.combustibleToolStripMenuItem.Name = "combustibleToolStripMenuItem";
            this.combustibleToolStripMenuItem.Size = new System.Drawing.Size(123, 23);
            this.combustibleToolStripMenuItem.Text = "Combustible";
            // 
            // altaCombustibleToolStripMenuItem
            // 
            this.altaCombustibleToolStripMenuItem.Name = "altaCombustibleToolStripMenuItem";
            this.altaCombustibleToolStripMenuItem.Size = new System.Drawing.Size(254, 24);
            this.altaCombustibleToolStripMenuItem.Text = "Alta Combustible";
            this.altaCombustibleToolStripMenuItem.Click += new System.EventHandler(this.altaCombustibleToolStripMenuItem_Click);
            // 
            // altaTipoCombustibleToolStripMenuItem
            // 
            this.altaTipoCombustibleToolStripMenuItem.Name = "altaTipoCombustibleToolStripMenuItem";
            this.altaTipoCombustibleToolStripMenuItem.Size = new System.Drawing.Size(254, 24);
            this.altaTipoCombustibleToolStripMenuItem.Text = "Alta Tipo Combustible";
            // 
            // turnoToolStripMenuItem
            // 
            this.turnoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaTurnoToolStripMenuItem});
            this.turnoToolStripMenuItem.Name = "turnoToolStripMenuItem";
            this.turnoToolStripMenuItem.Size = new System.Drawing.Size(61, 23);
            this.turnoToolStripMenuItem.Text = "Turno";
            // 
            // altaTurnoToolStripMenuItem
            // 
            this.altaTurnoToolStripMenuItem.Name = "altaTurnoToolStripMenuItem";
            this.altaTurnoToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.altaTurnoToolStripMenuItem.Text = "Alta Turno";
            this.altaTurnoToolStripMenuItem.Click += new System.EventHandler(this.altaTurnoToolStripMenuItem_Click);
            // 
            // variosToolStripMenuItem
            // 
            this.variosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaPaisToolStripMenuItem,
            this.altaProvinciaToolStripMenuItem,
            this.altaCiudadToolStripMenuItem,
            this.altaTipoDocumentoToolStripMenuItem});
            this.variosToolStripMenuItem.Name = "variosToolStripMenuItem";
            this.variosToolStripMenuItem.Size = new System.Drawing.Size(68, 23);
            this.variosToolStripMenuItem.Text = "Varios";
            // 
            // altaPaisToolStripMenuItem
            // 
            this.altaPaisToolStripMenuItem.Name = "altaPaisToolStripMenuItem";
            this.altaPaisToolStripMenuItem.Size = new System.Drawing.Size(247, 24);
            this.altaPaisToolStripMenuItem.Text = "Alta Pais";
            this.altaPaisToolStripMenuItem.Click += new System.EventHandler(this.altaPaisToolStripMenuItem_Click);
            // 
            // altaProvinciaToolStripMenuItem
            // 
            this.altaProvinciaToolStripMenuItem.Name = "altaProvinciaToolStripMenuItem";
            this.altaProvinciaToolStripMenuItem.Size = new System.Drawing.Size(247, 24);
            this.altaProvinciaToolStripMenuItem.Text = "Alta Provincia";
            this.altaProvinciaToolStripMenuItem.Click += new System.EventHandler(this.altaProvinciaToolStripMenuItem_Click);
            // 
            // altaCiudadToolStripMenuItem
            // 
            this.altaCiudadToolStripMenuItem.Name = "altaCiudadToolStripMenuItem";
            this.altaCiudadToolStripMenuItem.Size = new System.Drawing.Size(247, 24);
            this.altaCiudadToolStripMenuItem.Text = "Alta Ciudad";
            this.altaCiudadToolStripMenuItem.Click += new System.EventHandler(this.altaCiudadToolStripMenuItem_Click);
            // 
            // altaTipoDocumentoToolStripMenuItem
            // 
            this.altaTipoDocumentoToolStripMenuItem.Name = "altaTipoDocumentoToolStripMenuItem";
            this.altaTipoDocumentoToolStripMenuItem.Size = new System.Drawing.Size(247, 24);
            this.altaTipoDocumentoToolStripMenuItem.Text = "Alta Tipo Documento";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(231)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::TPI.Properties.Resources.Close_Icon;
            this.btnCerrar.Location = new System.Drawing.Point(767, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(21, 22);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(231)))));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::TPI.Properties.Resources.Minimize_Icon;
            this.btnMinimizar.Location = new System.Drawing.Point(740, 5);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(21, 22);
            this.btnMinimizar.TabIndex = 7;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem camionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaCamionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaModeloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaEstacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaTanqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem combustibleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaCombustibleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaTipoCombustibleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaTurnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem variosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaPaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaProvinciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaCiudadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaTipoDocumentoToolStripMenuItem;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
    }
}