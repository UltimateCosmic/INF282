using SmashSoft.ServicioWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmashSoft
{
    public partial class frmBusquedaUniverso : Form
    {
        private ServicioWSClient _daoServicioWS;
        private universo _universoSeleccionado;
        public universo UniversoSeleccionado { get => _universoSeleccionado; set => _universoSeleccionado = value; }

        public frmBusquedaUniverso()
        {
            _daoServicioWS = new ServicioWSClient();
            InitializeComponent();
            dgvUniverso.AutoGenerateColumns = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvUniverso.DataSource = _daoServicioWS.listarPorNombre(txtNombre.Text).ToList();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            UniversoSeleccionado = (universo)dgvUniverso.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void dgvUniverso_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            universo universo = (universo)dgvUniverso.Rows[e.RowIndex].DataBoundItem;
            dgvUniverso.Rows[e.RowIndex].Cells[0].Value = universo.idUniverso;
            dgvUniverso.Rows[e.RowIndex].Cells[1].Value = universo.nombre;
        }
    }
}
