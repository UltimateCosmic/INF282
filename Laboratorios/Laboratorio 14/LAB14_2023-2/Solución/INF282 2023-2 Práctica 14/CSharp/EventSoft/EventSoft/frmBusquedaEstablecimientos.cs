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
    public partial class frmBusquedaEstablecimientos : Form
    {
        private ServicioWebClient _daoEstablecimiento;
        private establecimiento _establecimientoSeleccionado;

        public frmBusquedaEstablecimientos()
        {
            InitializeComponent();
            _daoEstablecimiento = new ServicioWebClient();
            dgvEstablecimientos.AutoGenerateColumns = false;
        }

        public establecimiento EstablecimientoSeleccionado { get => _establecimientoSeleccionado; set => _establecimientoSeleccionado = value; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvEstablecimientos.DataSource = _daoEstablecimiento.listarEstablecimientosPorNombre(txtNombre.Text);
        }

        private void dgvEstablecimientos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            establecimiento establecimiento = (establecimiento)dgvEstablecimientos.Rows[e.RowIndex].DataBoundItem;
            dgvEstablecimientos.Rows[e.RowIndex].Cells[0].Value = establecimiento.nombre;
            dgvEstablecimientos.Rows[e.RowIndex].Cells[1].Value = establecimiento.capacidadAsientos;
            if (establecimiento.tieneEstacionamiento) {
                dgvEstablecimientos.Rows[e.RowIndex].Cells[2].Value = "SI";
            } else {
                dgvEstablecimientos.Rows[e.RowIndex].Cells[2].Value = "NO";
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            _establecimientoSeleccionado = (establecimiento)dgvEstablecimientos.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }
    }
}
