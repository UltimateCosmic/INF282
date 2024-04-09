namespace FlightSoftSolutions
{
    partial class frmBusquedaEmpresasComerciales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEmpresasComerciales = new System.Windows.Forms.DataGridView();
            this.TipoEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Callsign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumAvi_CantEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNombreCallsign = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresasComerciales)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmpresasComerciales
            // 
            this.dgvEmpresasComerciales.AllowUserToAddRows = false;
            this.dgvEmpresasComerciales.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpresasComerciales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmpresasComerciales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpresasComerciales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoEmpresa,
            this.Callsign,
            this.NombreEmpresa,
            this.NumAvi_CantEmp});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmpresasComerciales.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmpresasComerciales.Location = new System.Drawing.Point(14, 45);
            this.dgvEmpresasComerciales.Name = "dgvEmpresasComerciales";
            this.dgvEmpresasComerciales.ReadOnly = true;
            this.dgvEmpresasComerciales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpresasComerciales.Size = new System.Drawing.Size(944, 227);
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
            // lblNombreCallsign
            // 
            this.lblNombreCallsign.AutoSize = true;
            this.lblNombreCallsign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCallsign.Location = new System.Drawing.Point(14, 13);
            this.lblNombreCallsign.Name = "lblNombreCallsign";
            this.lblNombreCallsign.Size = new System.Drawing.Size(357, 15);
            this.lblNombreCallsign.TabIndex = 1;
            this.lblNombreCallsign.Text = "Ingrese el nombre o callsign de la empresa comercial:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(377, 10);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(290, 21);
            this.txtNombre.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(673, 9);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(98, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Location = new System.Drawing.Point(827, 9);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(131, 23);
            this.btnSeleccionar.TabIndex = 4;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // frmBusquedaEmpresasComerciales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 286);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombreCallsign);
            this.Controls.Add(this.dgvEmpresasComerciales);
            this.Name = "frmBusquedaEmpresasComerciales";
            this.Text = "Formulario de Búsqueda de Empresas Comerciales";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresasComerciales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpresasComerciales;
        private System.Windows.Forms.Label lblNombreCallsign;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Callsign;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumAvi_CantEmp;
    }
}