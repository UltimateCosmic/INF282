namespace EventSoft
{
    partial class frmGestionLocales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionLocales));
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.lblID = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbDatosGenerales = new System.Windows.Forms.GroupBox();
            this.cbVestibulo = new System.Windows.Forms.CheckBox();
            this.cbProyector = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPalco = new System.Windows.Forms.CheckBox();
            this.btnDescargarPDF = new System.Windows.Forms.Button();
            this.btnSubirPDF = new System.Windows.Forms.Button();
            this.txtPlano = new System.Windows.Forms.TextBox();
            this.lblPlano = new System.Windows.Forms.Label();
            this.txtResenha = new System.Windows.Forms.TextBox();
            this.lblResenha = new System.Windows.Forms.Label();
            this.cboEstiloArquitectonico = new System.Windows.Forms.ComboBox();
            this.lblEstiloArquitectonico = new System.Windows.Forms.Label();
            this.txtAforo = new System.Windows.Forms.TextBox();
            this.lblAforo = new System.Windows.Forms.Label();
            this.dtpFechaConstruccion = new System.Windows.Forms.DateTimePicker();
            this.lblFechaConstruccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.btnSubirFoto = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            this.ofdPlano = new System.Windows.Forms.OpenFileDialog();
            this.sfdPlano = new System.Windows.Forms.SaveFileDialog();
            this.tsMenu.SuspendLayout();
            this.gbDatosGenerales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
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
            this.tsMenu.Size = new System.Drawing.Size(972, 25);
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
            this.btnBuscar.Image = global::EventSoft.Properties.Resources.Search;
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(66, 22);
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::EventSoft.Properties.Resources.Cancel;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(78, 22);
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(377, 24);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(94, 16);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID del Local:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(337, 52);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(134, 16);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre del Local:";
            // 
            // gbDatosGenerales
            // 
            this.gbDatosGenerales.Controls.Add(this.cbVestibulo);
            this.gbDatosGenerales.Controls.Add(this.cbProyector);
            this.gbDatosGenerales.Controls.Add(this.label1);
            this.gbDatosGenerales.Controls.Add(this.cbPalco);
            this.gbDatosGenerales.Controls.Add(this.btnDescargarPDF);
            this.gbDatosGenerales.Controls.Add(this.btnSubirPDF);
            this.gbDatosGenerales.Controls.Add(this.txtPlano);
            this.gbDatosGenerales.Controls.Add(this.lblPlano);
            this.gbDatosGenerales.Controls.Add(this.txtResenha);
            this.gbDatosGenerales.Controls.Add(this.lblResenha);
            this.gbDatosGenerales.Controls.Add(this.cboEstiloArquitectonico);
            this.gbDatosGenerales.Controls.Add(this.lblEstiloArquitectonico);
            this.gbDatosGenerales.Controls.Add(this.txtAforo);
            this.gbDatosGenerales.Controls.Add(this.lblAforo);
            this.gbDatosGenerales.Controls.Add(this.dtpFechaConstruccion);
            this.gbDatosGenerales.Controls.Add(this.lblFechaConstruccion);
            this.gbDatosGenerales.Controls.Add(this.txtDireccion);
            this.gbDatosGenerales.Controls.Add(this.lblDireccion);
            this.gbDatosGenerales.Controls.Add(this.btnSubirFoto);
            this.gbDatosGenerales.Controls.Add(this.txtID);
            this.gbDatosGenerales.Controls.Add(this.txtNombre);
            this.gbDatosGenerales.Controls.Add(this.lblNombre);
            this.gbDatosGenerales.Controls.Add(this.pbFoto);
            this.gbDatosGenerales.Controls.Add(this.lblID);
            this.gbDatosGenerales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosGenerales.Location = new System.Drawing.Point(12, 28);
            this.gbDatosGenerales.Name = "gbDatosGenerales";
            this.gbDatosGenerales.Size = new System.Drawing.Size(948, 368);
            this.gbDatosGenerales.TabIndex = 4;
            this.gbDatosGenerales.TabStop = false;
            this.gbDatosGenerales.Text = "Datos Generales del Local";
            this.gbDatosGenerales.Enter += new System.EventHandler(this.gbDatosGenerales_Enter);
            // 
            // cbVestibulo
            // 
            this.cbVestibulo.AutoSize = true;
            this.cbVestibulo.Location = new System.Drawing.Point(661, 192);
            this.cbVestibulo.Name = "cbVestibulo";
            this.cbVestibulo.Size = new System.Drawing.Size(91, 20);
            this.cbVestibulo.TabIndex = 8;
            this.cbVestibulo.Text = "Vestíbulo";
            this.cbVestibulo.UseVisualStyleBackColor = true;
            // 
            // cbProyector
            // 
            this.cbProyector.AutoSize = true;
            this.cbProyector.Location = new System.Drawing.Point(559, 192);
            this.cbProyector.Name = "cbProyector";
            this.cbProyector.Size = new System.Drawing.Size(93, 20);
            this.cbProyector.TabIndex = 7;
            this.cbProyector.Text = "Proyector";
            this.cbProyector.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Aspectos adicionales:";
            // 
            // cbPalco
            // 
            this.cbPalco.AutoSize = true;
            this.cbPalco.Location = new System.Drawing.Point(477, 192);
            this.cbPalco.Name = "cbPalco";
            this.cbPalco.Size = new System.Drawing.Size(66, 20);
            this.cbPalco.TabIndex = 6;
            this.cbPalco.Text = "Palco";
            this.cbPalco.UseVisualStyleBackColor = true;
            this.cbPalco.CheckedChanged += new System.EventHandler(this.cbPalco_CheckedChanged);
            // 
            // btnDescargarPDF
            // 
            this.btnDescargarPDF.Location = new System.Drawing.Point(823, 330);
            this.btnDescargarPDF.Name = "btnDescargarPDF";
            this.btnDescargarPDF.Size = new System.Drawing.Size(106, 23);
            this.btnDescargarPDF.TabIndex = 11;
            this.btnDescargarPDF.Text = "Descargar";
            this.btnDescargarPDF.UseVisualStyleBackColor = true;
            this.btnDescargarPDF.Click += new System.EventHandler(this.btnDescargarPDF_Click);
            // 
            // btnSubirPDF
            // 
            this.btnSubirPDF.Location = new System.Drawing.Point(729, 330);
            this.btnSubirPDF.Name = "btnSubirPDF";
            this.btnSubirPDF.Size = new System.Drawing.Size(88, 23);
            this.btnSubirPDF.TabIndex = 10;
            this.btnSubirPDF.Text = "Subir";
            this.btnSubirPDF.UseVisualStyleBackColor = true;
            this.btnSubirPDF.Click += new System.EventHandler(this.btnSubirPDF_Click);
            // 
            // txtPlano
            // 
            this.txtPlano.Location = new System.Drawing.Point(133, 331);
            this.txtPlano.Name = "txtPlano";
            this.txtPlano.ReadOnly = true;
            this.txtPlano.Size = new System.Drawing.Size(590, 22);
            this.txtPlano.TabIndex = 10;
            // 
            // lblPlano
            // 
            this.lblPlano.AutoSize = true;
            this.lblPlano.Location = new System.Drawing.Point(12, 334);
            this.lblPlano.Name = "lblPlano";
            this.lblPlano.Size = new System.Drawing.Size(115, 16);
            this.lblPlano.TabIndex = 17;
            this.lblPlano.Text = "Plano del local:";
            // 
            // txtResenha
            // 
            this.txtResenha.Location = new System.Drawing.Point(13, 232);
            this.txtResenha.Multiline = true;
            this.txtResenha.Name = "txtResenha";
            this.txtResenha.Size = new System.Drawing.Size(916, 87);
            this.txtResenha.TabIndex = 9;
            // 
            // lblResenha
            // 
            this.lblResenha.AutoSize = true;
            this.lblResenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResenha.Location = new System.Drawing.Point(10, 209);
            this.lblResenha.Name = "lblResenha";
            this.lblResenha.Size = new System.Drawing.Size(168, 16);
            this.lblResenha.TabIndex = 15;
            this.lblResenha.Text = "Breve reseña del local:";
            // 
            // cboEstiloArquitectonico
            // 
            this.cboEstiloArquitectonico.FormattingEnabled = true;
            this.cboEstiloArquitectonico.Location = new System.Drawing.Point(477, 162);
            this.cboEstiloArquitectonico.Name = "cboEstiloArquitectonico";
            this.cboEstiloArquitectonico.Size = new System.Drawing.Size(452, 24);
            this.cboEstiloArquitectonico.TabIndex = 5;
            // 
            // lblEstiloArquitectonico
            // 
            this.lblEstiloArquitectonico.AutoSize = true;
            this.lblEstiloArquitectonico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstiloArquitectonico.Location = new System.Drawing.Point(319, 166);
            this.lblEstiloArquitectonico.Name = "lblEstiloArquitectonico";
            this.lblEstiloArquitectonico.Size = new System.Drawing.Size(152, 16);
            this.lblEstiloArquitectonico.TabIndex = 13;
            this.lblEstiloArquitectonico.Text = "Estilo arquitectónico:";
            // 
            // txtAforo
            // 
            this.txtAforo.Location = new System.Drawing.Point(477, 134);
            this.txtAforo.Name = "txtAforo";
            this.txtAforo.Size = new System.Drawing.Size(107, 22);
            this.txtAforo.TabIndex = 4;
            // 
            // lblAforo
            // 
            this.lblAforo.AutoSize = true;
            this.lblAforo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAforo.Location = new System.Drawing.Point(423, 137);
            this.lblAforo.Name = "lblAforo";
            this.lblAforo.Size = new System.Drawing.Size(48, 16);
            this.lblAforo.TabIndex = 11;
            this.lblAforo.Text = "Aforo:";
            // 
            // dtpFechaConstruccion
            // 
            this.dtpFechaConstruccion.Location = new System.Drawing.Point(477, 106);
            this.dtpFechaConstruccion.Name = "dtpFechaConstruccion";
            this.dtpFechaConstruccion.Size = new System.Drawing.Size(365, 22);
            this.dtpFechaConstruccion.TabIndex = 3;
            // 
            // lblFechaConstruccion
            // 
            this.lblFechaConstruccion.AutoSize = true;
            this.lblFechaConstruccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaConstruccion.Location = new System.Drawing.Point(304, 109);
            this.lblFechaConstruccion.Name = "lblFechaConstruccion";
            this.lblFechaConstruccion.Size = new System.Drawing.Size(167, 16);
            this.lblFechaConstruccion.TabIndex = 9;
            this.lblFechaConstruccion.Text = "Fecha de construcción:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(477, 77);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(452, 22);
            this.txtDireccion.TabIndex = 2;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(394, 80);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(77, 16);
            this.lblDireccion.TabIndex = 7;
            this.lblDireccion.Text = "Dirección:";
            // 
            // btnSubirFoto
            // 
            this.btnSubirFoto.BackgroundImage = global::EventSoft.Properties.Resources.Upload;
            this.btnSubirFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubirFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubirFoto.Location = new System.Drawing.Point(241, 165);
            this.btnSubirFoto.Name = "btnSubirFoto";
            this.btnSubirFoto.Size = new System.Drawing.Size(40, 35);
            this.btnSubirFoto.TabIndex = 12;
            this.btnSubirFoto.UseVisualStyleBackColor = true;
            this.btnSubirFoto.Click += new System.EventHandler(this.btnSubirFoto_Click);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(477, 21);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(70, 22);
            this.txtID.TabIndex = 13;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(477, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(452, 22);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // pbFoto
            // 
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Location = new System.Drawing.Point(12, 24);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(269, 176);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 3;
            this.pbFoto.TabStop = false;
            // 
            // ofdFoto
            // 
            this.ofdFoto.FileName = "openFileDialog1";
            // 
            // ofdPlano
            // 
            this.ofdPlano.FileName = "openFileDialog1";
            // 
            // frmGestionLocales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 405);
            this.Controls.Add(this.gbDatosGenerales);
            this.Controls.Add(this.tsMenu);
            this.Name = "frmGestionLocales";
            this.Text = "Formulario de Gestión de Locales";
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.gbDatosGenerales.ResumeLayout(false);
            this.gbDatosGenerales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.GroupBox gbDatosGenerales;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnSubirFoto;
        private System.Windows.Forms.OpenFileDialog ofdFoto;
        private System.Windows.Forms.TextBox txtPlano;
        private System.Windows.Forms.Label lblPlano;
        private System.Windows.Forms.TextBox txtResenha;
        private System.Windows.Forms.Label lblResenha;
        private System.Windows.Forms.ComboBox cboEstiloArquitectonico;
        private System.Windows.Forms.Label lblEstiloArquitectonico;
        private System.Windows.Forms.TextBox txtAforo;
        private System.Windows.Forms.Label lblAforo;
        private System.Windows.Forms.DateTimePicker dtpFechaConstruccion;
        private System.Windows.Forms.Label lblFechaConstruccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Button btnDescargarPDF;
        private System.Windows.Forms.Button btnSubirPDF;
        private System.Windows.Forms.OpenFileDialog ofdPlano;
        private System.Windows.Forms.CheckBox cbPalco;
        private System.Windows.Forms.CheckBox cbVestibulo;
        private System.Windows.Forms.CheckBox cbProyector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog sfdPlano;
    }
}

