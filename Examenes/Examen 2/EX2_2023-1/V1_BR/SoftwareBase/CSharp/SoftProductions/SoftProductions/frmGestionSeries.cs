using SoftProductions.ProductoraWS;
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

namespace SoftProductions
{
    /* Coloque sus datos
        * -------------------------------------------------
        * Nombre Completo:
        * Código PUCP:
        * Fecha de Modificación: 
    */
    public partial class frmGestionSeries : Form
    {
        private Estado _estado;
        private string _rutaFotoLocal;

        private ProductoraWSClient _daoProductora;
        private BindingList<productora> _productoras;
        private productora _productora;

        private director _director;
        private serieTelevision _serieTelevision;
        private BindingList<capitulo> _capitulos;


        public frmGestionSeries()
        {
            InitializeComponent();
            _estado = Estado.Inicial;
            _daoProductora = new ProductoraWSClient();
            _capitulos = new BindingList<capitulo>();
            _productoras = new BindingList<productora>(_daoProductora.listarProductorasTodas());
            cboProductora.DataSource = _productoras.ToList();
            cboProductora.ValueMember = "idProductora";
            cboProductora.DisplayMember = "nombreProductora";
            dgvCapitulos.AutoGenerateColumns = false;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        public void limpiarComponentes()
        {
            cboProductora.SelectedIndex = -1;
            pbLogoProductora.Image = null;
            pbPortada.Image = null;
            panelSuperior.BackColor = SystemColors.Control;
            panelInferior.BackColor = SystemColors.Control;
            txtIDSerie.Text = "";
            txtNombreSerie.Text = "";
            nudTemporada.Value = 1;
            dtpFechaEmision.Value = DateTime.Now;
            txtCostoProduccion.Text = "";
            rbEspanhol.Checked = false;
            rbIngles.Checked = false;
            txtSipnosis.Text = "";
            txtNombreCapitulo.Text = "";
            nudNumCapitulo.Value = 1;
            txtDirectorCapitulo.Text = "";
            txtDuracionCapitulo.Text = "";
            _serieTelevision = new serieTelevision();
            _serieTelevision.productora = new productora();
            dgvCapitulos.DataSource = _capitulos;
        }

        private void btnSubirPortada_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdPortada.ShowDialog() == DialogResult.OK)
                {
                    _rutaFotoLocal = ofdPortada.FileName;
                    pbPortada.Image = Image.FromFile(_rutaFotoLocal);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Inicial;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
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
                    txtIDSerie.Enabled = false;
                    txtIDSerie.ReadOnly = true;
                    txtNombreSerie.Enabled = false;
                    txtNombreSerie.ReadOnly = false;
                    cboProductora.Enabled = false;
                    nudTemporada.Enabled = false;
                    dtpFechaEmision.Enabled = false;
                    txtCostoProduccion.Enabled = false;
                    txtCostoProduccion.ReadOnly = false;
                    rbEspanhol.Enabled = false;
                    rbIngles.Enabled = false;
                    txtSipnosis.Enabled = false;
                    txtSipnosis.ReadOnly = false;
                    txtNombreCapitulo.Enabled = false;
                    txtNombreCapitulo.ReadOnly = false;
                    nudNumCapitulo.Enabled = false;
                    txtDirectorCapitulo.Enabled = false;
                    txtDirectorCapitulo.ReadOnly = true;
                    txtDuracionCapitulo.Enabled = false;
                    txtDuracionCapitulo.ReadOnly = false;
                    btnAgregarCapitulo.Enabled = false;
                    btnEliminarCapitulo.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    txtIDSerie.Enabled = true;
                    txtIDSerie.ReadOnly = true;
                    txtNombreSerie.Enabled = true;
                    txtNombreSerie.ReadOnly = false;
                    cboProductora.Enabled = true;
                    nudTemporada.Enabled = true;
                    dtpFechaEmision.Enabled = true;
                    txtCostoProduccion.Enabled = true;
                    txtCostoProduccion.ReadOnly = false;
                    rbEspanhol.Enabled = true;
                    rbIngles.Enabled = true;
                    txtSipnosis.Enabled = true;
                    txtSipnosis.ReadOnly = false;
                    txtNombreCapitulo.Enabled = true;
                    txtNombreCapitulo.ReadOnly = false;
                    nudNumCapitulo.Enabled = true;
                    txtDirectorCapitulo.Enabled = true;
                    txtDirectorCapitulo.ReadOnly = true;
                    txtDuracionCapitulo.Enabled = true;
                    txtDuracionCapitulo.ReadOnly = false;
                    btnAgregarCapitulo.Enabled = true;
                    btnEliminarCapitulo.Enabled = true;
                    break;
                case Estado.Buscar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    txtIDSerie.Enabled = true;
                    txtIDSerie.ReadOnly = true;
                    txtNombreSerie.Enabled = true;
                    txtNombreSerie.ReadOnly = true;
                    cboProductora.Enabled = false;
                    nudTemporada.Enabled = false;
                    dtpFechaEmision.Enabled = false;
                    txtCostoProduccion.Enabled = true;
                    txtCostoProduccion.ReadOnly = true;
                    rbEspanhol.Enabled = false;
                    rbIngles.Enabled = false;
                    txtSipnosis.Enabled = true;
                    txtSipnosis.ReadOnly = true;
                    txtNombreCapitulo.Enabled = false;
                    txtNombreCapitulo.ReadOnly = false;
                    nudNumCapitulo.Enabled = false;
                    txtDirectorCapitulo.Enabled = false;
                    txtDirectorCapitulo.ReadOnly = true;
                    txtDuracionCapitulo.Enabled = false;
                    txtDuracionCapitulo.ReadOnly = false;
                    btnAgregarCapitulo.Enabled = false;
                    btnEliminarCapitulo.Enabled = false;
                    break;
            }
        }

