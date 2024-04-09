using GameSoft.ServicioWeb;
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

namespace GameSoft
{
    /* Colocar su código PUCP y nombre completo:
     * Código PUCP: 20203350
     * Nombre Completo: Johan Carlo Amador Egoavil
     */

    public partial class frmGestionPokemons : Form
    {
        private Estado _estado;
        private String _rutaFoto;

        private ServicioWebClient _daoServicioWeb;

        private tipoElemental _tipo1;
        private tipoElemental _tipo2;
        private tipoElemental _tipoMovimiento;
        private blanco _blancoSeleccionado;
        private BindingList<movimientoNivel> _movimientos;
        private pokemon _pokemon;

        public frmGestionPokemons()
        {
            InitializeComponent();            
            _daoServicioWeb = new ServicioWebClient();
            cboTipo1.DataSource = _daoServicioWeb.listarTodosTiposElementales();
            cboTipo1.DisplayMember = "nombre";
            cboTipo1.ValueMember = "idTipoElemental";
            cboTipo2.DataSource = _daoServicioWeb.listarTodosTiposElementales();
            cboTipo2.DisplayMember = "nombre";
            cboTipo2.ValueMember = "idTipoElemental";
            cboTipoMovimiento.DataSource = _daoServicioWeb.listarTodosTiposElementales();
            cboTipoMovimiento.DisplayMember = "nombre";
            cboTipoMovimiento.ValueMember = "idTipoElemental";
            cboClaseMovimiento.DataSource = _daoServicioWeb.listarTodasClases();
            cboClaseMovimiento.DisplayMember = "claseMovimiento";
            cboClaseMovimiento.ValueMember = "idClase";
            dgvMovimientosPorNivel.AutoGenerateColumns = false;
            _estado = Estado.Inicial;
            establecerEstadoComponentes();
            limpiarComponentes();

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
                    txtNro.Enabled = false;
                    txtNro.ReadOnly = false;
                    txtNombre.Enabled = false;
                    txtNombre.ReadOnly = false;
                    cboTipo1.Enabled = false;
                    cboTipo2.Enabled = false;
                    btnSubirFoto.Enabled = false;
                    txtDescripcion.Enabled = false;
                    txtDescripcion.ReadOnly = false;
                    txtPeso.Enabled = false;
                    txtPeso.ReadOnly = false;
                    txtAltura.Enabled = false;
                    txtAltura.ReadOnly = false;
                    rbPrimeraGen.Enabled = false;
                    rbSegundaGen.Enabled = false;
                    rbTerceraGen.Enabled = false;
                    txtLVLMovimiento.Enabled = false;
                    txtLVLMovimiento.ReadOnly = false;
                    txtNombreMovimiento.Enabled = false;
                    txtNombreMovimiento.ReadOnly = false;
                    cboTipoMovimiento.Enabled = false;
                    cboClaseMovimiento.Enabled = false;
                    txtPoderMovimiento.Enabled = false;
                    txtPoderMovimiento.ReadOnly = false;
                    txtExactitudMovimiento.Enabled = false;
                    txtExactitudMovimiento.ReadOnly = false;
                    txtPPMovimiento.Enabled = false;
                    txtPPMovimiento.ReadOnly = false;
                    txtBlancoMovimiento.Enabled = false;
                    txtBlancoMovimiento.ReadOnly = true;
                    txtDescripcionBlancoMovimiento.Enabled = false;
                    txtDescripcionBlancoMovimiento.ReadOnly = true;
                    btnAgregarMovimiento.Enabled = false;
                    btnEliminarMovimiento.Enabled = false;
                    btnBuscarBlanco.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    txtNro.Enabled = true;
                    txtNro.ReadOnly = false;
                    txtNombre.Enabled = true;
                    txtNombre.ReadOnly = false;
                    cboTipo1.Enabled = true;
                    cboTipo2.Enabled = true;
                    btnSubirFoto.Enabled = true;
                    txtDescripcion.Enabled = true;
                    txtDescripcion.ReadOnly = false;
                    txtPeso.Enabled = true;
                    txtPeso.ReadOnly = false;
                    txtAltura.Enabled = true;
                    txtAltura.ReadOnly = false;
                    rbPrimeraGen.Enabled = true;
                    rbSegundaGen.Enabled = true;
                    rbTerceraGen.Enabled = true;
                    txtLVLMovimiento.Enabled = true;
                    txtLVLMovimiento.ReadOnly = false;
                    txtNombreMovimiento.Enabled = true;
                    txtNombreMovimiento.ReadOnly = false;
                    cboTipoMovimiento.Enabled = true;
                    cboClaseMovimiento.Enabled = true;
                    txtPoderMovimiento.Enabled = true;
                    txtPoderMovimiento.ReadOnly = false;
                    txtExactitudMovimiento.Enabled = true;
                    txtExactitudMovimiento.ReadOnly = false;
                    txtPPMovimiento.Enabled = true;
                    txtPPMovimiento.ReadOnly = false;
                    txtBlancoMovimiento.Enabled = true;
                    txtBlancoMovimiento.ReadOnly = true;
                    txtDescripcionBlancoMovimiento.Enabled = true;
                    txtDescripcionBlancoMovimiento.ReadOnly = true;
                    btnAgregarMovimiento.Enabled = true;
                    btnEliminarMovimiento.Enabled = true;
                    btnBuscarBlanco.Enabled = true;
                    break;
                case Estado.Buscar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    txtNro.Enabled = true;
                    txtNro.ReadOnly = true;
                    txtNombre.Enabled = true;
                    txtNombre.ReadOnly = true;
                    cboTipo1.Enabled = false;
                    cboTipo2.Enabled = false;
                    btnSubirFoto.Enabled = false;
                    txtDescripcion.Enabled = true;
                    txtDescripcion.ReadOnly = true;
                    txtPeso.Enabled = true;
                    txtPeso.ReadOnly = true;
                    txtAltura.Enabled = true;
                    txtAltura.ReadOnly = true;
                    rbPrimeraGen.Enabled = false;
                    rbSegundaGen.Enabled = false;
                    rbTerceraGen.Enabled = false;
                    txtLVLMovimiento.Enabled = true;
                    txtLVLMovimiento.ReadOnly = true;
                    txtNombreMovimiento.Enabled = true;
                    txtNombreMovimiento.ReadOnly = true;
                    cboTipoMovimiento.Enabled = false;
                    cboClaseMovimiento.Enabled = false;
                    txtPoderMovimiento.Enabled = true;
                    txtPoderMovimiento.ReadOnly = true;
                    txtExactitudMovimiento.Enabled = true;
                    txtExactitudMovimiento.ReadOnly = true;
                    txtPPMovimiento.Enabled = true;
                    txtPPMovimiento.ReadOnly = true;
                    txtBlancoMovimiento.Enabled = true;
                    txtBlancoMovimiento.ReadOnly = true;
                    txtDescripcionBlancoMovimiento.Enabled = true;
                    txtDescripcionBlancoMovimiento.ReadOnly = true;
                    btnAgregarMovimiento.Enabled = false;
                    btnEliminarMovimiento.Enabled = false;
                    btnBuscarBlanco.Enabled = false;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            dgvMovimientosPorNivel.DataSource = null;
            panelNroNombre.BackColor = SystemColors.Control;
            panelTipo1.BackColor = SystemColors.Control;
            panelTipo2.BackColor = SystemColors.Control;
            txtNro.Text = "";
            txtNombre.Text = "";
            cboTipo1.SelectedIndex = -1;
            cboTipo2.SelectedIndex = -1;
            txtDescripcion.Text = "";
            txtPeso.Text = "";
            txtAltura.Text = "";
            rbPrimeraGen.Checked = false;
            rbSegundaGen.Checked = false;
            rbTerceraGen.Checked = false;
            txtLVLMovimiento.Text = "";
            txtNombreMovimiento.Text = "";
            cboTipoMovimiento.SelectedIndex = -1;
            cboClaseMovimiento.SelectedIndex = -1;
            txtPoderMovimiento.Text = "";
            txtExactitudMovimiento.Text = "";
            txtPPMovimiento.Text = "";
            txtBlancoMovimiento.Text = "";
            txtDescripcionBlancoMovimiento.Text = "";
            pbFoto.Image = null;
            pbTipo1.Image = null;
            pbTipo2.Image = null;
            pbTipoMovimiento.Image = null;
            pbClaseMovimiento.Image = null;
            ttAgregarMovimiento.SetToolTip(this.btnAgregarMovimiento, "Agregar Movimiento");
            ttEliminarMovimiento.SetToolTip(this.btnEliminarMovimiento, "Eliminar Movimiento");
            ttPoder.SetToolTip(this.lblPoderMovimiento, "El poder es un valor entero entre 0 y 200");
            ttExactitud.SetToolTip(this.lblExactitudMovimiento, "La exactitud es un valor entero entre 0 y 100");
            ttPP.SetToolTip(this.lblPPMovimiento, "Los puntos de poder es un valor entero entre 0 y 100");
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            establecerEstadoComponentes();
            limpiarComponentes();
            _pokemon = new pokemon();
            _blancoSeleccionado = new blanco();
            _movimientos = new BindingList<movimientoNivel>();
            dgvMovimientosPorNivel.DataSource = _movimientos;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Inicial;
            establecerEstadoComponentes();
            limpiarComponentes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Buscar;
            establecerEstadoComponentes();

            frmBusquedaPokemons formBuscarPokemones = new frmBusquedaPokemons();
            if (formBuscarPokemones.ShowDialog() == DialogResult.OK)
            {
                _pokemon = formBuscarPokemones.Pokemon;
                MemoryStream ms = new MemoryStream(_pokemon.foto);
                pbFoto.Image = new Bitmap(ms);
                MemoryStream ms2 = new MemoryStream(_pokemon.tipo1.foto);
                pbTipo2.Image = new Bitmap(ms2);
                panelNroNombre.BackColor = Color.FromArgb(_pokemon.tipo1.valorRojo, _pokemon.tipo1.valorVerde, _pokemon.tipo1.valorAzul);
                panelTipo1.BackColor = Color.FromArgb(_pokemon.tipo1.valorRojo, _pokemon.tipo1.valorVerde, _pokemon.tipo1.valorAzul);
                cboTipo1.SelectedValue = _pokemon.tipo1.nombre;
                MemoryStream ms3 = new MemoryStream(_pokemon.tipo2.foto);
                pbTipo2.Image = new Bitmap(ms3);
                panelTipo2.BackColor = Color.FromArgb(_pokemon.tipo2.valorRojo, _pokemon.tipo2.valorVerde, _pokemon.tipo2.valorAzul);
                cboTipo2.SelectedValue = _pokemon.tipo2.nombre;
                txtDescripcion.Text = _pokemon.descripcion;
                txtPeso.Text = _pokemon.peso.ToString();
                txtAltura.Text = _pokemon.altura.ToString();
                if (_pokemon.generacion == generacion.PRIMERA_GENERACION)
                    rbPrimeraGen.Checked = true;
                if (_pokemon.generacion == generacion.SEGUNDA_GENERACION)
                    rbSegundaGen.Checked = true;
                if (_pokemon.generacion == generacion.TERCERA_GENERACION)
                    rbTerceraGen.Checked = true;
                dgvMovimientosPorNivel.DataSource = _daoServicioWeb.listarMovimientosNivelPorID(_pokemon.idPokemon);
            }
        }

