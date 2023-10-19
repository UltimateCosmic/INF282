using SmashSoft.ServicioWS;
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

namespace SmashSoft
{
    /* Coloque sus datos
        * -------------------------------------------------
        * Nombre Completo: Johan Amador
        * Código PUCP: 20203350
        * Fecha de Modificación: 19/10/23
    */
    public partial class frmGestionPersonajes : Form
    {
        private Estado _estado;
        private string _rutaFotoLocal;
        private ServicioWSClient _daoServicioWS;
        private universo _universo;
        private personaje _personaje;
        public frmGestionPersonajes()
        {
            InitializeComponent();
            _estado = Estado.Inicial;
            _daoServicioWS = new ServicioWSClient();
            cboPlataformaOrigen.DataSource = _daoServicioWS.listarTodas();
            cboPlataformaOrigen.DisplayMember = "nombre";
            cboPlataformaOrigen.ValueMember = "idPlataforma";
            limpiarComponentes();
            establecerEstadoComponentes();
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
                    btnBuscarUniverso.Enabled = false;
                    lblIDPersonaje.Enabled = false;
                    txtIDPersonaje.Enabled = false;
                    lblNombre.Enabled = false;
                    txtNombre.Enabled = false;
                    lblUniverso.Enabled = false;
                    txtUniverso.Enabled = false;
                    lblFechaAparicion.Enabled = false;
                    dtpFechaAparicion.Enabled = false;
                    lblPlataformaOrigen.Enabled = false;
                    cboPlataformaOrigen.Enabled = false;
                    lblDescripcion.Enabled = false;
                    txtDescripcion.Enabled = false;
                    lblVelocidadCaminar.Enabled = false;
                    txtVelocidadCaminar.Enabled = false;
                    lblVelocidadCorrer.Enabled = false;
                    txtVelocidadCorrer.Enabled = false;
                    cbSaltoPared.Enabled = false;
                    cbAdhesionParedes.Enabled = false;
                    cbArrastre.Enabled = false;
                    lblCantMaxSaltos.Enabled = false;
                    nudCantMaxSaltos.Enabled = false;
                    lblDatosTecnicosAdicionales.Enabled = false;
                    lblPeso.Enabled = false;
                    txtPeso.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnSubirFoto.Enabled = true;
                    btnBuscarUniverso.Enabled = true;
                    lblIDPersonaje.Enabled = true;
                    txtIDPersonaje.Enabled = true;
                    lblNombre.Enabled = true;
                    txtNombre.Enabled = true;
                    txtNombre.ReadOnly = false;
                    lblUniverso.Enabled = true;
                    txtUniverso.Enabled = true;
                    lblFechaAparicion.Enabled = true;
                    dtpFechaAparicion.Enabled = true;
                    lblPlataformaOrigen.Enabled = true;
                    cboPlataformaOrigen.Enabled = true;
                    lblDescripcion.Enabled = true;
                    txtDescripcion.Enabled = true;
                    txtDescripcion.ReadOnly = false;
                    lblVelocidadCaminar.Enabled = true;
                    txtVelocidadCaminar.Enabled = true;
                    txtVelocidadCaminar.ReadOnly = false;
                    lblVelocidadCorrer.Enabled = true;
                    txtVelocidadCorrer.Enabled = true;
                    txtVelocidadCorrer.ReadOnly = false;
                    cbSaltoPared.Enabled = true;
                    cbAdhesionParedes.Enabled = true;
                    cbArrastre.Enabled = true;
                    lblCantMaxSaltos.Enabled = true;
                    nudCantMaxSaltos.Enabled = true;
                    lblDatosTecnicosAdicionales.Enabled = true;
                    lblPeso.Enabled = true;
                    txtPeso.Enabled = true;
                    txtPeso.ReadOnly = false;
                    break;
                case Estado.Buscar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnSubirFoto.Enabled = false;
                    btnBuscarUniverso.Enabled = false;
                    lblIDPersonaje.Enabled = true;
                    txtIDPersonaje.Enabled = true;
                    lblNombre.Enabled = true;
                    txtNombre.Enabled = true;
                    txtNombre.ReadOnly = true;
                    lblUniverso.Enabled = true;
                    txtUniverso.Enabled = false;
                    lblFechaAparicion.Enabled = true;
                    dtpFechaAparicion.Enabled = false;
                    lblPlataformaOrigen.Enabled = true;
                    cboPlataformaOrigen.Enabled = false;
                    lblDescripcion.Enabled = true;
                    txtDescripcion.Enabled = true;
                    txtDescripcion.ReadOnly = true;
                    lblVelocidadCaminar.Enabled = true;
                    txtVelocidadCaminar.Enabled = true;
                    txtVelocidadCaminar.ReadOnly = true;
                    lblVelocidadCorrer.Enabled = true;
                    txtVelocidadCorrer.Enabled = true;
                    txtVelocidadCorrer.ReadOnly = true;
                    cbSaltoPared.Enabled = false;
                    cbAdhesionParedes.Enabled = false;
                    cbArrastre.Enabled = false;
                    lblCantMaxSaltos.Enabled = true;
                    nudCantMaxSaltos.Enabled = false;
                    lblDatosTecnicosAdicionales.Enabled = true;
                    lblPeso.Enabled = true;
                    txtPeso.Enabled = true;
                    txtPeso.ReadOnly = true;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            txtIDPersonaje.Text = "";
            txtNombre.Text = "";
            txtUniverso.Text = "";
            dtpFechaAparicion.Value = DateTime.Now;
            cboPlataformaOrigen.SelectedIndex = -1;
            txtDescripcion.Text = "";
            txtVelocidadCaminar.Text = "";
            txtVelocidadCorrer.Text = "";
            nudCantMaxSaltos.Value = 0;
            cbSaltoPared.Checked = false;
            cbAdhesionParedes.Checked = false;
            cbArrastre.Checked = false;
        }

        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdFoto.ShowDialog() == DialogResult.OK)
                {
                    _rutaFotoLocal = ofdFoto.FileName;
                    pbFoto.Image = Image.FromFile(_rutaFotoLocal);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            _personaje = new personaje();
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Inicial;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Buscar;
            establecerEstadoComponentes();
        }

