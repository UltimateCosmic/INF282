namespace SmashSoft
{
    partial class frmGestionPersonajes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionPersonajes));
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.gbDatosPersonaje = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPlataformaOrigen = new System.Windows.Forms.Label();
            this.cboPlataformaOrigen = new System.Windows.Forms.ComboBox();
            this.dtpFechaAparicion = new System.Windows.Forms.DateTimePicker();
            this.lblFechaAparicion = new System.Windows.Forms.Label();
            this.btnBuscarUniverso = new System.Windows.Forms.Button();
            this.txtUniverso = new System.Windows.Forms.TextBox();
            this.lblUniverso = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtIDPersonaje = new System.Windows.Forms.TextBox();
            this.lblIDPersonaje = new System.Windows.Forms.Label();
            this.btnSubirFoto = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            this.lblVelocidadCaminar = new System.Windows.Forms.Label();
            this.txtVelocidadCaminar = new System.Windows.Forms.TextBox();
            this.lblVelocidadCorrer = new System.Windows.Forms.Label();
            this.lblCantMaxSaltos = new System.Windows.Forms.Label();
            this.nudCantMaxSaltos = new System.Windows.Forms.NumericUpDown();
            this.txtVelocidadCorrer = new System.Windows.Forms.TextBox();
            this.gbAtributosPersonaje = new System.Windows.Forms.GroupBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.cbArrastre = new System.Windows.Forms.CheckBox();
            this.cbAdhesionParedes = new System.Windows.Forms.CheckBox();
            this.cbSaltoPared = new System.Windows.Forms.CheckBox();
            this.lblDatosTecnicosAdicionales = new System.Windows.Forms.Label();
            this.tsMenu.SuspendLayout();
            this.gbDatosPersonaje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantMaxSaltos)).BeginInit();
            this.gbAtributosPersonaje.SuspendLayout();
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
            this.tsMenu.Size = new System.Drawing.Size(1002, 25);
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
            this.btnBuscar.Image = global::SmashSoft.Properties.Resources.Search;
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(66, 22);
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::SmashSoft.Properties.Resources.Cancel;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(78, 22);
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gbDatosPersonaje
            // 
            this.gbDatosPersonaje.Controls.Add(this.txtDescripcion);
            this.gbDatosPersonaje.Controls.Add(this.lblDescripcion);
            this.gbDatosPersonaje.Controls.Add(this.lblPlataformaOrigen);
            this.gbDatosPersonaje.Controls.Add(this.cboPlataformaOrigen);
            this.gbDatosPersonaje.Controls.Add(this.dtpFechaAparicion);
            this.gbDatosPersonaje.Controls.Add(this.lblFechaAparicion);
            this.gbDatosPersonaje.Controls.Add(this.btnBuscarUniverso);
            this.gbDatosPersonaje.Controls.Add(this.txtUniverso);
            this.gbDatosPersonaje.Controls.Add(this.lblUniverso);
            this.gbDatosPersonaje.Controls.Add(this.txtNombre);
            this.gbDatosPersonaje.Controls.Add(this.lblNombre);
            this.gbDatosPersonaje.Controls.Add(this.txtIDPersonaje);
            this.gbDatosPersonaje.Controls.Add(this.lblIDPersonaje);
            this.gbDatosPersonaje.Controls.Add(this.btnSubirFoto);
            this.gbDatosPersonaje.Controls.Add(this.pbFoto);
            this.gbDatosPersonaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosPersonaje.Location = new System.Drawing.Point(12, 28);
            this.gbDatosPersonaje.Name = "gbDatosPersonaje";
            this.gbDatosPersonaje.Size = new System.Drawing.Size(977, 284);
            this.gbDatosPersonaje.TabIndex = 1;
            this.gbDatosPersonaje.TabStop = false;
            this.gbDatosPersonaje.Text = "Datos del Personaje";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(512, 184);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(446, 88);
            this.txtDescripcion.TabIndex = 14;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(409, 182);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(94, 16);
            this.lblDescripcion.TabIndex = 13;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblPlataformaOrigen
            // 
            this.lblPlataformaOrigen.AutoSize = true;
            this.lblPlataformaOrigen.Location = new System.Drawing.Point(345, 152);
            this.lblPlataformaOrigen.Name = "lblPlataformaOrigen";
            this.lblPlataformaOrigen.Size = new System.Drawing.Size(158, 16);
            this.lblPlataformaOrigen.TabIndex = 12;
            this.lblPlataformaOrigen.Text = "Plataforma de Origen:";
            // 
            // cboPlataformaOrigen
            // 
            this.cboPlataformaOrigen.FormattingEnabled = true;
            this.cboPlataformaOrigen.Location = new System.Drawing.Point(512, 149);
            this.cboPlataformaOrigen.Name = "cboPlataformaOrigen";
            this.cboPlataformaOrigen.Size = new System.Drawing.Size(446, 24);
            this.cboPlataformaOrigen.TabIndex = 11;
            // 
            // dtpFechaAparicion
            // 
            this.dtpFechaAparicion.Location = new System.Drawing.Point(512, 118);
            this.dtpFechaAparicion.Name = "dtpFechaAparicion";
            this.dtpFechaAparicion.Size = new System.Drawing.Size(446, 22);
            this.dtpFechaAparicion.TabIndex = 10;
            // 
            // lblFechaAparicion
            // 
            this.lblFechaAparicion.AutoSize = true;
            this.lblFechaAparicion.Location = new System.Drawing.Point(357, 121);
            this.lblFechaAparicion.Name = "lblFechaAparicion";
            this.lblFechaAparicion.Size = new System.Drawing.Size(146, 16);
            this.lblFechaAparicion.TabIndex = 9;
            this.lblFechaAparicion.Text = "Fecha de Aparición:";
            // 
            // btnBuscarUniverso
            // 
            this.btnBuscarUniverso.BackgroundImage = global::SmashSoft.Properties.Resources.Search;
            this.btnBuscarUniverso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarUniverso.Location = new System.Drawing.Point(927, 87);
            this.btnBuscarUniverso.Name = "btnBuscarUniverso";
            this.btnBuscarUniverso.Size = new System.Drawing.Size(31, 24);
            this.btnBuscarUniverso.TabIndex = 8;
            this.btnBuscarUniverso.UseVisualStyleBackColor = true;
            this.btnBuscarUniverso.Click += new System.EventHandler(this.btnBuscarUniverso_Click);
            // 
            // txtUniverso
            // 
            this.txtUniverso.Location = new System.Drawing.Point(512, 88);
            this.txtUniverso.Name = "txtUniverso";
            this.txtUniverso.ReadOnly = true;
            this.txtUniverso.Size = new System.Drawing.Size(414, 22);
            this.txtUniverso.TabIndex = 7;
            // 
            // lblUniverso
            // 
            this.lblUniverso.AutoSize = true;
            this.lblUniverso.Location = new System.Drawing.Point(339, 91);
            this.lblUniverso.Name = "lblUniverso";
            this.lblUniverso.Size = new System.Drawing.Size(165, 16);
            this.lblUniverso.TabIndex = 6;
            this.lblUniverso.Text = "Universo Procedencia:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(512, 56);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(446, 22);
            this.txtNombre.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(339, 59);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(167, 16);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre del Personaje:";
            // 
            // txtIDPersonaje
            // 
            this.txtIDPersonaje.Location = new System.Drawing.Point(512, 25);
            this.txtIDPersonaje.Name = "txtIDPersonaje";
            this.txtIDPersonaje.ReadOnly = true;
            this.txtIDPersonaje.Size = new System.Drawing.Size(100, 22);
            this.txtIDPersonaje.TabIndex = 3;
            this.txtIDPersonaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIDPersonaje
            // 
            this.lblIDPersonaje.AutoSize = true;
            this.lblIDPersonaje.Location = new System.Drawing.Point(379, 28);
            this.lblIDPersonaje.Name = "lblIDPersonaje";
            this.lblIDPersonaje.Size = new System.Drawing.Size(127, 16);
            this.lblIDPersonaje.TabIndex = 2;
            this.lblIDPersonaje.Text = "ID del Personaje:";
            // 
            // btnSubirFoto
            // 
            this.btnSubirFoto.BackgroundImage = global::SmashSoft.Properties.Resources.Upload;
            this.btnSubirFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubirFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubirFoto.Location = new System.Drawing.Point(278, 192);
            this.btnSubirFoto.Name = "btnSubirFoto";
            this.btnSubirFoto.Size = new System.Drawing.Size(43, 32);
            this.btnSubirFoto.TabIndex = 1;
            this.btnSubirFoto.UseVisualStyleBackColor = true;
            this.btnSubirFoto.Click += new System.EventHandler(this.btnSubirFoto_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Location = new System.Drawing.Point(16, 28);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(305, 196);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 0;
            this.pbFoto.TabStop = false;
            // 
            // ofdFoto
            // 
            this.ofdFoto.FileName = "ofdFoto";
            // 
            // lblVelocidadCaminar
            // 
            this.lblVelocidadCaminar.AutoSize = true;
            this.lblVelocidadCaminar.Location = new System.Drawing.Point(160, 29);
            this.lblVelocidadCaminar.Name = "lblVelocidadCaminar";
            this.lblVelocidadCaminar.Size = new System.Drawing.Size(160, 16);
            this.lblVelocidadCaminar.TabIndex = 13;
            this.lblVelocidadCaminar.Text = "Velocidad al Caminar:";
            // 
            // txtVelocidadCaminar
            // 
            this.txtVelocidadCaminar.Location = new System.Drawing.Point(322, 27);
            this.txtVelocidadCaminar.Name = "txtVelocidadCaminar";
            this.txtVelocidadCaminar.Size = new System.Drawing.Size(100, 22);
            this.txtVelocidadCaminar.TabIndex = 14;
            // 
            // lblVelocidadCorrer
            // 
            this.lblVelocidadCorrer.AutoSize = true;
            this.lblVelocidadCorrer.Location = new System.Drawing.Point(437, 30);
            this.lblVelocidadCorrer.Name = "lblVelocidadCorrer";
            this.lblVelocidadCorrer.Size = new System.Drawing.Size(146, 16);
            this.lblVelocidadCorrer.TabIndex = 15;
            this.lblVelocidadCorrer.Text = "Velocidad al Correr:";
            // 
            // lblCantMaxSaltos
            // 
            this.lblCantMaxSaltos.AutoSize = true;
            this.lblCantMaxSaltos.Location = new System.Drawing.Point(674, 29);
            this.lblCantMaxSaltos.Name = "lblCantMaxSaltos";
            this.lblCantMaxSaltos.Size = new System.Drawing.Size(200, 16);
            this.lblCantMaxSaltos.TabIndex = 16;
            this.lblCantMaxSaltos.Text = "Cantidad Máxima de Saltos:";
            // 
            // nudCantMaxSaltos
            // 
            this.nudCantMaxSaltos.Location = new System.Drawing.Point(877, 27);
            this.nudCantMaxSaltos.Name = "nudCantMaxSaltos";
            this.nudCantMaxSaltos.Size = new System.Drawing.Size(82, 22);
            this.nudCantMaxSaltos.TabIndex = 17;
            this.nudCantMaxSaltos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVelocidadCorrer
            // 
            this.txtVelocidadCorrer.Location = new System.Drawing.Point(584, 27);
            this.txtVelocidadCorrer.Name = "txtVelocidadCorrer";
            this.txtVelocidadCorrer.Size = new System.Drawing.Size(82, 22);
            this.txtVelocidadCorrer.TabIndex = 18;
            // 
            // gbAtributosPersonaje
            // 
            this.gbAtributosPersonaje.Controls.Add(this.txtPeso);
            this.gbAtributosPersonaje.Controls.Add(this.lblPeso);
            this.gbAtributosPersonaje.Controls.Add(this.cbArrastre);
            this.gbAtributosPersonaje.Controls.Add(this.cbAdhesionParedes);
            this.gbAtributosPersonaje.Controls.Add(this.cbSaltoPared);
            this.gbAtributosPersonaje.Controls.Add(this.lblDatosTecnicosAdicionales);
            this.gbAtributosPersonaje.Controls.Add(this.txtVelocidadCaminar);
            this.gbAtributosPersonaje.Controls.Add(this.txtVelocidadCorrer);
            this.gbAtributosPersonaje.Controls.Add(this.nudCantMaxSaltos);
            this.gbAtributosPersonaje.Controls.Add(this.lblCantMaxSaltos);
            this.gbAtributosPersonaje.Controls.Add(this.lblVelocidadCorrer);
            this.gbAtributosPersonaje.Controls.Add(this.lblVelocidadCaminar);
            this.gbAtributosPersonaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAtributosPersonaje.Location = new System.Drawing.Point(12, 315);
            this.gbAtributosPersonaje.Name = "gbAtributosPersonaje";
            this.gbAtributosPersonaje.Size = new System.Drawing.Size(977, 90);
            this.gbAtributosPersonaje.TabIndex = 19;
            this.gbAtributosPersonaje.TabStop = false;
            this.gbAtributosPersonaje.Text = "Atributos del Personaje";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(66, 27);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(76, 22);
            this.txtPeso.TabIndex = 24;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(13, 30);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(47, 16);
            this.lblPeso.TabIndex = 23;
            this.lblPeso.Text = "Peso:";
            // 
            // cbArrastre
            // 
            this.cbArrastre.AutoSize = true;
            this.cbArrastre.Location = new System.Drawing.Point(589, 60);
            this.cbArrastre.Name = "cbArrastre";
            this.cbArrastre.Size = new System.Drawing.Size(81, 20);
            this.cbArrastre.TabIndex = 22;
            this.cbArrastre.Text = "Arrastre";
            this.cbArrastre.UseVisualStyleBackColor = true;
            // 
            // cbAdhesionParedes
            // 
            this.cbAdhesionParedes.AutoSize = true;
            this.cbAdhesionParedes.Location = new System.Drawing.Point(398, 60);
            this.cbAdhesionParedes.Name = "cbAdhesionParedes";
            this.cbAdhesionParedes.Size = new System.Drawing.Size(166, 20);
            this.cbAdhesionParedes.TabIndex = 21;
            this.cbAdhesionParedes.Text = "Adhesión a paredes";
            this.cbAdhesionParedes.UseVisualStyleBackColor = true;
            // 
            // cbSaltoPared
            // 
            this.cbSaltoPared.AutoSize = true;
            this.cbSaltoPared.Location = new System.Drawing.Point(243, 60);
            this.cbSaltoPared.Name = "cbSaltoPared";
            this.cbSaltoPared.Size = new System.Drawing.Size(129, 20);
            this.cbSaltoPared.TabIndex = 20;
            this.cbSaltoPared.Text = "Salto de pared";
            this.cbSaltoPared.UseVisualStyleBackColor = true;
            // 
            // lblDatosTecnicosAdicionales
            // 
            this.lblDatosTecnicosAdicionales.AutoSize = true;
            this.lblDatosTecnicosAdicionales.Location = new System.Drawing.Point(13, 61);
            this.lblDatosTecnicosAdicionales.Name = "lblDatosTecnicosAdicionales";
            this.lblDatosTecnicosAdicionales.Size = new System.Drawing.Size(206, 16);
            this.lblDatosTecnicosAdicionales.TabIndex = 19;
            this.lblDatosTecnicosAdicionales.Text = "Datos Técnicos Adicionales:";
            // 
            // frmGestionPersonajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 416);
            this.Controls.Add(this.gbAtributosPersonaje);
            this.Controls.Add(this.gbDatosPersonaje);
            this.Controls.Add(this.tsMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmGestionPersonajes";
            this.Text = "Formulario de Gestión de Personajes SmashBros";
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.gbDatosPersonaje.ResumeLayout(false);
            this.gbDatosPersonaje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantMaxSaltos)).EndInit();
            this.gbAtributosPersonaje.ResumeLayout(false);
            this.gbAtributosPersonaje.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.GroupBox gbDatosPersonaje;
        private System.Windows.Forms.Button btnSubirFoto;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.OpenFileDialog ofdFoto;
        private System.Windows.Forms.Button btnBuscarUniverso;
        private System.Windows.Forms.TextBox txtUniverso;
        private System.Windows.Forms.Label lblUniverso;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtIDPersonaje;
        private System.Windows.Forms.Label lblIDPersonaje;
        private System.Windows.Forms.TextBox txtVelocidadCorrer;
        private System.Windows.Forms.NumericUpDown nudCantMaxSaltos;
        private System.Windows.Forms.Label lblCantMaxSaltos;
        private System.Windows.Forms.Label lblVelocidadCorrer;
        private System.Windows.Forms.TextBox txtVelocidadCaminar;
        private System.Windows.Forms.Label lblVelocidadCaminar;
        private System.Windows.Forms.Label lblPlataformaOrigen;
        private System.Windows.Forms.ComboBox cboPlataformaOrigen;
        private System.Windows.Forms.DateTimePicker dtpFechaAparicion;
        private System.Windows.Forms.Label lblFechaAparicion;
        private System.Windows.Forms.GroupBox gbAtributosPersonaje;
        private System.Windows.Forms.CheckBox cbArrastre;
        private System.Windows.Forms.CheckBox cbAdhesionParedes;
        private System.Windows.Forms.CheckBox cbSaltoPared;
        private System.Windows.Forms.Label lblDatosTecnicosAdicionales;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblPeso;
    }
}