        private void btnAgregarMovimiento_Click(object sender, EventArgs e)
        {
            limpiarComponentesMovimiento();

            movimientoNivel movimientoNuevo = new movimientoNivel();
            movimientoNuevo.nivelAprendizaje = Int32.Parse(txtLVLMovimiento.Text);
            movimientoNuevo.nombreMovimiento = txtNombreMovimiento.Text;
            movimientoNuevo.tipo = new tipoElemental();
            movimientoNuevo.tipo.idTipoElemental = cboTipoMovimiento.SelectedIndex;
            movimientoNuevo.clase = new clase();
            movimientoNuevo.clase.idClase = cboClaseMovimiento.SelectedIndex;
            movimientoNuevo.poder = Int32.Parse(txtPoderMovimiento.Text);
            movimientoNuevo.exactitud = Int32.Parse(txtExactitudMovimiento.Text);
            movimientoNuevo.puntosPoder = Int32.Parse(txtPPMovimiento.Text);
            movimientoNuevo.blanco = new blanco();
            movimientoNuevo.blanco.idBlanco = _blancoSeleccionado.idBlanco;
            _movimientos.Add(movimientoNuevo);

            movimientoNuevo = null;
            txtLVLMovimiento.Text = "";
            txtNombre.Text = "";
            txtPoderMovimiento.Text = "";
            txtExactitudMovimiento.Text = "";
            txtPPMovimiento.Text = "";
            _blancoSeleccionado = null;
            txtBlancoMovimiento.Text = "";
            txtDescripcionBlancoMovimiento.Text = "";
            cboTipoMovimiento.SelectedIndex = -1;
            cboClaseMovimiento.SelectedIndex = -1;
        }

