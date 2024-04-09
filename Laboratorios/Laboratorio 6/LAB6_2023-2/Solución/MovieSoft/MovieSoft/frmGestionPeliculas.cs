using MovieSoftController.DAO;
using MovieSoftController.MySQL;
using MovieSoftModel;
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

namespace MovieSoft
{
    /* Colocar datos
     * ----------------------------------------------------
     * Código PUCP: 20203350
     * Nombre Completo: Johan Carlo Amador Egoavil
     * Fecha de modificación:
     * ----------------------------------------------------
     */
    public partial class frmGestionPeliculas : Form
    {
        private string _rutaPortada = "";
        private Estado _estado;
        private Pelicula _pelicula;
        private PeliculaDAO _daoPelicula;
        private Genero _genero;
        private GeneroDAO _daoGenero;
        private Productora _productora;
        private ProductoraDAO _daoProductora;

        public frmGestionPeliculas()
        {
            InitializeComponent();
            _estado = Estado.Inicial;
            limpiarComponentes();

            _daoGenero = new GeneroMySQL();
            cboGenero.DataSource = _daoGenero.lista();
            cboGenero.DisplayMember = "Nombre";
            cboGenero.ValueMember = "IdGenero";

            _daoProductora = new ProductoraMySQL();
            cboProductora.DataSource = _daoProductora.lista();
            cboProductora.DisplayMember = "Nombre";
            cboProductora.ValueMember = "IdProductora";

            _daoPelicula = new PeliculaMySQL();

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
                    btnCancelar.Enabled = false;
                    gbDatosGenerales.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    gbDatosGenerales.Enabled = true;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            txtIDPelicula.Text = "";
            txtNombre.Text = "";
            cboGenero.SelectedIndex = -1;
            cboProductora.SelectedIndex = -1;
            dtpFechaEstreno.Value = DateTime.Now;
            cbDoblada.Checked = false;
            cbSubtitulada.Checked = false;
            txtCostoProduccion.Text = "";
            txtSinopsis.Text = "";
            panelSuperior.BackColor = SystemColors.Control;
            pbLogoProductora.Image = null;
            pbPortada.Image = null;

        }

        private void btnSubirPortada_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdPortada.ShowDialog() == DialogResult.OK)
                {
                    _rutaPortada = ofdPortada.FileName;
                    pbPortada.Image = Image.FromFile(_rutaPortada);
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
            establecerEstadoComponentes();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            _pelicula = new Pelicula();
            establecerEstadoComponentes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaPeliculas formBusqPeliculas = new frmBusquedaPeliculas();
            if(formBusqPeliculas.ShowDialog() == DialogResult.OK)
            {
                _pelicula = formBusqPeliculas.Pelicula;
                txtIDPelicula.Text = _pelicula.IdPelicula.ToString();
                txtNombre.Text = _pelicula.Nombre;
                cboProductora.SelectedValue = _pelicula.Productora.IdProductora;
                cboGenero.SelectedValue = _pelicula.Genero.IdGenero;
                dtpFechaEstreno.Value = _pelicula.FechaEstreno;
                cbDoblada.Checked = _pelicula.FormatoDoblada;
                cbSubtitulada.Checked = _pelicula.FormatoSubtitulada;
                cbXtreme.Checked = _pelicula.FormatoXtreme;
                cb3D.Checked = _pelicula.Formato3D;
                txtCostoProduccion.Text = _pelicula.CostoProduccion.ToString();
                MemoryStream ms = new MemoryStream(_pelicula.Portada);
                pbPortada.Image = new Bitmap(ms);
                txtSinopsis.Text = _pelicula.Sinopsis;
            }
        }

        private void cboGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboProductora_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProductora.SelectedIndex != -1)
            {
                _productora = new Productora();
                _productora = (Productora)cboProductora.SelectedItem;
                MemoryStream ms = new MemoryStream(_productora.Logo);
                pbLogoProductora.Image = new Bitmap(ms);
                panelSuperior.BackColor = Color.FromArgb(_productora.R, _productora.G, _productora.B);
            }
        }

        private void pbLogoProductora_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _pelicula.Productora = (Productora)cboProductora.SelectedItem;
            _pelicula.Genero = (Genero)cboGenero.SelectedItem;
            _pelicula.Nombre = txtNombre.Text;
            _pelicula.FechaEstreno = dtpFechaEstreno.Value;
            _pelicula.FormatoDoblada = cbDoblada.Enabled;
            _pelicula.FormatoSubtitulada = cbSubtitulada.Enabled;
            _pelicula.FormatoXtreme = cbXtreme.Enabled;
            _pelicula.Formato3D = cb3D.Enabled;
            _pelicula.CostoProduccion = Double.Parse(txtCostoProduccion.Text);
            _pelicula.Sinopsis = txtSinopsis.Text;
            
            FileStream fs = new FileStream(_rutaPortada, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            _pelicula.Portada = br.ReadBytes((int)fs.Length);
            fs.Close();

            int resultado = _daoPelicula.insertar(_pelicula);
            if (resultado!=0)
            {
                txtIDPelicula.Text = _pelicula.IdPelicula.ToString();
                MessageBox.Show("La película se ha registrado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
                MessageBox.Show("Hubo un error en el registro", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void listarPelicula(Pelicula peliculaSel)
        {
            txtIDPelicula.Text = peliculaSel.IdPelicula.ToString();
            txtNombre.Text = peliculaSel.Nombre;
            cboGenero.SelectedIndex = peliculaSel.Genero.IdGenero;
            cboProductora.SelectedIndex = peliculaSel.Productora.IdProductora;
            dtpFechaEstreno.Value = peliculaSel.FechaEstreno;
            cbDoblada.Checked = peliculaSel.FormatoDoblada;
            cbSubtitulada.Checked = peliculaSel.FormatoSubtitulada;
            cbXtreme.Checked = peliculaSel.FormatoXtreme;
            cb3D.Checked = peliculaSel.Formato3D;
            txtCostoProduccion.Text = peliculaSel.CostoProduccion.ToString();
            txtSinopsis.Text = peliculaSel.Sinopsis;
            panelSuperior.BackColor = Color.FromArgb(peliculaSel.Productora.R, peliculaSel.Productora.G, peliculaSel.Productora.B);
            MemoryStream ms = new MemoryStream(peliculaSel.Portada);
            pbPortada.Image = new Bitmap(ms);
            MemoryStream ms2 = new MemoryStream(peliculaSel.Productora.Logo);
            pbLogoProductora.Image = new Bitmap(ms2);
        }
    }
}
