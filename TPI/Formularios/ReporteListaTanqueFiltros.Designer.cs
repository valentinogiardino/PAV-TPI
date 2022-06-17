
namespace TPI.Formularios
{
    partial class ReporteListaTanqueFiltros
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteListaTanqueFiltros));
            this.label1 = new System.Windows.Forms.Label();
            this.ReporteTanqueFiltro = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNroTanque = new System.Windows.Forms.TextBox();
            this.txtMinLit = new System.Windows.Forms.TextBox();
            this.cmbEstacion = new System.Windows.Forms.ComboBox();
            this.cmbTipoComb = new System.Windows.Forms.ComboBox();
            this.txtVolMax = new System.Windows.Forms.TextBox();
            this.txtVolDisp = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.bD3K7G09_2021DataSet = new TPI.BD3K7G09_2021DataSet();
            this.bD3K7G092021DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K7G09_2021DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K7G092021DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtros";
            // 
            // ReporteTanqueFiltro
            // 
            this.ReporteTanqueFiltro.BackColor = System.Drawing.Color.DarkCyan;
            this.ReporteTanqueFiltro.LocalReport.ReportEmbeddedResource = "TPI.ConjuntoDeDatos.DatosTanque.rdlc";
            this.ReporteTanqueFiltro.Location = new System.Drawing.Point(6, 293);
            this.ReporteTanqueFiltro.Name = "ReporteTanqueFiltro";
            this.ReporteTanqueFiltro.ServerReport.BearerToken = null;
            this.ReporteTanqueFiltro.Size = new System.Drawing.Size(776, 459);
            this.ReporteTanqueFiltro.TabIndex = 3;
            this.ReporteTanqueFiltro.Load += new System.EventHandler(this.ReporteTanqueFiltro_Load);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nro de Tanque:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(92, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Estación:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Volumen Máximo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tipo Combustible:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(21, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mínimo de Litros:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(374, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 22);
            this.label7.TabIndex = 9;
            this.label7.Text = "Volúmen Disponible:";
            // 
            // txtNroTanque
            // 
            this.txtNroTanque.Location = new System.Drawing.Point(188, 84);
            this.txtNroTanque.Name = "txtNroTanque";
            this.txtNroTanque.Size = new System.Drawing.Size(155, 20);
            this.txtNroTanque.TabIndex = 11;
            // 
            // txtMinLit
            // 
            this.txtMinLit.Location = new System.Drawing.Point(188, 267);
            this.txtMinLit.Name = "txtMinLit";
            this.txtMinLit.Size = new System.Drawing.Size(152, 20);
            this.txtMinLit.TabIndex = 12;
            // 
            // cmbEstacion
            // 
            this.cmbEstacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstacion.FormattingEnabled = true;
            this.cmbEstacion.Location = new System.Drawing.Point(188, 132);
            this.cmbEstacion.Name = "cmbEstacion";
            this.cmbEstacion.Size = new System.Drawing.Size(155, 21);
            this.cmbEstacion.TabIndex = 13;
            // 
            // cmbTipoComb
            // 
            this.cmbTipoComb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoComb.FormattingEnabled = true;
            this.cmbTipoComb.Location = new System.Drawing.Point(188, 223);
            this.cmbTipoComb.Name = "cmbTipoComb";
            this.cmbTipoComb.Size = new System.Drawing.Size(152, 21);
            this.cmbTipoComb.TabIndex = 14;
            // 
            // txtVolMax
            // 
            this.txtVolMax.Location = new System.Drawing.Point(188, 176);
            this.txtVolMax.Name = "txtVolMax";
            this.txtVolMax.Size = new System.Drawing.Size(155, 20);
            this.txtVolMax.TabIndex = 15;
            // 
            // txtVolDisp
            // 
            this.txtVolDisp.Location = new System.Drawing.Point(569, 84);
            this.txtVolDisp.Name = "txtVolDisp";
            this.txtVolDisp.Size = new System.Drawing.Size(152, 20);
            this.txtVolDisp.TabIndex = 16;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(189)))));
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(450, 226);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(119, 59);
            this.btnLimpiar.TabIndex = 18;
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(189)))));
            this.btnGenerarReporte.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnGenerarReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnGenerarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarReporte.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporte.ForeColor = System.Drawing.Color.White;
            this.btnGenerarReporte.Location = new System.Drawing.Point(601, 226);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(119, 59);
            this.btnGenerarReporte.TabIndex = 17;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = false;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // bD3K7G09_2021DataSet
            // 
            this.bD3K7G09_2021DataSet.DataSetName = "BD3K7G09_2021DataSet";
            this.bD3K7G09_2021DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bD3K7G092021DataSetBindingSource
            // 
            this.bD3K7G092021DataSetBindingSource.DataSource = this.bD3K7G09_2021DataSet;
            this.bD3K7G092021DataSetBindingSource.Position = 0;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::TPI.Properties.Resources.Minimize_Icon;
            this.btnMinimizar.Location = new System.Drawing.Point(733, 11);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(21, 22);
            this.btnMinimizar.TabIndex = 26;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::TPI.Properties.Resources.Close_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(761, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 22);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ReporteListaTanqueFiltros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(800, 764);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.txtVolDisp);
            this.Controls.Add(this.txtVolMax);
            this.Controls.Add(this.cmbTipoComb);
            this.Controls.Add(this.cmbEstacion);
            this.Controls.Add(this.txtMinLit);
            this.Controls.Add(this.txtNroTanque);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ReporteTanqueFiltro);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ReporteListaTanqueFiltros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteListaTanqueFiltros";
            this.Load += new System.EventHandler(this.ReporteListaTanqueFiltros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD3K7G09_2021DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K7G092021DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer ReporteTanqueFiltro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNroTanque;
        private System.Windows.Forms.TextBox txtMinLit;
        private System.Windows.Forms.ComboBox cmbEstacion;
        private System.Windows.Forms.ComboBox cmbTipoComb;
        private System.Windows.Forms.TextBox txtVolMax;
        private System.Windows.Forms.TextBox txtVolDisp;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGenerarReporte;
        private BD3K7G09_2021DataSet bD3K7G09_2021DataSet;
        private System.Windows.Forms.BindingSource bD3K7G092021DataSetBindingSource;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}