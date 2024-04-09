namespace FlightSoftSolutions
{
    partial class frmGestionAeropuertos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionAeropuertos));
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.tcAeropuertos = new System.Windows.Forms.TabControl();
            this.tpDatosGenerales = new System.Windows.Forms.TabPage();
            this.btnSubirFoto = new System.Windows.Forms.Button();
            this.gbDatosOperadora = new System.Windows.Forms.GroupBox();
            this.btnBuscarOperadora = new System.Windows.Forms.Button();
            this.txtOperadoraAsignada = new System.Windows.Forms.TextBox();
            this.lblOperadoraAsignada = new System.Windows.Forms.Label();
            this.cbWIFI = new System.Windows.Forms.CheckBox();
            this.cbSistemaGestEquipaje = new System.Windows.Forms.CheckBox();
            this.txtCostoConstruccion = new System.Windows.Forms.TextBox();
            this.lblCostoConstruccion = new System.Windows.Forms.Label();
            this.cbSalaVIP = new System.Windows.Forms.CheckBox();
            this.lblCaracteristicasAdicionales = new System.Windows.Forms.Label();
            this.rbInternacional = new System.Windows.Forms.RadioButton();
            this.rbNacional = new System.Windows.Forms.RadioButton();
            this.lblTipoAeropuerto = new System.Windows.Forms.Label();
            this.dtpAnhoFundacion = new System.Windows.Forms.DateTimePicker();
            this.lblAnhoFundacion = new System.Windows.Forms.Label();
            this.cboCiudad = new System.Windows.Forms.ComboBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtIDAeropuerto = new System.Windows.Forms.TextBox();
            this.lblIDAeropuerto = new System.Windows.Forms.Label();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.tbEmpresasAsociadas = new System.Windows.Forms.TabPage();
            this.btnEliminarEmpresaComercial = new System.Windows.Forms.Button();
            this.btnAgregarEmpresaComercial = new System.Windows.Forms.Button();
            this.txtNombreEmpresa = new System.Windows.Forms.TextBox();
            this.btnBuscarEmpresaComercial = new System.Windows.Forms.Button();
            this.txtTipoEmpresa = new System.Windows.Forms.TextBox();
            this.lblNombreEmpresa = new System.Windows.Forms.Label();
            this.lblTipoEmpresa = new System.Windows.Forms.Label();
            this.dgvEmpresasComerciales = new System.Windows.Forms.DataGridView();
            this.TipoEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Callsign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumAvi_CantEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblGestionAeropuertos = new System.Windows.Forms.Label();
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            this.tsMenu.SuspendLayout();
            this.tcAeropuertos.SuspendLayout();
            this.tpDatosGenerales.SuspendLayout();
            this.gbDatosOperadora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.tbEmpresasAsociadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresasComerciales)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.btnBuscar,
            this.btnCancelar});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(1029, 25);
            this.tsMenu.TabIndex = 0;
            this.tsMenu.Text = "tsMenu";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(66, 22);
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(76, 22);
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::FlightSoftSolutions.Properties.Resources.Search;
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(66, 22);
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::FlightSoftSolutions.Properties.Resources.Cancel;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(78, 22);
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tcAeropuertos
            // 
            this.tcAeropuertos.Controls.Add(this.tpDatosGenerales);
            this.tcAeropuertos.Controls.Add(this.tbEmpresasAsociadas);
            this.tcAeropuertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcAeropuertos.Location = new System.Drawing.Point(12, 66);
            this.tcAeropuertos.Name = "tcAeropuertos";
            this.tcAeropuertos.SelectedIndex = 0;
            this.tcAeropuertos.Size = new System.Drawing.Size(1001, 340);
            this.tcAeropuertos.TabIndex = 1;
            // 
            // tpDatosGenerales
            // 
            this.tpDatosGenerales.BackColor = System.Drawing.SystemColors.Control;
            this.tpDatosGenerales.Controls.Add(this.btnSubirFoto);
            this.tpDatosGenerales.Controls.Add(this.gbDatosOperadora);
            this.tpDatosGenerales.Controls.Add(this.cbWIFI);
            this.tpDatosGenerales.Controls.Add(this.cbSistemaGestEquipaje);
            this.tpDatosGenerales.Controls.Add(this.txtCostoConstruccion);
            this.tpDatosGenerales.Controls.Add(this.lblCostoConstruccion);
            this.tpDatosGenerales.Controls.Add(this.cbSalaVIP);
            this.tpDatosGenerales.Controls.Add(this.lblCaracteristicasAdicionales);
            this.tpDatosGenerales.Controls.Add(this.rbInternacional);
            this.tpDatosGenerales.Controls.Add(this.rbNacional);
            this.tpDatosGenerales.Controls.Add(this.lblTipoAeropuerto);
            this.tpDatosGenerales.Controls.Add(this.dtpAnhoFundacion);
            this.tpDatosGenerales.Controls.Add(this.lblAnhoFundacion);
            this.tpDatosGenerales.Controls.Add(this.cboCiudad);
            this.tpDatosGenerales.Controls.Add(this.lblCiudad);
            this.tpDatosGenerales.Controls.Add(this.txtDireccion);
            this.tpDatosGenerales.Controls.Add(this.lblDireccion);
            this.tpDatosGenerales.Controls.Add(this.txtNombre);
            this.tpDatosGenerales.Controls.Add(this.lblNombre);
            this.tpDatosGenerales.Controls.Add(this.txtIDAeropuerto);
            this.tpDatosGenerales.Controls.Add(this.lblIDAeropuerto);
            this.tpDatosGenerales.Controls.Add(this.pbFoto);
            this.tpDatosGenerales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpDatosGenerales.Location = new System.Drawing.Point(4, 24);
            this.tpDatosGenerales.Name = "tpDatosGenerales";
            this.tpDatosGenerales.Padding = new System.Windows.Forms.Padding(3);
            this.tpDatosGenerales.Size = new System.Drawing.Size(993, 312);
            this.tpDatosGenerales.TabIndex = 0;
            this.tpDatosGenerales.Text = "Datos Generales";
            // 
            // btnSubirFoto
            // 
            this.btnSubirFoto.BackgroundImage = global::FlightSoftSolutions.Properties.Resources.Upload;
            this.btnSubirFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubirFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubirFoto.Location = new System.Drawing.Point(246, 182);
            this.btnSubirFoto.Name = "btnSubirFoto";
            this.btnSubirFoto.Size = new System.Drawing.Size(46, 34);
            this.btnSubirFoto.TabIndex = 21;
            this.btnSubirFoto.UseVisualStyleBackColor = true;
            this.btnSubirFoto.Click += new System.EventHandler(this.btnSubirFoto_Click);
            // 
            // gbDatosOperadora
            // 
            this.gbDatosOperadora.Controls.Add(this.btnBuscarOperadora);
            this.gbDatosOperadora.Controls.Add(this.txtOperadoraAsignada);
            this.gbDatosOperadora.Controls.Add(this.lblOperadoraAsignada);
            this.gbDatosOperadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosOperadora.Location = new System.Drawing.Point(15, 232);
            this.gbDatosOperadora.Name = "gbDatosOperadora";
            this.gbDatosOperadora.Size = new System.Drawing.Size(961, 64);
            this.gbDatosOperadora.TabIndex = 20;
            this.gbDatosOperadora.TabStop = false;
            this.gbDatosOperadora.Text = "Datos de la Operadora";
            // 
            // btnBuscarOperadora
            // 
            this.btnBuscarOperadora.BackgroundImage = global::FlightSoftSolutions.Properties.Resources.Search;
            this.btnBuscarOperadora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscarOperadora.Location = new System.Drawing.Point(920, 27);
            this.btnBuscarOperadora.Name = "btnBuscarOperadora";
            this.btnBuscarOperadora.Size = new System.Drawing.Size(35, 23);
            this.btnBuscarOperadora.TabIndex = 2;
            this.btnBuscarOperadora.UseVisualStyleBackColor = true;
            this.btnBuscarOperadora.Click += new System.EventHandler(this.btnBuscarOperadora_Click);
            // 
            // txtOperadoraAsignada
            // 
            this.txtOperadoraAsignada.Location = new System.Drawing.Point(257, 28);
            this.txtOperadoraAsignada.Name = "txtOperadoraAsignada";
            this.txtOperadoraAsignada.ReadOnly = true;
            this.txtOperadoraAsignada.Size = new System.Drawing.Size(657, 21);
            this.txtOperadoraAsignada.TabIndex = 1;
            // 
            // lblOperadoraAsignada
            // 
            this.lblOperadoraAsignada.AutoSize = true;
            this.lblOperadoraAsignada.Location = new System.Drawing.Point(19, 31);
            this.lblOperadoraAsignada.Name = "lblOperadoraAsignada";
            this.lblOperadoraAsignada.Size = new System.Drawing.Size(232, 15);
            this.lblOperadoraAsignada.TabIndex = 0;
            this.lblOperadoraAsignada.Text = "Operadora Asignada al Aeropuerto:";
            // 
            // cbWIFI
            // 
            this.cbWIFI.AutoSize = true;
            this.cbWIFI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWIFI.Location = new System.Drawing.Point(634, 190);
            this.cbWIFI.Name = "cbWIFI";
            this.cbWIFI.Size = new System.Drawing.Size(59, 19);
            this.cbWIFI.TabIndex = 19;
            this.cbWIFI.Text = "WI-FI";
            this.cbWIFI.UseVisualStyleBackColor = true;
            // 
            // cbSistemaGestEquipaje
            // 
            this.cbSistemaGestEquipaje.AutoSize = true;
            this.cbSistemaGestEquipaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSistemaGestEquipaje.Location = new System.Drawing.Point(744, 189);
            this.cbSistemaGestEquipaje.Name = "cbSistemaGestEquipaje";
            this.cbSistemaGestEquipaje.Size = new System.Drawing.Size(232, 19);
            this.cbSistemaGestEquipaje.TabIndex = 18;
            this.cbSistemaGestEquipaje.Text = "Sistema de Gestión de Equipaje";
            this.cbSistemaGestEquipaje.UseVisualStyleBackColor = true;
            // 
            // txtCostoConstruccion
            // 
            this.txtCostoConstruccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoConstruccion.Location = new System.Drawing.Point(808, 131);
            this.txtCostoConstruccion.Name = "txtCostoConstruccion";
            this.txtCostoConstruccion.Size = new System.Drawing.Size(168, 21);
            this.txtCostoConstruccion.TabIndex = 17;
            // 
            // lblCostoConstruccion
            // 
            this.lblCostoConstruccion.AutoSize = true;
            this.lblCostoConstruccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoConstruccion.Location = new System.Drawing.Point(637, 134);
            this.lblCostoConstruccion.Name = "lblCostoConstruccion";
            this.lblCostoConstruccion.Size = new System.Drawing.Size(165, 15);
            this.lblCostoConstruccion.TabIndex = 16;
            this.lblCostoConstruccion.Text = "Costo Construcción (S/.):";
            // 
            // cbSalaVIP
            // 
            this.cbSalaVIP.AutoSize = true;
            this.cbSalaVIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSalaVIP.Location = new System.Drawing.Point(501, 190);
            this.cbSalaVIP.Name = "cbSalaVIP";
            this.cbSalaVIP.Size = new System.Drawing.Size(80, 19);
            this.cbSalaVIP.TabIndex = 15;
            this.cbSalaVIP.Text = "Sala VIP";
            this.cbSalaVIP.UseVisualStyleBackColor = true;
            // 
            // lblCaracteristicasAdicionales
            // 
            this.lblCaracteristicasAdicionales.AutoSize = true;
            this.lblCaracteristicasAdicionales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaracteristicasAdicionales.Location = new System.Drawing.Point(311, 190);
            this.lblCaracteristicasAdicionales.Name = "lblCaracteristicasAdicionales";
            this.lblCaracteristicasAdicionales.Size = new System.Drawing.Size(184, 15);
            this.lblCaracteristicasAdicionales.TabIndex = 14;
            this.lblCaracteristicasAdicionales.Text = "Características Adicionales:";
            // 
            // rbInternacional
            // 
            this.rbInternacional.AutoSize = true;
            this.rbInternacional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInternacional.Location = new System.Drawing.Point(606, 161);
            this.rbInternacional.Name = "rbInternacional";
            this.rbInternacional.Size = new System.Drawing.Size(109, 19);
            this.rbInternacional.TabIndex = 13;
            this.rbInternacional.TabStop = true;
            this.rbInternacional.Text = "Internacional";
            this.rbInternacional.UseVisualStyleBackColor = true;
            // 
            // rbNacional
            // 
            this.rbNacional.AutoSize = true;
            this.rbNacional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNacional.Location = new System.Drawing.Point(501, 161);
            this.rbNacional.Name = "rbNacional";
            this.rbNacional.Size = new System.Drawing.Size(82, 19);
            this.rbNacional.TabIndex = 12;
            this.rbNacional.TabStop = true;
            this.rbNacional.Text = "Nacional";
            this.rbNacional.UseVisualStyleBackColor = true;
            // 
            // lblTipoAeropuerto
            // 
            this.lblTipoAeropuerto.AutoSize = true;
            this.lblTipoAeropuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoAeropuerto.Location = new System.Drawing.Point(362, 163);
            this.lblTipoAeropuerto.Name = "lblTipoAeropuerto";
            this.lblTipoAeropuerto.Size = new System.Drawing.Size(133, 15);
            this.lblTipoAeropuerto.TabIndex = 11;
            this.lblTipoAeropuerto.Text = "Tipo de Aeropuerto:";
            // 
            // dtpAnhoFundacion
            // 
            this.dtpAnhoFundacion.CustomFormat = "yyyy";
            this.dtpAnhoFundacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAnhoFundacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAnhoFundacion.Location = new System.Drawing.Point(501, 131);
            this.dtpAnhoFundacion.Name = "dtpAnhoFundacion";
            this.dtpAnhoFundacion.ShowUpDown = true;
            this.dtpAnhoFundacion.Size = new System.Drawing.Size(98, 21);
            this.dtpAnhoFundacion.TabIndex = 10;
            // 
            // lblAnhoFundacion
            // 
            this.lblAnhoFundacion.AutoSize = true;
            this.lblAnhoFundacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnhoFundacion.Location = new System.Drawing.Point(369, 134);
            this.lblAnhoFundacion.Name = "lblAnhoFundacion";
            this.lblAnhoFundacion.Size = new System.Drawing.Size(126, 15);
            this.lblAnhoFundacion.TabIndex = 9;
            this.lblAnhoFundacion.Text = "Año de Fundación:";
            // 
            // cboCiudad
            // 
            this.cboCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCiudad.FormattingEnabled = true;
            this.cboCiudad.Location = new System.Drawing.Point(501, 102);
            this.cboCiudad.Name = "cboCiudad";
            this.cboCiudad.Size = new System.Drawing.Size(475, 23);
            this.cboCiudad.TabIndex = 8;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.Location = new System.Drawing.Point(309, 105);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(186, 15);
            this.lblCiudad.TabIndex = 7;
            this.lblCiudad.Text = "Ciudad donde está ubicado:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(501, 75);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(475, 21);
            this.txtDireccion.TabIndex = 6;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(423, 78);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(72, 15);
            this.lblDireccion.TabIndex = 5;
            this.lblDireccion.Text = "Dirección:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(501, 47);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(475, 21);
            this.txtNombre.TabIndex = 4;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(335, 50);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(160, 15);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre del Aeropuerto:";
            // 
            // txtIDAeropuerto
            // 
            this.txtIDAeropuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDAeropuerto.Location = new System.Drawing.Point(501, 18);
            this.txtIDAeropuerto.Name = "txtIDAeropuerto";
            this.txtIDAeropuerto.ReadOnly = true;
            this.txtIDAeropuerto.Size = new System.Drawing.Size(100, 21);
            this.txtIDAeropuerto.TabIndex = 2;
            this.txtIDAeropuerto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIDAeropuerto
            // 
            this.lblIDAeropuerto.AutoSize = true;
            this.lblIDAeropuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDAeropuerto.Location = new System.Drawing.Point(374, 21);
            this.lblIDAeropuerto.Name = "lblIDAeropuerto";
            this.lblIDAeropuerto.Size = new System.Drawing.Size(121, 15);
            this.lblIDAeropuerto.TabIndex = 1;
            this.lblIDAeropuerto.Text = "Id del Aeropuerto:";
            // 
            // pbFoto
            // 
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Location = new System.Drawing.Point(15, 16);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(277, 200);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 0;
            this.pbFoto.TabStop = false;
            // 
            // tbEmpresasAsociadas
            // 
            this.tbEmpresasAsociadas.BackColor = System.Drawing.SystemColors.Control;
            this.tbEmpresasAsociadas.Controls.Add(this.btnEliminarEmpresaComercial);
            this.tbEmpresasAsociadas.Controls.Add(this.btnAgregarEmpresaComercial);
            this.tbEmpresasAsociadas.Controls.Add(this.txtNombreEmpresa);
            this.tbEmpresasAsociadas.Controls.Add(this.btnBuscarEmpresaComercial);
            this.tbEmpresasAsociadas.Controls.Add(this.txtTipoEmpresa);
            this.tbEmpresasAsociadas.Controls.Add(this.lblNombreEmpresa);
            this.tbEmpresasAsociadas.Controls.Add(this.lblTipoEmpresa);
            this.tbEmpresasAsociadas.Controls.Add(this.dgvEmpresasComerciales);
            this.tbEmpresasAsociadas.Location = new System.Drawing.Point(4, 24);
            this.tbEmpresasAsociadas.Name = "tbEmpresasAsociadas";
            this.tbEmpresasAsociadas.Padding = new System.Windows.Forms.Padding(3);
            this.tbEmpresasAsociadas.Size = new System.Drawing.Size(993, 312);
            this.tbEmpresasAsociadas.TabIndex = 1;
            this.tbEmpresasAsociadas.Text = "Empresas Comerciales Asociadas";
            // 
            // btnEliminarEmpresaComercial
            // 
            this.btnEliminarEmpresaComercial.Location = new System.Drawing.Point(665, 43);
            this.btnEliminarEmpresaComercial.Name = "btnEliminarEmpresaComercial";
            this.btnEliminarEmpresaComercial.Size = new System.Drawing.Size(40, 23);
            this.btnEliminarEmpresaComercial.TabIndex = 7;
            this.btnEliminarEmpresaComercial.Text = "-";
            this.btnEliminarEmpresaComercial.UseVisualStyleBackColor = true;
            this.btnEliminarEmpresaComercial.Click += new System.EventHandler(this.btnEliminarEmpresaComercial_Click);
            // 
            // btnAgregarEmpresaComercial
            // 
            this.btnAgregarEmpresaComercial.Location = new System.Drawing.Point(623, 43);
            this.btnAgregarEmpresaComercial.Name = "btnAgregarEmpresaComercial";
            this.btnAgregarEmpresaComercial.Size = new System.Drawing.Size(40, 23);
            this.btnAgregarEmpresaComercial.TabIndex = 6;
            this.btnAgregarEmpresaComercial.Text = "+";
            this.btnAgregarEmpresaComercial.UseVisualStyleBackColor = true;
            this.btnAgregarEmpresaComercial.Click += new System.EventHandler(this.btnAgregarEmpresaComercial_Click);
            // 
            // txtNombreEmpresa
            // 
            this.txtNombreEmpresa.Location = new System.Drawing.Point(190, 44);
            this.txtNombreEmpresa.Name = "txtNombreEmpresa";
            this.txtNombreEmpresa.ReadOnly = true;
            this.txtNombreEmpresa.Size = new System.Drawing.Size(415, 21);
            this.txtNombreEmpresa.TabIndex = 5;
            // 
            // btnBuscarEmpresaComercial
            // 
            this.btnBuscarEmpresaComercial.BackgroundImage = global::FlightSoftSolutions.Properties.Resources.Search;
            this.btnBuscarEmpresaComercial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscarEmpresaComercial.Location = new System.Drawing.Point(370, 16);
            this.btnBuscarEmpresaComercial.Name = "btnBuscarEmpresaComercial";
            this.btnBuscarEmpresaComercial.Size = new System.Drawing.Size(43, 23);
            this.btnBuscarEmpresaComercial.TabIndex = 4;
            this.btnBuscarEmpresaComercial.UseVisualStyleBackColor = true;
            this.btnBuscarEmpresaComercial.Click += new System.EventHandler(this.btnBuscarEmpresaComercial_Click);
            // 
            // txtTipoEmpresa
            // 
            this.txtTipoEmpresa.Location = new System.Drawing.Point(190, 17);
            this.txtTipoEmpresa.Name = "txtTipoEmpresa";
            this.txtTipoEmpresa.ReadOnly = true;
            this.txtTipoEmpresa.Size = new System.Drawing.Size(174, 21);
            this.txtTipoEmpresa.TabIndex = 3;
            // 
            // lblNombreEmpresa
            // 
            this.lblNombreEmpresa.AutoSize = true;
            this.lblNombreEmpresa.Location = new System.Drawing.Point(25, 47);
            this.lblNombreEmpresa.Name = "lblNombreEmpresa";
            this.lblNombreEmpresa.Size = new System.Drawing.Size(159, 15);
            this.lblNombreEmpresa.TabIndex = 2;
            this.lblNombreEmpresa.Text = "Nombre de la Empresa:";
            // 
            // lblTipoEmpresa
            // 
            this.lblTipoEmpresa.AutoSize = true;
            this.lblTipoEmpresa.Location = new System.Drawing.Point(84, 20);
            this.lblTipoEmpresa.Name = "lblTipoEmpresa";
            this.lblTipoEmpresa.Size = new System.Drawing.Size(100, 15);
            this.lblTipoEmpresa.TabIndex = 1;
            this.lblTipoEmpresa.Text = "Tipo Empresa:";
            // 
            // dgvEmpresasComerciales
            // 
            this.dgvEmpresasComerciales.AllowUserToAddRows = false;
            this.dgvEmpresasComerciales.AllowUserToDeleteRows = false;
            this.dgvEmpresasComerciales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpresasComerciales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoEmpresa,
            this.Callsign,
            this.NombreEmpresa,
            this.NumAvi_CantEmp});
            this.dgvEmpresasComerciales.Location = new System.Drawing.Point(23, 83);
            this.dgvEmpresasComerciales.Name = "dgvEmpresasComerciales";
            this.dgvEmpresasComerciales.ReadOnly = true;
            this.dgvEmpresasComerciales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpresasComerciales.Size = new System.Drawing.Size(944, 211);
            this.dgvEmpresasComerciales.TabIndex = 0;
            this.dgvEmpresasComerciales.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvEmpresasComerciales_CellFormatting);
            // 
            // TipoEmpresa
            // 
            this.TipoEmpresa.HeaderText = "Tipo Empresa";
            this.TipoEmpresa.Name = "TipoEmpresa";
            this.TipoEmpresa.ReadOnly = true;
            this.TipoEmpresa.Width = 150;
            // 
            // Callsign
            // 
            this.Callsign.HeaderText = "Callsign";
            this.Callsign.Name = "Callsign";
            this.Callsign.ReadOnly = true;
            this.Callsign.Width = 150;
            // 
            // NombreEmpresa
            // 
            this.NombreEmpresa.HeaderText = "Nombre de la Empresa";
            this.NombreEmpresa.Name = "NombreEmpresa";
            this.NombreEmpresa.ReadOnly = true;
            this.NombreEmpresa.Width = 300;
            // 
            // NumAvi_CantEmp
            // 
            this.NumAvi_CantEmp.HeaderText = "Num. Aviones / Cant. Empleados";
            this.NumAvi_CantEmp.Name = "NumAvi_CantEmp";
            this.NumAvi_CantEmp.ReadOnly = true;
            this.NumAvi_CantEmp.Width = 260;
            // 
            // lblGestionAeropuertos
            // 
            this.lblGestionAeropuertos.AutoSize = true;
            this.lblGestionAeropuertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionAeropuertos.Location = new System.Drawing.Point(13, 35);
            this.lblGestionAeropuertos.Name = "lblGestionAeropuertos";
            this.lblGestionAeropuertos.Size = new System.Drawing.Size(187, 18);
            this.lblGestionAeropuertos.TabIndex = 2;
            this.lblGestionAeropuertos.Text = "Gestión de Aeropuertos";
            // 
            // ofdFoto
            // 
            this.ofdFoto.FileName = "ofdFoto";
            // 
            // frmGestionAeropuertos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 418);
            this.Controls.Add(this.lblGestionAeropuertos);
            this.Controls.Add(this.tcAeropuertos);
            this.Controls.Add(this.tsMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmGestionAeropuertos";
            this.Text = "Formulario de Gestión de Aeropuertos";
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.tcAeropuertos.ResumeLayout(false);
            this.tpDatosGenerales.ResumeLayout(false);
            this.tpDatosGenerales.PerformLayout();
            this.gbDatosOperadora.ResumeLayout(false);
            this.gbDatosOperadora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.tbEmpresasAsociadas.ResumeLayout(false);
            this.tbEmpresasAsociadas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresasComerciales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.TabControl tcAeropuertos;
        private System.Windows.Forms.TabPage tpDatosGenerales;
        private System.Windows.Forms.TabPage tbEmpresasAsociadas;
        private System.Windows.Forms.Label lblGestionAeropuertos;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.OpenFileDialog ofdFoto;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtIDAeropuerto;
        private System.Windows.Forms.Label lblIDAeropuerto;
        private System.Windows.Forms.ComboBox cboCiudad;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.DateTimePicker dtpAnhoFundacion;
        private System.Windows.Forms.Label lblAnhoFundacion;
        private System.Windows.Forms.RadioButton rbInternacional;
        private System.Windows.Forms.RadioButton rbNacional;
        private System.Windows.Forms.Label lblTipoAeropuerto;
        private System.Windows.Forms.CheckBox cbSalaVIP;
        private System.Windows.Forms.Label lblCaracteristicasAdicionales;
        private System.Windows.Forms.CheckBox cbSistemaGestEquipaje;
        private System.Windows.Forms.TextBox txtCostoConstruccion;
        private System.Windows.Forms.Label lblCostoConstruccion;
        private System.Windows.Forms.CheckBox cbWIFI;
        private System.Windows.Forms.GroupBox gbDatosOperadora;
        private System.Windows.Forms.Button btnBuscarOperadora;
        private System.Windows.Forms.TextBox txtOperadoraAsignada;
        private System.Windows.Forms.Label lblOperadoraAsignada;
        private System.Windows.Forms.Button btnSubirFoto;
        private System.Windows.Forms.DataGridView dgvEmpresasComerciales;
        private System.Windows.Forms.Label lblNombreEmpresa;
        private System.Windows.Forms.Label lblTipoEmpresa;
        private System.Windows.Forms.TextBox txtNombreEmpresa;
        private System.Windows.Forms.Button btnBuscarEmpresaComercial;
        private System.Windows.Forms.TextBox txtTipoEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Callsign;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumAvi_CantEmp;
        private System.Windows.Forms.Button btnEliminarEmpresaComercial;
        private System.Windows.Forms.Button btnAgregarEmpresaComercial;
    }
}