        private void cboProductora_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboProductora.SelectedIndex != -1)
            {
                _productora = _productoras[cboProductora.SelectedIndex];
                MemoryStream ms = new MemoryStream(_productora.logo);
                pbLogoProductora.Image = new Bitmap(ms);
                panelSuperior.BackColor = Color.FromArgb(_productora.r, _productora.g, _productora.b);
                panelInferior.BackColor = Color.FromArgb(_productora.r, _productora.g, _productora.b);
            }
            
        }

        private void btnBuscarDirector_Click(object sender, EventArgs e)
        {
            frmBusquedaDirectores frmBusqDir = new frmBusquedaDirectores();
            if(frmBusqDir.ShowDialog() == DialogResult.OK )
            {
                _director = frmBusqDir.DirectorSeleccionado;
                txtDirectorCapitulo.Text = _director.nombreDirector + " " + _director.apellidoDirector;
            }
        }

        private void btnAgregarCapitulo_Click(object sender, EventArgs e)
        {
            if (txtNombreCapitulo.Text == "" || txtDuracionCapitulo.Text == "" || txtDirectorCapitulo.Text == "")
            {
                MessageBox.Show("Debe seleccionar un programa academico", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            capitulo cap = new capitulo();
            cap.numeroCapitulo = (int)nudNumCapitulo.Value;
            cap.nombreCapitulo = txtNombreCapitulo.Text;
            cap.director = _director;
            cap.duracion = txtDuracionCapitulo.Text;
            _capitulos.Add(cap);
            txtNombreCapitulo.Text = "";
            txtDuracionCapitulo.Text = "";
            txtDirectorCapitulo.Text = "";
        }

        private void dgvCapitulos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            capitulo capitulo = (capitulo)dgvCapitulos.Rows[e.RowIndex].DataBoundItem;
            try
            {
                dgvCapitulos.Rows[e.RowIndex].Cells[0].Value = capitulo.numeroCapitulo;
                dgvCapitulos.Rows[e.RowIndex].Cells[1].Value = capitulo.nombreCapitulo;
                dgvCapitulos.Rows[e.RowIndex].Cells[2].Value = capitulo.director.nombreDirector + " " + capitulo.director.apellidoDirector;
                dgvCapitulos.Rows[e.RowIndex].Cells[3].Value = capitulo.duracion;
            }
            catch(Exception ex) { }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _serieTelevision.nombreSerie = txtNombreSerie.Text;
            _serieTelevision.productora = _productora;
            _serieTelevision.temporada = (int)nudTemporada.Value;
            _serieTelevision.fechaEmision = dtpFechaEmision.Value;
            _serieTelevision.fechaEmisionSpecified = true;
            _serieTelevision.costoProduccion = Double.Parse(txtCostoProduccion.Text);
            _serieTelevision.idioma = rbEspanhol.Checked ? 'E' : 'I';
            FileStream fs = new FileStream(_rutaFotoLocal, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            _serieTelevision.portada = br.ReadBytes((int)fs.Length);
            fs.Close();
            _serieTelevision.sipnosis = txtSipnosis.Text;
            _serieTelevision.capitulos = _capitulos.ToArray();
            int resultado = _daoProductora.insertarSerieTelevision(_serieTelevision);
            if (resultado != 0)
            {
                txtIDSerie.Text = resultado.ToString();
                MessageBox.Show("Se ha registrado con éxito la serie", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _estado = Estado.Inicial;
                establecerEstadoComponentes();
            }
            else
                MessageBox.Show("Ha ocurrido un error con el registro", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnEliminarCapitulo_Click(object sender, EventArgs e)
        {
            if (dgvCapitulos.CurrentRow != null)
            {
                capitulo cap = (capitulo)dgvCapitulos.CurrentRow.DataBoundItem;
                _capitulos.Remove(cap);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un capitulo", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaSeries frmBusqSer = new frmBusquedaSeries();
            if(frmBusqSer.ShowDialog() == DialogResult.OK)
            {
                _serieTelevision = frmBusqSer.SerieSeleccionada;
                dgvCapitulos.DataSource = _serieTelevision.capitulos;
                txtIDSerie.Text = _serieTelevision.idSerieTelevision.ToString();
                txtNombreSerie.Text = _serieTelevision.nombreSerie;
                nudTemporada.Value = _serieTelevision.temporada;
                dtpFechaEmision.Value = _serieTelevision.fechaEmision;
                txtCostoProduccion.Text = _serieTelevision.costoProduccion.ToString ();
                rbEspanhol.Checked = _serieTelevision.idioma == 'E'? true: false; ;
                rbIngles.Checked = _serieTelevision.idioma == 'I'? true: false; ;
                txtSipnosis.Text = _serieTelevision.sipnosis;
                MemoryStream ms = new MemoryStream(_serieTelevision.portada);
                pbPortada.Image = new Bitmap(ms);
                ms = new MemoryStream(_serieTelevision.productora.logo);
                pbLogoProductora.Image = new Bitmap(ms);
                panelSuperior.BackColor = Color.FromArgb(_serieTelevision.productora.r, _serieTelevision.productora.g, _serieTelevision.productora.b);
                panelInferior.BackColor = Color.FromArgb(_serieTelevision.productora.r, _serieTelevision.productora.g, _serieTelevision.productora.b);
                cboProductora.Text = _serieTelevision.productora.nombreProductora;
            }
        }
    }
}