        private void btnBuscarUniverso_Click(object sender, EventArgs e)
        {
            frmBusquedaUniverso formBusqUniv = new frmBusquedaUniverso();
            if (formBusqUniv.ShowDialog() == DialogResult.OK)
            {
                _universo = new universo();
                _universo = formBusqUniv.UniversoSeleccionado;
                txtUniverso.Text = _universo.nombre;
                establecerEstadoComponentes();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _personaje.nombre = txtNombre.Text;
            _personaje.universo = new universo();
            _personaje.universo.idUniverso = _universo.idUniverso;
            _personaje.fechaAparicion = dtpFechaAparicion.Value;
            _personaje.plataforma = new plataforma();
            _personaje.plataforma.idPlataforma = (int)cboPlataformaOrigen.SelectedValue;
            _personaje.descripcion = txtDescripcion.Text;
            FileStream fs = new FileStream(_rutaFotoLocal, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            _personaje.foto = br.ReadBytes((int)fs.Length);
            fs.Close();
            _personaje.peso = Double.Parse(txtPeso.Text);
            _personaje.velocidadAlCaminar = Double.Parse(txtVelocidadCaminar.Text);
            _personaje.velocidadAlCorrer = Double.Parse(txtVelocidadCorrer.Text);
            _personaje.cantidadMaxSaltos = (int)nudCantMaxSaltos.Value;
            _personaje.saltoPared = cbSaltoPared.Checked;
            _personaje.adhesionParedes = cbAdhesionParedes.Checked;
            _personaje.arrastre = cbArrastre.Checked;
            if (_estado == Estado.Nuevo)
            {
                int resultado = _daoServicioWS.insertar(_personaje);
                if (resultado != 0)
                {
                    txtIDPersonaje.Text = resultado.ToString();
                    MessageBox.Show("El personaje se ha registrado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    establecerEstadoComponentes();
                }
                else
                    MessageBox.Show("Hubo un error en el registro", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
