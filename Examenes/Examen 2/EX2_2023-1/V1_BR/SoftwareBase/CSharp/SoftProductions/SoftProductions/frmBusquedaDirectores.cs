using SoftProductions.ProductoraWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftProductions
{
    public partial class frmBusquedaDirectores : Form
    {
        private director _directorSeleccionado;
        private ProductoraWSClient _daoProductora;
        public frmBusquedaDirectores()
        {
            InitializeComponent();
            _daoProductora = new ProductoraWSClient();
            dgvDirectores.AutoGenerateColumns = false;
        }

        public director DirectorSeleccionado { get => _directorSeleccionado; set => _directorSeleccionado = value; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvDirectores.DataSource = _daoProductora.listarDirectorPorNombre(txtNombre.Text);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if(dgvDirectores.CurrentRow.Index != -1)
            {
                _directorSeleccionado = (director)dgvDirectores.CurrentRow.DataBoundItem;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void dgvDirectores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            director dir = (director)dgvDirectores.Rows[e.RowIndex].DataBoundItem;
            dgvDirectores.Rows[e.RowIndex].Cells[0].Value = dir.nombreDirector + " " + dir.apellidoDirector;
            dgvDirectores.Rows[e.RowIndex].Cells[1].Value = dir.nacionalidad;
        }
    }
}
