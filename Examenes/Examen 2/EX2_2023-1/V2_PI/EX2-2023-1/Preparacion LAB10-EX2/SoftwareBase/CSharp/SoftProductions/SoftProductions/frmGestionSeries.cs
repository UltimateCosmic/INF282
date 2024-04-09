using SoftProductions.SoftProductionsWS;
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
        * Nombre Completo: Piero Franchesco Gonzales Fernandez
        * Código PUCP: 20201706
        * Fecha de Modificación: hoy 
    */
    public partial class frmGestionSeries : Form
    {
        private Estado _estado;
        private string _rutaFotoLocal;
        private SoftProductionsWSClient _daoSoftProductionsWS;
        private productora _productora;
        private director _directorSeleccionado;
        private BindingList<capitulo> _capitulos;
        private serieTelevision _serie;
        
        public frmGestionSeries()
        {
            _daoSoftProductionsWS = new SoftProductionsWSClient(); 
            InitializeComponent();
            cboProductora.DataSource = _daoSoftProductionsWS.listarTodasProductoras();
            cboProductora.DisplayMember = "nombreProductora";
            cboProductora.ValueMember = "idProductora";
            limpiarComponentes();
            _estado = Estado.Inicial;
            establecerEstadoComponentes();
            dgvCapitulos.AutoGenerateColumns = false;
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
            _productora = new productora();
            _serie = new serieTelevision();
            _capitulos = new BindingList<capitulo>();
            dgvCapitulos.DataSource = _capitulos;
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
                _productora = (productora)cboProductora.SelectedItem;
                MemoryStream ms = new MemoryStream(_productora.logo); 
                pbLogoProductora.Image = new Bitmap(ms);
                panelInferior.BackColor = Color.FromArgb(_productora.r, _productora.g,_productora.b);
                panelSuperior.BackColor = Color.FromArgb(_productora.r, _productora.g, _productora.b);
            }

        }

        private void btnBuscarDirector_Click(object sender, EventArgs e)
        {
            frmBusquedaDirectores formDirectores = new frmBusquedaDirectores();
            if (formDirectores.ShowDialog() == DialogResult.OK)
            {
                _directorSeleccionado = formDirectores.Director;
                txtDirectorCapitulo.Text = _directorSeleccionado.nombreDirector + " " + _directorSeleccionado.apellidoDirector;
            }
        }

        private void btnAgregarCapitulo_Click(object sender, EventArgs e)
        {
            capitulo capituloNuevo = new capitulo();
            capituloNuevo.nombreCapitulo = txtNombreCapitulo.Text;
            capituloNuevo.duracion = txtDuracionCapitulo.Text;
            //PARECE QUE NO ES NECESARIO GESTAR NUEVA MEMORIA, RECORDAR UU
            capituloNuevo.director = new director();
            capituloNuevo.director.idDirector = _directorSeleccionado.idDirector;
            capituloNuevo.numeroCapitulo = (int)nudNumCapitulo.Value;
            _capitulos.Add(capituloNuevo);
            capituloNuevo = null;
            txtNombreCapitulo.Text = "";
            txtDirectorCapitulo.Text = "";
            txtDuracionCapitulo.Text = "";
            nudNumCapitulo.Value++;

        }

        private void dgvCapitulos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //ESTRE TRY CATCH ES PARA PODER ELIMINAR SIN QUE SALGA UN ERROR DE EXCEPCION XD, SIEMPRE USAR EL TRY CATCH MI KING 
            try
            {
                capitulo capituloAux = (capitulo)dgvCapitulos.Rows[e.RowIndex].DataBoundItem;

                dgvCapitulos.Rows[e.RowIndex].Cells[0].Value = capituloAux.numeroCapitulo;
                dgvCapitulos.Rows[e.RowIndex].Cells[1].Value = capituloAux.nombreCapitulo;
                dgvCapitulos.Rows[e.RowIndex].Cells[2].Value = capituloAux.director.nombreDirector + " " +
                                                        capituloAux.director.apellidoDirector;
                dgvCapitulos.Rows[e.RowIndex].Cells[3].Value = capituloAux.duracion;
            }
            catch(Exception ex)
            {

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _serie.productora = new productora();
            _serie.productora.idProductora = _productora.idProductora;
            _serie.capitulos = _capitulos.ToArray();
            _serie.nombreSerie = txtNombreSerie.Text;
            _serie.temporada = (int)nudTemporada.Value;
            _serie.fechaEmision = dtpFechaEmision.Value;
            _serie.fechaEmisionSpecified = true;
            _serie.costoProduccion = Double.Parse(txtCostoProduccion.Text);
            if (rbEspanhol.Checked)
                _serie.idioma = 'E';
            if (rbIngles.Checked)
                _serie.idioma = 'I';
            _serie.sipnosis = txtSipnosis.Text;
            FileStream fs = new FileStream(_rutaFotoLocal, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            _serie.portada = br.ReadBytes((int)fs.Length);
            fs.Close();
            int resultado = _daoSoftProductionsWS.insertarSerieTV(_serie);
            if (resultado != 0)
            {
                MessageBox.Show("Se ha guardado la serie de forma exitosa", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIDSerie.Text = resultado.ToString();
                _estado = Estado.Inicial;
                establecerEstadoComponentes();
            }
            else
                MessageBox.Show("Ha ocurrido un error con el registro de la serie", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnEliminarCapitulo_Click(object sender, EventArgs e)
        {
            if (dgvCapitulos.CurrentRow != null)
            {
                capitulo capituloAux = (capitulo)dgvCapitulos.CurrentRow.DataBoundItem;
                _capitulos.Remove(capituloAux);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un capitulo", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaSeries formBuscarSeries = new frmBusquedaSeries();
            if (formBuscarSeries.ShowDialog() == DialogResult.OK)
            {
                _serie = formBuscarSeries.Serie;
                MemoryStream ms = new MemoryStream(_serie.productora.logo);
                pbLogoProductora.Image = new Bitmap(ms);
                panelInferior.BackColor = Color.FromArgb(_serie.productora.r, _serie.productora.g, _serie.productora.b);
                panelSuperior.BackColor = Color.FromArgb(_serie.productora.r, _serie.productora.g, _serie.productora.b);
                txtIDSerie.Text = _serie.idSerieTelevision.ToString();
                txtNombreSerie.Text = _serie.nombreSerie;
                cboProductora.SelectedValue = _serie.productora.idProductora;
                nudTemporada.Value = _serie.temporada;
                txtCostoProduccion.Text = _serie.costoProduccion.ToString();
                if (_serie.idioma == 'I')
                    rbIngles.Checked = true;
                else if (_serie.idioma == 'E')
                    rbEspanhol.Checked = true;
                txtSipnosis.Text = _serie.sipnosis;
                MemoryStream ms2 = new MemoryStream(_serie.portada);
                pbPortada.Image = new Bitmap(ms2);
                dgvCapitulos.DataSource = _daoSoftProductionsWS.listarCapitulosXID(_serie.idSerieTelevision);
            }
        }
    }
}
