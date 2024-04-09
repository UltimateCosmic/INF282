using EventSoftController.DAO;
using EventSoftController.MySQL;
using EventSoftModel;
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

/* Coloque sus datos
    * -------------------------------------------
    * Nombre Completo: Johan Carlo Amador Egoavil
    * Código PUCP: 20203350
    * Fecha de Modificación: 
*/

namespace EventSoft
{
    public partial class frmGestionLocales : Form
    {
        
        private string _rutaFotoLocal = "";
        private string _rutaArchivoPlano = "";
        private Estado _estado;
        private Local _local;
        private LocalDAO _daoLocal;
        private EstiloArquitectonicoDAO _daoEstiloArquitectonico;
        public frmGestionLocales()
        {
            InitializeComponent();
            _daoLocal = new LocalMySQL();
            _daoEstiloArquitectonico = new EstiloArquitectonicoMySQL();
            _estado = Estado.Inicial;
            limpiarComponentes();
            cboEstiloArquitectonico.DataSource = _daoEstiloArquitectonico.lista();
            cboEstiloArquitectonico.DisplayMember = "Nombre";
            cboEstiloArquitectonico.ValueMember = "IdEstiloArquitectonico";
            establecerEstadoComponentes();
        }

        public void listarLocal(Local localSel)
        {
            txtID.Text = localSel.IdLocal.ToString();
            txtNombre.Text = localSel.Nombre;
            txtDireccion.Text = localSel.Direccion;
            txtAforo.Text = localSel.Aforo.ToString();
            dtpFechaConstruccion.Value = localSel.FechaConstruccion;
            cboEstiloArquitectonico.SelectedIndex = localSel.EstiloArquitectonico.IdEstiloArquitectonico;
            cbPalco.Checked = localSel.TienePalco;
            cbProyector.Checked = localSel.TieneProyector;
            cbVestibulo.Checked = localSel.TieneVestibulo;
            txtResenha.Text = localSel.Resenha;
            MemoryStream ms = new MemoryStream(localSel.Foto);
            pbFoto.Image = new Bitmap(ms);
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

        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Inicial:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnCancelar.Enabled = true;
                    gbDatosGenerales.Enabled = false;
                    btnSubirPDF.Enabled = false;
                    btnDescargarPDF.Enabled = false;
                    btnSubirFoto.Enabled = false;
                    txtNombre.ReadOnly = false;
                    txtDireccion.ReadOnly = false;
                    txtAforo.ReadOnly = false;
                    txtResenha.ReadOnly = false;
                    dtpFechaConstruccion.Enabled = false;
                    cboEstiloArquitectonico.Enabled = false;
                    cbPalco.Enabled = false;
                    cbProyector.Enabled = false;
                    cbVestibulo.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    gbDatosGenerales.Enabled = true;
                    btnSubirPDF.Enabled = true;
                    btnDescargarPDF.Enabled = false;
                    btnSubirFoto.Enabled = true;
                    txtNombre.ReadOnly = false;
                    txtDireccion.ReadOnly = false;
                    txtAforo.ReadOnly = false;
                    txtResenha.ReadOnly = false;
                    dtpFechaConstruccion.Enabled = true;
                    cboEstiloArquitectonico.Enabled = true;
                    cbPalco.Enabled = true;
                    cbProyector.Enabled = true;
                    cbVestibulo.Enabled = true;
                    break;
                case Estado.Buscar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    gbDatosGenerales.Enabled = true;
                    btnSubirPDF.Enabled = false;
                    btnDescargarPDF.Enabled = true;
                    btnSubirFoto.Enabled = false;
                    txtNombre.ReadOnly = true;
                    txtDireccion.ReadOnly = true;
                    txtAforo.ReadOnly = true;
                    txtResenha.ReadOnly = true;
                    dtpFechaConstruccion.Enabled = false;
                    cboEstiloArquitectonico.Enabled = false;
                    cbPalco.Enabled = false;
                    cbProyector.Enabled = false;
                    cbVestibulo.Enabled = false;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtAforo.Text = "";
            dtpFechaConstruccion.Value = DateTime.Now;
            cboEstiloArquitectonico.SelectedIndex = -1;
            cbPalco.Checked = false;
            cbProyector.Checked = false;
            cbVestibulo.Checked = false;
            txtResenha.Text = "";
            txtPlano.Text = "";
            pbFoto.Image = null;
            _rutaFotoLocal = "";
            _rutaArchivoPlano = "";
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
            _local = new Local();
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void btnSubirPDF_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdPlano.ShowDialog() == DialogResult.OK)
                {
                    _rutaArchivoPlano = ofdPlano.FileName;
                    txtPlano.Text = _rutaArchivoPlano;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al seleccionar el archivo", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Buscar;
            establecerEstadoComponentes();
            frmBusquedaLocales formBusqLoc = new frmBusquedaLocales();
            if (formBusqLoc.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnDescargarPDF_Click(object sender, EventArgs e)
        {
            if (sfdPlano.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    String archivoGenerar = sfdPlano.FileName;
                    MessageBox.Show("Se ha guardado el archivo", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se ha generado un error al momento de guardar el archivo", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void gbDatosGenerales_Enter(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _local.EstiloArquitectonico = (EstiloArquitectonico)cboEstiloArquitectonico.SelectedItem;
            _local.Nombre = txtNombre.Text;
            _local.Direccion = txtDireccion.Text;
            _local.FechaConstruccion = dtpFechaConstruccion.Value;
            _local.Aforo = int.Parse(txtAforo.Text);
            _local.TienePalco = cbPalco.Enabled;
            _local.TieneProyector = cbProyector.Enabled;
            _local.TieneVestibulo = cbVestibulo.Enabled;
            _local.Resenha = txtResenha.Text;
            
            FileStream fs = new FileStream(_rutaFotoLocal, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            _local.Foto = br.ReadBytes((int)fs.Length);
            fs.Close();

            FileStream fs2 = new FileStream(_rutaArchivoPlano, FileMode.Open, FileAccess.Read);
            BinaryReader br2 = new BinaryReader(fs2);
            _local.Plano = br2.ReadBytes((int)fs2.Length);
            fs2.Close();

            int resultado = _daoLocal.insertar(_local);
            if (resultado!=0)
            {
                txtID.Text = _local.IdLocal.ToString();
                MessageBox.Show("El local se ha registrado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
                MessageBox.Show("Hubo un error en el registro", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cbPalco_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
