namespace GameSoft
{
    partial class frmGestionVideojuegos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionVideojuegos));
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.lblGestionVideojuegos = new System.Windows.Forms.Label();
            this.gbDatosGenerales = new System.Windows.Forms.GroupBox();
            this.btnDescargarArchivoPDF = new System.Windows.Forms.Button();
            this.btnSubirArchivoPDF = new System.Windows.Forms.Button();
            this.txtRutaArchivoPDF = new System.Windows.Forms.TextBox();
            this.lblRutaArchivoPDF = new System.Windows.Forms.Label();
            this.txtCostoDesarrollo = new System.Windows.Forms.TextBox();
            this.lblCostoDesarrollo = new System.Windows.Forms.Label();
            this.cbSmartphone = new System.Windows.Forms.CheckBox();
            this.rbAdultsOnly = new System.Windows.Forms.RadioButton();
            this.rbMature = new System.Windows.Forms.RadioButton();
            this.rbTeen = new System.Windows.Forms.RadioButton();
            this.cbPC = new System.Windows.Forms.CheckBox();
            this.cbNintendoSwitch = new System.Windows.Forms.CheckBox();
            this.cbXboxSeries = new System.Windows.Forms.CheckBox();
            this.cbPlaystation5 = new System.Windows.Forms.CheckBox();
            this.rbEveryone = new System.Windows.Forms.RadioButton();
            this.lblClasificacionESRB = new System.Windows.Forms.Label();
            this.lblPlataformas = new System.Windows.Forms.Label();
            this.btnBuscarDesarrolladora = new System.Windows.Forms.Button();
            this.txtDesarrolladora = new System.Windows.Forms.TextBox();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.dtpFechaLanzamiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechaLanzamiento = new System.Windows.Forms.Label();
            this.lblDesarrolladora = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.btnSubirPortada = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIDVideojuego = new System.Windows.Forms.TextBox();
            this.lblIDVideojuego = new System.Windows.Forms.Label();
            this.pbPortada = new System.Windows.Forms.PictureBox();
            this.ofdPortada = new System.Windows.Forms.OpenFileDialog();
            this.ofdArchivo = new System.Windows.Forms.OpenFileDialog();
            this.sfdArchivo = new System.Windows.Forms.SaveFileDialog();
            this.tsMenu.SuspendLayout();
            this.gbDatosGenerales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).BeginInit();
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
            this.tsMenu.Size = new System.Drawing.Size(1131, 25);
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
            this.btnBuscar.Image = global::GameSoft.Properties.Resources.Search;
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(66, 22);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::GameSoft.Properties.Resources.Cancel;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(78, 22);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblGestionVideojuegos
            // 
            this.lblGestionVideojuegos.AutoSize = true;
            this.lblGestionVideojuegos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionVideojuegos.Location = new System.Drawing.Point(12, 35);
            this.lblGestionVideojuegos.Name = "lblGestionVideojuegos";
            this.lblGestionVideojuegos.Size = new System.Drawing.Size(174, 16);
            this.lblGestionVideojuegos.TabIndex = 1;
            this.lblGestionVideojuegos.Text = "Gestión de Videojuegos";
            // 
            // gbDatosGenerales
            // 
            this.gbDatosGenerales.Controls.Add(this.btnDescargarArchivoPDF);
            this.gbDatosGenerales.Controls.Add(this.btnSubirArchivoPDF);
            this.gbDatosGenerales.Controls.Add(this.txtRutaArchivoPDF);
            this.gbDatosGenerales.Controls.Add(this.lblRutaArchivoPDF);
            this.gbDatosGenerales.Controls.Add(this.txtCostoDesarrollo);
            this.gbDatosGenerales.Controls.Add(this.lblCostoDesarrollo);
            this.gbDatosGenerales.Controls.Add(this.cbSmartphone);
            this.gbDatosGenerales.Controls.Add(this.rbAdultsOnly);
            this.gbDatosGenerales.Controls.Add(this.rbMature);
            this.gbDatosGenerales.Controls.Add(this.rbTeen);
            this.gbDatosGenerales.Controls.Add(this.cbPC);
            this.gbDatosGenerales.Controls.Add(this.cbNintendoSwitch);
            this.gbDatosGenerales.Controls.Add(this.cbXboxSeries);
            this.gbDatosGenerales.Controls.Add(this.cbPlaystation5);
            this.gbDatosGenerales.Controls.Add(this.rbEveryone);
            this.gbDatosGenerales.Controls.Add(this.lblClasificacionESRB);
            this.gbDatosGenerales.Controls.Add(this.lblPlataformas);
            this.gbDatosGenerales.Controls.Add(this.btnBuscarDesarrolladora);
            this.gbDatosGenerales.Controls.Add(this.txtDesarrolladora);
            this.gbDatosGenerales.Controls.Add(this.cboGenero);
            this.gbDatosGenerales.Controls.Add(this.dtpFechaLanzamiento);
            this.gbDatosGenerales.Controls.Add(this.lblFechaLanzamiento);
            this.gbDatosGenerales.Controls.Add(this.lblDesarrolladora);
            this.gbDatosGenerales.Controls.Add(this.lblGenero);
            this.gbDatosGenerales.Controls.Add(this.btnSubirPortada);
            this.gbDatosGenerales.Controls.Add(this.lblNombre);
            this.gbDatosGenerales.Controls.Add(this.txtNombre);
            this.gbDatosGenerales.Controls.Add(this.txtIDVideojuego);
            this.gbDatosGenerales.Controls.Add(this.lblIDVideojuego);
            this.gbDatosGenerales.Controls.Add(this.pbPortada);
            this.gbDatosGenerales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosGenerales.Location = new System.Drawing.Point(12, 64);
            this.gbDatosGenerales.Name = "gbDatosGenerales";
            this.gbDatosGenerales.Size = new System.Drawing.Size(1107, 304);
            this.gbDatosGenerales.TabIndex = 2;
            this.gbDatosGenerales.TabStop = false;
            this.gbDatosGenerales.Text = "Datos Generales";
            // 
            // btnDescargarArchivoPDF
            // 
            this.btnDescargarArchivoPDF.Location = new System.Drawing.Point(991, 267);
            this.btnDescargarArchivoPDF.Name = "btnDescargarArchivoPDF";
            this.btnDescargarArchivoPDF.Size = new System.Drawing.Size(103, 24);
            this.btnDescargarArchivoPDF.TabIndex = 29;
            this.btnDescargarArchivoPDF.Text = "Descargar";
            this.btnDescargarArchivoPDF.UseVisualStyleBackColor = true;
            this.btnDescargarArchivoPDF.Click += new System.EventHandler(this.btnDescargarArchivoPDF_Click);
            // 
            // btnSubirArchivoPDF
            // 
            this.btnSubirArchivoPDF.Location = new System.Drawing.Point(911, 267);
            this.btnSubirArchivoPDF.Name = "btnSubirArchivoPDF";
            this.btnSubirArchivoPDF.Size = new System.Drawing.Size(74, 24);
            this.btnSubirArchivoPDF.TabIndex = 28;
            this.btnSubirArchivoPDF.Text = "Subir";
            this.btnSubirArchivoPDF.UseVisualStyleBackColor = true;
            this.btnSubirArchivoPDF.Click += new System.EventHandler(this.btnSubirArchivoPDF_Click);
            // 
            // txtRutaArchivoPDF
            // 
            this.txtRutaArchivoPDF.Location = new System.Drawing.Point(232, 268);
            this.txtRutaArchivoPDF.Name = "txtRutaArchivoPDF";
            this.txtRutaArchivoPDF.ReadOnly = true;
            this.txtRutaArchivoPDF.Size = new System.Drawing.Size(673, 22);
            this.txtRutaArchivoPDF.TabIndex = 27;
            // 
            // lblRutaArchivoPDF
            // 
            this.lblRutaArchivoPDF.AutoSize = true;
            this.lblRutaArchivoPDF.Location = new System.Drawing.Point(13, 271);
            this.lblRutaArchivoPDF.Name = "lblRutaArchivoPDF";
            this.lblRutaArchivoPDF.Size = new System.Drawing.Size(213, 16);
            this.lblRutaArchivoPDF.TabIndex = 26;
            this.lblRutaArchivoPDF.Text = "Material Promocional en PDF:";
            // 
            // txtCostoDesarrollo
            // 
            this.txtCostoDesarrollo.Location = new System.Drawing.Point(532, 169);
            this.txtCostoDesarrollo.Name = "txtCostoDesarrollo";
            this.txtCostoDesarrollo.Size = new System.Drawing.Size(169, 22);
            this.txtCostoDesarrollo.TabIndex = 25;
            // 
            // lblCostoDesarrollo
            // 
            this.lblCostoDesarrollo.AutoSize = true;
            this.lblCostoDesarrollo.Location = new System.Drawing.Point(354, 172);
            this.lblCostoDesarrollo.Name = "lblCostoDesarrollo";
            this.lblCostoDesarrollo.Size = new System.Drawing.Size(172, 16);
            this.lblCostoDesarrollo.TabIndex = 24;
            this.lblCostoDesarrollo.Text = "Costo de Desarrollo ($):";
            // 
            // cbSmartphone
            // 
            this.cbSmartphone.AutoSize = true;
            this.cbSmartphone.Location = new System.Drawing.Point(960, 230);
            this.cbSmartphone.Name = "cbSmartphone";
            this.cbSmartphone.Size = new System.Drawing.Size(109, 20);
            this.cbSmartphone.TabIndex = 23;
            this.cbSmartphone.Text = "Smartphone";
            this.cbSmartphone.UseVisualStyleBackColor = true;
            // 
            // rbAdultsOnly
            // 
            this.rbAdultsOnly.AutoSize = true;
            this.rbAdultsOnly.Location = new System.Drawing.Point(846, 198);
            this.rbAdultsOnly.Name = "rbAdultsOnly";
            this.rbAdultsOnly.Size = new System.Drawing.Size(127, 20);
            this.rbAdultsOnly.TabIndex = 22;
            this.rbAdultsOnly.TabStop = true;
            this.rbAdultsOnly.Text = "Adults Only (A)";
            this.rbAdultsOnly.UseVisualStyleBackColor = true;
            // 
            // rbMature
            // 
            this.rbMature.AutoSize = true;
            this.rbMature.Location = new System.Drawing.Point(742, 198);
            this.rbMature.Name = "rbMature";
            this.rbMature.Size = new System.Drawing.Size(98, 20);
            this.rbMature.TabIndex = 21;
            this.rbMature.TabStop = true;
            this.rbMature.Text = "Mature (M)";
            this.rbMature.UseVisualStyleBackColor = true;
            // 
            // rbTeen
            // 
            this.rbTeen.AutoSize = true;
            this.rbTeen.Location = new System.Drawing.Point(651, 198);
            this.rbTeen.Name = "rbTeen";
            this.rbTeen.Size = new System.Drawing.Size(85, 20);
            this.rbTeen.TabIndex = 20;
            this.rbTeen.TabStop = true;
            this.rbTeen.Text = "Teen (T)";
            this.rbTeen.UseVisualStyleBackColor = true;
            // 
            // cbPC
            // 
            this.cbPC.AutoSize = true;
            this.cbPC.Location = new System.Drawing.Point(908, 230);
            this.cbPC.Name = "cbPC";
            this.cbPC.Size = new System.Drawing.Size(46, 20);
            this.cbPC.TabIndex = 19;
            this.cbPC.Text = "PC";
            this.cbPC.UseVisualStyleBackColor = true;
            // 
            // cbNintendoSwitch
            // 
            this.cbNintendoSwitch.AutoSize = true;
            this.cbNintendoSwitch.Location = new System.Drawing.Point(651, 230);
            this.cbNintendoSwitch.Name = "cbNintendoSwitch";
            this.cbNintendoSwitch.Size = new System.Drawing.Size(136, 20);
            this.cbNintendoSwitch.TabIndex = 18;
            this.cbNintendoSwitch.Text = "Nintendo Switch";
            this.cbNintendoSwitch.UseVisualStyleBackColor = true;
            // 
            // cbXboxSeries
            // 
            this.cbXboxSeries.AutoSize = true;
            this.cbXboxSeries.Location = new System.Drawing.Point(793, 230);
            this.cbXboxSeries.Name = "cbXboxSeries";
            this.cbXboxSeries.Size = new System.Drawing.Size(109, 20);
            this.cbXboxSeries.TabIndex = 17;
            this.cbXboxSeries.Text = "Xbox Series";
            this.cbXboxSeries.UseVisualStyleBackColor = true;
            // 
            // cbPlaystation5
            // 
            this.cbPlaystation5.AutoSize = true;
            this.cbPlaystation5.Location = new System.Drawing.Point(530, 230);
            this.cbPlaystation5.Name = "cbPlaystation5";
            this.cbPlaystation5.Size = new System.Drawing.Size(115, 20);
            this.cbPlaystation5.TabIndex = 16;
            this.cbPlaystation5.Text = "Playstation 5";
            this.cbPlaystation5.UseVisualStyleBackColor = true;
            // 
            // rbEveryone
            // 
            this.rbEveryone.AutoSize = true;
            this.rbEveryone.Location = new System.Drawing.Point(530, 198);
            this.rbEveryone.Name = "rbEveryone";
            this.rbEveryone.Size = new System.Drawing.Size(115, 20);
            this.rbEveryone.TabIndex = 15;
            this.rbEveryone.TabStop = true;
            this.rbEveryone.Text = "Everyone (E)";
            this.rbEveryone.UseVisualStyleBackColor = true;
            // 
            // lblClasificacionESRB
            // 
            this.lblClasificacionESRB.AutoSize = true;
            this.lblClasificacionESRB.Location = new System.Drawing.Point(379, 200);
            this.lblClasificacionESRB.Name = "lblClasificacionESRB";
            this.lblClasificacionESRB.Size = new System.Drawing.Size(145, 16);
            this.lblClasificacionESRB.TabIndex = 14;
            this.lblClasificacionESRB.Text = "Clasificación ESRB:";
            // 
            // lblPlataformas
            // 
            this.lblPlataformas.AutoSize = true;
            this.lblPlataformas.Location = new System.Drawing.Point(360, 232);
            this.lblPlataformas.Name = "lblPlataformas";
            this.lblPlataformas.Size = new System.Drawing.Size(163, 16);
            this.lblPlataformas.TabIndex = 13;
            this.lblPlataformas.Text = "Plataformas de Juego:";
            // 
            // btnBuscarDesarrolladora
            // 
            this.btnBuscarDesarrolladora.BackgroundImage = global::GameSoft.Properties.Resources.Search;
            this.btnBuscarDesarrolladora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscarDesarrolladora.Location = new System.Drawing.Point(1062, 82);
            this.btnBuscarDesarrolladora.Name = "btnBuscarDesarrolladora";
            this.btnBuscarDesarrolladora.Size = new System.Drawing.Size(32, 25);
            this.btnBuscarDesarrolladora.TabIndex = 12;
            this.btnBuscarDesarrolladora.UseVisualStyleBackColor = true;
            this.btnBuscarDesarrolladora.Click += new System.EventHandler(this.btnBuscarDesarrolladora_Click);
            // 
            // txtDesarrolladora
            // 
            this.txtDesarrolladora.Location = new System.Drawing.Point(532, 83);
            this.txtDesarrolladora.Name = "txtDesarrolladora";
            this.txtDesarrolladora.ReadOnly = true;
            this.txtDesarrolladora.Size = new System.Drawing.Size(524, 22);
            this.txtDesarrolladora.TabIndex = 11;
            // 
            // cboGenero
            // 
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Location = new System.Drawing.Point(532, 111);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(562, 24);
            this.cboGenero.TabIndex = 10;
            // 
            // dtpFechaLanzamiento
            // 
            this.dtpFechaLanzamiento.Location = new System.Drawing.Point(532, 141);
            this.dtpFechaLanzamiento.Name = "dtpFechaLanzamiento";
            this.dtpFechaLanzamiento.Size = new System.Drawing.Size(562, 22);
            this.dtpFechaLanzamiento.TabIndex = 9;
            // 
            // lblFechaLanzamiento
            // 
            this.lblFechaLanzamiento.AutoSize = true;
            this.lblFechaLanzamiento.Location = new System.Drawing.Point(359, 144);
            this.lblFechaLanzamiento.Name = "lblFechaLanzamiento";
            this.lblFechaLanzamiento.Size = new System.Drawing.Size(167, 16);
            this.lblFechaLanzamiento.TabIndex = 8;
            this.lblFechaLanzamiento.Text = "Fecha de Lanzamiento:";
            // 
            // lblDesarrolladora
            // 
            this.lblDesarrolladora.AutoSize = true;
            this.lblDesarrolladora.Location = new System.Drawing.Point(410, 86);
            this.lblDesarrolladora.Name = "lblDesarrolladora";
            this.lblDesarrolladora.Size = new System.Drawing.Size(116, 16);
            this.lblDesarrolladora.TabIndex = 7;
            this.lblDesarrolladora.Text = "Desarrolladora:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(464, 114);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(62, 16);
            this.lblGenero.TabIndex = 6;
            this.lblGenero.Text = "Género:";
            // 
            // btnSubirPortada
            // 
            this.btnSubirPortada.BackgroundImage = global::GameSoft.Properties.Resources.Upload;
            this.btnSubirPortada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubirPortada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubirPortada.Location = new System.Drawing.Point(302, 212);
            this.btnSubirPortada.Name = "btnSubirPortada";
            this.btnSubirPortada.Size = new System.Drawing.Size(42, 36);
            this.btnSubirPortada.TabIndex = 5;
            this.btnSubirPortada.UseVisualStyleBackColor = true;
            this.btnSubirPortada.Click += new System.EventHandler(this.btnSubirPortada_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(350, 58);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(176, 16);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre del Videojuego:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(532, 55);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(562, 22);
            this.txtNombre.TabIndex = 3;
            // 
            // txtIDVideojuego
            // 
            this.txtIDVideojuego.Location = new System.Drawing.Point(532, 27);
            this.txtIDVideojuego.Name = "txtIDVideojuego";
            this.txtIDVideojuego.ReadOnly = true;
            this.txtIDVideojuego.Size = new System.Drawing.Size(100, 22);
            this.txtIDVideojuego.TabIndex = 2;
            this.txtIDVideojuego.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIDVideojuego
            // 
            this.lblIDVideojuego.AutoSize = true;
            this.lblIDVideojuego.Location = new System.Drawing.Point(390, 30);
            this.lblIDVideojuego.Name = "lblIDVideojuego";
            this.lblIDVideojuego.Size = new System.Drawing.Size(136, 16);
            this.lblIDVideojuego.TabIndex = 1;
            this.lblIDVideojuego.Text = "ID del Videojuego:";
            // 
            // pbPortada
            // 
            this.pbPortada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPortada.Location = new System.Drawing.Point(16, 27);
            this.pbPortada.Name = "pbPortada";
            this.pbPortada.Size = new System.Drawing.Size(328, 221);
            this.pbPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPortada.TabIndex = 0;
            this.pbPortada.TabStop = false;
            // 
            // ofdPortada
            // 
            this.ofdPortada.FileName = "ofdPortada";
            // 
            // ofdArchivo
            // 
            this.ofdArchivo.FileName = "ofdArchivo";
            // 
            // frmGestionVideojuegos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 380);
            this.Controls.Add(this.gbDatosGenerales);
            this.Controls.Add(this.lblGestionVideojuegos);
            this.Controls.Add(this.tsMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmGestionVideojuegos";
            this.Text = "Formulario de Gestión de Videojuegos";
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.gbDatosGenerales.ResumeLayout(false);
            this.gbDatosGenerales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.Label lblGestionVideojuegos;
        private System.Windows.Forms.GroupBox gbDatosGenerales;
        private System.Windows.Forms.Button btnSubirPortada;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIDVideojuego;
        private System.Windows.Forms.Label lblIDVideojuego;
        private System.Windows.Forms.PictureBox pbPortada;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Button btnBuscarDesarrolladora;
        private System.Windows.Forms.TextBox txtDesarrolladora;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.DateTimePicker dtpFechaLanzamiento;
        private System.Windows.Forms.Label lblFechaLanzamiento;
        private System.Windows.Forms.Label lblDesarrolladora;
        private System.Windows.Forms.RadioButton rbEveryone;
        private System.Windows.Forms.Label lblClasificacionESRB;
        private System.Windows.Forms.Label lblPlataformas;
        private System.Windows.Forms.CheckBox cbPC;
        private System.Windows.Forms.CheckBox cbNintendoSwitch;
        private System.Windows.Forms.CheckBox cbXboxSeries;
        private System.Windows.Forms.CheckBox cbPlaystation5;
        private System.Windows.Forms.Label lblCostoDesarrollo;
        private System.Windows.Forms.CheckBox cbSmartphone;
        private System.Windows.Forms.RadioButton rbAdultsOnly;
        private System.Windows.Forms.RadioButton rbMature;
        private System.Windows.Forms.RadioButton rbTeen;
        private System.Windows.Forms.Button btnDescargarArchivoPDF;
        private System.Windows.Forms.Button btnSubirArchivoPDF;
        private System.Windows.Forms.TextBox txtRutaArchivoPDF;
        private System.Windows.Forms.Label lblRutaArchivoPDF;
        private System.Windows.Forms.TextBox txtCostoDesarrollo;
        private System.Windows.Forms.OpenFileDialog ofdPortada;
        private System.Windows.Forms.OpenFileDialog ofdArchivo;
        private System.Windows.Forms.SaveFileDialog sfdArchivo;
    }
}

