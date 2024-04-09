namespace GameSoft
{
    partial class frmGestionPokemons
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionPokemons));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.tcGestionPokemon = new System.Windows.Forms.TabControl();
            this.tbDatosGenerales = new System.Windows.Forms.TabPage();
            this.panelGeneracion = new System.Windows.Forms.Panel();
            this.rbTerceraGen = new System.Windows.Forms.RadioButton();
            this.rbSegundaGen = new System.Windows.Forms.RadioButton();
            this.rbPrimeraGen = new System.Windows.Forms.RadioButton();
            this.lblGeneracion = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.panelPesoAltura = new System.Windows.Forms.Panel();
            this.lblm = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblKg = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnSubirFoto = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.panelTipos = new System.Windows.Forms.Panel();
            this.cboTipo2 = new System.Windows.Forms.ComboBox();
            this.cboTipo1 = new System.Windows.Forms.ComboBox();
            this.lblTipo2 = new System.Windows.Forms.Label();
            this.lblTipo1 = new System.Windows.Forms.Label();
            this.pbTipo2 = new System.Windows.Forms.PictureBox();
            this.pbTipo1 = new System.Windows.Forms.PictureBox();
            this.panelTipo2 = new System.Windows.Forms.Panel();
            this.panelTipo1 = new System.Windows.Forms.Panel();
            this.panelNroNombre = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNro = new System.Windows.Forms.TextBox();
            this.lblNro = new System.Windows.Forms.Label();
            this.tpMovimientosPorNivel = new System.Windows.Forms.TabPage();
            this.btnEliminarMovimiento = new System.Windows.Forms.Button();
            this.btnAgregarMovimiento = new System.Windows.Forms.Button();
            this.gbMovimientoNuevo = new System.Windows.Forms.GroupBox();
            this.btnBuscarBlanco = new System.Windows.Forms.Button();
            this.txtDescripcionBlancoMovimiento = new System.Windows.Forms.TextBox();
            this.txtBlancoMovimiento = new System.Windows.Forms.TextBox();
            this.lblBlancoMovimiento = new System.Windows.Forms.Label();
            this.txtPPMovimiento = new System.Windows.Forms.TextBox();
            this.lblPPMovimiento = new System.Windows.Forms.Label();
            this.txtExactitudMovimiento = new System.Windows.Forms.TextBox();
            this.lblExactitudMovimiento = new System.Windows.Forms.Label();
            this.txtPoderMovimiento = new System.Windows.Forms.TextBox();
            this.lblPoderMovimiento = new System.Windows.Forms.Label();
            this.lblClaseMovimiento = new System.Windows.Forms.Label();
            this.cboClaseMovimiento = new System.Windows.Forms.ComboBox();
            this.pbClaseMovimiento = new System.Windows.Forms.PictureBox();
            this.pbTipoMovimiento = new System.Windows.Forms.PictureBox();
            this.txtNombreMovimiento = new System.Windows.Forms.TextBox();
            this.cboTipoMovimiento = new System.Windows.Forms.ComboBox();
            this.lblLVLMovimiento = new System.Windows.Forms.Label();
            this.lblTipoMovimiento = new System.Windows.Forms.Label();
            this.txtLVLMovimiento = new System.Windows.Forms.TextBox();
            this.lblNombreMovimiento = new System.Windows.Forms.Label();
            this.dgvMovimientosPorNivel = new System.Windows.Forms.DataGridView();
            this.LV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLASE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PODER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXACT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BLANCO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            this.ttAgregarMovimiento = new System.Windows.Forms.ToolTip(this.components);
            this.ttEliminarMovimiento = new System.Windows.Forms.ToolTip(this.components);
            this.ttPoder = new System.Windows.Forms.ToolTip(this.components);
            this.ttExactitud = new System.Windows.Forms.ToolTip(this.components);
            this.ttPP = new System.Windows.Forms.ToolTip(this.components);
            this.tsMenu.SuspendLayout();
            this.tcGestionPokemon.SuspendLayout();
            this.tbDatosGenerales.SuspendLayout();
            this.panelGeneracion.SuspendLayout();
            this.panelPesoAltura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.panelTipos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTipo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTipo1)).BeginInit();
            this.panelNroNombre.SuspendLayout();
            this.tpMovimientosPorNivel.SuspendLayout();
            this.gbMovimientoNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClaseMovimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTipoMovimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientosPorNivel)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.btnBuscar,
            this.btnCancelar});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(946, 25);
            this.tsMenu.TabIndex = 0;
            this.tsMenu.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(66, 22);
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(76, 22);
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::GameSoft.Properties.Resources.Search;
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(66, 22);
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::GameSoft.Properties.Resources.Cancel;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(78, 22);
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tcGestionPokemon
            // 
            this.tcGestionPokemon.Controls.Add(this.tbDatosGenerales);
            this.tcGestionPokemon.Controls.Add(this.tpMovimientosPorNivel);
            this.tcGestionPokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcGestionPokemon.Location = new System.Drawing.Point(12, 32);
            this.tcGestionPokemon.Name = "tcGestionPokemon";
            this.tcGestionPokemon.SelectedIndex = 0;
            this.tcGestionPokemon.Size = new System.Drawing.Size(922, 374);
            this.tcGestionPokemon.TabIndex = 1;
            // 
            // tbDatosGenerales
            // 
            this.tbDatosGenerales.BackColor = System.Drawing.SystemColors.Control;
            this.tbDatosGenerales.Controls.Add(this.panelGeneracion);
            this.tbDatosGenerales.Controls.Add(this.lblDescripcion);
            this.tbDatosGenerales.Controls.Add(this.panelPesoAltura);
            this.tbDatosGenerales.Controls.Add(this.txtDescripcion);
            this.tbDatosGenerales.Controls.Add(this.btnSubirFoto);
            this.tbDatosGenerales.Controls.Add(this.pbFoto);
            this.tbDatosGenerales.Controls.Add(this.panelTipos);
            this.tbDatosGenerales.Controls.Add(this.panelNroNombre);
            this.tbDatosGenerales.Location = new System.Drawing.Point(4, 24);
            this.tbDatosGenerales.Name = "tbDatosGenerales";
            this.tbDatosGenerales.Padding = new System.Windows.Forms.Padding(3);
            this.tbDatosGenerales.Size = new System.Drawing.Size(914, 346);
            this.tbDatosGenerales.TabIndex = 0;
            this.tbDatosGenerales.Text = "Datos Generales";
            // 
            // panelGeneracion
            // 
            this.panelGeneracion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGeneracion.Controls.Add(this.rbTerceraGen);
            this.panelGeneracion.Controls.Add(this.rbSegundaGen);
            this.panelGeneracion.Controls.Add(this.rbPrimeraGen);
            this.panelGeneracion.Controls.Add(this.lblGeneracion);
            this.panelGeneracion.Location = new System.Drawing.Point(268, 311);
            this.panelGeneracion.Name = "panelGeneracion";
            this.panelGeneracion.Size = new System.Drawing.Size(632, 28);
            this.panelGeneracion.TabIndex = 7;
            // 
            // rbTerceraGen
            // 
            this.rbTerceraGen.AutoSize = true;
            this.rbTerceraGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTerceraGen.Location = new System.Drawing.Point(413, 3);
            this.rbTerceraGen.Name = "rbTerceraGen";
            this.rbTerceraGen.Size = new System.Drawing.Size(116, 20);
            this.rbTerceraGen.TabIndex = 3;
            this.rbTerceraGen.TabStop = true;
            this.rbTerceraGen.Text = "Tercera Gen.";
            this.rbTerceraGen.UseVisualStyleBackColor = true;
            // 
            // rbSegundaGen
            // 
            this.rbSegundaGen.AutoSize = true;
            this.rbSegundaGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSegundaGen.Location = new System.Drawing.Point(259, 3);
            this.rbSegundaGen.Name = "rbSegundaGen";
            this.rbSegundaGen.Size = new System.Drawing.Size(123, 20);
            this.rbSegundaGen.TabIndex = 2;
            this.rbSegundaGen.TabStop = true;
            this.rbSegundaGen.Text = "Segunda Gen.";
            this.rbSegundaGen.UseVisualStyleBackColor = true;
            // 
            // rbPrimeraGen
            // 
            this.rbPrimeraGen.AutoSize = true;
            this.rbPrimeraGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPrimeraGen.Location = new System.Drawing.Point(119, 3);
            this.rbPrimeraGen.Name = "rbPrimeraGen";
            this.rbPrimeraGen.Size = new System.Drawing.Size(115, 20);
            this.rbPrimeraGen.TabIndex = 1;
            this.rbPrimeraGen.TabStop = true;
            this.rbPrimeraGen.Text = "Primera Gen.";
            this.rbPrimeraGen.UseVisualStyleBackColor = true;
            // 
            // lblGeneracion
            // 
            this.lblGeneracion.AutoSize = true;
            this.lblGeneracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneracion.Location = new System.Drawing.Point(10, 5);
            this.lblGeneracion.Name = "lblGeneracion";
            this.lblGeneracion.Size = new System.Drawing.Size(91, 16);
            this.lblGeneracion.TabIndex = 0;
            this.lblGeneracion.Text = "Generación:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(265, 188);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(94, 16);
            this.lblDescripcion.TabIndex = 6;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // panelPesoAltura
            // 
            this.panelPesoAltura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPesoAltura.Controls.Add(this.lblm);
            this.panelPesoAltura.Controls.Add(this.txtAltura);
            this.panelPesoAltura.Controls.Add(this.lblAltura);
            this.panelPesoAltura.Controls.Add(this.lblKg);
            this.panelPesoAltura.Controls.Add(this.lblPeso);
            this.panelPesoAltura.Controls.Add(this.txtPeso);
            this.panelPesoAltura.Location = new System.Drawing.Point(268, 269);
            this.panelPesoAltura.Name = "panelPesoAltura";
            this.panelPesoAltura.Size = new System.Drawing.Size(632, 36);
            this.panelPesoAltura.TabIndex = 5;
            // 
            // lblm
            // 
            this.lblm.AutoSize = true;
            this.lblm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblm.Location = new System.Drawing.Point(432, 9);
            this.lblm.Name = "lblm";
            this.lblm.Size = new System.Drawing.Size(23, 16);
            this.lblm.TabIndex = 5;
            this.lblm.Text = "m.";
            // 
            // txtAltura
            // 
            this.txtAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltura.Location = new System.Drawing.Point(326, 6);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 22);
            this.txtAltura.TabIndex = 4;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(269, 9);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(51, 16);
            this.lblAltura.TabIndex = 3;
            this.lblAltura.Text = "Altura:";
            // 
            // lblKg
            // 
            this.lblKg.AutoSize = true;
            this.lblKg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKg.Location = new System.Drawing.Point(169, 9);
            this.lblKg.Name = "lblKg";
            this.lblKg.Size = new System.Drawing.Size(28, 16);
            this.lblKg.TabIndex = 2;
            this.lblKg.Text = "kg.";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(10, 9);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(47, 16);
            this.lblPeso.TabIndex = 1;
            this.lblPeso.Text = "Peso:";
            // 
            // txtPeso
            // 
            this.txtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Location = new System.Drawing.Point(63, 6);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 22);
            this.txtPeso.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(268, 207);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(632, 56);
            this.txtDescripcion.TabIndex = 4;
            // 
            // btnSubirFoto
            // 
            this.btnSubirFoto.BackgroundImage = global::GameSoft.Properties.Resources.Upload;
            this.btnSubirFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubirFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubirFoto.Location = new System.Drawing.Point(216, 99);
            this.btnSubirFoto.Name = "btnSubirFoto";
            this.btnSubirFoto.Size = new System.Drawing.Size(40, 33);
            this.btnSubirFoto.TabIndex = 3;
            this.btnSubirFoto.UseVisualStyleBackColor = true;
            this.btnSubirFoto.Click += new System.EventHandler(this.btnSubirFoto_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Location = new System.Drawing.Point(15, 99);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(241, 241);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 2;
            this.pbFoto.TabStop = false;
            // 
            // panelTipos
            // 
            this.panelTipos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTipos.Controls.Add(this.cboTipo2);
            this.panelTipos.Controls.Add(this.cboTipo1);
            this.panelTipos.Controls.Add(this.lblTipo2);
            this.panelTipos.Controls.Add(this.lblTipo1);
            this.panelTipos.Controls.Add(this.pbTipo2);
            this.panelTipos.Controls.Add(this.pbTipo1);
            this.panelTipos.Controls.Add(this.panelTipo2);
            this.panelTipos.Controls.Add(this.panelTipo1);
            this.panelTipos.Location = new System.Drawing.Point(492, 15);
            this.panelTipos.Name = "panelTipos";
            this.panelTipos.Size = new System.Drawing.Size(408, 184);
            this.panelTipos.TabIndex = 1;
            // 
            // cboTipo2
            // 
            this.cboTipo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipo2.FormattingEnabled = true;
            this.cboTipo2.Location = new System.Drawing.Point(83, 151);
            this.cboTipo2.Name = "cboTipo2";
            this.cboTipo2.Size = new System.Drawing.Size(317, 24);
            this.cboTipo2.TabIndex = 7;
            this.cboTipo2.SelectedIndexChanged += new System.EventHandler(this.cboTipo2_SelectedIndexChanged);
            // 
            // cboTipo1
            // 
            this.cboTipo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipo1.FormattingEnabled = true;
            this.cboTipo1.Location = new System.Drawing.Point(83, 62);
            this.cboTipo1.Name = "cboTipo1";
            this.cboTipo1.Size = new System.Drawing.Size(317, 24);
            this.cboTipo1.TabIndex = 3;
            this.cboTipo1.SelectedIndexChanged += new System.EventHandler(this.cboTipo1_SelectedIndexChanged);
            // 
            // lblTipo2
            // 
            this.lblTipo2.AutoSize = true;
            this.lblTipo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo2.Location = new System.Drawing.Point(80, 123);
            this.lblTipo2.Name = "lblTipo2";
            this.lblTipo2.Size = new System.Drawing.Size(55, 16);
            this.lblTipo2.TabIndex = 6;
            this.lblTipo2.Text = "Tipo 2:";
            // 
            // lblTipo1
            // 
            this.lblTipo1.AutoSize = true;
            this.lblTipo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo1.Location = new System.Drawing.Point(80, 34);
            this.lblTipo1.Name = "lblTipo1";
            this.lblTipo1.Size = new System.Drawing.Size(55, 16);
            this.lblTipo1.TabIndex = 2;
            this.lblTipo1.Text = "Tipo 1:";
            // 
            // pbTipo2
            // 
            this.pbTipo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbTipo2.Location = new System.Drawing.Point(9, 120);
            this.pbTipo2.Name = "pbTipo2";
            this.pbTipo2.Size = new System.Drawing.Size(65, 55);
            this.pbTipo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTipo2.TabIndex = 5;
            this.pbTipo2.TabStop = false;
            // 
            // pbTipo1
            // 
            this.pbTipo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbTipo1.Location = new System.Drawing.Point(9, 31);
            this.pbTipo1.Name = "pbTipo1";
            this.pbTipo1.Size = new System.Drawing.Size(65, 55);
            this.pbTipo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTipo1.TabIndex = 1;
            this.pbTipo1.TabStop = false;
            // 
            // panelTipo2
            // 
            this.panelTipo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTipo2.Location = new System.Drawing.Point(9, 95);
            this.panelTipo2.Name = "panelTipo2";
            this.panelTipo2.Size = new System.Drawing.Size(391, 22);
            this.panelTipo2.TabIndex = 4;
            // 
            // panelTipo1
            // 
            this.panelTipo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTipo1.Location = new System.Drawing.Point(9, 6);
            this.panelTipo1.Name = "panelTipo1";
            this.panelTipo1.Size = new System.Drawing.Size(391, 22);
            this.panelTipo1.TabIndex = 0;
            // 
            // panelNroNombre
            // 
            this.panelNroNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNroNombre.Controls.Add(this.txtNombre);
            this.panelNroNombre.Controls.Add(this.lblNombre);
            this.panelNroNombre.Controls.Add(this.txtNro);
            this.panelNroNombre.Controls.Add(this.lblNro);
            this.panelNroNombre.Location = new System.Drawing.Point(15, 15);
            this.panelNroNombre.Name = "panelNroNombre";
            this.panelNroNombre.Size = new System.Drawing.Size(471, 78);
            this.panelNroNombre.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(90, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(360, 22);
            this.txtNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(22, 43);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 16);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNro
            // 
            this.txtNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNro.Location = new System.Drawing.Point(90, 13);
            this.txtNro.Name = "txtNro";
            this.txtNro.Size = new System.Drawing.Size(100, 22);
            this.txtNro.TabIndex = 1;
            this.txtNro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNro
            // 
            this.lblNro.AutoSize = true;
            this.lblNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNro.Location = new System.Drawing.Point(52, 16);
            this.lblNro.Name = "lblNro";
            this.lblNro.Size = new System.Drawing.Size(36, 16);
            this.lblNro.TabIndex = 0;
            this.lblNro.Text = "Nro:";
            // 
            // tpMovimientosPorNivel
            // 
            this.tpMovimientosPorNivel.BackColor = System.Drawing.SystemColors.Control;
            this.tpMovimientosPorNivel.Controls.Add(this.btnEliminarMovimiento);
            this.tpMovimientosPorNivel.Controls.Add(this.btnAgregarMovimiento);
            this.tpMovimientosPorNivel.Controls.Add(this.gbMovimientoNuevo);
            this.tpMovimientosPorNivel.Controls.Add(this.dgvMovimientosPorNivel);
            this.tpMovimientosPorNivel.Location = new System.Drawing.Point(4, 24);
            this.tpMovimientosPorNivel.Name = "tpMovimientosPorNivel";
            this.tpMovimientosPorNivel.Padding = new System.Windows.Forms.Padding(3);
            this.tpMovimientosPorNivel.Size = new System.Drawing.Size(914, 346);
            this.tpMovimientosPorNivel.TabIndex = 1;
            this.tpMovimientosPorNivel.Text = "Movimientos por Nivel";
            // 
            // btnEliminarMovimiento
            // 
            this.btnEliminarMovimiento.BackgroundImage = global::GameSoft.Properties.Resources.eliminar;
            this.btnEliminarMovimiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarMovimiento.Location = new System.Drawing.Point(855, 149);
            this.btnEliminarMovimiento.Name = "btnEliminarMovimiento";
            this.btnEliminarMovimiento.Size = new System.Drawing.Size(53, 49);
            this.btnEliminarMovimiento.TabIndex = 9;
            this.btnEliminarMovimiento.UseVisualStyleBackColor = true;
            this.btnEliminarMovimiento.Click += new System.EventHandler(this.btnEliminarMovimiento_Click);
            // 
            // btnAgregarMovimiento
            // 
            this.btnAgregarMovimiento.BackgroundImage = global::GameSoft.Properties.Resources.agregar;
            this.btnAgregarMovimiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarMovimiento.Location = new System.Drawing.Point(799, 149);
            this.btnAgregarMovimiento.Name = "btnAgregarMovimiento";
            this.btnAgregarMovimiento.Size = new System.Drawing.Size(53, 49);
            this.btnAgregarMovimiento.TabIndex = 8;
            this.btnAgregarMovimiento.UseVisualStyleBackColor = true;
            this.btnAgregarMovimiento.Click += new System.EventHandler(this.btnAgregarMovimiento_Click);
            // 
            // gbMovimientoNuevo
            // 
            this.gbMovimientoNuevo.Controls.Add(this.btnBuscarBlanco);
            this.gbMovimientoNuevo.Controls.Add(this.txtDescripcionBlancoMovimiento);
            this.gbMovimientoNuevo.Controls.Add(this.txtBlancoMovimiento);
            this.gbMovimientoNuevo.Controls.Add(this.lblBlancoMovimiento);
            this.gbMovimientoNuevo.Controls.Add(this.txtPPMovimiento);
            this.gbMovimientoNuevo.Controls.Add(this.lblPPMovimiento);
            this.gbMovimientoNuevo.Controls.Add(this.txtExactitudMovimiento);
            this.gbMovimientoNuevo.Controls.Add(this.lblExactitudMovimiento);
            this.gbMovimientoNuevo.Controls.Add(this.txtPoderMovimiento);
            this.gbMovimientoNuevo.Controls.Add(this.lblPoderMovimiento);
            this.gbMovimientoNuevo.Controls.Add(this.lblClaseMovimiento);
            this.gbMovimientoNuevo.Controls.Add(this.cboClaseMovimiento);
            this.gbMovimientoNuevo.Controls.Add(this.pbClaseMovimiento);
            this.gbMovimientoNuevo.Controls.Add(this.pbTipoMovimiento);
            this.gbMovimientoNuevo.Controls.Add(this.txtNombreMovimiento);
            this.gbMovimientoNuevo.Controls.Add(this.cboTipoMovimiento);
            this.gbMovimientoNuevo.Controls.Add(this.lblLVLMovimiento);
            this.gbMovimientoNuevo.Controls.Add(this.lblTipoMovimiento);
            this.gbMovimientoNuevo.Controls.Add(this.txtLVLMovimiento);
            this.gbMovimientoNuevo.Controls.Add(this.lblNombreMovimiento);
            this.gbMovimientoNuevo.Location = new System.Drawing.Point(6, 3);
            this.gbMovimientoNuevo.Name = "gbMovimientoNuevo";
            this.gbMovimientoNuevo.Size = new System.Drawing.Size(787, 195);
            this.gbMovimientoNuevo.TabIndex = 7;
            this.gbMovimientoNuevo.TabStop = false;
            this.gbMovimientoNuevo.Text = "Agregar Nuevo Movimiento por Nivel";
            // 
            // btnBuscarBlanco
            // 
            this.btnBuscarBlanco.BackgroundImage = global::GameSoft.Properties.Resources.Search;
            this.btnBuscarBlanco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarBlanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarBlanco.Location = new System.Drawing.Point(751, 101);
            this.btnBuscarBlanco.Name = "btnBuscarBlanco";
            this.btnBuscarBlanco.Size = new System.Drawing.Size(30, 24);
            this.btnBuscarBlanco.TabIndex = 20;
            this.btnBuscarBlanco.UseVisualStyleBackColor = true;
            this.btnBuscarBlanco.Click += new System.EventHandler(this.btnBuscarBlanco_Click);
            // 
            // txtDescripcionBlancoMovimiento
            // 
            this.txtDescripcionBlancoMovimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionBlancoMovimiento.Location = new System.Drawing.Point(495, 126);
            this.txtDescripcionBlancoMovimiento.Multiline = true;
            this.txtDescripcionBlancoMovimiento.Name = "txtDescripcionBlancoMovimiento";
            this.txtDescripcionBlancoMovimiento.ReadOnly = true;
            this.txtDescripcionBlancoMovimiento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcionBlancoMovimiento.Size = new System.Drawing.Size(286, 63);
            this.txtDescripcionBlancoMovimiento.TabIndex = 19;
            // 
            // txtBlancoMovimiento
            // 
            this.txtBlancoMovimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBlancoMovimiento.Location = new System.Drawing.Point(495, 102);
            this.txtBlancoMovimiento.Name = "txtBlancoMovimiento";
            this.txtBlancoMovimiento.ReadOnly = true;
            this.txtBlancoMovimiento.Size = new System.Drawing.Size(254, 22);
            this.txtBlancoMovimiento.TabIndex = 18;
            // 
            // lblBlancoMovimiento
            // 
            this.lblBlancoMovimiento.AutoSize = true;
            this.lblBlancoMovimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlancoMovimiento.Location = new System.Drawing.Point(430, 105);
            this.lblBlancoMovimiento.Name = "lblBlancoMovimiento";
            this.lblBlancoMovimiento.Size = new System.Drawing.Size(59, 16);
            this.lblBlancoMovimiento.TabIndex = 17;
            this.lblBlancoMovimiento.Text = "Blanco:";
            // 
            // txtPPMovimiento
            // 
            this.txtPPMovimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPPMovimiento.Location = new System.Drawing.Point(495, 77);
            this.txtPPMovimiento.Name = "txtPPMovimiento";
            this.txtPPMovimiento.Size = new System.Drawing.Size(86, 22);
            this.txtPPMovimiento.TabIndex = 16;
            // 
            // lblPPMovimiento
            // 
            this.lblPPMovimiento.AutoSize = true;
            this.lblPPMovimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPPMovimiento.Location = new System.Drawing.Point(458, 80);
            this.lblPPMovimiento.Name = "lblPPMovimiento";
            this.lblPPMovimiento.Size = new System.Drawing.Size(31, 16);
            this.lblPPMovimiento.TabIndex = 15;
            this.lblPPMovimiento.Text = "PP:";
            // 
            // txtExactitudMovimiento
            // 
            this.txtExactitudMovimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExactitudMovimiento.Location = new System.Drawing.Point(495, 52);
            this.txtExactitudMovimiento.Name = "txtExactitudMovimiento";
            this.txtExactitudMovimiento.Size = new System.Drawing.Size(86, 22);
            this.txtExactitudMovimiento.TabIndex = 14;
            // 
            // lblExactitudMovimiento
            // 
            this.lblExactitudMovimiento.AutoSize = true;
            this.lblExactitudMovimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExactitudMovimiento.Location = new System.Drawing.Point(415, 55);
            this.lblExactitudMovimiento.Name = "lblExactitudMovimiento";
            this.lblExactitudMovimiento.Size = new System.Drawing.Size(74, 16);
            this.lblExactitudMovimiento.TabIndex = 13;
            this.lblExactitudMovimiento.Text = "Exactitud:";
            // 
            // txtPoderMovimiento
            // 
            this.txtPoderMovimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoderMovimiento.Location = new System.Drawing.Point(495, 27);
            this.txtPoderMovimiento.Name = "txtPoderMovimiento";
            this.txtPoderMovimiento.Size = new System.Drawing.Size(86, 22);
            this.txtPoderMovimiento.TabIndex = 12;
            // 
            // lblPoderMovimiento
            // 
            this.lblPoderMovimiento.AutoSize = true;
            this.lblPoderMovimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoderMovimiento.Location = new System.Drawing.Point(436, 30);
            this.lblPoderMovimiento.Name = "lblPoderMovimiento";
            this.lblPoderMovimiento.Size = new System.Drawing.Size(53, 16);
            this.lblPoderMovimiento.TabIndex = 11;
            this.lblPoderMovimiento.Text = "Poder:";
            // 
            // lblClaseMovimiento
            // 
            this.lblClaseMovimiento.AutoSize = true;
            this.lblClaseMovimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaseMovimiento.Location = new System.Drawing.Point(32, 136);
            this.lblClaseMovimiento.Name = "lblClaseMovimiento";
            this.lblClaseMovimiento.Size = new System.Drawing.Size(51, 16);
            this.lblClaseMovimiento.TabIndex = 10;
            this.lblClaseMovimiento.Text = "Clase:";
            // 
            // cboClaseMovimiento
            // 
            this.cboClaseMovimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboClaseMovimiento.FormattingEnabled = true;
            this.cboClaseMovimiento.Location = new System.Drawing.Point(173, 133);
            this.cboClaseMovimiento.Name = "cboClaseMovimiento";
            this.cboClaseMovimiento.Size = new System.Drawing.Size(203, 24);
            this.cboClaseMovimiento.TabIndex = 9;
            // 
            // pbClaseMovimiento
            // 
            this.pbClaseMovimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbClaseMovimiento.Location = new System.Drawing.Point(89, 126);
            this.pbClaseMovimiento.Name = "pbClaseMovimiento";
            this.pbClaseMovimiento.Size = new System.Drawing.Size(78, 36);
            this.pbClaseMovimiento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClaseMovimiento.TabIndex = 8;
            this.pbClaseMovimiento.TabStop = false;
            // 
            // pbTipoMovimiento
            // 
            this.pbTipoMovimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbTipoMovimiento.Location = new System.Drawing.Point(89, 74);
            this.pbTipoMovimiento.Name = "pbTipoMovimiento";
            this.pbTipoMovimiento.Size = new System.Drawing.Size(56, 49);
            this.pbTipoMovimiento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTipoMovimiento.TabIndex = 7;
            this.pbTipoMovimiento.TabStop = false;
            // 
            // txtNombreMovimiento
            // 
            this.txtNombreMovimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreMovimiento.Location = new System.Drawing.Point(89, 49);
            this.txtNombreMovimiento.Name = "txtNombreMovimiento";
            this.txtNombreMovimiento.Size = new System.Drawing.Size(287, 22);
            this.txtNombreMovimiento.TabIndex = 4;
            // 
            // cboTipoMovimiento
            // 
            this.cboTipoMovimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoMovimiento.FormattingEnabled = true;
            this.cboTipoMovimiento.Location = new System.Drawing.Point(151, 85);
            this.cboTipoMovimiento.Name = "cboTipoMovimiento";
            this.cboTipoMovimiento.Size = new System.Drawing.Size(225, 24);
            this.cboTipoMovimiento.TabIndex = 6;
            this.cboTipoMovimiento.SelectedIndexChanged += new System.EventHandler(this.cboTipoMovimiento_SelectedIndexChanged);
            // 
            // lblLVLMovimiento
            // 
            this.lblLVLMovimiento.AutoSize = true;
            this.lblLVLMovimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLVLMovimiento.Location = new System.Drawing.Point(46, 27);
            this.lblLVLMovimiento.Name = "lblLVLMovimiento";
            this.lblLVLMovimiento.Size = new System.Drawing.Size(37, 16);
            this.lblLVLMovimiento.TabIndex = 1;
            this.lblLVLMovimiento.Text = "LVL:";
            // 
            // lblTipoMovimiento
            // 
            this.lblTipoMovimiento.AutoSize = true;
            this.lblTipoMovimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoMovimiento.Location = new System.Drawing.Point(40, 88);
            this.lblTipoMovimiento.Name = "lblTipoMovimiento";
            this.lblTipoMovimiento.Size = new System.Drawing.Size(43, 16);
            this.lblTipoMovimiento.TabIndex = 5;
            this.lblTipoMovimiento.Text = "Tipo:";
            // 
            // txtLVLMovimiento
            // 
            this.txtLVLMovimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLVLMovimiento.Location = new System.Drawing.Point(89, 24);
            this.txtLVLMovimiento.Name = "txtLVLMovimiento";
            this.txtLVLMovimiento.Size = new System.Drawing.Size(67, 22);
            this.txtLVLMovimiento.TabIndex = 2;
            this.txtLVLMovimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNombreMovimiento
            // 
            this.lblNombreMovimiento.AutoSize = true;
            this.lblNombreMovimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMovimiento.Location = new System.Drawing.Point(17, 52);
            this.lblNombreMovimiento.Name = "lblNombreMovimiento";
            this.lblNombreMovimiento.Size = new System.Drawing.Size(66, 16);
            this.lblNombreMovimiento.TabIndex = 3;
            this.lblNombreMovimiento.Text = "Nombre:";
            // 
            // dgvMovimientosPorNivel
            // 
            this.dgvMovimientosPorNivel.AllowUserToAddRows = false;
            this.dgvMovimientosPorNivel.AllowUserToDeleteRows = false;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle37.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle37.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMovimientosPorNivel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.dgvMovimientosPorNivel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimientosPorNivel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LV,
            this.NOMBRE,
            this.TIPO,
            this.CLASE,
            this.PODER,
            this.EXACT,
            this.PP,
            this.BLANCO});
            this.dgvMovimientosPorNivel.Location = new System.Drawing.Point(6, 204);
            this.dgvMovimientosPorNivel.Name = "dgvMovimientosPorNivel";
            this.dgvMovimientosPorNivel.ReadOnly = true;
            this.dgvMovimientosPorNivel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovimientosPorNivel.Size = new System.Drawing.Size(902, 136);
            this.dgvMovimientosPorNivel.TabIndex = 0;
            this.dgvMovimientosPorNivel.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvMovimientosPorNivel_CellFormatting);
            // 
            // LV
            // 
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.LV.DefaultCellStyle = dataGridViewCellStyle38;
            this.LV.HeaderText = "LV";
            this.LV.Name = "LV";
            this.LV.ReadOnly = true;
            this.LV.Width = 70;
            // 
            // NOMBRE
            // 
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NOMBRE.DefaultCellStyle = dataGridViewCellStyle39;
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            this.NOMBRE.Width = 120;
            // 
            // TIPO
            // 
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TIPO.DefaultCellStyle = dataGridViewCellStyle40;
            this.TIPO.HeaderText = "TIPO";
            this.TIPO.Name = "TIPO";
            this.TIPO.ReadOnly = true;
            this.TIPO.Width = 120;
            // 
            // CLASE
            // 
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CLASE.DefaultCellStyle = dataGridViewCellStyle41;
            this.CLASE.HeaderText = "CLASE";
            this.CLASE.Name = "CLASE";
            this.CLASE.ReadOnly = true;
            this.CLASE.Width = 120;
            // 
            // PODER
            // 
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PODER.DefaultCellStyle = dataGridViewCellStyle42;
            this.PODER.HeaderText = "PODER";
            this.PODER.Name = "PODER";
            this.PODER.ReadOnly = true;
            this.PODER.Width = 70;
            // 
            // EXACT
            // 
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.EXACT.DefaultCellStyle = dataGridViewCellStyle43;
            this.EXACT.HeaderText = "EXACT";
            this.EXACT.Name = "EXACT";
            this.EXACT.ReadOnly = true;
            this.EXACT.Width = 70;
            // 
            // PP
            // 
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PP.DefaultCellStyle = dataGridViewCellStyle44;
            this.PP.HeaderText = "PP";
            this.PP.Name = "PP";
            this.PP.ReadOnly = true;
            this.PP.Width = 70;
            // 
            // BLANCO
            // 
            dataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.BLANCO.DefaultCellStyle = dataGridViewCellStyle45;
            this.BLANCO.HeaderText = "BLANCO";
            this.BLANCO.Name = "BLANCO";
            this.BLANCO.ReadOnly = true;
            this.BLANCO.Width = 200;
            // 
            // ofdFoto
            // 
            this.ofdFoto.FileName = "ofdFoto";
            // 
            // frmGestionPokemons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 419);
            this.Controls.Add(this.tcGestionPokemon);
            this.Controls.Add(this.tsMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmGestionPokemons";
            this.Text = "Formulario de Gestión de Pokémon";
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.tcGestionPokemon.ResumeLayout(false);
            this.tbDatosGenerales.ResumeLayout(false);
            this.tbDatosGenerales.PerformLayout();
            this.panelGeneracion.ResumeLayout(false);
            this.panelGeneracion.PerformLayout();
            this.panelPesoAltura.ResumeLayout(false);
            this.panelPesoAltura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.panelTipos.ResumeLayout(false);
            this.panelTipos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTipo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTipo1)).EndInit();
            this.panelNroNombre.ResumeLayout(false);
            this.panelNroNombre.PerformLayout();
            this.tpMovimientosPorNivel.ResumeLayout(false);
            this.gbMovimientoNuevo.ResumeLayout(false);
            this.gbMovimientoNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClaseMovimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTipoMovimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientosPorNivel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.TabControl tcGestionPokemon;
        private System.Windows.Forms.TabPage tbDatosGenerales;
        private System.Windows.Forms.TabPage tpMovimientosPorNivel;
        private System.Windows.Forms.Panel panelNroNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNro;
        private System.Windows.Forms.Label lblNro;
        private System.Windows.Forms.Panel panelTipos;
        private System.Windows.Forms.Button btnSubirFoto;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Panel panelTipo1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cboTipo2;
        private System.Windows.Forms.ComboBox cboTipo1;
        private System.Windows.Forms.Label lblTipo2;
        private System.Windows.Forms.Label lblTipo1;
        private System.Windows.Forms.PictureBox pbTipo2;
        private System.Windows.Forms.PictureBox pbTipo1;
        private System.Windows.Forms.Panel panelTipo2;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Panel panelPesoAltura;
        private System.Windows.Forms.DataGridView dgvMovimientosPorNivel;
        private System.Windows.Forms.OpenFileDialog ofdFoto;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblKg;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblm;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Panel panelGeneracion;
        private System.Windows.Forms.Label lblGeneracion;
        private System.Windows.Forms.RadioButton rbTerceraGen;
        private System.Windows.Forms.RadioButton rbSegundaGen;
        private System.Windows.Forms.RadioButton rbPrimeraGen;
        private System.Windows.Forms.TextBox txtLVLMovimiento;
        private System.Windows.Forms.Label lblLVLMovimiento;
        private System.Windows.Forms.ComboBox cboTipoMovimiento;
        private System.Windows.Forms.Label lblTipoMovimiento;
        private System.Windows.Forms.TextBox txtNombreMovimiento;
        private System.Windows.Forms.Label lblNombreMovimiento;
        private System.Windows.Forms.Button btnEliminarMovimiento;
        private System.Windows.Forms.Button btnAgregarMovimiento;
        private System.Windows.Forms.GroupBox gbMovimientoNuevo;
        private System.Windows.Forms.PictureBox pbTipoMovimiento;
        private System.Windows.Forms.ComboBox cboClaseMovimiento;
        private System.Windows.Forms.PictureBox pbClaseMovimiento;
        private System.Windows.Forms.TextBox txtPoderMovimiento;
        private System.Windows.Forms.Label lblPoderMovimiento;
        private System.Windows.Forms.Label lblClaseMovimiento;
        private System.Windows.Forms.Button btnBuscarBlanco;
        private System.Windows.Forms.TextBox txtDescripcionBlancoMovimiento;
        private System.Windows.Forms.TextBox txtBlancoMovimiento;
        private System.Windows.Forms.Label lblBlancoMovimiento;
        private System.Windows.Forms.TextBox txtPPMovimiento;
        private System.Windows.Forms.Label lblPPMovimiento;
        private System.Windows.Forms.TextBox txtExactitudMovimiento;
        private System.Windows.Forms.Label lblExactitudMovimiento;
        private System.Windows.Forms.ToolTip ttAgregarMovimiento;
        private System.Windows.Forms.ToolTip ttEliminarMovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn LV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLASE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PODER;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXACT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PP;
        private System.Windows.Forms.DataGridViewTextBoxColumn BLANCO;
        private System.Windows.Forms.ToolTip ttPoder;
        private System.Windows.Forms.ToolTip ttExactitud;
        private System.Windows.Forms.ToolTip ttPP;
    }
}

