namespace TPI
{
    partial class AltaEmpleado
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
            this.btnGuardarEmpleado = new System.Windows.Forms.Button();
            this.txtNroCasa = new System.Windows.Forms.TextBox();
            this.lblNroCasa = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.txtNroDocumento = new System.Windows.Forms.MaskedTextBox();
            this.lblNroDocumento = new System.Windows.Forms.Label();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.txtCuil = new System.Windows.Forms.TextBox();
            this.lblCuil = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblGerente = new System.Windows.Forms.Label();
            this.btnActualizarEmpleado = new System.Windows.Forms.Button();
            this.btnBorrarEmpleado = new System.Windows.Forms.Button();
            this.grillaEmpleados = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroCasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gerente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.chkGerente = new System.Windows.Forms.CheckBox();
            this.txtFechaIngreso = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grillaEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardarEmpleado
            // 
            this.btnGuardarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.btnGuardarEmpleado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnGuardarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarEmpleado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarEmpleado.ForeColor = System.Drawing.Color.LightGray;
            this.btnGuardarEmpleado.Location = new System.Drawing.Point(452, 420);
            this.btnGuardarEmpleado.Name = "btnGuardarEmpleado";
            this.btnGuardarEmpleado.Size = new System.Drawing.Size(110, 50);
            this.btnGuardarEmpleado.TabIndex = 12;
            this.btnGuardarEmpleado.Text = "Guardar Empleado";
            this.btnGuardarEmpleado.UseVisualStyleBackColor = false;
            this.btnGuardarEmpleado.Click += new System.EventHandler(this.btnGuardarEmpleado_Click);
            // 
            // txtNroCasa
            // 
            this.txtNroCasa.BackColor = System.Drawing.Color.White;
            this.txtNroCasa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNroCasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroCasa.ForeColor = System.Drawing.Color.Black;
            this.txtNroCasa.Location = new System.Drawing.Point(378, 217);
            this.txtNroCasa.Name = "txtNroCasa";
            this.txtNroCasa.Size = new System.Drawing.Size(169, 20);
            this.txtNroCasa.TabIndex = 6;
            // 
            // lblNroCasa
            // 
            this.lblNroCasa.AutoSize = true;
            this.lblNroCasa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroCasa.ForeColor = System.Drawing.Color.White;
            this.lblNroCasa.Location = new System.Drawing.Point(265, 217);
            this.lblNroCasa.Name = "lblNroCasa";
            this.lblNroCasa.Size = new System.Drawing.Size(99, 21);
            this.lblNroCasa.TabIndex = 30;
            this.lblNroCasa.Text = "N° de casa:";
            // 
            // txtCalle
            // 
            this.txtCalle.BackColor = System.Drawing.Color.White;
            this.txtCalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalle.ForeColor = System.Drawing.Color.Black;
            this.txtCalle.Location = new System.Drawing.Point(378, 191);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(169, 20);
            this.txtCalle.TabIndex = 5;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalle.ForeColor = System.Drawing.Color.White;
            this.lblCalle.Location = new System.Drawing.Point(311, 191);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(54, 21);
            this.lblCalle.TabIndex = 28;
            this.lblCalle.Text = "Calle:";
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.BackColor = System.Drawing.Color.White;
            this.txtNroDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNroDocumento.ForeColor = System.Drawing.Color.Black;
            this.txtNroDocumento.Location = new System.Drawing.Point(376, 317);
            this.txtNroDocumento.Mask = "99999999";
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.Size = new System.Drawing.Size(70, 20);
            this.txtNroDocumento.TabIndex = 9;
            this.txtNroDocumento.ValidatingType = typeof(int);
            // 
            // lblNroDocumento
            // 
            this.lblNroDocumento.AutoSize = true;
            this.lblNroDocumento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroDocumento.ForeColor = System.Drawing.Color.White;
            this.lblNroDocumento.Location = new System.Drawing.Point(214, 317);
            this.lblNroDocumento.Name = "lblNroDocumento";
            this.lblNroDocumento.Size = new System.Drawing.Size(154, 21);
            this.lblNroDocumento.TabIndex = 26;
            this.lblNroDocumento.Text = "N° de documento:";
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.BackColor = System.Drawing.Color.White;
            this.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoDocumento.ForeColor = System.Drawing.Color.Black;
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(376, 290);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(169, 21);
            this.cmbTipoDocumento.TabIndex = 8;
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDocumento.ForeColor = System.Drawing.Color.White;
            this.lblTipoDocumento.Location = new System.Drawing.Point(198, 291);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(168, 21);
            this.lblTipoDocumento.TabIndex = 24;
            this.lblTipoDocumento.Text = "Tipo de documento:";
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.White;
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.Color.Black;
            this.txtApellido.Location = new System.Drawing.Point(376, 87);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(171, 20);
            this.txtApellido.TabIndex = 1;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.White;
            this.lblApellido.Location = new System.Drawing.Point(285, 87);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(78, 21);
            this.lblApellido.TabIndex = 18;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(376, 61);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(171, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(285, 61);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(77, 21);
            this.lblNombre.TabIndex = 16;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegajo.ForeColor = System.Drawing.Color.White;
            this.lblLegajo.Location = new System.Drawing.Point(293, 113);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(66, 21);
            this.lblLegajo.TabIndex = 32;
            this.lblLegajo.Text = "Legajo:";
            // 
            // txtLegajo
            // 
            this.txtLegajo.BackColor = System.Drawing.Color.White;
            this.txtLegajo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLegajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLegajo.ForeColor = System.Drawing.Color.Black;
            this.txtLegajo.Location = new System.Drawing.Point(376, 113);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(171, 20);
            this.txtLegajo.TabIndex = 3;
            // 
            // txtCuil
            // 
            this.txtCuil.BackColor = System.Drawing.Color.White;
            this.txtCuil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCuil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuil.ForeColor = System.Drawing.Color.Black;
            this.txtCuil.Location = new System.Drawing.Point(376, 264);
            this.txtCuil.Name = "txtCuil";
            this.txtCuil.Size = new System.Drawing.Size(169, 20);
            this.txtCuil.TabIndex = 7;
            // 
            // lblCuil
            // 
            this.lblCuil.AutoSize = true;
            this.lblCuil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuil.ForeColor = System.Drawing.Color.White;
            this.lblCuil.Location = new System.Drawing.Point(310, 264);
            this.lblCuil.Name = "lblCuil";
            this.lblCuil.Size = new System.Drawing.Size(50, 21);
            this.lblCuil.TabIndex = 35;
            this.lblCuil.Text = "CUIL:";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.ForeColor = System.Drawing.Color.White;
            this.lblCiudad.Location = new System.Drawing.Point(295, 162);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(73, 21);
            this.lblCiudad.TabIndex = 36;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // lblGerente
            // 
            this.lblGerente.AutoSize = true;
            this.lblGerente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGerente.ForeColor = System.Drawing.Color.White;
            this.lblGerente.Location = new System.Drawing.Point(280, 388);
            this.lblGerente.Name = "lblGerente";
            this.lblGerente.Size = new System.Drawing.Size(80, 21);
            this.lblGerente.TabIndex = 38;
            this.lblGerente.Text = "Gerente:";
            // 
            // btnActualizarEmpleado
            // 
            this.btnActualizarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.btnActualizarEmpleado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnActualizarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarEmpleado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarEmpleado.ForeColor = System.Drawing.Color.LightGray;
            this.btnActualizarEmpleado.Location = new System.Drawing.Point(336, 420);
            this.btnActualizarEmpleado.Name = "btnActualizarEmpleado";
            this.btnActualizarEmpleado.Size = new System.Drawing.Size(110, 50);
            this.btnActualizarEmpleado.TabIndex = 41;
            this.btnActualizarEmpleado.Text = "Actualizar Empleado";
            this.btnActualizarEmpleado.UseVisualStyleBackColor = false;
            this.btnActualizarEmpleado.Click += new System.EventHandler(this.btnActualizarEmpleado_Click);
            // 
            // btnBorrarEmpleado
            // 
            this.btnBorrarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.btnBorrarEmpleado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnBorrarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarEmpleado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarEmpleado.ForeColor = System.Drawing.Color.LightGray;
            this.btnBorrarEmpleado.Location = new System.Drawing.Point(218, 490);
            this.btnBorrarEmpleado.Name = "btnBorrarEmpleado";
            this.btnBorrarEmpleado.Size = new System.Drawing.Size(110, 50);
            this.btnBorrarEmpleado.TabIndex = 42;
            this.btnBorrarEmpleado.Text = "Borrar Empleado";
            this.btnBorrarEmpleado.UseVisualStyleBackColor = false;
            this.btnBorrarEmpleado.Click += new System.EventHandler(this.btnBorrarEmpleado_Click);
            // 
            // grillaEmpleados
            // 
            this.grillaEmpleados.AllowUserToAddRows = false;
            this.grillaEmpleados.AllowUserToDeleteRows = false;
            this.grillaEmpleados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.grillaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.apellido,
            this.legajo,
            this.cuil,
            this.tipoDocumento,
            this.nroDocumento,
            this.ciudad,
            this.calle,
            this.nroCasa,
            this.fechaIngreso,
            this.gerente});
            this.grillaEmpleados.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.grillaEmpleados.Location = new System.Drawing.Point(568, 34);
            this.grillaEmpleados.Name = "grillaEmpleados";
            this.grillaEmpleados.ReadOnly = true;
            this.grillaEmpleados.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.grillaEmpleados.Size = new System.Drawing.Size(814, 543);
            this.grillaEmpleados.TabIndex = 43;
            this.grillaEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaEmpleados_CellClick);
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 80;
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "apellido";
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            this.apellido.Width = 80;
            // 
            // legajo
            // 
            this.legajo.DataPropertyName = "legajo";
            this.legajo.HeaderText = "Legajo";
            this.legajo.Name = "legajo";
            this.legajo.ReadOnly = true;
            this.legajo.Width = 50;
            // 
            // cuil
            // 
            this.cuil.DataPropertyName = "cuil";
            this.cuil.HeaderText = "CUIL";
            this.cuil.Name = "cuil";
            this.cuil.ReadOnly = true;
            this.cuil.Width = 80;
            // 
            // tipoDocumento
            // 
            this.tipoDocumento.DataPropertyName = "tipoDoc";
            this.tipoDocumento.HeaderText = "Tipo doc";
            this.tipoDocumento.Name = "tipoDocumento";
            this.tipoDocumento.ReadOnly = true;
            this.tipoDocumento.Width = 40;
            // 
            // nroDocumento
            // 
            this.nroDocumento.DataPropertyName = "nroDoc";
            this.nroDocumento.HeaderText = "Nº Doc";
            this.nroDocumento.Name = "nroDocumento";
            this.nroDocumento.ReadOnly = true;
            this.nroDocumento.Width = 80;
            // 
            // ciudad
            // 
            this.ciudad.DataPropertyName = "idCiudad";
            this.ciudad.HeaderText = "Ciudad";
            this.ciudad.Name = "ciudad";
            this.ciudad.ReadOnly = true;
            this.ciudad.Width = 80;
            // 
            // calle
            // 
            this.calle.DataPropertyName = "calle";
            this.calle.HeaderText = "Calle";
            this.calle.Name = "calle";
            this.calle.ReadOnly = true;
            this.calle.Width = 80;
            // 
            // nroCasa
            // 
            this.nroCasa.DataPropertyName = "nroCalle";
            this.nroCasa.HeaderText = "Nº Casa";
            this.nroCasa.Name = "nroCasa";
            this.nroCasa.ReadOnly = true;
            this.nroCasa.Width = 50;
            // 
            // fechaIngreso
            // 
            this.fechaIngreso.DataPropertyName = "fechaIngreso";
            this.fechaIngreso.HeaderText = "Fecha ingreso";
            this.fechaIngreso.Name = "fechaIngreso";
            this.fechaIngreso.ReadOnly = true;
            // 
            // gerente
            // 
            this.gerente.DataPropertyName = "gerente";
            this.gerente.HeaderText = "Gerente";
            this.gerente.Name = "gerente";
            this.gerente.ReadOnly = true;
            this.gerente.Width = 50;
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.BackColor = System.Drawing.Color.White;
            this.cmbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCiudad.ForeColor = System.Drawing.Color.Black;
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(378, 164);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(169, 21);
            this.cmbCiudad.TabIndex = 4;
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaIngreso.ForeColor = System.Drawing.Color.White;
            this.lblFechaIngreso.Location = new System.Drawing.Point(233, 358);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(122, 21);
            this.lblFechaIngreso.TabIndex = 46;
            this.lblFechaIngreso.Text = "Fecha ingreso:";
            // 
            // chkGerente
            // 
            this.chkGerente.AutoSize = true;
            this.chkGerente.ForeColor = System.Drawing.Color.White;
            this.chkGerente.Location = new System.Drawing.Point(376, 391);
            this.chkGerente.Name = "chkGerente";
            this.chkGerente.Size = new System.Drawing.Size(35, 17);
            this.chkGerente.TabIndex = 11;
            this.chkGerente.Text = "Si";
            this.chkGerente.UseVisualStyleBackColor = true;
            // 
            // txtFechaIngreso
            // 
            this.txtFechaIngreso.BackColor = System.Drawing.Color.White;
            this.txtFechaIngreso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFechaIngreso.ForeColor = System.Drawing.Color.Black;
            this.txtFechaIngreso.Location = new System.Drawing.Point(376, 361);
            this.txtFechaIngreso.Mask = "00/00/0000";
            this.txtFechaIngreso.Name = "txtFechaIngreso";
            this.txtFechaIngreso.Size = new System.Drawing.Size(70, 20);
            this.txtFechaIngreso.TabIndex = 10;
            this.txtFechaIngreso.ValidatingType = typeof(System.DateTime);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.btnLimpiarCampos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.ForeColor = System.Drawing.Color.LightGray;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(218, 420);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(110, 50);
            this.btnLimpiarCampos.TabIndex = 48;
            this.btnLimpiarCampos.Text = "Limpiar campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.panel1.BackgroundImage = global::TPI.Properties.Resources.descarga;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 596);
            this.panel1.TabIndex = 49;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::TPI.Properties.Resources.Minimize_Icon;
            this.btnMinimizar.Location = new System.Drawing.Point(1334, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(21, 22);
            this.btnMinimizar.TabIndex = 51;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::TPI.Properties.Resources.Close_Icon;
            this.btnCerrar.Location = new System.Drawing.Point(1361, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(21, 22);
            this.btnCerrar.TabIndex = 50;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(255, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 30);
            this.label1.TabIndex = 52;
            this.label1.Text = "Alta de Empleado";
            // 
            // AltaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1400, 596);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.chkGerente);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.txtFechaIngreso);
            this.Controls.Add(this.cmbCiudad);
            this.Controls.Add(this.grillaEmpleados);
            this.Controls.Add(this.btnBorrarEmpleado);
            this.Controls.Add(this.btnActualizarEmpleado);
            this.Controls.Add(this.lblGerente);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.lblCuil);
            this.Controls.Add(this.txtCuil);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.lblLegajo);
            this.Controls.Add(this.txtNroCasa);
            this.Controls.Add(this.lblNroCasa);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.txtNroDocumento);
            this.Controls.Add(this.lblNroDocumento);
            this.Controls.Add(this.cmbTipoDocumento);
            this.Controls.Add(this.lblTipoDocumento);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnGuardarEmpleado);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AltaEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Empleado";
            this.Load += new System.EventHandler(this.AltaEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarEmpleado;
        private System.Windows.Forms.TextBox txtNroCasa;
        private System.Windows.Forms.Label lblNroCasa;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.MaskedTextBox txtNroDocumento;
        private System.Windows.Forms.Label lblNroDocumento;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.TextBox txtCuil;
        private System.Windows.Forms.Label lblCuil;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblGerente;
        private System.Windows.Forms.Button btnActualizarEmpleado;
        private System.Windows.Forms.Button btnBorrarEmpleado;
        private System.Windows.Forms.DataGridView grillaEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuil;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroCasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn gerente;
        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.CheckBox chkGerente;
        private System.Windows.Forms.MaskedTextBox txtFechaIngreso;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label label1;
    }
}