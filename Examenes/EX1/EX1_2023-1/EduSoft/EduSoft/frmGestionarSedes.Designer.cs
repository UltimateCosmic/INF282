namespace EduSoft
{
    partial class frmGestionarSedes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionarSedes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.lblGestionSedes = new System.Windows.Forms.Label();
            this.tcSede = new System.Windows.Forms.TabControl();
            this.tpDatosGenerales = new System.Windows.Forms.TabPage();
            this.cbEstacionamiento = new System.Windows.Forms.CheckBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtAforo = new System.Windows.Forms.TextBox();
            this.lblAforo = new System.Windows.Forms.Label();
            this.cbCafeteria = new System.Windows.Forms.CheckBox();
            this.cbSalasEstudio = new System.Windows.Forms.CheckBox();
            this.cbBiblioteca = new System.Windows.Forms.CheckBox();
            this.cbAuditorio = new System.Windows.Forms.CheckBox();
            this.gbEjecutivoResp = new System.Windows.Forms.GroupBox();
            this.btnBuscarEjecutivoResponsable = new System.Windows.Forms.Button();
            this.txtNombreEjecutivoResp = new System.Windows.Forms.TextBox();
            this.txtDNIEjecutivoResp = new System.Windows.Forms.TextBox();
            this.lblNombreEjecutivoResp = new System.Windows.Forms.Label();
            this.lblDNIEjecutivoResp = new System.Windows.Forms.Label();
            this.lblCaracteristicas = new System.Windows.Forms.Label();
            this.txtCantAulas = new System.Windows.Forms.TextBox();
            this.lblCantAulas = new System.Windows.Forms.Label();
            this.cboTipoSede = new System.Windows.Forms.ComboBox();
            this.lblTipoSede = new System.Windows.Forms.Label();
            this.dtpFechaInauguracion = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubirFoto = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIDSede = new System.Windows.Forms.TextBox();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.lblIDSede = new System.Windows.Forms.Label();
            this.tpProgramasAcademicos = new System.Windows.Forms.TabPage();
            this.btnEliminarProgramaAcademico = new System.Windows.Forms.Button();
            this.btnAgregarProgramaAcademico = new System.Windows.Forms.Button();
            this.lblListaProgramas = new System.Windows.Forms.Label();
            this.dgvProgramasAcademicos = new System.Windows.Forms.DataGridView();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantHorasCreditos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicioRealizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombrePrograma = new System.Windows.Forms.TextBox();
            this.lblNombrePrograma = new System.Windows.Forms.Label();
            this.txtTipoPrograma = new System.Windows.Forms.TextBox();
            this.lblTipoPrograma = new System.Windows.Forms.Label();
            this.btnBuscarPrograma = new System.Windows.Forms.Button();
            this.txtClavePrograma = new System.Windows.Forms.TextBox();
            this.lblClavePrograma = new System.Windows.Forms.Label();
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            this.tsMenu.SuspendLayout();
            this.tcSede.SuspendLayout();
            this.tpDatosGenerales.SuspendLayout();
            this.gbEjecutivoResp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.tpProgramasAcademicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgramasAcademicos)).BeginInit();
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
            this.tsMenu.Size = new System.Drawing.Size(1023, 25);
            this.tsMenu.TabIndex = 0;
            this.tsMenu.Text = "toolStrip1";
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
            this.btnBuscar.Image = global::EduSoft.Properties.Resources.Search;
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(66, 22);
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::EduSoft.Properties.Resources.Cancel;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(78, 22);
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblGestionSedes
            // 
            this.lblGestionSedes.AutoSize = true;
            this.lblGestionSedes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionSedes.Location = new System.Drawing.Point(12, 34);
            this.lblGestionSedes.Name = "lblGestionSedes";
            this.lblGestionSedes.Size = new System.Drawing.Size(131, 16);
            this.lblGestionSedes.TabIndex = 1;
            this.lblGestionSedes.Text = "Gestión de Sedes";
            // 
            // tcSede
            // 
            this.tcSede.Controls.Add(this.tpDatosGenerales);
            this.tcSede.Controls.Add(this.tpProgramasAcademicos);
            this.tcSede.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcSede.Location = new System.Drawing.Point(15, 62);
            this.tcSede.Name = "tcSede";
            this.tcSede.SelectedIndex = 0;
            this.tcSede.Size = new System.Drawing.Size(997, 363);
            this.tcSede.TabIndex = 2;
            // 
            // tpDatosGenerales
            // 
            this.tpDatosGenerales.BackColor = System.Drawing.SystemColors.Control;
            this.tpDatosGenerales.Controls.Add(this.cbEstacionamiento);
            this.tpDatosGenerales.Controls.Add(this.lblDireccion);
            this.tpDatosGenerales.Controls.Add(this.txtDireccion);
            this.tpDatosGenerales.Controls.Add(this.txtAforo);
            this.tpDatosGenerales.Controls.Add(this.lblAforo);
            this.tpDatosGenerales.Controls.Add(this.cbCafeteria);
            this.tpDatosGenerales.Controls.Add(this.cbSalasEstudio);
            this.tpDatosGenerales.Controls.Add(this.cbBiblioteca);
            this.tpDatosGenerales.Controls.Add(this.cbAuditorio);
            this.tpDatosGenerales.Controls.Add(this.gbEjecutivoResp);
            this.tpDatosGenerales.Controls.Add(this.lblCaracteristicas);
            this.tpDatosGenerales.Controls.Add(this.txtCantAulas);
            this.tpDatosGenerales.Controls.Add(this.lblCantAulas);
            this.tpDatosGenerales.Controls.Add(this.cboTipoSede);
            this.tpDatosGenerales.Controls.Add(this.lblTipoSede);
            this.tpDatosGenerales.Controls.Add(this.dtpFechaInauguracion);
            this.tpDatosGenerales.Controls.Add(this.label2);
            this.tpDatosGenerales.Controls.Add(this.btnSubirFoto);
            this.tpDatosGenerales.Controls.Add(this.lblNombre);
            this.tpDatosGenerales.Controls.Add(this.txtNombre);
            this.tpDatosGenerales.Controls.Add(this.txtIDSede);
            this.tpDatosGenerales.Controls.Add(this.pbFoto);
            this.tpDatosGenerales.Controls.Add(this.lblIDSede);
            this.tpDatosGenerales.Location = new System.Drawing.Point(4, 24);
            this.tpDatosGenerales.Name = "tpDatosGenerales";
            this.tpDatosGenerales.Padding = new System.Windows.Forms.Padding(3);
            this.tpDatosGenerales.Size = new System.Drawing.Size(989, 335);
            this.tpDatosGenerales.TabIndex = 0;
            this.tpDatosGenerales.Text = "Datos Generales";
            // 
            // cbEstacionamiento
            // 
            this.cbEstacionamiento.AutoSize = true;
            this.cbEstacionamiento.Location = new System.Drawing.Point(539, 305);
            this.cbEstacionamiento.Name = "cbEstacionamiento";
            this.cbEstacionamiento.Size = new System.Drawing.Size(133, 19);
            this.cbEstacionamiento.TabIndex = 17;
            this.cbEstacionamiento.Text = "Estacionamiento";
            this.cbEstacionamiento.UseVisualStyleBackColor = true;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(359, 80);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(72, 15);
            this.lblDireccion.TabIndex = 21;
            this.lblDireccion.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(437, 77);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(533, 21);
            this.txtDireccion.TabIndex = 20;
            // 
            // txtAforo
            // 
            this.txtAforo.Location = new System.Drawing.Point(639, 169);
            this.txtAforo.Name = "txtAforo";
            this.txtAforo.Size = new System.Drawing.Size(100, 21);
            this.txtAforo.TabIndex = 11;
            // 
            // lblAforo
            // 
            this.lblAforo.AutoSize = true;
            this.lblAforo.Location = new System.Drawing.Point(553, 172);
            this.lblAforo.Name = "lblAforo";
            this.lblAforo.Size = new System.Drawing.Size(80, 15);
            this.lblAforo.TabIndex = 18;
            this.lblAforo.Text = "Aforo Total:";
            // 
            // cbCafeteria
            // 
            this.cbCafeteria.AutoSize = true;
            this.cbCafeteria.Location = new System.Drawing.Point(885, 305);
            this.cbCafeteria.Name = "cbCafeteria";
            this.cbCafeteria.Size = new System.Drawing.Size(84, 19);
            this.cbCafeteria.TabIndex = 19;
            this.cbCafeteria.Text = "Cafetería";
            this.cbCafeteria.UseVisualStyleBackColor = true;
            // 
            // cbSalasEstudio
            // 
            this.cbSalasEstudio.AutoSize = true;
            this.cbSalasEstudio.Location = new System.Drawing.Point(710, 305);
            this.cbSalasEstudio.Name = "cbSalasEstudio";
            this.cbSalasEstudio.Size = new System.Drawing.Size(133, 19);
            this.cbSalasEstudio.TabIndex = 18;
            this.cbSalasEstudio.Text = "Salas de estudio";
            this.cbSalasEstudio.UseVisualStyleBackColor = true;
            // 
            // cbBiblioteca
            // 
            this.cbBiblioteca.AutoSize = true;
            this.cbBiblioteca.Location = new System.Drawing.Point(401, 305);
            this.cbBiblioteca.Name = "cbBiblioteca";
            this.cbBiblioteca.Size = new System.Drawing.Size(90, 19);
            this.cbBiblioteca.TabIndex = 16;
            this.cbBiblioteca.Text = "Biblioteca";
            this.cbBiblioteca.UseVisualStyleBackColor = true;
            // 
            // cbAuditorio
            // 
            this.cbAuditorio.AutoSize = true;
            this.cbAuditorio.Location = new System.Drawing.Point(283, 305);
            this.cbAuditorio.Name = "cbAuditorio";
            this.cbAuditorio.Size = new System.Drawing.Size(83, 19);
            this.cbAuditorio.TabIndex = 15;
            this.cbAuditorio.Text = "Auditorio";
            this.cbAuditorio.UseVisualStyleBackColor = true;
            // 
            // gbEjecutivoResp
            // 
            this.gbEjecutivoResp.Controls.Add(this.btnBuscarEjecutivoResponsable);
            this.gbEjecutivoResp.Controls.Add(this.txtNombreEjecutivoResp);
            this.gbEjecutivoResp.Controls.Add(this.txtDNIEjecutivoResp);
            this.gbEjecutivoResp.Controls.Add(this.lblNombreEjecutivoResp);
            this.gbEjecutivoResp.Controls.Add(this.lblDNIEjecutivoResp);
            this.gbEjecutivoResp.Location = new System.Drawing.Point(17, 203);
            this.gbEjecutivoResp.Name = "gbEjecutivoResp";
            this.gbEjecutivoResp.Size = new System.Drawing.Size(953, 91);
            this.gbEjecutivoResp.TabIndex = 13;
            this.gbEjecutivoResp.TabStop = false;
            this.gbEjecutivoResp.Text = "Ejecutivo Responsable de la Sede";
            // 
            // btnBuscarEjecutivoResponsable
            // 
            this.btnBuscarEjecutivoResponsable.BackgroundImage = global::EduSoft.Properties.Resources.Search;
            this.btnBuscarEjecutivoResponsable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscarEjecutivoResponsable.Location = new System.Drawing.Point(308, 29);
            this.btnBuscarEjecutivoResponsable.Name = "btnBuscarEjecutivoResponsable";
            this.btnBuscarEjecutivoResponsable.Size = new System.Drawing.Size(39, 23);
            this.btnBuscarEjecutivoResponsable.TabIndex = 13;
            this.btnBuscarEjecutivoResponsable.UseVisualStyleBackColor = true;
            this.btnBuscarEjecutivoResponsable.Click += new System.EventHandler(this.btnBuscarEjecutivoResponsable_Click);
            // 
            // txtNombreEjecutivoResp
            // 
            this.txtNombreEjecutivoResp.Location = new System.Drawing.Point(152, 55);
            this.txtNombreEjecutivoResp.Name = "txtNombreEjecutivoResp";
            this.txtNombreEjecutivoResp.ReadOnly = true;
            this.txtNombreEjecutivoResp.Size = new System.Drawing.Size(438, 21);
            this.txtNombreEjecutivoResp.TabIndex = 14;
            // 
            // txtDNIEjecutivoResp
            // 
            this.txtDNIEjecutivoResp.Location = new System.Drawing.Point(152, 30);
            this.txtDNIEjecutivoResp.Name = "txtDNIEjecutivoResp";
            this.txtDNIEjecutivoResp.ReadOnly = true;
            this.txtDNIEjecutivoResp.Size = new System.Drawing.Size(153, 21);
            this.txtDNIEjecutivoResp.TabIndex = 12;
            // 
            // lblNombreEjecutivoResp
            // 
            this.lblNombreEjecutivoResp.AutoSize = true;
            this.lblNombreEjecutivoResp.Location = new System.Drawing.Point(19, 58);
            this.lblNombreEjecutivoResp.Name = "lblNombreEjecutivoResp";
            this.lblNombreEjecutivoResp.Size = new System.Drawing.Size(127, 15);
            this.lblNombreEjecutivoResp.TabIndex = 1;
            this.lblNombreEjecutivoResp.Text = "Nombre Completo:";
            // 
            // lblDNIEjecutivoResp
            // 
            this.lblDNIEjecutivoResp.AutoSize = true;
            this.lblDNIEjecutivoResp.Location = new System.Drawing.Point(111, 33);
            this.lblDNIEjecutivoResp.Name = "lblDNIEjecutivoResp";
            this.lblDNIEjecutivoResp.Size = new System.Drawing.Size(35, 15);
            this.lblDNIEjecutivoResp.TabIndex = 0;
            this.lblDNIEjecutivoResp.Text = "DNI:";
            // 
            // lblCaracteristicas
            // 
            this.lblCaracteristicas.AutoSize = true;
            this.lblCaracteristicas.Location = new System.Drawing.Point(14, 306);
            this.lblCaracteristicas.Name = "lblCaracteristicas";
            this.lblCaracteristicas.Size = new System.Drawing.Size(257, 15);
            this.lblCaracteristicas.TabIndex = 12;
            this.lblCaracteristicas.Text = "Características Adicionales de la Sede:";
            // 
            // txtCantAulas
            // 
            this.txtCantAulas.Location = new System.Drawing.Point(437, 169);
            this.txtCantAulas.Name = "txtCantAulas";
            this.txtCantAulas.Size = new System.Drawing.Size(100, 21);
            this.txtCantAulas.TabIndex = 10;
            // 
            // lblCantAulas
            // 
            this.lblCantAulas.AutoSize = true;
            this.lblCantAulas.Location = new System.Drawing.Point(304, 172);
            this.lblCantAulas.Name = "lblCantAulas";
            this.lblCantAulas.Size = new System.Drawing.Size(127, 15);
            this.lblCantAulas.TabIndex = 10;
            this.lblCantAulas.Text = "Cantidad de Aulas:";
            // 
            // cboTipoSede
            // 
            this.cboTipoSede.FormattingEnabled = true;
            this.cboTipoSede.Location = new System.Drawing.Point(437, 137);
            this.cboTipoSede.Name = "cboTipoSede";
            this.cboTipoSede.Size = new System.Drawing.Size(533, 23);
            this.cboTipoSede.TabIndex = 9;
            // 
            // lblTipoSede
            // 
            this.lblTipoSede.AutoSize = true;
            this.lblTipoSede.Location = new System.Drawing.Point(335, 141);
            this.lblTipoSede.Name = "lblTipoSede";
            this.lblTipoSede.Size = new System.Drawing.Size(96, 15);
            this.lblTipoSede.TabIndex = 8;
            this.lblTipoSede.Text = "Tipo de Sede:";
            // 
            // dtpFechaInauguracion
            // 
            this.dtpFechaInauguracion.Location = new System.Drawing.Point(437, 107);
            this.dtpFechaInauguracion.Name = "dtpFechaInauguracion";
            this.dtpFechaInauguracion.Size = new System.Drawing.Size(533, 21);
            this.dtpFechaInauguracion.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha de Inauguración:";
            // 
            // btnSubirFoto
            // 
            this.btnSubirFoto.BackgroundImage = global::EduSoft.Properties.Resources.Upload;
            this.btnSubirFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubirFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubirFoto.Location = new System.Drawing.Point(215, 163);
            this.btnSubirFoto.Name = "btnSubirFoto";
            this.btnSubirFoto.Size = new System.Drawing.Size(46, 34);
            this.btnSubirFoto.TabIndex = 5;
            this.btnSubirFoto.UseVisualStyleBackColor = true;
            this.btnSubirFoto.Click += new System.EventHandler(this.btnSubirFoto_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(296, 50);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(135, 15);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre de la Sede:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(437, 47);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(533, 21);
            this.txtNombre.TabIndex = 2;
            // 
            // txtIDSede
            // 
            this.txtIDSede.Location = new System.Drawing.Point(437, 16);
            this.txtIDSede.Name = "txtIDSede";
            this.txtIDSede.ReadOnly = true;
            this.txtIDSede.Size = new System.Drawing.Size(70, 21);
            this.txtIDSede.TabIndex = 1;
            this.txtIDSede.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbFoto
            // 
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Location = new System.Drawing.Point(17, 16);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(244, 181);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 1;
            this.pbFoto.TabStop = false;
            // 
            // lblIDSede
            // 
            this.lblIDSede.AutoSize = true;
            this.lblIDSede.Location = new System.Drawing.Point(333, 19);
            this.lblIDSede.Name = "lblIDSede";
            this.lblIDSede.Size = new System.Drawing.Size(98, 15);
            this.lblIDSede.TabIndex = 0;
            this.lblIDSede.Text = "ID de la Sede:";
            // 
            // tpProgramasAcademicos
            // 
            this.tpProgramasAcademicos.BackColor = System.Drawing.SystemColors.Control;
            this.tpProgramasAcademicos.Controls.Add(this.btnEliminarProgramaAcademico);
            this.tpProgramasAcademicos.Controls.Add(this.btnAgregarProgramaAcademico);
            this.tpProgramasAcademicos.Controls.Add(this.lblListaProgramas);
            this.tpProgramasAcademicos.Controls.Add(this.dgvProgramasAcademicos);
            this.tpProgramasAcademicos.Controls.Add(this.txtNombrePrograma);
            this.tpProgramasAcademicos.Controls.Add(this.lblNombrePrograma);
            this.tpProgramasAcademicos.Controls.Add(this.txtTipoPrograma);
            this.tpProgramasAcademicos.Controls.Add(this.lblTipoPrograma);
            this.tpProgramasAcademicos.Controls.Add(this.btnBuscarPrograma);
            this.tpProgramasAcademicos.Controls.Add(this.txtClavePrograma);
            this.tpProgramasAcademicos.Controls.Add(this.lblClavePrograma);
            this.tpProgramasAcademicos.Location = new System.Drawing.Point(4, 24);
            this.tpProgramasAcademicos.Name = "tpProgramasAcademicos";
            this.tpProgramasAcademicos.Padding = new System.Windows.Forms.Padding(3);
            this.tpProgramasAcademicos.Size = new System.Drawing.Size(989, 335);
            this.tpProgramasAcademicos.TabIndex = 1;
            this.tpProgramasAcademicos.Text = "Programas Académicos";
            // 
            // btnEliminarProgramaAcademico
            // 
            this.btnEliminarProgramaAcademico.Location = new System.Drawing.Point(817, 64);
            this.btnEliminarProgramaAcademico.Name = "btnEliminarProgramaAcademico";
            this.btnEliminarProgramaAcademico.Size = new System.Drawing.Size(38, 23);
            this.btnEliminarProgramaAcademico.TabIndex = 6;
            this.btnEliminarProgramaAcademico.Text = "-";
            this.btnEliminarProgramaAcademico.UseVisualStyleBackColor = true;
            this.btnEliminarProgramaAcademico.Click += new System.EventHandler(this.btnEliminarProgramaAcademico_Click);
            // 
            // btnAgregarProgramaAcademico
            // 
            this.btnAgregarProgramaAcademico.Location = new System.Drawing.Point(776, 64);
            this.btnAgregarProgramaAcademico.Name = "btnAgregarProgramaAcademico";
            this.btnAgregarProgramaAcademico.Size = new System.Drawing.Size(38, 23);
            this.btnAgregarProgramaAcademico.TabIndex = 5;
            this.btnAgregarProgramaAcademico.Text = "+";
            this.btnAgregarProgramaAcademico.UseVisualStyleBackColor = true;
            this.btnAgregarProgramaAcademico.Click += new System.EventHandler(this.btnAgregarProgramaAcademico_Click);
            // 
            // lblListaProgramas
            // 
            this.lblListaProgramas.AutoSize = true;
            this.lblListaProgramas.Location = new System.Drawing.Point(10, 113);
            this.lblListaProgramas.Name = "lblListaProgramas";
            this.lblListaProgramas.Size = new System.Drawing.Size(290, 15);
            this.lblListaProgramas.TabIndex = 8;
            this.lblListaProgramas.Text = "Lista de Programas Académicos de la Sede:";
            // 
            // dgvProgramasAcademicos
            // 
            this.dgvProgramasAcademicos.AllowUserToAddRows = false;
            this.dgvProgramasAcademicos.AllowUserToDeleteRows = false;
            this.dgvProgramasAcademicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProgramasAcademicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo,
            this.Clave,
            this.Nombre,
            this.CantHorasCreditos,
            this.FechaInicioRealizacion});
            this.dgvProgramasAcademicos.Location = new System.Drawing.Point(12, 135);
            this.dgvProgramasAcademicos.Name = "dgvProgramasAcademicos";
            this.dgvProgramasAcademicos.ReadOnly = true;
            this.dgvProgramasAcademicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProgramasAcademicos.Size = new System.Drawing.Size(963, 185);
            this.dgvProgramasAcademicos.TabIndex = 7;
            this.dgvProgramasAcademicos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvProgramasAcademicos_CellFormatting);
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Clave
            // 
            this.Clave.HeaderText = "Clave";
            this.Clave.Name = "Clave";
            this.Clave.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 350;
            // 
            // CantHorasCreditos
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CantHorasCreditos.DefaultCellStyle = dataGridViewCellStyle1;
            this.CantHorasCreditos.HeaderText = "Cant. Horas/Créditos";
            this.CantHorasCreditos.Name = "CantHorasCreditos";
            this.CantHorasCreditos.ReadOnly = true;
            this.CantHorasCreditos.Width = 170;
            // 
            // FechaInicioRealizacion
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FechaInicioRealizacion.DefaultCellStyle = dataGridViewCellStyle2;
            this.FechaInicioRealizacion.HeaderText = "F. Inicio/Realización";
            this.FechaInicioRealizacion.Name = "FechaInicioRealizacion";
            this.FechaInicioRealizacion.ReadOnly = true;
            this.FechaInicioRealizacion.Width = 170;
            // 
            // txtNombrePrograma
            // 
            this.txtNombrePrograma.Location = new System.Drawing.Point(175, 65);
            this.txtNombrePrograma.Name = "txtNombrePrograma";
            this.txtNombrePrograma.ReadOnly = true;
            this.txtNombrePrograma.Size = new System.Drawing.Size(588, 21);
            this.txtNombrePrograma.TabIndex = 4;
            // 
            // lblNombrePrograma
            // 
            this.lblNombrePrograma.AutoSize = true;
            this.lblNombrePrograma.Location = new System.Drawing.Point(16, 68);
            this.lblNombrePrograma.Name = "lblNombrePrograma";
            this.lblNombrePrograma.Size = new System.Drawing.Size(153, 15);
            this.lblNombrePrograma.TabIndex = 5;
            this.lblNombrePrograma.Text = "Nombre del Programa:";
            // 
            // txtTipoPrograma
            // 
            this.txtTipoPrograma.Location = new System.Drawing.Point(175, 39);
            this.txtTipoPrograma.Name = "txtTipoPrograma";
            this.txtTipoPrograma.ReadOnly = true;
            this.txtTipoPrograma.Size = new System.Drawing.Size(150, 21);
            this.txtTipoPrograma.TabIndex = 3;
            this.txtTipoPrograma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTipoPrograma
            // 
            this.lblTipoPrograma.AutoSize = true;
            this.lblTipoPrograma.Location = new System.Drawing.Point(43, 42);
            this.lblTipoPrograma.Name = "lblTipoPrograma";
            this.lblTipoPrograma.Size = new System.Drawing.Size(126, 15);
            this.lblTipoPrograma.TabIndex = 3;
            this.lblTipoPrograma.Text = "Tipo de Programa:";
            // 
            // btnBuscarPrograma
            // 
            this.btnBuscarPrograma.Image = global::EduSoft.Properties.Resources.Search;
            this.btnBuscarPrograma.Location = new System.Drawing.Point(255, 12);
            this.btnBuscarPrograma.Name = "btnBuscarPrograma";
            this.btnBuscarPrograma.Size = new System.Drawing.Size(34, 23);
            this.btnBuscarPrograma.TabIndex = 2;
            this.btnBuscarPrograma.UseVisualStyleBackColor = true;
            this.btnBuscarPrograma.Click += new System.EventHandler(this.btnBuscarPrograma_Click);
            // 
            // txtClavePrograma
            // 
            this.txtClavePrograma.Location = new System.Drawing.Point(175, 13);
            this.txtClavePrograma.Name = "txtClavePrograma";
            this.txtClavePrograma.ReadOnly = true;
            this.txtClavePrograma.Size = new System.Drawing.Size(77, 21);
            this.txtClavePrograma.TabIndex = 1;
            this.txtClavePrograma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblClavePrograma
            // 
            this.lblClavePrograma.AutoSize = true;
            this.lblClavePrograma.Location = new System.Drawing.Point(32, 16);
            this.lblClavePrograma.Name = "lblClavePrograma";
            this.lblClavePrograma.Size = new System.Drawing.Size(137, 15);
            this.lblClavePrograma.TabIndex = 0;
            this.lblClavePrograma.Text = "Clave del Programa:";
            // 
            // ofdFoto
            // 
            this.ofdFoto.FileName = "openFileDialog1";
            // 
            // frmGestionarSedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 437);
            this.Controls.Add(this.tcSede);
            this.Controls.Add(this.lblGestionSedes);
            this.Controls.Add(this.tsMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmGestionarSedes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de Gestión de Sedes";
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.tcSede.ResumeLayout(false);
            this.tpDatosGenerales.ResumeLayout(false);
            this.tpDatosGenerales.PerformLayout();
            this.gbEjecutivoResp.ResumeLayout(false);
            this.gbEjecutivoResp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.tpProgramasAcademicos.ResumeLayout(false);
            this.tpProgramasAcademicos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgramasAcademicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.Label lblGestionSedes;
        private System.Windows.Forms.TabControl tcSede;
        private System.Windows.Forms.TabPage tpDatosGenerales;
        private System.Windows.Forms.TabPage tpProgramasAcademicos;
        private System.Windows.Forms.Button btnSubirFoto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIDSede;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Label lblIDSede;
        private System.Windows.Forms.DateTimePicker dtpFechaInauguracion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTipoSede;
        private System.Windows.Forms.Label lblTipoSede;
        private System.Windows.Forms.CheckBox cbCafeteria;
        private System.Windows.Forms.CheckBox cbSalasEstudio;
        private System.Windows.Forms.CheckBox cbBiblioteca;
        private System.Windows.Forms.CheckBox cbAuditorio;
        private System.Windows.Forms.GroupBox gbEjecutivoResp;
        private System.Windows.Forms.Label lblCaracteristicas;
        private System.Windows.Forms.TextBox txtCantAulas;
        private System.Windows.Forms.Label lblCantAulas;
        private System.Windows.Forms.TextBox txtAforo;
        private System.Windows.Forms.Label lblAforo;
        private System.Windows.Forms.Button btnBuscarEjecutivoResponsable;
        private System.Windows.Forms.TextBox txtNombreEjecutivoResp;
        private System.Windows.Forms.TextBox txtDNIEjecutivoResp;
        private System.Windows.Forms.Label lblNombreEjecutivoResp;
        private System.Windows.Forms.Label lblDNIEjecutivoResp;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.CheckBox cbEstacionamiento;
        private System.Windows.Forms.Label lblListaProgramas;
        private System.Windows.Forms.DataGridView dgvProgramasAcademicos;
        private System.Windows.Forms.TextBox txtNombrePrograma;
        private System.Windows.Forms.Label lblNombrePrograma;
        private System.Windows.Forms.TextBox txtTipoPrograma;
        private System.Windows.Forms.Label lblTipoPrograma;
        private System.Windows.Forms.Button btnBuscarPrograma;
        private System.Windows.Forms.TextBox txtClavePrograma;
        private System.Windows.Forms.Label lblClavePrograma;
        private System.Windows.Forms.Button btnEliminarProgramaAcademico;
        private System.Windows.Forms.Button btnAgregarProgramaAcademico;
        private System.Windows.Forms.OpenFileDialog ofdFoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantHorasCreditos;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicioRealizacion;
    }
}

