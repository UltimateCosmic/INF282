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
using EventSoft.ServicioWeb;

namespace EventSoft
{
    /* Coloque su nombre completo y código
     * Nombre Completo: Johan Carlo Amador Egoavil
     * Código PUCP: 20203350
     */
    public partial class frmGestionEventos : Form
    {
        private Estado _estado;
        private string _rutaFoto;
        private artista _artista;
        private establecimiento _establecimiento;
        private evento _evento;
        private ServicioWebClient _daoServicioWeb; 
        public frmGestionEventos()
        {
            InitializeComponent();
            _estado = Estado.Inicial;
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
                    btnBuscarArtista.Enabled = false;
                    btnBuscarEstablecimiento.Enabled = false;
                    btnSubirFoto.Enabled = false;
                    txtIDEvento.Enabled = false;
                    txtIDEvento.ReadOnly = true;
                    txtNombreEvento.Enabled = false;
                    txtNombreEvento.ReadOnly = false;
                    rbConcierto.Enabled = false;
                    rbTeatro.Enabled = false;
                    txtArtista.Enabled = false;
                    txtArtista.ReadOnly = true;
                    txtEstablecimiento.Enabled = false;
                    txtEstablecimiento.ReadOnly = true;
                    dtpFechaEvento.Enabled = false;
                    dtpHoraEvento.Enabled = false;
                    txtCostoRealizacion.Enabled = false;
                    txtCostoRealizacion.ReadOnly = false;
                    txtCantEntradasDisp.Enabled = false;
                    txtCantEntradasDisp.ReadOnly = false;
                    txtDescripcion.Enabled = false;
                    txtDescripcion.ReadOnly = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnBuscarArtista.Enabled = true;
                    btnBuscarEstablecimiento.Enabled = true;
                    btnSubirFoto.Enabled = true;
                    txtIDEvento.Enabled = true;
                    txtIDEvento.ReadOnly = true;
                    txtNombreEvento.Enabled = true;
                    txtNombreEvento.ReadOnly = false;
                    rbConcierto.Enabled = true;
                    rbTeatro.Enabled = true;
                    txtArtista.Enabled = true;
                    txtArtista.ReadOnly = true;
                    txtEstablecimiento.Enabled = true;
                    txtEstablecimiento.ReadOnly = true;
                    dtpFechaEvento.Enabled = true;
                    dtpHoraEvento.Enabled = true;
                    txtCostoRealizacion.Enabled = true;
                    txtCostoRealizacion.ReadOnly = false;
                    txtCantEntradasDisp.Enabled = true;
                    txtCantEntradasDisp.ReadOnly = false;
                    txtDescripcion.Enabled = true;
                    txtDescripcion.ReadOnly = false;
                    break;
                case Estado.Buscar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnBuscarArtista.Enabled = false;
                    btnBuscarEstablecimiento.Enabled = false;
                    btnSubirFoto.Enabled = false;
                    txtIDEvento.Enabled = true;
                    txtIDEvento.ReadOnly = true;
                    txtNombreEvento.Enabled = true;
                    txtNombreEvento.ReadOnly = true;
                    rbConcierto.Enabled = false;
                    rbTeatro.Enabled = false;
                    txtArtista.Enabled = true;
                    txtArtista.ReadOnly = true;
                    txtEstablecimiento.Enabled = true;
                    txtEstablecimiento.ReadOnly = true;
                    dtpFechaEvento.Enabled = false;
                    dtpHoraEvento.Enabled = false;
                    txtCostoRealizacion.Enabled = true;
                    txtCostoRealizacion.ReadOnly = true;
                    txtCantEntradasDisp.Enabled = true;
                    txtCantEntradasDisp.ReadOnly = true;
                    txtDescripcion.Enabled = true;
                    txtDescripcion.ReadOnly = true;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            txtIDEvento.Text = "";
            txtNombreEvento.Text = "";
            rbConcierto.Checked = false;
            rbTeatro.Checked = false;
            txtArtista.Text = "";
            txtEstablecimiento.Text = "";
            dtpFechaEvento.Value = DateTime.Now;
            dtpHoraEvento.Value = DateTime.Now;
            txtCostoRealizacion.Text = "";
            txtCantEntradasDisp.Text = "";
            txtDescripcion.Text = "";
            pbFoto.Image = null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarComponentes();
            _estado = Estado.Inicial;
            establecerEstadoComponentes();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarComponentes();
            _estado = Estado.Nuevo;
            establecerEstadoComponentes();
            _evento = new evento();
        }

        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdFoto.ShowDialog() == DialogResult.OK)
                {
                    _rutaFoto = ofdFoto.FileName;
                    pbFoto.Image = Image.FromFile(_rutaFoto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Buscar;
            establecerEstadoComponentes();
            frmBusquedaEventos formBusqEv = new frmBusquedaEventos();
            if (formBusqEv.ShowDialog() == DialogResult.OK)
            {
                _evento = formBusqEv.EventoSeleccionado;
                txtIDEvento.Text = _evento.idEvento.ToString();
                txtNombreEvento.Text = _evento.nombre;
                if (_evento.tipoEvento == tipoEvento.CONCIERTO) rbConcierto.Checked = true;
                else if (_evento.tipoEvento == tipoEvento.TEATRO) rbTeatro.Checked = true;
                txtArtista.Text = _evento.artista.nombre;
                txtEstablecimiento.Text = _evento.establecimiento.nombre;
                dtpFechaEvento.Value = _evento.fechaEvento;
                dtpHoraEvento.Value = DateTime.ParseExact(_evento.horaEvento, "HH:mm", null);
                txtCostoRealizacion.Text = _evento.costoRealizacion.ToString();
                txtCantEntradasDisp.Text = _evento.cantidadEntradasDisponibles.ToString();
                txtDescripcion.Text = _evento.descripcion.ToString();
                MemoryStream ms = new MemoryStream(_evento.foto);
                pbFoto.Image = new Bitmap(ms);
                _estado = Estado.Buscar;
                establecerEstadoComponentes();
            }
        }

        private void btnBuscarArtista_Click(object sender, EventArgs e)
        {
            _estado = Estado.Buscar;
            establecerEstadoComponentes();
            frmBusquedaArtistas formBusqArt = new frmBusquedaArtistas();
            if (formBusqArt.ShowDialog() == DialogResult.OK)
            {
                _artista = formBusqArt.ArtistaSeleccionado;
                txtArtista.Text = _artista.nombre;
            }
        }

        private void btnBuscarEstablecimiento_Click(object sender, EventArgs e)
        {
            _estado = Estado.Buscar;
            establecerEstadoComponentes();
            frmBusquedaEstablecimientos formBusqEst = new frmBusquedaEstablecimientos();
            if (formBusqEst.ShowDialog() == DialogResult.OK)
            {
                _establecimiento = formBusqEst.EstablecimientoSeleccionado;
                txtEstablecimiento.Text = _establecimiento.nombre;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _evento.nombre = txtNombreEvento.Text;
            if (rbConcierto.Checked) _evento.tipoEvento = tipoEvento.CONCIERTO;
            else if (rbTeatro.Checked) _evento.tipoEvento = tipoEvento.TEATRO;
            _evento.tipoEventoSpecified = true;
            _evento.artista = new artista();
            _evento.artista = _artista;
            _evento.establecimiento = new establecimiento();
            _evento.establecimiento = _establecimiento;
            _evento.fechaEvento = dtpFechaEvento.Value;
            _evento.fechaEventoSpecified = true;
            _evento.horaEvento = dtpHoraEvento.Value.ToString();
            _evento.costoRealizacion = Double.Parse(txtCostoRealizacion.Text);
            _evento.cantidadEntradasDisponibles = Int32.Parse(txtCantEntradasDisp.Text);
            _evento.descripcion = txtDescripcion.Text;
            FileStream fs = new FileStream(_rutaFoto, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            _evento.foto = br.ReadBytes((int)fs.Length);
            fs.Close();
            if (_estado == Estado.Nuevo)
            {
                int resultado = _daoServicioWeb.insertarEvento(_evento);
                if (resultado != 0)
                {
                    txtIDEvento.Text = resultado.ToString();
                    MessageBox.Show("El evento se ha registrado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    establecerEstadoComponentes();
                }
            }
        }
    }
}
