
namespace TPI.Formularios
{
    partial class ListadoAsistenciasFiltros
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
            this.reporteAsistenciaFiltros = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmbCuitEstacion = new System.Windows.Forms.ComboBox();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.cmbNroDoc = new System.Windows.Forms.ComboBox();
            this.maskedFecha = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnBuscarAsistencia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reporteAsistenciaFiltros
            // 
            this.reporteAsistenciaFiltros.BackColor = System.Drawing.Color.DarkCyan;
            this.reporteAsistenciaFiltros.Location = new System.Drawing.Point(78, 279);
            this.reporteAsistenciaFiltros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reporteAsistenciaFiltros.Name = "reporteAsistenciaFiltros";
            this.reporteAsistenciaFiltros.ServerReport.BearerToken = null;
            this.reporteAsistenciaFiltros.Size = new System.Drawing.Size(869, 337);
            this.reporteAsistenciaFiltros.TabIndex = 0;
            // 
            // cmbCuitEstacion
            // 
            this.cmbCuitEstacion.FormattingEnabled = true;
            this.cmbCuitEstacion.Location = new System.Drawing.Point(192, 105);
            this.cmbCuitEstacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCuitEstacion.Name = "cmbCuitEstacion";
            this.cmbCuitEstacion.Size = new System.Drawing.Size(179, 24);
            this.cmbCuitEstacion.TabIndex = 1;
            // 
            // cmbTurno
            // 
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location = new System.Drawing.Point(192, 161);
            this.cmbTurno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(179, 24);
            this.cmbTurno.TabIndex = 3;
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Location = new System.Drawing.Point(499, 102);
            this.cmbTipoDoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(179, 24);
            this.cmbTipoDoc.TabIndex = 5;
            // 
            // cmbNroDoc
            // 
            this.cmbNroDoc.FormattingEnabled = true;
            this.cmbNroDoc.Location = new System.Drawing.Point(499, 159);
            this.cmbNroDoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbNroDoc.Name = "cmbNroDoc";
            this.cmbNroDoc.Size = new System.Drawing.Size(179, 24);
            this.cmbNroDoc.TabIndex = 7;
            // 
            // maskedFecha
            // 
            this.maskedFecha.Location = new System.Drawing.Point(799, 159);
            this.maskedFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maskedFecha.Mask = "00/00/0000";
            this.maskedFecha.Name = "maskedFecha";
            this.maskedFecha.Size = new System.Drawing.Size(148, 23);
            this.maskedFecha.TabIndex = 9;
            this.maskedFecha.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(75, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cuit Estacion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(729, 161);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(419, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "NroDoc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(409, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo Doc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(114, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Turno:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label6.Location = new System.Drawing.Point(336, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(354, 28);
            this.label6.TabIndex = 19;
            this.label6.Text = "Listado Asistencias con Filtros";
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
            this.btnLimpiarCampos.Location = new System.Drawing.Point(698, 208);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(115, 52);
            this.btnLimpiarCampos.TabIndex = 20;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            // 
            // btnBuscarAsistencia
            // 
            this.btnBuscarAsistencia.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnBuscarAsistencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.btnBuscarAsistencia.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnBuscarAsistencia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnBuscarAsistencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnBuscarAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarAsistencia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAsistencia.ForeColor = System.Drawing.Color.LightGray;
            this.btnBuscarAsistencia.Location = new System.Drawing.Point(832, 208);
            this.btnBuscarAsistencia.Name = "btnBuscarAsistencia";
            this.btnBuscarAsistencia.Size = new System.Drawing.Size(115, 52);
            this.btnBuscarAsistencia.TabIndex = 21;
            this.btnBuscarAsistencia.Text = "Buscar Asistencia";
            this.btnBuscarAsistencia.UseVisualStyleBackColor = false;
            // 
            // ListadoAsistenciasFiltros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(994, 663);
            this.Controls.Add(this.btnBuscarAsistencia);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskedFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbNroDoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTipoDoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCuitEstacion);
            this.Controls.Add(this.reporteAsistenciaFiltros);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ListadoAsistenciasFiltros";
            this.Text = "Listado Asistencias con Filtros";
            this.Load += new System.EventHandler(this.ListadoAsistenciasFiltros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reporteAsistenciaFiltros;
        private System.Windows.Forms.ComboBox cmbCuitEstacion;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.ComboBox cmbTipoDoc;
        private System.Windows.Forms.ComboBox cmbNroDoc;
        private System.Windows.Forms.MaskedTextBox maskedFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnBuscarAsistencia;
    }
}