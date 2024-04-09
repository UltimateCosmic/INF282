using FlightSoftSolutionsController.DAO;
using FlightSoftSolutionsController.MySQL;
using FlightSoftSolutionsModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightSoftSolutions
{
    /* Coloque sus datos
        * -------------------------------------------------
        * Nombre Completo: Johan Carlo Amador Egoavil
        * Código PUCP: 20203350
        * Fecha de Modificación: 09/10/2023 
    */
    public partial class frmGestionAeropuertos : Form
    {
        private string _rutaFotoAeropuerto;
        private Estado _estado;
        private CiudadDAO _daoCiudad;
        private Operadora _operadora;
        private EmpresaComercial _empresaComercial;
        private BindingList<EmpresaComercial> _empresasComerciales;
        private Aeropuerto _aeropuerto;
        private AeropuertoDAO _daoAeropuerto;
        public frmGestionAeropuertos()
        {
            InitializeComponent();
            _estado = Estado.Inicial;
            _daoCiudad = new CiudadMySQL();
            _daoAeropuerto = new AeropuertoMySQL();
            cboCiudad.DataSource = _daoCiudad.listarTodas();
            cboCiudad.DisplayMember = "Nombre";
            cboCiudad.ValueMember = "IdCiudad";
            limpiarComponentes();
            establecerEstadoComponentes();
            dgvEmpresasComerciales.AutoGenerateColumns = false;
        }

        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdFoto.ShowDialog() == DialogResult.OK)
                {
                    _rutaFotoAeropuerto = ofdFoto.FileName;
                    pbFoto.Image = Image.FromFile(_rutaFotoAeropuerto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Inicial:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnSubirFoto.Enabled = false;
                    btnBuscarOperadora.Enabled = false;
                    btnBuscarEmpresaComercial.Enabled = false;
                    btnAgregarEmpresaComercial.Enabled = false;
                    btnEliminarEmpresaComercial.Enabled = false;
                    txtIDAeropuerto.Enabled = false;
                    txtIDAeropuerto.ReadOnly = true;
                    txtNombre.Enabled = false;
                    txtNombre.ReadOnly = false;
                    txtDireccion.Enabled = false;
                    txtDireccion.ReadOnly = false;
                    cboCiudad.Enabled = false;
                    dtpAnhoFundacion.Enabled = false;
                    txtCostoConstruccion.Enabled = false;
                    txtCostoConstruccion.ReadOnly = false;
                    rbNacional.Enabled = false;
                    rbInternacional.Enabled = false;
                    cbSalaVIP.Enabled = false;
                    cbWIFI.Enabled = false;
                    cbSistemaGestEquipaje.Enabled = false;
                    txtOperadoraAsignada.Enabled = false;
                    txtOperadoraAsignada.ReadOnly = true;
                    txtTipoEmpresa.Enabled = false;
                    txtTipoEmpresa.ReadOnly = true;
                    txtNombreEmpresa.Enabled = false;
                    txtNombreEmpresa.ReadOnly = true;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnSubirFoto.Enabled = true;
                    btnBuscarOperadora.Enabled = true;
                    btnBuscarEmpresaComercial.Enabled = true;
                    btnAgregarEmpresaComercial.Enabled = true;
                    btnEliminarEmpresaComercial.Enabled = true;
                    txtIDAeropuerto.Enabled = true;
                    txtIDAeropuerto.ReadOnly = true;
                    txtNombre.Enabled = true;
                    txtNombre.ReadOnly = false;
                    txtDireccion.Enabled = true;
                    txtDireccion.ReadOnly = false;
                    cboCiudad.Enabled = true;
                    dtpAnhoFundacion.Enabled = true;
                    txtCostoConstruccion.Enabled = true;
                    txtCostoConstruccion.ReadOnly = false;
                    rbNacional.Enabled = true;
                    rbInternacional.Enabled = true;
                    cbSalaVIP.Enabled = true;
                    cbWIFI.Enabled = true;
                    cbSistemaGestEquipaje.Enabled = true;
                    txtOperadoraAsignada.Enabled = true;
                    txtOperadoraAsignada.ReadOnly = true;
                    txtTipoEmpresa.Enabled = true;
                    txtTipoEmpresa.ReadOnly = true;
                    txtNombreEmpresa.Enabled = true;
                    txtNombreEmpresa.ReadOnly = true;
                    break;
                case Estado.Buscar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnSubirFoto.Enabled = false;
                    btnBuscarOperadora.Enabled = false;
                    btnBuscarEmpresaComercial.Enabled = false;
                    btnAgregarEmpresaComercial.Enabled = false;
                    btnEliminarEmpresaComercial.Enabled = false;
                    txtIDAeropuerto.Enabled = true;
                    txtIDAeropuerto.ReadOnly = true;
                    txtNombre.Enabled = true;
                    txtNombre.ReadOnly = true;
                    txtDireccion.Enabled = true;
                    txtDireccion.ReadOnly = true;
                    cboCiudad.Enabled = false;
                    dtpAnhoFundacion.Enabled = false;
                    txtCostoConstruccion.Enabled = true;
                    txtCostoConstruccion.ReadOnly = true;
                    rbNacional.Enabled = false;
                    rbInternacional.Enabled = false;
                    cbSalaVIP.Enabled = false;
                    cbWIFI.Enabled = false;
                    cbSistemaGestEquipaje.Enabled = false;
                    txtOperadoraAsignada.Enabled = true;
                    txtOperadoraAsignada.ReadOnly = true;
                    txtTipoEmpresa.Enabled = false;
                    txtNombreEmpresa.Enabled = false;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            txtIDAeropuerto.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            cboCiudad.SelectedIndex = -1;
            dtpAnhoFundacion.Value = DateTime.Now;
            txtCostoConstruccion.Text = "";
            rbNacional.Checked = false;
            rbInternacional.Checked = false;
            cbSalaVIP.Checked = false;
            cbWIFI.Checked = false;
            cbSistemaGestEquipaje.Checked = false;
            txtOperadoraAsignada.Text = "";
            pbFoto.Image = null;
            txtTipoEmpresa.Text = "";
            txtNombreEmpresa.Text = "";
            dgvEmpresasComerciales.DataSource = null;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            limpiarComponentes();
            establecerEstadoComponentes();
            _empresasComerciales = new BindingList<EmpresaComercial>();
            dgvEmpresasComerciales.DataSource = _empresasComerciales;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Inicial;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void btnBuscarOperadora_Click(object sender, EventArgs e)
        {
            frmBusquedaOperadoras formBusqOp = new frmBusquedaOperadoras();
            if (formBusqOp.ShowDialog() == DialogResult.OK)
            {
                _operadora = formBusqOp.OperadoraSeleccionada;
                txtOperadoraAsignada.Text = _operadora.Nombre;
                establecerEstadoComponentes();
            }
        }

        private void btnBuscarEmpresaComercial_Click(object sender, EventArgs e)
        {
            frmBusquedaEmpresasComerciales formBusqEC = new frmBusquedaEmpresasComerciales();
            if (formBusqEC.ShowDialog() == DialogResult.OK)
            {
                _empresaComercial = new EmpresaComercial();
                _empresaComercial = formBusqEC.EmpresaComercialSeleccionada;
                if (typeof(Aerolinea).IsInstanceOfType(_empresaComercial))
                {
                    txtTipoEmpresa.Text = "Aerolinea";
                }
                else if (typeof(TiendaRetail).IsInstanceOfType(_empresaComercial))
                {
                    txtTipoEmpresa.Text = "Tienda Retail";
                }
                txtNombreEmpresa.Text = _empresaComercial.Nombre;
            }
        }

        private void btnAgregarEmpresaComercial_Click(object sender, EventArgs e)
        {
            if (_empresaComercial==null)
            {
                MessageBox.Show("Debe seleccionar una empresa comercial", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _empresasComerciales.Add(_empresaComercial);
            _empresaComercial = null;
            txtTipoEmpresa.Text = "";
            txtNombreEmpresa.Text = "";
        }

        private void btnEliminarEmpresaComercial_Click(object sender, EventArgs e)
        {
            if (dgvEmpresasComerciales.CurrentRow != null)
            {
                EmpresaComercial empresaComercial = (EmpresaComercial)dgvEmpresasComerciales.CurrentRow.DataBoundItem;
                _empresasComerciales.Remove(empresaComercial);
            }
            else
            {
                MessageBox.Show("Debe seleccionar una empresa comercial", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void dgvEmpresasComerciales_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            EmpresaComercial empresaComercial = (EmpresaComercial)dgvEmpresasComerciales.Rows[e.RowIndex].DataBoundItem;
            if (typeof(Aerolinea).IsInstanceOfType(empresaComercial))
            {
                dgvEmpresasComerciales.Rows[e.RowIndex].Cells[0].Value = "Aerolinea";
                dgvEmpresasComerciales.Rows[e.RowIndex].Cells[3].Value = ((Aerolinea)empresaComercial).NumeroAviones;
            }
            else if (typeof(TiendaRetail).IsInstanceOfType(empresaComercial))
            {
                dgvEmpresasComerciales.Rows[e.RowIndex].Cells[0].Value = "Tienda Retail";
                dgvEmpresasComerciales.Rows[e.RowIndex].Cells[3].Value = ((TiendaRetail)empresaComercial).CantidadEmpleados;
            }
            dgvEmpresasComerciales.Rows[e.RowIndex].Cells[1].Value = empresaComercial.Callsign;
            dgvEmpresasComerciales.Rows[e.RowIndex].Cells[2].Value = empresaComercial.Nombre;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _aeropuerto = new Aeropuerto();
            _aeropuerto.Nombre = txtNombre.Text;
            _aeropuerto.Direccion = txtDireccion.Text;
            _aeropuerto.Ciudad = new Ciudad();
            _aeropuerto.Ciudad = (Ciudad)cboCiudad.SelectedItem;
            _aeropuerto.AnhoFundacion = dtpAnhoFundacion.Value.Year;
            _aeropuerto.CostoConstruccion = Double.Parse(txtCostoConstruccion.Text);
            if (rbInternacional.Checked)
                _aeropuerto.TipoAeropuerto = TipoAeropuerto.Internacional;
            else if (rbNacional.Checked)
                _aeropuerto.TipoAeropuerto = TipoAeropuerto.Nacional;
            if (cbSalaVIP.Checked)
                _aeropuerto.TieneSalaVIP = true;
            else
                _aeropuerto.TieneSalaVIP = false;
            if (cbWIFI.Checked)
                _aeropuerto.TieneWiFi = true;
            else
                _aeropuerto.TieneWiFi = false;
            if (cbSistemaGestEquipaje.Checked)
                _aeropuerto.TieneSistemaGestionEquipaje = true;
            else
                _aeropuerto.TieneSistemaGestionEquipaje = false;
            _aeropuerto.Operadora = _operadora;
            FileStream fs = new FileStream(_rutaFotoAeropuerto, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            _aeropuerto.Foto = br.ReadBytes((int)fs.Length);
            fs.Close();
            if (_estado == Estado.Nuevo)
            {
                _aeropuerto.EmpresasComerciales = new BindingList<EmpresaComercial>();
                foreach (EmpresaComercial ec in _empresasComerciales)
                {
                    _aeropuerto.EmpresasComerciales.Add(ec);
                }
                int resultado = _daoAeropuerto.insertar(_aeropuerto);
                if (resultado != 0)
                {
                    txtIDAeropuerto.Text = _aeropuerto.IdAeropuerto.ToString();
                    MessageBox.Show("Se ha guardado el aeropuerto de forma exitosa", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    establecerEstadoComponentes();
                }
                else
                    MessageBox.Show("Hubo un error en el registro", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Buscar;
            frmBusquedaAeropuertos formBusqAeropuertos = new frmBusquedaAeropuertos();
            if (formBusqAeropuertos.ShowDialog() == DialogResult.OK)
            {
                _aeropuerto = new Aeropuerto();
                _aeropuerto.EmpresasComerciales = new BindingList<EmpresaComercial>();
                _aeropuerto = formBusqAeropuertos.AeropuertoSeleccionado;
                dgvEmpresasComerciales.DataSource = _aeropuerto.EmpresasComerciales;
                _aeropuerto.EmpresasComerciales = formBusqAeropuertos.AeropuertoSeleccionado.EmpresasComerciales;
                txtIDAeropuerto.Text = _aeropuerto.IdAeropuerto.ToString();
                txtNombre.Text = _aeropuerto.Nombre;
                txtDireccion.Text = _aeropuerto.Direccion;
                cboCiudad.SelectedValue = _aeropuerto.Ciudad.IdCiudad;
                dtpAnhoFundacion.Value = DateTime.ParseExact(_aeropuerto.AnhoFundacion.ToString(), "yyyy", null);
                if (_aeropuerto.TipoAeropuerto == TipoAeropuerto.Internacional)
                    rbInternacional.Checked = true;
                else if (_aeropuerto.TipoAeropuerto == TipoAeropuerto.Nacional)
                    rbNacional.Checked = true;
                txtCostoConstruccion.Text = _aeropuerto.CostoConstruccion.ToString();
                if (_aeropuerto.TieneSalaVIP)
                    cbSalaVIP.Checked = true;
                if (_aeropuerto.TieneWiFi)
                    cbWIFI.Checked = true;
                if (_aeropuerto.TieneSistemaGestionEquipaje)
                    cbSistemaGestEquipaje.Checked = true;
                txtOperadoraAsignada.Text = _aeropuerto.Operadora.Nombre;
                MemoryStream ms = new MemoryStream(_aeropuerto.Foto);
                pbFoto.Image = new Bitmap(ms);
                dgvEmpresasComerciales.DataSource = formBusqAeropuertos.AeropuertoSeleccionado.EmpresasComerciales;
                establecerEstadoComponentes();
            }
        }
    }
}