        public void limpiarComponentesMovimiento()
        {
            txtLVLMovimiento.Text = "";
            txtNombreMovimiento.Text = "";
            cboTipoMovimiento.SelectedIndex = -1;
            pbTipoMovimiento.Image = null;
            cboClaseMovimiento.SelectedIndex = -1;
            pbClaseMovimiento.Image = null;
            txtPoderMovimiento.Text = "";
            txtExactitudMovimiento.Text = "";
            txtPPMovimiento.Text = "";
            txtBlancoMovimiento.Text = "";
            txtDescripcionBlancoMovimiento.Text = "";
        }

        private void cboTipo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipo1.SelectedIndex != -1)
            {
                _tipo1 = (tipoElemental)cboTipo1.SelectedItem;
                MemoryStream ms = new MemoryStream(_tipo1.foto);
                pbTipo1.Image = new Bitmap(ms);
                panelNroNombre.BackColor = Color.FromArgb(_tipo1.valorRojo, _tipo1.valorVerde, _tipo1.valorAzul);
                panelTipo1.BackColor = Color.FromArgb(_tipo1.valorRojo, _tipo1.valorVerde, _tipo1.valorAzul);
            }
        }

        private void cboTipo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipo2.SelectedIndex != -1)
            {
                _tipo2 = (tipoElemental)cboTipo1.SelectedItem;
                MemoryStream ms = new MemoryStream(_tipo2.foto);
                pbTipo2.Image = new Bitmap(ms);
                panelTipo2.BackColor = Color.FromArgb(_tipo2.valorRojo, _tipo2.valorVerde, _tipo2.valorAzul);
            }
        }

        private void cboTipoMovimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoMovimiento.SelectedIndex != -1)
            {
                _tipoMovimiento = (tipoElemental)cboTipoMovimiento.SelectedItem;
                MemoryStream ms = new MemoryStream(_tipoMovimiento.foto);
                pbTipoMovimiento.Image = new Bitmap(ms);
            }
        }

        private void btnBuscarBlanco_Click(object sender, EventArgs e)
        {
            frmBusquedaBlanco formBlancos = new frmBusquedaBlanco();
            if (formBlancos.ShowDialog() == DialogResult.OK)
            {
                _blancoSeleccionado = formBlancos.Blanco;
                txtBlancoMovimiento.Text = _blancoSeleccionado.blancoMovimiento;
                txtDescripcionBlancoMovimiento.Text = _blancoSeleccionado.descripcion;
            }
        }

        private void dgvMovimientosPorNivel_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                movimientoNivel movimientoAux = (movimientoNivel)dgvMovimientosPorNivel.Rows[e.RowIndex].DataBoundItem;

                dgvMovimientosPorNivel.Rows[e.RowIndex].Cells[0].Value = movimientoAux.nivelAprendizaje;
                dgvMovimientosPorNivel.Rows[e.RowIndex].Cells[1].Value = movimientoAux.nombreMovimiento;
                dgvMovimientosPorNivel.Rows[e.RowIndex].Cells[2].Value = movimientoAux.tipo.nombre;
                dgvMovimientosPorNivel.Rows[e.RowIndex].Cells[3].Value = movimientoAux.clase.claseMovimiento;
                dgvMovimientosPorNivel.Rows[e.RowIndex].Cells[4].Value = movimientoAux.poder;
                dgvMovimientosPorNivel.Rows[e.RowIndex].Cells[5].Value = movimientoAux.exactitud;
                dgvMovimientosPorNivel.Rows[e.RowIndex].Cells[6].Value = movimientoAux.puntosPoder;
                dgvMovimientosPorNivel.Rows[e.RowIndex].Cells[7].Value = movimientoAux.blanco.blancoMovimiento;
            }
            catch (Exception ex)
            {

            }
        }

        private void btnEliminarMovimiento_Click(object sender, EventArgs e)
        {
            if (dgvMovimientosPorNivel.CurrentRow != null)
            {
                movimientoNivel movimientoAux = (movimientoNivel)dgvMovimientosPorNivel.CurrentRow.DataBoundItem;
                _movimientos.Remove(movimientoAux);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un movimiento", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _pokemon.numeroPokedexNacional = txtNro.Text;
            _pokemon.movimientosNivel = _movimientos.ToArray();
            _pokemon.nombre = txtNombre.Text;
            _pokemon.tipo1 = new tipoElemental();
            _pokemon.tipo2 = new tipoElemental();
            _pokemon.tipo1.idTipoElemental = cboTipo1.SelectedIndex;
            _pokemon.tipo2.idTipoElemental = cboTipo2.SelectedIndex;
            _pokemon.descripcion = txtDescripcion.Text;
            _pokemon.peso = Double.Parse(txtPeso.Text);
            _pokemon.altura = Double.Parse(txtAltura.Text);
            if (rbPrimeraGen.Checked)
                _pokemon.generacion = generacion.PRIMERA_GENERACION;
            if (rbSegundaGen.Checked)
                _pokemon.generacion = generacion.SEGUNDA_GENERACION;
            if (rbTerceraGen.Checked)
                _pokemon.generacion = generacion.TERCERA_GENERACION;
            FileStream fs = new FileStream(_rutaFoto, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            _pokemon.foto = br.ReadBytes((int)fs.Length);
            fs.Close();
            int resultado = _daoServicioWeb.insertarPokemon(_pokemon);
            if (resultado != 0)
            {
                MessageBox.Show("Se ha guardado el Pokemon de forma exitosa", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _estado = Estado.Inicial;
                establecerEstadoComponentes();
            }
            else
                MessageBox.Show("Ha ocurrido un error con el registro del Pokemon", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
