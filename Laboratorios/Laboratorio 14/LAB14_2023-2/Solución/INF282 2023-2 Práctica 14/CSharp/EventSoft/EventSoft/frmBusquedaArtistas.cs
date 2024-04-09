using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventSoft.ServicioWeb;

namespace EventSoft
{
    public partial class frmBusquedaArtistas : Form
    {
        private ServicioWebClient _daoArtista;
        private artista _artistaSeleccionado;

        public frmBusquedaArtistas()
        {
            InitializeComponent();
            _daoArtista = new ServicioWebClient();
            dgvArtistas.AutoGenerateColumns = false;
        }

        public artista ArtistaSeleccionado { get => _artistaSeleccionado; set => _artistaSeleccionado = value; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvArtistas.DataSource = _daoArtista.listarArtistasPorNombre(txtNombre.Text);
        }

        private void dgvArtistas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            artista artista = (artista)dgvArtistas.Rows[e.RowIndex].DataBoundItem;
            dgvArtistas.Rows[e.RowIndex].Cells[0].Value = artista.nombre;
            dgvArtistas.Rows[e.RowIndex].Cells[1].Value = artista.nacionalidad;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            _artistaSeleccionado = (artista)dgvArtistas.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }
    }
}
