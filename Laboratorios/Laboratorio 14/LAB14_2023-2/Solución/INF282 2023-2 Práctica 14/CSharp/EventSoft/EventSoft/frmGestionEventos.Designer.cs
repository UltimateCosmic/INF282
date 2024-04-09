namespace EventSoft
{
    partial class frmGestionEventos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionEventos));
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.lblGestionEventos = new System.Windows.Forms.Label();
            this.gbDatosGenerales = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtCantEntradasDisp = new System.Windows.Forms.TextBox();
            this.lblCantEntradasDisp = new System.Windows.Forms.Label();
            this.btnBuscarArtista = new System.Windows.Forms.Button();
            this.txtArtista = new System.Windows.Forms.TextBox();
            this.lblArtista = new System.Windows.Forms.Label();
            this.txtCostoRealizacion = new System.Windows.Forms.TextBox();
            this.lblCostoRealizacion = new System.Windows.Forms.Label();
            this.dtpHoraEvento = new System.Windows.Forms.DateTimePicker();
            this.lblHoraEvento = new System.Windows.Forms.Label();
            this.lblFechaEvento = new System.Windows.Forms.Label();
            this.dtpFechaEvento = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarEstablecimiento = new System.Windows.Forms.Button();
            this.txtEstablecimiento = new System.Windows.Forms.TextBox();
            this.lblEstablecimiento = new System.Windows.Forms.Label();
            this.rbTeatro = new System.Windows.Forms.RadioButton();
            this.rbConcierto = new System.Windows.Forms.RadioButton();
            this.lblTipoEvento = new System.Windows.Forms.Label();
            this.btnSubirFoto = new System.Windows.Forms.Button();
            this.txtNombreEvento = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblIDEvento = new System.Windows.Forms.Label();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.txtIDEvento = new System.Windows.Forms.TextBox();
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            this.tsMenu.SuspendLayout();
            this.gbDatosGenerales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
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
            this.tsMenu.Size = new System.Drawing.Size(1075, 25);
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
            this.btnBuscar.Image = global::EventSoft.Properties.Resources.Search;
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(66, 22);
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::EventSoft.Properties.Resources.Cancel;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(78, 22);
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblGestionEventos
            // 
            this.lblGestionEventos.AutoSize = true;
            this.lblGestionEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionEventos.Location = new System.Drawing.Point(12, 29);
            this.lblGestionEventos.Name = "lblGestionEventos";
            this.lblGestionEventos.Size = new System.Drawing.Size(142, 16);
            this.lblGestionEventos.TabIndex = 1;
            this.lblGestionEventos.Text = "Gestión de Eventos";
            // 
            // gbDatosGenerales
            // 
            this.gbDatosGenerales.Controls.Add(this.txtDescripcion);
            this.gbDatosGenerales.Controls.Add(this.lblDescripcion);
            this.gbDatosGenerales.Controls.Add(this.txtCantEntradasDisp);
            this.gbDatosGenerales.Controls.Add(this.lblCantEntradasDisp);
            this.gbDatosGenerales.Controls.Add(this.btnBuscarArtista);
            this.gbDatosGenerales.Controls.Add(this.txtArtista);
            this.gbDatosGenerales.Controls.Add(this.lblArtista);
            this.gbDatosGenerales.Controls.Add(this.txtCostoRealizacion);
            this.gbDatosGenerales.Controls.Add(this.lblCostoRealizacion);
            this.gbDatosGenerales.Controls.Add(this.dtpHoraEvento);
            this.gbDatosGenerales.Controls.Add(this.lblHoraEvento);
            this.gbDatosGenerales.Controls.Add(this.lblFechaEvento);
            this.gbDatosGenerales.Controls.Add(this.dtpFechaEvento);
            this.gbDatosGenerales.Controls.Add(this.btnBuscarEstablecimiento);
            this.gbDatosGenerales.Controls.Add(this.txtEstablecimiento);
            this.gbDatosGenerales.Controls.Add(this.lblEstablecimiento);
            this.gbDatosGenerales.Controls.Add(this.rbTeatro);
            this.gbDatosGenerales.Controls.Add(this.rbConcierto);
            this.gbDatosGenerales.Controls.Add(this.lblTipoEvento);
            this.gbDatosGenerales.Controls.Add(this.btnSubirFoto);
            this.gbDatosGenerales.Controls.Add(this.txtNombreEvento);
            this.gbDatosGenerales.Controls.Add(this.lblNombre);
            this.gbDatosGenerales.Controls.Add(this.lblIDEvento);
            this.gbDatosGenerales.Controls.Add(this.pbFoto);
            this.gbDatosGenerales.Controls.Add(this.txtIDEvento);
            this.gbDatosGenerales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosGenerales.Location = new System.Drawing.Point(15, 51);
            this.gbDatosGenerales.Name = "gbDatosGenerales";
            this.gbDatosGenerales.Size = new System.Drawing.Size(1048, 367);
            this.gbDatosGenerales.TabIndex = 2;
            this.gbDatosGenerales.TabStop = false;
            this.gbDatosGenerales.Text = "Datos Generales";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(15, 268);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(1027, 89);
            this.txtDescripcion.TabIndex = 24;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(12, 249);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(172, 16);
            this.lblDescripcion.TabIndex = 23;
            this.lblDescripcion.Text = "Descripción del Evento:";
            // 
            // txtCantEntradasDisp
            // 
            this.txtCantEntradasDisp.Location = new System.Drawing.Point(621, 212);
            this.txtCantEntradasDisp.Name = "txtCantEntradasDisp";
            this.txtCantEntradasDisp.Size = new System.Drawing.Size(136, 22);
            this.txtCantEntradasDisp.TabIndex = 22;
            // 
            // lblCantEntradasDisp
            // 
            this.lblCantEntradasDisp.AutoSize = true;
            this.lblCantEntradasDisp.Location = new System.Drawing.Point(367, 215);
            this.lblCantEntradasDisp.Name = "lblCantEntradasDisp";
            this.lblCantEntradasDisp.Size = new System.Drawing.Size(248, 16);
            this.lblCantEntradasDisp.TabIndex = 21;
            this.lblCantEntradasDisp.Text = "Cantidad de Entradas Disponibles:";
            // 
            // btnBuscarArtista
            // 
            this.btnBuscarArtista.BackgroundImage = global::EventSoft.Properties.Resources.Search;
            this.btnBuscarArtista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarArtista.Location = new System.Drawing.Point(1010, 98);
            this.btnBuscarArtista.Name = "btnBuscarArtista";
            this.btnBuscarArtista.Size = new System.Drawing.Size(32, 24);
            this.btnBuscarArtista.TabIndex = 20;
            this.btnBuscarArtista.UseVisualStyleBackColor = true;
            this.btnBuscarArtista.Click += new System.EventHandler(this.btnBuscarArtista_Click);
            // 
            // txtArtista
            // 
            this.txtArtista.Location = new System.Drawing.Point(512, 99);
            this.txtArtista.Name = "txtArtista";
            this.txtArtista.ReadOnly = true;
            this.txtArtista.Size = new System.Drawing.Size(496, 22);
            this.txtArtista.TabIndex = 19;
            // 
            // lblArtista
            // 
            this.lblArtista.AutoSize = true;
            this.lblArtista.Location = new System.Drawing.Point(451, 102);
            this.lblArtista.Name = "lblArtista";
            this.lblArtista.Size = new System.Drawing.Size(55, 16);
            this.lblArtista.TabIndex = 18;
            this.lblArtista.Text = "Artista:";
            // 
            // txtCostoRealizacion
            // 
            this.txtCostoRealizacion.Location = new System.Drawing.Point(846, 182);
            this.txtCostoRealizacion.Name = "txtCostoRealizacion";
            this.txtCostoRealizacion.Size = new System.Drawing.Size(196, 22);
            this.txtCostoRealizacion.TabIndex = 17;
            // 
            // lblCostoRealizacion
            // 
            this.lblCostoRealizacion.AutoSize = true;
            this.lblCostoRealizacion.Location = new System.Drawing.Point(648, 185);
            this.lblCostoRealizacion.Name = "lblCostoRealizacion";
            this.lblCostoRealizacion.Size = new System.Drawing.Size(192, 16);
            this.lblCostoRealizacion.TabIndex = 16;
            this.lblCostoRealizacion.Text = "Costo de Realización (S/.):";
            // 
            // dtpHoraEvento
            // 
            this.dtpHoraEvento.CustomFormat = "HH:mm";
            this.dtpHoraEvento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraEvento.Location = new System.Drawing.Point(512, 182);
            this.dtpHoraEvento.Name = "dtpHoraEvento";
            this.dtpHoraEvento.ShowUpDown = true;
            this.dtpHoraEvento.Size = new System.Drawing.Size(114, 22);
            this.dtpHoraEvento.TabIndex = 15;
            // 
            // lblHoraEvento
            // 
            this.lblHoraEvento.AutoSize = true;
            this.lblHoraEvento.Location = new System.Drawing.Point(383, 185);
            this.lblHoraEvento.Name = "lblHoraEvento";
            this.lblHoraEvento.Size = new System.Drawing.Size(123, 16);
            this.lblHoraEvento.TabIndex = 14;
            this.lblHoraEvento.Text = "Hora del Evento:";
            // 
            // lblFechaEvento
            // 
            this.lblFechaEvento.AutoSize = true;
            this.lblFechaEvento.Location = new System.Drawing.Point(374, 157);
            this.lblFechaEvento.Name = "lblFechaEvento";
            this.lblFechaEvento.Size = new System.Drawing.Size(132, 16);
            this.lblFechaEvento.TabIndex = 13;
            this.lblFechaEvento.Text = "Fecha del Evento:";
            // 
            // dtpFechaEvento
            // 
            this.dtpFechaEvento.Location = new System.Drawing.Point(512, 154);
            this.dtpFechaEvento.Name = "dtpFechaEvento";
            this.dtpFechaEvento.Size = new System.Drawing.Size(530, 22);
            this.dtpFechaEvento.TabIndex = 12;
            // 
            // btnBuscarEstablecimiento
            // 
            this.btnBuscarEstablecimiento.BackgroundImage = global::EventSoft.Properties.Resources.Search;
            this.btnBuscarEstablecimiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarEstablecimiento.Location = new System.Drawing.Point(1010, 125);
            this.btnBuscarEstablecimiento.Name = "btnBuscarEstablecimiento";
            this.btnBuscarEstablecimiento.Size = new System.Drawing.Size(32, 24);
            this.btnBuscarEstablecimiento.TabIndex = 11;
            this.btnBuscarEstablecimiento.UseVisualStyleBackColor = true;
            this.btnBuscarEstablecimiento.Click += new System.EventHandler(this.btnBuscarEstablecimiento_Click);
            // 
            // txtEstablecimiento
            // 
            this.txtEstablecimiento.Location = new System.Drawing.Point(512, 126);
            this.txtEstablecimiento.Name = "txtEstablecimiento";
            this.txtEstablecimiento.ReadOnly = true;
            this.txtEstablecimiento.Size = new System.Drawing.Size(496, 22);
            this.txtEstablecimiento.TabIndex = 10;
            // 
            // lblEstablecimiento
            // 
            this.lblEstablecimiento.AutoSize = true;
            this.lblEstablecimiento.Location = new System.Drawing.Point(384, 129);
            this.lblEstablecimiento.Name = "lblEstablecimiento";
            this.lblEstablecimiento.Size = new System.Drawing.Size(122, 16);
            this.lblEstablecimiento.TabIndex = 9;
            this.lblEstablecimiento.Text = "Establecimiento:";
            // 
            // rbTeatro
            // 
            this.rbTeatro.AutoSize = true;
            this.rbTeatro.Location = new System.Drawing.Point(621, 77);
            this.rbTeatro.Name = "rbTeatro";
            this.rbTeatro.Size = new System.Drawing.Size(71, 20);
            this.rbTeatro.TabIndex = 8;
            this.rbTeatro.TabStop = true;
            this.rbTeatro.Text = "Teatro";
            this.rbTeatro.UseVisualStyleBackColor = true;
            // 
            // rbConcierto
            // 
            this.rbConcierto.AutoSize = true;
            this.rbConcierto.Location = new System.Drawing.Point(515, 77);
            this.rbConcierto.Name = "rbConcierto";
            this.rbConcierto.Size = new System.Drawing.Size(91, 20);
            this.rbConcierto.TabIndex = 7;
            this.rbConcierto.TabStop = true;
            this.rbConcierto.Text = "Concierto";
            this.rbConcierto.UseVisualStyleBackColor = true;
            // 
            // lblTipoEvento
            // 
            this.lblTipoEvento.AutoSize = true;
            this.lblTipoEvento.Location = new System.Drawing.Point(389, 79);
            this.lblTipoEvento.Name = "lblTipoEvento";
            this.lblTipoEvento.Size = new System.Drawing.Size(117, 16);
            this.lblTipoEvento.TabIndex = 6;
            this.lblTipoEvento.Text = "Tipo de Evento:";
            // 
            // btnSubirFoto
            // 
            this.btnSubirFoto.BackgroundImage = global::EventSoft.Properties.Resources.Upload;
            this.btnSubirFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubirFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubirFoto.Location = new System.Drawing.Point(306, 199);
            this.btnSubirFoto.Name = "btnSubirFoto";
            this.btnSubirFoto.Size = new System.Drawing.Size(50, 35);
            this.btnSubirFoto.TabIndex = 5;
            this.btnSubirFoto.UseVisualStyleBackColor = true;
            this.btnSubirFoto.Click += new System.EventHandler(this.btnSubirFoto_Click);
            // 
            // txtNombreEvento
            // 
            this.txtNombreEvento.Location = new System.Drawing.Point(512, 52);
            this.txtNombreEvento.Name = "txtNombreEvento";
            this.txtNombreEvento.Size = new System.Drawing.Size(530, 22);
            this.txtNombreEvento.TabIndex = 4;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(362, 55);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(144, 16);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre del Evento:";
            // 
            // lblIDEvento
            // 
            this.lblIDEvento.AutoSize = true;
            this.lblIDEvento.Location = new System.Drawing.Point(402, 29);
            this.lblIDEvento.Name = "lblIDEvento";
            this.lblIDEvento.Size = new System.Drawing.Size(104, 16);
            this.lblIDEvento.TabIndex = 2;
            this.lblIDEvento.Text = "ID del Evento:";
            // 
            // pbFoto
            // 
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Location = new System.Drawing.Point(15, 25);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(341, 209);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 1;
            this.pbFoto.TabStop = false;
            // 
            // txtIDEvento
            // 
            this.txtIDEvento.Location = new System.Drawing.Point(512, 26);
            this.txtIDEvento.Name = "txtIDEvento";
            this.txtIDEvento.ReadOnly = true;
            this.txtIDEvento.Size = new System.Drawing.Size(79, 22);
            this.txtIDEvento.TabIndex = 0;
            this.txtIDEvento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ofdFoto
            // 
            this.ofdFoto.FileName = "ofdFoto";
            // 
            // frmGestionEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1075, 426);
            this.Controls.Add(this.gbDatosGenerales);
            this.Controls.Add(this.lblGestionEventos);
            this.Controls.Add(this.tsMenu);
            this.DoubleBuffered = true;
            this.Name = "frmGestionEventos";
            this.Text = "Formulario de Gestión de Eventos";
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
        private System.Windows.Forms.Label lblGestionEventos;
        private System.Windows.Forms.GroupBox gbDatosGenerales;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.TextBox txtIDEvento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblIDEvento;
        private System.Windows.Forms.Button btnSubirFoto;
        private System.Windows.Forms.TextBox txtNombreEvento;
        private System.Windows.Forms.RadioButton rbTeatro;
        private System.Windows.Forms.RadioButton rbConcierto;
        private System.Windows.Forms.Label lblTipoEvento;
        private System.Windows.Forms.Button btnBuscarEstablecimiento;
        private System.Windows.Forms.TextBox txtEstablecimiento;
        private System.Windows.Forms.Label lblEstablecimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaEvento;
        private System.Windows.Forms.Label lblFechaEvento;
        private System.Windows.Forms.TextBox txtCostoRealizacion;
        private System.Windows.Forms.Label lblCostoRealizacion;
        private System.Windows.Forms.DateTimePicker dtpHoraEvento;
        private System.Windows.Forms.Label lblHoraEvento;
        private System.Windows.Forms.TextBox txtCantEntradasDisp;
        private System.Windows.Forms.Label lblCantEntradasDisp;
        private System.Windows.Forms.Button btnBuscarArtista;
        private System.Windows.Forms.TextBox txtArtista;
        private System.Windows.Forms.Label lblArtista;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.OpenFileDialog ofdFoto;
    }
}