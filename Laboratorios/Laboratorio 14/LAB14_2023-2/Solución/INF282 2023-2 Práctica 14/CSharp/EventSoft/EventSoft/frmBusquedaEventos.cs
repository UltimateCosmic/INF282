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
    public partial class frmBusquedaEventos : Form
    {
        private ServicioWebClient _daoEvento;
        private artista _eventoSeleccionado;

        public frmBusquedaEventos()
        {
            InitializeComponent();
            _daoEvento = new ServicioWebClient();
            dgvEventos.AutoGenerateColumns = false;
        }

        public artista EventoSeleccionado { get => _eventoSeleccionado; set => _eventoSeleccionado = value; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvEventos.DataSource = _daoEvento.listarEventosPorNombre(txtNombre.Text);
        }

        private void dgvEventos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            evento evento = (evento)dgvEventos.Rows[e.RowIndex].DataBoundItem;
            dgvEventos.Rows[e.RowIndex].Cells[0].Value = evento.nombre;
            dgvEventos.Rows[e.RowIndex].Cells[1].Value = evento.artista.nombre;
            dgvEventos.Rows[e.RowIndex].Cells[2].Value = evento.establecimiento.nombre;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            _eventoSeleccionado = (artista)dgvEventos.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }
    }
}
