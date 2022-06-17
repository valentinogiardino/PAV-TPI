
namespace TPI.Formularios
{
    partial class ReporteListadoEstaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteListadoEstaciones));
            this.reportViewerEstaciones = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerEstaciones
            // 
            this.reportViewerEstaciones.BackColor = System.Drawing.Color.DarkCyan;
            this.reportViewerEstaciones.LocalReport.ReportEmbeddedResource = "TPI.ConjuntoDeDatos.ListadoEstaciones.rdlc";
            this.reportViewerEstaciones.Location = new System.Drawing.Point(9, 51);
            this.reportViewerEstaciones.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewerEstaciones.Name = "reportViewerEstaciones";
            this.reportViewerEstaciones.ServerReport.BearerToken = null;
            this.reportViewerEstaciones.Size = new System.Drawing.Size(604, 521);
            this.reportViewerEstaciones.TabIndex = 0;
            this.reportViewerEstaciones.Load += new System.EventHandler(this.reportViewerEstaciones_Load);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::TPI.Properties.Resources.Close_Icon;
            this.btnCerrar.Location = new System.Drawing.Point(592, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(21, 22);
            this.btnCerrar.TabIndex = 43;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::TPI.Properties.Resources.Minimize_Icon;
            this.btnMinimizar.Location = new System.Drawing.Point(565, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(21, 22);
            this.btnMinimizar.TabIndex = 44;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // ReporteListadoEstaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(625, 583);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.reportViewerEstaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReporteListadoEstaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Estaciones";
            this.Load += new System.EventHandler(this.ReporteListadoEstaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerEstaciones;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
    }
}